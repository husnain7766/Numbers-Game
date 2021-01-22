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
    public partial class MainMenu : Form
    {
        private string fileName_;
        private List<ScoreList> scoreList_;
        class ScoreList :IComparable<ScoreList>
        {
            public string Name;
            public int Score;

            public ScoreList(string line)
            {
                Name = line.Split(',')[0];
                Score = int.Parse(line.Split(',')[1]);
            }
            public ScoreList(string name, int score)
            {
                Name = name;
                Score = score;
            }

            public int CompareTo(ScoreList other)
            {
                if (ReferenceEquals(this, other)) return 0;
                if (ReferenceEquals(null, other)) return 1;
                return Score.CompareTo(other.Score)*-1;
            }
        }

        public MainMenu()
        {
            fileName_ = "scores.txt";
            scoreList_ = new List<ScoreList>();
            InitializeComponent();
            ReadFile();
            RenderList();
           
        }

        void ReadFile()
        {
            try
            {
                string[] lines = File.ReadAllLines(fileName_);
                scoreList_.Clear();
                for (int i = 0; i < lines.Length; i++)
                {
                    scoreList_.Add(new ScoreList(lines[i]));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(@"Unable To Load File");
                File.WriteAllText(fileName_, "");
            }
        }

        void RenderList()
        {
            scoreList_.Sort();
            namesLabel.Text = scoreLabel.Text = "";
            for (int i = 0; i < scoreList_.Count; i++)
            {
                namesLabel.Text += i + ". " + scoreList_[i].Name + '\n';
                scoreLabel.Text += scoreList_[i].Score + "\n";
            }
        }

 
        private void startButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show(@"Enter Name To Start");
            }
            else
            {
                GameForm game = new GameForm(nameTextBox.Text,fileName_);
                game.ShowDialog();
                ReadFile();
                RenderList();
            }
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
