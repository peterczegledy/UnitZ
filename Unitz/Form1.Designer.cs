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
            this.gbDistance = new System.Windows.Forms.GroupBox();
            this.tbNm = new System.Windows.Forms.TextBox();
            this.tbMm = new System.Windows.Forms.TextBox();
            this.tbCm = new System.Windows.Forms.TextBox();
            this.tbDm = new System.Windows.Forms.TextBox();
            this.tbInch = new System.Windows.Forms.TextBox();
            this.tbFoot = new System.Windows.Forms.TextBox();
            this.tbYard = new System.Windows.Forms.TextBox();
            this.tbM = new System.Windows.Forms.TextBox();
            this.tbKm = new System.Windows.Forms.TextBox();
            this.tbMile = new System.Windows.Forms.TextBox();
            this.btnDistanceCalculate = new System.Windows.Forms.Button();
            this.btnDistanceClear = new System.Windows.Forms.Button();
            this.lNm = new System.Windows.Forms.Label();
            this.lMm = new System.Windows.Forms.Label();
            this.lCm = new System.Windows.Forms.Label();
            this.lDm = new System.Windows.Forms.Label();
            this.lInches = new System.Windows.Forms.Label();
            this.lFoot = new System.Windows.Forms.Label();
            this.lYard = new System.Windows.Forms.Label();
            this.lM = new System.Windows.Forms.Label();
            this.lKm = new System.Windows.Forms.Label();
            this.lMile = new System.Windows.Forms.Label();
            this.gbFluid = new System.Windows.Forms.GroupBox();
            this.tbMl = new System.Windows.Forms.TextBox();
            this.tbCl = new System.Windows.Forms.TextBox();
            this.tbDl = new System.Windows.Forms.TextBox();
            this.tbFlOz = new System.Windows.Forms.TextBox();
            this.tbCup = new System.Windows.Forms.TextBox();
            this.tbPint = new System.Windows.Forms.TextBox();
            this.tbQuart = new System.Windows.Forms.TextBox();
            this.tbL = new System.Windows.Forms.TextBox();
            this.tbGallon = new System.Windows.Forms.TextBox();
            this.lMl = new System.Windows.Forms.Label();
            this.lCl = new System.Windows.Forms.Label();
            this.lDl = new System.Windows.Forms.Label();
            this.lFlOz = new System.Windows.Forms.Label();
            this.lCup = new System.Windows.Forms.Label();
            this.lPint = new System.Windows.Forms.Label();
            this.lQuart = new System.Windows.Forms.Label();
            this.lL = new System.Windows.Forms.Label();
            this.lGallon = new System.Windows.Forms.Label();
            this.btnFluidCalculate = new System.Windows.Forms.Button();
            this.btnFluidClear = new System.Windows.Forms.Button();
            this.gbWeight = new System.Windows.Forms.GroupBox();
            this.tbMg = new System.Windows.Forms.TextBox();
            this.tbG = new System.Windows.Forms.TextBox();
            this.tbDag = new System.Windows.Forms.TextBox();
            this.tbOz = new System.Windows.Forms.TextBox();
            this.tbLb = new System.Windows.Forms.TextBox();
            this.tbKg = new System.Windows.Forms.TextBox();
            this.tbSt = new System.Windows.Forms.TextBox();
            this.tbT = new System.Windows.Forms.TextBox();
            this.tbShortTon = new System.Windows.Forms.TextBox();
            this.tbLongTon = new System.Windows.Forms.TextBox();
            this.lMg = new System.Windows.Forms.Label();
            this.lG = new System.Windows.Forms.Label();
            this.lDag = new System.Windows.Forms.Label();
            this.lOz = new System.Windows.Forms.Label();
            this.lLb = new System.Windows.Forms.Label();
            this.lKg = new System.Windows.Forms.Label();
            this.lSt = new System.Windows.Forms.Label();
            this.lT = new System.Windows.Forms.Label();
            this.lShortTon = new System.Windows.Forms.Label();
            this.lLongTon = new System.Windows.Forms.Label();
            this.btnWeightCalculate = new System.Windows.Forms.Button();
            this.btnWeightClear = new System.Windows.Forms.Button();
            this.gbTime.SuspendLayout();
            this.gbDistance.SuspendLayout();
            this.gbFluid.SuspendLayout();
            this.gbWeight.SuspendLayout();
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
            // gbDistance
            // 
            this.gbDistance.Controls.Add(this.lMile);
            this.gbDistance.Controls.Add(this.lKm);
            this.gbDistance.Controls.Add(this.lM);
            this.gbDistance.Controls.Add(this.lYard);
            this.gbDistance.Controls.Add(this.lFoot);
            this.gbDistance.Controls.Add(this.lInches);
            this.gbDistance.Controls.Add(this.lDm);
            this.gbDistance.Controls.Add(this.lCm);
            this.gbDistance.Controls.Add(this.lMm);
            this.gbDistance.Controls.Add(this.lNm);
            this.gbDistance.Controls.Add(this.btnDistanceClear);
            this.gbDistance.Controls.Add(this.btnDistanceCalculate);
            this.gbDistance.Controls.Add(this.tbMile);
            this.gbDistance.Controls.Add(this.tbKm);
            this.gbDistance.Controls.Add(this.tbM);
            this.gbDistance.Controls.Add(this.tbYard);
            this.gbDistance.Controls.Add(this.tbFoot);
            this.gbDistance.Controls.Add(this.tbInch);
            this.gbDistance.Controls.Add(this.tbDm);
            this.gbDistance.Controls.Add(this.tbCm);
            this.gbDistance.Controls.Add(this.tbMm);
            this.gbDistance.Controls.Add(this.tbNm);
            resources.ApplyResources(this.gbDistance, "gbDistance");
            this.gbDistance.Name = "gbDistance";
            this.gbDistance.TabStop = false;
            // 
            // tbNm
            // 
            resources.ApplyResources(this.tbNm, "tbNm");
            this.tbNm.Name = "tbNm";
            // 
            // tbMm
            // 
            resources.ApplyResources(this.tbMm, "tbMm");
            this.tbMm.Name = "tbMm";
            // 
            // tbCm
            // 
            resources.ApplyResources(this.tbCm, "tbCm");
            this.tbCm.Name = "tbCm";
            // 
            // tbDm
            // 
            resources.ApplyResources(this.tbDm, "tbDm");
            this.tbDm.Name = "tbDm";
            // 
            // tbInch
            // 
            resources.ApplyResources(this.tbInch, "tbInch");
            this.tbInch.Name = "tbInch";
            // 
            // tbFoot
            // 
            resources.ApplyResources(this.tbFoot, "tbFoot");
            this.tbFoot.Name = "tbFoot";
            // 
            // tbYard
            // 
            resources.ApplyResources(this.tbYard, "tbYard");
            this.tbYard.Name = "tbYard";
            // 
            // tbM
            // 
            resources.ApplyResources(this.tbM, "tbM");
            this.tbM.Name = "tbM";
            // 
            // tbKm
            // 
            resources.ApplyResources(this.tbKm, "tbKm");
            this.tbKm.Name = "tbKm";
            // 
            // tbMile
            // 
            resources.ApplyResources(this.tbMile, "tbMile");
            this.tbMile.Name = "tbMile";
            // 
            // btnDistanceCalculate
            // 
            resources.ApplyResources(this.btnDistanceCalculate, "btnDistanceCalculate");
            this.btnDistanceCalculate.Name = "btnDistanceCalculate";
            this.btnDistanceCalculate.UseVisualStyleBackColor = true;
            this.btnDistanceCalculate.Click += new System.EventHandler(this.btnDistanceCalculate_Click);
            // 
            // btnDistanceClear
            // 
            resources.ApplyResources(this.btnDistanceClear, "btnDistanceClear");
            this.btnDistanceClear.Name = "btnDistanceClear";
            this.btnDistanceClear.UseVisualStyleBackColor = true;
            this.btnDistanceClear.Click += new System.EventHandler(this.btnDistanceClear_Click);
            // 
            // lNm
            // 
            resources.ApplyResources(this.lNm, "lNm");
            this.lNm.Name = "lNm";
            // 
            // lMm
            // 
            resources.ApplyResources(this.lMm, "lMm");
            this.lMm.Name = "lMm";
            // 
            // lCm
            // 
            resources.ApplyResources(this.lCm, "lCm");
            this.lCm.Name = "lCm";
            // 
            // lDm
            // 
            resources.ApplyResources(this.lDm, "lDm");
            this.lDm.Name = "lDm";
            // 
            // lInches
            // 
            resources.ApplyResources(this.lInches, "lInches");
            this.lInches.Name = "lInches";
            // 
            // lFoot
            // 
            resources.ApplyResources(this.lFoot, "lFoot");
            this.lFoot.Name = "lFoot";
            // 
            // lYard
            // 
            resources.ApplyResources(this.lYard, "lYard");
            this.lYard.Name = "lYard";
            // 
            // lM
            // 
            resources.ApplyResources(this.lM, "lM");
            this.lM.Name = "lM";
            // 
            // lKm
            // 
            resources.ApplyResources(this.lKm, "lKm");
            this.lKm.Name = "lKm";
            // 
            // lMile
            // 
            resources.ApplyResources(this.lMile, "lMile");
            this.lMile.Name = "lMile";
            // 
            // gbFluid
            // 
            this.gbFluid.Controls.Add(this.btnFluidClear);
            this.gbFluid.Controls.Add(this.btnFluidCalculate);
            this.gbFluid.Controls.Add(this.lGallon);
            this.gbFluid.Controls.Add(this.lL);
            this.gbFluid.Controls.Add(this.lQuart);
            this.gbFluid.Controls.Add(this.lPint);
            this.gbFluid.Controls.Add(this.lCup);
            this.gbFluid.Controls.Add(this.lFlOz);
            this.gbFluid.Controls.Add(this.lDl);
            this.gbFluid.Controls.Add(this.lCl);
            this.gbFluid.Controls.Add(this.lMl);
            this.gbFluid.Controls.Add(this.tbGallon);
            this.gbFluid.Controls.Add(this.tbL);
            this.gbFluid.Controls.Add(this.tbQuart);
            this.gbFluid.Controls.Add(this.tbPint);
            this.gbFluid.Controls.Add(this.tbCup);
            this.gbFluid.Controls.Add(this.tbFlOz);
            this.gbFluid.Controls.Add(this.tbDl);
            this.gbFluid.Controls.Add(this.tbCl);
            this.gbFluid.Controls.Add(this.tbMl);
            resources.ApplyResources(this.gbFluid, "gbFluid");
            this.gbFluid.Name = "gbFluid";
            this.gbFluid.TabStop = false;
            // 
            // tbMl
            // 
            resources.ApplyResources(this.tbMl, "tbMl");
            this.tbMl.Name = "tbMl";
            // 
            // tbCl
            // 
            resources.ApplyResources(this.tbCl, "tbCl");
            this.tbCl.Name = "tbCl";
            // 
            // tbDl
            // 
            resources.ApplyResources(this.tbDl, "tbDl");
            this.tbDl.Name = "tbDl";
            // 
            // tbFlOz
            // 
            resources.ApplyResources(this.tbFlOz, "tbFlOz");
            this.tbFlOz.Name = "tbFlOz";
            // 
            // tbCup
            // 
            resources.ApplyResources(this.tbCup, "tbCup");
            this.tbCup.Name = "tbCup";
            // 
            // tbPint
            // 
            resources.ApplyResources(this.tbPint, "tbPint");
            this.tbPint.Name = "tbPint";
            // 
            // tbQuart
            // 
            resources.ApplyResources(this.tbQuart, "tbQuart");
            this.tbQuart.Name = "tbQuart";
            // 
            // tbL
            // 
            resources.ApplyResources(this.tbL, "tbL");
            this.tbL.Name = "tbL";
            // 
            // tbGallon
            // 
            resources.ApplyResources(this.tbGallon, "tbGallon");
            this.tbGallon.Name = "tbGallon";
            // 
            // lMl
            // 
            resources.ApplyResources(this.lMl, "lMl");
            this.lMl.Name = "lMl";
            // 
            // lCl
            // 
            resources.ApplyResources(this.lCl, "lCl");
            this.lCl.Name = "lCl";
            // 
            // lDl
            // 
            resources.ApplyResources(this.lDl, "lDl");
            this.lDl.Name = "lDl";
            // 
            // lFlOz
            // 
            resources.ApplyResources(this.lFlOz, "lFlOz");
            this.lFlOz.Name = "lFlOz";
            // 
            // lCup
            // 
            resources.ApplyResources(this.lCup, "lCup");
            this.lCup.Name = "lCup";
            // 
            // lPint
            // 
            resources.ApplyResources(this.lPint, "lPint");
            this.lPint.Name = "lPint";
            // 
            // lQuart
            // 
            resources.ApplyResources(this.lQuart, "lQuart");
            this.lQuart.Name = "lQuart";
            // 
            // lL
            // 
            resources.ApplyResources(this.lL, "lL");
            this.lL.Name = "lL";
            // 
            // lGallon
            // 
            resources.ApplyResources(this.lGallon, "lGallon");
            this.lGallon.Name = "lGallon";
            // 
            // btnFluidCalculate
            // 
            resources.ApplyResources(this.btnFluidCalculate, "btnFluidCalculate");
            this.btnFluidCalculate.Name = "btnFluidCalculate";
            this.btnFluidCalculate.UseVisualStyleBackColor = true;
            this.btnFluidCalculate.Click += new System.EventHandler(this.btnFluidCalculate_Click);
            // 
            // btnFluidClear
            // 
            resources.ApplyResources(this.btnFluidClear, "btnFluidClear");
            this.btnFluidClear.Name = "btnFluidClear";
            this.btnFluidClear.UseVisualStyleBackColor = true;
            this.btnFluidClear.Click += new System.EventHandler(this.btnFluidClear_Click);
            // 
            // gbWeight
            // 
            this.gbWeight.Controls.Add(this.btnWeightClear);
            this.gbWeight.Controls.Add(this.btnWeightCalculate);
            this.gbWeight.Controls.Add(this.lLongTon);
            this.gbWeight.Controls.Add(this.lShortTon);
            this.gbWeight.Controls.Add(this.lT);
            this.gbWeight.Controls.Add(this.lSt);
            this.gbWeight.Controls.Add(this.lKg);
            this.gbWeight.Controls.Add(this.lLb);
            this.gbWeight.Controls.Add(this.lOz);
            this.gbWeight.Controls.Add(this.lDag);
            this.gbWeight.Controls.Add(this.lG);
            this.gbWeight.Controls.Add(this.lMg);
            this.gbWeight.Controls.Add(this.tbLongTon);
            this.gbWeight.Controls.Add(this.tbShortTon);
            this.gbWeight.Controls.Add(this.tbT);
            this.gbWeight.Controls.Add(this.tbSt);
            this.gbWeight.Controls.Add(this.tbKg);
            this.gbWeight.Controls.Add(this.tbLb);
            this.gbWeight.Controls.Add(this.tbOz);
            this.gbWeight.Controls.Add(this.tbDag);
            this.gbWeight.Controls.Add(this.tbG);
            this.gbWeight.Controls.Add(this.tbMg);
            resources.ApplyResources(this.gbWeight, "gbWeight");
            this.gbWeight.Name = "gbWeight";
            this.gbWeight.TabStop = false;
            // 
            // tbMg
            // 
            resources.ApplyResources(this.tbMg, "tbMg");
            this.tbMg.Name = "tbMg";
            this.tbMg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbG
            // 
            resources.ApplyResources(this.tbG, "tbG");
            this.tbG.Name = "tbG";
            // 
            // tbDag
            // 
            resources.ApplyResources(this.tbDag, "tbDag");
            this.tbDag.Name = "tbDag";
            // 
            // tbOz
            // 
            resources.ApplyResources(this.tbOz, "tbOz");
            this.tbOz.Name = "tbOz";
            // 
            // tbLb
            // 
            resources.ApplyResources(this.tbLb, "tbLb");
            this.tbLb.Name = "tbLb";
            // 
            // tbKg
            // 
            resources.ApplyResources(this.tbKg, "tbKg");
            this.tbKg.Name = "tbKg";
            // 
            // tbSt
            // 
            resources.ApplyResources(this.tbSt, "tbSt");
            this.tbSt.Name = "tbSt";
            // 
            // tbT
            // 
            resources.ApplyResources(this.tbT, "tbT");
            this.tbT.Name = "tbT";
            // 
            // tbShortTon
            // 
            resources.ApplyResources(this.tbShortTon, "tbShortTon");
            this.tbShortTon.Name = "tbShortTon";
            // 
            // tbLongTon
            // 
            resources.ApplyResources(this.tbLongTon, "tbLongTon");
            this.tbLongTon.Name = "tbLongTon";
            // 
            // lMg
            // 
            resources.ApplyResources(this.lMg, "lMg");
            this.lMg.Name = "lMg";
            // 
            // lG
            // 
            resources.ApplyResources(this.lG, "lG");
            this.lG.Name = "lG";
            // 
            // lDag
            // 
            resources.ApplyResources(this.lDag, "lDag");
            this.lDag.Name = "lDag";
            // 
            // lOz
            // 
            resources.ApplyResources(this.lOz, "lOz");
            this.lOz.Name = "lOz";
            // 
            // lLb
            // 
            resources.ApplyResources(this.lLb, "lLb");
            this.lLb.Name = "lLb";
            // 
            // lKg
            // 
            resources.ApplyResources(this.lKg, "lKg");
            this.lKg.Name = "lKg";
            // 
            // lSt
            // 
            resources.ApplyResources(this.lSt, "lSt");
            this.lSt.Name = "lSt";
            // 
            // lT
            // 
            resources.ApplyResources(this.lT, "lT");
            this.lT.Name = "lT";
            // 
            // lShortTon
            // 
            resources.ApplyResources(this.lShortTon, "lShortTon");
            this.lShortTon.Name = "lShortTon";
            // 
            // lLongTon
            // 
            resources.ApplyResources(this.lLongTon, "lLongTon");
            this.lLongTon.Name = "lLongTon";
            // 
            // btnWeightCalculate
            // 
            resources.ApplyResources(this.btnWeightCalculate, "btnWeightCalculate");
            this.btnWeightCalculate.Name = "btnWeightCalculate";
            this.btnWeightCalculate.UseVisualStyleBackColor = true;
            this.btnWeightCalculate.Click += new System.EventHandler(this.btnWeightCalculate_Click);
            // 
            // btnWeightClear
            // 
            resources.ApplyResources(this.btnWeightClear, "btnWeightClear");
            this.btnWeightClear.Name = "btnWeightClear";
            this.btnWeightClear.UseVisualStyleBackColor = true;
            this.btnWeightClear.Click += new System.EventHandler(this.btnWeightClear_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbWeight);
            this.Controls.Add(this.gbFluid);
            this.Controls.Add(this.gbDistance);
            this.Controls.Add(this.gbTime);
            this.Name = "Form1";
            this.gbTime.ResumeLayout(false);
            this.gbTime.PerformLayout();
            this.gbDistance.ResumeLayout(false);
            this.gbDistance.PerformLayout();
            this.gbFluid.ResumeLayout(false);
            this.gbFluid.PerformLayout();
            this.gbWeight.ResumeLayout(false);
            this.gbWeight.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbDistance;
        private System.Windows.Forms.Button btnDistanceCalculate;
        private System.Windows.Forms.TextBox tbMile;
        private System.Windows.Forms.TextBox tbKm;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.TextBox tbYard;
        private System.Windows.Forms.TextBox tbFoot;
        private System.Windows.Forms.TextBox tbInch;
        private System.Windows.Forms.TextBox tbDm;
        private System.Windows.Forms.TextBox tbCm;
        private System.Windows.Forms.TextBox tbMm;
        private System.Windows.Forms.TextBox tbNm;
        private System.Windows.Forms.Button btnDistanceClear;
        private System.Windows.Forms.Label lMile;
        private System.Windows.Forms.Label lKm;
        private System.Windows.Forms.Label lM;
        private System.Windows.Forms.Label lYard;
        private System.Windows.Forms.Label lFoot;
        private System.Windows.Forms.Label lInches;
        private System.Windows.Forms.Label lDm;
        private System.Windows.Forms.Label lCm;
        private System.Windows.Forms.Label lMm;
        private System.Windows.Forms.Label lNm;
        private System.Windows.Forms.GroupBox gbFluid;
        private System.Windows.Forms.TextBox tbGallon;
        private System.Windows.Forms.TextBox tbL;
        private System.Windows.Forms.TextBox tbQuart;
        private System.Windows.Forms.TextBox tbPint;
        private System.Windows.Forms.TextBox tbCup;
        private System.Windows.Forms.TextBox tbFlOz;
        private System.Windows.Forms.TextBox tbDl;
        private System.Windows.Forms.TextBox tbCl;
        private System.Windows.Forms.TextBox tbMl;
        private System.Windows.Forms.Label lGallon;
        private System.Windows.Forms.Label lL;
        private System.Windows.Forms.Label lQuart;
        private System.Windows.Forms.Label lPint;
        private System.Windows.Forms.Label lCup;
        private System.Windows.Forms.Label lFlOz;
        private System.Windows.Forms.Label lDl;
        private System.Windows.Forms.Label lCl;
        private System.Windows.Forms.Label lMl;
        private System.Windows.Forms.Button btnFluidCalculate;
        private System.Windows.Forms.Button btnFluidClear;
        private System.Windows.Forms.GroupBox gbWeight;
        private System.Windows.Forms.TextBox tbMg;
        private System.Windows.Forms.TextBox tbLongTon;
        private System.Windows.Forms.TextBox tbShortTon;
        private System.Windows.Forms.TextBox tbT;
        private System.Windows.Forms.TextBox tbSt;
        private System.Windows.Forms.TextBox tbKg;
        private System.Windows.Forms.TextBox tbLb;
        private System.Windows.Forms.TextBox tbOz;
        private System.Windows.Forms.TextBox tbDag;
        private System.Windows.Forms.TextBox tbG;
        private System.Windows.Forms.Label lKg;
        private System.Windows.Forms.Label lLb;
        private System.Windows.Forms.Label lOz;
        private System.Windows.Forms.Label lDag;
        private System.Windows.Forms.Label lG;
        private System.Windows.Forms.Label lMg;
        private System.Windows.Forms.Button btnWeightClear;
        private System.Windows.Forms.Button btnWeightCalculate;
        private System.Windows.Forms.Label lLongTon;
        private System.Windows.Forms.Label lShortTon;
        private System.Windows.Forms.Label lT;
        private System.Windows.Forms.Label lSt;
    }
}

