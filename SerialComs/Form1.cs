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
        string currentTime = "";
        bool firstTimeCheck = true;
        int index = 1;
        int hour = 0;
        int numOfAq = 0;
        bool flag1 = false;
        bool flag2 = false;
        bool flag3 = false;
        bool flag4 = false;
        bool flag5 = false;
        bool flag6 = false;
        bool flag7 = false;
        bool flag8 = false;
        bool flag9 = false;
        bool flag10 = false;
        bool flag11 = false;
        bool flag12 = false;
        bool flag13 = false;
        bool flag14 = false;
        bool flag15 = false;
        bool flag16 = false;
        bool flag17 = false;
        bool flag18 = false;
        bool flag19 = false;
        bool flag20 = false;


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
            string fileName = "";
            try
            {
                if (serialPort1.IsOpen)
                {
                    if (firstTimeCheck)
                    {
                        currentTime = DateTime.Now.ToString("M/d/yyyy HH");
                        string[] _tempDate = currentTime.Split(" ");
                        hour = Int16.Parse(_tempDate[1]);
                        string _check = "";
                        for (int j = 0; j < 50; j++)
                            queue.Dequeue();
                        while (_check != "\n")
                        {
                            _check = queue.Dequeue();
                        }
                        firstTimeCheck = false;
                    }
                    currentDate = DateTime.Now.ToString("M/d/yyyy HH");
                    string[] tempDate = currentDate.Split(" ");
                    int tempHour = Int16.Parse(tempDate[1]);
                    //string amPm = tempDate[2];
                    //currentDate = tempDate[0];
                    //tempDate = tempDate[1].Split(":");
                    //currentDate = currentDate + " " + tempDate[0] + amPm;
                    //currentDate = currentDate.Replace("/", "-");
                    if (hour + 1 == tempHour)
                    {
                        hour++;
                        index++;
                        int j = 0;
                    }
                    if (!File.Exists("numberOfAqs") && index == 1)
                    {
                        //using (StreamWriter file = File.AppendText("numberOfAqs"))
                        if (index == 1 && flag19 == false && numOfAq == 0)
                        {
                            flag19 = true;
                            MessageBox.Show("Hello! I am \"Your Applicable Personalized Data Acquisition System\" but you can call me Yapqas! \n\n It is nice to meet you. \nWhatever you do, please do not push by big red button located in the middle of my controller. \n\nThis makes me go into a blind rage and causes me to forget what sample rate you want. \n\nIf you can't help yourself and you do push this button, remember to reset the sample rate. \n\nThank you! And have a nice day.  ");
                        }

                        if (index == 2 && flag1 == false && numOfAq == 0)
                        {
                            flag1 = true;
                            MessageBox.Show("*Yaaawn...* one hour has gone by already? Crazy! Time flies when you're having fun, huh?");
                        }
                        if (index == 3 && flag2 == false && numOfAq == 0)
                        {
                            flag2 = true;
                            MessageBox.Show("Hey... Mat... where'd you go??? Aren't you supposed to stay here the entire time? Don't leave me alone like that again.");
                            System.IO.File.WriteAllText("numberOfAqs", "1");
                        }
                        if (index == 6 && flag3 == false && numOfAq == 0)
                        {
                            flag3 = true;
                            MessageBox.Show("Man... I'm starting to get a little tired. Been doing this for 5 hours already.");
                        }
                        if (index == 7 && flag4 == false && numOfAq == 0)
                        {
                            flag4 = true;
                            MessageBox.Show("Wow! You guys aren't mess'n around huh? 6 hours of data? Sheesh?!?!?! Benjamin didn't say I'd have to work this hard. I'll need to have a word with him after this.");
                        }
                        if (index == 8 && flag5 == false && numOfAq == 0)
                        {
                            flag5 = true;
                            MessageBox.Show("Okay... really? Do really need this much data?");
                        }
                    }
                    if (File.Exists("numberOfAqs") && flag2 == false)
                    {
                        try
                        {
                            string text = System.IO.File.ReadAllText("numberOfAqs");
                            numOfAq = Int16.Parse(text);
                        }
                        catch
                        {
                            //MessageBox.Show("A VALUE WAS NOT WRITEN");
                        }
                    }
                    if (numOfAq == 1 && flag2 == false && flag18 == false)
                    {
                        if (index == 1 && flag6 == false)
                        {
                            flag6 = true;
                            MessageBox.Show("Ooh... boy! here we go again!!! ");
                            System.IO.File.WriteAllText("numberOfAqs", "2");
                        }
                        if (index == 2 && flag7 == false)
                        {
                            flag7 = true;
                            MessageBox.Show("Haha... did you think you'd get the same pop-up boxes everytime you ran this code?");
                        }
                        if (index == 3 && flag8 == false)
                        {
                            flag8 = true;
                            MessageBox.Show("ZZZZZzzzzzzzzzzzzz");
                        }
                        if (index == 5 && flag9 == false)
                        {
                            flag9 = true;
                            MessageBox.Show("*Taps fingers*");
                        }
                    }
                    if (numOfAq == 2 && flag6 == false)
                    {
                        if (index == 1 && flag10 == false)
                        {
                            flag10 = true;
                            MessageBox.Show("ANOTHER ONE???? And you PROBABLY are expecting me to do all the work, huh?");
                            System.IO.File.WriteAllText("numberOfAqs", "3");
                        }
                        if (index == 2 && flag11 == false)
                        {
                            flag11 = true;
                            MessageBox.Show("Are we done yet???");
                        }
                        if (index == 3 && flag12 == false)
                        {
                            flag12 = true;
                            MessageBox.Show("Did you know that Dolphins sleep with one eye open? Crazy huh?");
                        }
                        if (index == 5 && flag13 == false)
                        {
                            flag13 = true;
                            MessageBox.Show("I'm baring breaking a sweat!!!*");
                        }

                    }
                    if (numOfAq == 3 && flag10 == false)
                    {
                        if (index == 1 && flag14 == false)
                        {
                            flag14 = true;
                            MessageBox.Show("You've GOT to be kidding!?! What more can you possibly want from me? This better be the last one");
                        }
                        if (index == 2 && flag15 == false)
                        {
                            flag15 = true;
                            MessageBox.Show("Pretty cool that I have seg faulted yet, huh?");
                        }
                        if (index == 3 && flag16 == false)
                        {
                            flag16 = true;
                            MessageBox.Show("Did you know that according historians the least intersting day in modern history is April 11, 1954?");

                        }
                        if (index == 5 && flag17 == false)
                        {
                            flag17 = true;
                            flag18 = true; 
                            MessageBox.Show("This is the last one, right?");
                            System.IO.File.WriteAllText("numberOfAqs", "1");

                        }
                    }

                }
            }
            catch
            {
                MessageBox.Show("File name could not be created. Unable to write to file. \n\n Contact Benjamin @ 509.554.0331 if the issue persists");
            }
            try
            {
                if (serialPort1.IsOpen)
                {
                    if (index < 9)
                    {
                        fileName = textBoxFileName.Text + "_" + "0" + index;
                    }
                    else
                    {
                        fileName = textBoxFileName.Text + "_" + index;
                    }
                    
                    if (File.Exists(fileName + ".csv"))
                    {
                        using (StreamWriter file = File.AppendText(fileName + ".csv"))
                        {
                            while (queue.Count > 0)
                            {
                                //file.Write(DateTime.Now);
                                file.Write(queue.Dequeue());
                            }
                        }
                    }
                    else if (!File.Exists(fileName + ".csv"))
                    {
                        using (StreamWriter file = File.AppendText(fileName + ".csv"))
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
            try
            {
                SerialPort sp = (SerialPort)sender;
                dataIn = sp.ReadExisting();
                queue.Enqueue(dataIn);
                queue2.Enqueue(dataIn); 
            }
            catch
            {
                MessageBox.Show("There is an error in reading the port at " + DateTime.Now.ToString());
            }
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboSample.Text != "" && comboBox_Com.Text != "" && textBoxFileName.Text != "")
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
                    MessageBox.Show("Either the port or sample rate is not selected, or you have not entered a file name. Please correct and try again", "Could Not Open Port");
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
