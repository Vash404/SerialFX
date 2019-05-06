using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Timers;
using System.IO;
using System.Threading;
using IronPdf;
using System.Data.SQLite;
using System.Management;
using System.Security.Cryptography;
/*
 *  Implementata Licenza
 *  
 *  Sistemare chiusura finestre (chiusura e creazione nuove finestre >>) Fatto più o meno
 *  passa il mouse su this per il nome vero
 *   
 * 
 */
namespace Serial
{
    public partial class CentraleFX : Form
    {
        private delegate void delegato();               //delegato per cambio testo
        //private TextBox textBox1;

        Boolean connesso = false;
        string att = "";                                //inizalizzo variabili globali
        string serial = "";

        DataTable dt = new DataTable("nomedellatabella");
        BindingSource bs = new BindingSource();
        //string stringa = "";

        public CentraleFX()
        {
            InitializeComponent();
            OpenLicenza();
            getAllPorts();                               //Richiamo la funzione

            //SQLiteConnection.CreateFile("MyDatabase.sqlite");

            version.Text = "0.6b";
        }

        void getAllPorts()
        {
            String[] ports = SerialPort.GetPortNames();  //Prendo tutte le porte disponibili
            port.Items.AddRange(ports);                  //Le inserisco nel menù

            if (port.Items.Count != 0)                       //controllo lista COM
            {
                port.SelectedIndex = 0;                     //Dio merda
            }

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("msg", "cap", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            dt.Columns.Add("id");
            dt.Columns.Add("centrale");
            dt.Columns.Add("evento");
            dt.Columns.Add("stanza");
            dt.Columns.Add("zona");
            dt.Columns.Add("loop");
            dt.Columns.Add("sensore");
            dt.Columns.Add("data");
            dt.Columns.Add("ora");
            dt.Columns.Add("testo");
            dt.Columns["id"].AutoIncrement = true;
            dt.Columns["id"].AutoIncrementStep = 1;
            bs.DataSource = dt;
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            OpenLicenza();

            if (connesso == false)
            {
                try
                {
                    if (port.Text == "")
                    {
                        textbox.Text = "Seleziona una porta COM";
                    }
                    else
                    {
                        //Thread readThread = new Thread(Read);

                        serialPort1.PortName = port.Text;
                        serialPort1.BaudRate = 9600;

                        status.Value = 100;
                        textbox.Text = "";
                        connesso = true;
                        //connect.Enabled = false;
                        connect.Text = "Disconnetti";
                        save.Enabled = true;
                        ripulisci.Enabled = true;
                        serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                        serialPort1.Open();
                    }
                }
                catch (UnauthorizedAccessException)
                {

                    textbox.Text = "Errore";
                }
            }
            else
            {
                serialPort1.Close();
                connesso = false;
                status.Value = 0;
                connect.Text = "Connetti";
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (connesso == true)                   //se è connesso avvia funzione
            {
                ReadSerialFile();
            }
        }

        private void ReadSerialFile()
        {
            att = textbox.Text;                                     //prendo valori correnti
            try
            {
                serial = serialPort1.ReadLine();                        //leggo seriale
            }
            catch (Exception)

            {

            }

            Console.WriteLine(serial);
            Application.DoEvents();

            delegato delegato1 = ChangeText;                      //chiedo al delegato di avviare la funzione
            textbox.Invoke(delegato1);                            //do un calcio al delegato per farlo partire perchè sennò sta li fermo a girarsi i pollici
            //serial = serial.Replace("\r", "\r\n");              //controllo a capo centraleFX, lo fa il delegato perchè lo pago abbastanza
        }
        private void ChangeText()
        {
            textbox.Text = att + Environment.NewLine + Environment.NewLine + serial;    //piglio la linea due accapi e ci siamo
            textbox.SelectionStart = textbox.Text.Length;
            textbox.ScrollToCaret();                                                    //e scorro fino in fondo
            serial = serial.Replace("\r", "\r\n");                                      //siccome windows non rispetta gli standard metto questi
            File.AppendAllText("CentraleFXlog.txt", serial);                            //alla fine metto tutto nel file
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (CloseCancel() == false)
            {
                e.Cancel = true;
            };
        }

        public bool CloseCancel() //necessita static?
        {
            const string message = "Sei sicuro di voler chiudere il programma?";
            const string caption = "Conferma Chiusura";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                return true;
            }

            else
                return false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void version_Click(object sender, EventArgs e)
        {
            //textbox.Text = DateTime.Today.ToString();
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "File di testo (*.txt)|*.txt";             //serve per salvare
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.AddExtension = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textbox.Text);
            }
        }

        private void ripulisci_Click(object sender, EventArgs e)
        {
            textbox.Text = "";
        }

        public static String sha256_hash(String value)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }

        public static String HWid()
        {
            var mbs = new ManagementObjectSearcher("Select ProcessorId From Win32_processor");
            ManagementObjectCollection mbsList = mbs.Get();
            string id = "";
            foreach (ManagementObject mo in mbsList)
            {
                id = mo["ProcessorId"].ToString();
                break;
            }

            return id.ToString();
        }

        public static Boolean ControlloLicenza()
        {
            if (File.Exists("licenza"))
            {
                string text = File.ReadAllText("licenza");

                if (text == sha256_hash(HWid()))
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

            else
            {
                return false;
            }
        }

        public void OpenLicenza()
        {
            if (!ControlloLicenza())
            {
                this.Hide();
                licenza lic = new licenza();
                lic.ShowDialog();
                this.Close();
            }

            else
            {
                textbox.Text = "Licenza Valida\r\nCollegati au una porta COM";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textbox.Text = sha256_hash(HWid());
        }

        private void closeconn(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Click(object sender, EventArgs e)
        {

        }

        private void Beta_Click(object sender, EventArgs e)
        {

        }

        private void TabControl1_Selected(Object sender, TabControlEventArgs e)
        {
            const string message = "Attenzione la beta non è stabile!";
            const string caption = "Conferma beta";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                tabControl1.SelectedIndex = 1;
            }

            else
                tabControl1.SelectedIndex = 0;
        }
    }
}
