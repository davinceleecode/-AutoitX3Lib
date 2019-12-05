using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;


namespace AutoItLee
{
    /// <summary>
    /// AutoItLeeHelper was initially designed for PC “roll out” situations to reliably automate and configure thousands of PCs. 
    /// </summary>
    public class AutoItLeeHelper : BaseAutoIt
    {
        /// <summary>
        /// passing instance of AutoITLee to base
        /// </summary>
        public AutoItLeeHelper()
            : base(new AutoItX3()) { }


        /// <summary>
        /// Will automate the actual mouse click
        /// </summary>
        /// <param name="clickSide">Option to select Left or Right click</param>
        /// <param name="x">Target the x position</param>
        /// <param name="y">Target the y position</param>
        /// <param name="clickCount">How many mouse click to perform</param>
        /// <param name="speed">Speed of the mouse interaction</param>
        public void MouseClick(CommonEnum.MouseClick clickSide, int x, int y, int clickCount, int speed)
        {
            AI.MouseClick(clickSide.ToString(), x, y, clickCount, speed);
        }

        /// <summary>
        /// a handle to the requested window.
        /// </summary>
        /// <param name="title">The title/hWnd/class of the window to check.</param>
        /// <param name="text">The text of the window to check. Default is an empty string.</param>
        /// <param name="control">Basic control info</param>
        public void ControlFocus(string title, string text = "", string control = "")
        {
            AI.ControlFocus(title, text, control);
        }

        /// <summary>
        /// wait until the target windows control activate
        /// </summary>
        /// <param name="title">The title/hWnd/class of the window to check.</param>
        /// <param name="text">The text of the window to check. Default is an empty string.</param>
        /// <param name="timeout">Timeout in seconds if the window is not active. Default is 0 (no timeout).</param>
        public void WinWaitActive(string title, string text = "", int timeout = 0)
        {
            AI.WinWaitActive(title, text, timeout);
        }

        /// <summary>
        /// Closes a window.
        /// </summary>
        /// <param name="title">The title/hWnd/class of the window to check.</param>
        /// <param name="text">[optional] The text of the window to close. Default is an empty string.</param>
        public void WinClose(string title, string text = "")
        {
            AI.WinClose(title, text);
        }

        /// <summary>
        /// Activates (gives focus to) a window.
        /// </summary>
        /// <param name="title">The title/hWnd/class of the window to activate.</param>
        /// <param name="text">[optional] The text of the window to activate. Default is an empty string.</param>
        public void WinActivate(string title, string text = "")
        {
            AI.WinActivate(title);
        }


        /// <summary>
        /// Sends keystrokes to the active application.
        /// </summary>
        /// <param name="text">The string of keystrokes to send.</param>
        public void Send(string text)
        {
            AI.Send(text);
        }

        /// <summary>
        /// Shows, hides, minimizes, maximizes, or restores a window.
        /// </summary>
        /// <param name="title">The title/hWnd/class of the window to change the state.</param>
        /// <param name="text">The text of the window to change the state.</param>
        /// <param name="flag">The "show" flag of the executed program:
        ///                     @SW_HIDE = Hide window
        ///                     @SW_SHOW = Shows a previously hidden window
        ///                     @SW_MINIMIZE = Minimize window
        ///                     @SW_MAXIMIZE = Maximize window
        ///                     @SW_RESTORE = Undoes a window minimization or maximization
        ///                     @SW_DISABLE = Disables the window
        ///                     @SW_ENABLE = Enables the window</param>
        public void WinSetState(string title, string text, int flag)
        {
            AI.WinSetState(title, text, flag);
        }
    }
}
