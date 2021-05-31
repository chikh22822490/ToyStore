using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToyStore
{
    public partial class Catalog : UserControl
    {
        public Catalog()
        {
            InitializeComponent();
        }

        #region Properties
        private string _name;
        private string _type;
        private string _description;
        private string _price;
        private Image _image;
        private string _minAge;
        private string _maxAge;
        private string _stock;

        [Category("Custom Props")]
        public string Name
        {
            get { return _name; }
            set { _name = value; lblName.Text = value; }
        }

        [Category("Custom Props")]
        public string Price
        {
            get { return _price; }
            set { _price = value; lblPrice.Text = value; }
        }

        [Category("Custom Props")]
        public string Description
        {
            get { return _description; }
            set { _description = value; lblDescription.Text = value; }
        }

        [Category("Custom Props")]
        public string Type
        {
            get { return _type; }
            set { _type = value; lblType.Text = value; }
        }

        [Category("Custom Props")]
        public Image Image
        {
            get { return _image; }
            set { _image = value; img_toy.Image = value; }
        }

        [Category("Custom Props")]
        public string MinAge
        {
            get { return _minAge; }
            set { _minAge = value; lbl_minAge.Text = value; }
        }

        [Category("Custom Props")]
        public string MaxAge
        {
            get { return _maxAge; }
            set { _maxAge = value; lbl_maxAge.Text = value; }
        }

        [Category("Custom Props")]
        public string Stock
        {
            get { return _stock; }
            set { _stock = value; lblStock.Text = value; }
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightCyan;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }




        #endregion

        /*private void Catalog_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.LightCyan;
        }*/
    }
}
