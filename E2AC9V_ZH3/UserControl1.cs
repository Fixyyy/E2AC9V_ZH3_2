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
    public partial class UserControl1 : UserControl
    {
        Models.TextBookContext context = new Models.TextBookContext();
        public UserControl1()
        {
            InitializeComponent();
            StudentSzuro();
            RendelesListazas();
            KonyvSzuro();
        }

        private void StudentTextbox_TextChanged(object sender, EventArgs e)
        {
            StudentSzuro();
        }

        private void StudentSzuro()
        {
            StudentListbox.DataSource = (from x in context.Students
                                         where x.Name.Contains(StudentTextbox.Text)
                                         select x).ToList();
            StudentListbox.DisplayMember = "Name";
        }

        private void StudentListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RendelesListazas();
        }

        private void RendelesListazas()
        {
            var kivalasztottdiak = (Student)StudentListbox.SelectedValue;
            var rendelesek = from x in context.Orders
                             where x.StudentFk == kivalasztottdiak.StudentId
                             select new
                             {
                                 OrderSk = x.OrderSk,
                                 Title = x.TextbookFkNavigation.Title
                             };
            RendelesListbox.DataSource = rendelesek.ToList();
            RendelesListbox.DisplayMember = "Title";
            RendelesListbox.ValueMember = "OrderSk";
        }

        private void KonyvekTextbox_TextChanged(object sender, EventArgs e)
        {
            KonyvSzuro();
        }

        private void KonyvSzuro()
        {
            KonyvekListbox.DataSource = (from x in context.Textbooks
                                         where x.Title.Contains(KonyvekTextbox.Text)
                                         select x).ToList();
            KonyvekListbox.DisplayMember = "Title";
        }

        private void KonyvekListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztos hozzáadja a könyveket a rendeléshez?", " ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                for (int i = 0; i < Convert.ToInt32(TeteldarabTextbox.Text); i++)
                {


                    var kivalasztottdiak = (Student)StudentListbox.SelectedItem;
                    var kivalasztottonyv = (Textbook)KonyvekListbox.SelectedItem;

                    Models.Order newOrder = new Models.Order()

                    {
                        StudentFk = kivalasztottdiak.StudentId,
                        TextbookFk = kivalasztottonyv.TextbookId
                    };

                    context.Orders.Add(newOrder);

                    try
                    {
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                    RendelesListazas();
                    
                }
            }
            RendelesListazas();
        }

        private void TeteldarabTextbox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(TeteldarabTextbox, "");
        }

        private void TeteldarabTextbox_Validating(object sender, CancelEventArgs e)
        {
            if (TeteldarabTextbox.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(TeteldarabTextbox, "A tételszám nem lehet üres");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztos, hogy törlöd a rendelést?", " ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int OrderAzon = Convert.ToInt32(RendelesListbox.SelectedValue);
                var TorlendoOrder = from x in context.Orders
                         where x.OrderSk == OrderAzon
                         select x;
                context.Orders.Remove(TorlendoOrder.FirstOrDefault());

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                RendelesListazas();
            }
        }
    }
}
