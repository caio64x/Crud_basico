namespace SGC_Winform
{
    partial class ClienteInserirAlterarForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datanascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cidadeComboBox = new System.Windows.Forms.ComboBox();
            this.salvarButton = new System.Windows.Forms.Button();
            this.fecharButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(17, 36);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(133, 20);
            this.idTextBox.TabIndex = 0;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(156, 36);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(632, 20);
            this.nomeTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(14, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de Nascimento";
            // 
            // datanascimentoDateTimePicker
            // 
            this.datanascimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datanascimentoDateTimePicker.Location = new System.Drawing.Point(17, 91);
            this.datanascimentoDateTimePicker.Name = "datanascimentoDateTimePicker";
            this.datanascimentoDateTimePicker.Size = new System.Drawing.Size(133, 20);
            this.datanascimentoDateTimePicker.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(155, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome";
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.enderecoTextBox.Location = new System.Drawing.Point(156, 91);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(389, 20);
            this.enderecoTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(156, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(548, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bairro";
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bairroTextBox.Location = new System.Drawing.Point(551, 91);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(237, 20);
            this.bairroTextBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(14, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cidade";
            // 
            // cidadeComboBox
            // 
            this.cidadeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cidadeComboBox.FormattingEnabled = true;
            this.cidadeComboBox.Location = new System.Drawing.Point(12, 146);
            this.cidadeComboBox.Name = "cidadeComboBox";
            this.cidadeComboBox.Size = new System.Drawing.Size(569, 21);
            this.cidadeComboBox.TabIndex = 5;
            // 
            // salvarButton
            // 
            this.salvarButton.Location = new System.Drawing.Point(619, 147);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(75, 23);
            this.salvarButton.TabIndex = 6;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // fecharButton
            // 
            this.fecharButton.Location = new System.Drawing.Point(700, 147);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(75, 23);
            this.fecharButton.TabIndex = 7;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.UseVisualStyleBackColor = true;
            this.fecharButton.Click += new System.EventHandler(this.fecharButton_Click);
            // 
            // ClienteInserirAlterarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 182);
            this.Controls.Add(this.fecharButton);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.cidadeComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bairroTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datanascimentoDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClienteInserirAlterarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClienteInserirAlterarForm";
            this.Load += new System.EventHandler(this.ClienteInserirAlterarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datanascimentoDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cidadeComboBox;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Button fecharButton;
    }
}