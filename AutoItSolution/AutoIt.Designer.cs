namespace AutoItSolution
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
            this.btnMouseClick = new System.Windows.Forms.Button();
            this.btnControlFocus = new System.Windows.Forms.Button();
            this.btnWaitActiveControl = new System.Windows.Forms.Button();
            this.btnActivateWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMouseClick
            // 
            this.btnMouseClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMouseClick.Location = new System.Drawing.Point(16, 15);
            this.btnMouseClick.Margin = new System.Windows.Forms.Padding(4);
            this.btnMouseClick.Name = "btnMouseClick";
            this.btnMouseClick.Size = new System.Drawing.Size(212, 52);
            this.btnMouseClick.TabIndex = 0;
            this.btnMouseClick.Text = "Mouse Move Click";
            this.btnMouseClick.UseVisualStyleBackColor = true;
            this.btnMouseClick.Click += new System.EventHandler(this.btnMouseClick_Click);
            // 
            // btnControlFocus
            // 
            this.btnControlFocus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlFocus.Location = new System.Drawing.Point(16, 74);
            this.btnControlFocus.Margin = new System.Windows.Forms.Padding(4);
            this.btnControlFocus.Name = "btnControlFocus";
            this.btnControlFocus.Size = new System.Drawing.Size(212, 52);
            this.btnControlFocus.TabIndex = 1;
            this.btnControlFocus.Text = "Control Focus";
            this.btnControlFocus.UseVisualStyleBackColor = true;
            this.btnControlFocus.Click += new System.EventHandler(this.btnControlFocus_Click);
            // 
            // btnWaitActiveControl
            // 
            this.btnWaitActiveControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWaitActiveControl.Location = new System.Drawing.Point(16, 133);
            this.btnWaitActiveControl.Margin = new System.Windows.Forms.Padding(4);
            this.btnWaitActiveControl.Name = "btnWaitActiveControl";
            this.btnWaitActiveControl.Size = new System.Drawing.Size(212, 52);
            this.btnWaitActiveControl.TabIndex = 2;
            this.btnWaitActiveControl.Text = "Windows Wait Active";
            this.btnWaitActiveControl.UseVisualStyleBackColor = true;
            this.btnWaitActiveControl.Click += new System.EventHandler(this.btnWaitActiveControl_Click);
            // 
            // btnActivateWindow
            // 
            this.btnActivateWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivateWindow.Location = new System.Drawing.Point(16, 193);
            this.btnActivateWindow.Margin = new System.Windows.Forms.Padding(4);
            this.btnActivateWindow.Name = "btnActivateWindow";
            this.btnActivateWindow.Size = new System.Drawing.Size(212, 52);
            this.btnActivateWindow.TabIndex = 3;
            this.btnActivateWindow.Text = "Activate Window";
            this.btnActivateWindow.UseVisualStyleBackColor = true;
            this.btnActivateWindow.Click += new System.EventHandler(this.btnActivateWindow_Click);
            // 
            // AutoIt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 256);
            this.Controls.Add(this.btnActivateWindow);
            this.Controls.Add(this.btnWaitActiveControl);
            this.Controls.Add(this.btnControlFocus);
            this.Controls.Add(this.btnMouseClick);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AutoIt";
            this.Text = "AutoIt";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMouseClick;
        private System.Windows.Forms.Button btnControlFocus;
        private System.Windows.Forms.Button btnWaitActiveControl;
        private System.Windows.Forms.Button btnActivateWindow;
    }
}