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
using AutoItLee;

namespace AutoItLee
{
    public partial class AutoIt : Form
    {
        private readonly AutoItLeeHelper x;

        public AutoIt()
        {
            InitializeComponent();
            x = new AutoItLeeHelper();
        }


        private void BtnMouseClick_Click(object sender, EventArgs e)
        {
            //mouse move and click the specific window coordinates
            x.MouseClick(CommonEnum.MouseButton.LEFT, 35, 21, 2, -1);
        }

        private void BtnControlFocus_Click(object sender, EventArgs e)
        {
            //in this example can't focus application if windowstate is minimize
            Process.Start("Notepad");
            x.ControlFocus(@"[Title:Untitled - Notepad; Class:Notepad]", "", "Edit1");
            x.WinWaitActive(@"[Title:Untitled - Notepad; Class:Notepad]");
            x.Send("This is some text.");
            x.WinClose("*Untitled - Notepad");

            x.WinWaitActive("Notepad", "Save");

            SendKeys.SendWait("!n");
        }

        private void BtnWaitActiveControl_Click(object sender, EventArgs e)
        {
            //Run notepad
            Process.Start("Notepad");

            x.WinWaitActive("Untitled - Notepad");

            x.Send("This is some text.");


            x.WinClose("*Untitled - Notepad");

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

        private void BtnActivateWindow_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "Calc.exe";
            process.Start();

            x.WinActivate("Calculator");
            Thread.Sleep(3000);
            x.WinClose("Calculator");
        }


    }
}
