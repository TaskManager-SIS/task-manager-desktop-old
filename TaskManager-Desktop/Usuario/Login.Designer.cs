using System.Runtime.InteropServices;
using System;

namespace TaskManager_Desktop
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Bloco = new System.Windows.Forms.Panel();
            this.lblSenhaEsquecida = new System.Windows.Forms.Label();
            this.lblLoginInexistente = new System.Windows.Forms.Label();
            this.btnLoginConta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tituloPanel = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Bloco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Bloco
            // 
            this.Bloco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Bloco.BackColor = System.Drawing.Color.White;
            this.Bloco.Controls.Add(this.lblSenhaEsquecida);
            this.Bloco.Controls.Add(this.lblLoginInexistente);
            this.Bloco.Controls.Add(this.btnLoginConta);
            this.Bloco.Controls.Add(this.label3);
            this.Bloco.Controls.Add(this.textBox4);
            this.Bloco.Controls.Add(this.lblEmail);
            this.Bloco.Controls.Add(this.textBox2);
            this.Bloco.Controls.Add(this.tituloPanel);
            this.Bloco.Location = new System.Drawing.Point(415, 162);
            this.Bloco.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.Bloco.Name = "Bloco";
            this.Bloco.Size = new System.Drawing.Size(413, 379);
            this.Bloco.TabIndex = 0;
            this.Bloco.Paint += new System.Windows.Forms.PaintEventHandler(this.Bloco_Paint);
            // 
            // lblSenhaEsquecida
            // 
            this.lblSenhaEsquecida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSenhaEsquecida.AutoSize = true;
            this.lblSenhaEsquecida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSenhaEsquecida.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSenhaEsquecida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblSenhaEsquecida.Location = new System.Drawing.Point(21, 237);
            this.lblSenhaEsquecida.Name = "lblSenhaEsquecida";
            this.lblSenhaEsquecida.Size = new System.Drawing.Size(217, 18);
            this.lblSenhaEsquecida.TabIndex = 17;
            this.lblSenhaEsquecida.Text = "Esqueceu a senha? Clique aqui";
            this.lblSenhaEsquecida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSenhaEsquecida.Click += new System.EventHandler(this.lblSenhaEsquecida_Click);
            // 
            // lblLoginInexistente
            // 
            this.lblLoginInexistente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLoginInexistente.AutoSize = true;
            this.lblLoginInexistente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLoginInexistente.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginInexistente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblLoginInexistente.Location = new System.Drawing.Point(91, 334);
            this.lblLoginInexistente.Name = "lblLoginInexistente";
            this.lblLoginInexistente.Size = new System.Drawing.Size(230, 19);
            this.lblLoginInexistente.TabIndex = 16;
            this.lblLoginInexistente.Text = "Não tem cadastro? Registrar-se";
            this.lblLoginInexistente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoginInexistente.Click += new System.EventHandler(this.lblLoginInexistente_Click);
            // 
            // btnLoginConta
            // 
            this.btnLoginConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.btnLoginConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginConta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnLoginConta.ForeColor = System.Drawing.Color.White;
            this.btnLoginConta.Location = new System.Drawing.Point(141, 290);
            this.btnLoginConta.Name = "btnLoginConta";
            this.btnLoginConta.Size = new System.Drawing.Size(130, 36);
            this.btnLoginConta.TabIndex = 15;
            this.btnLoginConta.Text = "Entrar";
            this.btnLoginConta.UseVisualStyleBackColor = false;
            this.btnLoginConta.Click += new System.EventHandler(this.btnLoginConta_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label3.Location = new System.Drawing.Point(20, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Senha";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.textBox4.Location = new System.Drawing.Point(24, 202);
            this.textBox4.MaxLength = 100;
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '*';
            this.textBox4.Size = new System.Drawing.Size(361, 32);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "Inserir sua senha";
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.lblEmail.Location = new System.Drawing.Point(20, 94);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(214, 24);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "E-mail";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.textBox2.Location = new System.Drawing.Point(22, 121);
            this.textBox2.MaxLength = 100;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(363, 32);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Inserir seu e-mail";
            // 
            // tituloPanel
            // 
            this.tituloPanel.BackColor = System.Drawing.Color.Transparent;
            this.tituloPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloPanel.Font = new System.Drawing.Font("DM Sans", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tituloPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.tituloPanel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tituloPanel.Location = new System.Drawing.Point(0, 0);
            this.tituloPanel.Name = "tituloPanel";
            this.tituloPanel.Size = new System.Drawing.Size(413, 59);
            this.tituloPanel.TabIndex = 0;
            this.tituloPanel.Text = "Login";
            this.tituloPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(415, 38);
            this.Logo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(413, 76);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1260, 697);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Bloco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.Bloco.ResumeLayout(false);
            this.Bloco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Bloco;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label tituloPanel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnLoginConta;
        private System.Windows.Forms.Label lblLoginInexistente;
        private System.Windows.Forms.Label lblSenhaEsquecida;
    }
}