using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lianliankan
{
    public partial class RelaxModeForm : GameForm
    {
        public RelaxModeForm()
        {
            InitializeComponent();
        }

        private void RelaxModeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}
