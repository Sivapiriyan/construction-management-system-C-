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
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
            
        }
        DataTable table;
        MySqlConnection Connection = new MySqlConnection("datasource = localhost;port = 3306;Initial Catalog = 'black_lotus';username = root;password =");
        MySqlCommand command;
        MySqlDataReader mdr;
        private void bunifuMetroTextbox_scusid_OnValueChanged(object sender, EventArgs e)
        {
            

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Connection.Open();
            String query = "SELECT * FROM customer WHERE CustomerID =" + int.Parse(bunifuMetroTextbox_scusid.Text);
            command = new MySqlCommand(query, Connection);
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                bunifuMetroTextbox_sfname.Text = mdr.GetString("Firstname");
                bunifuMetroTextbox_slname.Text = mdr.GetString("Lastname");


            }
            else
            {
                MessageBox.Show("No Data Found");

            }
            Connection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Connection.Open();
            String query = "SELECT * FROM product WHERE ID =" + int.Parse(bunifuMetroTextbox1.Text);
            command = new MySqlCommand(query, Connection);
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                bunifuMetroTextbox3.Text = mdr.GetString("Name");
                bunifuMetroTextbox2.Text = mdr.GetString("Color");
                bunifuMetroTextbox_price.Text = mdr.GetString("Price");


            }
            else
            {
                MessageBox.Show("No Data Found");

            }
            Connection.Close();
        }
        public void viewdata()
        {
           
            String select = "select * from sales";
            MySqlCommand comd = new MySqlCommand(select, Connection);
            MySqlDataAdapter da = new MySqlDataAdapter(comd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuCustomDataGrid1.AutoGenerateColumns = false;
            bunifuCustomDataGrid1.DataSource = dt;
            Connection.Close();
        }
        private void Sale_Load(object sender, EventArgs e)
        {
            

            String time = DateTime.Now.ToString("HH:mm:ss");
            String date = DateTime.Now.ToString("yyyy:mm:dd");
            viewdata();
        }

        private void button_addprod_Click(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox_sfname.Text.Length==0|| bunifuMetroTextbox_scusid.Text.Length==0|| bunifuMetroTextbox_slname.Text.Length==0 || bunifuMetroTextbox1.Text.Length==0 || bunifuMetroTextbox3.Text.Length==0 || bunifuMetroTextbox2.Text.Length==0 || bunifuMetroTextbox_price.Text.Length==0 || bunifuMetroTextbox_qty.Text.Length==0)
            {
                MessageBox.Show("Please Fill All Boxes");
            }
            else
            {
                String select = "select * from product where ID='"+ bunifuMetroTextbox1.Text+ "'and Quantity > '"+bunifuMetroTextbox_qty.Text+"' ";
                MySqlCommand comd = new MySqlCommand(select, Connection);
                MySqlDataAdapter da = new MySqlDataAdapter(comd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Connection.Open();
                if (dt.Rows.Count>=1)
                {
                    string insert = "INSERT INTO `sales`(`Date`, `Time`, `CustomerID`, `ID`, `Name`, `Color`, `Price`, `Quantity`, `Total`) VALUES ('"+ DateTime.Now.ToString("yyyy:mm:dd")+ "','"+ DateTime.Now.ToString("HH:mm:ss") + "','"+bunifuMetroTextbox_scusid.Text+"','"+bunifuMetroTextbox1.Text+ "','" + bunifuMetroTextbox3.Text + "','" + bunifuMetroTextbox2.Text + "','" + bunifuMetroTextbox_price.Text + "','" + bunifuMetroTextbox_qty.Text + "','" + bunifuMetroTextbox4.Text + "')";
                    string decress = "update product set Quantity=Quantity-'" + bunifuMetroTextbox_qty.Text + "'where ID ='"+bunifuMetroTextbox1.Text+"'";
                    MySqlCommand comd1 = new MySqlCommand(insert, Connection);
                    MySqlCommand comd2 = new MySqlCommand(decress, Connection);
                    
                    if (comd1.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Successfull !!!");
                        comd2.ExecuteNonQuery();
                        viewdata();
                        bunifuMetroTextbox_scusid.Text = "";
                        bunifuMetroTextbox_price.Text = "";
                        bunifuMetroTextbox_qty.Text = "";
                        bunifuMetroTextbox1.Text = "";
                        bunifuMetroTextbox2.Text = "";
                        bunifuMetroTextbox3.Text = "";
                        bunifuMetroTextbox4.Text = "";
                        bunifuMetroTextbox_sfname.Text = "";
                        bunifuMetroTextbox_slname.Text = "";



                    }
                }
                else
                {
                    MessageBox.Show("Item Not Available Here");
                }
                Connection.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox_qty.Text.Length == 0 || bunifuMetroTextbox_price.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Quantity");
            }
            else
            {
                int qyt = Convert.ToInt32(bunifuMetroTextbox_qty.Text);
                int price = Convert.ToInt32(bunifuMetroTextbox_price.Text);
                int total = qyt * price;
                bunifuMetroTextbox4.Text = Convert.ToString(total);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_Cus cus = new add_Cus();
            cus.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sale sal = new Sale();
            sal.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox_search_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Sales_Details sd = new Sales_Details();
            sd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Employee prod = new Employee();
            prod.Show();
        }
    }
}
