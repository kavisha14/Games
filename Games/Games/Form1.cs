using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void math_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "C:\\Users\\Ritesh\\Documents\\Visual Studio 2015\\Projects\\mathquiz\\mathquiz\\obj\\Debug\\mathquiz.exe";
            p.Start();
        }

        private void comparison_Click(object sender, EventArgs e)
        {
            Process q = new Process();
            q.StartInfo.FileName = "C:\\Users\\Ritesh\\Documents\\Visual Studio 2015\\Projects\\matchingGame\\matchingGame\\bin\\Debug\\matchingGame.exe";
            q.Start();
        }

        private void mazerunner_Click(object sender, EventArgs e)
        {
            Process t = new Process();
            t.StartInfo.FileName = "C:\\Users\\Ritesh\\Documents\\Visual Studio 2015\\Projects\\MazeGame\\MazeGame\\bin\\Debug\\MazeGame.exe";
            t.Start();
        }
    }
}
