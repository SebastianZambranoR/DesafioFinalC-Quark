using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RetoFinalCSharpQuark.View
{
    interface IHistoryView
    {
        DataTable QuoteTable { get; set; }

        void SetDataSource();

        void Show();
    }
}
