﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseBase;
using Views.services;

namespace Views.views
{
    public partial class UpdateAtletaForm : Form
    {
        public UpdateAtletaForm()
        {
            InitializeComponent();
        }

        private void UpdateAtletaForm_Load(object sender, EventArgs e)
        {
            List<Atleta> atletas = AtletaService.getAllAtletas();
            foreach (var atleta in atletas)
            {
                atleta_combobox.Items.Add(atleta);
            }
        }
        private void update_atleta_btn_Click(object sender, EventArgs e)
        {
            var selected_atleta = (Atleta)atleta_combobox.SelectedItem;
            selected_atleta.Atl_DNI = dni_textbox.Text;
            selected_atleta.Atl_Nombre = nombre_textbox.Text;
            selected_atleta.Atl_Apellido = apellido_textbox.Text;
            AtletaService.updateAtleta(selected_atleta);
        }

        private void atleta_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected_atleta = (Atleta)atleta_combobox.SelectedItem;
            dni_textbox.Text = selected_atleta.Atl_DNI;
            nombre_textbox.Text = selected_atleta.Atl_Nombre;
            apellido_textbox.Text = selected_atleta.Atl_Apellido;
        }
    }
}
