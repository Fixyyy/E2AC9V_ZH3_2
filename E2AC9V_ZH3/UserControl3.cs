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
    public partial class UserControl3 : UserControl
    {
        Models.TextBookContext context = new Models.TextBookContext();
        public UserControl3()
        {
            InitializeComponent();
            DiakListazas();
        }

        private void DiákSzűrő_TextChanged(object sender, EventArgs e)
        {
            DiakListazas();
        }

        private void DiakListazas()
        {
            DiákListbox.DataSource = (from x in context.Students
                                      where x.Name.Contains(DiákSzűrő.Text)
                                      select x).ToList();
            DiákListbox.DisplayMember = "Name";
        }

        private void DiákListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kivalasztottdiak = (Student)DiákListbox.SelectedValue;
            var diakok = from x in context.Students
                         where x.StudentId == kivalasztottdiak.StudentId
                         select new Diak
                         {
                             StudentId = x.StudentId,
                             Name = x.Name,
                             Neptun = x.Neptun

                         };
            diakBindingSource.DataSource = diakok.ToList();
        }
        
    }
}
