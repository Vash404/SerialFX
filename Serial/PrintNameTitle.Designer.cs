namespace Serial
{
    partial class PrintNameTitle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titoloStampa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sendName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titoloStampa
            // 
            this.titoloStampa.Location = new System.Drawing.Point(17, 64);
            this.titoloStampa.Name = "titoloStampa";
            this.titoloStampa.Size = new System.Drawing.Size(253, 20);
            this.titoloStampa.TabIndex = 0;
            this.titoloStampa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.titoloStampa_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserisci titolo stampa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "lascia vuoto per non inserire il titolo";
            // 
            // sendName
            // 
            this.sendName.Location = new System.Drawing.Point(17, 90);
            this.sendName.Name = "sendName";
            this.sendName.Size = new System.Drawing.Size(253, 23);
            this.sendName.TabIndex = 3;
            this.sendName.Text = "Salva";
            this.sendName.UseVisualStyleBackColor = true;
            this.sendName.Click += new System.EventHandler(this.sendName_Click);
            // 
            // PrintNameTitle
            // 
            this.AcceptButton = this.sendName;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 119);
            this.Controls.Add(this.sendName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titoloStampa);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(298, 158);
            this.MinimumSize = new System.Drawing.Size(298, 158);
            this.Name = "PrintNameTitle";
            this.ShowInTaskbar = false;
            this.Text = "Titolo Stampa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titoloStampa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendName;
    }
}