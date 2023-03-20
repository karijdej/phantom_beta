using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phantom_beta
{
    public partial class Form1 : Form
    {
        public delegate void d1(string indata);
        private readonly List<double> _temps = new List<double>();
        public static int loops = -1;

        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        private void heaterCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (heaterCheck.Checked)
            {
                HeaterOn();
            }
            else
            {
                HeaterOff();
            }
        }

        private void lampCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (lampCheck.Checked)
            {
                LampsOn();
            }
            else
            {
                LampsOff();
            }
        }



        public void HeaterOn()
        {
            //heater & fan on - pin 2
            serialPort1.Write("A");
        }
        public void HeaterOff()
        {
            //heater & fan off - pin 2
            serialPort1.Write("a");
        }
        public void LampsOn()
        {
            //lamps on - pin 4
            serialPort1.Write("B");
        }
        public void LampsOff()
        {
            //lamps off - pin 4
            serialPort1.Write("b");
        }
        public void BothOn()
        {
            serialPort1.Write("C");
        }
        public void BothOff()
        {
            serialPort1.Write("c");
        }

        public double readTemp()
        {
            return Convert.ToDouble(textBox1.Text);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Start();

            if (checkBox1.Checked)
            {
                HeaterOn();
            }

            if (checkBox2.Checked)
            {
                LampsOn();
            }

            if (checkBox3.Checked)
            {
                BothOn();
            }
        }



        

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string indata = serialPort1.ReadLine();
            d1 writeit = new d1(Write2Form);
            Invoke(writeit, indata);
        }

        public void Write2Form(string indata)
        {
            textBox1.Text = indata;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            BothOff();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double current_temp = readTemp();
            _temps.Add(current_temp);

            int length = Convert.ToInt32(testLength.Text);
            int ticks = length;
            loops++;

            ticks--;
            testLength.Text = ticks.ToString();

            System.Diagnostics.Debug.WriteLine(_temps[loops]);

            if (length == 1)
            {
                timer1.Stop();
                BothOff();
                System.Diagnostics.Debug.WriteLine(current_temp);
                //File.WriteAllText("C:\\Users\\Dennis\\Documents\\Phantom\\cs_data\\data.csv", _temps.ToString());
            }
        }


    }
}
