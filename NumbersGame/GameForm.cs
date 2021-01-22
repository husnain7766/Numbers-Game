using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumbersGame
{
    public partial class GameForm : Form
    {
        private int level = 1;
        private int score = 0;
        private int result = -1;
        private string fileName;
        private string name;
        Random random = new Random();
        public GameForm(string name,string fileName)
        {
            this.name = name;
            this.fileName = fileName;
            InitializeComponent();
            KeypadInit();
            question();
            Timer timer1 = new Timer
            {
                Interval = 1000
            };
            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(timer_Tick);

        }

        private void KeypadInit()
        {
            this.button0.Click += new System.EventHandler(this.button_Click);
            this.button1.Click += new System.EventHandler(this.button_Click);
            this.button2.Click += new System.EventHandler(this.button_Click);
            this.button3.Click += new System.EventHandler(this.button_Click);
            this.button4.Click += new System.EventHandler(this.button_Click);
            this.button5.Click += new System.EventHandler(this.button_Click);
            this.button6.Click += new System.EventHandler(this.button_Click);
            this.button7.Click += new System.EventHandler(this.button_Click);
            this.button8.Click += new System.EventHandler(this.button_Click);
            this.button9.Click += new System.EventHandler(this.button_Click);
        }
        private void timer_Tick(object sender, System.EventArgs e)
        {
            int x = int.Parse(timeLabel.Text) + 1;
            timeLabel.Text = x.ToString();
        }

        void question()
        {
            int x = random.Next(level * 10);
            int y = random.Next(level * 10);
            int op = random.Next(3);
            oper1.Text = x.ToString();
            oper2.Text = y.ToString();
            if (op == 0)
            {
                result = x + y;
                operation.Text = @"+";
            }
            else if (op == 1)
            {
                result = x - y;
                operation.Text = @"-";
            }
            else if (op == 2)
            {
                result = x * y;
                operation.Text = @"*";
            }

            level++;
        }


        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string s = ResultTestBox.Text;
            int x;
            if (!int.TryParse(s, out x))
            {
                MessageBox.Show(@"Invalid Input");
                return;
            }
            if (x == result)
            {
                score = level * 10;
                scoreLabel.Text = score.ToString();
            }
            question();

            ResultTestBox.Text = "";
            if (level == 6)
            {
                Result result = new Result(score,int.Parse(timeLabel.Text),name);
                result.ShowDialog();
                Save();
                this.Close();
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string d = button.Text;
            ResultTestBox.Text += d;
        }

        private void Save()
        {
            try
            {
                string[] lines = {name + "," + score};
                File.AppendAllLines(fileName,lines);
            }
            catch (Exception e)
            {
                MessageBox.Show(@"Enable to store result");
            }
        }

    }
}
