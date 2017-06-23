namespace Entity
{
    partial class GrillaPersonas
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
            this.components = new System.ComponentModel.Container();
            this.contactoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.butAlta = new System.Windows.Forms.Button();
            this.butModif = new System.Windows.Forms.Button();
            this.butElimina = new System.Windows.Forms.Button();
            this.butSalir = new System.Windows.Forms.Button();
            this.comboBoxGrupo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contactoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contactoDataGridView
            // 
            this.contactoDataGridView.AutoGenerateColumns = false;
            this.contactoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.contactoDataGridView.DataSource = this.contactoBindingSource;
            this.contactoDataGridView.Location = new System.Drawing.Point(12, 43);
            this.contactoDataGridView.Name = "contactoDataGridView";
            this.contactoDataGridView.Size = new System.Drawing.Size(542, 220);
            this.contactoDataGridView.TabIndex = 1;
            this.contactoDataGridView.SelectionChanged += new System.EventHandler(this.contactoDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Grupo_Id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Grupo_Id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // contactoBindingSource
            // 
            this.contactoBindingSource.DataSource = typeof(Entity.Contacto);
            // 
            // butAlta
            // 
            this.butAlta.Location = new System.Drawing.Point(576, 24);
            this.butAlta.Name = "butAlta";
            this.butAlta.Size = new System.Drawing.Size(75, 23);
            this.butAlta.TabIndex = 2;
            this.butAlta.Text = "Alta";
            this.butAlta.UseVisualStyleBackColor = true;
            this.butAlta.Click += new System.EventHandler(this.butAlta_Click);
            // 
            // butModif
            // 
            this.butModif.Location = new System.Drawing.Point(576, 63);
            this.butModif.Name = "butModif";
            this.butModif.Size = new System.Drawing.Size(75, 23);
            this.butModif.TabIndex = 3;
            this.butModif.Text = "Modificar";
            this.butModif.UseVisualStyleBackColor = true;
            this.butModif.Click += new System.EventHandler(this.butModif_Click);
            // 
            // butElimina
            // 
            this.butElimina.Location = new System.Drawing.Point(575, 101);
            this.butElimina.Name = "butElimina";
            this.butElimina.Size = new System.Drawing.Size(75, 23);
            this.butElimina.TabIndex = 4;
            this.butElimina.Text = "Eliminar";
            this.butElimina.UseVisualStyleBackColor = true;
            this.butElimina.Click += new System.EventHandler(this.butElimina_Click);
            // 
            // butSalir
            // 
            this.butSalir.Location = new System.Drawing.Point(575, 256);
            this.butSalir.Name = "butSalir";
            this.butSalir.Size = new System.Drawing.Size(75, 23);
            this.butSalir.TabIndex = 5;
            this.butSalir.Text = "Salir";
            this.butSalir.UseVisualStyleBackColor = true;
            this.butSalir.Click += new System.EventHandler(this.butSalir_Click);
            // 
            // comboBoxGrupo
            // 
            this.comboBoxGrupo.FormattingEnabled = true;
            this.comboBoxGrupo.Location = new System.Drawing.Point(12, 12);
            this.comboBoxGrupo.Name = "comboBoxGrupo";
            this.comboBoxGrupo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGrupo.TabIndex = 6;
            this.comboBoxGrupo.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrupo_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // GrillaPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxGrupo);
            this.Controls.Add(this.butSalir);
            this.Controls.Add(this.butElimina);
            this.Controls.Add(this.butModif);
            this.Controls.Add(this.butAlta);
            this.Controls.Add(this.contactoDataGridView);
            this.Name = "GrillaPersonas";
            this.Text = "GrillaPersonas";
            this.Activated += new System.EventHandler(this.GrillaPersonas_Activated);
            this.Load += new System.EventHandler(this.GrillaPersonas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource contactoBindingSource;
        private System.Windows.Forms.DataGridView contactoDataGridView;
        private System.Windows.Forms.Button butAlta;
        private System.Windows.Forms.Button butModif;
        private System.Windows.Forms.Button butElimina;
        private System.Windows.Forms.Button butSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox comboBoxGrupo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}