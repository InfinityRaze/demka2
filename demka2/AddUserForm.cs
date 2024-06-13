using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demka2
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
            LoadRoles();
        }

        private void LoadRoles()
        {
            string connectionString = "Data Source = DESKTOP-RJGLL1R\\SQLEXPRESS; Initial catalog=demka2; Integrated Security=true";
            string query = "SELECT userroleid, namerole FROM [demka2].[dbo].[userrole]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    roleComboBox.Items.Add(new { Id = reader.GetInt32(0), Name = reader.GetString(1) });
                }
                roleComboBox.DisplayMember = "Name";
                roleComboBox.ValueMember = "Id";
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastnameTextBox.Text) || string.IsNullOrEmpty(firstnameTextBox.Text) ||
                string.IsNullOrEmpty(middlenameTextBox.Text) || string.IsNullOrEmpty(loginTextBox.Text) ||
                string.IsNullOrEmpty(passwordTextBox.Text) || roleComboBox.SelectedItem == null)
            {
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Data Source = DESKTOP-RJGLL1R\\SQLEXPRESS; Initial catalog=demka2; Integrated Security=true";
            string query = "INSERT INTO [demka2].[dbo].[user] (login, password, lastname, firstname, middlename, userroleid) " +
                           "VALUES (@login, @password, @lastname, @firstname, @middlename, @userroleid)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@login", loginTextBox.Text);
                command.Parameters.AddWithValue("@password", passwordTextBox.Text);
                command.Parameters.AddWithValue("@lastname", lastnameTextBox.Text);
                command.Parameters.AddWithValue("@firstname", firstnameTextBox.Text);
                command.Parameters.AddWithValue("@middlename", middlenameTextBox.Text);
                command.Parameters.AddWithValue("@userroleid", ((dynamic)roleComboBox.SelectedItem).Id);

                connection.Open();
                command.ExecuteNonQuery();
            }

            MessageBox.Show("Пользователь успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
