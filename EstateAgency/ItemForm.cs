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
    public partial class ItemForm : Form
    {
        EstateAgency db;

        public ItemForm(EstateAgency dataBase)
        {
            InitializeComponent();
            db = dataBase;
        }

        private void RealtyTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void OwnersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddDeleteUpdateMethods.AddEstateObject(db, 1, 1, 3400, "tt", 1, "ss", 1, 1, 13);
        }
    }
}
