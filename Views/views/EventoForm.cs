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
    public partial class EventoForm : Form
    {
        public EventoForm()
        {
            InitializeComponent();
        }

        private void EventoForm_Load(object sender, EventArgs e)
        {
            foreach (var competencia in Globals.competencias)
            {
                competencia_combobox.Items.Add(competencia);
            }
            competencia_combobox.ValueMember = "nombre";

            foreach (var atleta in Globals.atletas)
            {
                atleta_combobox.Items.Add(atleta);
            }
            atleta_combobox.ValueMember = "nombre";
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            var main = new Main();
            main.Show();
            this.Hide();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            var selected_atleta = (Atleta)atleta_combobox.SelectedItem;
            var selected_competencia = (Competencia)competencia_combobox.SelectedItem;
            var new_evento = new Evento();
            new_evento.Eve_ID = ++Globals.currentSerialId;
            new_evento.Com_ID = selected_competencia.Com_ID;
            new_evento.Atl_ID = selected_atleta.Atl_ID;
            new_evento.Eve_HoraInicio = fecha_inicio_usercontrol.date_input;
            new_evento.Eve_HoraFin = fecha_inicio_usercontrol.date_input;

            Globals.eventos.Add(new_evento);

        }
    }
}
