namespace Geradorador_de_Senha
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.pctLogoLogin = new System.Windows.Forms.PictureBox();
            this.chkPasswordCharLogin = new System.Windows.Forms.CheckBox();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.txtLoginLogin = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.bntLimpar);
            this.groupBox1.Controls.Add(this.pctLogoLogin);
            this.groupBox1.Controls.Add(this.chkPasswordCharLogin);
            this.groupBox1.Controls.Add(this.txtSenhaLogin);
            this.groupBox1.Controls.Add(this.txtLoginLogin);
            this.groupBox1.Controls.Add(this.lblSenha);
            this.groupBox1.Controls.Add(this.lblLogin);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // bntLimpar
            // 
            this.bntLimpar.BackColor = System.Drawing.Color.LightGray;
            this.bntLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntLimpar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bntLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.bntLimpar.Location = new System.Drawing.Point(217, 267);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(62, 23);
            this.bntLimpar.TabIndex = 2;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = false;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // pctLogoLogin
            // 
            this.pctLogoLogin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pctLogoLogin.Image = ((System.Drawing.Image)(resources.GetObject("pctLogoLogin.Image")));
            this.pctLogoLogin.Location = new System.Drawing.Point(90, 23);
            this.pctLogoLogin.Name = "pctLogoLogin";
            this.pctLogoLogin.Size = new System.Drawing.Size(122, 133);
            this.pctLogoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogoLogin.TabIndex = 6;
            this.pctLogoLogin.TabStop = false;
            // 
            // chkPasswordCharLogin
            // 
            this.chkPasswordCharLogin.AutoSize = true;
            this.chkPasswordCharLogin.BackColor = System.Drawing.Color.Transparent;
            this.chkPasswordCharLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPasswordCharLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.chkPasswordCharLogin.Location = new System.Drawing.Point(73, 268);
            this.chkPasswordCharLogin.Name = "chkPasswordCharLogin";
            this.chkPasswordCharLogin.Size = new System.Drawing.Size(125, 23);
            this.chkPasswordCharLogin.TabIndex = 3;
            this.chkPasswordCharLogin.Text = "Exibir Senha";
            this.chkPasswordCharLogin.UseVisualStyleBackColor = false;
            this.chkPasswordCharLogin.CheckedChanged += new System.EventHandler(this.chkPasswordCharLogin_CheckedChanged);
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSenhaLogin.Location = new System.Drawing.Point(70, 219);
            this.txtSenhaLogin.MaxLength = 24;
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.PasswordChar = '*';
            this.txtSenhaLogin.Size = new System.Drawing.Size(218, 26);
            this.txtSenhaLogin.TabIndex = 1;
            this.txtSenhaLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenhaLogin_KeyDown);
            // 
            // txtLoginLogin
            // 
            this.txtLoginLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLoginLogin.Location = new System.Drawing.Point(70, 187);
            this.txtLoginLogin.MaxLength = 20;
            this.txtLoginLogin.Name = "txtLoginLogin";
            this.txtLoginLogin.Size = new System.Drawing.Size(218, 26);
            this.txtLoginLogin.TabIndex = 0;
            this.txtLoginLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoginLogin_KeyDown);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblSenha.Location = new System.Drawing.Point(3, 223);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(69, 22);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblLogin.Location = new System.Drawing.Point(3, 191);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(63, 22);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location = new System.Drawing.Point(82, 306);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(133, 24);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Fazer Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.Location = new System.Drawing.Point(113, 336);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(56, 21);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(303, 364);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - Gerenciador de Senha";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pctLogoLogin;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private System.Windows.Forms.TextBox txtLoginLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.CheckBox chkPasswordCharLogin;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnVoltar;
    }
}