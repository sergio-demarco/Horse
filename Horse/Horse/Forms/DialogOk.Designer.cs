namespace Horse.Forms
{
    partial class DialogOk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogOk));
            this.btnDialogOk = new System.Windows.Forms.Button();
            this.lblDialogOk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDialogOk
            // 
            this.btnDialogOk.Location = new System.Drawing.Point(89, 50);
            this.btnDialogOk.Name = "btnDialogOk";
            this.btnDialogOk.Size = new System.Drawing.Size(75, 23);
            this.btnDialogOk.TabIndex = 0;
            this.btnDialogOk.Text = "OK";
            this.btnDialogOk.UseVisualStyleBackColor = true;
            this.btnDialogOk.Click += new System.EventHandler(this.btnDialogOk_Click);
            // 
            // lblDialogOk
            // 
            this.lblDialogOk.AutoSize = true;
            this.lblDialogOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDialogOk.Location = new System.Drawing.Point(26, 9);
            this.lblDialogOk.Name = "lblDialogOk";
            this.lblDialogOk.Size = new System.Drawing.Size(0, 15);
            this.lblDialogOk.TabIndex = 1;
            // 
            // DialogOk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 83);
            this.ControlBox = false;
            this.Controls.Add(this.lblDialogOk);
            this.Controls.Add(this.btnDialogOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DialogOk";
            this.Text = " ";
            this.Load += new System.EventHandler(this.DialogOk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDialogOk;
        private System.Windows.Forms.Label lblDialogOk;
    }
}