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
            this.SuspendLayout();
            // 
            // port
            // 
            this.port.DisplayMember = "1";
            this.port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.port.FormattingEnabled = true;
            this.port.Location = new System.Drawing.Point(8, 32);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(121, 21);
            this.port.TabIndex = 0;
            this.port.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(156, 32);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(100, 21);
            this.status.TabIndex = 1;
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(8, 68);
            this.textbox.MaxLength = 327670000;
            this.textbox.Multiline = true;
            this.textbox.Name = "textbox";
            this.textbox.ReadOnly = true;
            this.textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox.Size = new System.Drawing.Size(248, 370);
            this.textbox.TabIndex = 0;
            this.textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(275, 32);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 21);
            this.connect.TabIndex = 3;
            this.connect.Text = "Connetti";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Porta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stato";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(339, 434);
            this.version.Name = "version";
            this.version.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.version.Size = new System.Drawing.Size(60, 13);
            this.version.TabIndex = 6;
            this.version.Text = "<Versione>";
            this.version.Click += new System.EventHandler(this.version_Click);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(275, 402);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 7;
            this.save.Text = "Salva";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // ripulisci
            // 
            this.ripulisci.Enabled = false;
            this.ripulisci.Location = new System.Drawing.Point(275, 373);
            this.ripulisci.Name = "ripulisci";
            this.ripulisci.Size = new System.Drawing.Size(75, 23);
            this.ripulisci.TabIndex = 8;
            this.ripulisci.Text = "Ripulisci";
            this.ripulisci.UseVisualStyleBackColor = true;
            this.ripulisci.Click += new System.EventHandler(this.ripulisci_Click);
            // 
            // CentraleFX
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 447);
            this.Controls.Add(this.ripulisci);
            this.Controls.Add(this.save);
            this.Controls.Add(this.version);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.status);
            this.Controls.Add(this.port);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CentraleFX";
            this.Text = "Seriale Centrale FX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

