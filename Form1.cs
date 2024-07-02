using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            resetData();
            try
            {
                // Create a Customer
                Customer customer = new Customer();

                // Get all orderIds
                List<Customer> orderIds = customer.GetAll();

                string orderStr = txtSearch.Text;
                int orderInt = 0;

                // Check if the order can be converted
                if (int.TryParse(orderStr, out orderInt))
                {
                    int orderId = orderInt;
                    if (orderIds.Find(x => x.OrderId == orderId) is not null)
                    {
                        customer = customer.SearchOrder(orderId);
                        lblCompanyName.Text = customer.CompanyName;
                        lblCompanyAddress.Text = customer.Address;

                        List<Product> products = customer.GetProductsByOrderId();
                        if (products.Count < 1)
                        {
                            lblError.Text = "No hay productos bajo esta orden";
                        }
                        else
                        {
                            dgvOrders.DataSource = products;
                        }
                    }
                    else
                    {
                        string message = "El numero de orden no es valido";
                        MessageBox.Show(message);
                    }
                }
                else
                {
                    MessageBox.Show("El numero no pudo ser convertido correctamente. Comprueba haber ingresado un numero valido (no caracteres, no decimales) y que no sea demasiado grande o demasiado pequeño.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void resetData()
        {
            lblCompanyName.Text = String.Empty;
            lblCompanyAddress.Text = String.Empty;
            lblError.Text = String.Empty;
            dgvOrders.DataSource = null;
        }
    }
}
