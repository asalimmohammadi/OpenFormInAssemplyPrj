using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dllTestProject
{
    public partial class frmTest : Form
    {
        int _ID = -1;
        string _Title = "null";
        public frmTest()
        {
            InitializeComponent();
        }

        public frmTest(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }

        public frmTest(int ID , string Title)
        {
            InitializeComponent();
            _ID = ID;
            _Title = Title;
        }
        private void frmTest_Load(object sender, EventArgs e)
        {
            label1.Text = _ID.ToString();
            label2.Text = _Title;
        }
    }
}
