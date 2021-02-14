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
    public partial class add_Cus : Form
    {
        public add_Cus()
        {
            InitializeComponent();
            Load2();
        }
        DataTable table;
        MySqlConnection Connection = new MySqlConnection("datasource = localhost;port = 3306;Initial Catalog = 'black_lotus';username = root;password =");
        MySqlCommand command;

    
        public void  Load2()
        {
            string selectQuery = "SELECT * FROM customer";
            table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, Connection);
            adapter.Fill(table);
            bunifuCustomDataGrid_cus.DataSource = table;
        }

        public void openConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();

            }
        }

        public void closeConnection()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }
        public void executeQuery(string query)
        {
            try
            {

                openConnection();
                command = new MySqlCommand(query, Connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    Popup pp = new Popup();
                    pp.ShowDialog();
                    // MessageBox.Show("Query Executed");

                }
                else
                {
                    popupNon pnon = new popupNon();
                    pnon.ShowDialog();
                    //  MessageBox.Show("Query Not Executed");
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        private void button_addprod_Click(object sender, EventArgs e)
        {
            //Insert Query
            string insertQuery = ("INSERT INTO customer(Firstname,Lastname,Mobile,NIC)VALUES('" + bunifuMetroTextbox_fname.Text + "','" + bunifuMetroTextbox_lname.Text + "','" + bunifuMetroTextbox_telno.Text + "','" + bunifuMetroTextbox_nic.Text + "')");
            executeQuery(insertQuery);
            //System.Windows.Forms.MessageBox.Show("New Flower Added");
            // Popup pp = new Popup();
            //  pp.ShowDialog();
            Load2();

            // For Empty textbox after insert
            bunifuMetroTextbox_cusid.Text = "";
            bunifuMetroTextbox_fname.Text = "";
            bunifuMetroTextbox_lname.Text = "";
            bunifuMetroTextbox_telno.Text = "";
            bunifuMetroTextbox_nic.Text = "";
        }

        private void bunifuCustomDataGrid_cus_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            bunifuMetroTextbox_cusid.Text = bunifuCustomDataGrid_cus.CurrentRow.Cells[0].Value.ToString();
            bunifuMetroTextbox_fname.Text = bunifuCustomDataGrid_cus.CurrentRow.Cells[1].Value.ToString();
            bunifuMetroTextbox_lname.Text = bunifuCustomDataGrid_cus.CurrentRow.Cells[2].Value.ToString();
            bunifuMetroTextbox_telno.Text = bunifuCustomDataGrid_cus.CurrentRow.Cells[5].Value.ToString();
            bunifuMetroTextbox_nic.Text = bunifuCustomDataGrid_cus.CurrentRow.Cells[6].Value.ToString();
        }

        private void button_updateprod_Click(object sender, EventArgs e)
        {
            // Update Query
            string updateQuery = "UPDATE customer SET Firstname = '" + bunifuMetroTextbox_fname.Text + "',Lastname = '" + bunifuMetroTextbox_lname.Text + "',Mobile = '" + bunifuMetroTextbox_telno.Text + "',NIC = '" + bunifuMetroTextbox_nic.Text + "' WHERE CustomerID = " + int.Parse(bunifuMetroTextbox_cusid.Text);
            executeQuery(updateQuery);
            // Popup pp = new Popup();
            //pp.ShowDialog();
            // System.Windows.Forms.MessageBox.Show("Details Updated");
            Load2();

            // For Empty textbox after update
            bunifuMetroTextbox_cusid.Text = "";
            bunifuMetroTextbox_fname.Text = "";
            bunifuMetroTextbox_lname.Text = "";
            bunifuMetroTextbox_telno.Text = "";
            bunifuMetroTextbox_nic.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Delete Query
            string deleteQuery = "DELETE FROM customer WHERE CustomerID = " + int.Parse(bunifuMetroTextbox_cusid.Text);
            executeQuery(deleteQuery);
            // Popup pp = new Popup();
            // pp.ShowDialog();
            //System.Windows.Forms.MessageBox.Show("Flower Deleted");
            Load2();
            //For Empty textbox after delete
            bunifuMetroTextbox_cusid.Text = "";
            bunifuMetroTextbox_fname.Text = "";
            bunifuMetroTextbox_lname.Text = "";
            bunifuMetroTextbox_telno.Text = "";
            bunifuMetroTextbox_nic.Text = "";
        }

        private void bunifuMetroTextbox_search_OnValueChanged(object sender, EventArgs e)
        {
            DataView view = new DataView(table);
            view.RowFilter = string.Format("Firstname LIKE '%{0}%'", bunifuMetroTextbox_search.Text);
            bunifuCustomDataGrid_cus.DataSource = view;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_Cus cus = new add_Cus();
            cus.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee prod = new Employee();
            prod.Show();
        }

        private void add_Cus_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Sales_Details sd = new Sales_Details();
            sd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Sale sale = new Sale();
            sale.Show();

        }

        private void bunifuCustomDataGrid_cus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_Cus_Load_1(object sender, EventArgs e)
        {

        }
    }
}
