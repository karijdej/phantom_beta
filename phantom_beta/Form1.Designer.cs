namespace phantom_beta
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.startButton = new System.Windows.Forms.Button();
            this.testLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.heaterCheck = new System.Windows.Forms.CheckBox();
            this.lampCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM6";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(388, 320);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Current Temp (C)";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(126, 100);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 20);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Heater";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(126, 128);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(70, 20);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Lamps";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(126, 347);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(154, 33);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start Test";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // testLength
            // 
            this.testLength.Location = new System.Drawing.Point(126, 228);
            this.testLength.Name = "testLength";
            this.testLength.Size = new System.Drawing.Size(67, 22);
            this.testLength.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Test Length (min)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(126, 282);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(67, 22);
            this.textBox3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sampling Interval (sec)";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(126, 154);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(56, 20);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "Both";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // heaterCheck
            // 
            this.heaterCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.heaterCheck.AutoSize = true;
            this.heaterCheck.Location = new System.Drawing.Point(399, 208);
            this.heaterCheck.Name = "heaterCheck";
            this.heaterCheck.Size = new System.Drawing.Size(58, 26);
            this.heaterCheck.TabIndex = 14;
            this.heaterCheck.Text = "Heater";
            this.heaterCheck.UseVisualStyleBackColor = true;
            this.heaterCheck.CheckedChanged += new System.EventHandler(this.heaterCheck_CheckedChanged);
            // 
            // lampCheck
            // 
            this.lampCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.lampCheck.AutoSize = true;
            this.lampCheck.Location = new System.Drawing.Point(399, 240);
            this.lampCheck.Name = "lampCheck";
            this.lampCheck.Size = new System.Drawing.Size(58, 26);
            this.lampCheck.TabIndex = 15;
            this.lampCheck.Text = "Lamps";
            this.lampCheck.UseVisualStyleBackColor = true;
            this.lampCheck.CheckedChanged += new System.EventHandler(this.lampCheck_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lampCheck);
            this.Controls.Add(this.heaterCheck);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.testLength);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox testLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox heaterCheck;
        private System.Windows.Forms.CheckBox lampCheck;
    }
}

