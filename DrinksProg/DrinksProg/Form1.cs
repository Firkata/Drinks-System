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
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DrinksProg
{
    public partial class Form1 : Form
    {
        private BindingList<Product> bindingProductList;
        private decimal priceTotal;
        private string currency;
        bool extraPressed = false;
        decimal amountGiven;
        decimal amountChange;
        private ResourceManager resourceManger;
        private CultureInfo cultureInfo;
        Button deleteProduct;
        Button newProduct;
        FlowLayoutPanel fpanelDrinks;
        FlowLayoutPanel fpanelExtras;
        OpenFileDialog openFileDialog;
        string path;

        public Form1()
        {

            path = Directory.GetCurrentDirectory();
            path = Path.Combine(path, "Products.xml");
            XmlService.FilePath = path;

            InitializeComponent();
            bindingProductList = new BindingList<Product>();
            listProducts.DataSource = bindingProductList;
            listProducts.DisplayMember = "Name";
            resourceManger = new ResourceManager("DrinksProg.Resources.Localization", Assembly.GetExecutingAssembly());
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            UpdateUIControls();

            string CultureName = Thread.CurrentThread.CurrentCulture.Name;
            cultureInfo = new CultureInfo(CultureName);
            if (cultureInfo.NumberFormat.NumberDecimalSeparator != ".")
            {
                cultureInfo.NumberFormat.NumberDecimalSeparator = ".";
                Thread.CurrentThread.CurrentCulture = cultureInfo;
            }

        }

        void addDrinks_CollectionChanged(object sender, ProductEventArgument e)
        {
            CreateButton(e.Product);
        }

        //избор директория на файл
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            string filePath = string.Empty;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }
        }

        //добавя продукти в tabPage
        public void AddProductsToPanel()
        {

            //productsList = xml.Deserialize<List<Product>>();

            fpanelDrinks = new FlowLayoutPanel();
            fpanelDrinks.Dock = DockStyle.Fill;

            fpanelExtras = new FlowLayoutPanel();
            fpanelExtras.Dock = DockStyle.Fill;

            foreach (Product product in XmlService.ListOfProducts)
            {
                CreateButton(product);
            }
            

            tabPanel.TabPages[0].Controls.Add(fpanelDrinks);
            tabPanel.TabPages[1].Controls.Add(fpanelExtras);
        }

        private void CreateButton(Product product)
        {

            newProduct = new Button();
            newProduct.Size = new Size(100, 100);
            newProduct.Text = product.Name;

            deleteProduct = new Button();
            deleteProduct.Size = new Size(20, 20);
            deleteProduct.Text = "X";
            deleteProduct.BackColor = Color.Red;

            newProduct.Controls.Add(deleteProduct);


            if (product.GetType() == typeof(Drinks))
            {
                fpanelDrinks.Controls.Add(newProduct);
            }
            else if (product.GetType() == typeof(Extras))
            {
                fpanelExtras.Controls.Add(newProduct);
            }
            newProduct.Tag = product;//let's you put in any type of custom object into your button
            deleteProduct.Tag = newProduct;
            newProduct.Click += newProduct_Click;//one event handler for all instances of buttons
            deleteProduct.Click += deleteProduct_Click;

        }

        //изтрива продукт от List<Product>
        void deleteProduct_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DialogResult dialResult = MessageBox.Show("Do you want to delete this product?", "", MessageBoxButtons.YesNo);
            if (dialResult == DialogResult.Yes)
            {
                fpanelDrinks.Controls.Remove((Button)btn.Tag);
                fpanelExtras.Controls.Remove((Button)btn.Tag);

                Button deleteProduct = (Button)sender;
                Button newProduct = (Button)deleteProduct.Tag;
                Product product = (Product)newProduct.Tag;

                //productsList.Remove(product);
                XmlService.ListOfProducts.Remove(product);
            }
        }

        //изтрива продукт от поръчката
        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<Product> list = bindingProductList.ToList();

            if (listProducts.SelectedItems != null)
            {
                foreach (Product p in listProducts.SelectedItems)
                {
                    list.Remove(p);
                    PriceTotal = PriceTotal - (decimal)p.Price;
                }
            }
            bindingProductList = new BindingList<Product>(list);
            listProducts.DataSource = bindingProductList;

        }

        //прави поръчка при кликане на продукт
        void newProduct_Click(object sender, EventArgs e)
        {
            Product prod = (Product)((Button)sender).Tag;

            //access the product that was passed in newProduct.Tag || casting it because it will think it's a generic object
            Drinks drink;
            Extras extra;

            int index;
            Currency = prod.Currency;
            PriceTotal = PriceTotal + (decimal)prod.Price;

            if (prod.GetType() == typeof(Drinks))
            {
                drink = new Drinks();
                drink.Name = prod.Name;
                drink.Price = prod.Price;

                bindingProductList.Add(drink);
            }
            else
            {
                extraPressed = true;
            }


            if (listProducts.SelectedItem == null && extraPressed)
            {
                extra = new Extras();
                extra.Name = prod.Name;
                extra.Price = prod.Price;

                bindingProductList.Add(extra);
                listProducts.ClearSelected();
            }
            else if (listProducts.SelectedItem.GetType() == typeof(Drinks) && extraPressed)
            {
                drink = listProducts.SelectedItem as Drinks;

                extra = new Extras();
                extra.Name = prod.Name;
                extra.Price = prod.Price;

                drink.ExtrasList.Add(extra);
                extra.IsExtraOfDrink = true;

                index = bindingProductList.IndexOf(drink);
                bindingProductList.Insert(index + 1, extra);
            }
            else if (listProducts.SelectedItem.GetType() == typeof(Extras) && extraPressed)
            {
                //extra = new Extras(prod.Name, prod.Price);
                extra = new Extras();
                extra.Name = prod.Name;
                extra.Price = prod.Price;
                bindingProductList.Add(extra);

            }
            else
            {
                listProducts.ClearSelected();
            }
            extraPressed = false;
        }

        //подрежда продуктите в поръчката
        private void FormatListItem(object sender, ListControlConvertEventArgs e)
        {

            string currentName = ((Product)e.ListItem).Name;
            decimal currentPrice = (decimal)((Product)e.ListItem).Price;
            string currency = ((Product)e.ListItem).Currency;

            string currentNamePadded = (currentName.PadRight(40 - currentName.Length));

            if (e.ListItem.GetType() == typeof(Drinks))
            {
                e.Value = string.Format("{0}{1}{2}", currentNamePadded, currentPrice, currency);
            }
            else
            {
                if (((Extras)e.ListItem).IsExtraOfDrink)
                {
                    e.Value = string.Format("\t{0}{1}{2}", currentNamePadded, currentPrice, currency);
                }
                else
                {
                    e.Value = string.Format("{0}{1}{2}", currentNamePadded, currentPrice, currency);
                }
            }

        }

        //отваря се AddDrinks при цъкане в менюто
        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDrinks addDrinks = new AddDrinks(cultureInfo);
            addDrinks.CollectionChanged += addDrinks_CollectionChanged;
            addDrinks.ShowDialog();
        }

        //отваря се AddExtras при цъкане в менюто
        private void extraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddExtras addExtras = new AddExtras(cultureInfo);
            addExtras.CollectionChanged += addDrinks_CollectionChanged;
            addExtras.ShowDialog();
        }

        //десериализира при зареждане на формата
        private void Form1_FormLoad(object sender, EventArgs e)
        {
            //productsList = xml.Deserialize<List<Product>>();
            XmlService.ListOfProducts = XmlService.Deserialize<List<Product>>();
            AddProductsToPanel();
        }

        //сериализира при затваряне на програмата
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //xml.Serialize<List<Product>>(productsList);
            XmlService.Serialize<List<Product>>(XmlService.ListOfProducts);
        }

        //кликане на празно пространство
        private void MousePress(object sender, MouseEventArgs e)
        {
            int index;
            index = listProducts.IndexFromPoint(e.Location);
            if (index == -1)
            {
                listProducts.ClearSelected();
            }
        }

        //изчиства данните (нов клиент)
        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingProductList.Clear();
            txtChange.Text = "";
            txtGiven.Text = "";
            txtPay.Text = "";
            priceTotal = 0;
        }

        //бутон за плащане
        private void btnPay_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtGiven.Text))
            {
                decimal.TryParse(txtGiven.Text, out amountGiven);
            }

            amountChange = amountGiven - priceTotal;

            if (amountGiven < priceTotal)
            {
                MessageBox.Show("Invalid Input!");
                txtGiven.Text = "";
                amountGiven = 0;
                txtChange.Text = "";
                amountChange = 0;
            }

            txtChange.Text = String.Format("{0} {1}", amountChange, currency);

        }

        //групово селектиране
        private void listProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listProducts.SelectedItem != null)
            {
                if (listProducts.SelectedItem.GetType() == typeof(Drinks))
                {
                    foreach (Extras ex in (listProducts.SelectedItem as Drinks).ExtrasList)
                    {
                        //обектите влизат в SelectedItems
                        listProducts.SelectedItems.Add(ex);
                    }

                }
            }

        }

        //позволява само цифри в текстбокс Платено
        private void txtGiven_KeyPress(object sender, KeyPressEventArgs e)
        {
            //txtChange.MaxLength = 4;

            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)46)))
                e.Handled = true;
            //if (Regex.IsMatch(txtChange.Text, @"\.\d\d"))
            //{
            //    e.Handled = true;
            //}
        }


        //променя езика на контролите
        private void UpdateUIControls()
        {
            try
            {
                if (resourceManger != null)
                {
                    btnPay.Text = resourceManger.GetString("btnPay");
                    btnDelete.Text = resourceManger.GetString("btnDelete");
                    lblAmountToPay.Text = resourceManger.GetString("lblPay");
                    lblAmountGiven.Text = resourceManger.GetString("lblGiven");
                    lblChange.Text = resourceManger.GetString("lblChange");
                    dataToolStripMenuItem.Text = resourceManger.GetString("Data");
                    newCustomerToolStripMenuItem.Text = resourceManger.GetString("NewCustomer");
                    addProductToolStripMenuItem.Text = resourceManger.GetString("AddProduct");
                    drinksToolStripMenuItem.Text = resourceManger.GetString("AddDrink");
                    extraToolStripMenuItem.Text = resourceManger.GetString("AddExtra");
                    viewToolStripMenuItem.Text = resourceManger.GetString("View");
                    languageToolStripMenuItem.Text = resourceManger.GetString("Language");
                    englishToolStripMenuItem.Text = resourceManger.GetString("English");
                    bulgarianToolStripMenuItem.Text = resourceManger.GetString("Bulgarian");
                    tabPanel.TabPages[0].Text = resourceManger.GetString("tabDrinks");
                    tabPanel.TabPages[1].Text = resourceManger.GetString("tabExtras");
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //сменя езика на английски
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string culture = "en-US";
            cultureInfo = new CultureInfo(culture);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture);
            UpdateUIControls();
        }

        //сменя езика на български
        private void bulgarianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string culture = "bg-BG";
            cultureInfo = new CultureInfo(culture);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture);
            UpdateUIControls();
        }

        public string Currency
        {
            get
            {
                return currency;
            }
            set
            {
                currency = value;
            }
        }

        public decimal PriceTotal
        {
            get
            {
                return priceTotal;
            }
            set
            {
                priceTotal = value;
                txtPay.Text = String.Format("{0} {1}", priceTotal, currency);
            }
        }


        //if (listProducts.Items.Count > 0)
        //{
        //    btnDelete.Enabled = true;
        //}
        //else
        //{
        //    btnDelete.Enabled = false;
        //}

        //Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ",";

    }

}
