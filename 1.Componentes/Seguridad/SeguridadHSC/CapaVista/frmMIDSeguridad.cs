﻿using System;
using System.Windows.Forms;
using BitacoraUsuario;
using CapaControladorSeguridadHSC;
using static datosUsuario;

namespace CapaVistaSeguridadHSC
{
    public partial class frmMIDSeguridad : Form
    {
        private ObtenerPermisos global = new ObtenerPermisos();

        public frmMIDSeguridad()
        {
            InitializeComponent();
            CenterToScreen();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Bitacora loggear = new Bitacora();
                loggear.guardarEnBitacora(IdUsuario, "1", "0001", "Cerrar sesión");
                txtUsuario.Text = form.usuario();
            }
            else { this.Close(); }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            //nombreform form3 = new nombreform();
            //form3.MdiParent = this.MdiParent;

            //form3.Show();
        }

        private void btnAplicacion_Click(object sender, EventArgs e)
        {
            frmMantenimientoAplicacion form3 = new frmMantenimientoAplicacion();
            form3.MdiParent = this;
            Bitacora loggear = new Bitacora();
            loggear.guardarEnBitacora(IdUsuario, "1", "0003", "Entrada a la Vista");
            form3.Show();
        }

        private void btnModulos_Click(object sender, EventArgs e)
        {
        }

        private void btnPerfiles_Click(object sender, EventArgs e)
        {
            frmMantenimientoPerfil form3 = new frmMantenimientoPerfil();
            form3.MdiParent = this;
            Bitacora loggear = new Bitacora();
            loggear.guardarEnBitacora(IdUsuario, "1", "0007", "Entrada a la Vista");
            form3.Show();
        }

        private void btnAsignacionDeAplicacionAUsuarios_Click(object sender, EventArgs e)
        {
            frmAplicaciones form3 = new frmAplicaciones();
            form3.MdiParent = this;
            Bitacora loggear = new Bitacora();
            loggear.guardarEnBitacora(IdUsuario, "1", "0006", "Entrada a la Vista");
            form3.Show();
        }

        private void btnAsignacionDeAplicacionesAPerfiles_Click(object sender, EventArgs e)
        {
            frmAplicacionesPerfiles form3 = new frmAplicacionesPerfiles();
            form3.MdiParent = this;
            Bitacora loggear = new Bitacora();
            loggear.guardarEnBitacora(IdUsuario, "1", "0005", "Entrada a la Vista");
            form3.Show();
        }

        private void btnCambioContraseña_Click(object sender, EventArgs e)
        {
            frmCambioContraseña form3 = new frmCambioContraseña();
            form3.MdiParent = this;
            Bitacora loggear = new Bitacora();
            loggear.guardarEnBitacora(IdUsuario, "1", "0010", "Entrada a la Vista");
            form3.Show();
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
        }

        private void btnAsiginaciónDePerfilesAUsuarios_Click(object sender, EventArgs e)
        {
            frmPerfiles form3 = new frmPerfiles();
            form3.MdiParent = this;
            Bitacora loggear = new Bitacora();
            loggear.guardarEnBitacora(IdUsuario, "1", "0007", "Asignación de Perfiles a Usuarios");
            form3.Show();
        }

        private void bitácoraDeLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBitacora form3 = new frmBitacora();
            form3.MdiParent = this;
            Bitacora loggear = new Bitacora();
            loggear.guardarEnBitacora(IdUsuario, "1", "0011", "Entrada a la Vista");
            form3.Show();
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarUsuario form3 = new frmRegistrarUsuario();
            form3.MdiParent = this;
            Bitacora loggear = new Bitacora();
            loggear.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
            form3.Show();
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            frmPermisos form3 = new frmPermisos();
            form3.MdiParent = this;
            Bitacora loggear = new Bitacora();
            loggear.guardarEnBitacora(IdUsuario, "1", "0008", "Entrada a la Vista");
            form3.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLoginHSC_Load(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
                global.usuarioglobal = txtUsuario.Text;
            }
            else
            {
                this.Close();
            }
        }

        private void módulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoModulo form3 = new frmMantenimientoModulo();
            form3.MdiParent = this;
            Bitacora loggear = new Bitacora();
            loggear.guardarEnBitacora(IdUsuario, "1", "0012", "Entrada a la Vista");
            form3.Show();
        }
    }
}