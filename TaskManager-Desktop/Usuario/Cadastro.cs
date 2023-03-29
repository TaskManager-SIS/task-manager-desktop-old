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

namespace TaskManager_Desktop
{
    public partial class Cadastro : Form
    {
        //round corners

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public Cadastro()
        {
            InitializeComponent();
        }

        private void Bloco_Paint(object sender, PaintEventArgs e)
        {
            //centralizado
            Bloco.Left = (this.ClientSize.Width - Bloco.Width) / 2;
            //Bloco.Top = (this.ClientSize.Height - Bloco.Height) / 2;
            
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Bloco.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Bloco.Width, Bloco.Height, 20, 20));
        }

        /* Caso Formborder -> Resize */
        private void Cadastro_SizeChanged(object sender, EventArgs e)
        {
            CenterControlInParent(Bloco);
        }
        private void CenterControlInParent(Control ctrlToCenter)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2;
            //ctrlToCenter.Top = (ctrlToCenter.Parent.Height - ctrlToCenter.Height) / 2;
        } 

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

    }
}
