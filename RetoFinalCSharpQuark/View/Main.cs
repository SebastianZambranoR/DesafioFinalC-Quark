using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetoFinalCSharpQuark.View
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void tbxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckIsANumber(e);
        }

        private void tbxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckIsANumber(e);
        }

        private bool CheckIsANumber(KeyPressEventArgs PressedKey)
        {
            bool result = false;
            if (!char.IsControl(PressedKey.KeyChar) && !char.IsNumber(PressedKey.KeyChar))
            {
                result = true;
            }

            return result;
        }
    }
}
