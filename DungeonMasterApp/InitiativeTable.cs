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
        private const int yDistance = 1;
        
        public InitiativeTable()
        {
            InitializeComponent();
        }


        public void AddInitiativeToken(InitiativeToken token)
        {
            int yLocation = 0;
            bool isFirst = true;

            /* Check if there are any initiative tokens already added... */
            foreach (Control c in panel1.Controls)
            {
                if (c is InitiativeToken)
                {
                    yLocation = Math.Max(yLocation, (c as InitiativeToken).Bottom);
                    isFirst = false;
                }
            }

            yLocation += yDistance;

            token.Top = yLocation;
            token.Width = panel1.Width;

            token.InitiativeDeleted = new InitiativeToken.InitiativeTokenEvent(HandleTokenRemove);
            token.InitiativeChanged = new InitiativeToken.InitiativeTokenEvent(HandleInitiativeValueChanged);

            if (isFirst)
            {
                token.IsActive = true;
            }

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
            if ((sender as InitiativeToken).IsActive)
            {
                setNextInitiative();
            }
            
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

        private void setNextInitiative()
        {
            List<InitiativeToken> tokens = selectInitiativeTokens();

            /* Lets sort the list based on position. If it's stupid and it works.... */
            List<InitiativeToken> SortedList = tokens.OrderBy(o => o.Top).ToList();

            if (SortedList.Count > 1)
            {
                for (int x = 0; x < SortedList.Count; x++)
                {
                    if (SortedList[x].IsActive)
                    {
                        SortedList[x].IsActive = false;
                        if (x == SortedList.Count - 1)
                        {
                            /* TODO : Add callback here. End of turn. */
                            SortedList[0].IsActive = true;
                        }
                        else
                        {
                            SortedList[x + 1].IsActive = true;
                        }
                        break;
                    }
                }
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            setNextInitiative();
        }

        private void InitiativeTable_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
