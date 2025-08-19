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
                seconds = double.Parse(tbMonths.Text) * 2629746;
            else if (!string.IsNullOrEmpty(tbYears.Text))
                seconds = double.Parse(tbYears.Text) * 31556952;
            else if (!string.IsNullOrEmpty(tbDecades.Text))
                seconds = double.Parse(tbDecades.Text) * 315569520;
            else if (!string.IsNullOrEmpty(tbCenturies.Text))
                seconds = double.Parse(tbCenturies.Text) * 3155695200;
            else if (!string.IsNullOrEmpty(tbMillennia.Text))
                seconds = double.Parse(tbMillennia.Text) * 31556952000;
            else
                return;

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
                return;

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

        private void btnFluidCalculate_Click(object sender, EventArgs e)
        {
            double liters = 0;

            if (!string.IsNullOrEmpty(tbMl.Text))
                liters = double.Parse(tbMl.Text) / 1000.0;
            else if (!string.IsNullOrEmpty(tbCl.Text))
                liters = double.Parse(tbCl.Text) / 100.0;
            else if (!string.IsNullOrEmpty(tbDl.Text))
                liters = double.Parse(tbDl.Text) / 10.0;
            else if (!string.IsNullOrEmpty(tbL.Text))
                liters = double.Parse(tbL.Text);
            else if (!string.IsNullOrEmpty(tbFlOz.Text))
                liters = double.Parse(tbFlOz.Text) * 0.0295735;
            else if (!string.IsNullOrEmpty(tbCup.Text))
                liters = double.Parse(tbCup.Text) * 0.236588; 
            else if (!string.IsNullOrEmpty(tbPint.Text))
                liters = double.Parse(tbPint.Text) * 0.473176; 
            else if (!string.IsNullOrEmpty(tbQuart.Text))
                liters = double.Parse(tbQuart.Text) * 0.946353;
            else if (!string.IsNullOrEmpty(tbGallon.Text))
                liters = double.Parse(tbGallon.Text) * 3.78541;
            else
                return;

            tbMl.Text = Math.Round(liters * 1000, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(liters * 1000, 10).ToString("F10").Length));
            tbCl.Text = Math.Round(liters * 100, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(liters * 100, 10).ToString("F10").Length));
            tbDl.Text = Math.Round(liters * 10, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(liters * 10, 10).ToString("F10").Length));
            tbL.Text = Math.Round(liters, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(liters, 10).ToString("F10").Length));
            tbFlOz.Text = Math.Round(liters / 0.0295735, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(liters / 0.0295735, 10).ToString("F10").Length));
            tbCup.Text = Math.Round(liters / 0.236588, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(liters / 0.236588, 10).ToString("F10").Length));
            tbPint.Text = Math.Round(liters / 0.473176, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(liters / 0.473176, 10).ToString("F10").Length));
            tbQuart.Text = Math.Round(liters / 0.946353, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(liters / 0.946353, 10).ToString("F10").Length));
            tbGallon.Text = Math.Round(liters / 3.78541, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(liters / 3.78541, 10).ToString("F10").Length));

            tbMl.ReadOnly = true;
            tbCl.ReadOnly = true;
            tbDl.ReadOnly = true;
            tbFlOz.ReadOnly = true;
            tbCup.ReadOnly = true;
            tbPint.ReadOnly = true;
            tbQuart.ReadOnly = true;
            tbL.ReadOnly = true;
            tbGallon.ReadOnly = true;
        }

        private void btnFluidClear_Click(object sender, EventArgs e)
        {
            tbMl.Text = "";
            tbCl.Text = "";
            tbDl.Text = "";
            tbFlOz.Text = "";
            tbCup.Text = "";
            tbPint.Text = "";
            tbQuart.Text = "";
            tbL.Text = "";
            tbGallon.Text = "";

            tbMl.ReadOnly = false;
            tbCl.ReadOnly = false;
            tbDl.ReadOnly = false;
            tbFlOz.ReadOnly = false;
            tbCup.ReadOnly = false;
            tbPint.ReadOnly = false;
            tbQuart.ReadOnly = false;
            tbL.ReadOnly = false;
            tbGallon.ReadOnly = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnWeightCalculate_Click(object sender, EventArgs e)
        {
            double kilograms = 0;

            if (!string.IsNullOrEmpty(tbMg.Text))
                kilograms = double.Parse(tbMg.Text) / 1e6;
            else if (!string.IsNullOrEmpty(tbG.Text))
                kilograms = double.Parse(tbG.Text) / 1000.0;
            else if (!string.IsNullOrEmpty(tbDag.Text))
                kilograms = double.Parse(tbDag.Text) / 100.0;
            else if (!string.IsNullOrEmpty(tbOz.Text))
                kilograms = double.Parse(tbOz.Text) * 0.028349523125;
            else if (!string.IsNullOrEmpty(tbLb.Text))
                kilograms = double.Parse(tbLb.Text) * 0.45359237;
            else if (!string.IsNullOrEmpty(tbKg.Text))
                kilograms = double.Parse(tbKg.Text);
            else if (!string.IsNullOrEmpty(tbSt.Text))
                kilograms = double.Parse(tbSt.Text) * 6.35029318;
            else if (!string.IsNullOrEmpty(tbT.Text))
                kilograms = double.Parse(tbT.Text) * 1000.0;
            else if (!string.IsNullOrEmpty(tbShortTon.Text))
                kilograms = double.Parse(tbShortTon.Text) * 907.18474;
            else if (!string.IsNullOrEmpty(tbLongTon.Text))
                kilograms = double.Parse(tbLongTon.Text) * 1016.0469088;
            else
                return;

            tbMg.Text = Math.Round(kilograms * 1e6, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(kilograms * 1e6, 10).ToString("F10").Length));
            tbG.Text = Math.Round(kilograms * 1000.0, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(kilograms * 1000.0, 10).ToString("F10").Length));
            tbDag.Text = Math.Round(kilograms * 100.0, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(kilograms * 100.0, 10).ToString("F10").Length));
            tbOz.Text = Math.Round(kilograms / 0.028349523125, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(kilograms / 0.028349523125, 10).ToString("F10").Length));
            tbLb.Text = Math.Round(kilograms / 0.45359237, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(kilograms / 0.45359237, 10).ToString("F10").Length));
            tbKg.Text = Math.Round(kilograms, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(kilograms, 10).ToString("F10").Length));
            tbSt.Text = Math.Round(kilograms / 6.35029318, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(kilograms / 6.35029318, 10).ToString("F10").Length));
            tbT.Text = Math.Round(kilograms / 1000.0, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(kilograms / 1000.0, 10).ToString("F10").Length));
            tbShortTon.Text = Math.Round(kilograms / 907.18474, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(kilograms / 907.18474, 10).ToString("F10").Length));
            tbLongTon.Text = Math.Round(kilograms / 1016.0469088, 10).ToString("F10").Substring(0, Math.Min(13, Math.Round(kilograms / 1016.0469088, 10).ToString("F10").Length));

            tbMg.ReadOnly = true;
            tbG.ReadOnly = true;
            tbDag.ReadOnly = true;
            tbOz.ReadOnly = true;
            tbLb.ReadOnly = true;
            tbKg.ReadOnly = true;
            tbSt.ReadOnly = true;
            tbT.ReadOnly = true;
            tbShortTon.ReadOnly = true;
            tbLongTon.ReadOnly = true;
        }

        private void btnWeightClear_Click(object sender, EventArgs e)
        {
            tbMg.Text = "";
            tbG.Text = "";
            tbDag.Text = "";
            tbOz.Text = "";
            tbLb.Text = "";
            tbKg.Text = "";
            tbSt.Text = "";
            tbT.Text = "";
            tbShortTon.Text = "";
            tbLongTon.Text = "";

            tbMg.ReadOnly = false;
            tbG.ReadOnly = false;
            tbDag.ReadOnly = false;
            tbOz.ReadOnly = false;
            tbLb.ReadOnly = false;
            tbKg.ReadOnly = false;
            tbSt.ReadOnly = false;
            tbT.ReadOnly = false;
            tbShortTon.ReadOnly = false;
            tbLongTon.ReadOnly = false;
        }
    }
}
