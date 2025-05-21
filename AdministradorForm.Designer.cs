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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdministracion = new System.Windows.Forms.Button();
            this.btnGolesySanciones = new System.Windows.Forms.Button();
            this.btnTablaClasificacion = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnPartidos = new System.Windows.Forms.Button();
            this.btnEquipos = new System.Windows.Forms.Button();
            this.bdCompleta = new Administrador.bdCompleta();
            this.bdCompletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdCompletaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.equiposdb = new Administrador.Equiposdb();
            this.equiposdbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equiposFindb = new Administrador.EquiposFindb();
            this.equiposBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.equiposTableAdapter = new Administrador.EquiposFindbTableAdapters.EquiposTableAdapter();
            this.db2025 = new Administrador.db2025();
            this.equiposBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.equiposTableAdapter1 = new Administrador.db2025TableAdapters.EquiposTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdCompleta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCompletaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCompletaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposdb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposdbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposFindb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db2025)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarEquipo
            // 
            this.btnAgregarEquipo.BackColor = System.Drawing.Color.White;
            this.btnAgregarEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarEquipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarEquipo.Location = new System.Drawing.Point(4, 156);
            this.btnAgregarEquipo.Name = "btnAgregarEquipo";
            this.btnAgregarEquipo.Size = new System.Drawing.Size(96, 35);
            this.btnAgregarEquipo.TabIndex = 3;
            this.btnAgregarEquipo.Text = "Agregar";
            this.btnAgregarEquipo.UseVisualStyleBackColor = false;
            this.btnAgregarEquipo.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre equipo";
            // 
            // txtNomEquipo
            // 
            this.txtNomEquipo.Location = new System.Drawing.Point(6, 40);
            this.txtNomEquipo.Name = "txtNomEquipo";
            this.txtNomEquipo.Size = new System.Drawing.Size(199, 20);
            this.txtNomEquipo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
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
            this.groupBox1.Location = new System.Drawing.Point(213, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 199);
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
            this.btnEliminarEquipo.Location = new System.Drawing.Point(109, 156);
            this.btnEliminarEquipo.Name = "btnEliminarEquipo";
            this.btnEliminarEquipo.Size = new System.Drawing.Size(96, 35);
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
            this.CargarImagen.Location = new System.Drawing.Point(156, 100);
            this.CargarImagen.Name = "CargarImagen";
            this.CargarImagen.Size = new System.Drawing.Size(49, 22);
            this.CargarImagen.TabIndex = 8;
            this.CargarImagen.Text = "Cargar";
            this.CargarImagen.UseVisualStyleBackColor = false;
            // 
            // txtlogo
            // 
            this.txtlogo.Location = new System.Drawing.Point(4, 102);
            this.txtlogo.Name = "txtlogo";
            this.txtlogo.Size = new System.Drawing.Size(146, 20);
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
            this.groupBox3.Location = new System.Drawing.Point(213, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 199);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Jugador";
            // 
            // CBequipo
            // 
            this.CBequipo.DataSource = this.equiposBindingSource2;
            this.CBequipo.DisplayMember = "Nombre";
            this.CBequipo.FormattingEnabled = true;
            this.CBequipo.Location = new System.Drawing.Point(6, 129);
            this.CBequipo.Name = "CBequipo";
            this.CBequipo.Size = new System.Drawing.Size(199, 21);
            this.CBequipo.TabIndex = 10;
            this.CBequipo.ValueMember = "id";
            this.CBequipo.SelectedIndexChanged += new System.EventHandler(this.CBequipo_SelectedIndexChanged);
            // 
            // equiposBindingSource
            // 
            this.equiposBindingSource.DataMember = "Equipos";
            // 
            // txtNumJugador
            // 
            this.txtNumJugador.Location = new System.Drawing.Point(8, 84);
            this.txtNumJugador.Name = "txtNumJugador";
            this.txtNumJugador.Size = new System.Drawing.Size(197, 20);
            this.txtNumJugador.TabIndex = 11;
            this.txtNumJugador.TextChanged += new System.EventHandler(this.txtNumJugador_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Numero jugador";
            // 
            // btnEliminarJugador
            // 
            this.btnEliminarJugador.BackColor = System.Drawing.Color.White;
            this.btnEliminarJugador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarJugador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarJugador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarJugador.Location = new System.Drawing.Point(109, 156);
            this.btnEliminarJugador.Name = "btnEliminarJugador";
            this.btnEliminarJugador.Size = new System.Drawing.Size(96, 35);
            this.btnEliminarJugador.TabIndex = 9;
            this.btnEliminarJugador.Text = "Eliminar";
            this.btnEliminarJugador.UseVisualStyleBackColor = false;
            // 
            // txtNombJugador
            // 
            this.txtNombJugador.Location = new System.Drawing.Point(6, 40);
            this.txtNombJugador.Name = "txtNombJugador";
            this.txtNombJugador.Size = new System.Drawing.Size(199, 20);
            this.txtNombJugador.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Equipo Equipo";
            // 
            // btnAgregarJugador
            // 
            this.btnAgregarJugador.BackColor = System.Drawing.Color.White;
            this.btnAgregarJugador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarJugador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarJugador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarJugador.Location = new System.Drawing.Point(4, 156);
            this.btnAgregarJugador.Name = "btnAgregarJugador";
            this.btnAgregarJugador.Size = new System.Drawing.Size(96, 35);
            this.btnAgregarJugador.TabIndex = 3;
            this.btnAgregarJugador.Text = "Agregar";
            this.btnAgregarJugador.UseVisualStyleBackColor = false;
            this.btnAgregarJugador.Click += new System.EventHandler(this.button11_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre jugador";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.logoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.equiposBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(439, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(349, 369);
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
            this.btnEquipoSiguiente.Location = new System.Drawing.Point(681, 12);
            this.btnEquipoSiguiente.Name = "btnEquipoSiguiente";
            this.btnEquipoSiguiente.Size = new System.Drawing.Size(107, 35);
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
            this.btnEquipoAnterior.Location = new System.Drawing.Point(439, 12);
            this.btnEquipoAnterior.Name = "btnEquipoAnterior";
            this.btnEquipoAnterior.Size = new System.Drawing.Size(107, 35);
            this.btnEquipoAnterior.TabIndex = 11;
            this.btnEquipoAnterior.Text = "Equipo anterior";
            this.btnEquipoAnterior.UseVisualStyleBackColor = false;
            this.btnEquipoAnterior.Click += new System.EventHandler(this.btnEquipoAnterior_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdministracion);
            this.groupBox2.Controls.Add(this.btnGolesySanciones);
            this.groupBox2.Controls.Add(this.btnTablaClasificacion);
            this.groupBox2.Controls.Add(this.btnMenu);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(20, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 192);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // btnAdministracion
            // 
            this.btnAdministracion.BackColor = System.Drawing.Color.LightGray;
            this.btnAdministracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdministracion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdministracion.Location = new System.Drawing.Point(8, 102);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Size = new System.Drawing.Size(162, 35);
            this.btnAdministracion.TabIndex = 5;
            this.btnAdministracion.Text = "Administrador";
            this.btnAdministracion.UseVisualStyleBackColor = false;
            this.btnAdministracion.Click += new System.EventHandler(this.btnAdministracion_Click);
            // 
            // btnGolesySanciones
            // 
            this.btnGolesySanciones.BackColor = System.Drawing.Color.White;
            this.btnGolesySanciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGolesySanciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGolesySanciones.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGolesySanciones.Location = new System.Drawing.Point(8, 143);
            this.btnGolesySanciones.Name = "btnGolesySanciones";
            this.btnGolesySanciones.Size = new System.Drawing.Size(162, 35);
            this.btnGolesySanciones.TabIndex = 2;
            this.btnGolesySanciones.Text = "Goles y Sanciones";
            this.btnGolesySanciones.UseVisualStyleBackColor = false;
            this.btnGolesySanciones.Click += new System.EventHandler(this.btnGolesySanciones_Click);
            // 
            // btnTablaClasificacion
            // 
            this.btnTablaClasificacion.BackColor = System.Drawing.Color.White;
            this.btnTablaClasificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTablaClasificacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTablaClasificacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTablaClasificacion.Location = new System.Drawing.Point(8, 60);
            this.btnTablaClasificacion.Name = "btnTablaClasificacion";
            this.btnTablaClasificacion.Size = new System.Drawing.Size(162, 35);
            this.btnTablaClasificacion.TabIndex = 1;
            this.btnTablaClasificacion.Text = "Clasificacion";
            this.btnTablaClasificacion.UseVisualStyleBackColor = false;
            this.btnTablaClasificacion.Click += new System.EventHandler(this.btnTablaClasificacion_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMenu.Location = new System.Drawing.Point(8, 19);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(162, 35);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Inicio";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnPartidos);
            this.groupBox5.Controls.Add(this.btnEquipos);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(20, 223);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(176, 128);
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
            this.btnPartidos.Location = new System.Drawing.Point(8, 78);
            this.btnPartidos.Name = "btnPartidos";
            this.btnPartidos.Size = new System.Drawing.Size(162, 35);
            this.btnPartidos.TabIndex = 2;
            this.btnPartidos.Text = "Administrar partidos";
            this.btnPartidos.UseVisualStyleBackColor = false;
            this.btnPartidos.Click += new System.EventHandler(this.btnPartidos_Click);
            // 
            // btnEquipos
            // 
            this.btnEquipos.BackColor = System.Drawing.Color.White;
            this.btnEquipos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEquipos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEquipos.Location = new System.Drawing.Point(8, 19);
            this.btnEquipos.Name = "btnEquipos";
            this.btnEquipos.Size = new System.Drawing.Size(162, 35);
            this.btnEquipos.TabIndex = 0;
            this.btnEquipos.Text = "Agregar equipo y Jugadores";
            this.btnEquipos.UseVisualStyleBackColor = false;
            // 
            // bdCompleta
            // 
            this.bdCompleta.DataSetName = "bdCompleta";
            this.bdCompleta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdCompletaBindingSource
            // 
            this.bdCompletaBindingSource.DataSource = this.bdCompleta;
            this.bdCompletaBindingSource.Position = 0;
            // 
            // bdCompletaBindingSource1
            // 
            this.bdCompletaBindingSource1.DataSource = this.bdCompleta;
            this.bdCompletaBindingSource1.Position = 0;
            // 
            // equiposdb
            // 
            this.equiposdb.DataSetName = "Equiposdb";
            this.equiposdb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equiposdbBindingSource
            // 
            this.equiposdbBindingSource.DataSource = this.equiposdb;
            this.equiposdbBindingSource.Position = 0;
            // 
            // equiposFindb
            // 
            this.equiposFindb.DataSetName = "EquiposFindb";
            this.equiposFindb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equiposBindingSource2
            // 
            this.equiposBindingSource2.DataMember = "Equipos";
            this.equiposBindingSource2.DataSource = this.equiposFindb;
            // 
            // equiposTableAdapter
            // 
            this.equiposTableAdapter.ClearBeforeFill = true;
            // 
            // db2025
            // 
            this.db2025.DataSetName = "db2025";
            this.db2025.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equiposBindingSource3
            // 
            this.equiposBindingSource3.DataMember = "Equipos";
            this.equiposBindingSource3.DataSource = this.db2025;
            // 
            // equiposTableAdapter1
            // 
            this.equiposTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // logoDataGridViewTextBoxColumn
            // 
            this.logoDataGridViewTextBoxColumn.DataPropertyName = "Logo";
            this.logoDataGridViewTextBoxColumn.HeaderText = "Logo";
            this.logoDataGridViewTextBoxColumn.Name = "logoDataGridViewTextBoxColumn";
            // 
            // AdministradorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEquipoSiguiente);
            this.Controls.Add(this.btnEquipoAnterior);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdministradorForm";
            this.Text = "Administracion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministradorForm_FormClosing);
            this.Load += new System.EventHandler(this.AdministradorForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdCompleta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCompletaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCompletaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposdb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposdbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposFindb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db2025)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource3)).EndInit();
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
        private System.Windows.Forms.BindingSource equiposBindingSource;
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
        private System.Windows.Forms.BindingSource equiposdbBindingSource;
        private Equiposdb equiposdb;
        private bdCompleta bdCompleta;
        private System.Windows.Forms.BindingSource bdCompletaBindingSource;
        private System.Windows.Forms.BindingSource bdCompletaBindingSource1;
        private EquiposFindb equiposFindb;
        private System.Windows.Forms.BindingSource equiposBindingSource2;
        private EquiposFindbTableAdapters.EquiposTableAdapter equiposTableAdapter;
        private db2025 db2025;
        private System.Windows.Forms.BindingSource equiposBindingSource3;
        private db2025TableAdapters.EquiposTableAdapter equiposTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn logoDataGridViewTextBoxColumn;
    }
}

