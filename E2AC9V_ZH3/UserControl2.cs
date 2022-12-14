using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E2AC9V_ZH3.Models;

namespace E2AC9V_ZH3
{
    public partial class UserControl2 : UserControl
    {
        Models.TextBookContext context = new Models.TextBookContext();
        public UserControl2()
        {
            InitializeComponent();
            KonyvekSzures();
        }

        private void KonyvSzures_TextChanged(object sender, EventArgs e)
        {
            KonyvekSzures();
        }

        private void KonyvekSzures()
        {
            KonyvekLista.DataSource = (from x in context.Textbooks
                                       where x.Title.Contains(KonyvSzures.Text)
                                       select x).ToList();
            KonyvekLista.DisplayMember = "Title";

            
        }

        private void KonyvekLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kivalasztottkonyv = (Textbook)KonyvekLista.SelectedValue;
            var konyvek = from x in context.Textbooks
                          where x.TextbookId == kivalasztottkonyv.TextbookId
                          select new Textbook
                          {
                              TextbookId = x.TextbookId,
                              StockNumber = x.StockNumber,
                              Title = x.Title,
                              Price = x.Price,
                              NotAvailable = x.NotAvailable,

                          };
            textbookBindingSource.DataSource = konyvek.ToList();
        }
    }
}
