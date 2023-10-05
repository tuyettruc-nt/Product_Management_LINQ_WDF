using System.Text.RegularExpressions;

namespace ManageProduct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Product> lstProduct = new List<Product>();
        private void Form1_Load(object sender, EventArgs e)
        {
            lstProduct = new List<Product>();
            lstProduct.Add(new Product { ID = "PR1", Name = "Cocacola", Amount = 50, Price = 10000, Origin = "Việt Nam", Date = new DateTime(2022, 5, 7) });
            lstProduct.Add(new Product { ID = "PR2", Name = "Olong", Amount = 45, Price = 7000, Origin = "Đài Loan", Date = new DateTime(2021, 10, 3) });
            lstProduct.Add(new Product { ID = "PR3", Name = "C2", Amount = 30, Price = 7500, Origin = "Đài Loan", Date = new DateTime(2023, 10, 5) });
            lstProduct.Add(new Product { ID = "PR4", Name = "Pepsi", Amount = 100, Price = 8000, Origin = "Campuchia", Date = new DateTime(2023, 10, 12) });
            lstProduct.Add(new Product { ID = "PR5", Name = "7 Up", Amount = 70, Price = 7600, Origin = "Thái Lan", Date = new DateTime(2021, 6, 12) });
            lstProduct.Add(new Product { ID = "PR6", Name = "Nutriboost", Amount = 80, Price = 9000, Origin = "Singapore", Date = new DateTime(2021, 10, 12) });
            lstProduct.Add(new Product { ID = "PR7", Name = "Sting", Amount = 35, Price = 8000, Origin = "Việt Nam", Date = new DateTime(2023, 11, 12) });
            lstProduct.Add(new Product { ID = "PR8", Name = "Bia Heneiken", Amount = 150, Price = 350000, Origin = "Hà Lan", Date = new DateTime(2022, 5, 17) });
            lstProduct.Add(new Product { ID = "PR9", Name = "Bia Saigon", Amount = 200, Price = 250000, Origin = "Việt Nam", Date = new DateTime(2023, 12, 1) });
            lstProduct.Add(new Product { ID = "PR10", Name = "Bia Tiger", Amount = 120, Price = 385000, Origin = "Việt Nam", Date = new DateTime(2022, 10, 12) });
            lstProduct.Add(new Product { ID = "PR11", Name = "Bia Ruby", Amount = 300, Price = 300000, Origin = "Na Uy", Date = new DateTime(2021, 1, 28) });
            listView1.Items.Clear();
            DisplayProduct(lstProduct, listView1);
        }

        private void DeleteText()
        {
            //txtID.Text = ""; cach 1
            txtID.Clear();
            txtName.Clear();
            txtAmount.Clear();
            txtPrice.Clear();
            txtOrigin.Clear();
        }

        private void DisplayProduct(List<Product> listPro, ListView listView)
        {
            listView.Items.Clear();
            listPro.ForEach(p =>
            {
                ListViewItem lstView = new ListViewItem(p.ID);
                lstView.SubItems.Add(p.Name);
                lstView.SubItems.Add(p.Amount + "");
                lstView.SubItems.Add(p.Price + "");
                lstView.SubItems.Add(p.Origin);
                lstView.SubItems.Add(p.Date.ToString("dd/MM/yy"));
                if (p.Date < DateTime.Now)
                {
                    lstView.ForeColor = Color.Red;
                }
                else
                {
                    lstView.ForeColor = Color.Green;
                }
                listView.Items.Add(lstView);
            });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product pr = new Product();
            bool errors = false;
            try
            {
                string id = txtID.Text.Trim();
                if (string.IsNullOrEmpty(id))
                {
                    errors = true;
                    throw new ArgumentNullException("ID cannot null or empty!");
                }

                if (lstProduct.Any(x => x.ID == id))
                {
                    throw new ArgumentNullException("ID must be unique!");
                }

                if (string.IsNullOrEmpty(txtName.Text))
                {
                    errors = true;
                    throw new ArgumentNullException("Name cannot null or empty!");
                }

                if (lstProduct.Any(x => x.Name == txtName.Text))
                {
                    throw new ArgumentNullException("Name must be unique!");
                }

                if (string.IsNullOrEmpty(txtOrigin.Text))
                {
                    errors = true;
                    throw new ArgumentNullException("Origin cannot null or empty!");
                }
                if (!int.TryParse(txtAmount.Text, out int count))
                {
                    errors = true;
                    throw new ArgumentNullException("Count cannot null or empty!");
                }

                if (!int.TryParse(txtPrice.Text, out int price))
                {
                    errors = true;
                    throw new ArgumentNullException("Price cannot null or empty!");
                }
                pr.Price = price;
                pr.Amount = count;
                pr.ID = txtID.Text;
                pr.Name = txtName.Text;
                pr.Origin = txtOrigin.Text;
                pr.Date = dateTimePicker1.Value;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!errors)
            {
                lstProduct.Add(pr);
                DeleteText();
                DisplayProduct(lstProduct, listView1);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn xóa!");
                return;
            }
            int prIndex = listView1.SelectedIndices[0];
            lstProduct.RemoveAt(prIndex);
            DisplayProduct(lstProduct, listView1);
        }

        private void btnPriceMax_Click(object sender, EventArgs e)
        {
            //C1
            /*            int prMax = lstProduct.Max(x => x.Price);
                        MessageBox.Show("Sản phẩm có giá trị lớn nhất là " + prMax);*/
            //C2
            Product pr = lstProduct[0];
            for (int i = 0; i < lstProduct.Count; i++)
            {
                if (pr.Price < lstProduct[i].Price)
                {
                    pr = lstProduct[i];
                }
            }
            List<Product> maxProduct = new List<Product>() { pr };
            DisplayProduct(maxProduct, listView2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool prDate = lstProduct.Any(x => x.Date <= DateTime.Now);
            listView2.Items.Clear();
            if (prDate)
            {
                MessageBox.Show("Có sản phẩm hết hạn!");
            }
            else
            {
                MessageBox.Show("Không có sản phẩm hết hạn");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPriceFrom.Text, out int minValue))
            {
                MessageBox.Show("Price start cannot null or empty!");
            }
            if (!int.TryParse(txtPriceTo.Text, out int maxValue))
            {
                MessageBox.Show("Price to cannot null or empty!");
            }

            var priceQuery = from x in lstProduct
                             where x.Price >= minValue && x.Price <= maxValue
                             select x;
            listView2.Items.Clear();
            foreach (var p in priceQuery)
            {
                ListViewItem lstView = new ListViewItem(p.ID);
                lstView.SubItems.Add(p.Name);
                lstView.SubItems.Add(p.Amount + "");
                lstView.SubItems.Add(p.Price + "");
                lstView.SubItems.Add(p.Origin);
                lstView.SubItems.Add(p.Date.ToString("dd/MM/yy"));
                listView2.Items.Add(lstView);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string find = textBox3.Text;
            if (!string.IsNullOrEmpty(find))
            {
                MessageBox.Show("The value that you want to find cannot empty or null!");
            }
            var findOrigin = lstProduct.Where(x => x.Origin == find).ToList();
            listView2.Items.Clear();
            foreach (var p in findOrigin)
            {
                ListViewItem lstView = new ListViewItem(p.ID);
                lstView.SubItems.Add(p.Name);
                lstView.SubItems.Add(p.Amount + "");
                lstView.SubItems.Add(p.Price + "");
                lstView.SubItems.Add(p.Origin);
                lstView.SubItems.Add(p.Date.ToString("dd/MM/yy"));
                listView2.Items.Add(lstView);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstProduct.Count; i++)
            {
                if (string.Compare(lstProduct[i].Origin, textBox4.Text, true) == 0)
                {
                    lstProduct.RemoveAt(i);
                }
                DisplayProduct(lstProduct, listView2);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox5.Text, out int minValue))
            {
                MessageBox.Show("Amount start cannot null or empty!");
            }
            if (!int.TryParse(textBox6.Text, out int maxValue))
            {
                MessageBox.Show("Amount to cannot null or empty!");
            }
            var countQuery = lstProduct.Where(x => minValue <= x.Amount && x.Amount <= maxValue);
            listView2.Items.Clear();
            foreach (var p in countQuery)
            {
                ListViewItem lstView = new ListViewItem(p.ID);
                lstView.SubItems.Add(p.Name);
                lstView.SubItems.Add(p.Amount + "");
                lstView.SubItems.Add(p.Price + "");
                lstView.SubItems.Add(p.Origin);
                lstView.SubItems.Add(p.Date.ToString("dd/MM/yy"));
                listView2.Items.Add(lstView);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime minDay = dateTimePicker2.Value.Date;
            DateTime maxDay = dateTimePicker2.Value.Date;
            var dateQuery = lstProduct.FindAll(x => minDay <= x.Date && x.Date <= maxDay);
            listView2.Items.Clear();
            DisplayProduct(dateQuery, listView2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var proDate = lstProduct.Where(x => x.Date < DateTime.Now).ToList();
            DisplayProduct(proDate, listView2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lstProduct.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lstProduct.RemoveAll(x => x.Date < DateTime.Now);
            listView2.Items.Clear();
            foreach (var p in lstProduct)
            {
                ListViewItem lstView = new ListViewItem(p.ID);
                lstView.SubItems.Add(p.Name);
                lstView.SubItems.Add(p.Amount + "");
                lstView.SubItems.Add(p.Price + "");
                lstView.SubItems.Add(p.Origin);
                lstView.SubItems.Add(p.Date.ToString("dd/MM/yy"));
                listView2.Items.Add(lstView);
            }
        }
    }
}