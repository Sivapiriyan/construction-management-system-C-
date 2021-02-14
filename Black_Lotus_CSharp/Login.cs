using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Black_Lotus_CSharp
{
    public partial class Login : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source = localhost;port = 3306;Initial Catalog = wfm-cms;User Id = root;password='root'");
        int x;
        public Login()
        {
            InitializeComponent();
        
        
        }   

        private void bunifuMetroTextbox1_Enter(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "";
        }

        private void bunifuMetroTextbox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bunifuMetroTextbox1.Text))
            {
                bunifuMetroTextbox1.Text = "Username";
            }
        }

        private void bunifuMetroTextbox2_Enter(object sender, EventArgs e)
        {
            bunifuMetroTextbox2.Text = "";
        }

        private void bunifuMetroTextbox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bunifuMetroTextbox2.Text))
            {
                bunifuMetroTextbox2.Text = "Password";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
          
            {
                x = 0;
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Admin where username = '" + bunifuMetroTextbox1.Text + "' and password = '" + bunifuMetroTextbox2.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                x = Convert.ToInt32(dt.Rows.Count.ToString());

                if (x == 0)
                {

                    MessageBox.Show("wrong password", "Error");
                }
                else
                {
                   
                    MessageBox.Show("Login Successfully", "success");
                    this.Hide();
                    Form1 home = new Form1();
                    home.Show();
                }
                con.Close();
            }
            
        }
    }
}
