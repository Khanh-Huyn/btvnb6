using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BT6.MODEL;

namespace BT6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Model1 context = new Model1();

            List<Student> students = context.Student.ToList();
            dataGridView1.DataSource = students;

        }
        

        
    }
}
