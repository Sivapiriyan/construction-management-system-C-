using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_Lotus_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
           
        

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee product = new Employee();
            product.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sale sale = new Sale();
            sale.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Sales_Details sd = new Sales_Details();
            sd.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_Cus cus = new add_Cus();
            cus.Show();
        }

        private void labeltime_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client client = new Client();
            client.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Project project = new Project();
            project.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            Leave leave = new Leave();
            leave.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee product = new Employee();
            product.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client client = new Client();
            client.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Project project = new Project();
            project.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
            Leave leave = new Leave();
            leave.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
