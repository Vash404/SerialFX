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
            getAllPorts();                               //Richiamo la funzione
            
            version.Text = "0.5b";            
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
                        connect.Enabled = false;
                        //connect.Text = "Disconnetti";
                        save.Enabled = true;
                        ripulisci.Enabled = true;
                        serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                        serialPort1.Open();
                    
                        //readThread.Start();

                        //this.Invoke(new EventHandler(ChangeText));

                        /*System.Timers.Timer timer = new System.Timers.Timer(TimeSpan.FromSeconds(1).TotalMilliseconds);
                        timer.AutoReset = true;
                        timer.Elapsed += new System.Timers.ElapsedEventHandler(Leggi);
                        timer.Start();*/

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

        /*private void Leggi(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Letto!");
            try
            {
                
                this.Invoke(new EventHandler(ChangeText));

            }
            catch (TimeoutException)
            {

                textBox1.Text = "Timeout";
            }
        }*/

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //if (!chiusura) {
            //    this.Invoke(new EventHandler(ChangeText));
            //}
            //else
            //{
            //    serialPort1.Close();
            //    serialPort1.Dispose();
            //}
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
            } catch (Exception)

            {
                //serialPort1.Dispose();
                //serialPort1.Close();
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

        private void label2_Click(object sender, EventArgs e)
        {
            var Renderer = new IronPdf.HtmlToPdf();
            var PDF = Renderer.RenderHTMLFileAsPdf("test.html");

            Renderer.PrintOptions.Footer = new HtmlHeaderFooter()
            {
                Height = 15,
                HtmlFragment = "<center><i>{page} of {total-pages}<i></center>",
                DrawDividerLine = true
            };

            var OutputPath = "Invoice.pdf";
            PDF.SaveAs(OutputPath);
        }

        private void closeconn(object sender, EventArgs e)
        {
            serialPort1.Close();                                                
        }
        
    }
}
