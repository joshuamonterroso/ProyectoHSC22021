﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitacoraUsuario;
using CapaControladorSeguridadHSC;
using static datosUsuario;

namespace CapaVistaSeguridadHSC
{
    public partial class frmMantenimientoModulo : Form
    {
        private Controlador cn = new Controlador();
        public frmMantenimientoModulo()
        {
            InitializeComponent();
            CenterToScreen();
            actualizardatagriew();
            textBox1.Focus();
        }
        private string tabla = "modulo";

        public void actualizardatagriew()
        {
            DataTable dt = cn.metodollenarTbl(tabla);
            perfilTabla.DataSource = dt;
        }
     
        public void metodoLimpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            btnHabilitado.Checked = false;
            btnInhabilitado.Checked = false;            
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                Bitacora loggear = new Bitacora();
               // loggear.guardarEnBitacora(IdUsuario, "1", "0012", "Insertar");

                if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox4.Text.Trim() != "")
                {
                    
                    loggear.guardarEnBitacora(IdUsuario, "1", "0012", "Inserción realizada");
                    cn.metodoInsertar(textBox1.Text, textBox2.Text, textBox4.Text, int.Parse(textBox3.Text));
                    MessageBox.Show("Insercion realizada");
                    metodoLimpiar();
                }
                else
                {
                    loggear.guardarEnBitacora(IdUsuario, "1", "0012", "Error al realizar Inserción");
                    MessageBox.Show("404 Error debe de ingresar todos los valores solicitados ");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("403 Error debe de ingresar todos los valores solicitados " + ex);
            }
            actualizardatagriew();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox4.Text.Trim() != "")
            {
                Bitacora loggear = new Bitacora();
                loggear.guardarEnBitacora(IdUsuario, "1", "0012", "Modificación Exitosa");
                cn.modificarModificar(textBox1.Text, textBox2.Text, textBox4.Text, int.Parse(textBox3.Text));
                MessageBox.Show("Insercion realizada");
                metodoLimpiar();
            }
            else
            {
                Bitacora loggear = new Bitacora();
                loggear.guardarEnBitacora(IdUsuario, "1", "0012", "Error al modificar");
                MessageBox.Show("Error debe de ingresar todos los valores solicitados ");
            }
            actualizardatagriew();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Bitacora loggear = new Bitacora();
            loggear.guardarEnBitacora(IdUsuario, "1", "0012", "Eliminar");
            cn.metodoEliminar(textBox1.Text);
            MessageBox.Show("Eliminacion realizada");
            metodoLimpiar();
            actualizardatagriew();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            metodoLimpiar();
        }

        private void btnHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            
            textBox3.Text = "1";
        }

        private void btnInhabilitado_CheckedChanged(object sender, EventArgs e)
        {
           
            textBox3.Text = "0";
        }

        private void perfilTabla_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                textBox1.Text = perfilTabla.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = perfilTabla.CurrentRow.Cells[1].Value.ToString();
                textBox4.Text = perfilTabla.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = perfilTabla.CurrentRow.Cells[3].Value.ToString();

                if (textBox3.Text == "1")
                {
                    btnHabilitado.Checked = true;
                }
                else if (textBox3.Text == "0")
                {
                    btnInhabilitado.Checked = true;
                }
            }
            catch
            {
            }

        }
    }
}
