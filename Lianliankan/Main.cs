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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void BtnRanking_Click(object sender, EventArgs e)
        {

        }

        private void BtnBasicMode_Click(object sender, EventArgs e)
        {
            Visible = false;
            BasicModeForm basicmForm = new BasicModeForm();
            basicmForm.ShowDialog();
            
            
            if(basicmForm.IsDisposed)
            {
                Visible = true;
            }
        }

        private void BtnRelaxMode_Click(object sender, EventArgs e)
        {
            Visible = false;
            RelaxModeForm relaxmForm = new RelaxModeForm();
            relaxmForm.ShowDialog();
           
            if (relaxmForm.IsDisposed)
            {
                Visible = true;
            }
        }

        private void BtnBlockMode_Click(object sender, EventArgs e)
        {
            Visible = false;
            BlockModeForm blockmForm = new BlockModeForm();
            blockmForm.ShowDialog();
           
            if (blockmForm.IsDisposed)
            {
                Visible = true;
            }
        }
    }
}
