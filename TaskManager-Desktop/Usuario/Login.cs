using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TaskManager_Desktop
{
    public partial class Login : Form
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

        public Login()
        {
            InitializeComponent();
            Logo.Left = (this.ClientSize.Width - Logo.Width) / 2;
            //tituloPanel.TextAlign = (ContentAlignment)HorizontalAlignment.Center; *Subs. Dock
            btnLoginConta.Left = (this.Bloco.Width - btnLoginConta.Width) / 2;
            btnLoginConta.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLoginConta.Width, btnLoginConta.Height, 7, 7));

        }

        private void Bloco_Paint(object sender, PaintEventArgs e)
        {
            //centralizado
            Bloco.Left = (this.ClientSize.Width - Bloco.Width) / 2; //Horizontal
            //Bloco.Top = (this.ClientSize.Height - Bloco.Height) / 2; //Vertical
            
            //rounded
            Bloco.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Bloco.Width, Bloco.Height, 10, 10));
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        /* Caso Window -> Resize */
        private void Cadastro_SizeChanged(object sender, EventArgs e)
        {
            CenterControlInParent(Bloco);
        }
        private void CenterControlInParent(Control ctrlToCenter)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2;
            //ctrlToCenter.Top = (ctrlToCenter.Parent.Height - ctrlToCenter.Height) / 2; *Vertical
        } 

        private void Cadastro_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLoginConta_Click(object sender, EventArgs e)
        {
            string mensagem = "Nome de usuário e/ou senha incorretos!";
            string titulo = "Erro ao logar!";
            MessageBox.Show(mensagem, titulo);
            ClearControls(this);
        }

        void ClearControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                /*else if (c is RadioButton)
                    ((RadioButton)c).Checked = false;
                else if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = -1;*/ //futuras opções

                if (c.HasChildren)
                    ClearControls(c);
            }
        }

        private void lblLoginInexistente_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            this.Hide();
            cadastro.ShowDialog();
        }

        private void lblSenhaEsquecida_Click(object sender, EventArgs e)
        {

        }
    }
}
