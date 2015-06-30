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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2=new Form2();

            f2.ShowDialog();            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            f1.ShowDialog();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void button3_Click(object sender, EventArgs e)
        {       
            CursoService service = new CursoService(new CursoRepository());
            List<Curso> cursos = service.RetrieveAll();
            GridCurso.DataSource = cursos;            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AlunoService service = new AlunoService(new AlunoRepository());
            List<Aluno> alunos = service.RetrieveAll();
            GridAlunos.DataSource = alunos;            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CursoService service = new CursoService(new CursoRepository());
            DataGridViewRow row = this.GridCurso.SelectedRows[0];
            Curso cursos = service.Delete(Convert.ToInt32(row.Cells["Id"].Value));
            GridCurso.DataSource = cursos;

            CursoService service1 = new CursoService(new CursoRepository());
            List<Curso> cursos1 = service.RetrieveAll();
            GridCurso.DataSource = cursos1;            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AlunoService service = new AlunoService(new AlunoRepository());
            DataGridViewRow row = this.GridAlunos.SelectedRows[0];
            Aluno alunos = service.Delete(Convert.ToInt32(row.Cells["Id"].Value));
            GridAlunos.DataSource = alunos;

            AlunoService service1 = new AlunoService(new AlunoRepository());
            List<Aluno> alunos1 = service.RetrieveAll();
            GridAlunos.DataSource = alunos1;            
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
