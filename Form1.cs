﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikfall
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            
            

            if (textBox1.Text == "")
            {
                MessageBox.Show("Ange ditt användarnamn!");
            }

            else if (textBox2.Text == "")
            {
                MessageBox.Show("Ange ditt lösenord");
            }


            else if (textBox1.Text.ToLower() == "admin")
            {
                this.Hide();
                bool b = true;
                EmployeeFrame openFrame = new EmployeeFrame(textBox1.Text, b);
                openFrame.Show();
            }

            else
            {
                this.Hide();
                bool b = false;
                EmployeeFrame openFrame = new EmployeeFrame(textBox1.Text, b);
                openFrame.Show();
            }
            }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

            
          
             
           
        


        

        
       
    }
}
