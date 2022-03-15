﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saper___gra
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
        }
        public int poziom=0;
        static int sec = 0;
        static int min = 0;
        private void button_start_Click(object sender, EventArgs e)
        {
            sec = 0;
            min = 0;
            Random rdn = new Random();
            int x = rdn.Next(1, 12);
            int y = rdn.Next(13, 18);
            int z = rdn.Next(19, 25);
            

            for (int i = 1; i <= 25; i++)
            {
                Button btnTemp = new Button();
                btnTemp.Cursor = System.Windows.Forms.Cursors.Arrow;
                btnTemp.Name = "btnTemp" + i.ToString();
                btnTemp.Size = new System.Drawing.Size(40, 40);               
                btnTemp.UseVisualStyleBackColor = true;
                flowLayoutPanel1.Controls.Add(btnTemp);
                btnTemp.Click += BtnTemp_Click;
                if (x == i || y == i || z == i)
                    btnTemp.Tag = true;
                else
                    btnTemp.Tag = false;

            }
            timer1.Enabled = true;
        }

        private void BtnTemp_Click(object sender, EventArgs e)
        {
            Button btnTemp = (Button)sender;
            bool tag =(bool)btnTemp.Tag;

            if (tag)
            {
                btnTemp.BackColor = Color.Red;
                int score = int.Parse(label4.Text);
                score++;
                label4.Text = score.ToString();
                timer1.Enabled = false;
                if (score == 1)
                {
                    MessageBox.Show("Przegrałeś!", "Wynik:", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            else
            {
                btnTemp.BackColor = Color.Green;
                int score = int.Parse(label3.Text);
                score++;
                label3.Text = score.ToString();
                
            }
        }

        private void GrazTrudnoscia_Click(object sender, EventArgs e)
        {
            Form2 GameWindow = new Form2(poziom);
            GameWindow.Show();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            poziom = listBox2.SelectedIndex;
            Console.WriteLine(poziom.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec == 60)
            {
                sec = 0;
                min++;
            }
            label5.Text = Convert.ToString(min) + " : " + Convert.ToString(sec);
        }
    }
}