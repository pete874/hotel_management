using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_management
{
    public partial class Varaukset_form : Form
    {
        public Varaukset_form()
        {
            InitializeComponent();
        }

        private void Varaukset_form_Load(object sender, EventArgs e)
        {
            SisaanDTP.CustomFormat = "dd.MM.yyyy";
            SisaanDTP.Format = DateTimePickerFormat.Custom;

            UlosDTP.CustomFormat = "dd.MM.yyyy";
            UlosDTP.Format = DateTimePickerFormat.Custom;
        }
    }
}
