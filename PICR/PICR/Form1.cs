﻿using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PICR
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            configuracionInicial();
        }

        private void configuracionInicial()
        {
            iconButton1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            iconButton2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            iconButton2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            iconButton3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            iconButton3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            iconButton4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            iconButton4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            iconButton5.FlatAppearance.MouseOverBackColor = Color.Transparent;
            iconButton5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            label9.Font = new Font(label9.Font, FontStyle.Underline);
            label9.Cursor = Cursors.Hand;
        }

        private void botonAcceder_MouseEnter(object sender, EventArgs e)
        {
            botonAcceder.BackColor = ColorTranslator.FromHtml("#DD4E80");
        }

        private void botonAcceder_MouseLeave(object sender, EventArgs e)
        {
           botonAcceder.BackColor = ColorTranslator.FromHtml("#0C5A89");
        }

        private void botonSalir_MouseEnter(object sender, EventArgs e)
        {
            botonSalir.BackColor = ColorTranslator.FromHtml("#DD4E80");
        }

        private void botonSalir_MouseLeave_1(object sender, EventArgs e)
        {
            botonSalir.BackColor = ColorTranslator.FromHtml("#0C5A89");
        }

        private void botonAcceder_Click(object sender, EventArgs e)
        {
            panelPrincipal.Visible = true;
            panelBienvenida.Dispose();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = true;
            panelProfesores.Visible = false;
            panelPlanos.Visible = false;
        }

        private void botonProfesorado_Click(object sender, EventArgs e)
        {
            panelProfesores.Visible = true;
            panelInfo.Visible = false;
            panelPlanos.Visible = false;
        }

        private void botonPlantaB_Click(object sender, EventArgs e)
        {
            imagenesPlanos.Image = Properties.Resources.primeraP;
            label26.Visible = true;
            label27.Visible = true;
            label28.Visible = true;
            label29.Visible = true;
            label30.Visible = true;
            label31.Visible = true;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            label35.Visible = false;
            label36.Visible = false;
            label37.Visible = false;
            label38.Visible = true;
            label39.Visible = false;
            label40.Visible = false;
            label41.Visible = false;
            label42.Visible = false;
            label43.Visible = false;
            iconButton5.Visible = true;
        }

        private void botonPlantaP_Click(object sender, EventArgs e)
        {
            imagenesPlanos.Image = Properties.Resources.SegundaP;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label32.Visible = true;
            label33.Visible = true;
            label34.Visible = true;
            label35.Visible = true;
            label36.Visible = true;
            label37.Visible = true;
            label38.Visible = true;
            label39.Visible = true;
            label40.Visible = false;
            label41.Visible = false;
            label42.Visible = false;
            label43.Visible = false;
            iconButton5.Visible = false;
        }

        private void botonPlantaS_Click(object sender, EventArgs e)
        {
            imagenesPlanos.Image = Properties.Resources.terceraP;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            label35.Visible = false;
            label36.Visible = false;
            label37.Visible = false;
            label38.Visible = true;
            label39.Visible = false;
            label40.Visible = true;
            label41.Visible = true;
            label42.Visible = true;
            label43.Visible = true;
            iconButton5.Visible = false;
        }

        private void buttonPlanos_Click(object sender, EventArgs e)
        {
            panelPlanos.Visible = true;
            panelProfesores.Visible = false;
            panelInfo.Visible = false;
            imagenesPlanos.Image = Properties.Resources.primeraP;
            label26.Visible = true;
            label27.Visible = true;
            label28.Visible = true;
            label29.Visible = true;
            label30.Visible = true;
            label31.Visible = true;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            label35.Visible = false;
            label36.Visible = false;
            label37.Visible = false;
            label38.Visible = true;
            label39.Visible = false;
            label40.Visible = false;
            label41.Visible = false;
            label42.Visible = false;
            label43.Visible = false;
            iconButton5.Visible = true;
        }
    }
}
