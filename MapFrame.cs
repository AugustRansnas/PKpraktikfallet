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
    public partial class MapFrame : Form
    {

        public MapFrame()
        {

            InitializeComponent();



            EmployeeFrame tmp = new EmployeeFrame();
            string adress = tmp.TheValue;
            string city = tmp.TheValue1;
            StringBuilder queryAdress = new StringBuilder();
            queryAdress.Append("http://maps.google.com/maps?q=");
            queryAdress.Append(adress + "," + city);
            webBrowserMap.Navigate(queryAdress.ToString());
            webBrowserMap.ScriptErrorsSuppressed = true;
        }

    }
}
                

   
    
