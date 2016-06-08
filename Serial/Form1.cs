using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace Serial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getAvailablePorts();
        }

        void getAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            portNamesComboBox.Items.AddRange(ports);
        }

        private void openPortButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (portNamesComboBox.Text == "" || baudRatesComboBox.Text == "")
                {
                    receivedHereTextBox.Text = "Please select port settings.\n" + "Пожалуйста, выберите порт.";
                }
                else
                {
                    serialPort1.PortName = portNamesComboBox.Text;
                    serialPort1.BaudRate = Convert.ToInt32(baudRatesComboBox.Text);
                    serialPort1.Open();
                    statusProgressBar.Value = 100;
                    sendButton.Enabled = true;
                    readButton.Enabled = true;
                    sendHereTextBox.Enabled = true;
                    openPortButton.Enabled = false;
                    closePortButton.Enabled = true;
                }
            }
            catch(UnauthorizedAccessException)
            {
                receivedHereTextBox.Text = "Unauthorized Access";
            }
        }

        private void closePortButton_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            statusProgressBar.Value = 00;
            sendButton.Enabled = false;
            readButton.Enabled = false;
            sendHereTextBox.Enabled = false;
            openPortButton.Enabled = true;
            closePortButton.Enabled = false;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(sendHereTextBox.Text);
            sendHereTextBox.Text = "";
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            try
            {
                receivedHereTextBox.Text = serialPort1.ReadLine();
            }
            catch (TimeoutException)
            {
                receivedHereTextBox.Text = "Timeout Exception";
            }
        }
    }
}
