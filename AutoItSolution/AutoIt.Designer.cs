namespace AutoItLee
{
    partial class AutoIt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnMouseClick = new System.Windows.Forms.Button();
            this.BtnControlFocus = new System.Windows.Forms.Button();
            this.BtnWaitActiveControl = new System.Windows.Forms.Button();
            this.BtnActivateWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMouseClick
            // 
            this.BtnMouseClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMouseClick.Location = new System.Drawing.Point(16, 15);
            this.BtnMouseClick.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMouseClick.Name = "BtnMouseClick";
            this.BtnMouseClick.Size = new System.Drawing.Size(212, 52);
            this.BtnMouseClick.TabIndex = 0;
            this.BtnMouseClick.Text = "Mouse Move Click";
            this.BtnMouseClick.UseVisualStyleBackColor = true;
            this.BtnMouseClick.Click += new System.EventHandler(this.BtnMouseClick_Click);
            // 
            // BtnControlFocus
            // 
            this.BtnControlFocus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnControlFocus.Location = new System.Drawing.Point(16, 74);
            this.BtnControlFocus.Margin = new System.Windows.Forms.Padding(4);
            this.BtnControlFocus.Name = "BtnControlFocus";
            this.BtnControlFocus.Size = new System.Drawing.Size(212, 52);
            this.BtnControlFocus.TabIndex = 1;
            this.BtnControlFocus.Text = "Control Focus";
            this.BtnControlFocus.UseVisualStyleBackColor = true;
            this.BtnControlFocus.Click += new System.EventHandler(this.BtnControlFocus_Click);
            // 
            // BtnWaitActiveControl
            // 
            this.BtnWaitActiveControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWaitActiveControl.Location = new System.Drawing.Point(16, 133);
            this.BtnWaitActiveControl.Margin = new System.Windows.Forms.Padding(4);
            this.BtnWaitActiveControl.Name = "BtnWaitActiveControl";
            this.BtnWaitActiveControl.Size = new System.Drawing.Size(212, 52);
            this.BtnWaitActiveControl.TabIndex = 2;
            this.BtnWaitActiveControl.Text = "Windows Wait Active";
            this.BtnWaitActiveControl.UseVisualStyleBackColor = true;
            this.BtnWaitActiveControl.Click += new System.EventHandler(this.BtnWaitActiveControl_Click);
            // 
            // BtnActivateWindow
            // 
            this.BtnActivateWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActivateWindow.Location = new System.Drawing.Point(16, 193);
            this.BtnActivateWindow.Margin = new System.Windows.Forms.Padding(4);
            this.BtnActivateWindow.Name = "BtnActivateWindow";
            this.BtnActivateWindow.Size = new System.Drawing.Size(212, 52);
            this.BtnActivateWindow.TabIndex = 3;
            this.BtnActivateWindow.Text = "Activate Window";
            this.BtnActivateWindow.UseVisualStyleBackColor = true;
            this.BtnActivateWindow.Click += new System.EventHandler(this.BtnActivateWindow_Click);
            // 
            // AutoIt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 256);
            this.Controls.Add(this.BtnActivateWindow);
            this.Controls.Add(this.BtnWaitActiveControl);
            this.Controls.Add(this.BtnControlFocus);
            this.Controls.Add(this.BtnMouseClick);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AutoIt";
            this.Text = "AutoIt";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMouseClick;
        private System.Windows.Forms.Button BtnControlFocus;
        private System.Windows.Forms.Button BtnWaitActiveControl;
        private System.Windows.Forms.Button BtnActivateWindow;
    }
}