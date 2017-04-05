using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            NameFactory nameFact = new NameFactory();
            Namer namer = nameFact.GetNamer(txtname.Text);
            txtFName.Text = namer.FirstName;
            txtLName.Text = namer.LastName;
        }
    }
}
