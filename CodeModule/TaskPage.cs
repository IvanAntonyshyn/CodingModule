using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeModule
{
    public partial class TaskPage : UserControl
    {
        public TaskPage()
        {
            InitializeComponent();
            label9.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Visible = true;
            textBox1.BackColor = Color.LightGreen;
            textBox5.BackColor = Color.LightGreen;
            textBox3.BackColor = Color.LightGreen;
            textBox4.BackColor = Color.Red;
        }
    }
}
