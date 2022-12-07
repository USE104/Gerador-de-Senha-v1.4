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

namespace Geradorador_de_Senha
{
    public partial class frmSplash : Form
    {

        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        private void frmSplash_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }


        public frmSplash()
        {
            
            InitializeComponent();
            MessageBox.Show("Seja Bem-vindo", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            MessageBox.Show("Obrigado por utilizar-lo, esse Projeto pertence a José Hugo", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            tmrSlapsh.Enabled = true;
        }



        private void tmrSlapsh_Tick(object sender, EventArgs e)
        {
            if (prgCarregando.Value < 100)
            {

                prgCarregando.Value = prgCarregando.Value + 2;
            }
            else
            {
                tmrSlapsh.Enabled = false;
                this.Visible = false;

                frmgeradorSenha abrir = new frmgeradorSenha();
                abrir.Show();
                this.Hide();
            }
        }
    }
}
