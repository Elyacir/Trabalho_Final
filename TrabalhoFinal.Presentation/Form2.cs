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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.Nome = textCurso.Text;
            curso.Turno = textTurno.Text;
            curso.QtdeMinimaCreditos = Convert.ToInt32(textMinimoCreditos.Text);
            CursoService service = new CursoService(new CursoRepository());
            service.Create(curso);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
