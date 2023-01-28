using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetoFinalCSharpQuark.View;
using RetoFinalCSharpQuark.Model;
using RetoFinalCSharpQuark.Presenter;

namespace RetoFinalCSharpQuark
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Shop shop = new Shop("La infalible", "Calle 43 #75-60");
            shop.InitializeData();


            ISellerModel seller = new Seller("Andres", "Patiño", shop, "22165");
            IMainView view = new Main();

            MainPresenter presenter = new MainPresenter(view, seller);
            Application.Run();
        }
    }
}
