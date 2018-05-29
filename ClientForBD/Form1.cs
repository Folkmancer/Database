using System;
using System.Windows.Forms;

namespace ClientForBD {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void tableToolStripMenuItem01_Click(object sender, EventArgs e)
        {
            FormTable01 Table01 = new FormTable01();            
            Table01.Show();
        }

        private void tableToolStripMenuItem02_Click(object sender, EventArgs e)
        {
            FormTable02 Table02 = new FormTable02();            
            Table02.Show();
        }

        private void tableToolStripMenuItem03_Click(object sender, EventArgs e)
        {
            FormTable03 Table03 = new FormTable03();            
            Table03.Show();
        }

        private void tableToolStripMenuItem04_Click(object sender, EventArgs e)
        {
            FormTable04 Table04 = new FormTable04();
            Table04.Show();
        }

        private void tableToolStripMenuItem05_Click(object sender, EventArgs e)
        {
            FormTable05 Table05 = new FormTable05();
            Table05.Show();
        }

        private void tableToolStripMenuItem06_Click(object sender, EventArgs e)
        {
            FormTable06 Table06 = new FormTable06();
            Table06.Show();
        }

        private void tableToolStripMenuItem07_Click(object sender, EventArgs e)
        {
            FormTable07 Table07 = new FormTable07();
            Table07.Show();
        }

        private void tableToolStripMenuItem08_Click(object sender, EventArgs e)
        {            
            FormTable08 Table08 = new FormTable08();
            Table08.Show();
        }

        private void tableToolStripMenuItem09_Click(object sender, EventArgs e)
        {
            FormTable09 Table09 = new FormTable09();
            Table09.Show();
        }

        private void tableToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            FormTable10 Table10 = new FormTable10();
            Table10.Show();
        }

        private void tableToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            FormTable11 Table11 = new FormTable11();
            Table11.Show();
        }

        private void queryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormQuery1 Query1 = new FormQuery1();
            Query1.Show();
        }

        private void queryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormQuery2 Query2 = new FormQuery2();
            Query2.Show();
        }

        private void queryToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormQuery3 Query3 = new FormQuery3();
            Query3.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpBox1 HelpForm = new HelpBox1();
            HelpForm.ShowDialog();
        }

        private void developerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 AboutForm = new AboutBox1();
            AboutForm.ShowDialog();
        }
    }
}
