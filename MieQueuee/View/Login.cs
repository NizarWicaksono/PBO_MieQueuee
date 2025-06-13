using MieQueuee.Controller;
using MieQueuee.View;
using MieQueuee.Model;

namespace MieQueuee
{
    public partial class Login : Form
    {
        private bool isPasswordVisible = false;

        public Login()
        {
            InitializeComponent();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                // Sembunyikan password
                textBox2.PasswordChar = '*';
                button1.Text = "👁️"; // atau ganti dengan "Lihat"
                isPasswordVisible = false;
            }
            else
            {
                // Tampilkan password
                textBox2.PasswordChar = '\0';
                button1.Text = "🙈"; // atau ganti dengan "Sembunyi"
                isPasswordVisible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBox1.Text;
                string password = textBox2.Text;

                LoginController controller = new LoginController();
                Users user = controller.Login(username, password);
                if (user != null)
                {

                    MessageBox.Show($"Login Berhasil");
                    Dashboard dashboard = new Dashboard();
                    this.Hide();
                    dashboard.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Username atau password salah.");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Gagal");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
