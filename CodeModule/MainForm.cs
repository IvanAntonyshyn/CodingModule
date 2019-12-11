using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CodeModule
{
    public partial class MainForm : Form
    {
        List<double> xValues = new List<double>();
        List<double> yValues = new List<double>();
        public MainForm()
        {
            InitializeComponent();
            xValues.Add(1);
            yValues.Add(25);

            xValues.Add(2);
            yValues.Add(75);

            xValues.Add(3);
            yValues.Add(50);

            xValues.Add(4);
            yValues.Add(90);

            chart1.Series["Series1"].Points.DataBindXY(xValues, yValues);
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            // UserControl start = new UserControl();
            StartPage startPage = new StartPage();
            startPage.Visible = true;
            //startPage.Show();
            //this.ActiveControl = startPage;
           // this.CreateControl();
        
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            button1.Visible = false;
            TasksList tasksList = new TasksList(this.tabPage1);
            tabPage1.Controls.Add(tasksList);
            
        }
    }
}
