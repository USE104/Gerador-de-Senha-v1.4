
﻿namespace Geradorador_de_Senha
{
    partial class frmgeradorSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmgeradorSenha));
            this.grpText = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkPasswordChar = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkHistoricodeSenha = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.btngerarSenha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.cboSenha = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.grpText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpButton.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpText
            // 
            this.grpText.Controls.Add(this.pictureBox1);
            this.grpText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpText.Location = new System.Drawing.Point(40, 44);
            this.grpText.Name = "grpText";
            this.grpText.Size = new System.Drawing.Size(299, 190);
            this.grpText.TabIndex = 0;
            this.grpText.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // grpButton
            // 
            this.grpButton.Controls.Add(this.groupBox1);
            this.grpButton.Controls.Add(this.btnLimpar);
            this.grpButton.Controls.Add(this.btnCopiar);
            this.grpButton.Controls.Add(this.btngerarSenha);
            this.grpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpButton.Location = new System.Drawing.Point(12, 332);
            this.grpButton.Name = "grpButton";
            this.grpButton.Size = new System.Drawing.Size(349, 178);
            this.grpButton.TabIndex = 1;
            this.grpButton.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.chkPasswordChar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkHistoricodeSenha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(22, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 50);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // chkPasswordChar
            // 
            this.chkPasswordChar.AutoSize = true;
            this.chkPasswordChar.BackColor = System.Drawing.SystemColors.Info;
            this.chkPasswordChar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPasswordChar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.chkPasswordChar.Location = new System.Drawing.Point(192, 21);
            this.chkPasswordChar.Name = "chkPasswordChar";
            this.chkPasswordChar.Size = new System.Drawing.Size(91, 23);
            this.chkPasswordChar.TabIndex = 4;
            this.chkPasswordChar.Text = "Habilitar";
            this.chkPasswordChar.UseVisualStyleBackColor = false;
            this.chkPasswordChar.CheckedChanged += new System.EventHandler(this.chkPasswordChar_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(163, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Esconder Senha";
            // 
            // chkHistoricodeSenha
            // 
            this.chkHistoricodeSenha.AutoSize = true;
            this.chkHistoricodeSenha.BackColor = System.Drawing.SystemColors.Info;
            this.chkHistoricodeSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHistoricodeSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.chkHistoricodeSenha.Location = new System.Drawing.Point(12, 21);
            this.chkHistoricodeSenha.Name = "chkHistoricodeSenha";
            this.chkHistoricodeSenha.Size = new System.Drawing.Size(109, 23);
            this.chkHistoricodeSenha.TabIndex = 3;
            this.chkHistoricodeSenha.Text = "Desabilitar";
            this.chkHistoricodeSenha.UseVisualStyleBackColor = false;
            this.chkHistoricodeSenha.CheckedChanged += new System.EventHandler(this.chkHistoricodeSenha_CheckedChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Histórico de Senha";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Info;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.Location = new System.Drawing.Point(22, 70);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(151, 46);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.BackColor = System.Drawing.SystemColors.Info;
            this.btnCopiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiar.Location = new System.Drawing.Point(172, 70);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(155, 46);
            this.btnCopiar.TabIndex = 6;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = false;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // btngerarSenha
            // 
            this.btngerarSenha.BackColor = System.Drawing.SystemColors.Info;
            this.btngerarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngerarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngerarSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngerarSenha.Location = new System.Drawing.Point(22, 110);
            this.btngerarSenha.Name = "btngerarSenha";
            this.btngerarSenha.Size = new System.Drawing.Size(305, 60);
            this.btngerarSenha.TabIndex = 1;
            this.btngerarSenha.Text = "Gerar Senha";
            this.btngerarSenha.UseVisualStyleBackColor = false;
            this.btngerarSenha.Click += new System.EventHandler(this.btngerarSenha_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gerador de Senha";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSenha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(40, 235);
            this.txtSenha.MaxLength = 24;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(299, 31);
            this.txtSenha.TabIndex = 0;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.LightGray;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(12, 524);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(43, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // cboSenha
            // 
            this.cboSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboSenha.FormattingEnabled = true;
            this.cboSenha.Location = new System.Drawing.Point(86, 298);
            this.cboSenha.Name = "cboSenha";
            this.cboSenha.Size = new System.Drawing.Size(203, 28);
            this.cboSenha.TabIndex = 2;
            this.cboSenha.SelectedIndexChanged += new System.EventHandler(this.cboSenha_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(80, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Histórico de Senhas Geradas";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightGray;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location = new System.Drawing.Point(128, 520);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(114, 31);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Fazer Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmgeradorSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(375, 557);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboSenha);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.grpText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmgeradorSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmgeradorSenha_Load);
            this.grpText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpButton.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpText;
        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Button btngerarSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox cboSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkHistoricodeSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkPasswordChar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLogin;
    }
}



    
