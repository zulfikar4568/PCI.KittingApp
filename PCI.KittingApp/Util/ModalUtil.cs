using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCI.KittingApp.Util
{
    public static class ModalUtil
    {
        public static int parentX, parentY;
        public static void Open(Form parent, Form modal)
        {
            Form modalBackground = new Form();
            using (modal)
            {
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.White;
                modalBackground.ShowInTaskbar = false;
                modalBackground.WindowState = FormWindowState.Maximized;
                modalBackground.Location = Screen.FromPoint(Cursor.Position).Bounds.Location;
                modalBackground.Show();
                modal.Owner = modalBackground;

                parentX = parent.Location.X;
                parentY = parent.Location.Y;

                modal.ShowDialog();
                modal.Location = Screen.FromPoint(Cursor.Position).Bounds.Location;
                modalBackground.Dispose();
            }
        }
    }
}
