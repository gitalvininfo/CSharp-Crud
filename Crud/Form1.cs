using System.Data.SqlClient;
using System.Data;

namespace Crud
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BM4QHGC\SQLEXPRESS;Initial Catalog=ProgrammingTutorialDB;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            
            SqlCommand command = new SqlCommand("insert into ProductInfo_Tab values('" + int.Parse(textBox1.Text) + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + comboBox1.Text + "', getdate(), getdate())", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted");
            con.Close();
            BindData(); 
        }

        public void BindData()
        {
            SqlCommand command = new SqlCommand("select * from ProductInfo_Tab", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update ProductInfo_Tab set ItemName = '" + textBox2.Text + "', Design = '" + textBox3.Text + "', Color = '" + comboBox1.Text + "', UpdateDate = getdate() where ProductID = '" + int.Parse(textBox1.Text) + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully updated");
            BindData();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("Delete ProductInfo_Tab where ProductID = '" + int.Parse(textBox1.Text) + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully deleted.");
            BindData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from ProductInfo_Tab where ProductID = '" + int.Parse(textBox1.Text) + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}