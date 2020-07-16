using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serial
{
    public partial class PrintNameTitle : Form
    {
        public PrintNameTitle()
        {
            InitializeComponent();
        }

        public string TextBoxText
        {
            get { return titoloStampa.Text; }
            set { titoloStampa.Text = value; }
        }

        private void sendName_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();//sendName_Click(this, new EventArgs());
        }

        private void titoloStampa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                sendName_Click(this, new EventArgs());
            }
        }
    }
}
