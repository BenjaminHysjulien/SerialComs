
namespace SerialComs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_parity = new System.Windows.Forms.Label();
            this.label_stop_bits = new System.Windows.Forms.Label();
            this.label_bits = new System.Windows.Forms.Label();
            this.label_baud = new System.Windows.Forms.Label();
            this.label_com = new System.Windows.Forms.Label();
            this.comboBox_parity = new System.Windows.Forms.ComboBox();
            this.comboBoxs_stop = new System.Windows.Forms.ComboBox();
            this.comboBox_data = new System.Windows.Forms.ComboBox();
            this.comboBox_baud = new System.Windows.Forms.ComboBox();
            this.comboBox_Com = new System.Windows.Forms.ComboBox();
            this.button_send = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboSample = new System.Windows.Forms.ComboBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_parity);
            this.groupBox1.Controls.Add(this.label_stop_bits);
            this.groupBox1.Controls.Add(this.label_bits);
            this.groupBox1.Controls.Add(this.label_baud);
            this.groupBox1.Controls.Add(this.label_com);
            this.groupBox1.Controls.Add(this.comboBox_parity);
            this.groupBox1.Controls.Add(this.comboBoxs_stop);
            this.groupBox1.Controls.Add(this.comboBox_data);
            this.groupBox1.Controls.Add(this.comboBox_baud);
            this.groupBox1.Controls.Add(this.comboBox_Com);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(317, 208);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Options";
            // 
            // label_parity
            // 
            this.label_parity.AutoSize = true;
            this.label_parity.Location = new System.Drawing.Point(54, 174);
            this.label_parity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_parity.Name = "label_parity";
            this.label_parity.Size = new System.Drawing.Size(63, 15);
            this.label_parity.TabIndex = 9;
            this.label_parity.Text = "PARITY BIT";
            // 
            // label_stop_bits
            // 
            this.label_stop_bits.AutoSize = true;
            this.label_stop_bits.Location = new System.Drawing.Point(54, 141);
            this.label_stop_bits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_stop_bits.Name = "label_stop_bits";
            this.label_stop_bits.Size = new System.Drawing.Size(59, 15);
            this.label_stop_bits.TabIndex = 8;
            this.label_stop_bits.Text = "STOP BITS";
            // 
            // label_bits
            // 
            this.label_bits.AutoSize = true;
            this.label_bits.Location = new System.Drawing.Point(54, 107);
            this.label_bits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_bits.Name = "label_bits";
            this.label_bits.Size = new System.Drawing.Size(60, 15);
            this.label_bits.TabIndex = 7;
            this.label_bits.Text = "DATA BITS";
            // 
            // label_baud
            // 
            this.label_baud.AutoSize = true;
            this.label_baud.Location = new System.Drawing.Point(54, 74);
            this.label_baud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_baud.Name = "label_baud";
            this.label_baud.Size = new System.Drawing.Size(67, 15);
            this.label_baud.TabIndex = 6;
            this.label_baud.Text = "BAUD RATE";
            // 
            // label_com
            // 
            this.label_com.AutoSize = true;
            this.label_com.Location = new System.Drawing.Point(54, 40);
            this.label_com.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_com.Name = "label_com";
            this.label_com.Size = new System.Drawing.Size(66, 15);
            this.label_com.TabIndex = 5;
            this.label_com.Text = "COM PORT";
            // 
            // comboBox_parity
            // 
            this.comboBox_parity.FormattingEnabled = true;
            this.comboBox_parity.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBox_parity.Location = new System.Drawing.Point(148, 171);
            this.comboBox_parity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_parity.Name = "comboBox_parity";
            this.comboBox_parity.Size = new System.Drawing.Size(140, 23);
            this.comboBox_parity.TabIndex = 4;
            this.comboBox_parity.Text = "None";
            // 
            // comboBoxs_stop
            // 
            this.comboBoxs_stop.FormattingEnabled = true;
            this.comboBoxs_stop.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.comboBoxs_stop.Location = new System.Drawing.Point(148, 137);
            this.comboBoxs_stop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxs_stop.Name = "comboBoxs_stop";
            this.comboBoxs_stop.Size = new System.Drawing.Size(140, 23);
            this.comboBoxs_stop.TabIndex = 3;
            this.comboBoxs_stop.Text = "One";
            // 
            // comboBox_data
            // 
            this.comboBox_data.FormattingEnabled = true;
            this.comboBox_data.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.comboBox_data.Location = new System.Drawing.Point(148, 104);
            this.comboBox_data.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_data.Name = "comboBox_data";
            this.comboBox_data.Size = new System.Drawing.Size(140, 23);
            this.comboBox_data.TabIndex = 2;
            this.comboBox_data.Text = "8";
            // 
            // comboBox_baud
            // 
            this.comboBox_baud.FormattingEnabled = true;
            this.comboBox_baud.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200"});
            this.comboBox_baud.Location = new System.Drawing.Point(148, 70);
            this.comboBox_baud.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_baud.Name = "comboBox_baud";
            this.comboBox_baud.Size = new System.Drawing.Size(140, 23);
            this.comboBox_baud.TabIndex = 1;
            this.comboBox_baud.Text = "9600";
            // 
            // comboBox_Com
            // 
            this.comboBox_Com.FormattingEnabled = true;
            this.comboBox_Com.Location = new System.Drawing.Point(148, 37);
            this.comboBox_Com.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_Com.Name = "comboBox_Com";
            this.comboBox_Com.Size = new System.Drawing.Size(140, 23);
            this.comboBox_Com.TabIndex = 0;
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(10, 29);
            this.button_send.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(158, 23);
            this.button_send.TabIndex = 6;
            this.button_send.Text = "Send Data";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(14, 228);
            this.button_open.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(173, 70);
            this.button_open.TabIndex = 7;
            this.button_open.Text = "Open Com Port";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(13, 304);
            this.button_close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(173, 70);
            this.button_close.TabIndex = 8;
            this.button_close.Text = "Close Com Port";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 393);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(172, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 29);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 23);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sample Rate (SPS)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 375);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Progress Bar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.comboSample);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button_send);
            this.groupBox2.Location = new System.Drawing.Point(339, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 402);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Communications";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 125);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(427, 261);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // comboSample
            // 
            this.comboSample.FormattingEnabled = true;
            this.comboSample.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboSample.Location = new System.Drawing.Point(176, 66);
            this.comboSample.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboSample.Name = "comboSample";
            this.comboSample.Size = new System.Drawing.Size(140, 23);
            this.comboSample.TabIndex = 10;
            this.comboSample.Text = "5";
            this.comboSample.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 428);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_parity;
        private System.Windows.Forms.Label label_stop_bits;
        private System.Windows.Forms.Label label_bits;
        private System.Windows.Forms.Label label_baud;
        private System.Windows.Forms.Label label_com;
        private System.Windows.Forms.ComboBox comboBox_parity;
        private System.Windows.Forms.ComboBox comboBoxs_stop;
        private System.Windows.Forms.ComboBox comboBox_data;
        private System.Windows.Forms.ComboBox comboBox_baud;
        private System.Windows.Forms.ComboBox comboBox_Com;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboSample;
        private System.Windows.Forms.Timer timer2;
    }
}

