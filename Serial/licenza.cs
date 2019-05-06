using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Serial
{
    public partial class licenza : Form
    {
        int click = 0;

        public licenza()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            if (click == 10)
            {
                text1.Text = Serial.CentraleFX.sha256_hash(Serial.CentraleFX.HWid());
            }
            else
            {
                click++;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("licenza", text1.Text);

            this.Hide();

            CentraleFX CFX = new CentraleFX();
            CFX.ShowDialog();
            this.Close();
        }
    }
}
