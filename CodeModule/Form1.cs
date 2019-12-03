using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace CodeModule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CodeModuleDBDataSet dbContext = new CodeModuleDBDataSet();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
