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
    public partial class Form2 : Form
    {
        public Form2(int poziom)
        {
            InitializeComponent();
            label2.Text = (poziom+1).ToString();
        }
        // tu będzie konstrukcja nowej planszy.
    }
}
