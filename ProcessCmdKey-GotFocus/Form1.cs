using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessCmdKey_GotFocus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    }

    public class CustomButton : Button
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Tab:
                    Debug.WriteLine("MoveFocus(MoveFocusReason.Next)");
                    return false;
                case Keys.Tab | Keys.Shift:
                    Debug.WriteLine("MoveFocus(MoveFocusReason.Previous)");
                    return false;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            Debug.WriteLine("MoveFocus(MoveFocusReason.Programmatic)");
        }

    }
}
