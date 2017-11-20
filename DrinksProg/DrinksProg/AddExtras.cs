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
    public partial class AddExtras : Form
    {
        private decimal price;
        private Extras extra;
        private CultureInfo cultureInfo;
        private ResourceManager resourceManger;

        public event EventHandler<ProductEventArgument> CollectionChanged;

        public AddExtras(CultureInfo culture)
        {
            cultureInfo = culture;
            InitializeComponent();
            resourceManger = new ResourceManager(("DrinksProg.Resources.Localization"), Assembly.GetExecutingAssembly());
            extra = new Extras();
          
            UpdateUIControls();
        }

        private void UpdateUIControls()
        {
            try
            {
                if (resourceManger != null)
                {
                    btnSaveExtra.Text = resourceManger.GetString("btnSave");
                    lblNameExtra.Text = resourceManger.GetString("Name");
                    lblPriceExtra.Text = resourceManger.GetString("Price");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
        private void btnSaveExtra_Click(object sender, EventArgs e)
        {
            extra.Name = txtNameExtra.Text;
            if (decimal.TryParse(txtNameExtra.Text, out price))
            {
                extra.Price = price;
            }
            extra.Currency = "lv";

            XmlService.ListOfProducts.Add(extra);

            if(CollectionChanged != null)
            {
                ProductEventArgument prodEventArgument = new ProductEventArgument();
                prodEventArgument.Product = extra;
                CollectionChanged(this, prodEventArgument);
                
            }
        }
    }
}
