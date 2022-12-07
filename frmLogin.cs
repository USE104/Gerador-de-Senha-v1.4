using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geradorador_de_Senha
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
           
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            if  (MessageBox.Show("Quer realmente retorna ao Gerador de Senha ?, Ao fazer isso todos os regitros dos campos serão apagados", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                limparCampos();

                frmgeradorSenha GeradorSenha = new frmgeradorSenha();
                GeradorSenha.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("O Retorno para o Gerador de Senha foi cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

        }

        private void limparCampos()
        {
            txtLoginLogin.Clear();
            txtSenhaLogin.Clear();
            chkPasswordCharLogin.Checked = false;
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Todos os registros dos campos serão apagados", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                limparCampos();

            }
            else
            {
                MessageBox.Show("A Limpeza dos registros foi cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void chkPasswordCharLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPasswordCharLogin.Checked)
            {
                txtSenhaLogin.PasswordChar = (char)0;
            }
            else
            {
                txtSenhaLogin.PasswordChar = '*';
            }
        }

        private bool logado = false;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario, senha;

            usuario = txtLoginLogin.Text;
            senha = txtSenhaLogin.Text;

            if (usuario.Equals("TI104") && senha.Equals("TI104"))
            {
               frmGerenciadordeSenha GerenciadordeSenha = new frmGerenciadordeSenha();
              GerenciadordeSenha.Show();
              this.Hide();
            }
            else
            {
                MessageBox.Show("Dados Incorretos", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }
        }

        private void txtLoginLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenhaLogin.Focus();
            }
        }

        private void txtSenhaLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.Focus();
            }
        }
    }
}
