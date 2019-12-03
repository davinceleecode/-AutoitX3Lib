using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace AutoItSolution
{
    public partial class AutoIt : Form
    {
        AutoItHelper x = new AutoItHelper();
        public AutoIt()
        {
            InitializeComponent();
        }
         
            
        private void btnMouseClick_Click(object sender, EventArgs e)
        {
            //mouse move and click the specific window coordinates
            x.MouseClick(CommonEnum.MouseClick.LEFT, 35, 21, 2, -1);
        }

        private void btnControlFocus_Click(object sender, EventArgs e)
        {
            //in this example can't focus application if windowstate is minimize
            x.ControlFocus("[Class:Notepad]", "", "Edit1");
        }

        private void btnWaitActiveControl_Click(object sender, EventArgs e)
        {
            //Run notepad
            Process.Start("Notepad");
            
            x.WinWaitActive("Untitled - Notepad");
            
            x.AI.Send("This is some text.");
            Thread.Sleep(2000);
            
            x.WinClose("Untitled - Notepad");

            x.WinWaitActive("Notepad", "Save");

            SendKeys.SendWait("!n");


            #region Another example using WinWaitActive & WinClose
            ////Run notepad
            //Process.Start("Notepad");

            ////Wait 10 seconds for the Notepad window to appear.
            //x.WinWaitActive("[CLASS:Notepad]", "", 10);

            ////Wait for 2 seconds to display the Notepad window.
            //Thread.Sleep(2000);

            ////Close the Notepad window using the classname of Notepad.
            //x.WinClose("[CLASS:Notepad]");
            #endregion
        }
    }
}
