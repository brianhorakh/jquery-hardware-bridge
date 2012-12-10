namespace ConsoleApplication1
{
    partial class DeviceServerMain
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
            this.debugTxt = new System.Windows.Forms.TextBox();
            this.portLbl = new System.Windows.Forms.Label();
            this.portTxt = new System.Windows.Forms.TextBox();
            this.debugLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // debugTxt
            // 
            this.debugTxt.CausesValidation = false;
            this.debugTxt.Location = new System.Drawing.Point(23, 277);
            this.debugTxt.Multiline = true;
            this.debugTxt.Name = "debugTxt";
            this.debugTxt.Size = new System.Drawing.Size(478, 186);
            this.debugTxt.TabIndex = 0;
            // 
            // portLbl
            // 
            this.portLbl.AutoSize = true;
            this.portLbl.Location = new System.Drawing.Point(33, 31);
            this.portLbl.Name = "portLbl";
            this.portLbl.Size = new System.Drawing.Size(58, 13);
            this.portLbl.TabIndex = 1;
            this.portLbl.Text = "HTTP Port";
            this.portLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // portTxt
            // 
            this.portTxt.Location = new System.Drawing.Point(97, 28);
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(80, 20);
            this.portTxt.TabIndex = 2;
            // 
            // debugLbl
            // 
            this.debugLbl.AutoSize = true;
            this.debugLbl.Location = new System.Drawing.Point(20, 261);
            this.debugLbl.Name = "debugLbl";
            this.debugLbl.Size = new System.Drawing.Size(80, 13);
            this.debugLbl.TabIndex = 3;
            this.debugLbl.Text = "Debug Console";
            // 
            // DeviceServerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 475);
            this.Controls.Add(this.debugLbl);
            this.Controls.Add(this.portTxt);
            this.Controls.Add(this.portLbl);
            this.Controls.Add(this.debugTxt);
            this.Name = "DeviceServerMain";
            this.Text = "DeviceServer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox debugTxt;
        private System.Windows.Forms.Label portLbl;
        private System.Windows.Forms.TextBox portTxt;
        private System.Windows.Forms.Label debugLbl;
    }
}