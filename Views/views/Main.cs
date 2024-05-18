using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.views
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            darDeAltaToolStripMenuItem = new ToolStripMenuItem();
            participanteToolStripMenuItem = new ToolStripMenuItem();
            eventoToolStripMenuItem = new ToolStripMenuItem();
            competenciaToolStripMenuItem = new ToolStripMenuItem();
            disciplinaToolStripMenuItem = new ToolStripMenuItem();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            atletas_list_label = new Label();
            competencias_list_l = new Label();
            competencias_list_label = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { darDeAltaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(740, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // darDeAltaToolStripMenuItem
            // 
            darDeAltaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { participanteToolStripMenuItem, eventoToolStripMenuItem, competenciaToolStripMenuItem, disciplinaToolStripMenuItem, sistemaToolStripMenuItem });
            darDeAltaToolStripMenuItem.Name = "darDeAltaToolStripMenuItem";
            darDeAltaToolStripMenuItem.Size = new Size(77, 20);
            darDeAltaToolStripMenuItem.Text = "Dar de Alta";
            // 
            // participanteToolStripMenuItem
            // 
            participanteToolStripMenuItem.Name = "participanteToolStripMenuItem";
            participanteToolStripMenuItem.Size = new Size(145, 22);
            participanteToolStripMenuItem.Text = "Participante";
            participanteToolStripMenuItem.Click += participanteToolStripMenuItem_Click_1;
            // 
            // eventoToolStripMenuItem
            // 
            eventoToolStripMenuItem.Name = "eventoToolStripMenuItem";
            eventoToolStripMenuItem.Size = new Size(145, 22);
            eventoToolStripMenuItem.Text = "Evento";
            eventoToolStripMenuItem.Click += eventoToolStripMenuItem_Click;
            // 
            // competenciaToolStripMenuItem
            // 
            competenciaToolStripMenuItem.Name = "competenciaToolStripMenuItem";
            competenciaToolStripMenuItem.Size = new Size(145, 22);
            competenciaToolStripMenuItem.Text = "Competencia";
            competenciaToolStripMenuItem.Click += competenciaToolStripMenuItem_Click;
            // 
            // disciplinaToolStripMenuItem
            // 
            disciplinaToolStripMenuItem.Name = "disciplinaToolStripMenuItem";
            disciplinaToolStripMenuItem.Size = new Size(145, 22);
            disciplinaToolStripMenuItem.Text = "Disciplina";
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(145, 22);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 43);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 1;
            label1.Text = "Participantes Registrados: ";
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = UpdateRowSource.None;
            // 
            // atletas_list_label
            // 
            atletas_list_label.AutoSize = true;
            atletas_list_label.Location = new Point(188, 44);
            atletas_list_label.Name = "atletas_list_label";
            atletas_list_label.Size = new Size(0, 15);
            atletas_list_label.TabIndex = 2;
            // 
            // competencias_list_l
            // 
            competencias_list_l.AutoSize = true;
            competencias_list_l.Location = new Point(27, 89);
            competencias_list_l.Name = "competencias_list_l";
            competencias_list_l.Size = new Size(149, 15);
            competencias_list_l.TabIndex = 3;
            competencias_list_l.Text = "Competencias Registradas:";
            // 
            // competencias_list_label
            // 
            competencias_list_label.AutoSize = true;
            competencias_list_label.Location = new Point(188, 89);
            competencias_list_label.Name = "competencias_list_label";
            competencias_list_label.Size = new Size(0, 15);
            competencias_list_label.TabIndex = 4;
            // 
            // Main
            // 
            ClientSize = new Size(740, 388);
            Controls.Add(competencias_list_label);
            Controls.Add(competencias_list_l);
            Controls.Add(atletas_list_label);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Load += Main_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem darDeAltaToolStripMenuItem;
        private ToolStripMenuItem participanteToolStripMenuItem;
        private ToolStripMenuItem eventoToolStripMenuItem;
        private ToolStripMenuItem competenciaToolStripMenuItem;
        private ToolStripMenuItem disciplinaToolStripMenuItem;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Label atletas_list_label;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private Label competencias_list_l;
        private Label competencias_list_label;
        private Label label1;

        private void participanteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var atletaForm = new AtletaForm();
            atletaForm.Show();
            this.Hide();
        }

        private void Main_Load_1(object sender, EventArgs e)
        {
            if (Globals.atletas.Count() == 0)
            {
                atletas_list_label.Text = "No hay atletas registrados";
            }
            else
            {
                foreach (var atleta in Globals.atletas)
                {
                    atletas_list_label.Text += atleta.Atl_Nombre + ", ";
                }
            }

            if (Globals.competencias.Count() == 0)
            {
                competencias_list_label.Text = "No hay competencias registrados";
            }
            else
            {
                foreach (var competencia in Globals.competencias)
                {
                    competencias_list_label.Text += competencia.Com_Nombre + ", ";
                }
            }

        }

        private void competenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var competenciaForm = new CompetenciaForm();
            competenciaForm.Show();
            this.Hide();
        }

        private void eventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var eventoForm = new EventoForm();
            eventoForm.Show();
            this.Hide();
        }

    }
}
