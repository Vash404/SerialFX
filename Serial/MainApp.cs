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
using System.Data.SQLite;
using System.Management;
using System.Security.Cryptography;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

/*
 *  Implementata Licenza
 *  
 *  Sistemare chiusura finestre (chiusura e creazione nuove finestre >>) Fatto più o meno
 *  passa il mouse su this per il nome vero
 *   
 *  Nei settings mettere queste cose:
 *  - possibilità scelta dove salvare il file log
 *  - autoconnect
 *  - FILE PDF
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
        int licenzavalida = 0;

        
        //string stringa = "";

        public CentraleFX()
        {
            InitializeComponent();
            OpenLicenza();
            getAllPorts();                               //Richiamo la funzione

            version.Text = DateTime.Now.ToString("dd/MM");

            beta.Enabled = false;


        }

        void getAllPorts()
        {
            String[] ports = SerialPort.GetPortNames();  //Prendo tutte le porte disponibili
            port.Items.AddRange(ports);                  //Le inserisco nel menù

            if (port.Items.Count != 0)                       //controllo lista COM
            {
                port.SelectedIndex = 0;                     //Dio merda
            }

            comboBox1.Items.Add("NESSUNA");
            comboBox1.Items.AddRange(ports);                  //Le inserisco nel menù in impostazioni

            if (comboBox1.Items.Count != 0)                       
            {
                comboBox1.SelectedIndex = 0;                     
            }

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("msg", "cap", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            OpenLicenza();

            if (connesso == false)
            {
                try
                {
                    if (port.Text == "" || licenzavalida == 0)
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
            File.AppendAllText("CentraleFXlogTEST.txt", serial);                            //alla fine metto tutto nel file
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













            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";

            // Create an empty page
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font
            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);

            // Draw the text
            gfx.DrawString(textbox.Text, font, XBrushes.Black,
              new XRect(0, 0, page.Width, page.Height),
              XStringFormats.Center);

            // Save the document...
            const string filename = "HelloWorld.pdf";
            document.Save(filename);
















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

                if (text == sha256_hash(string.Concat(HWid(), DateTime.Now.ToString("yyyy"))))
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
                //this.Hide();
                licenza lic = new licenza();
                lic.ShowDialog();
            }

            else
            {
                textbox.Text = "Licenza Valida\r\nCollegati ad una porta COM";
                licenzavalida = 1;
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
            
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                const string message = "Attenzione la beta non è stabile!";
                const string caption = "Conferma beta";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);


                if (result == DialogResult.OK)
                {
                    tabControl1.SelectedIndex = 1;
                }

                else
                    tabControl1.SelectedIndex = 0;
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
