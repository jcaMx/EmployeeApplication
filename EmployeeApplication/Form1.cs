using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeNamespace;

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            
            string id = textBoxID.Text;
            string fname = textBoxFname.Text;
            string lname = textBoxLname.Text;
            string position = textBoxPosition.Text;

            User user = new User(id, fname, lname, position);

            MessageBox.Show("ayoko na");



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (textBoxID != null && textBoxFname != null && textBoxLname != null && textBoxPosition != null)
            {
                buttonSubmit.Enabled = true;
            }
            else
            {
                MessageBox.Show("Enter the following values");
                buttonSubmit.Enabled = false;
            }
        }
    }
  }

