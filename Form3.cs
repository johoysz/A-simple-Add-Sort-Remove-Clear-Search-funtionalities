using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Buangjug_SemiFinalLaboratoryActivity2
{
    public partial class Form3 : Form
    {
        private Form1 form1;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchItem = textBoxSearch.Text;
            if (!string.IsNullOrEmpty(searchItem)) {
                int index = form1.comboBox.FindString(searchItem);
                if (index >= 0 || form1.comboBox.Items.Equals(searchItem))
                {
                    form1.comboBox.SelectedIndex = index;
                    form1.lblSelectItem.Text = form1.comboBox.SelectedItem.ToString();
                }
                else
                {
                    form1.comboBox.ResetText();
                    form1.lblSelectItem.Text = "Item not found.";

                    this.Close();
                    //new feature added!!!
                    string message = "Item not found!"+Environment.NewLine+"Do you want to add this to the list? ";
                    string title = "Add To List";
                    MessageBoxButtons messageBoxButtons= MessageBoxButtons.YesNo;
                    DialogResult dialogResult = MessageBox.Show(message, title, messageBoxButtons); 
                    if (dialogResult == DialogResult.Yes) {
                        form1.comboBox.Items.Add(searchItem.Substring(0,1).ToUpper() + searchItem.Substring(1).ToLower());
                    }
                }
            }
        }
    }
}
