namespace Horse.UserControls
{
    partial class Debts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Debts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.checkAllChecks = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkDni = new System.Windows.Forms.CheckBox();
            this.checkApellido = new System.Windows.Forms.CheckBox();
            this.checkNombre = new System.Windows.Forms.CheckBox();
            this.txtClients = new System.Windows.Forms.TextBox();
            this.dataClients = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dropOrderBy = new System.Windows.Forms.ComboBox();
            this.Agregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.indebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infavor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataClients)).BeginInit();
            this.SuspendLayout();
            // 
            // checkAllChecks
            // 
            this.checkAllChecks.AutoSize = true;
            this.checkAllChecks.Checked = true;
            this.checkAllChecks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAllChecks.Location = new System.Drawing.Point(116, 67);
            this.checkAllChecks.Name = "checkAllChecks";
            this.checkAllChecks.Size = new System.Drawing.Size(56, 17);
            this.checkAllChecks.TabIndex = 32;
            this.checkAllChecks.Text = "Todos";
            this.checkAllChecks.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.25F);
            this.label1.Location = new System.Drawing.Point(26, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "Buscar por:";
            // 
            // checkDni
            // 
            this.checkDni.AutoSize = true;
            this.checkDni.Checked = true;
            this.checkDni.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDni.Location = new System.Drawing.Point(331, 66);
            this.checkDni.Name = "checkDni";
            this.checkDni.Size = new System.Drawing.Size(42, 17);
            this.checkDni.TabIndex = 24;
            this.checkDni.Text = "Dni";
            this.checkDni.UseVisualStyleBackColor = true;
            // 
            // checkApellido
            // 
            this.checkApellido.AutoSize = true;
            this.checkApellido.Checked = true;
            this.checkApellido.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkApellido.Location = new System.Drawing.Point(262, 66);
            this.checkApellido.Name = "checkApellido";
            this.checkApellido.Size = new System.Drawing.Size(63, 17);
            this.checkApellido.TabIndex = 21;
            this.checkApellido.Text = "Apellido";
            this.checkApellido.UseVisualStyleBackColor = true;
            // 
            // checkNombre
            // 
            this.checkNombre.AutoSize = true;
            this.checkNombre.Checked = true;
            this.checkNombre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkNombre.Location = new System.Drawing.Point(193, 66);
            this.checkNombre.Name = "checkNombre";
            this.checkNombre.Size = new System.Drawing.Size(63, 17);
            this.checkNombre.TabIndex = 20;
            this.checkNombre.Text = "Nombre";
            this.checkNombre.UseVisualStyleBackColor = true;
            // 
            // txtClients
            // 
            this.txtClients.Location = new System.Drawing.Point(30, 22);
            this.txtClients.Multiline = true;
            this.txtClients.Name = "txtClients";
            this.txtClients.Size = new System.Drawing.Size(1024, 35);
            this.txtClients.TabIndex = 18;
            // 
            // dataClients
            // 
            this.dataClients.AllowUserToAddRows = false;
            this.dataClients.AllowUserToDeleteRows = false;
            this.dataClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Agregar,
            this.indebt,
            this.infavor,
            this.name,
            this.lastname,
            this.phone,
            this.phone2});
            this.dataClients.Location = new System.Drawing.Point(30, 86);
            this.dataClients.Name = "dataClients";
            this.dataClients.ReadOnly = true;
            this.dataClients.Size = new System.Drawing.Size(1122, 464);
            this.dataClients.TabIndex = 17;
            this.dataClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataClients_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(1091, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 54);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.25F);
            this.label2.Location = new System.Drawing.Point(424, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Ordenar por:";
            // 
            // dropOrderBy
            // 
            this.dropOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropOrderBy.FormattingEnabled = true;
            this.dropOrderBy.Items.AddRange(new object[] {
            "Debe",
            "A Favor"});
            this.dropOrderBy.Location = new System.Drawing.Point(513, 62);
            this.dropOrderBy.Name = "dropOrderBy";
            this.dropOrderBy.Size = new System.Drawing.Size(121, 21);
            this.dropOrderBy.TabIndex = 34;
            this.dropOrderBy.SelectedIndexChanged += new System.EventHandler(this.dropOrderBy_SelectedIndexChanged);
            // 
            // Agregar
            // 
            this.Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Agregar.Frozen = true;
            this.Agregar.HeaderText = "Agregar";
            this.Agregar.Name = "Agregar";
            this.Agregar.ReadOnly = true;
            this.Agregar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Agregar.Text = "Agregar Saldo";
            this.Agregar.UseColumnTextForButtonValue = true;
            this.Agregar.Width = 75;
            // 
            // indebt
            // 
            this.indebt.DataPropertyName = "indebt";
            this.indebt.Frozen = true;
            this.indebt.HeaderText = "DEBE";
            this.indebt.Name = "indebt";
            this.indebt.ReadOnly = true;
            this.indebt.Width = 120;
            // 
            // infavor
            // 
            this.infavor.DataPropertyName = "infavor";
            this.infavor.Frozen = true;
            this.infavor.HeaderText = "A Favor";
            this.infavor.Name = "infavor";
            this.infavor.ReadOnly = true;
            this.infavor.Width = 120;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.name.DefaultCellStyle = dataGridViewCellStyle1;
            this.name.HeaderText = "Nombre";
            this.name.MaxInputLength = 200;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 120;
            // 
            // lastname
            // 
            this.lastname.DataPropertyName = "lastname";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lastname.DefaultCellStyle = dataGridViewCellStyle2;
            this.lastname.HeaderText = "Apellido";
            this.lastname.MaxInputLength = 200;
            this.lastname.Name = "lastname";
            this.lastname.ReadOnly = true;
            this.lastname.Width = 120;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.phone.DefaultCellStyle = dataGridViewCellStyle3;
            this.phone.HeaderText = "Telefono";
            this.phone.MaxInputLength = 200;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 120;
            // 
            // phone2
            // 
            this.phone2.DataPropertyName = "phone2";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.phone2.DefaultCellStyle = dataGridViewCellStyle4;
            this.phone2.HeaderText = "Telefono 2";
            this.phone2.MaxInputLength = 200;
            this.phone2.Name = "phone2";
            this.phone2.ReadOnly = true;
            this.phone2.Width = 120;
            // 
            // Debts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dropOrderBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkAllChecks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkDni);
            this.Controls.Add(this.checkApellido);
            this.Controls.Add(this.checkNombre);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtClients);
            this.Controls.Add(this.dataClients);
            this.Name = "Debts";
            this.Size = new System.Drawing.Size(1446, 550);
            this.Load += new System.EventHandler(this.Debts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkAllChecks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkDni;
        private System.Windows.Forms.CheckBox checkApellido;
        private System.Windows.Forms.CheckBox checkNombre;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtClients;
        private System.Windows.Forms.DataGridView dataClients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dropOrderBy;
        private System.Windows.Forms.DataGridViewButtonColumn Agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn indebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn infavor;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2;
    }
}
