/**
Thomas Roberts
May 14, 2024

Description: This program contains the form components
*/
using System.Windows.Forms;

namespace HomeMaintenanceManager
{
    class Form1 : Form
    {
        public void FormLayout()
        {
            this.Name = "Form1";
            this.Text = "Form1";
            this.Size = new System.Drawing.Size(500, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}