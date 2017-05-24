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
    public partial class BlockModeForm : GameForm
    {
        public BlockModeForm()
        {
            InitializeComponent();
        }

        private void BlockModeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}
