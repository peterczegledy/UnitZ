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

        private void btnDistanceCalculate_Click(object sender, EventArgs e)
        {
            double meters = 0;

            // Megnézzük, melyik TextBoxban van érték
            if (!string.IsNullOrEmpty(tbNm.Text))
                meters = double.Parse(tbNm.Text) * 1e-9;
            else if (!string.IsNullOrEmpty(tbMm.Text))
                meters = double.Parse(tbMm.Text) * 1e-3;
            else if (!string.IsNullOrEmpty(tbCm.Text))
                meters = double.Parse(tbCm.Text) * 1e-2;
            else if (!string.IsNullOrEmpty(tbDm.Text))
                meters = double.Parse(tbDm.Text) * 1e-1;
            else if (!string.IsNullOrEmpty(tbM.Text))
                meters = double.Parse(tbM.Text);
            else if (!string.IsNullOrEmpty(tbKm.Text))
                meters = double.Parse(tbKm.Text) * 1e3;
            else if (!string.IsNullOrEmpty(tbInch.Text))
                meters = double.Parse(tbInch.Text) * 0.0254;
            else if (!string.IsNullOrEmpty(tbFoot.Text))
                meters = double.Parse(tbFoot.Text) * 0.3048;
            else if (!string.IsNullOrEmpty(tbYard.Text))
                meters = double.Parse(tbYard.Text) * 0.9144;
            else if (!string.IsNullOrEmpty(tbMile.Text))
                meters = double.Parse(tbMile.Text) * 1609.344;
            else
                return; // nincs input

            // Kitöltjük a többi TextBoxot
            tbNm.Text = Math.Round(meters * 1e9, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(meters * 1e9, 10).ToString("F10").Length));
            tbMm.Text = Math.Round(meters * 1e3, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(meters * 1e3, 10).ToString("F10").Length));
            tbCm.Text = Math.Round(meters * 1e2, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(meters * 1e2, 10).ToString("F10").Length));
            tbDm.Text = Math.Round(meters * 1e1, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(meters * 1e1, 10).ToString("F10").Length));
            tbM.Text = Math.Round(meters, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(meters, 10).ToString("F10").Length));
            tbKm.Text = Math.Round(meters / 1e3, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(meters / 1e3, 10).ToString("F10").Length));
            tbInch.Text = Math.Round(meters / 0.0254, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(meters / 0.0254, 10).ToString("F10").Length));
            tbFoot.Text = Math.Round(meters / 0.3048, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(meters / 0.3048, 10).ToString("F10").Length));
            tbYard.Text = Math.Round(meters / 0.9144, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(meters / 0.9144, 10).ToString("F10").Length));
            tbMile.Text = Math.Round(meters / 1609.344, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(meters / 1609.344, 10).ToString("F10").Length));

            tbNm.ReadOnly = true;
            tbMm.ReadOnly = true;
            tbCm.ReadOnly = true;
            tbDm.ReadOnly = true;
            tbInch.ReadOnly = true;
            tbFoot.ReadOnly = true;
            tbYard.ReadOnly = true;
            tbM.ReadOnly = true;
            tbKm.ReadOnly = true;
            tbMile.ReadOnly = true;
        }

        private void btnDistanceClear_Click(object sender, EventArgs e)
        {
            tbNm.Text = "";
            tbMm.Text = "";
            tbCm.Text = "";
            tbDm.Text = "";
            tbInch.Text = "";
            tbFoot.Text = "";
            tbYard.Text = "";
            tbM.Text = "";
            tbKm.Text = "";
            tbMile.Text = "";

            tbNm.ReadOnly = false;
            tbMm.ReadOnly = false;
            tbCm.ReadOnly = false;
            tbDm.ReadOnly = false;
            tbInch.ReadOnly = false;
            tbFoot.ReadOnly = false;
            tbYard.ReadOnly = false;
            tbM.ReadOnly = false;
            tbKm.ReadOnly = false;
            tbMile.ReadOnly = false;

        }
    }
}
