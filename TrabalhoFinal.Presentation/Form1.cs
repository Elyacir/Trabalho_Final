using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoFinal.Application;
using TrabalhoFinal.Domain.Entity;
using TrabalhoFinal.Infra.Data;

namespace TrabalhoFinal.Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Aluno aluno = new Aluno();
           aluno.Nome = textAluno.Text;
           aluno.Cpf = textCPF.Text;
           aluno.Matricula = textMatricula.Text;
           aluno.QtdeCredito = Convert.ToInt32(textCreditos.Text);
           AlunoService service = new AlunoService(new AlunoRepository());
           service.Create(aluno);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
