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
            this.SuspendLayout();
            // 
            // btnMouseClick
            // 
            this.btnMouseClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMouseClick.Location = new System.Drawing.Point(12, 12);
            this.btnMouseClick.Name = "btnMouseClick";
            this.btnMouseClick.Size = new System.Drawing.Size(159, 42);
            this.btnMouseClick.TabIndex = 0;
            this.btnMouseClick.Text = "Mouse Move Click";
            this.btnMouseClick.UseVisualStyleBackColor = true;
            this.btnMouseClick.Click += new System.EventHandler(this.btnMouseClick_Click);
            // 
            // btnControlFocus
            // 
            this.btnControlFocus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlFocus.Location = new System.Drawing.Point(12, 60);
            this.btnControlFocus.Name = "btnControlFocus";
            this.btnControlFocus.Size = new System.Drawing.Size(159, 42);
            this.btnControlFocus.TabIndex = 1;
            this.btnControlFocus.Text = "Control Focus";
            this.btnControlFocus.UseVisualStyleBackColor = true;
            this.btnControlFocus.Click += new System.EventHandler(this.btnControlFocus_Click);
            // 
            // btnWaitActiveControl
            // 
            this.btnWaitActiveControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWaitActiveControl.Location = new System.Drawing.Point(12, 108);
            this.btnWaitActiveControl.Name = "btnWaitActiveControl";
            this.btnWaitActiveControl.Size = new System.Drawing.Size(159, 42);
            this.btnWaitActiveControl.TabIndex = 2;
            this.btnWaitActiveControl.Text = "Windows Wait Active";
            this.btnWaitActiveControl.UseVisualStyleBackColor = true;
            this.btnWaitActiveControl.Click += new System.EventHandler(this.btnWaitActiveControl_Click);
            // 
            // AutoIt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 159);
            this.Controls.Add(this.btnWaitActiveControl);
            this.Controls.Add(this.btnControlFocus);
            this.Controls.Add(this.btnMouseClick);
            this.Name = "AutoIt";
            this.Text = "AutoIt";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMouseClick;
        private System.Windows.Forms.Button btnControlFocus;
        private System.Windows.Forms.Button btnWaitActiveControl;
    }
}