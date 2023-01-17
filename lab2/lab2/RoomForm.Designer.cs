﻿namespace lab2
{
    partial class RoomForm
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
            this.labelRoomName = new System.Windows.Forms.Label();
            this.textBoxRoomName = new System.Windows.Forms.TextBox();
            this.labelAmountWindows = new System.Windows.Forms.Label();
            this.numericUpDownAmountWindows = new System.Windows.Forms.NumericUpDown();
            this.radioButtonNorth = new System.Windows.Forms.RadioButton();
            this.labelWindowsSide = new System.Windows.Forms.Label();
            this.radioButtonSouth = new System.Windows.Forms.RadioButton();
            this.radioButtonWest = new System.Windows.Forms.RadioButton();
            this.radioButtonEast = new System.Windows.Forms.RadioButton();
            this.labelRoomFootage = new System.Windows.Forms.Label();
            this.trackBarRoomFootage = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSaveInfo = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelRoomFootageValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountWindows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRoomFootage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRoomName
            // 
            this.labelRoomName.AutoSize = true;
            this.labelRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelRoomName.Location = new System.Drawing.Point(92, 33);
            this.labelRoomName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRoomName.Name = "labelRoomName";
            this.labelRoomName.Size = new System.Drawing.Size(174, 20);
            this.labelRoomName.TabIndex = 0;
            this.labelRoomName.Text = "Название комнаты:";
            // 
            // textBoxRoomName
            // 
            this.textBoxRoomName.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxRoomName.Location = new System.Drawing.Point(23, 55);
            this.textBoxRoomName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRoomName.Name = "textBoxRoomName";
            this.textBoxRoomName.Size = new System.Drawing.Size(310, 25);
            this.textBoxRoomName.TabIndex = 1;
            this.textBoxRoomName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // labelAmountWindows
            // 
            this.labelAmountWindows.AutoSize = true;
            this.labelAmountWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelAmountWindows.Location = new System.Drawing.Point(190, 101);
            this.labelAmountWindows.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAmountWindows.Name = "labelAmountWindows";
            this.labelAmountWindows.Size = new System.Drawing.Size(143, 20);
            this.labelAmountWindows.TabIndex = 2;
            this.labelAmountWindows.Text = "Количество окон:";
            // 
            // numericUpDownAmountWindows
            // 
            this.numericUpDownAmountWindows.BackColor = System.Drawing.Color.LightYellow;
            this.numericUpDownAmountWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDownAmountWindows.Location = new System.Drawing.Point(194, 123);
            this.numericUpDownAmountWindows.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownAmountWindows.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownAmountWindows.Name = "numericUpDownAmountWindows";
            this.numericUpDownAmountWindows.Size = new System.Drawing.Size(62, 25);
            this.numericUpDownAmountWindows.TabIndex = 3;
            // 
            // radioButtonNorth
            // 
            this.radioButtonNorth.AutoSize = true;
            this.radioButtonNorth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonNorth.Location = new System.Drawing.Point(23, 233);
            this.radioButtonNorth.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNorth.Name = "radioButtonNorth";
            this.radioButtonNorth.Size = new System.Drawing.Size(74, 24);
            this.radioButtonNorth.TabIndex = 0;
            this.radioButtonNorth.TabStop = true;
            this.radioButtonNorth.Text = "Север";
            this.radioButtonNorth.UseVisualStyleBackColor = true;
            // 
            // labelWindowsSide
            // 
            this.labelWindowsSide.AutoSize = true;
            this.labelWindowsSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelWindowsSide.Location = new System.Drawing.Point(19, 201);
            this.labelWindowsSide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWindowsSide.Name = "labelWindowsSide";
            this.labelWindowsSide.Size = new System.Drawing.Size(192, 20);
            this.labelWindowsSide.TabIndex = 5;
            this.labelWindowsSide.Text = "Выберите сторону окон:";
            // 
            // radioButtonSouth
            // 
            this.radioButtonSouth.AutoSize = true;
            this.radioButtonSouth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonSouth.Location = new System.Drawing.Point(23, 261);
            this.radioButtonSouth.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonSouth.Name = "radioButtonSouth";
            this.radioButtonSouth.Size = new System.Drawing.Size(48, 24);
            this.radioButtonSouth.TabIndex = 1;
            this.radioButtonSouth.TabStop = true;
            this.radioButtonSouth.Text = "Юг";
            this.radioButtonSouth.UseVisualStyleBackColor = true;
            // 
            // radioButtonWest
            // 
            this.radioButtonWest.AutoSize = true;
            this.radioButtonWest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonWest.Location = new System.Drawing.Point(23, 289);
            this.radioButtonWest.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonWest.Name = "radioButtonWest";
            this.radioButtonWest.Size = new System.Drawing.Size(76, 24);
            this.radioButtonWest.TabIndex = 2;
            this.radioButtonWest.TabStop = true;
            this.radioButtonWest.Text = "Запад";
            this.radioButtonWest.UseVisualStyleBackColor = true;
            // 
            // radioButtonEast
            // 
            this.radioButtonEast.AutoSize = true;
            this.radioButtonEast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonEast.Location = new System.Drawing.Point(23, 317);
            this.radioButtonEast.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonEast.Name = "radioButtonEast";
            this.radioButtonEast.Size = new System.Drawing.Size(81, 24);
            this.radioButtonEast.TabIndex = 3;
            this.radioButtonEast.TabStop = true;
            this.radioButtonEast.Text = "Восток";
            this.radioButtonEast.UseVisualStyleBackColor = true;
            // 
            // labelRoomFootage
            // 
            this.labelRoomFootage.AutoSize = true;
            this.labelRoomFootage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelRoomFootage.Location = new System.Drawing.Point(19, 101);
            this.labelRoomFootage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRoomFootage.Name = "labelRoomFootage";
            this.labelRoomFootage.Size = new System.Drawing.Size(143, 20);
            this.labelRoomFootage.TabIndex = 6;
            this.labelRoomFootage.Text = "Метраж комнаты:";
            // 
            // trackBarRoomFootage
            // 
            this.trackBarRoomFootage.BackColor = System.Drawing.Color.LightGray;
            this.trackBarRoomFootage.Location = new System.Drawing.Point(23, 123);
            this.trackBarRoomFootage.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarRoomFootage.Maximum = 30;
            this.trackBarRoomFootage.Name = "trackBarRoomFootage";
            this.trackBarRoomFootage.Size = new System.Drawing.Size(153, 50);
            this.trackBarRoomFootage.TabIndex = 7;
            this.trackBarRoomFootage.TickFrequency = 5;
            this.trackBarRoomFootage.Scroll += new System.EventHandler(this.trackBarRoomFootage_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(33, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(135, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "30";
            // 
            // buttonSaveInfo
            // 
            this.buttonSaveInfo.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonSaveInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSaveInfo.Location = new System.Drawing.Point(23, 376);
            this.buttonSaveInfo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSaveInfo.Name = "buttonSaveInfo";
            this.buttonSaveInfo.Size = new System.Drawing.Size(139, 48);
            this.buttonSaveInfo.TabIndex = 11;
            this.buttonSaveInfo.Text = "Сохранить";
            this.buttonSaveInfo.UseVisualStyleBackColor = false;
            this.buttonSaveInfo.Click += new System.EventHandler(this.buttonSaveInfo_Click);
            this.buttonSaveInfo.MouseEnter += new System.EventHandler(this.buttonSaveInfo_MouseEnter);
            this.buttonSaveInfo.MouseLeave += new System.EventHandler(this.buttonSaveInfo_MouseLeave);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Brown;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonExit.Location = new System.Drawing.Point(194, 376);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(139, 48);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Закрыть";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.MouseEnter += new System.EventHandler(this.buttonExit_MouseEnter);
            this.buttonExit.MouseLeave += new System.EventHandler(this.buttonExit_MouseLeave);
            // 
            // labelRoomFootageValue
            // 
            this.labelRoomFootageValue.AutoSize = true;
            this.labelRoomFootageValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelRoomFootageValue.Location = new System.Drawing.Point(215, 88);
            this.labelRoomFootageValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRoomFootageValue.Name = "labelRoomFootageValue";
            this.labelRoomFootageValue.Size = new System.Drawing.Size(0, 20);
            this.labelRoomFootageValue.TabIndex = 13;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(351, 492);
            this.Controls.Add(this.radioButtonEast);
            this.Controls.Add(this.radioButtonNorth);
            this.Controls.Add(this.radioButtonWest);
            this.Controls.Add(this.radioButtonSouth);
            this.Controls.Add(this.labelRoomFootageValue);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSaveInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarRoomFootage);
            this.Controls.Add(this.labelRoomFootage);
            this.Controls.Add(this.labelWindowsSide);
            this.Controls.Add(this.numericUpDownAmountWindows);
            this.Controls.Add(this.labelAmountWindows);
            this.Controls.Add(this.textBoxRoomName);
            this.Controls.Add(this.labelRoomName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(369, 536);
            this.MinimumSize = new System.Drawing.Size(369, 536);
            this.Name = "RoomForm";
            this.Text = "Информация о комнатах";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountWindows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRoomFootage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRoomName;
        private System.Windows.Forms.TextBox textBoxRoomName;
        private System.Windows.Forms.Label labelAmountWindows;
        private System.Windows.Forms.NumericUpDown numericUpDownAmountWindows;
        private System.Windows.Forms.RadioButton radioButtonEast;
        private System.Windows.Forms.RadioButton radioButtonWest;
        private System.Windows.Forms.RadioButton radioButtonSouth;
        private System.Windows.Forms.RadioButton radioButtonNorth;
        private System.Windows.Forms.Label labelWindowsSide;
        private System.Windows.Forms.Label labelRoomFootage;
        private System.Windows.Forms.TrackBar trackBarRoomFootage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSaveInfo;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelRoomFootageValue;
    }
}