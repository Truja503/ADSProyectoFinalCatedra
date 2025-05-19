namespace Administrador
{
    partial class ClasificacionPartidosForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.torneoMontesSanBartoloDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.torneoMontesSanBartoloDataSet4 = new Administrador.TorneoMontesSanBartoloDataSet4();
            this.clasificacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clasificacionTableAdapter = new Administrador.TorneoMontesSanBartoloDataSet4TableAdapters.ClasificacionTableAdapter();
            this.equipoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.torneoMontesSanBartoloDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.torneoMontesSanBartoloDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasificacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Location = new System.Drawing.Point(206, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 426);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Posiciones";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipoIDDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.pJDataGridViewTextBoxColumn,
            this.pGDataGridViewTextBoxColumn,
            this.pEDataGridViewTextBoxColumn,
            this.pPDataGridViewTextBoxColumn,
            this.gFDataGridViewTextBoxColumn,
            this.gCDataGridViewTextBoxColumn,
            this.dGDataGridViewTextBoxColumn,
            this.puntosDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clasificacionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(571, 362);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(417, 17);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(162, 35);
            this.button7.TabIndex = 7;
            this.button7.Text = "Administrador siguientes";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(6, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(162, 35);
            this.button6.TabIndex = 6;
            this.button6.Text = "Administrador Anteriores";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(10, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 252);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(8, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 35);
            this.button4.TabIndex = 5;
            this.button4.Text = "Administrador";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(8, 211);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(162, 35);
            this.button5.TabIndex = 4;
            this.button5.Text = "Administrar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(8, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Goles y Sanciones";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(8, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clasificacion";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(8, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inicio";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // torneoMontesSanBartoloDataSet1
            // 
            // 
            // torneoMontesSanBartoloDataSet1BindingSource
            // 
            this.torneoMontesSanBartoloDataSet1BindingSource.Position = 0;
            // 
            // torneoMontesSanBartoloDataSet4
            // 
            this.torneoMontesSanBartoloDataSet4.DataSetName = "TorneoMontesSanBartoloDataSet4";
            this.torneoMontesSanBartoloDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clasificacionBindingSource
            // 
            this.clasificacionBindingSource.DataMember = "Clasificacion";
            this.clasificacionBindingSource.DataSource = this.torneoMontesSanBartoloDataSet4;
            // 
            // clasificacionTableAdapter
            // 
            this.clasificacionTableAdapter.ClearBeforeFill = true;
            // 
            // equipoIDDataGridViewTextBoxColumn
            // 
            this.equipoIDDataGridViewTextBoxColumn.DataPropertyName = "EquipoID";
            this.equipoIDDataGridViewTextBoxColumn.HeaderText = "EquipoID";
            this.equipoIDDataGridViewTextBoxColumn.Name = "equipoIDDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // pJDataGridViewTextBoxColumn
            // 
            this.pJDataGridViewTextBoxColumn.DataPropertyName = "PJ";
            this.pJDataGridViewTextBoxColumn.HeaderText = "PJ";
            this.pJDataGridViewTextBoxColumn.Name = "pJDataGridViewTextBoxColumn";
            // 
            // pGDataGridViewTextBoxColumn
            // 
            this.pGDataGridViewTextBoxColumn.DataPropertyName = "PG";
            this.pGDataGridViewTextBoxColumn.HeaderText = "PG";
            this.pGDataGridViewTextBoxColumn.Name = "pGDataGridViewTextBoxColumn";
            // 
            // pEDataGridViewTextBoxColumn
            // 
            this.pEDataGridViewTextBoxColumn.DataPropertyName = "PE";
            this.pEDataGridViewTextBoxColumn.HeaderText = "PE";
            this.pEDataGridViewTextBoxColumn.Name = "pEDataGridViewTextBoxColumn";
            // 
            // pPDataGridViewTextBoxColumn
            // 
            this.pPDataGridViewTextBoxColumn.DataPropertyName = "PP";
            this.pPDataGridViewTextBoxColumn.HeaderText = "PP";
            this.pPDataGridViewTextBoxColumn.Name = "pPDataGridViewTextBoxColumn";
            // 
            // gFDataGridViewTextBoxColumn
            // 
            this.gFDataGridViewTextBoxColumn.DataPropertyName = "GF";
            this.gFDataGridViewTextBoxColumn.HeaderText = "GF";
            this.gFDataGridViewTextBoxColumn.Name = "gFDataGridViewTextBoxColumn";
            // 
            // gCDataGridViewTextBoxColumn
            // 
            this.gCDataGridViewTextBoxColumn.DataPropertyName = "GC";
            this.gCDataGridViewTextBoxColumn.HeaderText = "GC";
            this.gCDataGridViewTextBoxColumn.Name = "gCDataGridViewTextBoxColumn";
            // 
            // dGDataGridViewTextBoxColumn
            // 
            this.dGDataGridViewTextBoxColumn.DataPropertyName = "DG";
            this.dGDataGridViewTextBoxColumn.HeaderText = "DG";
            this.dGDataGridViewTextBoxColumn.Name = "dGDataGridViewTextBoxColumn";
            // 
            // puntosDataGridViewTextBoxColumn
            // 
            this.puntosDataGridViewTextBoxColumn.DataPropertyName = "Puntos";
            this.puntosDataGridViewTextBoxColumn.HeaderText = "Puntos";
            this.puntosDataGridViewTextBoxColumn.Name = "puntosDataGridViewTextBoxColumn";
            // 
            // ClasificacionPartidosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ClasificacionPartidosForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClasificacionPartidosForm_FormClosing);
            this.Load += new System.EventHandler(this.ClasificacionPartidosForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.torneoMontesSanBartoloDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.torneoMontesSanBartoloDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasificacionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource torneoMontesSanBartoloDataSet1BindingSource;
        private TorneoMontesSanBartoloDataSet4 torneoMontesSanBartoloDataSet4;
        private System.Windows.Forms.BindingSource clasificacionBindingSource;
        private TorneoMontesSanBartoloDataSet4TableAdapters.ClasificacionTableAdapter clasificacionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntosDataGridViewTextBoxColumn;
    }
}

