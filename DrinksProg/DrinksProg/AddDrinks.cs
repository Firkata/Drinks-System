using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DrinksProg
{
    public partial class AddDrinks : Form
    {
        private decimal price;
        private Drinks drink;
        private CultureInfo cultureInfo;
        private ResourceManager resourceManger;

        public event EventHandler<ProductEventArgument> CollectionChanged;

        public AddDrinks(CultureInfo culture)
        {
            cultureInfo = culture;
            InitializeComponent();
            resourceManger = new ResourceManager(("DrinksProg.Resources.Localization"), Assembly.GetExecutingAssembly());
            drink = new Drinks();
            

            UpdateUIControls();
        }

        

        private void UpdateUIControls()
        {
            try
            {
                if (resourceManger != null)
                {
                    btnSaveDrink.Text = resourceManger.GetString("btnSave");
                    lblNameDrink.Text = resourceManger.GetString("Name");
                    lblPriceDrink.Text = resourceManger.GetString("Price");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnSaveDrink_Click(object sender, EventArgs e)
        {

            drink.Name = txtNameDrink.Text;
            if (decimal.TryParse(txtPriceDrink.Text, out price))
            {
                drink.Price = price;
            }
            drink.Currency = "lv.";

            XmlService.ListOfProducts.Add(drink);

            if(CollectionChanged !=null)
            {
                ProductEventArgument prodEventArgument = new ProductEventArgument();
                prodEventArgument.Product = drink;
                CollectionChanged(this, prodEventArgument);
            }
        }

    }
}
