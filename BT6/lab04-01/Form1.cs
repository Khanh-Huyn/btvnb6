﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab04_01.Model;

namespace lab04_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void FillData()
        {
            var context = new Student();
            dataGridView1.DataSource = context.StudentID.ToList();
        }
    }
}
