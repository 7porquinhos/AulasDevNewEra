using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormCadastroDeAlunos
{
    public partial class Form1 : Form
    {
        List<Aluno> listaDeAlunos = new List<Aluno>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            dgvAlunos.Rows.Clear();
            dgvAlunos.Refresh();
            Aluno aluno = new Aluno();
            aluno.Nome = txtNome.Text;
            aluno.Idade = int.Parse(txtIdade.Text);
            listaDeAlunos.Add(aluno);


            foreach (var item in listaDeAlunos)
            {
                dgvAlunos.Rows.Add(item.Nome, item.Idade);

            }
            txtNome.Text = "";
            txtIdade.Text = "";


        }
    }
}
