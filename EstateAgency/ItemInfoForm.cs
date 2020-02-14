using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstateAgency
{
    public partial class ItemInfoForm : Form
    {
        EstateAgency db;
        EstateObjects eo;
        public ItemInfoForm(EstateAgency database, EstateObjects estateObject)
        {
            InitializeComponent();
            db = database;
            eo = estateObject;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            eo.StatusId = 1;
            eo.OwnerId = 1;
            eo.Price = 50;
            eo.Address = "adres";
            eo.DistrictId = 1;
            eo.Description = "op";
            eo.RealtyTypeId = 1;
            eo.TradeTypeId = 1;
            eo.Area = 23;
            eo.Rooms = 5;
            db.SaveChanges();
        }
    }
}
