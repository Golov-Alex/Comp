using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract
{
    public partial class Form1 : Form
    {
        public class Employee
        {
            public int ID { get; set; }
            public string FIO { get; set; }
            public string Position { get; set; }
            public decimal Salary { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSortSalary_Click(object sender, EventArgs e)
        {

        }
    }
}
