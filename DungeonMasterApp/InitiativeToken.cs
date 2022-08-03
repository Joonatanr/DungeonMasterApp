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
        
        public InitiativeToken()
        {
            InitializeComponent();
        }

        private void textBoxInitiative_TextChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void textBoxInitiative_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
