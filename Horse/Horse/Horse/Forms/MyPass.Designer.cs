namespace Horse.Forms
{
    partial class MyPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPass));
            this.btnSavePass = new System.Windows.Forms.Button();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtNewPassRepeat = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblRepeatPas = new System.Windows.Forms.Label();
            this.lblErrorPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSavePass
            // 
            this.btnSavePass.Location = new System.Drawing.Point(97, 134);
            this.btnSavePass.Name = "btnSavePass";
            this.btnSavePass.Size = new System.Drawing.Size(75, 23);
            this.btnSavePass.TabIndex = 0;
            this.btnSavePass.Text = "Guardar";
            this.btnSavePass.UseVisualStyleBackColor = true;
            this.btnSavePass.Click += new System.EventHandler(this.btnSavePass_Click);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(30, 29);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(227, 20);
            this.txtNewPass.TabIndex = 1;
            // 
            // txtNewPassRepeat
            // 
            this.txtNewPassRepeat.Location = new System.Drawing.Point(30, 91);
            this.txtNewPassRepeat.Name = "txtNewPassRepeat";
            this.txtNewPassRepeat.Size = new System.Drawing.Size(227, 20);
            this.txtNewPassRepeat.TabIndex = 2;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Location = new System.Drawing.Point(30, 13);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(95, 13);
            this.lblNewPass.TabIndex = 3;
            this.lblNewPass.Text = "Nueva contraseña";
            // 
            // lblRepeatPas
            // 
            this.lblRepeatPas.AutoSize = true;
            this.lblRepeatPas.Location = new System.Drawing.Point(30, 75);
            this.lblRepeatPas.Name = "lblRepeatPas";
            this.lblRepeatPas.Size = new System.Drawing.Size(97, 13);
            this.lblRepeatPas.TabIndex = 4;
            this.lblRepeatPas.Text = "Repetir contraseña";
            // 
            // lblErrorPass
            // 
            this.lblErrorPass.AutoSize = true;
            this.lblErrorPass.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPass.Location = new System.Drawing.Point(12, 118);
            this.lblErrorPass.Name = "lblErrorPass";
            this.lblErrorPass.Size = new System.Drawing.Size(254, 13);
            this.lblErrorPass.TabIndex = 5;
            this.lblErrorPass.Text = "*Las contraseñas no coinciden. Intente nuevamente";
            this.lblErrorPass.Visible = false;
            // 
            // MyPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 169);
            this.Controls.Add(this.lblErrorPass);
            this.Controls.Add(this.lblRepeatPas);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.txtNewPassRepeat);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.btnSavePass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyPass";
            this.Text = "Reestablecer contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSavePass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtNewPassRepeat;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblRepeatPas;
        private System.Windows.Forms.Label lblErrorPass;
    }
}