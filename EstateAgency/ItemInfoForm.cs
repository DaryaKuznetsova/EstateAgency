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
            var realtyType = db.RealtyTypes.FirstOrDefault(p => p.Name == RealtyTypeTextBox.Text);
            var tradeType= db.TradeTypes.FirstOrDefault(p => p.Name == TradeTypeTextBox.Text);
            var district= db.Districts.FirstOrDefault(p => p.Name == DistrictTextBox.Text);
            var owner= db.Owners.FirstOrDefault(p => p.Name == OwnerInfoTextBox.Text);
            var status= db.Statuses.FirstOrDefault(p => p.Name == StatusTextBox.Text);

            eo.RealtyTypes = realtyType;
            eo.TradeTypes = tradeType;
            eo.Districts = district;
            eo.Owners = owner;
            eo.Statuses = status;
            eo.Price = Convert.ToDecimal(PriceTextBox.Text);
            eo.Address = AddressTextBox.Text;
            eo.Description = DescriptionTextBox.Text;
            eo.Rooms = Convert.ToByte(RoomsTextBox.Text);
            eo.LandArea = (float)Convert.ToDouble(LandAreaTextBox.Text);
            eo.Area = (float)Convert.ToDouble(areaTextBox.Text);
            eo.LandDescription = LandTextBox.Text;

            db.SaveChanges();           
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var realtyType = db.RealtyTypes.FirstOrDefault(p => p.Name == RealtyTypeTextBox.Text);
            var tradeType = db.TradeTypes.FirstOrDefault(p => p.Name == TradeTypeTextBox.Text);
            var district = db.Districts.FirstOrDefault(p => p.Name == DistrictTextBox.Text);
            var owner = db.Owners.FirstOrDefault(p => p.Name == OwnerInfoTextBox.Text);
            var status = db.Statuses.FirstOrDefault(p => p.Name == StatusTextBox.Text);
            if(realtyType!=null&&tradeType!=null&&district!=null&&owner!=null&&status!=null)
            {
                eo = new EstateObjects
                {
                    RealtyTypes = realtyType,
                    TradeTypes = tradeType,
                    Districts = district,
                    Owners = owner,
                    Statuses = status,
                    Price = Convert.ToDecimal(PriceTextBox.Text),
                    Address = AddressTextBox.Text,
                    Description = DescriptionTextBox.Text,
                    Rooms = Convert.ToByte(RoomsTextBox.Text),
                    LandArea = (float)Convert.ToDouble(LandAreaTextBox.Text),
                    Area = (float)Convert.ToDouble(areaTextBox.Text),
                    LandDescription = LandTextBox.Text
                };
                db.EstateObjects.Add(eo);
                db.SaveChanges();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            db.EstateObjects.Remove(eo);
            db.SaveChanges();
        }
    }
}
