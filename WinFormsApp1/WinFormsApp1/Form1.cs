using System.ComponentModel;
using System.Data.SqlClient;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sq = new SqlConnection(@"Data Source=LAB109PC22\SQLEXPRESS; Initial Catalog=NOTES; Integrated Security=True; Encrypt=False;"))
            {
                sq.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO JOHN (Title, [Content], TimeStamp) VALUES (@Title, @Content, @TimeStamp)", sq);
                cmd.Parameters.AddWithValue("title", textBox1.Text);
                cmd.Parameters.AddWithValue("content", richTextBox1.Text);
                cmd.Parameters.AddWithValue("timeStamp", DateTime.Now);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sq = new SqlConnection(@"Data Source=LAB109PC22\SQLEXPRESS; Initial Catalog=NOTES; Integrated Security=True; Encrypt=False;"))
            {
                sq.Open();
                SqlCommand cmd = new SqlCommand("Delete from JOHN where Title = @Title", sq);
                cmd.Parameters.AddWithValue("Title", textBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("DELETE.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection sq = new SqlConnection(@"Data Source=LAB109PC22\SQLEXPRESS; Initial Catalog=NOTES; Integrated Security=True; Encrypt=False;"))
            {
                sq.Open();
                SqlCommand cmd = new SqlCommand("Select [Content] from JOHN where Title = @Title", sq);
                cmd.Parameters.AddWithValue("Title", textBox1.Text);
                string content = (cmd.ExecuteScalar()).ToString();
                richTextBox1.Text = content;

                cmd = new SqlCommand("Select timestamp from JOHN where Title = @Title", sq);
                cmd.Parameters.AddWithValue("Title", textBox1.Text);
                content = (cmd.ExecuteScalar()).ToString();
                label2.Text = content;
            }
        }
    }
}
