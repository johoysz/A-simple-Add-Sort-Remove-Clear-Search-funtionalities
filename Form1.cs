using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buangjug_SemiFinalLaboratoryActivity2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox.Items.Add("Japan");
            comboBox.Items.Add("Alaska");
            comboBox.Items.Add("Philippines");
            comboBox.Items.Add("Venezuela");
            comboBox.Items.Add("South Korea");
        }
        public void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelectItem.Text = comboBox.SelectedItem.ToString();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblSelectItem.Text = string.Empty;
            comboBox.Text = string.Empty;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            comboBox.Sorted = true;
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(comboBox.SelectedItem != null)
            {
                comboBox.Items.Remove(comboBox.SelectedItem);
                lblSelectItem.Text = string.Empty;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 addForm = new Form2(this); addForm.Show();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Form3 searchForm = new Form3(this); searchForm.Show();
        }
    }
}
