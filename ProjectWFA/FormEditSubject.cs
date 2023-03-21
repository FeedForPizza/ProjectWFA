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
    public partial class FormEditSubject : Form
    {
        private int id;

        public FormEditSubject()
        {
            InitializeComponent();
        }

        public void Init(int id, string name)
        {
            this.id = id;
            this.numericUpDownID.Value = id;
            this.textBoxName.Text = name;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Configurator configurator = new Configurator();
            configurator.UpdateSpecialty(this.id, (int)this.numericUpDownID.Value,
           this.textBoxName.Text);

        }
    }
}
