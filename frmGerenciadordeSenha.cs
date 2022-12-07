using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Geradorador_de_Senha
{
    public partial class frmGerenciadordeSenha : Form
    {

        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmGerenciadordeSenha()
        {
            InitializeComponent();
        }

        public frmGerenciadordeSenha(string valor)
        {
            InitializeComponent();
        }

        public string Propriedade { get; set; }
    

    //VisiblePassword

    private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1.Checked)
            {
                txtSenha1.PasswordChar = (char)0;
            }
            else
            {
                txtSenha1.PasswordChar = '*';
            }
        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2.Checked)
            {
                txtSenha2.PasswordChar = (char)0;
            }
            else
            {
                txtSenha2.PasswordChar = '*';
            }
        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1.Checked)
            {
                txtSenha3.PasswordChar = (char)0;
            }
            else
            {
                txtSenha3.PasswordChar = '*';
            }
        }

        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1.Checked)
            {
                txtSenha4.PasswordChar = (char)0;
            }
            else
            {
                txtSenha4.PasswordChar = '*';
            }
        }

        private void chk5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1.Checked)
            {
                txtSenha5.PasswordChar = (char)0;
            }
            else
            {
                txtSenha5.PasswordChar = '*';
            }
        }

        private void chk6_CheckedChanged(object sender, EventArgs e)
        {
            if (chk6.Checked)
            {
                txtSenha6.PasswordChar = (char)0;
            }
            else
            {
                txtSenha6.PasswordChar = '*';
            }
        }

        private void chk7_CheckedChanged(object sender, EventArgs e)
        {
            if (chk7.Checked)
            {
                txtSenha7.PasswordChar = (char)0;
            }
            else
            {
                txtSenha7.PasswordChar = '*';
            }
        }

        private void chk8_CheckedChanged(object sender, EventArgs e)
        {
            if (chk8.Checked)
            {
                txtSenha8.PasswordChar = (char)0;
            }
            else
            {
                txtSenha8.PasswordChar = '*';
            }
        }

        private void chk9_CheckedChanged(object sender, EventArgs e)
        {
            if (chk9.Checked)
            {
                txtSenha9.PasswordChar = (char)0;
            }
            else
            {
                txtSenha9.PasswordChar = '*';
            }
        }


        //copyTxt

        private void btn1_Click(object sender, EventArgs e)
        {
            txtSenha1.Copy();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtSenha2.Copy();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtSenha3.Copy();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtSenha4.Copy();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtSenha5.Copy();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtSenha6.Copy();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtSenha7.Copy();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtSenha8.Copy();
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            txtSenha9.Copy();
        }

        // Keydows


        private void txtLogin1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha1.Focus();
            }
        }

        private void txtLogin2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha2.Focus();
            }
        }

        private void txtLogin3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha3.Focus();
            }
        }

        private void txtLogin4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha4.Focus();
            }
        }

        private void txtSenha5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha5.Focus();
            }
        }

        private void txtLogin6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha6.Focus();
            }
        }

        private void txtLogin7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha6.Focus();
            }
        }

        private void txtLogin8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha8.Focus();
            }
        }

        private void txtLogin9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha9.Focus();
            }
        }

        //Buttons


        private void btnVoltarLogin_Click(object sender, EventArgs e)
        {
            frmLogin VoltarLogin = new frmLogin();
            VoltarLogin.Show();
            this.Hide();
        }

        private void btnVoltarGerenciador_Click(object sender, EventArgs e)
        {
            frmgeradorSenha  voltarGeradorSenha = new frmgeradorSenha();
            voltarGeradorSenha.Show();
            this.Hide();
        }

        // remoção do X da janela

        private void frmGerenciadordeSenha_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void txtSenhasGeradasLoguin_TextChanged(object sender, EventArgs e)
        {
           
        }


    }
}
