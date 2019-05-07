﻿namespace InteractiveSeven.UI.UserControls
{
    partial class MenuColorControlTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botRightColorSwatch = new System.Windows.Forms.Panel();
            this.botLeftColorSwatch = new System.Windows.Forms.Panel();
            this.topRightColorSwatch = new System.Windows.Forms.Panel();
            this.topLeftColorSwatch = new System.Windows.Forms.Panel();
            this.SetColorsButton = new System.Windows.Forms.Button();
            this.bottomRightGroup = new System.Windows.Forms.GroupBox();
            this.botRightColorPicker = new Cyotek.Windows.Forms.ColorEditor();
            this.RefreshColorsButton = new System.Windows.Forms.Button();
            this.botLeftGroup = new System.Windows.Forms.GroupBox();
            this.botLeftColorPicker = new Cyotek.Windows.Forms.ColorEditor();
            this.topRightGroup = new System.Windows.Forms.GroupBox();
            this.topRightColorPicker = new Cyotek.Windows.Forms.ColorEditor();
            this.topLeftGroup = new System.Windows.Forms.GroupBox();
            this.topLeftColorPicker = new Cyotek.Windows.Forms.ColorEditor();
            this.bottomRightGroup.SuspendLayout();
            this.botLeftGroup.SuspendLayout();
            this.topRightGroup.SuspendLayout();
            this.topLeftGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // botRightColorSwatch
            // 
            this.botRightColorSwatch.BackColor = System.Drawing.Color.Black;
            this.botRightColorSwatch.Location = new System.Drawing.Point(230, 236);
            this.botRightColorSwatch.Name = "botRightColorSwatch";
            this.botRightColorSwatch.Size = new System.Drawing.Size(58, 33);
            this.botRightColorSwatch.TabIndex = 26;
            // 
            // botLeftColorSwatch
            // 
            this.botLeftColorSwatch.BackColor = System.Drawing.Color.Black;
            this.botLeftColorSwatch.Location = new System.Drawing.Point(164, 236);
            this.botLeftColorSwatch.Name = "botLeftColorSwatch";
            this.botLeftColorSwatch.Size = new System.Drawing.Size(58, 33);
            this.botLeftColorSwatch.TabIndex = 27;
            // 
            // topRightColorSwatch
            // 
            this.topRightColorSwatch.BackColor = System.Drawing.Color.Black;
            this.topRightColorSwatch.Location = new System.Drawing.Point(230, 197);
            this.topRightColorSwatch.Name = "topRightColorSwatch";
            this.topRightColorSwatch.Size = new System.Drawing.Size(58, 33);
            this.topRightColorSwatch.TabIndex = 28;
            // 
            // topLeftColorSwatch
            // 
            this.topLeftColorSwatch.BackColor = System.Drawing.Color.Black;
            this.topLeftColorSwatch.Location = new System.Drawing.Point(164, 197);
            this.topLeftColorSwatch.Name = "topLeftColorSwatch";
            this.topLeftColorSwatch.Size = new System.Drawing.Size(58, 33);
            this.topLeftColorSwatch.TabIndex = 25;
            // 
            // SetColorsButton
            // 
            this.SetColorsButton.Location = new System.Drawing.Point(248, 481);
            this.SetColorsButton.Name = "SetColorsButton";
            this.SetColorsButton.Size = new System.Drawing.Size(195, 60);
            this.SetColorsButton.TabIndex = 21;
            this.SetColorsButton.Text = "Send to Game";
            this.SetColorsButton.UseVisualStyleBackColor = true;
            this.SetColorsButton.Click += new System.EventHandler(this.SetColorsButton_Click);
            // 
            // bottomRightGroup
            // 
            this.bottomRightGroup.Controls.Add(this.botRightColorPicker);
            this.bottomRightGroup.Location = new System.Drawing.Point(242, 275);
            this.bottomRightGroup.Name = "bottomRightGroup";
            this.bottomRightGroup.Size = new System.Drawing.Size(207, 187);
            this.bottomRightGroup.TabIndex = 24;
            this.bottomRightGroup.TabStop = false;
            this.bottomRightGroup.Text = "Bottom Right";
            // 
            // botRightColorPicker
            // 
            this.botRightColorPicker.Location = new System.Drawing.Point(6, 19);
            this.botRightColorPicker.Name = "botRightColorPicker";
            this.botRightColorPicker.ShowAlphaChannel = false;
            this.botRightColorPicker.ShowColorSpaceLabels = false;
            this.botRightColorPicker.Size = new System.Drawing.Size(191, 168);
            this.botRightColorPicker.TabIndex = 12;
            // 
            // RefreshColorsButton
            // 
            this.RefreshColorsButton.Location = new System.Drawing.Point(9, 481);
            this.RefreshColorsButton.Name = "RefreshColorsButton";
            this.RefreshColorsButton.Size = new System.Drawing.Size(191, 60);
            this.RefreshColorsButton.TabIndex = 20;
            this.RefreshColorsButton.Text = "Pull from Game";
            this.RefreshColorsButton.UseVisualStyleBackColor = true;
            this.RefreshColorsButton.Click += new System.EventHandler(this.RefreshColorsButton_Click);
            // 
            // botLeftGroup
            // 
            this.botLeftGroup.Controls.Add(this.botLeftColorPicker);
            this.botLeftGroup.Location = new System.Drawing.Point(3, 275);
            this.botLeftGroup.Name = "botLeftGroup";
            this.botLeftGroup.Size = new System.Drawing.Size(207, 187);
            this.botLeftGroup.TabIndex = 23;
            this.botLeftGroup.TabStop = false;
            this.botLeftGroup.Text = "Bottom Left";
            // 
            // botLeftColorPicker
            // 
            this.botLeftColorPicker.Location = new System.Drawing.Point(6, 19);
            this.botLeftColorPicker.Name = "botLeftColorPicker";
            this.botLeftColorPicker.ShowAlphaChannel = false;
            this.botLeftColorPicker.ShowColorSpaceLabels = false;
            this.botLeftColorPicker.Size = new System.Drawing.Size(191, 168);
            this.botLeftColorPicker.TabIndex = 12;
            // 
            // topRightGroup
            // 
            this.topRightGroup.Controls.Add(this.topRightColorPicker);
            this.topRightGroup.Location = new System.Drawing.Point(242, 3);
            this.topRightGroup.Name = "topRightGroup";
            this.topRightGroup.Size = new System.Drawing.Size(207, 187);
            this.topRightGroup.TabIndex = 22;
            this.topRightGroup.TabStop = false;
            this.topRightGroup.Text = "Top Right";
            // 
            // topRightColorPicker
            // 
            this.topRightColorPicker.Location = new System.Drawing.Point(6, 19);
            this.topRightColorPicker.Name = "topRightColorPicker";
            this.topRightColorPicker.ShowAlphaChannel = false;
            this.topRightColorPicker.ShowColorSpaceLabels = false;
            this.topRightColorPicker.Size = new System.Drawing.Size(191, 168);
            this.topRightColorPicker.TabIndex = 12;
            // 
            // topLeftGroup
            // 
            this.topLeftGroup.Controls.Add(this.topLeftColorPicker);
            this.topLeftGroup.Location = new System.Drawing.Point(3, 3);
            this.topLeftGroup.Name = "topLeftGroup";
            this.topLeftGroup.Size = new System.Drawing.Size(207, 187);
            this.topLeftGroup.TabIndex = 19;
            this.topLeftGroup.TabStop = false;
            this.topLeftGroup.Text = "Top Left";
            // 
            // topLeftColorPicker
            // 
            this.topLeftColorPicker.Location = new System.Drawing.Point(6, 19);
            this.topLeftColorPicker.Name = "topLeftColorPicker";
            this.topLeftColorPicker.ShowAlphaChannel = false;
            this.topLeftColorPicker.ShowColorSpaceLabels = false;
            this.topLeftColorPicker.Size = new System.Drawing.Size(191, 168);
            this.topLeftColorPicker.TabIndex = 12;
            // 
            // MenuColorControlTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.botRightColorSwatch);
            this.Controls.Add(this.botLeftColorSwatch);
            this.Controls.Add(this.topRightColorSwatch);
            this.Controls.Add(this.topLeftColorSwatch);
            this.Controls.Add(this.SetColorsButton);
            this.Controls.Add(this.bottomRightGroup);
            this.Controls.Add(this.RefreshColorsButton);
            this.Controls.Add(this.botLeftGroup);
            this.Controls.Add(this.topRightGroup);
            this.Controls.Add(this.topLeftGroup);
            this.Name = "MenuColorControlTab";
            this.Size = new System.Drawing.Size(455, 547);
            this.bottomRightGroup.ResumeLayout(false);
            this.botLeftGroup.ResumeLayout(false);
            this.topRightGroup.ResumeLayout(false);
            this.topLeftGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel botRightColorSwatch;
        private System.Windows.Forms.Panel botLeftColorSwatch;
        private System.Windows.Forms.Panel topRightColorSwatch;
        private System.Windows.Forms.Panel topLeftColorSwatch;
        private System.Windows.Forms.Button SetColorsButton;
        private System.Windows.Forms.GroupBox bottomRightGroup;
        private Cyotek.Windows.Forms.ColorEditor botRightColorPicker;
        private System.Windows.Forms.Button RefreshColorsButton;
        private System.Windows.Forms.GroupBox botLeftGroup;
        private Cyotek.Windows.Forms.ColorEditor botLeftColorPicker;
        private System.Windows.Forms.GroupBox topRightGroup;
        private Cyotek.Windows.Forms.ColorEditor topRightColorPicker;
        private System.Windows.Forms.GroupBox topLeftGroup;
        private Cyotek.Windows.Forms.ColorEditor topLeftColorPicker;
    }
}
