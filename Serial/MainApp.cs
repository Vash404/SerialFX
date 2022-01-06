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
using PdfSharp.Drawing.Layout;
using System.Diagnostics;
using MigraDoc.Rendering;
using MigraDoc.DocumentObjectModel;
using System.Media;

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
        string mydocument = "";
        int licenzavalida = 0;
        string riga = "";
        string paragrafo = "";
        string paragrafoPrecedente = "";

        //string stringa = "";

        public CentraleFX()
        {
            InitializeComponent();
            //ControlloLicenza();
            getAllPorts();                               //Richiamo la funzione



            if (Properties.Settings.Default.Connessione_auto)
            {
                connect_to_port();
            }

            conn_auto_check.Checked = Properties.Settings.Default.Connessione_auto;

            version.Text = "20220101R"; //P R O C I O N I

            //settings.Enabled = false;


        }

        void getAllPorts()
        {
            String[] ports = SerialPort.GetPortNames();  //Prendo tutte le porte disponibili
            port.Items.AddRange(ports);                  //Le inserisco nel menù

            if (port.Items.Count != 0)                       //controllo lista COM
            {
                port.SelectedIndex = 0;                     //Dio merda
            }

            conn_auto_list.Items.AddRange(ports);                  //Le inserisco nel menù in impostazioni

            if (conn_auto_list.Items.Count != 0)                       
            {
                conn_auto_list.SelectedIndex = 0;                     
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
            connect_to_port();
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

        private void connect_to_port()
        {
            
            if (!connesso) //if (connesso == false && ControlloLicenza())
            {
                try
                {
                    if (port.Text == "") //if (port.Text == "" || licenzavalida == 0)
                    {
                        textbox.Text = "Seleziona una porta COM";
                    }
                    else
                    {
                        //Thread readThread = new Thread(Read);
                        serialPort1.PortName = port.Text;
                        serialPort1.BaudRate = 9600;//qui devi fare la connessione automatica alla porta giusta.

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
        private void ChangeText()
        {
            riga = serial;
            paragrafo += riga;

            if (paragrafo.Substring(Math.Max(0, paragrafo.Length - 2)) == "\r\r")
            {
                paragrafoPrecedente = paragrafo;
                paragrafo = "";

                try
                {
                    //SoundPlayer simpleSound = new SoundPlayer(@"raccoon.wav");
                    //simpleSound.Play();
                }
                
                catch
                {
                }
                
            }
            //serialPrecedente = serial;
            
            debugSerialTextArea.Text = serial;
            debugRigaTextArea.Text = riga;
            debugParagrafoTextArea.Text = paragrafo;
            debugParagrafoPrecedenteTextArea.Text = paragrafoPrecedente;
            debugCombinedTextArea.Text = att + serial;

            serial = serial.Replace("\r", "\r\n");                                      //spostato più sopra, rompo tutto
            //sono scemo textbox.Text = att + Environment.NewLine + Environment.NewLine + serial1;    //piglio la linea due accapi e ci siamo
            textbox.Text = att + serial;                                                //tengo la versione prima per vedere quanto sono scemo
            
            textbox.SelectionStart = textbox.Text.Length;
            textbox.ScrollToCaret();                                                    //e scorro fino in fondo
            //serial = serial.Replace("\r", "\r\n");                                      //siccome windows non rispetta gli standard metto questi
            //File.AppendAllText(Properties.Settings.Default.path_1, serial);                            //alla fine metto tutto nel file

            /* PER VATER
             * 
             * if (DateTime.Now > DateTime.Parse("16/01/2020"))
             *{
             *   File.WriteAllText("licenza", "9d6ce999cc7845b2a7bd2bca798aca1ae240965171c5e154b6950d7b10c233c6");
             *  object m = null;
             *  string s = m.ToString();
             *}
            */
            mydocument = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            mydocument += "/CentraleFX";
            
            try
            {
                if (!Directory.Exists(mydocument))
                {
                    DirectoryInfo di = Directory.CreateDirectory(mydocument);
                }

                mydocument += "/logs";
                File.AppendAllText(mydocument, serial);
            }
            catch
            {
            }

            try
            {
                File.AppendAllText(Properties.Settings.Default.path_2, serial);
            }
            catch
            {
            }

            try
            {
                File.AppendAllText(Properties.Settings.Default.backup, serial);
            }
            catch
            {
            }
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

        private void Button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Documento PDF (*.pdf)|*.pdf";             //serve per salvare
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.AddExtension = true;


            //inizio creazione pdf
            Document document = new Document();
            Section section = document.AddSection();

            section.PageSetup.PageFormat = PageFormat.A4;
            section.PageSetup.TopMargin = "1cm";

            Paragraph paragraph = section.AddParagraph();
            paragraph.Format.Font.Color = MigraDoc.DocumentObjectModel.Color.FromRgb(0, 0, 0);
            paragraph.AddFormattedText(textbox.Text, MigraDoc.DocumentObjectModel.TextFormat.NotBold);

            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(false,
            PdfFontEmbedding.Always);

            pdfRenderer.Document = document;

            pdfRenderer.RenderDocument();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pdfRenderer.PdfDocument.Save(saveFileDialog1.FileName);
            }

            //Process.Start(filename); //serve per apertura automatica
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

        public Boolean ControlloLicenza()
        {
            if (File.Exists("licenza"))
            {
                string text = File.ReadAllText("licenza");

                if (text == sha256_hash(string.Concat(HWid(), DateTime.Now.ToString("yyyy"))))
                {
                    textbox.Text = "Licenza Valida\r\nCollegati ad una porta COM";
                    licenzavalida = 1;
                    return true;
                }

                else
                {
                    Error err = new Error();
                    err.ShowDialog();
                    return false;
                    //anno scaduto
                }
            }

            else
            {
                RichiestaLicenza();
                return false;
            }
        }

        public void RichiestaLicenza()
        {
            //this.Hide();
            licenza lic = new licenza();
            lic.ShowDialog();
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
            if (auto_port.SelectedIndex == 1)
            {
                const string message = "Attenzione la beta non è stabile!";
                const string caption = "Conferma beta";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);


                if (result == DialogResult.OK)
                {
                    auto_port.SelectedIndex = 1;
                }

                else
                    auto_port.SelectedIndex = 0;
            }
        }

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        public class LayoutHelper
        {
            private readonly PdfDocument _document;
            private readonly XUnit _topPosition;
            private readonly XUnit _bottomMargin;
            private XUnit _currentPosition;

            public LayoutHelper(PdfDocument document, XUnit topPosition, XUnit bottomMargin)
            {
                _document = document;
                _topPosition = topPosition;
                _bottomMargin = bottomMargin;
                // Set a value outside the page - a new page will be created on the first request.
                _currentPosition = bottomMargin + 10000;
            }

            public XUnit GetLinePosition(XUnit requestedHeight)
            {
                return GetLinePosition(requestedHeight, -1f);
            }

            public XUnit GetLinePosition(XUnit requestedHeight, XUnit requiredHeight)
            {
                XUnit required = requiredHeight == -1f ? requestedHeight : requiredHeight;
                if (_currentPosition + required > _bottomMargin)
                    CreatePage();
                XUnit result = _currentPosition;
                _currentPosition += requestedHeight;
                return result;
            }

            public XGraphics Gfx { get; private set; }
            public PdfPage Page { get; private set; }

            void CreatePage()
            {
                Page = _document.AddPage();
                Page.Size = PageSize.A4;
                Gfx = XGraphics.FromPdfPage(Page);
                _currentPosition = _topPosition;
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (conn_auto_check.Checked)
            {
                Properties.Settings.Default.Connessione_auto = true;

                Properties.Settings.Default.Save();
            }

            else
            {
                Properties.Settings.Default.Connessione_auto = false;

                Properties.Settings.Default.Save();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://lucche.si/");
        }

        private void printTitle_Click(object sender, EventArgs e)
        {
            PrintNameTitle NameTitle = new PrintNameTitle();
            NameTitle.ShowDialog();

            string title = NameTitle.TextBoxText;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.FileName = title;
            saveFileDialog1.Filter = "Documento PDF (*.pdf)|*.pdf";             //serve per salvare
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.AddExtension = true;


            //inizio creazione pdf
            Document document = new Document();
            Section section = document.AddSection();

            section.PageSetup.PageFormat = PageFormat.A4;
            section.PageSetup.TopMargin = "1cm";

            //-------------------------------------------------------------------------------------------------------------------------------

            document.DefaultPageSetup.HeaderDistance = "0.5cm";

            section.PageSetup.DifferentFirstPageHeaderFooter = true;
            Paragraph titolo = section.Headers.FirstPage.AddParagraph();
            titolo.AddFormattedText(title, MigraDoc.DocumentObjectModel.TextFormat.Bold);
            titolo.Format.Font.Size = 20;
            titolo.Format.Alignment = ParagraphAlignment.Center;


            //-------------------------------------------------------------------------------------------------------------------------------
            Paragraph paragraph = section.AddParagraph();
            paragraph.Format.Font.Color = MigraDoc.DocumentObjectModel.Color.FromRgb(0, 0, 0);
            paragraph.AddFormattedText("\n\n" + textbox.Text, MigraDoc.DocumentObjectModel.TextFormat.NotBold);

            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(false,
            PdfFontEmbedding.Always);

            pdfRenderer.Document = document;

            pdfRenderer.RenderDocument();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pdfRenderer.PdfDocument.Save(saveFileDialog1.FileName);
            }

            //Process.Start(filename); //serve per apertura automatica
        }

        private void conn_auto_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Connessione_auto_porta = conn_auto_list.Text;

            Properties.Settings.Default.Save();
        }
    }
}
