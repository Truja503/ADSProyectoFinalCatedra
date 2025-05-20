namespace Administrador
{
    partial class AdministradorForm
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAgregarEquipo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomEquipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarEquipo = new System.Windows.Forms.Button();
            this.CargarImagen = new System.Windows.Forms.Button();
            this.txtlogo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CBequipo = new System.Windows.Forms.ComboBox();
            this.equiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.torneoMontesSanBartoloDataSet2 = new Administrador.TorneoMontesSanBartoloDataSet2();
            this.txtNumJugador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminarJugador = new System.Windows.Forms.Button();
            this.txtNombJugador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarJugador = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.equiposBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnEquipoSiguiente = new System.Windows.Forms.Button();
            this.btnEquipoAnterior = new System.Windows.Forms.Button();
            this.equiposTableAdapter = new Administrador.TorneoMontesSanBartoloDataSet2TableAdapters.EquiposTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdministracion = new System.Windows.Forms.Button();
            this.btnGolesySanciones = new System.Windows.Forms.Button();
            this.btnTablaClasificacion = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnPartidos = new System.Windows.Forms.Button();
            this.btnEquipos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.torneoMontesSanBartoloDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarEquipo
            // 
            this.btnAgregarEquipo.BackColor = System.Drawing.Color.White;
            this.btnAgregarEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarEquipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarEquipo.Location = new System.Drawing.Point(5, 192);
            this.btnAgregarEquipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarEquipo.Name = "btnAgregarEquipo";
            this.btnAgregarEquipo.Size = new System.Drawing.Size(128, 43);
            this.btnAgregarEquipo.TabIndex = 3;
            this.btnAgregarEquipo.Text = "Agregar";
            this.btnAgregarEquipo.UseVisualStyleBackColor = false;
            this.btnAgregarEquipo.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre equipo";
            // 
            // txtNomEquipo
            // 
            this.txtNomEquipo.Location = new System.Drawing.Point(8, 49);
            this.txtNomEquipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomEquipo.Name = "txtNomEquipo";
            this.txtNomEquipo.Size = new System.Drawing.Size(264, 22);
            this.txtNomEquipo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Logo Equipo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminarEquipo);
            this.groupBox1.Controls.Add(this.CargarImagen);
            this.groupBox1.Controls.Add(this.txtlogo);
            this.groupBox1.Controls.Add(this.txtNomEquipo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAgregarEquipo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(284, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(281, 245);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipo";
            // 
            // btnEliminarEquipo
            // 
            this.btnEliminarEquipo.BackColor = System.Drawing.Color.White;
            this.btnEliminarEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarEquipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarEquipo.Location = new System.Drawing.Point(145, 192);
            this.btnEliminarEquipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarEquipo.Name = "btnEliminarEquipo";
            this.btnEliminarEquipo.Size = new System.Drawing.Size(128, 43);
            this.btnEliminarEquipo.TabIndex = 9;
            this.btnEliminarEquipo.Text = "Eliminar";
            this.btnEliminarEquipo.UseVisualStyleBackColor = false;
            // 
            // CargarImagen
            // 
            this.CargarImagen.BackColor = System.Drawing.Color.White;
            this.CargarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CargarImagen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CargarImagen.Location = new System.Drawing.Point(208, 123);
            this.CargarImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CargarImagen.Name = "CargarImagen";
            this.CargarImagen.Size = new System.Drawing.Size(65, 27);
            this.CargarImagen.TabIndex = 8;
            this.CargarImagen.Text = "Cargar";
            this.CargarImagen.UseVisualStyleBackColor = false;
            // 
            // txtlogo
            // 
            this.txtlogo.Location = new System.Drawing.Point(5, 126);
            this.txtlogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtlogo.Name = "txtlogo";
            this.txtlogo.Size = new System.Drawing.Size(193, 22);
            this.txtlogo.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CBequipo);
            this.groupBox3.Controls.Add(this.txtNumJugador);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnEliminarJugador);
            this.groupBox3.Controls.Add(this.txtNombJugador);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnAgregarJugador);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(284, 274);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(281, 245);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Jugador";
            // 
            // CBequipo
            // 
            this.CBequipo.DataSource = this.equiposBindingSource;
            this.CBequipo.DisplayMember = "Nombre";
            this.CBequipo.FormattingEnabled = true;
            this.CBequipo.Location = new System.Drawing.Point(8, 159);
            this.CBequipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBequipo.Name = "CBequipo";
            this.CBequipo.Size = new System.Drawing.Size(264, 24);
            this.CBequipo.TabIndex = 10;
            this.CBequipo.ValueMember = "EquipoID";
            // 
            // equiposBindingSource
            // 
            this.equiposBindingSource.DataMember = "Equipos";
            this.equiposBindingSource.DataSource = this.torneoMontesSanBartoloDataSet2;
            // 
            // torneoMontesSanBartoloDataSet2
            // 
            this.torneoMontesSanBartoloDataSet2.DataSetName = "TorneoMontesSanBartoloDataSet2";
            this.torneoMontesSanBartoloDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNumJugador
            // 
            this.txtNumJugador.Location = new System.Drawing.Point(11, 103);
            this.txtNumJugador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumJugador.Name = "txtNumJugador";
            this.txtNumJugador.Size = new System.Drawing.Size(261, 22);
            this.txtNumJugador.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Numero jugador";
            // 
            // btnEliminarJugador
            // 
            this.btnEliminarJugador.BackColor = System.Drawing.Color.White;
            this.btnEliminarJugador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarJugador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarJugador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarJugador.Location = new System.Drawing.Point(145, 192);
            this.btnEliminarJugador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarJugador.Name = "btnEliminarJugador";
            this.btnEliminarJugador.Size = new System.Drawing.Size(128, 43);
            this.btnEliminarJugador.TabIndex = 9;
            this.btnEliminarJugador.Text = "Eliminar";
            this.btnEliminarJugador.UseVisualStyleBackColor = false;
            // 
            // txtNombJugador
            // 
            this.txtNombJugador.Location = new System.Drawing.Point(8, 49);
            this.txtNombJugador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombJugador.Name = "txtNombJugador";
            this.txtNombJugador.Size = new System.Drawing.Size(264, 22);
            this.txtNombJugador.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Equipo Equipo";
            // 
            // btnAgregarJugador
            // 
            this.btnAgregarJugador.BackColor = System.Drawing.Color.White;
            this.btnAgregarJugador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarJugador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarJugador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarJugador.Location = new System.Drawing.Point(5, 192);
            this.btnAgregarJugador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarJugador.Name = "btnAgregarJugador";
            this.btnAgregarJugador.Size = new System.Drawing.Size(128, 43);
            this.btnAgregarJugador.TabIndex = 3;
            this.btnAgregarJugador.Text = "Agregar";
            this.btnAgregarJugador.UseVisualStyleBackColor = false;
            this.btnAgregarJugador.Click += new System.EventHandler(this.button11_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre jugador";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.equiposBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(585, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(465, 454);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // equiposBindingSource1
            // 
            this.equiposBindingSource1.DataMember = "Equipos";
            // 
            // btnEquipoSiguiente
            // 
            this.btnEquipoSiguiente.BackColor = System.Drawing.Color.White;
            this.btnEquipoSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEquipoSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEquipoSiguiente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEquipoSiguiente.Location = new System.Drawing.Point(908, 15);
            this.btnEquipoSiguiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEquipoSiguiente.Name = "btnEquipoSiguiente";
            this.btnEquipoSiguiente.Size = new System.Drawing.Size(143, 43);
            this.btnEquipoSiguiente.TabIndex = 12;
            this.btnEquipoSiguiente.Text = "Siguiente equipo\r\n";
            this.btnEquipoSiguiente.UseVisualStyleBackColor = false;
            // 
            // btnEquipoAnterior
            // 
            this.btnEquipoAnterior.BackColor = System.Drawing.Color.White;
            this.btnEquipoAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEquipoAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEquipoAnterior.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEquipoAnterior.Location = new System.Drawing.Point(585, 15);
            this.btnEquipoAnterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEquipoAnterior.Name = "btnEquipoAnterior";
            this.btnEquipoAnterior.Size = new System.Drawing.Size(143, 43);
            this.btnEquipoAnterior.TabIndex = 11;
            this.btnEquipoAnterior.Text = "Equipo anterior";
            this.btnEquipoAnterior.UseVisualStyleBackColor = false;
            // 
            // equiposTableAdapter
            // 
            this.equiposTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdministracion);
            this.groupBox2.Controls.Add(this.btnGolesySanciones);
            this.groupBox2.Controls.Add(this.btnTablaClasificacion);
            this.groupBox2.Controls.Add(this.btnMenu);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(27, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(235, 236);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // btnAdministracion
            // 
            this.btnAdministracion.BackColor = System.Drawing.Color.White;
            this.btnAdministracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdministracion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdministracion.Location = new System.Drawing.Point(11, 126);
            this.btnAdministracion.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Size = new System.Drawing.Size(216, 43);
            this.btnAdministracion.TabIndex = 5;
            this.btnAdministracion.Text = "Administrador";
            this.btnAdministracion.UseVisualStyleBackColor = false;
            // 
            // btnGolesySanciones
            // 
            this.btnGolesySanciones.BackColor = System.Drawing.Color.LightGray;
            this.btnGolesySanciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGolesySanciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGolesySanciones.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGolesySanciones.Location = new System.Drawing.Point(11, 176);
            this.btnGolesySanciones.Margin = new System.Windows.Forms.Padding(4);
            this.btnGolesySanciones.Name = "btnGolesySanciones";
            this.btnGolesySanciones.Size = new System.Drawing.Size(216, 43);
            this.btnGolesySanciones.TabIndex = 2;
            this.btnGolesySanciones.Text = "Goles y Sanciones";
            this.btnGolesySanciones.UseVisualStyleBackColor = false;
            // 
            // btnTablaClasificacion
            // 
            this.btnTablaClasificacion.BackColor = System.Drawing.Color.White;
            this.btnTablaClasificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTablaClasificacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTablaClasificacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTablaClasificacion.Location = new System.Drawing.Point(11, 74);
            this.btnTablaClasificacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnTablaClasificacion.Name = "btnTablaClasificacion";
            this.btnTablaClasificacion.Size = new System.Drawing.Size(216, 43);
            this.btnTablaClasificacion.TabIndex = 1;
            this.btnTablaClasificacion.Text = "Clasificacion";
            this.btnTablaClasificacion.UseVisualStyleBackColor = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMenu.Location = new System.Drawing.Point(11, 23);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(216, 43);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Inicio";
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnPartidos);
            this.groupBox5.Controls.Add(this.btnEquipos);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(27, 274);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(235, 158);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Menu";
            // 
            // btnPartidos
            // 
            this.btnPartidos.BackColor = System.Drawing.Color.White;
            this.btnPartidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPartidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPartidos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPartidos.Location = new System.Drawing.Point(11, 96);
            this.btnPartidos.Margin = new System.Windows.Forms.Padding(4);
            this.btnPartidos.Name = "btnPartidos";
            this.btnPartidos.Size = new System.Drawing.Size(216, 43);
            this.btnPartidos.TabIndex = 2;
            this.btnPartidos.Text = "Administrar partidos";
            this.btnPartidos.UseVisualStyleBackColor = false;
            // 
            // btnEquipos
            // 
            this.btnEquipos.BackColor = System.Drawing.Color.White;
            this.btnEquipos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEquipos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEquipos.Location = new System.Drawing.Point(11, 23);
            this.btnEquipos.Margin = new System.Windows.Forms.Padding(4);
            this.btnEquipos.Name = "btnEquipos";
            this.btnEquipos.Size = new System.Drawing.Size(216, 43);
            this.btnEquipos.TabIndex = 0;
            this.btnEquipos.Text = "Agregar equipo y Jugadores";
            this.btnEquipos.UseVisualStyleBackColor = false;
            // 
            // AdministradorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEquipoSiguiente);
            this.Controls.Add(this.btnEquipoAnterior);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdministradorForm";
            this.Text = "Administracion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministradorForm_FormClosing);
            this.Load += new System.EventHandler(this.AdministradorForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.torneoMontesSanBartoloDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarEquipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomEquipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminarEquipo;
        private System.Windows.Forms.Button CargarImagen;
        private System.Windows.Forms.TextBox txtlogo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNumJugador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminarJugador;
        private System.Windows.Forms.TextBox txtNombJugador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarJugador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBequipo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEquipoSiguiente;
        private System.Windows.Forms.Button btnEquipoAnterior;
        private TorneoMontesSanBartoloDataSet2 torneoMontesSanBartoloDataSet2;
        private System.Windows.Forms.BindingSource equiposBindingSource;
        private TorneoMontesSanBartoloDataSet2TableAdapters.EquiposTableAdapter equiposTableAdapter;
        private System.Windows.Forms.BindingSource equiposBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn logoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdministracion;
        private System.Windows.Forms.Button btnGolesySanciones;
        private System.Windows.Forms.Button btnTablaClasificacion;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnPartidos;
        private System.Windows.Forms.Button btnEquipos;
    }
}

