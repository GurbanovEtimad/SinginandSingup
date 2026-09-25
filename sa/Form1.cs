namespace sa
{
    public partial class Form1 : Form
    {

        private static readonly List<User> Users = new List<User>();

        public Form1()
        {
            InitializeComponent();


            textBox2.UseSystemPasswordChar = true;
            textBox3.UseSystemPasswordChar = true;


            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            button1.Click += button1_Click;

            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            button2.Click += button2_Click;
        }


        private void checkBox1_CheckedChanged(object? sender, EventArgs e)
        {

            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }


        private void button1_Click(object? sender, EventArgs e)
        {
            var username = textBox1.Text.Trim();
            var password = textBox2.Text ?? string.Empty;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.", "Sign in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = Users.Find(u => string.Equals(u.Username, username, StringComparison.OrdinalIgnoreCase));
            if (user != null && user.Password == password)
            {
                MessageBox.Show("Login successful.", "Sign in", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Sign in", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void checkBox2_CheckedChanged(object? sender, EventArgs e)
        {
            textBox3.UseSystemPasswordChar = !checkBox2.Checked;
        }


        private void button2_Click(object? sender, EventArgs e)
        {
            var username = textBox4.Text.Trim();
            var password = textBox3.Text ?? string.Empty;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter username and password to sign up.", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Users.Exists(u => string.Equals(u.Username, username, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Username already exists.", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Users.Add(new User { Username = username, Password = password });
            MessageBox.Show("Registration successful.", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private class User
        {
            public required string Username { get; init; }
            public required string Password { get; init; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
