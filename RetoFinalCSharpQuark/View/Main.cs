using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetoFinalCSharpQuark.Model;
using RetoFinalCSharpQuark.View;
using RetoFinalCSharpQuark.Presenter;

namespace RetoFinalCSharpQuark.View
{
    public partial class Main : Form, IMainView
    {
        public string sellerName { set => lblSellerName.Text = value; }
        public string sellerId { set => lblSellerId.Text = value; }
        public bool isShirt { get => rbtShirt.Checked; }
        public bool isShort { get => cbxShort.Checked; }
        public bool MaoNeck { get => cbxMaoNeck.Checked; }
        public bool isSlim { get => cbxSlim.Checked;}
        public bool isPremium { get => rbtPremium.Checked; }
        public string selectedDressStock { get => lblStock.Text; set => lblStock.Text = value; }

        public string unitPrice => tbxPrice.Text;

        public string dressAmount => tbxAmount.Text;

        public string quotedTotalValue { set => lblQuoteValue.Text = value; }
        public string shopName { set => lblShopName.Text = value; }
        public string shopAddress { set => lblShopAddress.Text = value; }

        public Main()
        {
            InitializeComponent();
        }

        public event Action UpdatedDressData;
        public event Action MakeQuote;
        public event Action QuotesHistory;

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


        private void btnMakeQuote_Click(object sender, EventArgs e)
        {
            MakeQuote?.Invoke();
        }

        public bool CompleteDressDefinition()
        {
            bool dressTypeSelected = rbtJean.Checked || rbtShirt.Checked;
            bool dressQualitySelected = rbtStandar.Checked || rbtPremium.Checked;

            bool allFieldsCompleted = dressTypeSelected && dressQualitySelected;

            return allFieldsCompleted;
        }


        #region UpdateDressValues
        private void rbtShirt_CheckedChanged(object sender, EventArgs e)
        {
            UpdatedDressData?.Invoke();
        }

        private void rbtJean_CheckedChanged(object sender, EventArgs e)
        {
            UpdatedDressData?.Invoke();
        }

        private void cbxShort_CheckedChanged(object sender, EventArgs e)
        {
            UpdatedDressData?.Invoke();
        }

        private void cbxMaoNeck_CheckedChanged(object sender, EventArgs e)
        {
            UpdatedDressData?.Invoke();
        }

        private void cbxSlim_CheckedChanged(object sender, EventArgs e)
        {
            UpdatedDressData?.Invoke();
        }

        private void rbtStandar_CheckedChanged(object sender, EventArgs e)
        {
            UpdatedDressData?.Invoke();
        }

        private void rbtPremium_CheckedChanged(object sender, EventArgs e)
        {
            UpdatedDressData?.Invoke();
        }


        #endregion

        public void ShowError(string Message)
        {
            MessageBox.Show(Message);
        }

        private void btnQuotes_Click(object sender, EventArgs e)
        {
            QuotesHistory?.Invoke();
        }
    }
}
