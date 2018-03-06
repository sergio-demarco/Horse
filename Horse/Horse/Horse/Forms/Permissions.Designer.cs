namespace Horse.Forms
{
    partial class Permission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Permission));
            this.dataGridPermissions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPermissions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPermissions
            // 
            this.dataGridPermissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPermissions.Location = new System.Drawing.Point(12, 12);
            this.dataGridPermissions.Name = "dataGridPermissions";
            this.dataGridPermissions.Size = new System.Drawing.Size(526, 320);
            this.dataGridPermissions.TabIndex = 0;
            // 
            // Permission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 344);
            this.Controls.Add(this.dataGridPermissions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Permission";
            this.Text = "Editar Permisos";
            this.Load += new System.EventHandler(this.Permission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPermissions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPermissions;
    }
}