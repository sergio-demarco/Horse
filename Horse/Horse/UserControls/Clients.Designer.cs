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
            ((System.ComponentModel.ISupportInitialize)(this.dataClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataClients
            // 
            this.dataClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClients.Location = new System.Drawing.Point(23, 83);
            this.dataClients.Name = "dataClients";
            this.dataClients.Size = new System.Drawing.Size(897, 464);
            this.dataClients.TabIndex = 0;
            // 
            // txtClients
            // 
            this.txtClients.Location = new System.Drawing.Point(23, 19);
            this.txtClients.Multiline = true;
            this.txtClients.Name = "txtClients";
            this.txtClients.Size = new System.Drawing.Size(830, 35);
            this.txtClients.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(859, 19);
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
            this.checkNombre.Location = new System.Drawing.Point(23, 60);
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
            this.checkApellido.Location = new System.Drawing.Point(92, 60);
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
            this.checkCorreo.Location = new System.Drawing.Point(542, 60);
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
            this.checkCuit.Location = new System.Drawing.Point(700, 60);
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
            this.checkDni.Location = new System.Drawing.Point(161, 60);
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
            this.checkLocalidad.Location = new System.Drawing.Point(470, 60);
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
            this.checkNombreMascota.Location = new System.Drawing.Point(209, 60);
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
            this.checkRazSocial.Location = new System.Drawing.Point(605, 60);
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
            this.checkTelefono.Location = new System.Drawing.Point(322, 60);
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
            this.checkDomicilio.Location = new System.Drawing.Point(396, 60);
            this.checkDomicilio.Name = "checkDomicilio";
            this.checkDomicilio.Size = new System.Drawing.Size(68, 17);
            this.checkDomicilio.TabIndex = 13;
            this.checkDomicilio.Text = "Domicilio";
            this.checkDomicilio.UseVisualStyleBackColor = true;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Size = new System.Drawing.Size(950, 550);
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
    }
}
