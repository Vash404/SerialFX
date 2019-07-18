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
            this.print = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.TabPage();
            this.conn_auto_list = new System.Windows.Forms.ComboBox();
            this.conn_auto_check = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            this.port.Location = new System.Drawing.Point(11, 33);
            this.port.Margin = new System.Windows.Forms.Padding(4);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(160, 24);
            this.port.TabIndex = 0;
            this.port.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(205, 33);
            this.status.Margin = new System.Windows.Forms.Padding(4);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(133, 24);
            this.status.TabIndex = 1;
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(11, 74);
            this.textbox.Margin = new System.Windows.Forms.Padding(4);
            this.textbox.MaxLength = 327670000;
            this.textbox.Multiline = true;
            this.textbox.Name = "textbox";
            this.textbox.ReadOnly = true;
            this.textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox.Size = new System.Drawing.Size(327, 437);
            this.textbox.TabIndex = 0;
            this.textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(356, 33);
            this.connect.Margin = new System.Windows.Forms.Padding(4);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(100, 24);
            this.connect.TabIndex = 3;
            this.connect.Text = "Connetti";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Porta";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stato";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(393, 502);
            this.version.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.version.Name = "version";
            this.version.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.version.Size = new System.Drawing.Size(80, 17);
            this.version.TabIndex = 6;
            this.version.Text = "19980722b";
            this.version.Click += new System.EventHandler(this.version_Click);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(356, 466);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 28);
            this.save.TabIndex = 7;
            this.save.Text = "Salva TXT";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // ripulisci
            // 
            this.ripulisci.Enabled = false;
            this.ripulisci.Location = new System.Drawing.Point(356, 396);
            this.ripulisci.Margin = new System.Windows.Forms.Padding(4);
            this.ripulisci.Name = "ripulisci";
            this.ripulisci.Size = new System.Drawing.Size(100, 28);
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
            this.auto_port.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.auto_port.Name = "auto_port";
            this.auto_port.SelectedIndex = 0;
            this.auto_port.Size = new System.Drawing.Size(485, 551);
            this.auto_port.TabIndex = 0;
            this.auto_port.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.SystemColors.Control;
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
            this.main.Location = new System.Drawing.Point(4, 25);
            this.main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.main.Name = "main";
            this.main.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.main.Size = new System.Drawing.Size(477, 522);
            this.main.TabIndex = 0;
            this.main.Text = "Main";
            this.main.Click += new System.EventHandler(this.Main_Click);
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(356, 431);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(100, 28);
            this.print.TabIndex = 9;
            this.print.Text = "Stampa";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.Button1_Click);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.SystemColors.Control;
            this.settings.Controls.Add(this.conn_auto_list);
            this.settings.Controls.Add(this.conn_auto_check);
            this.settings.Controls.Add(this.label3);
            this.settings.Cursor = System.Windows.Forms.Cursors.Default;
            this.settings.Location = new System.Drawing.Point(4, 25);
            this.settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settings.Name = "settings";
            this.settings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settings.Size = new System.Drawing.Size(477, 522);
            this.settings.TabIndex = 1;
            this.settings.Text = "Impostazioni";
            this.settings.Click += new System.EventHandler(this.Beta_Click);
            // 
            // conn_auto_list
            // 
            this.conn_auto_list.DisplayMember = "1";
            this.conn_auto_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conn_auto_list.FormattingEnabled = true;
            this.conn_auto_list.Location = new System.Drawing.Point(26, 44);
            this.conn_auto_list.Margin = new System.Windows.Forms.Padding(4);
            this.conn_auto_list.Name = "conn_auto_list";
            this.conn_auto_list.Size = new System.Drawing.Size(136, 24);
            this.conn_auto_list.TabIndex = 3;
            // 
            // conn_auto_check
            // 
            this.conn_auto_check.AutoSize = true;
            this.conn_auto_check.Location = new System.Drawing.Point(180, 48);
            this.conn_auto_check.Name = "conn_auto_check";
            this.conn_auto_check.Size = new System.Drawing.Size(18, 17);
            this.conn_auto_check.TabIndex = 2;
            this.conn_auto_check.UseVisualStyleBackColor = true;
            this.conn_auto_check.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Connessione automatica a";
            // 
            // CentraleFX
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 550);
            this.Controls.Add(this.auto_port);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}

