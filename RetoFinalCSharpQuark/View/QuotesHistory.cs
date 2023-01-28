using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetoFinalCSharpQuark.View;

namespace RetoFinalCSharpQuark.View
{
    public partial class QuotesHistory : Form, IHistoryView
    {
        public QuotesHistory()
        {
            InitializeComponent();
        }

        private DataTable quoteTable;

        public DataTable QuoteTable { get => quoteTable; set => quoteTable = value; }

        private void QuotesHistory_Load(object sender, EventArgs e)
        {

        }

        public void SetDataSource()
        {
            dgvQuoteList.DataSource = QuoteTable;
        }
    }
}
