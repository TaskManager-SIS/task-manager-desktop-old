using System;
using System.Drawing;
using System.Runtime.InteropServices;
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
            Logo.Left = (this.ClientSize.Width - Logo.Width) / 2;
            //tituloPanel.TextAlign = (ContentAlignment)HorizontalAlignment.Center; *Subs. Dock
            btnCriarConta.Left = (this.Bloco.Width - btnCriarConta.Width) / 2;
            btnCriarConta.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnCriarConta.Width, btnCriarConta.Height, 7, 7));

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

        /*public void RemoveText(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            ctrl.Text = "";
        }

         public void AddText(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            if (String.IsNullOrWhiteSpace(ctrl.Text))
                ctrl.Text = "Enter text here...";
        }*/ //Teste Placeholder

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            string mensagem = "Sua conta foi criada com sucesso!";
            string titulo = "Dados Salvos";
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

        private void lblLoginExistente_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }
    }
}
