﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using PCI.KittingApp.Components;
using PCI.KittingApp.Entity.Users;
using PCI.KittingApp.Forms;
using PCI.KittingApp.Forms.Users;
using PCI.KittingApp.Repository.Opcenter;
using PCI.KittingApp.UseCase;

namespace PCI.KittingApp
{
    public partial class Main : Form
    {
        private OpcenterCheckData _opcenterCheckData;
        private OpcenterSaveData _opcenterSaveData;
        private Kitting _kitting;
        private TransactionFailed _transactionFailed;
        private PrintingLabelUseCase _printingLabelUseCase;
        private UserUseCase _userUseCase;
        private SummaryUseCase _summaryUseCase;
        public static User currentUserSession { get; private set; }

        #region UI_Field
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        
        private int borderSize = 2;
        private Size formSize; //Keep form size when it is minimized and restored.Since the form is resized because it takes into account the size of the title bar and borders.
        #endregion
        public Main(UserUseCase userUseCase, OpcenterCheckData opcenterCheckData, OpcenterSaveData opcenterSaveData, Kitting kitting, TransactionFailed transactionFailed, PrintingLabelUseCase printingLabelUseCase, SummaryUseCase summaryUseCase)
        {
            InitializeComponent();
            #region UI_Constructor
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Padding = new Padding(borderSize);//Border size
            this.BackColor = Color.FromArgb(45, 45, 65);//Border color

            // Set the label version 
            labelVersion.Text = $"Copyright © 2023 by OpexCG | Version {Assembly.GetEntryAssembly().GetName().Version}";
            labelVersion.LinkBehavior = LinkBehavior.NeverUnderline;

            Logout();
            #endregion

            _opcenterCheckData = opcenterCheckData;
            _opcenterSaveData = opcenterSaveData;
            _kitting = kitting;
            _transactionFailed = transactionFailed;
            _printingLabelUseCase = printingLabelUseCase;
            _userUseCase = userUseCase;
            _summaryUseCase = summaryUseCase;
        }

        #region UI_Resposibility
        //Overrride methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        // Structs to use Custom Colors
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }


        //Methods
        public void SetNetworkConnected()
        {
            #if DEBUG
                Console.WriteLine($"Connected!");
            #endif
            iconStatusConnection.IconColor = Color.GreenYellow;
            iconStatusConnection.ForeColor = Color.GreenYellow;
            iconStatusConnection.Text = "Connected";
        }
        public void SetNetworkNotConnected()
        {
            #if DEBUG
                Console.WriteLine($"Disconnected!");
            #endif
            iconStatusConnection.IconColor = Color.Red;
            iconStatusConnection.ForeColor = Color.Red;
            iconStatusConnection.Text = "Disconnected";
        }
        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37,36,81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // Left border Button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {

                currentBtn.BackColor = Color.FromArgb(51, 51, 76);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            lblCurrentChildForm.Text = currentBtn.Text;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.Coral);
            OpenChildForm(new FormOrder(_opcenterCheckData, _opcenterSaveData));
        }

        private void btnUnitRegistration_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.Coral);
            OpenChildForm(new FormUnitRegistration(_opcenterCheckData, _kitting, _opcenterSaveData));
        }

        private void btnMaterialRegistration_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.Coral);
            OpenChildForm(new FormMaterialRegistration(_kitting, _opcenterCheckData, _opcenterSaveData));
        }

        private void btnReprintingLabel_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.Coral);
            OpenChildForm(new FormReprintingLabel(_printingLabelUseCase, _opcenterCheckData, _kitting));
        }

        private void btnTransactionFailed_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.Coral);
            OpenChildForm(new FormTransactionFailed(_transactionFailed));
        }

        private void btnUsersManagement_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.Coral);
            OpenChildForm(new FormUsersManagement(_userUseCase));
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.Coral);
            OpenChildForm(new FormSummary(_opcenterCheckData, _summaryUseCase));
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            GoHome();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;// Icon Current Child Form
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Coral;
            lblCurrentChildForm.Text = "Home";
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTItleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
        }
        #endregion

        private void iconStatusConnection_Click(object sender, EventArgs e)
        {
            bool status = Bootstrapper.CheckConnection();
            if (!status)
            {
                ZIAlertBox.Error("Network Information", "Server Disconnected!");
                SetNetworkNotConnected();
            }
            else
            {
                ZIAlertBox.Success("Network Information", "Server Connected!");
                SetNetworkConnected();
            }
        }

        private void labelVersion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            labelVersion.LinkVisited = true;
            System.Diagnostics.Process.Start("https://opexcg.com/");
        }
        private bool ValidationOfLogin()
        {

            if (textBoxEmployeeId.Text == "" || textBoxPassword.Text == "")
            {
                ZIAlertBox.Error("Authentication Message", "Employee ID or Password is required!");
                return false;
            }

            currentUserSession = _userUseCase.Login(textBoxEmployeeId.Text, textBoxPassword.Text);
            
            if (currentUserSession == null)
            {
                ZIAlertBox.Error("Authentication Message", "Employee ID or Password is not correct!");
                return false;
            }

            labelUserDisplay.Text = $"Hi, {currentUserSession.FullName}!";
            return true;
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var statusLogin = ValidationOfLogin();
            if ( statusLogin) LoginSuccess();
        }

        private void LoginSuccess()
        {
            btnSummary.Visible = true;
            btnReprintingLabel.Visible = true;
            btnTransactionFailed.Visible = true;
            btnMaterialRegistration.Visible = true;
            btnUnitRegistration.Visible = true;
            btnOrder.Visible = true;

            if (currentUserSession.Role == Role.Admin) btnUsersManagement.Visible = true;

            textBoxEmployeeId.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            buttonLogoutSidebar.Visible = true;
            labelUserDisplay.Visible = true;

            panelSuccessLogin.Visible = true;
            panelLogin.Visible = false;

            ZIAlertBox.Success("Authentication Message", "Login Successfully!");
        }

        private void Logout()
        {
            currentUserSession = null;

            btnOrder.Visible = false;
            btnUnitRegistration.Visible = false;
            btnMaterialRegistration.Visible = false;
            btnTransactionFailed.Visible = false;
            btnReprintingLabel.Visible = false;
            btnUsersManagement.Visible = false;
            btnSummary.Visible = false;


            buttonLogoutSidebar.Visible = false;
            labelUserDisplay.Visible = false;
            
            panelSuccessLogin.Visible = false;
            panelLogin.Visible = true;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            var confirmation = ZIMessageBox.Show("Are you sure want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                Logout();
                ZIAlertBox.Success("Authentication Message", "Logout Successfully!");
            }
        }   

        private void buttonLogoutSidebar_Click(object sender, EventArgs e)
        {
            var confirmation = ZIMessageBox.Show("Are you sure want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                GoHome();
                Logout();
                ZIAlertBox.Success("Authentication Message", "Logout Successfully!");
            }
        }

        private void GoHome()
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
    }
}
