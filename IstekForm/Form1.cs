using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
namespace IstekForm

{
    public partial class Form1 : Form
    {

        string totalString = string.Empty;
        string connectionString = "Data Source=KURHAN\\SQLEXPRESS;Initial Catalog=istek;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void paradorText_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (towelBox.Checked)
            {
                totalString += "I want towel\n";
            }
            if (pillowBox.Checked)
            {
                totalString += "I want pillow\n";
            }
            if (blanketBox.Checked)
            {
                totalString += "I want blanket\n";
            }
            if (sheetBox.Checked)
            {
                totalString += "I want sheets for my bed\n";
            }
            if (shampooBox.Checked)
            {
                totalString += "I want shampoo\n";
            }
            if (showerBox.Checked)
            {
                totalString += "I want shower gel\n";
            }

            string addRequest = specialBox.Text;

            if (addRequest != null)
            {
                totalString += addRequest;
            }



            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Requests (RequestText) VALUES (@text)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@text", totalString);
                cmd.ExecuteNonQuery();
                conn.Close();

            }

            MessageBox.Show("Ýstek baþarýyla kayýt edildi.\n\n" + totalString, "Ýstek Listesi");
            LoadRequests();

        }


        private void LoadRequests()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Requests";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Requests SET Status = 1 WHERE Id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", selectedID);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Ýstek tamamlandý olarak iþaretlendi");
                LoadRequests();

            }
            else
            {
                MessageBox.Show("Lütfen önce bir istek seçiniz.");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure that you want to delete this row", "Accepted to delete",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                int selectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Requests WHERE Id = @id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", selectedID);
                        cmd.ExecuteNonQuery();

                    }

                    MessageBox.Show("Ýstek baþarýyla silindi");
                    LoadRequests();
                }
                else
                {
                    MessageBox.Show("Please choose a request to delete");
                }



            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir istek seçiniz");
            }
        }
    }


}
