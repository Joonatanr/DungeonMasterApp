using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DungeonMasterApp
{
    public partial class InitiativeToken : UserControl
    {
        
        public string TokenName
        {
            get { return textBoxTokenName.Text;     }
            set { textBoxTokenName.Text = value;    }
        }

        private int _myInitiative = 0;

        public int TokenInitiative
        {
            get { return _myInitiative;  }
            set { _myInitiative = value; textBoxInitiative.Text = value.ToString(); }
        }

        public delegate void InitiativeTokenEvent(object sender);

        public InitiativeTokenEvent InitiativeChanged;
        public InitiativeTokenEvent InitiativeDeleted;

        public InitiativeToken()
        {
            InitializeComponent();
        }

        private void textBoxInitiative_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInitiative_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                this.Parent.Focus();
                e.Handled = true;
            }
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            InitiativeDeleted?.Invoke(this);
        }

        private void textBoxInitiative_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxInitiative.Text))
            {
                _myInitiative = 0;
            }
            else
            {
                if (int.TryParse(textBoxInitiative.Text, out _myInitiative) == false)
                {
                    /* Should not happen, but you never know. */
                    MessageBox.Show("Incorrect value entered for initiative");
                    _myInitiative = 0;
                }
            }                  
            
            InitiativeChanged?.Invoke(this);
        }
    }
}
