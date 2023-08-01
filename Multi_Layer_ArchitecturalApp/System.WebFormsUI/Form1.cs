using System.Business.Abstract;
using System.Business.Concrete;

using System.ComponentModel.DataAnnotations;
using System.DataAccess.Concrete.EntitiyFrameWork;
using System.Entities.Concrete;
using System.Net.Mail;

namespace System.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IProductManager productManager = new ProductManager(new EfProductDal());

        ICategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        private void Form1_Load(object sender, EventArgs e)
        {

            LoadAllProductList();

            LoadCategoriesToComboBox();

        }

        private void LoadCategoriesToComboBox()
        {
            cbxCategory.DataSource = categoryManager.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategoryIdAddBox.DataSource = categoryManager.GetAll();
            cbxCategoryIdAddBox.DisplayMember = "CategoryName";
            cbxCategoryIdAddBox.ValueMember = "CategoryId";

            cbxUpdateCategory.DataSource = categoryManager.GetAll();
            cbxUpdateCategory.DisplayMember = "CategoryName";
            cbxUpdateCategory.ValueMember = "CategoryId";
        }

        private void LoadCategories()
        {
            dgwProductList.DataSource = categoryManager.GetAll();
        }

        private void LoadAllProductList()
        {
            dgwProductList.DataSource = productManager.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProductList.DataSource = productManager.GetProductsBySelectedCategory(Convert.ToInt32(cbxCategory.SelectedValue));
                // At the first started moment, returns null value.So, We need to write into try - catch
            }
            catch
            {
            }

        }

        private void txtProducts_TextChanged(object sender, EventArgs e)
        {

            if (txtProducts.Text == null)
            {
                LoadAllProductList();

            }
            else
            {

                dgwProductList.DataSource = productManager.GetProductsByWritenProduct(txtProducts.Text);

            }

        }
        private void AddButton_Click(object sender, EventArgs e)
        {

            try
            {
                productManager.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbxCategoryIdAddBox.SelectedValue),
                    ProductName = txtProductNameAddBox.Text,
                    QuantityPerUnit = txtQuantityPerUnit.Text,
                    UnitPrice = Convert.ToDecimal(txtPrice.Text),
                    UnitsInStock = Convert.ToInt16(txtStockAmount.Text),


                });
                MessageBox.Show("Added!");
                LoadAllProductList();
            }
            catch (ValidationException exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void updatebutton_Click(object sender, EventArgs e)
        {


            try
            {
                productManager.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgwProductList.CurrentRow.Cells[0].Value),
                    ProductName = txtUpdateProductName.Text,
                    CategoryId = Convert.ToInt32(cbxUpdateCategory.SelectedValue),
                    UnitPrice = Convert.ToDecimal(txtUpdatePrice.Text),
                    UnitsInStock = Convert.ToInt16(txtStockAmount.Text),
                    QuantityPerUnit = txtQuantityPerUnit.Text,

                });
                MessageBox.Show("Updated!");
                LoadAllProductList();
            }
            catch (ValidationException exception)
            {

                MessageBox.Show(exception.Message);

            }

        }

        private void dgwProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtUpdateProductName.Text = dgwProductList.CurrentRow.Cells[1].Value.ToString();
            cbxUpdateCategory.SelectedValue = dgwProductList.CurrentRow.Cells[2].Value;
            txtUpdateQuantityPerUnit.Text = dgwProductList.CurrentRow.Cells[3].Value.ToString();
            txtUpdatePrice.Text = dgwProductList.CurrentRow.Cells[4].Value.ToString();
            txtUpdateStockAmount.Text = dgwProductList.CurrentRow.Cells[5].Value.ToString();


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (dgwProductList.CurrentRow != null)
            {
                try
                {
                    productManager.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProductList.CurrentRow.Cells[0].Value),

                    });
                    MessageBox.Show("The Product Deleted.");
                    LoadAllProductList();
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }


            }




        }
    }
}