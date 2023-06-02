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
    public partial class Form2 : Form
    {
        private Form1 form1; //passing of reference from form1 to form2
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        public void btnOK_Click(object sender, EventArgs e)
        {
            string newItem = textBoxItem.Text.Substring(0,1).ToUpper() + textBoxItem.Text.Substring(1).ToLower();
            if (!string.IsNullOrEmpty(newItem))
            {
                form1.comboBox.Items.Add(newItem); //make sure to set the combobox modifier to public or internal so that it can be accessed from other forms
                this.Close(); // to  close form
            }
        }
    }
}