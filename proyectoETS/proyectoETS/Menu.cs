﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoETS
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cambiarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios Nuevo = new Usuarios();

            Nuevo.MdiParent = this;

            Nuevo.Show();
        }
    }
}
