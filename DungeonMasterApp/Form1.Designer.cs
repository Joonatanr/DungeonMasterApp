
namespace DungeonMasterApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.initiativeToken1 = new DungeonMasterApp.InitiativeToken();
            this.SuspendLayout();
            // 
            // initiativeToken1
            // 
            this.initiativeToken1.Location = new System.Drawing.Point(31, 28);
            this.initiativeToken1.Name = "initiativeToken1";
            this.initiativeToken1.Size = new System.Drawing.Size(345, 36);
            this.initiativeToken1.TabIndex = 0;
            this.initiativeToken1.TokenInitiative = 0;
            this.initiativeToken1.TokenName = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.initiativeToken1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private InitiativeToken initiativeToken1;
    }
}

