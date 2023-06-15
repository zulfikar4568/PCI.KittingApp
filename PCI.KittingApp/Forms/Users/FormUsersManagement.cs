using PCI.KittingApp.Components;
using PCI.KittingApp.Entity.Users;
using PCI.KittingApp.UseCase;
using PCI.KittingApp.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCI.KittingApp.Forms.Users
{
    public partial class FormUsersManagement : Form
    {
        private UserUseCase _userUseCase;
        private List<User> _users = new List<User>();
        public FormUsersManagement(UserUseCase userUseCase)
        {
            InitializeComponent();
            _userUseCase = userUseCase;

            GetListOfUsers();
        }
        private void GetListOfUsers()
        {
            dataGridUsers.Rows.Clear();

            _users = _userUseCase.GetUsers();

            if (_users == null) return;

            if (_users.Count > 0)
            {
                foreach (var item in _users)
                {
                    dataGridUsers.Rows.Add(item.Id, item.EmployeeId, item.FullName, item.Email, item.Role);
                }
            }
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            ModalUtil.Open(this, new FormUser(UserMode.CREATE, new User(), _userUseCase));
            GetListOfUsers();
        }

        private void dataGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridUsers.Columns[e.ColumnIndex].Name == "Edit")
            {
                var stringId = (string)dataGridUsers.Rows[e.RowIndex].Cells["Id"].FormattedValue;
                if (stringId == "" || stringId == null) return;

                var dataUser= _users.Find(x => x.Id == stringId);
                dataUser.Password = "";
                ModalUtil.Open(this, new FormUser(UserMode.UPDATE, dataUser, _userUseCase));
            } else if (dataGridUsers.Columns[e.ColumnIndex].Name == "Delete")
            {
                var stringId = (string)dataGridUsers.Rows[e.RowIndex].Cells["Id"].FormattedValue;
                if (stringId == "" || stringId == null) return;

                var dataUser = _users.Find(x => x.Id == stringId);
                if (dataUser == null) return;


                var confirm = ZIMessageBox.Show($"Are you sure want to delete {dataUser.FullName} user?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    _userUseCase.DeleteUser(dataUser);
                }
            }

            GetListOfUsers();
        }
    }
}
