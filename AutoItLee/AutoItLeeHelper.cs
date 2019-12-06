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
        /// <param name="mouseButton">Option to select Left or Right click</param>
        /// <param name="x">Target the x position</param>
        /// <param name="y">Target the y position</param>
        /// <param name="clickCount">How many mouse click to perform</param>
        /// <param name="speed">Speed of the mouse interaction</param>
        public int MouseClick(CommonEnum.MouseButton mouseButton, int x, int y, int clickCount, int speed)
        {
            return AI.MouseClick(mouseButton.ToString(), x, y, clickCount, speed);
        }

        /// <summary>
        /// a handle to the requested window.
        /// </summary>
        /// <param name="title">The title/hWnd/class of the window to check.</param>
        /// <param name="text">The text of the window to check. Default is an empty string.</param>
        /// <param name="control">Basic control info</param>
        public int ControlFocus(string title, string text = "", string control = "")
        {
            return AI.ControlFocus(title, text, control);
        }

        /// <summary>
        /// wait until the target windows control activate
        /// </summary>
        /// <param name="title">The title/hWnd/class of the window to check.</param>
        /// <param name="text">The text of the window to check. Default is an empty string.</param>
        /// <param name="timeout">Timeout in seconds if the window is not active. Default is 0 (no timeout).</param>
        public int WinWaitActive(string title, string text = "", int timeout = 0)
        {
            return AI.WinWaitActive(title, text, timeout);
        }

        /// <summary>
        /// Closes a window.
        /// </summary>
        /// <param name="title">The title/hWnd/class of the window to check.</param>
        /// <param name="text">[optional] The text of the window to close. Default is an empty string.</param>
        public int WinClose(string title, string text = "")
        {
            return AI.WinClose(title, text);
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
        /// Sends simulated keystrokes to the active window.
        /// </summary>
        /// <param name="text">The sequence of keys to send.</param>
        /// <param name="mode">[optional] Changes how "keys" is processed:
        ///$SEND_DEFAULT(0) = Text contains special characters like + and ! to indicate SHIFT and ALT key-presses(default).
        ///$SEND_RAW(1) = keys are sent raw.</param>
        public void Send(string text, int mode = 0)
        {
            AI.Send(text, mode);
        }

        /// <summary>
        /// Shows, hides, minimizes, maximizes, or restores a window.
        /// </summary>
        /// <param name="title">The title/hWnd/class of the window to change the state.</param>
        /// <param name="text">The text of the window to change the state.</param>
        /// <param name="flag">The "show" flag of the executed program: <br/>
        ///@SW_HIDE = Hide window <br/>
        ///@SW_SHOW = Shows a previously hidden window <br/>
        ///@SW_MINIMIZE = Minimize window <br/>
        ///@SW_MAXIMIZE = Maximize window <br/>
        ///@SW_RESTORE = Undoes a window minimization or maximization <br/>
        ///@SW_DISABLE = Disables the window <br/>
        ///@SW_ENABLE = Enables the window</param> 
        public int WinSetState(string title, string text, int flag)
        {
            return AI.WinSetState(title, text, flag);
        }

        /// <summary>
        /// Changes the operation of various AutoIt functions/parameters.
        /// </summary>
        /// <param name="strOption">The option to change. </param>
        /// <param name="nValue">
        /// [optional] The value to assign to the option. The type and meaning vary by option. <br/>
        /// See remarks below. If the param is not provided, \n then the function just returns the value already assigned to the option. <br/>
        /// The keyword Default can be used for the parameter to reset the option to its default value.<br/></param>
        /// <returns>
        ///Success:	the value of the previous setting for the option.
        ///Failure:	sets the @error flag to non-zero. Failure will occur if the parameters are invalid (such as an option that does not exist).</returns>
        public int AutoItSetOption(string strOption, int nValue)
        {
            return AI.AutoItSetOption(strOption, nValue);
        }

        /// <summary>
        /// Retrieves text from the clipboard.
        /// </summary>
        /// <returns>Success: a string containing the text on the clipboard. <br/>
        /// Failure:	sets the @error to non-zero. <br/>
        /// @error:	1 = if clipboard is empty <br/>
        /// 2 = if contains a non-text entry. <br/>
        /// 3 or 4 = if cannot access the clipboard.
        /// </returns>
        public string ClipGet()
        {
            return AI.ClipGet();
        }

        /// <summary>
        /// Writes text to the clipboard.
        /// </summary>
        /// <param name="strClip">The text to write to the clipboard.</param>
        public void ClipPut(string strClip)
        {
            AI.ClipPut(strClip);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strTitle">The title/hWnd/class of the window to access.</param>
        /// <param name="strText">The text of the window to access. </param>
        /// <param name="strControl">The control to interact with.</param>
        /// <param name="enumButton">[optional] The button to click, "left", "right", "middle", "main", "menu", "primary", "secondary". Default is the left button.</param>
        /// <param name="nNumClicks">[optional] The number of times to click the mouse. Default is 1.</param>
        /// <param name="nX">[optional] The x position to click within the control. Default is center.</param>
        /// <param name="nY">[optional] The y position to click within the control. Default is center.</param>
        /// <returns></returns>
        public int ControlClick(string strTitle, string strText, string strControl, CommonEnum.MouseButton enumButton = CommonEnum.MouseButton.LEFT, int nNumClicks = 1, int nX = -2147483647, int nY = -2147483647)
        {
            return AI.ControlClick(strTitle, strText, strControl, enumButton.ToString(), nNumClicks, nX, nY);
        }

        /// <summary>
        /// Sends a command to a control.
        /// </summary>
        /// <param name="strTitle">The title/hWnd/class of the window to access.</param>
        /// <param name="strText">The text of the window to access.</param>
        /// <param name="strControl">The control to interact with.</param>
        /// <param name="strCommand">The command to send to the control.</param>
        /// <param name="strExtra">[optional] Additional parameter required by some commands.</param>
        /// <returns></returns>
        public string ControlCommand(string strTitle, string strText, string strControl, string strCommand, string strExtra)
        {
            return AI.ControlCommand(strTitle, strText, strControl, strCommand, strExtra);
        }

        /// <summary>
        /// Disables or "grays-out" a control.
        /// </summary>
        /// <param name="strTitle">The title/hWnd/class of the window to access. </param>
        /// <param name="strText">The text of the window to access.</param>
        /// <param name="strControl">The control to interact with.</param>
        /// <returns>
        /// Success:	1. <br/>
        /// Failure:	0.
        /// </returns>
        public int ControlDisable(string strTitle, string strText, string strControl)
        {
            return AI.ControlDisable(strTitle, strText, strControl);
        }

        /// <summary>
        /// Enables a "grayed-out" control.
        /// </summary>
        /// <param name="strTitle">The title/hWnd/class of the window to access. </param>
        /// <param name="strText">The text of the window to access.</param>
        /// <param name="strControl">The control to interact with. </param>
        /// <returns>
        /// Success:	1. <br/>
        /// Failure:	0.
        /// </returns>
        public int ControlEnable(string strTitle, string strText, string strControl)
        {
            return AI.ControlEnable(strTitle, strText, strControl);
        }

        /// <summary>
        /// Returns the ControlRef# of the control that has keyboard focus within a specified window.
        /// </summary>
        /// <param name="strTitle">The title/hWnd/class of the window to access. </param>
        /// <param name="strText">[optional] The text of the window to access. </param>
        /// <returns>
        ///Success:	the ClassNameNN of the control that has keyboard focus within a specified window. <br/>
        ///Failure:	"" (empty string) and sets the @error flag to 1 if window is not found.
        /// </returns>
        public string ControlGetFocus(string strTitle, string strText = "")
        {
            return AI.ControlGetFocus(strTitle, strText);
        }

        /// <summary>
        /// Retrieves the internal handle of a control.
        /// </summary>
        /// <param name="strTitle">The title/hWnd/class of the window to access. </param>
        /// <param name="strText">The text of the window to access. </param>
        /// <param name="strControl">The control to interact with. </param>
        /// <returns>
        /// Success:	the handle (HWND) value. <br/>
        /// Failure:	0 and sets the @error flag to non-zero if no window matches the criteria.
        /// </returns>
        public string ControlGetHandle(string strTitle, string strText, string strControl)
        {
            return AI.ControlGetHandle(strTitle, strText, strControl);
        }

        /// <summary>
        /// Retrieves the position and size of a control relative to it's window
        /// </summary>
        /// <param name="strTitle">The title of the window to access.</param>
        /// <param name="strText">The text of the window to access.</param>
        /// <param name="strControl">The control to interact with. </param>
        /// <returns>
        /// Success:	Returns the X coordinate of the control. <br/>
        /// Failure:	Sets oAutoIt.error to 1.
        /// </returns>
        public int ControlGetPosX(string strTitle, string strText, string strControl)
        {
            return AI.ControlGetPosX(strTitle, strText, strControl);
        }

        /// <summary>
        /// Retrieves the position and size of a control relative to it's window
        /// </summary>
        /// <param name="strTitle">The title of the window to access.</param>
        /// <param name="strText">The text of the window to access.</param>
        /// <param name="strControl">The control to interact with. </param>
        /// <returns>
        /// Success:	Returns the Y coordinate of the control. <br/>
        /// Failure:	Sets oAutoIt.error to 1.
        /// </returns>
        public int ControlGetPosY(string strTitle, string strText, string strControl)
        {
            return AI.ControlGetPosY(strTitle, strText, strControl);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strTitle"></param>
        /// <param name="strText"></param>
        /// <param name="strControl"></param>
        /// <returns></returns>
        public int ControlGetPosHeight(string strTitle, string strText, string strControl)
        {
            return AI.ControlGetPosHeight(strTitle, strText, strControl);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strTitle"></param>
        /// <param name="strText"></param>
        /// <param name="strControl"></param>
        /// <returns></returns>
        public int ControlGetPosWidth(string strTitle, string strText, string strControl)
        {
            return AI.ControlGetPosWidth(strTitle, strText, strControl);
        }

        /// <summary>
        /// Retrieves text from a control.
        /// </summary>
        /// <param name="strTitle">The title/hWnd/class of the window to access.</param>
        /// <param name="strText">The text of the window to access.</param>
        /// <param name="strControl">The control to interact with.</param>
        /// <returns> 
        ///Success:	the text from a control. <br/>
        ///Failure:	"" (empty string) and sets the @error flag to 1.
        /// </returns>
        public string ControlGetText(string strTitle, string strText, string strControl)
        {
            return AI.ControlGetText(strTitle, strText, strControl);
        }

        /// <summary>
        /// Hides a control.
        /// </summary>
        /// <param name="strTitle">The title/hWnd/class of the window to access. </param>
        /// <param name="strText">The text of the window to access.</param>
        /// <param name="strControl">The control to interact with. </param>
        /// <returns>
        /// Success:	1. <br/>
        /// Failure:	0 if window/control is not found.
        /// </returns>
        public int ControlHide(string strTitle, string strText, string strControl)
        {
            return AI.ControlHide(strTitle, strText, strControl);
        }

        /// <summary>
        /// Sends a command to a ListView32 control.
        /// </summary>
        /// <param name="strTitle">The title/hWnd/class of the window to access.</param>
        /// <param name="strText">The text of the window to access.</param>
        /// <param name="strControl">The control to interact with.</param>
        /// <param name="strCommand">The command to send to the control</param>
        /// <param name="strExtra1">[optional] Additional parameter required by some commands.</param>
        /// <param name="strExtra2">[optional] Additional parameter required by some commands.</param>
        /// <returns>Return depends on command as table below shows. In case of an error (such as an invalid command or window/control could not be found) then @error is set to 1.</returns>
        public string ControlListView(string strTitle, string strText, string strControl, string strCommand, string strExtra1, string strExtra2)
        {
            return AI.ControlListView(strTitle, strText, strControl, strCommand, strExtra1, strExtra2);
        }

        /// <summary>
        /// Moves a control within a window.
        /// </summary>
        /// <param name="strTitle">The title/hWnd/class of the window to access. </param>
        /// <param name="strText">The text of the window to access. </param>
        /// <param name="strControl">The control to interact with. </param>
        /// <param name="nX">X coordinate to move to relative to the window client area.</param>
        /// <param name="nY">Y coordinate to move to relative to the window client area.</param>
        /// <param name="nWidth">[optional] New width of the window.</param>
        /// <param name="nHeight">[optional] New height of the window.</param>
        /// <returns> 
        /// Success:	1.
        /// Failure:	0 if window/control is not found.
        /// </returns>
        public int ControlMove(string strTitle, string strText, string strControl, int nX, int nY, int nWidth = -1, int nHeight = -1)
        {
            return AI.ControlMove(strTitle, strText, strControl, nX, nY, nWidth, nHeight);
        }

        /// <summary>
        /// Sends a string of characters to a control.
        /// </summary>
        /// <param name="strTitle">The title/hWnd/class of the window to access.</param>
        /// <param name="strText">The text of the window to access.</param>
        /// <param name="strControl">The control to interact with.</param>
        /// <param name="strSendText">String of characters to send to the control.</param>
        /// <param name="nMode">[optional] Changes how "keys" is processed: <br/>
        /// $SEND_DEFAULT (0) = Text contains special characters like + and ! to indicate SHIFT and ALT key-presses (default). <br/>
        /// $SEND_RAW (1) = keys are sent raw.
        /// </param>
        /// <returns>
        /// Success:	1. <br/>
        /// Failure:	0 if window/control is not found.
        /// </returns>
        public int ControlSend(string strTitle, string strText, string strControl, string strSendText, int nMode = 0)
        {
            return AI.ControlSend(strTitle, strText, strControl, strSendText, nMode);
        }

        /// <summary>
        /// Sets text of a control.
        /// </summary>
        /// <param name="strTitle">The title/hWnd/class of the window to access. </param>
        /// <param name="strText">The text of the window to access.</param>
        /// <param name="strControl">The control to interact with.</param>
        /// <param name="strControlText">The new text to be set into the control.</param>
        /// <returns>
        /// Success:	1.
        /// Failure:	0 if window/control is not found.
        /// </returns>
        public int ControlSetText(string strTitle, string strText, string strControl, string strControlText)
        {
            return AI.ControlSetText(strTitle, strText, strControl, strControlText);
        }

        /// <summary>
        /// Shows a control that was hidden.
        /// </summary>
        /// <param name="strTitle">The title/hWnd/class of the window to access.</param>
        /// <param name="strText">The text of the window to access. </param>
        /// <param name="strControl">The control to interact with.</param>
        /// <returns>
        /// Success:	1.
        /// Failure:	0 if window/control is not found.
        /// </returns>
        public int ControlShow(string strTitle, string strText, string strControl)
        {
            return AI.ControlShow(strTitle, strText, strControl);
        }

        /// <summary>
        /// Sends a command to a TreeView32 control.
        /// </summary>
        /// <param name="strTitle">The title/hWnd/class of the window to access. </param>
        /// <param name="strText">The text of the window to access. </param>
        /// <param name="strControl">The control to interact with.</param>
        /// <param name="strCommand">The command to send to the control (see below).</param>
        /// <param name="strExtra1">Additional parameter required by some commands.</param>
        /// <param name="strExtra2">Additional parameter required by some commands.</param>
        /// <returns>
        /// Return depends on the command as table below shows. In case of an error (such as an invalid command or window/control could not be found) then @error is set to 1.
        /// </returns>
        /// <para>
        /// "Check", "item"                 -->         Checks an item (if the item supports it). <br/>
        /// "Collapse", "item"              --> 	    Collapses an item to hide its children. <br/>
        /// "Exists", "item"                -->	        Returns 1 if an item exists, otherwise 0. <br/>
        /// "Expand", "item"                -->	        Expands an item to show its children. <br/>
        /// "GetItemCount", "item"          --> 	    Returns the number of children for a selected item. <br/>
        /// "GetSelected" [, UseIndex]      -->	        Returns the item reference of the current selection using the text reference of the item (or index reference if UseIndex is set to 1). <br/>
        /// "GetText", "item"	            -->         Returns the text of an item. <br/>
        /// "IsChecked"	                    -->         Returns the state of an item. 1:checked, 0:unchecked, -1:not a checkbox. <br/>
        /// "Select", "item"                -->         Selects an item. <br/>
        /// "Uncheck", "item"               --> 	    Unchecks an item (if the item supports it).
        /// </para>
        public string ControlTreeView(string strTitle, string strText, string strControl, string strCommand, string strExtra1, string strExtra2)
        {
            return AI.ControlTreeView(strTitle, strText, strControl, strCommand, strExtra1, strExtra2);
        }

        /// <summary>
        /// Maps a network drive.
        /// </summary>
        /// <param name="strDevice">The device to map, for example "O:" or "LPT1:". If you pass an empty string for this parameter a connection is made but not mapped to a specific drive. If you specify "*" an unused drive letter will be automatically selected.</param>
        /// <param name="strShare">The remote share to connect to in the form "\\server\share".</param>
        /// <param name="nFlags">
        /// [optional] A combination of the following: <br/>
        /// $DMA_DEFAULT (0) = default <br/>
        /// $DMA_PERSISTENT (1) = Persistent mapping <br/>
        /// $DMA_PERSISTENT (1) = Persistent mapping
        /// </param>
        /// <param name="strUser">[optional] The username to use to connect. In the form "username" or "domain\username".</param>
        /// <param name="strPwd">[optional] The password to use to connect.</param>
        /// <returns>
        /// Success:	1. (See Remarks) <br/>
        /// Failure:	0 if a new mapping could not be created and sets the @error flag to non-zero. <br/>
        /// @error:	1 = Undefined / Other error. @extended set with Windows API return <br/>
        /// 2 = Access to the remote share was denied <br/>
        /// 3 = The device is already assigned <br/>
        /// 4 = Invalid device name <br/>
        /// 5 = Invalid remote share <br/>
        /// 6 = Invalid password
        /// </returns>
        public string DriveMapAdd(string strDevice, string strShare, int nFlags = 0, string strUser = "", string strPwd = "")
        {
            return AI.DriveMapAdd(strDevice, strShare, nFlags, strUser, strPwd);
        }

        /// <summary>
        /// Disconnects a network drive.
        /// </summary>
        /// <param name="strDevice">The device to disconnect, e.g. "O:" or "LPT1:".</param>
        /// <returns>
        /// Success:	1.
        /// Failure:	0 if the disconnection was unsuccessful.
        /// </returns>
        public int DriveMapDel(string strDevice)
        {
            return AI.DriveMapDel(strDevice);
        }

        /// <summary>
        /// Retrieves the details of a mapped drive.
        /// </summary>
        /// <param name="strDevice">The device (drive or printer) letter to query, e.g. "O:" or "LPT1:"</param>
        /// <returns>
        /// Success:	a details of the mapping, e.g. \\server\share <br/>
        /// Failure:	an empty string "" and sets the @error flag to 1.
        /// </returns>
        public string DriveMapGet(string strDevice)
        {
            return AI.DriveMapGet(strDevice);
        }

        /// <summary>
        /// Checks if the current user has full administrator privileges.
        /// </summary>
        /// <returns>
        /// Success:	1 if the current user has administrator privileges.
        /// Failure:	0 if user lacks admin privileges.
        /// </returns>
        public int IsAdmin()
        {
            return AI.IsAdmin();
        }

        /// <summary>
        /// Perform a mouse click and drag operation.
        /// </summary>
        /// <param name="strButton">The button to click see enum mousebutton</param>
        /// <param name="nX1">The x/y coords to start the drag operation from.</param>
        /// <param name="nY1">The x/y coords to start the drag operation from.</param>
        /// <param name="nX2">The x/y coords to end the drag operation at.</param>
        /// <param name="nY2">The x/y coords to end the drag operation at.</param>
        /// <param name="nSpeed">[optional] the speed to move the mouse in the range 1 (fastest) to 100 (slowest). A speed of 0 will move the mouse instantly. Default speed is 10.</param>
        /// <returns>
        /// Success:	1. <br/>
        /// Failure:	0, the button is not in the list.
        /// </returns>
        public int MouseClickDrag(string strButton, int nX1, int nY1, int nX2, int nY2, int nSpeed = -1)
        {
            return AI.MouseClickDrag(strButton, nX1, nY1, nX2, nY2, nSpeed);
        }
    }
}
