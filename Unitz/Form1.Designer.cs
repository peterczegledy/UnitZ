namespace Unitz
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbTime = new System.Windows.Forms.GroupBox();
            this.tbSeconds = new System.Windows.Forms.TextBox();
            this.tbMinutes = new System.Windows.Forms.TextBox();
            this.tbHours = new System.Windows.Forms.TextBox();
            this.tbDays = new System.Windows.Forms.TextBox();
            this.tbWeeks = new System.Windows.Forms.TextBox();
            this.tbMonths = new System.Windows.Forms.TextBox();
            this.tbYears = new System.Windows.Forms.TextBox();
            this.tbDecades = new System.Windows.Forms.TextBox();
            this.tbCenturies = new System.Windows.Forms.TextBox();
            this.tbMillennia = new System.Windows.Forms.TextBox();
            this.lSeconds = new System.Windows.Forms.Label();
            this.lMinutes = new System.Windows.Forms.Label();
            this.lHours = new System.Windows.Forms.Label();
            this.lDays = new System.Windows.Forms.Label();
            this.lWeeks = new System.Windows.Forms.Label();
            this.lMonths = new System.Windows.Forms.Label();
            this.lYears = new System.Windows.Forms.Label();
            this.lDecades = new System.Windows.Forms.Label();
            this.lCenturies = new System.Windows.Forms.Label();
            this.lMillennia = new System.Windows.Forms.Label();
            this.btnTimeCalculate = new System.Windows.Forms.Button();
            this.btnTimeClear = new System.Windows.Forms.Button();
            this.gbTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTime
            // 
            this.gbTime.Controls.Add(this.btnTimeClear);
            this.gbTime.Controls.Add(this.btnTimeCalculate);
            this.gbTime.Controls.Add(this.lMillennia);
            this.gbTime.Controls.Add(this.lCenturies);
            this.gbTime.Controls.Add(this.lDecades);
            this.gbTime.Controls.Add(this.lYears);
            this.gbTime.Controls.Add(this.lMonths);
            this.gbTime.Controls.Add(this.lWeeks);
            this.gbTime.Controls.Add(this.lDays);
            this.gbTime.Controls.Add(this.lHours);
            this.gbTime.Controls.Add(this.lMinutes);
            this.gbTime.Controls.Add(this.lSeconds);
            this.gbTime.Controls.Add(this.tbMillennia);
            this.gbTime.Controls.Add(this.tbCenturies);
            this.gbTime.Controls.Add(this.tbDecades);
            this.gbTime.Controls.Add(this.tbYears);
            this.gbTime.Controls.Add(this.tbMonths);
            this.gbTime.Controls.Add(this.tbWeeks);
            this.gbTime.Controls.Add(this.tbDays);
            this.gbTime.Controls.Add(this.tbHours);
            this.gbTime.Controls.Add(this.tbMinutes);
            this.gbTime.Controls.Add(this.tbSeconds);
            resources.ApplyResources(this.gbTime, "gbTime");
            this.gbTime.Name = "gbTime";
            this.gbTime.TabStop = false;
            this.gbTime.Enter += new System.EventHandler(this.gbTime_Enter);
            // 
            // tbSeconds
            // 
            resources.ApplyResources(this.tbSeconds, "tbSeconds");
            this.tbSeconds.Name = "tbSeconds";
            // 
            // tbMinutes
            // 
            resources.ApplyResources(this.tbMinutes, "tbMinutes");
            this.tbMinutes.Name = "tbMinutes";
            // 
            // tbHours
            // 
            resources.ApplyResources(this.tbHours, "tbHours");
            this.tbHours.Name = "tbHours";
            // 
            // tbDays
            // 
            resources.ApplyResources(this.tbDays, "tbDays");
            this.tbDays.Name = "tbDays";
            // 
            // tbWeeks
            // 
            resources.ApplyResources(this.tbWeeks, "tbWeeks");
            this.tbWeeks.Name = "tbWeeks";
            // 
            // tbMonths
            // 
            resources.ApplyResources(this.tbMonths, "tbMonths");
            this.tbMonths.Name = "tbMonths";
            // 
            // tbYears
            // 
            resources.ApplyResources(this.tbYears, "tbYears");
            this.tbYears.Name = "tbYears";
            // 
            // tbDecades
            // 
            resources.ApplyResources(this.tbDecades, "tbDecades");
            this.tbDecades.Name = "tbDecades";
            // 
            // tbCenturies
            // 
            resources.ApplyResources(this.tbCenturies, "tbCenturies");
            this.tbCenturies.Name = "tbCenturies";
            // 
            // tbMillennia
            // 
            resources.ApplyResources(this.tbMillennia, "tbMillennia");
            this.tbMillennia.Name = "tbMillennia";
            // 
            // lSeconds
            // 
            resources.ApplyResources(this.lSeconds, "lSeconds");
            this.lSeconds.Name = "lSeconds";
            // 
            // lMinutes
            // 
            resources.ApplyResources(this.lMinutes, "lMinutes");
            this.lMinutes.Name = "lMinutes";
            // 
            // lHours
            // 
            resources.ApplyResources(this.lHours, "lHours");
            this.lHours.Name = "lHours";
            // 
            // lDays
            // 
            resources.ApplyResources(this.lDays, "lDays");
            this.lDays.Name = "lDays";
            // 
            // lWeeks
            // 
            resources.ApplyResources(this.lWeeks, "lWeeks");
            this.lWeeks.Name = "lWeeks";
            // 
            // lMonths
            // 
            resources.ApplyResources(this.lMonths, "lMonths");
            this.lMonths.Name = "lMonths";
            // 
            // lYears
            // 
            resources.ApplyResources(this.lYears, "lYears");
            this.lYears.Name = "lYears";
            // 
            // lDecades
            // 
            resources.ApplyResources(this.lDecades, "lDecades");
            this.lDecades.Name = "lDecades";
            // 
            // lCenturies
            // 
            resources.ApplyResources(this.lCenturies, "lCenturies");
            this.lCenturies.Name = "lCenturies";
            // 
            // lMillennia
            // 
            resources.ApplyResources(this.lMillennia, "lMillennia");
            this.lMillennia.Name = "lMillennia";
            // 
            // btnTimeCalculate
            // 
            resources.ApplyResources(this.btnTimeCalculate, "btnTimeCalculate");
            this.btnTimeCalculate.Name = "btnTimeCalculate";
            this.btnTimeCalculate.UseVisualStyleBackColor = true;
            this.btnTimeCalculate.Click += new System.EventHandler(this.btnTimeCalculate_Click);
            // 
            // btnTimeClear
            // 
            resources.ApplyResources(this.btnTimeClear, "btnTimeClear");
            this.btnTimeClear.Name = "btnTimeClear";
            this.btnTimeClear.UseVisualStyleBackColor = true;
            this.btnTimeClear.Click += new System.EventHandler(this.btnTimeClear_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbTime);
            this.Name = "Form1";
            this.gbTime.ResumeLayout(false);
            this.gbTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTime;
        private System.Windows.Forms.Label lMillennia;
        private System.Windows.Forms.Label lCenturies;
        private System.Windows.Forms.Label lDecades;
        private System.Windows.Forms.Label lYears;
        private System.Windows.Forms.Label lMonths;
        private System.Windows.Forms.Label lWeeks;
        private System.Windows.Forms.Label lDays;
        private System.Windows.Forms.Label lHours;
        private System.Windows.Forms.Label lMinutes;
        private System.Windows.Forms.Label lSeconds;
        private System.Windows.Forms.TextBox tbMillennia;
        private System.Windows.Forms.TextBox tbCenturies;
        private System.Windows.Forms.TextBox tbDecades;
        private System.Windows.Forms.TextBox tbYears;
        private System.Windows.Forms.TextBox tbMonths;
        private System.Windows.Forms.TextBox tbWeeks;
        private System.Windows.Forms.TextBox tbDays;
        private System.Windows.Forms.TextBox tbHours;
        private System.Windows.Forms.TextBox tbMinutes;
        private System.Windows.Forms.TextBox tbSeconds;
        private System.Windows.Forms.Button btnTimeCalculate;
        private System.Windows.Forms.Button btnTimeClear;
    }
}

