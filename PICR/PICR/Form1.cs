using FontAwesome.Sharp;
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
        }

        private void botonProfesorado_Click(object sender, EventArgs e)
        {
            panelProfesores.Visible = true;
            panelInfo.Visible = false;
        }
    }
}
