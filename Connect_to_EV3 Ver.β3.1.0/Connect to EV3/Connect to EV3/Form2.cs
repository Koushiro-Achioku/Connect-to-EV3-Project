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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox_COM_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.COM_port = comboBox_COM.SelectedItem.ToString();
            Properties.Settings.Default.Save();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = Properties.Settings.Default.light_mode;
            comboBox_COM.SelectedItem = Properties.Settings.Default.COM_port;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.light_mode = checkBox1.Checked;
            Properties.Settings.Default.Save();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.COM_port = textBox1.Text;
            Properties.Settings.Default.Save();
        }
        
    }
}
