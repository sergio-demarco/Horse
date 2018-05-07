namespace Horse.Forms
{
    partial class Calendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.btnSaveCalendar = new System.Windows.Forms.Button();
            this.numericPeriodDays = new System.Windows.Forms.NumericUpDown();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.numericPeriodDays)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClient.Location = new System.Drawing.Point(313, 31);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(75, 23);
            this.btnSearchClient.TabIndex = 18;
            this.btnSearchClient.Text = "Buscar";
            this.btnSearchClient.UseVisualStyleBackColor = true;
            this.btnSearchClient.Click += new System.EventHandler(this.btnSearchClient_Click);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(40, 10);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(57, 18);
            this.lblClient.TabIndex = 17;
            this.lblClient.Text = "Cliente:";
            // 
            // txtClient
            // 
            this.txtClient.Enabled = false;
            this.txtClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClient.Location = new System.Drawing.Point(43, 31);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(264, 26);
            this.txtClient.TabIndex = 16;
            // 
            // btnSaveCalendar
            // 
            this.btnSaveCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCalendar.Location = new System.Drawing.Point(61, 422);
            this.btnSaveCalendar.Name = "btnSaveCalendar";
            this.btnSaveCalendar.Size = new System.Drawing.Size(227, 47);
            this.btnSaveCalendar.TabIndex = 15;
            this.btnSaveCalendar.Text = "Guardar";
            this.btnSaveCalendar.UseVisualStyleBackColor = true;
            this.btnSaveCalendar.Click += new System.EventHandler(this.btnSaveCalendar_Click);
            // 
            // numericPeriodDays
            // 
            this.numericPeriodDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPeriodDays.Location = new System.Drawing.Point(43, 356);
            this.numericPeriodDays.Name = "numericPeriodDays";
            this.numericPeriodDays.Size = new System.Drawing.Size(270, 24);
            this.numericPeriodDays.TabIndex = 14;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(40, 330);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(118, 18);
            this.lblPeriod.TabIndex = 13;
            this.lblPeriod.Text = "Periodo de Dias:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(40, 261);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(146, 18);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Fecha de Comienzo:";
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(43, 282);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(270, 26);
            this.txtDate.TabIndex = 11;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(43, 69);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 493);
            this.Controls.Add(this.btnSearchClient);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.btnSaveCalendar);
            this.Controls.Add(this.numericPeriodDays);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.monthCalendar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            ((System.ComponentModel.ISupportInitialize)(this.numericPeriodDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Button btnSaveCalendar;
        private System.Windows.Forms.NumericUpDown numericPeriodDays;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}