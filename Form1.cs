using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScalePrj1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( sender is ComboBox)
            {
                int val = (sender as ComboBox).SelectedIndex;
                if (val == 0)
                    pictureBox1.BackgroundImage = ScalePrj1.Properties.Resources.superhero0;
                if (val == 1)
                    pictureBox1.BackgroundImage = ScalePrj1.Properties.Resources.superhero1;
            }
        }
    }
}
