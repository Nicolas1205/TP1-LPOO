using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseBase;

namespace Views.views
{
    public partial class CompetenciaForm : Form
    {
        public CompetenciaForm()
        {
            InitializeComponent();
        }

        private void CompetenciaForm_Load(object sender, EventArgs e)
        {

        }

        private void registrar_button_Click(object sender, EventArgs e)
        {
            Globals.currentSerialId++;
            var new_competencia = new Competencia
            {
                Com_ID = Globals.currentSerialId,
                Com_Nombre = nombre_textbox.Text,
                Com_Descripcion = descripcion_textbox.Text,
                Com_FechaInicio = fecha_inicio_usercontrol.date_input,
                Com_FechaFin = fecha_final_usercontrol.date_input,
                Com_Estado = estado_combobox.SelectedItem.ToString()
            };
            Globals.competencias.Add(new_competencia);
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            var main = new Main();
            main.Show();
            this.Hide();
        }

    }
}
