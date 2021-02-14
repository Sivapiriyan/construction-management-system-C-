using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Black_Lotus_CSharp
{
    public partial class Sales_Details : Form
    {
        public Sales_Details()
        {
            InitializeComponent();
            
        }
        MySqlConnection Connection = new MySqlConnection("datasource = localhost;port = 3306;Initial Catalog = 'black_lotus';username = root;password =");
        MySqlCommand command;
        MySqlDataReader mdr;
       // DataTable dt;

        private void Sales_Details_Load(object sender, EventArgs e)
        {
            String select = "select * from sales";
            String select2 = "select * from customer";
            MySqlCommand comd = new MySqlCommand(select, Connection);
            MySqlDataAdapter da = new MySqlDataAdapter(comd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuCustomDataGrid1.AutoGenerateColumns = false;
            bunifuCustomDataGrid1.DataSource = dt;
            Connection.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Connection.Open();
            String query = "SELECT * FROM customer WHERE CustomerID =" + int.Parse(bunifuMetroTextbox_scusid.Text);
            command = new MySqlCommand(query, Connection);
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                bunifuMetroTextbox_name1.Text = mdr.GetString("Firstname");
                bunifuMetroTextbox_name2.Text = mdr.GetString("Lastname");
                bunifuMetroTextbox_mobile.Text = mdr.GetString("Mobile");
                bunifuMetroTextbox_nic.Text = mdr.GetString("NIC");


            }
            else
            {
                MessageBox.Show("No data");

            }
            Connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Sales_Details sd = new Sales_Details();
            sd.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            add_Cus add = new add_Cus();
            add.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Sale sale = new Sale();
            sale.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Employee prod = new Employee();
            prod.Show();

        }

        //private void bunifuMetroTextbox_search_OnValueChanged(object sender, EventArgs e)
        //{
        //    DataView view = new DataView(dt);
        //    view.RowFilter = string.Format("Date LIKE '%{0}%'", bunifuMetroTextbox_search.Text);
        //    bunifuCustomDataGrid1.DataSource = view;
        //}
    }
}
