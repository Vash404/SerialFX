namespace Serial
{
    partial class CentraleFX
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CentraleFX));
            this.port = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.ProgressBar();
            this.textbox = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.version = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.ripulisci = new System.Windows.Forms.Button();
            this.auto_port = new System.Windows.Forms.TabControl();
            this.main = new System.Windows.Forms.TabPage();
            this.printTitle = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.conn_auto_list = new System.Windows.Forms.ComboBox();
            this.conn_auto_check = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.auto_port.SuspendLayout();
            this.main.SuspendLayout();
            this.settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // port
            // 
            this.port.DisplayMember = "1";
            this.port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.port.FormattingEnabled = true;
            this.port.Location = new System.Drawing.Point(8, 27);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(121, 21);
            this.port.TabIndex = 0;
            this.port.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(154, 27);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(100, 20);
            this.status.TabIndex = 1;
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(8, 60);
            this.textbox.MaxLength = 327670000;
            this.textbox.Multiline = true;
            this.textbox.Name = "textbox";
            this.textbox.ReadOnly = true;
            this.textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox.Size = new System.Drawing.Size(246, 372);
            this.textbox.TabIndex = 0;
            this.textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(267, 27);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(81, 20);
            this.connect.TabIndex = 3;
            this.connect.Text = "Connetti";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Porta";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stato";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(296, 422);
            this.version.Name = "version";
            this.version.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.version.Size = new System.Drawing.Size(61, 13);
            this.version.TabIndex = 6;
            this.version.Text = "19980722b";
            this.version.Click += new System.EventHandler(this.version_Click);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(267, 395);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(81, 23);
            this.save.TabIndex = 7;
            this.save.Text = "Salva TXT";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // ripulisci
            // 
            this.ripulisci.Enabled = false;
            this.ripulisci.Location = new System.Drawing.Point(267, 312);
            this.ripulisci.Name = "ripulisci";
            this.ripulisci.Size = new System.Drawing.Size(81, 23);
            this.ripulisci.TabIndex = 8;
            this.ripulisci.Text = "Ripulisci";
            this.ripulisci.UseVisualStyleBackColor = true;
            this.ripulisci.Click += new System.EventHandler(this.ripulisci_Click);
            // 
            // auto_port
            // 
            this.auto_port.Controls.Add(this.main);
            this.auto_port.Controls.Add(this.settings);
            this.auto_port.Location = new System.Drawing.Point(1, 0);
            this.auto_port.Margin = new System.Windows.Forms.Padding(2);
            this.auto_port.Name = "auto_port";
            this.auto_port.SelectedIndex = 0;
            this.auto_port.Size = new System.Drawing.Size(362, 463);
            this.auto_port.TabIndex = 0;
            this.auto_port.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.SystemColors.Control;
            this.main.Controls.Add(this.printTitle);
            this.main.Controls.Add(this.print);
            this.main.Controls.Add(this.port);
            this.main.Controls.Add(this.ripulisci);
            this.main.Controls.Add(this.save);
            this.main.Controls.Add(this.label1);
            this.main.Controls.Add(this.version);
            this.main.Controls.Add(this.status);
            this.main.Controls.Add(this.label2);
            this.main.Controls.Add(this.textbox);
            this.main.Controls.Add(this.connect);
            this.main.Location = new System.Drawing.Point(4, 22);
            this.main.Margin = new System.Windows.Forms.Padding(2);
            this.main.Name = "main";
            this.main.Padding = new System.Windows.Forms.Padding(2);
            this.main.Size = new System.Drawing.Size(354, 437);
            this.main.TabIndex = 0;
            this.main.Text = "Main";
            this.main.Click += new System.EventHandler(this.Main_Click);
            // 
            // printTitle
            // 
            this.printTitle.Location = new System.Drawing.Point(267, 367);
            this.printTitle.Margin = new System.Windows.Forms.Padding(2);
            this.printTitle.Name = "printTitle";
            this.printTitle.Size = new System.Drawing.Size(81, 23);
            this.printTitle.TabIndex = 10;
            this.printTitle.Text = "Stampa Titolo";
            this.printTitle.UseVisualStyleBackColor = true;
            this.printTitle.Click += new System.EventHandler(this.printTitle_Click);
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(267, 340);
            this.print.Margin = new System.Windows.Forms.Padding(2);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(81, 23);
            this.print.TabIndex = 9;
            this.print.Text = "Stampa";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.Button1_Click);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.SystemColors.Control;
            this.settings.Controls.Add(this.linkLabel1);
            this.settings.Controls.Add(this.conn_auto_list);
            this.settings.Controls.Add(this.conn_auto_check);
            this.settings.Controls.Add(this.label3);
            this.settings.Cursor = System.Windows.Forms.Cursors.Default;
            this.settings.Location = new System.Drawing.Point(4, 22);
            this.settings.Margin = new System.Windows.Forms.Padding(2);
            this.settings.Name = "settings";
            this.settings.Padding = new System.Windows.Forms.Padding(2);
            this.settings.Size = new System.Drawing.Size(354, 437);
            this.settings.TabIndex = 1;
            this.settings.Text = "Impostazioni";
            this.settings.Click += new System.EventHandler(this.Beta_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(290, 403);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.linkLabel1.Size = new System.Drawing.Size(49, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "lucche.si";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // conn_auto_list
            // 
            this.conn_auto_list.DisplayMember = "1";
            this.conn_auto_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conn_auto_list.FormattingEnabled = true;
            this.conn_auto_list.Location = new System.Drawing.Point(20, 36);
            this.conn_auto_list.Name = "conn_auto_list";
            this.conn_auto_list.Size = new System.Drawing.Size(103, 21);
            this.conn_auto_list.TabIndex = 3;
            this.conn_auto_list.SelectedIndexChanged += new System.EventHandler(this.conn_auto_list_SelectedIndexChanged);
            // 
            // conn_auto_check
            // 
            this.conn_auto_check.AutoSize = true;
            this.conn_auto_check.Location = new System.Drawing.Point(135, 39);
            this.conn_auto_check.Margin = new System.Windows.Forms.Padding(2);
            this.conn_auto_check.Name = "conn_auto_check";
            this.conn_auto_check.Size = new System.Drawing.Size(15, 14);
            this.conn_auto_check.TabIndex = 2;
            this.conn_auto_check.UseVisualStyleBackColor = true;
            this.conn_auto_check.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Connessione automatica a";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // CentraleFX
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 461);
            this.Controls.Add(this.auto_port);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CentraleFX";
            this.Text = "Seriale Centrale FX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.auto_port.ResumeLayout(false);
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar status;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox port;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button ripulisci;
        private System.Windows.Forms.TabControl auto_port;
        private System.Windows.Forms.TabPage main;
        private System.Windows.Forms.TabPage settings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox conn_auto_check;
        private System.Windows.Forms.ComboBox conn_auto_list;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button printTitle;
        private System.Windows.Forms.ImageList imageList1;
    }
}

