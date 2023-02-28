using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWFA
{
    public partial class FormSpecialty : Form
    {
        public FormSpecialty()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Configurator configurator = new Configurator();
            configurator.SaveSpecialty((int)this.IDupDown.Value,
           this.textBoxName.Text);
        }
    }
}
