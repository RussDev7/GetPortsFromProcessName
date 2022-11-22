﻿using System;
using System.Windows.Forms;

namespace GetTerrariaLocalPort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Get the local address of the process dynamically.
        private void button1_Click(object sender, EventArgs e)
        {
            if (TcpConnectionInfo.TryGetLocalPort(textBox1.Text, out ushort outPort) != 0)
            {
                MessageBox.Show("ERROR: The " + outPort + " proccess was not found.");
            }
            else
            {
                MessageBox.Show("ERROR: The " + textBox1.Text + " proccess was not found.");
            }
        }
    }
}
