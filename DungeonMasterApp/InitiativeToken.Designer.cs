﻿
namespace DungeonMasterApp
{
    partial class InitiativeToken
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
            this.textBoxTokenName = new System.Windows.Forms.TextBox();
            this.textBoxInitiative = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxTokenName
            // 
            this.textBoxTokenName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTokenName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTokenName.Location = new System.Drawing.Point(3, 3);
            this.textBoxTokenName.Name = "textBoxTokenName";
            this.textBoxTokenName.Size = new System.Drawing.Size(260, 29);
            this.textBoxTokenName.TabIndex = 0;
            // 
            // textBoxInitiative
            // 
            this.textBoxInitiative.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInitiative.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxInitiative.Location = new System.Drawing.Point(269, 3);
            this.textBoxInitiative.Name = "textBoxInitiative";
            this.textBoxInitiative.Size = new System.Drawing.Size(73, 29);
            this.textBoxInitiative.TabIndex = 1;
            this.textBoxInitiative.Text = "0";
            this.textBoxInitiative.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxInitiative.TextChanged += new System.EventHandler(this.textBoxInitiative_TextChanged);
            this.textBoxInitiative.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInitiative_KeyPress);
            // 
            // InitiativeToken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxInitiative);
            this.Controls.Add(this.textBoxTokenName);
            this.Name = "InitiativeToken";
            this.Size = new System.Drawing.Size(345, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTokenName;
        private System.Windows.Forms.TextBox textBoxInitiative;
    }
}
