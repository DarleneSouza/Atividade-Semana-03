using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_2_aula_sicronia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string menssagem = "";
            string usuario = TxtUsuario.Text;
            string senha = TxtSenha.Text;
            if (usuario == "admin" && senha == "ifsuldeminas")
            {
                menssagem = "Bem vindo!";
            }
            else
            {
                menssagem = "Acesso negado";
            }
            MessageBox.Show(menssagem);
        }
    }
}
