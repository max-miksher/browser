using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addressBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void addressBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());

            if (e.KeyCode == Keys.Return)
            {
                MessageBox.Show(e.KeyCode.ToString());
            }
        }
    }
}
