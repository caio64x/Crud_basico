namespace SGC_Winform
{
    partial class ClienteListarForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cabecalhoPanel = new System.Windows.Forms.Panel();
            this.buscarButton = new System.Windows.Forms.Button();
            this.filtroTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rodapePanel = new System.Windows.Forms.Panel();
            this.quantidadeLabel = new System.Windows.Forms.Label();
            this.botoesPanel = new System.Windows.Forms.Panel();
            this.fecharButton = new System.Windows.Forms.Button();
            this.incluirButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.meiopanel = new System.Windows.Forms.Panel();
            this.listaDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcidadeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabecalhoPanel.SuspendLayout();
            this.rodapePanel.SuspendLayout();
            this.botoesPanel.SuspendLayout();
            this.meiopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cabecalhoPanel
            // 
            this.cabecalhoPanel.Controls.Add(this.buscarButton);
            this.cabecalhoPanel.Controls.Add(this.filtroTextBox);
            this.cabecalhoPanel.Controls.Add(this.label1);
            this.cabecalhoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cabecalhoPanel.Location = new System.Drawing.Point(0, 0);
            this.cabecalhoPanel.Name = "cabecalhoPanel";
            this.cabecalhoPanel.Size = new System.Drawing.Size(1363, 100);
            this.cabecalhoPanel.TabIndex = 0;
            // 
            // buscarButton
            // 
            this.buscarButton.Image = global::SGC_Winform.Properties.Resources.Buscar;
            this.buscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarButton.Location = new System.Drawing.Point(345, 30);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 2;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // filtroTextBox
            // 
            this.filtroTextBox.Location = new System.Drawing.Point(16, 32);
            this.filtroTextBox.Name = "filtroTextBox";
            this.filtroTextBox.Size = new System.Drawing.Size(323, 20);
            this.filtroTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Nome";
            // 
            // rodapePanel
            // 
            this.rodapePanel.Controls.Add(this.quantidadeLabel);
            this.rodapePanel.Controls.Add(this.botoesPanel);
            this.rodapePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rodapePanel.Location = new System.Drawing.Point(0, 550);
            this.rodapePanel.Name = "rodapePanel";
            this.rodapePanel.Size = new System.Drawing.Size(1363, 66);
            this.rodapePanel.TabIndex = 1;
            // 
            // quantidadeLabel
            // 
            this.quantidadeLabel.AutoSize = true;
            this.quantidadeLabel.Location = new System.Drawing.Point(13, 26);
            this.quantidadeLabel.Name = "quantidadeLabel";
            this.quantidadeLabel.Size = new System.Drawing.Size(84, 13);
            this.quantidadeLabel.TabIndex = 3;
            this.quantidadeLabel.Text = "Nenhum registro";
            // 
            // botoesPanel
            // 
            this.botoesPanel.Controls.Add(this.fecharButton);
            this.botoesPanel.Controls.Add(this.incluirButton);
            this.botoesPanel.Controls.Add(this.excluirButton);
            this.botoesPanel.Controls.Add(this.alterarButton);
            this.botoesPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.botoesPanel.Location = new System.Drawing.Point(986, 0);
            this.botoesPanel.Name = "botoesPanel";
            this.botoesPanel.Size = new System.Drawing.Size(377, 66);
            this.botoesPanel.TabIndex = 2;
            // 
            // fecharButton
            // 
            this.fecharButton.Image = global::SGC_Winform.Properties.Resources.sair;
            this.fecharButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fecharButton.Location = new System.Drawing.Point(286, 21);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(79, 23);
            this.fecharButton.TabIndex = 6;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.UseVisualStyleBackColor = true;
            this.fecharButton.Click += new System.EventHandler(this.fecharButton_Click);
            // 
            // incluirButton
            // 
            this.incluirButton.Image = global::SGC_Winform.Properties.Resources.Novo;
            this.incluirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incluirButton.Location = new System.Drawing.Point(43, 21);
            this.incluirButton.Name = "incluirButton";
            this.incluirButton.Size = new System.Drawing.Size(79, 23);
            this.incluirButton.TabIndex = 5;
            this.incluirButton.Text = "Incluir";
            this.incluirButton.UseVisualStyleBackColor = true;
            this.incluirButton.Click += new System.EventHandler(this.incluirButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Image = global::SGC_Winform.Properties.Resources.Fechar;
            this.excluirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.excluirButton.Location = new System.Drawing.Point(205, 21);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(79, 23);
            this.excluirButton.TabIndex = 3;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // alterarButton
            // 
            this.alterarButton.Image = global::SGC_Winform.Properties.Resources.Auto;
            this.alterarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alterarButton.Location = new System.Drawing.Point(124, 21);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(79, 23);
            this.alterarButton.TabIndex = 4;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = true;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // meiopanel
            // 
            this.meiopanel.Controls.Add(this.listaDataGridView);
            this.meiopanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meiopanel.Location = new System.Drawing.Point(0, 100);
            this.meiopanel.Name = "meiopanel";
            this.meiopanel.Size = new System.Drawing.Size(1363, 450);
            this.meiopanel.TabIndex = 2;
            // 
            // listaDataGridView
            // 
            this.listaDataGridView.AllowUserToAddRows = false;
            this.listaDataGridView.AllowUserToDeleteRows = false;
            this.listaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nomeColumn,
            this.enderecoColumn,
            this.idcidadeColumn,
            this.cidadeColumn,
            this.bairroColumn,
            this.dataNascimentoColumn});
            this.listaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaDataGridView.Location = new System.Drawing.Point(0, 0);
            this.listaDataGridView.Name = "listaDataGridView";
            this.listaDataGridView.ReadOnly = true;
            this.listaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaDataGridView.Size = new System.Drawing.Size(1363, 450);
            this.listaDataGridView.TabIndex = 0;
            this.listaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaDataGridView_CellClick);
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "ID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.idColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 60;
            // 
            // nomeColumn
            // 
            this.nomeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeColumn.DataPropertyName = "Nome";
            this.nomeColumn.HeaderText = "Nome";
            this.nomeColumn.Name = "nomeColumn";
            this.nomeColumn.ReadOnly = true;
            // 
            // enderecoColumn
            // 
            this.enderecoColumn.DataPropertyName = "Endereco";
            this.enderecoColumn.HeaderText = "Endereço";
            this.enderecoColumn.Name = "enderecoColumn";
            this.enderecoColumn.ReadOnly = true;
            this.enderecoColumn.Width = 250;
            // 
            // idcidadeColumn
            // 
            this.idcidadeColumn.DataPropertyName = "IDCidade";
            this.idcidadeColumn.HeaderText = "IDcidade";
            this.idcidadeColumn.Name = "idcidadeColumn";
            this.idcidadeColumn.ReadOnly = true;
            this.idcidadeColumn.Visible = false;
            // 
            // cidadeColumn
            // 
            this.cidadeColumn.DataPropertyName = "CidadeNome";
            this.cidadeColumn.HeaderText = "Cidade";
            this.cidadeColumn.Name = "cidadeColumn";
            this.cidadeColumn.ReadOnly = true;
            this.cidadeColumn.Width = 280;
            // 
            // bairroColumn
            // 
            this.bairroColumn.DataPropertyName = "Bairro";
            this.bairroColumn.HeaderText = "Bairro";
            this.bairroColumn.Name = "bairroColumn";
            this.bairroColumn.ReadOnly = true;
            this.bairroColumn.Width = 150;
            // 
            // dataNascimentoColumn
            // 
            this.dataNascimentoColumn.DataPropertyName = "DataNascimento";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.dataNascimentoColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataNascimentoColumn.HeaderText = "Data Nasc";
            this.dataNascimentoColumn.Name = "dataNascimentoColumn";
            this.dataNascimentoColumn.ReadOnly = true;
            // 
            // ClienteListarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 616);
            this.Controls.Add(this.meiopanel);
            this.Controls.Add(this.rodapePanel);
            this.Controls.Add(this.cabecalhoPanel);
            this.Name = "ClienteListarForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClienteListarForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ClienteListarForm_Load);
            this.cabecalhoPanel.ResumeLayout(false);
            this.cabecalhoPanel.PerformLayout();
            this.rodapePanel.ResumeLayout(false);
            this.rodapePanel.PerformLayout();
            this.botoesPanel.ResumeLayout(false);
            this.meiopanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cabecalhoPanel;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.TextBox filtroTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel rodapePanel;
        private System.Windows.Forms.Panel botoesPanel;
        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.Button incluirButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Panel meiopanel;
        private System.Windows.Forms.DataGridView listaDataGridView;
        private System.Windows.Forms.Label quantidadeLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcidadeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoColumn;
    }
}