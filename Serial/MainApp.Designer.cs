﻿namespace Serial
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.main = new System.Windows.Forms.TabPage();
            this.beta = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.main.SuspendLayout();
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
            this.status.Location = new System.Drawing.Point(154, 25);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(100, 21);
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
            this.textbox.Size = new System.Drawing.Size(248, 356);
            this.textbox.TabIndex = 0;
            this.textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(276, 27);
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
            this.version.Location = new System.Drawing.Point(331, 408);
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
            this.save.Location = new System.Drawing.Point(276, 379);
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
            this.ripulisci.Location = new System.Drawing.Point(276, 349);
            this.ripulisci.Name = "ripulisci";
            this.ripulisci.Size = new System.Drawing.Size(75, 23);
            this.ripulisci.TabIndex = 8;
            this.ripulisci.Text = "Ripulisci";
            this.ripulisci.UseVisualStyleBackColor = true;
            this.ripulisci.Click += new System.EventHandler(this.ripulisci_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.main);
            this.tabControl1.Controls.Add(this.beta);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(364, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.SystemColors.Control;
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
            this.main.Size = new System.Drawing.Size(356, 422);
            this.main.TabIndex = 0;
            this.main.Text = "Main";
            this.main.Click += new System.EventHandler(this.Main_Click);
            // 
            // beta
            // 
            this.beta.BackColor = System.Drawing.SystemColors.Control;
            this.beta.Cursor = System.Windows.Forms.Cursors.Default;
            this.beta.Location = new System.Drawing.Point(4, 22);
            this.beta.Margin = new System.Windows.Forms.Padding(2);
            this.beta.Name = "beta";
            this.beta.Padding = new System.Windows.Forms.Padding(2);
            this.beta.Size = new System.Drawing.Size(356, 422);
            this.beta.TabIndex = 1;
            this.beta.Text = "BETA";
            this.beta.Click += new System.EventHandler(this.Beta_Click);
            // 
            // CentraleFX
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 447);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CentraleFX";
            this.Text = "Seriale Centrale FX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage main;
        private System.Windows.Forms.TabPage beta;
    }
}

