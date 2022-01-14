namespace AlarmClock.Forms
{
    partial class TimezoneForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.zoneR11Btn = new System.Windows.Forms.Button();
            this.zoneR10Btn = new System.Windows.Forms.Button();
            this.zoneR09Btn = new System.Windows.Forms.Button();
            this.zoneR08Btn = new System.Windows.Forms.Button();
            this.zoneR07Btn = new System.Windows.Forms.Button();
            this.zoneR06Btn = new System.Windows.Forms.Button();
            this.zoneR05Btn = new System.Windows.Forms.Button();
            this.zoneR04Btn = new System.Windows.Forms.Button();
            this.zoneR03Btn = new System.Windows.Forms.Button();
            this.zoneR02Btn = new System.Windows.Forms.Button();
            this.zoneR01Btn = new System.Windows.Forms.Button();
            this.zone00Btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.zone12Btn = new System.Windows.Forms.Button();
            this.zone11Btn = new System.Windows.Forms.Button();
            this.zone10Btn = new System.Windows.Forms.Button();
            this.zone09Btn = new System.Windows.Forms.Button();
            this.zone08Btn = new System.Windows.Forms.Button();
            this.zone07Btn = new System.Windows.Forms.Button();
            this.zone06Btn = new System.Windows.Forms.Button();
            this.zone05Btn = new System.Windows.Forms.Button();
            this.zone04Btn = new System.Windows.Forms.Button();
            this.zone03Btn = new System.Windows.Forms.Button();
            this.zone02Btn = new System.Windows.Forms.Button();
            this.zone01Btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 35);
            this.panel1.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TitleLabel.Location = new System.Drawing.Point(92, 5);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(117, 27);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "請選擇時區";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.CancelBtn);
            this.panel4.Controls.Add(this.SaveBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel4.Location = new System.Drawing.Point(0, 395);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 40);
            this.panel4.TabIndex = 1;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.SystemColors.Control;
            this.CancelBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CancelBtn.Location = new System.Drawing.Point(180, 5);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(100, 30);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.SaveBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SaveBtn.Location = new System.Drawing.Point(21, 5);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(100, 30);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "確定";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.zoneR11Btn);
            this.panel2.Controls.Add(this.zoneR10Btn);
            this.panel2.Controls.Add(this.zoneR09Btn);
            this.panel2.Controls.Add(this.zoneR08Btn);
            this.panel2.Controls.Add(this.zoneR07Btn);
            this.panel2.Controls.Add(this.zoneR06Btn);
            this.panel2.Controls.Add(this.zoneR05Btn);
            this.panel2.Controls.Add(this.zoneR04Btn);
            this.panel2.Controls.Add(this.zoneR03Btn);
            this.panel2.Controls.Add(this.zoneR02Btn);
            this.panel2.Controls.Add(this.zoneR01Btn);
            this.panel2.Controls.Add(this.zone00Btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 360);
            this.panel2.TabIndex = 2;
            // 
            // zoneR11Btn
            // 
            this.zoneR11Btn.BackColor = System.Drawing.SystemColors.Control;
            this.zoneR11Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.zoneR11Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zoneR11Btn.Location = new System.Drawing.Point(0, 330);
            this.zoneR11Btn.Name = "zoneR11Btn";
            this.zoneR11Btn.Size = new System.Drawing.Size(150, 30);
            this.zoneR11Btn.TabIndex = 11;
            this.zoneR11Btn.Text = "UTC-11";
            this.zoneR11Btn.UseVisualStyleBackColor = false;
            // 
            // zoneR10Btn
            // 
            this.zoneR10Btn.BackColor = System.Drawing.SystemColors.Control;
            this.zoneR10Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.zoneR10Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zoneR10Btn.Location = new System.Drawing.Point(0, 300);
            this.zoneR10Btn.Name = "zoneR10Btn";
            this.zoneR10Btn.Size = new System.Drawing.Size(150, 30);
            this.zoneR10Btn.TabIndex = 10;
            this.zoneR10Btn.Text = "UTC-10";
            this.zoneR10Btn.UseVisualStyleBackColor = false;
            // 
            // zoneR09Btn
            // 
            this.zoneR09Btn.BackColor = System.Drawing.SystemColors.Control;
            this.zoneR09Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.zoneR09Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zoneR09Btn.Location = new System.Drawing.Point(0, 270);
            this.zoneR09Btn.Name = "zoneR09Btn";
            this.zoneR09Btn.Size = new System.Drawing.Size(150, 30);
            this.zoneR09Btn.TabIndex = 9;
            this.zoneR09Btn.Text = "UTC-9";
            this.zoneR09Btn.UseVisualStyleBackColor = false;
            // 
            // zoneR08Btn
            // 
            this.zoneR08Btn.BackColor = System.Drawing.SystemColors.Control;
            this.zoneR08Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.zoneR08Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zoneR08Btn.Location = new System.Drawing.Point(0, 240);
            this.zoneR08Btn.Name = "zoneR08Btn";
            this.zoneR08Btn.Size = new System.Drawing.Size(150, 30);
            this.zoneR08Btn.TabIndex = 8;
            this.zoneR08Btn.Text = "UTC-8";
            this.zoneR08Btn.UseVisualStyleBackColor = false;
            // 
            // zoneR07Btn
            // 
            this.zoneR07Btn.BackColor = System.Drawing.SystemColors.Control;
            this.zoneR07Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.zoneR07Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zoneR07Btn.Location = new System.Drawing.Point(0, 210);
            this.zoneR07Btn.Name = "zoneR07Btn";
            this.zoneR07Btn.Size = new System.Drawing.Size(150, 30);
            this.zoneR07Btn.TabIndex = 7;
            this.zoneR07Btn.Text = "UTC-7";
            this.zoneR07Btn.UseVisualStyleBackColor = false;
            // 
            // zoneR06Btn
            // 
            this.zoneR06Btn.BackColor = System.Drawing.SystemColors.Control;
            this.zoneR06Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.zoneR06Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zoneR06Btn.Location = new System.Drawing.Point(0, 180);
            this.zoneR06Btn.Name = "zoneR06Btn";
            this.zoneR06Btn.Size = new System.Drawing.Size(150, 30);
            this.zoneR06Btn.TabIndex = 6;
            this.zoneR06Btn.Text = "UTC-6";
            this.zoneR06Btn.UseVisualStyleBackColor = false;
            // 
            // zoneR05Btn
            // 
            this.zoneR05Btn.BackColor = System.Drawing.SystemColors.Control;
            this.zoneR05Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.zoneR05Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zoneR05Btn.Location = new System.Drawing.Point(0, 150);
            this.zoneR05Btn.Name = "zoneR05Btn";
            this.zoneR05Btn.Size = new System.Drawing.Size(150, 30);
            this.zoneR05Btn.TabIndex = 5;
            this.zoneR05Btn.Text = "UTC-5";
            this.zoneR05Btn.UseVisualStyleBackColor = false;
            // 
            // zoneR04Btn
            // 
            this.zoneR04Btn.BackColor = System.Drawing.SystemColors.Control;
            this.zoneR04Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.zoneR04Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zoneR04Btn.Location = new System.Drawing.Point(0, 120);
            this.zoneR04Btn.Name = "zoneR04Btn";
            this.zoneR04Btn.Size = new System.Drawing.Size(150, 30);
            this.zoneR04Btn.TabIndex = 4;
            this.zoneR04Btn.Text = "UTC-4";
            this.zoneR04Btn.UseVisualStyleBackColor = false;
            // 
            // zoneR03Btn
            // 
            this.zoneR03Btn.BackColor = System.Drawing.SystemColors.Control;
            this.zoneR03Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.zoneR03Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zoneR03Btn.Location = new System.Drawing.Point(0, 90);
            this.zoneR03Btn.Name = "zoneR03Btn";
            this.zoneR03Btn.Size = new System.Drawing.Size(150, 30);
            this.zoneR03Btn.TabIndex = 3;
            this.zoneR03Btn.Text = "UTC-3";
            this.zoneR03Btn.UseVisualStyleBackColor = false;
            // 
            // zoneR02Btn
            // 
            this.zoneR02Btn.BackColor = System.Drawing.SystemColors.Control;
            this.zoneR02Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.zoneR02Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zoneR02Btn.Location = new System.Drawing.Point(0, 60);
            this.zoneR02Btn.Name = "zoneR02Btn";
            this.zoneR02Btn.Size = new System.Drawing.Size(150, 30);
            this.zoneR02Btn.TabIndex = 2;
            this.zoneR02Btn.Text = "UTC-2";
            this.zoneR02Btn.UseVisualStyleBackColor = false;
            // 
            // zoneR01Btn
            // 
            this.zoneR01Btn.BackColor = System.Drawing.SystemColors.Control;
            this.zoneR01Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.zoneR01Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zoneR01Btn.Location = new System.Drawing.Point(0, 30);
            this.zoneR01Btn.Name = "zoneR01Btn";
            this.zoneR01Btn.Size = new System.Drawing.Size(150, 30);
            this.zoneR01Btn.TabIndex = 1;
            this.zoneR01Btn.Text = "UTC-1";
            this.zoneR01Btn.UseVisualStyleBackColor = false;
            // 
            // zone00Btn
            // 
            this.zone00Btn.BackColor = System.Drawing.SystemColors.Control;
            this.zone00Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.zone00Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zone00Btn.Location = new System.Drawing.Point(0, 0);
            this.zone00Btn.Name = "zone00Btn";
            this.zone00Btn.Size = new System.Drawing.Size(150, 30);
            this.zone00Btn.TabIndex = 0;
            this.zone00Btn.Text = "UTC";
            this.zone00Btn.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.zone12Btn);
            this.panel3.Controls.Add(this.zone11Btn);
            this.panel3.Controls.Add(this.zone10Btn);
            this.panel3.Controls.Add(this.zone09Btn);
            this.panel3.Controls.Add(this.zone08Btn);
            this.panel3.Controls.Add(this.zone07Btn);
            this.panel3.Controls.Add(this.zone06Btn);
            this.panel3.Controls.Add(this.zone05Btn);
            this.panel3.Controls.Add(this.zone04Btn);
            this.panel3.Controls.Add(this.zone03Btn);
            this.panel3.Controls.Add(this.zone02Btn);
            this.panel3.Controls.Add(this.zone01Btn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel3.Location = new System.Drawing.Point(150, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 360);
            this.panel3.TabIndex = 3;
            // 
            // zone12Btn
            // 
            this.zone12Btn.BackColor = System.Drawing.SystemColors.Control;
            this.zone12Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.zone12Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zone12Btn.Location = new System.Drawing.Point(0, 330);
            this.zone12Btn.Name = "zone12Btn";
            this.zone12Btn.Size = new System.Drawing.Size(150, 30);
            this.zone12Btn.TabIndex = 12;
            this.zone12Btn.Text = "UTC+12";
            this.zone12Btn.UseVisualStyleBackColor = false;
            // 
            // zone11Btn
            // 
            this.zone11Btn.BackColor = System.Drawing.SystemColors.Control;
            this.zone11Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.zone11Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zone11Btn.Location = new System.Drawing.Point(0, 300);
            this.zone11Btn.Name = "zone11Btn";
            this.zone11Btn.Size = new System.Drawing.Size(150, 30);
            this.zone11Btn.TabIndex = 11;
            this.zone11Btn.Text = "UTC+11";
            this.zone11Btn.UseVisualStyleBackColor = false;
            // 
            // zone10Btn
            // 
            this.zone10Btn.BackColor = System.Drawing.SystemColors.Control;
            this.zone10Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.zone10Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zone10Btn.Location = new System.Drawing.Point(0, 270);
            this.zone10Btn.Name = "zone10Btn";
            this.zone10Btn.Size = new System.Drawing.Size(150, 30);
            this.zone10Btn.TabIndex = 10;
            this.zone10Btn.Text = "UTC+10";
            this.zone10Btn.UseVisualStyleBackColor = false;
            // 
            // zone09Btn
            // 
            this.zone09Btn.BackColor = System.Drawing.SystemColors.Control;
            this.zone09Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.zone09Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zone09Btn.Location = new System.Drawing.Point(0, 240);
            this.zone09Btn.Name = "zone09Btn";
            this.zone09Btn.Size = new System.Drawing.Size(150, 30);
            this.zone09Btn.TabIndex = 9;
            this.zone09Btn.Text = "UTC+9";
            this.zone09Btn.UseVisualStyleBackColor = false;
            // 
            // zone08Btn
            // 
            this.zone08Btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.zone08Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.zone08Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zone08Btn.Location = new System.Drawing.Point(0, 210);
            this.zone08Btn.Name = "zone08Btn";
            this.zone08Btn.Size = new System.Drawing.Size(150, 30);
            this.zone08Btn.TabIndex = 8;
            this.zone08Btn.Text = "UTC+8";
            this.zone08Btn.UseVisualStyleBackColor = false;
            // 
            // zone07Btn
            // 
            this.zone07Btn.BackColor = System.Drawing.SystemColors.Control;
            this.zone07Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.zone07Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zone07Btn.Location = new System.Drawing.Point(0, 180);
            this.zone07Btn.Name = "zone07Btn";
            this.zone07Btn.Size = new System.Drawing.Size(150, 30);
            this.zone07Btn.TabIndex = 7;
            this.zone07Btn.Text = "UTC+7";
            this.zone07Btn.UseVisualStyleBackColor = false;
            // 
            // zone06Btn
            // 
            this.zone06Btn.BackColor = System.Drawing.SystemColors.Control;
            this.zone06Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.zone06Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zone06Btn.Location = new System.Drawing.Point(0, 150);
            this.zone06Btn.Name = "zone06Btn";
            this.zone06Btn.Size = new System.Drawing.Size(150, 30);
            this.zone06Btn.TabIndex = 6;
            this.zone06Btn.Text = "UTC+6";
            this.zone06Btn.UseVisualStyleBackColor = false;
            // 
            // zone05Btn
            // 
            this.zone05Btn.BackColor = System.Drawing.SystemColors.Control;
            this.zone05Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.zone05Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zone05Btn.Location = new System.Drawing.Point(0, 120);
            this.zone05Btn.Name = "zone05Btn";
            this.zone05Btn.Size = new System.Drawing.Size(150, 30);
            this.zone05Btn.TabIndex = 5;
            this.zone05Btn.Text = "UTC+5";
            this.zone05Btn.UseVisualStyleBackColor = false;
            // 
            // zone04Btn
            // 
            this.zone04Btn.BackColor = System.Drawing.SystemColors.Control;
            this.zone04Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.zone04Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zone04Btn.Location = new System.Drawing.Point(0, 90);
            this.zone04Btn.Name = "zone04Btn";
            this.zone04Btn.Size = new System.Drawing.Size(150, 30);
            this.zone04Btn.TabIndex = 4;
            this.zone04Btn.Text = "UTC+4";
            this.zone04Btn.UseVisualStyleBackColor = false;
            // 
            // zone03Btn
            // 
            this.zone03Btn.BackColor = System.Drawing.SystemColors.Control;
            this.zone03Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.zone03Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zone03Btn.Location = new System.Drawing.Point(0, 60);
            this.zone03Btn.Name = "zone03Btn";
            this.zone03Btn.Size = new System.Drawing.Size(150, 30);
            this.zone03Btn.TabIndex = 3;
            this.zone03Btn.Text = "UTC+3";
            this.zone03Btn.UseVisualStyleBackColor = false;
            // 
            // zone02Btn
            // 
            this.zone02Btn.BackColor = System.Drawing.SystemColors.Control;
            this.zone02Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.zone02Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zone02Btn.Location = new System.Drawing.Point(0, 30);
            this.zone02Btn.Name = "zone02Btn";
            this.zone02Btn.Size = new System.Drawing.Size(150, 30);
            this.zone02Btn.TabIndex = 2;
            this.zone02Btn.Text = "UTC+2";
            this.zone02Btn.UseVisualStyleBackColor = false;
            // 
            // zone01Btn
            // 
            this.zone01Btn.BackColor = System.Drawing.SystemColors.Control;
            this.zone01Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.zone01Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zone01Btn.Location = new System.Drawing.Point(0, 0);
            this.zone01Btn.Name = "zone01Btn";
            this.zone01Btn.Size = new System.Drawing.Size(150, 30);
            this.zone01Btn.TabIndex = 1;
            this.zone01Btn.Text = "UTC+1";
            this.zone01Btn.UseVisualStyleBackColor = false;
            // 
            // TimezoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 435);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TimezoneForm";
            this.Text = "TimezoneForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button zoneR11Btn;
        private System.Windows.Forms.Button zoneR10Btn;
        private System.Windows.Forms.Button zoneR09Btn;
        private System.Windows.Forms.Button zoneR08Btn;
        private System.Windows.Forms.Button zoneR07Btn;
        private System.Windows.Forms.Button zoneR06Btn;
        private System.Windows.Forms.Button zoneR05Btn;
        private System.Windows.Forms.Button zoneR04Btn;
        private System.Windows.Forms.Button zoneR03Btn;
        private System.Windows.Forms.Button zoneR02Btn;
        private System.Windows.Forms.Button zoneR01Btn;
        private System.Windows.Forms.Button zone00Btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button zone12Btn;
        private System.Windows.Forms.Button zone11Btn;
        private System.Windows.Forms.Button zone10Btn;
        private System.Windows.Forms.Button zone09Btn;
        private System.Windows.Forms.Button zone08Btn;
        private System.Windows.Forms.Button zone07Btn;
        private System.Windows.Forms.Button zone06Btn;
        private System.Windows.Forms.Button zone05Btn;
        private System.Windows.Forms.Button zone04Btn;
        private System.Windows.Forms.Button zone03Btn;
        private System.Windows.Forms.Button zone02Btn;
        private System.Windows.Forms.Button zone01Btn;
    }
}