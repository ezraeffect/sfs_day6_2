using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day6_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[][] classArray = new string[3][];
            classArray[0] = new string[] { "홍길동", "박지영" };
            classArray[1] = new string[] { "박아무개", "김갑순", "홍길순" };
            classArray[2] = new string[] { "이민우" };

            textBox1.Text = $"1반 학생 목록 \r\n - {classArray[0][0]}\r\n - {classArray[0][1]}\r\n";
            textBox1.Text += $"2반 학생 목록 \r\n - {classArray[1][0]}\r\n - {classArray[1][1]}\r\n - {classArray[1][2]}\r\n";
            textBox1.Text += $"3반 학생 목록 \r\n - {classArray[2][0]}";

        }
    }
}
