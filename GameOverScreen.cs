﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class GameOverScreen : Form
    {
        public GameOverScreen(string score)
        {
            InitializeComponent();
            lblDisplay.Text = score;
        }
    }
}