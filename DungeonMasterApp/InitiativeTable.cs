using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DungeonMasterApp
{
    public partial class InitiativeTable : UserControl
    {
        private const int yDistance = 3;
        
        public InitiativeTable()
        {
            InitializeComponent();
        }


        public void AddInitiativeToken(InitiativeToken token)
        {
            int yLocation = 0;

            /* Check if there are any initiative tokens already added... */
            foreach (Control c in panel1.Controls)
            {
                if (c is InitiativeToken)
                {
                    yLocation = Math.Max(yLocation, (c as InitiativeToken).Bottom);
                }
            }

            yLocation += yDistance;

            token.Top = yLocation;
            token.InitiativeDeleted = new InitiativeToken.InitiativeTokenEvent(HandleTokenRemove);
            token.InitiativeChanged = new InitiativeToken.InitiativeTokenEvent(HandleInitiativeValueChanged);
            this.panel1.Controls.Add(token);
        }

        private void buttonAddToken_Click(object sender, EventArgs e)
        {
            InitiativeToken myToken = new InitiativeToken();
            myToken.TokenName = "Unnamed";
            AddInitiativeToken(myToken);


        }

        private void HandleTokenRemove(object sender)
        {
            this.panel1.Controls.Remove(sender as Control);
            resetOrderOfInitiative();
        }

        private void HandleInitiativeValueChanged(object sender)
        {
            resetOrderOfInitiative();
        }

        private void resetOrderOfInitiative()
        {
            List<InitiativeToken> myControls = selectInitiativeTokens();
            if (myControls.Count > 0)
            {
                /* Lets sort the list based on initiative */
                List<InitiativeToken> SortedList = myControls.OrderByDescending(o => o.TokenInitiative).ToList();

                int yPos = yDistance;

                foreach (InitiativeToken t in SortedList)
                {
                    t.Top = yPos;
                    yPos = t.Bottom + yDistance;
                }
            }
        }

        private List<InitiativeToken> selectInitiativeTokens()
        {
            List<InitiativeToken> res = new List<InitiativeToken>();

            foreach (Control c in panel1.Controls)
            {
                if (c is InitiativeToken)
                {
                    res.Add((InitiativeToken)c);
                }
            }

            return res;
        }
    }
}
