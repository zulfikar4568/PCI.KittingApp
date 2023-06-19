using PCI.KittingApp.Components;
using PCI.KittingApp.Entity.Users;
using PCI.KittingApp.UseCase;
using PCI.KittingApp.Util;
using Quartz.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCI.KittingApp.Forms.Users
{
    public partial class FormUser : Form
    {
        private bool ComboBoxFlag = false;
        private User _userData;
        private UserUseCase _userUseCase;
        private UserMode _userMode;
        public FormUser(UserMode userMode, User userData, UserUseCase userUseCase)
        {
            InitializeComponent();
            _userData = userData;
            _userUseCase = userUseCase;
            _userMode = userMode;
            comboBoxRole.DataSource = Enum.GetValues(typeof(Role));
            
            if (_userMode == UserMode.UPDATE) SetInitialData();
        }

        #region UI Responsibility
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FormUser_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void SetInitialData()
        {
            textBoxEmployeeId.Text = _userData.EmployeeId;
            textBoxFullName.Text = _userData.FullName;
            textBoxEmail.Text = _userData.Email;
            textBoxEmployeeId.Enabled = false;

            comboBoxRole.SelectedIndex = (int)_userData.Role;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSubmitUser_Click(object sender, EventArgs e)
        {
            if (!CheckRequiredData())
            {
                ZIAlertBox.Error("Data Completion", "Please complete the data first!");
                return;
            }
            if (_userMode == UserMode.CREATE)
            {
                bool result = _userUseCase.SignUp(_userData);
                if (result) this.Close();
            } else if(_userMode == UserMode.UPDATE)
            {
                if (_userData.Role != Main.currentUserSession.Role && _userData.Id == Main.currentUserSession.Id)
                {
                    ZIAlertBox.Error("Delete Information", $"You cannot edit your self the role, it must be other administrator");
                    return;
                }
                bool result = _userUseCase.UpdateUser(_userData);
                if (result) this.Close();
            }
        }

        private bool CheckRequiredData()
        {
            return (!textBoxEmployeeId.Text.IsNullOrWhiteSpace() && textBoxEmployeeId.Text != null && textBoxEmployeeId.Text != "") &&
                (!textBoxFullName.Text.IsNullOrWhiteSpace() && textBoxFullName.Text != null && textBoxFullName.Text != "")  &&
                (!textBoxEmail.Text.IsNullOrWhiteSpace() && textBoxEmail.Text != null && textBoxEmail.Text != "") &&
                (!textBoxPassword.Text.IsNullOrWhiteSpace() && textBoxPassword.Text != null && textBoxPassword.Text != "")  &&
                (!textBoxConfirmPassword.Text.IsNullOrWhiteSpace() && textBoxConfirmPassword.Text != null && textBoxConfirmPassword.Text != "") && 
                comboBoxRole.SelectedIndex != -1;
        }

        private void EmployeeIdTriggered()
        {
            _userData.EmployeeId = textBoxEmployeeId.Text;
            textBoxFullName.Select();
        }

        private void FullNameTriggered()
        {
            _userData.FullName = textBoxFullName.Text;
            textBoxEmail.Select();
        }

        private void EmailTriggered()
        {
            _userData.Email = textBoxEmail.Text;
        }

        private void ComboBoxTriggered()
        {
            if (ComboBoxFlag) _userData.Role = (Role)comboBoxRole.SelectedItem;
            else ComboBoxFlag = true;
        }

        private void PasswordTriggered()
        {
            _userData.Password = textBoxPassword.Text;
        }
        private void ConfirmPasswordTriggered()
        {
            if (_userData.Password != textBoxConfirmPassword.Text)
            {
                textBoxConfirmPassword.Text = "";
                ZIAlertBox.Error("Wrong Data", "Password doesn't match!");
                return;
            }
        }

        #region EVENT

        private void textBoxFullName_Leave(object sender, EventArgs e)
        {
            FullNameTriggered();
        }

        private void textBoxFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FullNameTriggered();
            }
        }

        private void textBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EmailTriggered();
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            EmailTriggered();
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxTriggered();
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            PasswordTriggered();
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PasswordTriggered();
            }
        }

        private void textBoxConfirmPassword_Leave(object sender, EventArgs e)
        {
            ConfirmPasswordTriggered();
        }

        private void textBoxConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConfirmPasswordTriggered();
            }
        }

        private void textBoxEmployeeId_Leave(object sender, EventArgs e)
        {
            EmployeeIdTriggered();
        }

        private void textBoxEmployeeId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EmployeeIdTriggered();
            }
        }

        private void buttonSubmitUser_Leave(object sender, EventArgs e)
        {
            textBoxEmployeeId.Select();
        }

        #endregion
    }
}
