using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;


namespace AutoItSolution
{
    public class AutoItHelper : BaseAutoIt
    {

        public AutoItHelper()
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

        public void Send(string text)
        {
            AI.Send(text);
        }
    }
}
