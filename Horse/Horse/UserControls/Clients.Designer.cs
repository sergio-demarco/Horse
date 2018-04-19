namespace Horse.UserControls
{
    partial class Clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            this.dataClients = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonsoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtClients = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.checkNombre = new System.Windows.Forms.CheckBox();
            this.checkApellido = new System.Windows.Forms.CheckBox();
            this.checkCorreo = new System.Windows.Forms.CheckBox();
            this.checkCuit = new System.Windows.Forms.CheckBox();
            this.checkDni = new System.Windows.Forms.CheckBox();
            this.checkLocalidad = new System.Windows.Forms.CheckBox();
            this.checkNombreMascota = new System.Windows.Forms.CheckBox();
            this.checkRazSocial = new System.Windows.Forms.CheckBox();
            this.checkTelefono = new System.Windows.Forms.CheckBox();
            this.checkDomicilio = new System.Windows.Forms.CheckBox();
            this.checkPhone2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkAllChecks = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataClients
            // 
            this.dataClients.AllowUserToAddRows = false;
            this.dataClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.id,
            this.name,
            this.lastname,
            this.email,
            this.cuit,
            this.dni,
            this.adress,
            this.location,
            this.petname,
            this.razonsoc,
            this.phone,
            this.phone2});
            this.dataClients.Location = new System.Drawing.Point(23, 83);
            this.dataClients.Name = "dataClients";
            this.dataClients.Size = new System.Drawing.Size(1257, 464);
            this.dataClients.TabIndex = 0;
            this.dataClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataClients_CellClick);
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 5;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "name";
            this.name.Name = "name";
            // 
            // lastname
            // 
            this.lastname.DataPropertyName = "lastname";
            this.lastname.HeaderText = "lastname";
            this.lastname.Name = "lastname";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            // 
            // cuit
            // 
            this.cuit.DataPropertyName = "cuit";
            this.cuit.HeaderText = "cuit";
            this.cuit.Name = "cuit";
            // 
            // dni
            // 
            this.dni.DataPropertyName = "dni";
            this.dni.HeaderText = "dni";
            this.dni.Name = "dni";
            // 
            // adress
            // 
            this.adress.DataPropertyName = "adress";
            this.adress.HeaderText = "adress";
            this.adress.Name = "adress";
            // 
            // location
            // 
            this.location.DataPropertyName = "location";
            this.location.HeaderText = "location";
            this.location.Name = "location";
            // 
            // petname
            // 
            this.petname.DataPropertyName = "petname";
            this.petname.HeaderText = "petname";
            this.petname.Name = "petname";
            // 
            // razonsoc
            // 
            this.razonsoc.DataPropertyName = "razonsoc";
            this.razonsoc.HeaderText = "razonsoc";
            this.razonsoc.Name = "razonsoc";
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "phone";
            this.phone.Name = "phone";
            // 
            // phone2
            // 
            this.phone2.DataPropertyName = "phone2";
            this.phone2.HeaderText = "phone2";
            this.phone2.Name = "phone2";
            // 
            // txtClients
            // 
            this.txtClients.Location = new System.Drawing.Point(23, 19);
            this.txtClients.Multiline = true;
            this.txtClients.Name = "txtClients";
            this.txtClients.Size = new System.Drawing.Size(1115, 35);
            this.txtClients.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(1144, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 54);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // checkNombre
            // 
            this.checkNombre.AutoSize = true;
            this.checkNombre.Checked = true;
            this.checkNombre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkNombre.Location = new System.Drawing.Point(186, 59);
            this.checkNombre.Name = "checkNombre";
            this.checkNombre.Size = new System.Drawing.Size(63, 17);
            this.checkNombre.TabIndex = 4;
            this.checkNombre.Text = "Nombre";
            this.checkNombre.UseVisualStyleBackColor = true;
            // 
            // checkApellido
            // 
            this.checkApellido.AutoSize = true;
            this.checkApellido.Checked = true;
            this.checkApellido.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkApellido.Location = new System.Drawing.Point(255, 59);
            this.checkApellido.Name = "checkApellido";
            this.checkApellido.Size = new System.Drawing.Size(63, 17);
            this.checkApellido.TabIndex = 5;
            this.checkApellido.Text = "Apellido";
            this.checkApellido.UseVisualStyleBackColor = true;
            // 
            // checkCorreo
            // 
            this.checkCorreo.AutoSize = true;
            this.checkCorreo.Checked = true;
            this.checkCorreo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCorreo.Location = new System.Drawing.Point(779, 59);
            this.checkCorreo.Name = "checkCorreo";
            this.checkCorreo.Size = new System.Drawing.Size(57, 17);
            this.checkCorreo.TabIndex = 6;
            this.checkCorreo.Text = "Correo";
            this.checkCorreo.UseVisualStyleBackColor = true;
            // 
            // checkCuit
            // 
            this.checkCuit.AutoSize = true;
            this.checkCuit.Checked = true;
            this.checkCuit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCuit.Location = new System.Drawing.Point(937, 59);
            this.checkCuit.Name = "checkCuit";
            this.checkCuit.Size = new System.Drawing.Size(44, 17);
            this.checkCuit.TabIndex = 7;
            this.checkCuit.Text = "Cuit";
            this.checkCuit.UseVisualStyleBackColor = true;
            // 
            // checkDni
            // 
            this.checkDni.AutoSize = true;
            this.checkDni.Checked = true;
            this.checkDni.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDni.Location = new System.Drawing.Point(324, 59);
            this.checkDni.Name = "checkDni";
            this.checkDni.Size = new System.Drawing.Size(42, 17);
            this.checkDni.TabIndex = 8;
            this.checkDni.Text = "Dni";
            this.checkDni.UseVisualStyleBackColor = true;
            // 
            // checkLocalidad
            // 
            this.checkLocalidad.AutoSize = true;
            this.checkLocalidad.Checked = true;
            this.checkLocalidad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkLocalidad.Location = new System.Drawing.Point(707, 59);
            this.checkLocalidad.Name = "checkLocalidad";
            this.checkLocalidad.Size = new System.Drawing.Size(72, 17);
            this.checkLocalidad.TabIndex = 9;
            this.checkLocalidad.Text = "Localidad";
            this.checkLocalidad.UseVisualStyleBackColor = true;
            // 
            // checkNombreMascota
            // 
            this.checkNombreMascota.AutoSize = true;
            this.checkNombreMascota.Checked = true;
            this.checkNombreMascota.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkNombreMascota.Location = new System.Drawing.Point(372, 59);
            this.checkNombreMascota.Name = "checkNombreMascota";
            this.checkNombreMascota.Size = new System.Drawing.Size(107, 17);
            this.checkNombreMascota.TabIndex = 10;
            this.checkNombreMascota.Text = "Nombre Mascota";
            this.checkNombreMascota.UseVisualStyleBackColor = true;
            // 
            // checkRazSocial
            // 
            this.checkRazSocial.AutoSize = true;
            this.checkRazSocial.Checked = true;
            this.checkRazSocial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkRazSocial.Location = new System.Drawing.Point(842, 59);
            this.checkRazSocial.Name = "checkRazSocial";
            this.checkRazSocial.Size = new System.Drawing.Size(89, 17);
            this.checkRazSocial.TabIndex = 11;
            this.checkRazSocial.Text = "Razon Social";
            this.checkRazSocial.UseVisualStyleBackColor = true;
            // 
            // checkTelefono
            // 
            this.checkTelefono.AutoSize = true;
            this.checkTelefono.Checked = true;
            this.checkTelefono.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkTelefono.Location = new System.Drawing.Point(485, 59);
            this.checkTelefono.Name = "checkTelefono";
            this.checkTelefono.Size = new System.Drawing.Size(68, 17);
            this.checkTelefono.TabIndex = 12;
            this.checkTelefono.Text = "Telefono";
            this.checkTelefono.UseVisualStyleBackColor = true;
            // 
            // checkDomicilio
            // 
            this.checkDomicilio.AutoSize = true;
            this.checkDomicilio.Checked = true;
            this.checkDomicilio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDomicilio.Location = new System.Drawing.Point(633, 59);
            this.checkDomicilio.Name = "checkDomicilio";
            this.checkDomicilio.Size = new System.Drawing.Size(68, 17);
            this.checkDomicilio.TabIndex = 13;
            this.checkDomicilio.Text = "Domicilio";
            this.checkDomicilio.UseVisualStyleBackColor = true;
            // 
            // checkPhone2
            // 
            this.checkPhone2.AutoSize = true;
            this.checkPhone2.Checked = true;
            this.checkPhone2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPhone2.Location = new System.Drawing.Point(559, 59);
            this.checkPhone2.Name = "checkPhone2";
            this.checkPhone2.Size = new System.Drawing.Size(74, 17);
            this.checkPhone2.TabIndex = 14;
            this.checkPhone2.Text = "Telefono2";
            this.checkPhone2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.25F);
            this.label1.Location = new System.Drawing.Point(19, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Buscar por:";
            // 
            // checkAllChecks
            // 
            this.checkAllChecks.AutoSize = true;
            this.checkAllChecks.Checked = true;
            this.checkAllChecks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAllChecks.Location = new System.Drawing.Point(109, 60);
            this.checkAllChecks.Name = "checkAllChecks";
            this.checkAllChecks.Size = new System.Drawing.Size(56, 17);
            this.checkAllChecks.TabIndex = 16;
            this.checkAllChecks.Text = "Todos";
            this.checkAllChecks.UseVisualStyleBackColor = true;
            this.checkAllChecks.CheckStateChanged += new System.EventHandler(this.checkAllChecks_CheckStateChanged);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkAllChecks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkPhone2);
            this.Controls.Add(this.checkDomicilio);
            this.Controls.Add(this.checkTelefono);
            this.Controls.Add(this.checkRazSocial);
            this.Controls.Add(this.checkNombreMascota);
            this.Controls.Add(this.checkLocalidad);
            this.Controls.Add(this.checkDni);
            this.Controls.Add(this.checkCuit);
            this.Controls.Add(this.checkCorreo);
            this.Controls.Add(this.checkApellido);
            this.Controls.Add(this.checkNombre);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtClients);
            this.Controls.Add(this.dataClients);
            this.Name = "Clients";
            this.Size = new System.Drawing.Size(1446, 550);
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataClients;
        private System.Windows.Forms.TextBox txtClients;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox checkNombre;
        private System.Windows.Forms.CheckBox checkApellido;
        private System.Windows.Forms.CheckBox checkCorreo;
        private System.Windows.Forms.CheckBox checkCuit;
        private System.Windows.Forms.CheckBox checkDni;
        private System.Windows.Forms.CheckBox checkLocalidad;
        private System.Windows.Forms.CheckBox checkNombreMascota;
        private System.Windows.Forms.CheckBox checkRazSocial;
        private System.Windows.Forms.CheckBox checkTelefono;
        private System.Windows.Forms.CheckBox checkDomicilio;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn petname;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonsoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2;
        private System.Windows.Forms.CheckBox checkPhone2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkAllChecks;
    }
}
