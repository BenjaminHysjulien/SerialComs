using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;
using System.Timers;
using System.Globalization;

namespace SerialComs
{
    public partial class Form1 : Form
    {
//        List<int> DataIn = new List<int>();
        List<string> DataIn = new List<string>();
        Queue<string> queue = new Queue<string>();
        Queue<string> queue2 = new Queue<string>();
        string dataIn;
        string dataOut;
        string currentDate;
        int sampleRate = 0;
        string richUpdate = "";
        public Form1()
        {
            InitializeComponent();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 10000;
            timer1.Start();
            timer2 = new System.Windows.Forms.Timer();
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Interval = 50;
            timer2.Start();
            if (comboSample.Text != "" && comboBox_Com.Text != "")
            {
                button_open.Enabled = true;
            }
            else
            {
                //button_open.Enabled = false; 
            }
        }


        private void check()
        {
            if (comboSample.Text != "" && comboBox_Com.Text != "")
            {
                button_open.Enabled = true;
            }
            else
            {
                button_open.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saveData();
        }
        private void saveData()
        {
            currentDate = DateTime.Now.ToString();
            string[] tempDate = currentDate.Split(" ");
            string amPm = tempDate[2];
            currentDate = tempDate[0];
            tempDate = tempDate[1].Split(":");
            currentDate = currentDate + " " + tempDate[0] + amPm;
            currentDate = currentDate.Replace("/", "-");
            try
            {
                if (serialPort1.IsOpen)
                {
                    if (File.Exists(currentDate + ".csv"))
                    {
                        using (StreamWriter file = File.AppendText(currentDate + ".csv"))
                        {
                            while (queue.Count > 0)
                            {
                                //file.Write(DateTime.Now);
                                file.Write(queue.Dequeue());
                            }
                        }
                    }
                    else if (!File.Exists(currentDate + ".csv"))
                    {
                        using (StreamWriter file = File.AppendText(currentDate + ".csv"))
                        {
                            while (queue.Count > 0)
                            {
                                // file.Write(DateTime.Now);
                                file.Write(queue.Dequeue());
                            }
                        }
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("The file could not be open for writing. If the file is open, please close the file so data logging can continue. \n\nIf the file is not open, please contact Benjamin @ 509-554-0331 \n\n This error occured at:" + DateTime.Now.ToString(), "Could Not Open File For Writing");
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            dataIn = sp.ReadExisting();
            queue.Enqueue(dataIn);
            queue2.Enqueue(dataIn);
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboSample.Text != "" && comboBox_Com.Text != "")
                {
                    currentDate = DateTime.Now.ToString();
                    string[] tempDate = currentDate.Split(" ");
                    string amPm = tempDate[2];
                    currentDate = tempDate[0];
                    tempDate = tempDate[1].Split(":");
                    currentDate = currentDate + " " + tempDate[0] + amPm;
                    currentDate = currentDate.Replace("/", "-");
                    DateTime localDate = DateTime.Now;
                    serialPort1.PortName = comboBox_Com.Text;
                    serialPort1.PortName = comboBox_Com.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox_baud.Text);
                    serialPort1.DataBits = Convert.ToInt32(comboBox_data.Text);
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBoxs_stop.Text);
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), comboBox_parity.Text);
                    serialPort1.Handshake = Handshake.None;
                    serialPort1.Open();
                    progressBar1.Value = 100;
                    string message = localDate.ToString() + " " + comboSample.Text;
                    serialPort1.Write(message);
                }
                else
                {
                    MessageBox.Show("Either the port or sample rate is not selected. Please select one and try again", "Could Not Open Port");
                }
            }
            catch
            {
                MessageBox.Show("An unkown error has occured while opening the port. Contact Benjamin @ 509-554-0331 if data logging has stopped. \n\n This error occured at: " + DateTime.Now.ToString() , "Could Not Open Port");
            }
        }
            
        private void button_send_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOut = textBox1.Text;
                serialPort1.Write(dataOut);
                serialPort1.WriteLine("\x44\x31\x0D");
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox_Com.Items.AddRange(ports);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox_Com.Items.AddRange(ports);
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            progressBar1.Value = 0; 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try {
                while (queue2.Count > 0)
                {
                    richUpdate = richUpdate + queue2.Dequeue();

                    int count = 0;
                    int len = richUpdate.Length;
                    for (int i = 0; i != len; ++i)
                        switch (richUpdate[i])
                        {
                            case '\r':
                                ++count;
                                if (i + 1 != len && richUpdate[i + 1] == '\n')
                                    ++i;
                                break;
                            case '\n':
                                // Uncomment below to include all other line break sequences
                                // case '\u000A':
                                // case '\v':
                                // case '\f':
                                // case '\u0085':
                                // case '\u2028':
                                // case '\u2029':
                                ++count;
                                break;
                        }
                    int x = 0;
                    if (count > 16)
                    {

                        bool posFlag = false;
                        for (int i = 0; i != len; ++i)
                            if (posFlag == false)
                            {
                                switch (richUpdate[i])
                                {
                                    case '\r':
                                        x = i;
                                        int j = i;
                                        x = j;
                                        posFlag = true;
                                        if (i + 1 != len && richUpdate[i + 1] == '\n')
                                        {
                                            ++i;
                                        }
                                        break;
                                    case '\n':
                                        // Uncomment below to include all other line break sequences
                                        // case '\u000A':
                                        // case '\v':
                                        // case '\f':
                                        // case '\u0085':
                                        // case '\u2028':
                                        // case '\u2029':

                                        posFlag = true;
                                        int z = i;
                                        x = z;
                                        break;
                                }
                            }
                        if (x >= 0)
                        {
                            richUpdate = richUpdate.Remove(0, x + 2);
                        }
                        richTextBox1.Text = richUpdate;
                    }
                    else
                        richTextBox1.Text = richUpdate;
                }
               
            }
            catch { }
        }
    }
}
