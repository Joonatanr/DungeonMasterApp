using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DungeonMasterApp
{
    public partial class InitiativeTable : UserControl
    {
        public InitiativeTable()
        {
            InitializeComponent();
        }

        private void buttonAddToken_Click(object sender, EventArgs e)
        {
            InitiativeToken myToken = new InitiativeToken();
            myToken.TokenName = "Unnamed";

            int yLocation = 0;

            /* Check if there are any initiative tokens already added... */
            foreach (Control c in groupBoxInitiativeTokens.Controls)
            {
                if (c is InitiativeToken)
                {
                    yLocation = Math.Max(yLocation, (c as InitiativeToken).Bottom);
                }
            }

            yLocation += 3;

            myToken.Top = yLocation;
            this.groupBoxInitiativeTokens.Controls.Add(myToken);
        }
    }
}
