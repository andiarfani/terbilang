using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mulai_Click(object sender, EventArgs e)
        {
            int nominal = int.Parse(txtangka.Text);

            Class1 none = new Class1();

            lsthasil.Text = Convert.ToString(none.TerbilangIndo(nominal));
        }
    }
}
