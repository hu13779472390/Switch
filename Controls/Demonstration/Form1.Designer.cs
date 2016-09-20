using Controls;
namespace Demonstration
{
    partial class Form1
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
            this.switch1 = new Controls.Switch();
            this.SuspendLayout();
            // 
            // switch1
            // 
            this.switch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.switch1.CurrentState = Switch.SwitchStates.On;
            this.switch1.Location = new System.Drawing.Point(114, 107);
            this.switch1.Name = "switch1";
            this.switch1.Size = new System.Drawing.Size(53, 23);
            this.switch1.TabIndex = 0;
            this.switch1.Text = "switch1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 274);
            this.Controls.Add(this.switch1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Switch switch1;
    }
}

