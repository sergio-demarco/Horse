namespace Horse.UserControls
{
    partial class CalendarClients
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.numericPeriodDays = new System.Windows.Forms.NumericUpDown();
            this.btnSaveCalendar = new System.Windows.Forms.Button();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.btnSearchClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericPeriodDays)).BeginInit();
            this.SuspendLayout();
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(69, 81);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 0;
            this.Calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(42, 313);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(270, 20);
            this.txtDate.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(39, 284);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(104, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Fecha de Comienzo:";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(39, 353);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(85, 13);
            this.lblPeriod.TabIndex = 3;
            this.lblPeriod.Text = "Periodo de Dias:";
            // 
            // numericPeriodDays
            // 
            this.numericPeriodDays.Location = new System.Drawing.Point(42, 379);
            this.numericPeriodDays.Name = "numericPeriodDays";
            this.numericPeriodDays.Size = new System.Drawing.Size(270, 20);
            this.numericPeriodDays.TabIndex = 5;
            // 
            // btnSaveCalendar
            // 
            this.btnSaveCalendar.Location = new System.Drawing.Point(68, 450);
            this.btnSaveCalendar.Name = "btnSaveCalendar";
            this.btnSaveCalendar.Size = new System.Drawing.Size(227, 47);
            this.btnSaveCalendar.TabIndex = 6;
            this.btnSaveCalendar.Text = "Guardar";
            this.btnSaveCalendar.UseVisualStyleBackColor = true;
            this.btnSaveCalendar.Click += new System.EventHandler(this.btnSaveCalendar_Click);
            // 
            // txtClient
            // 
            this.txtClient.Enabled = false;
            this.txtClient.Location = new System.Drawing.Point(42, 49);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(264, 20);
            this.txtClient.TabIndex = 7;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(39, 33);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(42, 13);
            this.lblClient.TabIndex = 8;
            this.lblClient.Text = "Cliente:";
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Location = new System.Drawing.Point(312, 47);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(75, 23);
            this.btnSearchClient.TabIndex = 9;
            this.btnSearchClient.Text = "Buscar";
            this.btnSearchClient.UseVisualStyleBackColor = true;
            this.btnSearchClient.Click += new System.EventHandler(this.btnSearchClient_Click);
            // 
            // CalendarClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearchClient);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.btnSaveCalendar);
            this.Controls.Add(this.numericPeriodDays);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.Calendar);
            this.Name = "CalendarClients";
            this.Size = new System.Drawing.Size(397, 509);
            this.Load += new System.EventHandler(this.CalendarClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericPeriodDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.NumericUpDown numericPeriodDays;
        private System.Windows.Forms.Button btnSaveCalendar;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Button btnSearchClient;
    }
}
