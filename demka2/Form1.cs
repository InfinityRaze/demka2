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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = DESKTOP-RJGLL1R\\SQLEXPRESS; Initial catalog=demka2; Integrated Security=true";
            string query = "SELECT u.userid, ur.namerole FROM [user] u " +
                           "JOIN [userrole] ur ON u.userroleid = ur.userroleid " +
                           "WHERE u.login = @login AND u.password = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@login", loginTextBox.Text);
                command.Parameters.AddWithValue("@password", passwordTextBox.Text);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int userId = reader.GetInt32(0);
                    string userRole = reader.GetString(1);
                    OpenRoleForm(userRole, userId);
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OpenRoleForm(string role, int userId)
        {
            Form formToOpen;
            switch (role)
            {
                case "Заведующий подразделением":
                    formToOpen = new HeadOfDepartmentForm(userId);
                    break;
                case "Организатор":
                    formToOpen = new OrganizerForm();
                    break;
                case "Техник":
                    formToOpen = new TechnicianForm();
                    break;
                default:
                    throw new Exception("Неизвестная роль пользователя");
            }

            formToOpen.Show();
            this.Hide();
        }
    }
}
