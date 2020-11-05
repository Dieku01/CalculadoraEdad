using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularEdad
{
    public partial class frmPrincipal : Form
    {
        int edadYear;
        int edadMonth;
        int edadDay;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblEdad.Text = dateTimePicker1.Value.Day.ToString() + "- " + dateTimePicker1.Value.Month.ToString() + "- " + dateTimePicker1.Value.Year.ToString();
            if (int.Parse(dateTimePicker1.Value.Year.ToString()) > int.Parse(DateTime.Now.Year.ToString()))
            {
                MessageBox.Show("Error en la selección de edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                edadYear = DateTime.Now.Year - dateTimePicker1.Value.Year;
                if (int.Parse(dateTimePicker1.Value.Month.ToString()) > int.Parse(DateTime.Now.Month.ToString()))
                {
                    MessageBox.Show("Error en la selección de edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (int.Parse(dateTimePicker1.Value.Month.ToString()) == int.Parse(DateTime.Now.Month.ToString()))
                {
                    if (int.Parse(dateTimePicker1.Value.Day.ToString()) > int.Parse(DateTime.Now.Day.ToString()))
                    {
                        MessageBox.Show("Error en la selección de edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        edadDay = DateTime.Now.Day - dateTimePicker1.Value.Day;
                    }
                }
                else
                {
                    edadMonth = DateTime.Now.Month - dateTimePicker1.Value.Month;
                    edadDay = DateTime.Now.Day - dateTimePicker1.Value.Day;
                    if (DateTime.Now.Day > dateTimePicker1.Value.Day)
                    {
                        edadDay = DateTime.Now.Day - dateTimePicker1.Value.Day;
                    }
                    else
                    {
                        edadDay = dateTimePicker1.Value.Day -DateTime.Now.Day;
                    }
                }
            }
            lblEdad.Text = $"{edadYear.ToString()} Año/s {edadMonth.ToString()} Mes/es {edadDay.ToString()} Día/s";
        }
    }
}
