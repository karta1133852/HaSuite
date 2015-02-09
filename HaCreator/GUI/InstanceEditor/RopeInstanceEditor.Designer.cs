﻿namespace HaCreator.GUI.InstanceEditor
{
    partial class RopeInstanceEditor
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
            this.pathLabel = new System.Windows.Forms.Label();
            this.xInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yInput = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.ropeBox = new System.Windows.Forms.CheckBox();
            this.ladderBox = new System.Windows.Forms.CheckBox();
            this.ufBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.xInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yInput)).BeginInit();
            this.SuspendLayout();
            // 
            // pathLabel
            // 
            // 
            // 
            // 
            this.pathLabel.Location = new System.Drawing.Point(0, 12);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(179, 16);
            this.pathLabel.TabIndex = 0;
            this.pathLabel.Text = "label1";
            this.pathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xInput
            // 
            this.xInput.Location = new System.Drawing.Point(79, 34);
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
            this.label1.Location = new System.Drawing.Point(63, 37);
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
            this.label2.Location = new System.Drawing.Point(63, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // yInput
            // 
            this.yInput.Location = new System.Drawing.Point(79, 60);
            this.yInput.Name = "yInput";
            this.yInput.Minimum = -2147483648;
            this.yInput.Maximum = 2147483647; 
            this.yInput.Size = new System.Drawing.Size(50, 20);
            this.yInput.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.Location = new System.Drawing.Point(12, 128);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(76, 28);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.Location = new System.Drawing.Point(94, 128);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(73, 28);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ropeBox
            // 
            this.ropeBox.AutoSize = true;
            // 
            // 
            // 
            this.ropeBox.Location = new System.Drawing.Point(39, 86);
            this.ropeBox.Name = "ropeBox";
            this.ropeBox.Size = new System.Drawing.Size(49, 15);
            this.ropeBox.TabIndex = 9;
            this.ropeBox.Text = "Rope";
            // 
            // ladderBox
            // 
            this.ladderBox.AutoSize = true;
            // 
            // 
            // 
            this.ladderBox.Location = new System.Drawing.Point(94, 86);
            this.ladderBox.Name = "ladderBox";
            this.ladderBox.Size = new System.Drawing.Size(57, 15);
            this.ladderBox.TabIndex = 10;
            this.ladderBox.Text = "Ladder";
            // 
            // ufBox
            // 
            this.ufBox.AutoSize = true;
            // 
            // 
            // 
            this.ufBox.Location = new System.Drawing.Point(45, 107);
            this.ufBox.Name = "ufBox";
            this.ufBox.Size = new System.Drawing.Size(98, 15);
            this.ufBox.TabIndex = 11;
            this.ufBox.Text = "Upper Foothold";
            // 
            // RopeInstanceEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 167);
            this.Controls.Add(this.ufBox);
            this.Controls.Add(this.ladderBox);
            this.Controls.Add(this.ropeBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xInput);
            this.Controls.Add(this.pathLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RopeInstanceEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.xInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yInput)).EndInit();
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
        private System.Windows.Forms.CheckBox ropeBox;
        private System.Windows.Forms.CheckBox ladderBox;
        private System.Windows.Forms.CheckBox ufBox;
    }
}