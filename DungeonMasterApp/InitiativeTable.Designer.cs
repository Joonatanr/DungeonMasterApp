
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxInitiativeTokens.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddToken
            // 
            this.buttonAddToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddToken.Location = new System.Drawing.Point(330, 374);
            this.buttonAddToken.Name = "buttonAddToken";
            this.buttonAddToken.Size = new System.Drawing.Size(75, 23);
            this.buttonAddToken.TabIndex = 0;
            this.buttonAddToken.Text = "Add";
            this.buttonAddToken.UseVisualStyleBackColor = true;
            this.buttonAddToken.Click += new System.EventHandler(this.buttonAddToken_Click);
            // 
            // groupBoxInitiativeTokens
            // 
            this.groupBoxInitiativeTokens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInitiativeTokens.Controls.Add(this.panel1);
            this.groupBoxInitiativeTokens.Location = new System.Drawing.Point(3, 3);
            this.groupBoxInitiativeTokens.Name = "groupBoxInitiativeTokens";
            this.groupBoxInitiativeTokens.Size = new System.Drawing.Size(402, 365);
            this.groupBoxInitiativeTokens.TabIndex = 1;
            this.groupBoxInitiativeTokens.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(0, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 346);
            this.panel1.TabIndex = 0;
            // 
            // InitiativeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxInitiativeTokens);
            this.Controls.Add(this.buttonAddToken);
            this.Name = "InitiativeTable";
            this.Size = new System.Drawing.Size(408, 400);
            this.groupBoxInitiativeTokens.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddToken;
        private System.Windows.Forms.GroupBox groupBoxInitiativeTokens;
        private System.Windows.Forms.Panel panel1;
    }
}
