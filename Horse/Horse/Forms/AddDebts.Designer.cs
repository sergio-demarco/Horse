namespace Horse.Forms
{
    partial class AddDebts
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
            this.lblClient = new System.Windows.Forms.Label();
            this.lblDebt = new System.Windows.Forms.Label();
            this.lblInfavor = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.txtDebt = new System.Windows.Forms.TextBox();
            this.txtInfavor = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.lblClient.Location = new System.Drawing.Point(15, 32);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(61, 23);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Cliente:";
            // 
            // lblDebt
            // 
            this.lblDebt.AutoSize = true;
            this.lblDebt.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.lblDebt.Location = new System.Drawing.Point(15, 75);
            this.lblDebt.Name = "lblDebt";
            this.lblDebt.Size = new System.Drawing.Size(52, 23);
            this.lblDebt.TabIndex = 1;
            this.lblDebt.Text = "Debe:";
            // 
            // lblInfavor
            // 
            this.lblInfavor.AutoSize = true;
            this.lblInfavor.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.lblInfavor.Location = new System.Drawing.Point(15, 118);
            this.lblInfavor.Name = "lblInfavor";
            this.lblInfavor.Size = new System.Drawing.Size(68, 23);
            this.lblInfavor.TabIndex = 2;
            this.lblInfavor.Text = "A Favor:";
            // 
            // txtClient
            // 
            this.txtClient.Enabled = false;
            this.txtClient.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.txtClient.Location = new System.Drawing.Point(89, 29);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(216, 29);
            this.txtClient.TabIndex = 3;
            // 
            // txtDebt
            // 
            this.txtDebt.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebt.Location = new System.Drawing.Point(89, 72);
            this.txtDebt.Name = "txtDebt";
            this.txtDebt.Size = new System.Drawing.Size(216, 29);
            this.txtDebt.TabIndex = 4;
            this.txtDebt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInfavor
            // 
            this.txtInfavor.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.txtInfavor.Location = new System.Drawing.Point(89, 115);
            this.txtInfavor.Name = "txtInfavor";
            this.txtInfavor.Size = new System.Drawing.Size(216, 29);
            this.txtInfavor.TabIndex = 5;
            this.txtInfavor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(238, 196);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(108, 196);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(89, 150);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 9;
            // 
            // AddDebts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 231);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtInfavor);
            this.Controls.Add(this.txtDebt);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.lblInfavor);
            this.Controls.Add(this.lblDebt);
            this.Controls.Add(this.lblClient);
            this.Name = "AddDebts";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Deudor";
            this.Load += new System.EventHandler(this.AddDebts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblDebt;
        private System.Windows.Forms.Label lblInfavor;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.TextBox txtDebt;
        private System.Windows.Forms.TextBox txtInfavor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}