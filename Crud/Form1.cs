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
            
            SqlCommand command = new SqlCommand("insert into ProductInfo_Tab values('" + int.Parse(textBox1.Text) + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + comboBox1.Text + "', getdate())", con);
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
    }
}