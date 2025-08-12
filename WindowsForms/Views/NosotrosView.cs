using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Views
{
    partial class NosotrosView : Form
    {
        public NosotrosView()
        {
            InitializeComponent();

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
