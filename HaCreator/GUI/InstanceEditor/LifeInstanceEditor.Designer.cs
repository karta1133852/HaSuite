﻿namespace HaCreator.GUI.InstanceEditor
{
    partial class LifeInstanceEditor
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
            this.components = new System.ComponentModel.Container();
            this.pathLabel = new System.Windows.Forms.Label();
            this.xInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yInput = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rx0Box = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.rx1Box = new System.Windows.Forms.NumericUpDown();
            this.mobTimeBox = new System.Windows.Forms.NumericUpDown();
            this.mobTimeEnable = new System.Windows.Forms.CheckBox();
            this.limitedNameEnable = new System.Windows.Forms.CheckBox();
            this.infoEnable = new System.Windows.Forms.CheckBox();
            this.teamEnable = new System.Windows.Forms.CheckBox();
            this.hideBox = new System.Windows.Forms.CheckBox();
            this.infoBox = new System.Windows.Forms.NumericUpDown();
            this.teamBox = new System.Windows.Forms.NumericUpDown();
            this.limitedNameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.xInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rx0Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rx1Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobTimeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pathLabel
            // 
            // 
            // 
            // 
            this.pathLabel.Location = new System.Drawing.Point(0, 12);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(309, 37);
            this.pathLabel.TabIndex = 0;
            this.pathLabel.Text = "label1";
            this.pathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xInput
            // 
            this.xInput.Location = new System.Drawing.Point(39, 52);
            this.xInput.Name = "xInput";
            this.xInput.Minimum = -2147483648;
            this.xInput.Maximum = 2147483647; 
            this.xInput.Size = new System.Drawing.Size(50, 20);
            this.xInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            // 
            // 
            // 
            this.label1.Location = new System.Drawing.Point(23, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            // 
            // 
            // 
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // yInput
            // 

            this.yInput.Location = new System.Drawing.Point(39, 78);
            this.yInput.Name = "yInput";
            this.yInput.Minimum = -2147483648;
            this.yInput.Maximum = 2147483647; 
            this.yInput.Size = new System.Drawing.Size(50, 20);
            this.yInput.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.Location = new System.Drawing.Point(103, 193);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(76, 28);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.Location = new System.Drawing.Point(185, 193);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(73, 28);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            // 
            // 
            // 
            this.label3.Location = new System.Drawing.Point(14, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "RX0";
            // 
            // rx0Box
            // 
            this.rx0Box.Location = new System.Drawing.Point(38, 104);
            this.rx0Box.Name = "rx0Box";
            this.rx0Box.Minimum = -2147483648;
            this.rx0Box.Maximum = 2147483647; 
            this.rx0Box.Size = new System.Drawing.Size(50, 20);
            this.rx0Box.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            // 
            // 
            // 
            this.label4.Location = new System.Drawing.Point(15, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "RX1";
            // 
            // rx1Box
            // 
            this.rx1Box.Location = new System.Drawing.Point(38, 130);
            this.rx1Box.Name = "rx1Box";
            this.rx1Box.Minimum = -2147483648;
            this.rx1Box.Maximum = 2147483647; 
            this.rx1Box.Size = new System.Drawing.Size(50, 20);
            this.rx1Box.TabIndex = 11;
            // 
            // mobTimeBox
            // 
            this.mobTimeBox.Enabled = false;
            this.mobTimeBox.Location = new System.Drawing.Point(227, 50);
            this.mobTimeBox.Name = "mobTimeBox";
            this.mobTimeBox.Minimum = -2147483648;
            this.mobTimeBox.Maximum = 2147483647; 
            this.mobTimeBox.Size = new System.Drawing.Size(50, 20);
            this.mobTimeBox.TabIndex = 13;
            // 
            // mobTimeEnable
            // 
            this.mobTimeEnable.AutoSize = true;
            // 
            // 
            // 
            this.mobTimeEnable.Location = new System.Drawing.Point(131, 52);
            this.mobTimeEnable.Name = "mobTimeEnable";
            this.mobTimeEnable.Size = new System.Drawing.Size(71, 15);
            this.mobTimeEnable.TabIndex = 15;
            this.mobTimeEnable.Text = "Mob Time";
            this.mobTimeEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBoxCheckChanged);
            // 
            // limitedNameEnable
            // 
            this.limitedNameEnable.AutoSize = true;
            // 
            // 
            // 
            this.limitedNameEnable.Location = new System.Drawing.Point(131, 130);
            this.limitedNameEnable.Name = "limitedNameEnable";
            this.limitedNameEnable.Size = new System.Drawing.Size(90, 15);
            this.limitedNameEnable.TabIndex = 16;
            this.limitedNameEnable.Text = "Limited Name";
            this.limitedNameEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBoxCheckChanged);
            // 
            // infoEnable
            // 
            this.infoEnable.AutoSize = true;
            // 
            // 
            // 
            this.infoEnable.Location = new System.Drawing.Point(131, 79);
            this.infoEnable.Name = "infoEnable";
            this.infoEnable.Size = new System.Drawing.Size(41, 15);
            this.infoEnable.TabIndex = 18;
            this.infoEnable.Text = "Info";
            this.infoEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBoxCheckChanged);
            // 
            // teamEnable
            // 
            this.teamEnable.AutoSize = true;
            // 
            // 
            // 
            this.teamEnable.Location = new System.Drawing.Point(131, 105);
            this.teamEnable.Name = "teamEnable";
            this.teamEnable.Size = new System.Drawing.Size(51, 15);
            this.teamEnable.TabIndex = 19;
            this.teamEnable.Text = "Team";
            this.teamEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBoxCheckChanged);
            // 
            // hideBox
            // 
            this.hideBox.AutoSize = true;
            // 
            // 
            // 
            this.hideBox.Location = new System.Drawing.Point(38, 156);
            this.hideBox.Name = "hideBox";
            this.hideBox.Size = new System.Drawing.Size(45, 15);
            this.hideBox.TabIndex = 20;
            this.hideBox.Text = "Hide";
            // 
            // infoBox
            // 
            this.infoBox.Enabled = false;
            this.infoBox.Location = new System.Drawing.Point(227, 76);
            this.infoBox.Name = "infoBox";
            this.infoBox.Minimum = -2147483648;
            this.infoBox.Maximum = 2147483647; 
            this.infoBox.Size = new System.Drawing.Size(50, 20);
            this.infoBox.TabIndex = 21;
            // 
            // teamBox
            // 
            this.teamBox.Enabled = false;
            this.teamBox.Location = new System.Drawing.Point(227, 102);
            this.teamBox.Name = "teamBox";
            this.teamBox.Minimum = -2147483648;
            this.teamBox.Maximum = 2147483647; 
            this.teamBox.Size = new System.Drawing.Size(50, 20);
            this.teamBox.TabIndex = 22;
            // 
            // limitedNameBox
            // 
            // 
            // 
            // 
            this.limitedNameBox.Enabled = false;
            this.limitedNameBox.Location = new System.Drawing.Point(227, 128);
            this.limitedNameBox.Name = "limitedNameBox";
            this.limitedNameBox.Size = new System.Drawing.Size(63, 20);
            this.limitedNameBox.TabIndex = 24;
            // 
            // LifeInstanceEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 233);
            this.Controls.Add(this.limitedNameBox);
            this.Controls.Add(this.teamBox);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.hideBox);
            this.Controls.Add(this.teamEnable);
            this.Controls.Add(this.infoEnable);
            this.Controls.Add(this.limitedNameEnable);
            this.Controls.Add(this.mobTimeEnable);
            this.Controls.Add(this.mobTimeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rx1Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rx0Box);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xInput);
            this.Controls.Add(this.pathLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LifeInstanceEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.xInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rx0Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rx1Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobTimeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown xInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown yInput;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown rx0Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown rx1Box;
        private System.Windows.Forms.NumericUpDown mobTimeBox;
        private System.Windows.Forms.CheckBox mobTimeEnable;
        private System.Windows.Forms.CheckBox limitedNameEnable;
        private System.Windows.Forms.CheckBox infoEnable;
        private System.Windows.Forms.CheckBox teamEnable;
        private System.Windows.Forms.CheckBox hideBox;
        private System.Windows.Forms.NumericUpDown infoBox;
        private System.Windows.Forms.NumericUpDown teamBox;
        private System.Windows.Forms.TextBox limitedNameBox;
    }
}