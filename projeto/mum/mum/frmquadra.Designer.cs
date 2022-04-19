namespace mum
{
    partial class frmquadra
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
            System.Windows.Forms.Label n__de_quadraLabel;
            System.Windows.Forms.Label quadraLabel;
            System.Windows.Forms.Label caracteristicasLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label dataLabel;
            this.cadastroQBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroDataSet = new mum.cadastroDataSet();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtquadra = new System.Windows.Forms.TextBox();
            this.txtcaracteristicas = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.tpdata = new System.Windows.Forms.DateTimePicker();
            this.cadastroQDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastroQTableAdapter = new mum.cadastroDataSetTableAdapters.CadastroQTableAdapter();
            this.tableAdapterManager = new mum.cadastroDataSetTableAdapters.TableAdapterManager();
            this.btinserir = new System.Windows.Forms.Button();
            this.btsalvar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new mum.cadastroDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            n__de_quadraLabel = new System.Windows.Forms.Label();
            quadraLabel = new System.Windows.Forms.Label();
            caracteristicasLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroQBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroQDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // n__de_quadraLabel
            // 
            n__de_quadraLabel.AutoSize = true;
            n__de_quadraLabel.BackColor = System.Drawing.Color.Transparent;
            n__de_quadraLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            n__de_quadraLabel.ForeColor = System.Drawing.Color.White;
            n__de_quadraLabel.Location = new System.Drawing.Point(29, 46);
            n__de_quadraLabel.Name = "n__de_quadraLabel";
            n__de_quadraLabel.Size = new System.Drawing.Size(93, 15);
            n__de_quadraLabel.TabIndex = 3;
            n__de_quadraLabel.Text = "N° de quadra:";
            // 
            // quadraLabel
            // 
            quadraLabel.AutoSize = true;
            quadraLabel.BackColor = System.Drawing.Color.Transparent;
            quadraLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quadraLabel.ForeColor = System.Drawing.Color.White;
            quadraLabel.Location = new System.Drawing.Point(29, 82);
            quadraLabel.Name = "quadraLabel";
            quadraLabel.Size = new System.Drawing.Size(56, 15);
            quadraLabel.TabIndex = 5;
            quadraLabel.Text = "Quadra:";
            // 
            // caracteristicasLabel
            // 
            caracteristicasLabel.AutoSize = true;
            caracteristicasLabel.BackColor = System.Drawing.Color.Transparent;
            caracteristicasLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            caracteristicasLabel.ForeColor = System.Drawing.Color.White;
            caracteristicasLabel.Location = new System.Drawing.Point(29, 120);
            caracteristicasLabel.Name = "caracteristicasLabel";
            caracteristicasLabel.Size = new System.Drawing.Size(102, 15);
            caracteristicasLabel.TabIndex = 7;
            caracteristicasLabel.Text = "Caracteristicas:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.BackColor = System.Drawing.Color.Transparent;
            valorLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorLabel.ForeColor = System.Drawing.Color.White;
            valorLabel.Location = new System.Drawing.Point(29, 155);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(43, 15);
            valorLabel.TabIndex = 9;
            valorLabel.Text = "Valor:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.BackColor = System.Drawing.Color.Transparent;
            dataLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataLabel.ForeColor = System.Drawing.Color.White;
            dataLabel.Location = new System.Drawing.Point(29, 194);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(39, 15);
            dataLabel.TabIndex = 11;
            dataLabel.Text = "Data:";
            // 
            // cadastroQBindingSource
            // 
            this.cadastroQBindingSource.DataMember = "CadastroQ";
            this.cadastroQBindingSource.DataSource = this.cadastroDataSet;
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "cadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtN
            // 
            this.txtN.BackColor = System.Drawing.SystemColors.Window;
            this.txtN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroQBindingSource, "N° de quadra", true));
            this.txtN.Location = new System.Drawing.Point(137, 44);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(92, 20);
            this.txtN.TabIndex = 4;
            // 
            // txtquadra
            // 
            this.txtquadra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroQBindingSource, "Quadra", true));
            this.txtquadra.Location = new System.Drawing.Point(137, 80);
            this.txtquadra.Name = "txtquadra";
            this.txtquadra.Size = new System.Drawing.Size(1034, 20);
            this.txtquadra.TabIndex = 6;
            // 
            // txtcaracteristicas
            // 
            this.txtcaracteristicas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroQBindingSource, "Caracteristicas", true));
            this.txtcaracteristicas.Location = new System.Drawing.Point(137, 115);
            this.txtcaracteristicas.Name = "txtcaracteristicas";
            this.txtcaracteristicas.Size = new System.Drawing.Size(1034, 20);
            this.txtcaracteristicas.TabIndex = 8;
            // 
            // txtvalor
            // 
            this.txtvalor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroQBindingSource, "Valor", true));
            this.txtvalor.Location = new System.Drawing.Point(137, 153);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(92, 20);
            this.txtvalor.TabIndex = 10;
            // 
            // tpdata
            // 
            this.tpdata.CalendarFont = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpdata.CalendarMonthBackground = System.Drawing.Color.ForestGreen;
            this.tpdata.CalendarTitleBackColor = System.Drawing.Color.ForestGreen;
            this.tpdata.CalendarTitleForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tpdata.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cadastroQBindingSource, "Data", true));
            this.tpdata.Location = new System.Drawing.Point(137, 189);
            this.tpdata.Name = "tpdata";
            this.tpdata.Size = new System.Drawing.Size(227, 20);
            this.tpdata.TabIndex = 12;
            // 
            // cadastroQDataGridView
            // 
            this.cadastroQDataGridView.AllowUserToAddRows = false;
            this.cadastroQDataGridView.AllowUserToDeleteRows = false;
            this.cadastroQDataGridView.AutoGenerateColumns = false;
            this.cadastroQDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.cadastroQDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cadastroQDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.cadastroQDataGridView.DataSource = this.cadastroQBindingSource;
            this.cadastroQDataGridView.Location = new System.Drawing.Point(21, 257);
            this.cadastroQDataGridView.Name = "cadastroQDataGridView";
            this.cadastroQDataGridView.ReadOnly = true;
            this.cadastroQDataGridView.Size = new System.Drawing.Size(1318, 375);
            this.cadastroQDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "N° de quadra";
            this.dataGridViewTextBoxColumn2.HeaderText = "N° de quadra";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quadra";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quadra";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 400;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Caracteristicas";
            this.dataGridViewTextBoxColumn4.HeaderText = "Caracteristicas";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 395;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn5.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 180;
            // 
            // cadastroQTableAdapter
            // 
            this.cadastroQTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CadastroQTableAdapter = this.cadastroQTableAdapter;
            this.tableAdapterManager.UpdateOrder = mum.cadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btinserir
            // 
            this.btinserir.BackColor = System.Drawing.Color.Transparent;
            this.btinserir.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btinserir.FlatAppearance.BorderSize = 2;
            this.btinserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btinserir.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btinserir.ForeColor = System.Drawing.Color.White;
            this.btinserir.Location = new System.Drawing.Point(1235, 44);
            this.btinserir.Name = "btinserir";
            this.btinserir.Size = new System.Drawing.Size(104, 41);
            this.btinserir.TabIndex = 14;
            this.btinserir.Text = "Inserir";
            this.btinserir.UseVisualStyleBackColor = false;
            this.btinserir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.BackColor = System.Drawing.Color.Transparent;
            this.btsalvar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btsalvar.FlatAppearance.BorderSize = 2;
            this.btsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsalvar.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsalvar.ForeColor = System.Drawing.Color.White;
            this.btsalvar.Location = new System.Drawing.Point(1235, 94);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(104, 41);
            this.btsalvar.TabIndex = 15;
            this.btsalvar.Text = "Salvar";
            this.btsalvar.UseVisualStyleBackColor = false;
            this.btsalvar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.BackColor = System.Drawing.Color.Transparent;
            this.btcancelar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btcancelar.FlatAppearance.BorderSize = 2;
            this.btcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcancelar.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.ForeColor = System.Drawing.Color.White;
            this.btcancelar.Location = new System.Drawing.Point(1235, 142);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(104, 41);
            this.btcancelar.TabIndex = 16;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.BackColor = System.Drawing.Color.Transparent;
            this.btexcluir.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btexcluir.FlatAppearance.BorderSize = 2;
            this.btexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btexcluir.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexcluir.ForeColor = System.Drawing.Color.White;
            this.btexcluir.Location = new System.Drawing.Point(1235, 192);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(104, 41);
            this.btexcluir.TabIndex = 17;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = false;
            this.btexcluir.Click += new System.EventHandler(this.button4_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CadastroQTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = mum.cadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::mum.Properties.Resources.botão_desliga;
            this.button1.Location = new System.Drawing.Point(1325, 713);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 22);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // frmquadra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mum.Properties.Resources.Clube_de_tênis_fundo;
            this.ClientSize = new System.Drawing.Size(1370, 747);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.btinserir);
            this.Controls.Add(this.cadastroQDataGridView);
            this.Controls.Add(n__de_quadraLabel);
            this.Controls.Add(this.txtN);
            this.Controls.Add(quadraLabel);
            this.Controls.Add(this.txtquadra);
            this.Controls.Add(caracteristicasLabel);
            this.Controls.Add(this.txtcaracteristicas);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.tpdata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmquadra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Cadastro de quadras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmquadra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroQBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroQDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cadastroDataSet cadastroDataSet;
        private System.Windows.Forms.BindingSource cadastroQBindingSource;
        private cadastroDataSetTableAdapters.CadastroQTableAdapter cadastroQTableAdapter;
        private cadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtquadra;
        private System.Windows.Forms.TextBox txtcaracteristicas;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.DateTimePicker tpdata;
        private System.Windows.Forms.DataGridView cadastroQDataGridView;
        private System.Windows.Forms.Button btinserir;
        private System.Windows.Forms.Button btsalvar;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private cadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button button1;
    }
}