
namespace DungeonMasterApp
{
    partial class InitiativeTable
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
            this.buttonAddToken = new System.Windows.Forms.Button();
            this.groupBoxInitiativeTokens = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // buttonAddToken
            // 
            this.buttonAddToken.Location = new System.Drawing.Point(272, 363);
            this.buttonAddToken.Name = "buttonAddToken";
            this.buttonAddToken.Size = new System.Drawing.Size(75, 23);
            this.buttonAddToken.TabIndex = 0;
            this.buttonAddToken.Text = "Add";
            this.buttonAddToken.UseVisualStyleBackColor = true;
            this.buttonAddToken.Click += new System.EventHandler(this.buttonAddToken_Click);
            // 
            // groupBoxInitiativeTokens
            // 
            this.groupBoxInitiativeTokens.Location = new System.Drawing.Point(3, 3);
            this.groupBoxInitiativeTokens.Name = "groupBoxInitiativeTokens";
            this.groupBoxInitiativeTokens.Size = new System.Drawing.Size(344, 354);
            this.groupBoxInitiativeTokens.TabIndex = 1;
            this.groupBoxInitiativeTokens.TabStop = false;
            // 
            // InitiativeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxInitiativeTokens);
            this.Controls.Add(this.buttonAddToken);
            this.Name = "InitiativeTable";
            this.Size = new System.Drawing.Size(350, 389);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddToken;
        private System.Windows.Forms.GroupBox groupBoxInitiativeTokens;
    }
}
