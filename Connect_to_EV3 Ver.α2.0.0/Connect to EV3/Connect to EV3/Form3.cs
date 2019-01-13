using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Connect_to_EV3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)//up
            {
                button_up.Image = Properties.Resources.up_on;
            }
            if (e.KeyCode == Keys.A)//left
            {
                button_left.Image = Properties.Resources.left_on;
            }
            if (e.KeyCode == Keys.X)//down
            {
                button_down.Image = Properties.Resources.down_on;
            }
            if (e.KeyCode == Keys.D)//right
            {
                button_right.Image = Properties.Resources.right_on;
            }
        }

        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)//up
            {
                button_up.Image = Properties.Resources.up;
            }
            if (e.KeyCode == Keys.A)//left
            {
                button_left.Image = Properties.Resources.left;
            }
            if (e.KeyCode == Keys.X)//down
            {
                button_down.Image = Properties.Resources.down;
            }
            if (e.KeyCode == Keys.D)//right
            {
                button_right.Image = Properties.Resources.right;
            }
        }

        private void Form3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'S')//center
            {

            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }
    }
}
