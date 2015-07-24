﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculators
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Buttons' Methods
        public void MainM1()
        {
            this.Opacity = .7;
            Grades asd1 = new Grades();
            asd1.ShowDialog();
            this.Opacity = 100;
        }
        public void MainM2()
        {
            this.Opacity = .7;
            LineEquation asd2 = new LineEquation();
            asd2.ShowDialog();
            this.Opacity = 100;
        }
        public void Test1()
        {
            this.Opacity = .7;
            Test asd3 = new Test();
            asd3.ShowDialog();
            this.Opacity = 100;
        }
        #endregion

        #region Buttons' Actions
        public void BGrades_Click(object sender, EventArgs e)
        {
            MainM1();
        }
        private void BEquation_Click(object sender, EventArgs e)
        {
            MainM2();
        }
        private void test1_Click(object sender, EventArgs e)
        {
            Test1();
        }
        #endregion

        #region ESC to close method
        private void ESCClose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion

        #region Hide and Show Label1

        public void label_ON()
        {
            label1.Visible = true;
        }

        public void label_OFF()
        {
            label1.Visible = false;
        }
    
        private void ObjectMouseHover_IN(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void ObjectMouseHover_OUT(object sender, EventArgs e)
        {
            label_OFF();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            label_ON();
        }
        #endregion
    }
}