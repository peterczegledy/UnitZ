using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unitz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gbTime_Enter(object sender, EventArgs e)
        {

        }

        private void btnTimeCalculate_Click(object sender, EventArgs e)
        {
            double seconds = 0;

            if (!string.IsNullOrEmpty(tbSeconds.Text))
                seconds = double.Parse(tbSeconds.Text);
            else if (!string.IsNullOrEmpty(tbMinutes.Text))
                seconds = double.Parse(tbMinutes.Text) * 60;
            else if (!string.IsNullOrEmpty(tbHours.Text))
                seconds = double.Parse(tbHours.Text) * 3600;
            else if (!string.IsNullOrEmpty(tbDays.Text))
                seconds = double.Parse(tbDays.Text) * 86400;
            else if (!string.IsNullOrEmpty(tbWeeks.Text))
                seconds = double.Parse(tbWeeks.Text) * 604800;
            else if (!string.IsNullOrEmpty(tbMonths.Text))
                seconds = double.Parse(tbMonths.Text) * 2629746; // átlagos hónap
            else if (!string.IsNullOrEmpty(tbYears.Text))
                seconds = double.Parse(tbYears.Text) * 31556952; // átlagos év
            else if (!string.IsNullOrEmpty(tbDecades.Text))
                seconds = double.Parse(tbDecades.Text) * 315569520;
            else if (!string.IsNullOrEmpty(tbCenturies.Text))
                seconds = double.Parse(tbCenturies.Text) * 3155695200;
            else if (!string.IsNullOrEmpty(tbMillennia.Text))
                seconds = double.Parse(tbMillennia.Text) * 31556952000;
            else
                return;

            // Kitöltés
            tbSeconds.Text = Math.Round(seconds, 10).ToString("F10");
            tbMinutes.Text = Math.Round(seconds / 60, 10).ToString("F10");
            tbHours.Text = Math.Round(seconds / 3600, 10).ToString("F10");
            tbDays.Text = Math.Round(seconds / 86400, 10).ToString("F10");
            tbWeeks.Text = Math.Round(seconds / 604800, 10).ToString("F10");
            tbMonths.Text = Math.Round(seconds / 2629746, 10).ToString("F10");
            tbYears.Text = Math.Round(seconds / 31556952, 10).ToString("F10");
            tbDecades.Text = Math.Round(seconds / 315569520, 10).ToString("F10");
            tbCenturies.Text = Math.Round(seconds / 3155695200, 10).ToString("F10");
            tbMillennia.Text = Math.Round(seconds / 31556952000, 10).ToString("F10");

            tbSeconds.ReadOnly = true;
            tbMinutes.ReadOnly = true;
            tbHours.ReadOnly = true;
            tbDays.ReadOnly = true;
            tbWeeks.ReadOnly = true;
            tbMonths.ReadOnly = true;
            tbYears.ReadOnly = true;
            tbDecades.ReadOnly = true;
            tbCenturies.ReadOnly = true;
            tbMillennia.ReadOnly = true;
        }

        private void btnTimeClear_Click(object sender, EventArgs e)
        {
            tbSeconds.Text = "";
            tbMinutes.Text = "";
            tbHours.Text = "";
            tbDays.Text = "";
            tbWeeks.Text = "";
            tbMonths.Text = "";
            tbYears.Text = "";
            tbDecades.Text = "";
            tbCenturies.Text = "";
            tbMillennia.Text = "";

            tbSeconds.ReadOnly = false;
            tbMinutes.ReadOnly = false;
            tbHours.ReadOnly = false;
            tbDays.ReadOnly = false;
            tbWeeks.ReadOnly = false;
            tbMonths.ReadOnly = false;
            tbYears.ReadOnly = false;
            tbDecades.ReadOnly = false;
            tbCenturies.ReadOnly = false;
            tbMillennia.ReadOnly = false;
        }
    }
}
