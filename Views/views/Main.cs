using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.services;

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
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            usuarios_managment_btn = new Button();
            atletas_managment_btn = new Button();
            competiciones_managment_btn = new Button();
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
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = UpdateRowSource.None;
            // 
            // usuarios_managment_btn
            // 
            usuarios_managment_btn.Location = new Point(25, 66);
            usuarios_managment_btn.Name = "usuarios_managment_btn";
            usuarios_managment_btn.Size = new Size(179, 23);
            usuarios_managment_btn.TabIndex = 5;
            usuarios_managment_btn.Text = "Gestion de Usuarios";
            usuarios_managment_btn.UseVisualStyleBackColor = true;
            // 
            // atletas_managment_btn
            // 
            atletas_managment_btn.Location = new Point(25, 109);
            atletas_managment_btn.Name = "atletas_managment_btn";
            atletas_managment_btn.Size = new Size(179, 23);
            atletas_managment_btn.TabIndex = 6;
            atletas_managment_btn.Text = "Gestion Atletas";
            atletas_managment_btn.UseVisualStyleBackColor = true;
            // 
            // competiciones_managment_btn
            // 
            competiciones_managment_btn.Location = new Point(25, 155);
            competiciones_managment_btn.Name = "competiciones_managment_btn";
            competiciones_managment_btn.Size = new Size(179, 23);
            competiciones_managment_btn.TabIndex = 7;
            competiciones_managment_btn.Text = "Gestion Competiciones";
            competiciones_managment_btn.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            ClientSize = new Size(740, 388);
            Controls.Add(competiciones_managment_btn);
            Controls.Add(atletas_managment_btn);
            Controls.Add(usuarios_managment_btn);
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
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private Button usuarios_managment_btn;
        private Button atletas_managment_btn;
        private Button competiciones_managment_btn;

        private void participanteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var atletaForm = new AtletaForm();
            atletaForm.Show();
            this.Hide();
        }

        private void Main_Load_1(object sender, EventArgs e)
        {
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
