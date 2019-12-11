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
    public partial class TasksList : UserControl
    { public TabPage form;
        public TasksList(TabPage f)
        {
            InitializeComponent();
            form = f;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TaskPage taskPage = new TaskPage();
            this.Visible = false;
            form.Controls.Add(taskPage);
            
        }
    }
}
