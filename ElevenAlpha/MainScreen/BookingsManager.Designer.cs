﻿namespace ElevenAlpha
{
    partial class BookingsManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MemberIdLabel = new System.Windows.Forms.Label();
            this.MemberIdTextBox = new System.Windows.Forms.TextBox();
            this.ShowMemberLookupButton = new System.Windows.Forms.Button();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.BookingDateLabel = new System.Windows.Forms.Label();
            this.BookingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FacilityTypeLabel = new System.Windows.Forms.Label();
            this.FacilityTypeComboBox = new System.Windows.Forms.ComboBox();
            this.BookButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.PreviousDayButton = new System.Windows.Forms.Button();
            this.NextDayButton = new System.Windows.Forms.Button();
            this.BookingManagerDataGrid = new System.Windows.Forms.DataGridView();
            this.BookButton1 = new System.Windows.Forms.Button();
            this.CloseButton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookingManagerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MemberIdLabel
            // 
            this.MemberIdLabel.AutoSize = true;
            this.MemberIdLabel.Location = new System.Drawing.Point(94, 39);
            this.MemberIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MemberIdLabel.Name = "MemberIdLabel";
            this.MemberIdLabel.Size = new System.Drawing.Size(152, 32);
            this.MemberIdLabel.TabIndex = 1;
            this.MemberIdLabel.Text = "Member ID";
            // 
            // MemberIdTextBox
            // 
            this.MemberIdTextBox.Location = new System.Drawing.Point(295, 36);
            this.MemberIdTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MemberIdTextBox.Name = "MemberIdTextBox";
            this.MemberIdTextBox.Size = new System.Drawing.Size(159, 38);
            this.MemberIdTextBox.TabIndex = 2;
            this.MemberIdTextBox.TextChanged += new System.EventHandler(this.MemberIdTextBox_TextChanged);
            // 
            // ShowMemberLookupButton
            // 
            this.ShowMemberLookupButton.Location = new System.Drawing.Point(460, 36);
            this.ShowMemberLookupButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ShowMemberLookupButton.Name = "ShowMemberLookupButton";
            this.ShowMemberLookupButton.Size = new System.Drawing.Size(50, 39);
            this.ShowMemberLookupButton.TabIndex = 3;
            this.ShowMemberLookupButton.Text = "...";
            this.ShowMemberLookupButton.UseVisualStyleBackColor = true;
            this.ShowMemberLookupButton.Click += new System.EventHandler(this.ShowMemberLookupButton_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FirstNameTextBox.Location = new System.Drawing.Point(584, 36);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.ReadOnly = true;
            this.FirstNameTextBox.Size = new System.Drawing.Size(255, 38);
            this.FirstNameTextBox.TabIndex = 4;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameTextBox.Location = new System.Drawing.Point(845, 36);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.ReadOnly = true;
            this.LastNameTextBox.Size = new System.Drawing.Size(255, 38);
            this.LastNameTextBox.TabIndex = 5;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // BookingDateLabel
            // 
            this.BookingDateLabel.AutoSize = true;
            this.BookingDateLabel.Location = new System.Drawing.Point(94, 87);
            this.BookingDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookingDateLabel.Name = "BookingDateLabel";
            this.BookingDateLabel.Size = new System.Drawing.Size(186, 32);
            this.BookingDateLabel.TabIndex = 6;
            this.BookingDateLabel.Text = "Booking Date";
            // 
            // BookingDateTimePicker
            // 
            this.BookingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BookingDateTimePicker.Location = new System.Drawing.Point(295, 81);
            this.BookingDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BookingDateTimePicker.MinDate = new System.DateTime(2018, 3, 26, 0, 0, 0, 0);
            this.BookingDateTimePicker.Name = "BookingDateTimePicker";
            this.BookingDateTimePicker.Size = new System.Drawing.Size(214, 38);
            this.BookingDateTimePicker.TabIndex = 7;
            this.BookingDateTimePicker.ValueChanged += new System.EventHandler(this.BookingDateTimePicker_ValueChanged);
            // 
            // FacilityTypeLabel
            // 
            this.FacilityTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FacilityTypeLabel.AutoSize = true;
            this.FacilityTypeLabel.Location = new System.Drawing.Point(664, 85);
            this.FacilityTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FacilityTypeLabel.Name = "FacilityTypeLabel";
            this.FacilityTypeLabel.Size = new System.Drawing.Size(175, 32);
            this.FacilityTypeLabel.TabIndex = 8;
            this.FacilityTypeLabel.Text = "Facility Type";
            // 
            // FacilityTypeComboBox
            // 
            this.FacilityTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FacilityTypeComboBox.FormattingEnabled = true;
            this.FacilityTypeComboBox.Location = new System.Drawing.Point(845, 84);
            this.FacilityTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FacilityTypeComboBox.Name = "FacilityTypeComboBox";
            this.FacilityTypeComboBox.Size = new System.Drawing.Size(255, 39);
            this.FacilityTypeComboBox.TabIndex = 9;
            this.FacilityTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.FacilityTypeComboBox_SelectedIndexChanged);
            // 
            // BookButton
            // 
            this.BookButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BookButton.Location = new System.Drawing.Point(477, 1245);
            this.BookButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(128, 46);
            this.BookButton.TabIndex = 10;
            this.BookButton.Text = "Book";
            this.BookButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(612, 1245);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(128, 46);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // PreviousDayButton
            // 
            this.PreviousDayButton.Location = new System.Drawing.Point(516, 84);
            this.PreviousDayButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PreviousDayButton.Name = "PreviousDayButton";
            this.PreviousDayButton.Size = new System.Drawing.Size(50, 39);
            this.PreviousDayButton.TabIndex = 12;
            this.PreviousDayButton.Text = "<";
            this.PreviousDayButton.UseVisualStyleBackColor = true;
            this.PreviousDayButton.Click += new System.EventHandler(this.PreviousDayButton_Click);
            // 
            // NextDayButton
            // 
            this.NextDayButton.Location = new System.Drawing.Point(571, 84);
            this.NextDayButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NextDayButton.Name = "NextDayButton";
            this.NextDayButton.Size = new System.Drawing.Size(50, 39);
            this.NextDayButton.TabIndex = 13;
            this.NextDayButton.Text = ">";
            this.NextDayButton.UseVisualStyleBackColor = true;
            this.NextDayButton.Click += new System.EventHandler(this.NextDayButton_Click);
            // 
            // BookingManagerDataGrid
            // 
            this.BookingManagerDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BookingManagerDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BookingManagerDataGrid.ColumnHeadersHeight = 80;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BookingManagerDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.BookingManagerDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookingManagerDataGrid.Location = new System.Drawing.Point(100, 150);
            this.BookingManagerDataGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BookingManagerDataGrid.MultiSelect = false;
            this.BookingManagerDataGrid.Name = "BookingManagerDataGrid";
            this.BookingManagerDataGrid.ReadOnly = true;
            this.BookingManagerDataGrid.RowHeadersWidth = 250;
            this.BookingManagerDataGrid.RowTemplate.Height = 80;
            this.BookingManagerDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.BookingManagerDataGrid.Size = new System.Drawing.Size(1004, 692);
            this.BookingManagerDataGrid.TabIndex = 0;
            this.BookingManagerDataGrid.DoubleClick += new System.EventHandler(this.BookingManagerDataGrid_DoubleClick);
            // 
            // BookButton1
            // 
            this.BookButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BookButton1.Location = new System.Drawing.Point(386, 890);
            this.BookButton1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BookButton1.Name = "BookButton1";
            this.BookButton1.Size = new System.Drawing.Size(188, 46);
            this.BookButton1.TabIndex = 14;
            this.BookButton1.Text = "Book";
            this.BookButton1.UseVisualStyleBackColor = true;
            this.BookButton1.Click += new System.EventHandler(this.BookButton1_Click);
            // 
            // CloseButton1
            // 
            this.CloseButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CloseButton1.Location = new System.Drawing.Point(585, 890);
            this.CloseButton1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CloseButton1.Name = "CloseButton1";
            this.CloseButton1.Size = new System.Drawing.Size(188, 46);
            this.CloseButton1.TabIndex = 15;
            this.CloseButton1.Text = "Close";
            this.CloseButton1.UseVisualStyleBackColor = true;
            this.CloseButton1.Click += new System.EventHandler(this.CloseButton1_Click);
            // 
            // BookingsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(1204, 992);
            this.Controls.Add(this.CloseButton1);
            this.Controls.Add(this.BookButton1);
            this.Controls.Add(this.NextDayButton);
            this.Controls.Add(this.PreviousDayButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.BookButton);
            this.Controls.Add(this.FacilityTypeComboBox);
            this.Controls.Add(this.FacilityTypeLabel);
            this.Controls.Add(this.BookingDateTimePicker);
            this.Controls.Add(this.BookingDateLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.ShowMemberLookupButton);
            this.Controls.Add(this.MemberIdTextBox);
            this.Controls.Add(this.MemberIdLabel);
            this.Controls.Add(this.BookingManagerDataGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BookingsManager";
            this.Padding = new System.Windows.Forms.Padding(100, 150, 100, 150);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking Manager";
            ((System.ComponentModel.ISupportInitialize)(this.BookingManagerDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MemberIdLabel;
        private System.Windows.Forms.Button ShowMemberLookupButton;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label BookingDateLabel;
        private System.Windows.Forms.DateTimePicker BookingDateTimePicker;
        private System.Windows.Forms.Label FacilityTypeLabel;
        private System.Windows.Forms.ComboBox FacilityTypeComboBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Button BookButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button PreviousDayButton;
        private System.Windows.Forms.Button NextDayButton;
        public System.Windows.Forms.TextBox MemberIdTextBox;
        public System.Windows.Forms.DataGridView BookingManagerDataGrid;
        private System.Windows.Forms.Button BookButton1;
        private System.Windows.Forms.Button CloseButton1;
    }
}