using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumbersGame
{
    public partial class Result : Form
    {
        public Result(int score, int time, string name)
        {
            InitializeComponent();
            timeLabel.Text = time.ToString();
            scoreLabel.Text = score.ToString();
            nameLabel.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
