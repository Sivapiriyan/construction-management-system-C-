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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            
        }
        DataTable table;
        MySqlConnection Connection = new MySqlConnection("datasource = localhost;port = 3306;Initial Catalog = 'wfm-cms';username = root;password ='root'");
        MySqlCommand command;


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }

        private void labelsec_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labeltime_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee product = new Employee();
            product.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            Populate();
        }
        public void Populate()
        {
            string selectQuery = "SELECT * FROM employee";
             table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, Connection);
            adapter.Fill(table);
            bunifuCustomDataGrid1.DataSource = table;
        }

        private void bunifuCustomDataGrid1_MouseClick(object sender, MouseEventArgs e)
        {
            bunifuMetroTextbox_id.Text = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
            bunifuMetroTextbox_name.Text = bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
            bunifuMetroTextbox_color.Text = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
            bunifuMetroTextbox_price.Text = bunifuCustomDataGrid1.CurrentRow.Cells[3].Value.ToString();
            bunifuMetroTextbox_qty.Text = bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString();
        }

        public void openConnection()
        {
            if(Connection.State == ConnectionState.Closed)
            {
                Connection.Open();

            }
        }

        public void closeConnection()
        {
            if(Connection.State == ConnectionState.Open)
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

                if(command.ExecuteNonQuery() == 1)
                {

                    MessageBox.Show("SUCCESS", "SUCCESS");

                }
                else
                {
                    MessageBox.Show("ERROR", "ERROR");

                }

            }catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }finally
            {
                closeConnection();
            }
        }

        private void button_addprod_Click(object sender, EventArgs e)
        {
         
            if (
            bunifuMetroTextbox_name.Text == "" ||
            bunifuMetroTextbox_color.Text == "" ||
            bunifuMetroTextbox_price.Text == "" ||
            bunifuMetroTextbox_qty.Text == "")
            {
                MessageBox.Show("Fill all boxes to add new employee", "Error");
            }
            else
            {
                string insertQuery = ("INSERT INTO employee(Name,NIC,TeleNumber,Role)VALUES('" + bunifuMetroTextbox_name.Text + "','" + bunifuMetroTextbox_color.Text + "','" + bunifuMetroTextbox_price.Text + "','" + bunifuMetroTextbox_qty.Text + "')");
                executeQuery(insertQuery);
                Populate();
                bunifuMetroTextbox_id.Text = "";
                bunifuMetroTextbox_name.Text = "";
                bunifuMetroTextbox_color.Text = "";
                bunifuMetroTextbox_price.Text = "";
                bunifuMetroTextbox_qty.Text = "";                
            }

          
        }

        private void button_updateprod_Click(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox_id.Text != "" &&
            bunifuMetroTextbox_name.Text != "" &&
            bunifuMetroTextbox_color.Text != "" &&
            bunifuMetroTextbox_price.Text != "" &&
            bunifuMetroTextbox_qty.Text != "")
            {
                string updateQuery = "UPDATE employee SET Name = '" + bunifuMetroTextbox_name.Text + "',NIC = '" + bunifuMetroTextbox_color.Text + "',TeleNumber = '" + bunifuMetroTextbox_price.Text + "',Role = '" + bunifuMetroTextbox_qty.Text + "' WHERE ID = " + int.Parse(bunifuMetroTextbox_id.Text);
                executeQuery(updateQuery);
                Populate();
                bunifuMetroTextbox_id.Text = "";
                bunifuMetroTextbox_name.Text = "";
                bunifuMetroTextbox_color.Text = "";
                bunifuMetroTextbox_price.Text = "";
                bunifuMetroTextbox_qty.Text = "";             
            }
            else
            {
                MessageBox.Show("Please Select a record to be Update", "ERROR");
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {   
            if (bunifuMetroTextbox_id.Text != ""&&
            bunifuMetroTextbox_name.Text != "" &&
            bunifuMetroTextbox_color.Text != "" &&
            bunifuMetroTextbox_price.Text != "" &&
            bunifuMetroTextbox_qty.Text != "")
            {
                string deleteQuery = "DELETE FROM employee WHERE ID = " + int.Parse(bunifuMetroTextbox_id.Text);
                executeQuery(deleteQuery);
                Populate();
                bunifuMetroTextbox_id.Text = "";
                bunifuMetroTextbox_name.Text = "";
                bunifuMetroTextbox_color.Text = "";
                bunifuMetroTextbox_price.Text = "";
                bunifuMetroTextbox_qty.Text = "";             
            }
            else
            {
                MessageBox.Show("Please Select a record to be delete" ,"ERROR");
            }
            
            
        }

        private void bunifuMetroTextbox_search_OnValueChanged(object sender, EventArgs e)
        {
            DataView view = new DataView(table);
            view.RowFilter = string.Format("Name LIKE '%{0}%'", bunifuMetroTextbox_search.Text);
            bunifuCustomDataGrid1.DataSource = view;


        }

        private void search(object sender, EventArgs e)
        {
        }

        private void searchleave(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_Cus cus = new add_Cus();
            cus.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Sale sale = new Sale();
            sale.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Sales_Details sd = new Sales_Details();
            sd.Show();
        }

        private void bunifuMetroTextbox_id_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Client client = new Client();
            client.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Project project = new Project();
            project.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Leave leave = new Leave();
            leave.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form1 home = new Form1();
            home.Show();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            DataView view = new DataView(table);
            view.RowFilter = string.Format("NIC LIKE '%{0}%'", bunifuMetroTextbox1.Text);
            bunifuCustomDataGrid1.DataSource = view;
        }
    }
}
