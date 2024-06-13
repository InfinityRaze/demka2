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
    public partial class ShiftsForm : Form
    {
        public ShiftsForm()
        {
            InitializeComponent();
            LoadShiftsAndUsers();

        }

        private void loadShiftsButton_Click(object sender, EventArgs e)
        {
            AddShiftForm shiftsForm = new AddShiftForm();
            shiftsForm.Show();
        }

        private void LoadShiftsAndUsers()
        {
            string connectionString = "Data Source = DESKTOP-RJGLL1R\\SQLEXPRESS; Initial catalog=demka2; Integrated Security=true";
            string query = @"SELECT s.shiftid, s.datestart, s.dateend, u.userid, u.firstname, u.lastname
                             FROM [demka2].[dbo].[shift] s
                             LEFT JOIN [demka2].[dbo].[userlist] ul ON s.shiftid = ul.shiftid
                             LEFT JOIN [demka2].[dbo].[user] u ON ul.userid = u.userid";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    shiftsGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке смен: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
