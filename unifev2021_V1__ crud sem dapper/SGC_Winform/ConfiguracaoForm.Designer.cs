namespace SGC_Winform
{
    partial class ConfiguracaoForm
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
            this.texto1Label = new System.Windows.Forms.Label();
            this.texto1TextBox = new System.Windows.Forms.TextBox();
            this.ordenarButton = new System.Windows.Forms.Button();
            this.texto2TextBox = new System.Windows.Forms.TextBox();
            this.texto2Label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texto1Label
            // 
            this.texto1Label.AutoSize = true;
            this.texto1Label.Location = new System.Drawing.Point(2, 9);
            this.texto1Label.Name = "texto1Label";
            this.texto1Label.Size = new System.Drawing.Size(77, 13);
            this.texto1Label.TabIndex = 0;
            this.texto1Label.Text = "Digite um texto";
            // 
            // texto1TextBox
            // 
            this.texto1TextBox.Location = new System.Drawing.Point(5, 26);
            this.texto1TextBox.Name = "texto1TextBox";
            this.texto1TextBox.Size = new System.Drawing.Size(323, 20);
            this.texto1TextBox.TabIndex = 1;
            // 
            // ordenarButton
            // 
            this.ordenarButton.Location = new System.Drawing.Point(100, 53);
            this.ordenarButton.Name = "ordenarButton";
            this.ordenarButton.Size = new System.Drawing.Size(75, 23);
            this.ordenarButton.TabIndex = 2;
            this.ordenarButton.Text = "Ordenar";
            this.ordenarButton.UseVisualStyleBackColor = true;
            this.ordenarButton.Click += new System.EventHandler(this.ordenarButton_Click);
            // 
            // texto2TextBox
            // 
            this.texto2TextBox.Location = new System.Drawing.Point(5, 100);
            this.texto2TextBox.Name = "texto2TextBox";
            this.texto2TextBox.Size = new System.Drawing.Size(323, 20);
            this.texto2TextBox.TabIndex = 4;
            // 
            // texto2Label
            // 
            this.texto2Label.AutoSize = true;
            this.texto2Label.Location = new System.Drawing.Point(2, 83);
            this.texto2Label.Name = "texto2Label";
            this.texto2Label.Size = new System.Drawing.Size(175, 13);
            this.texto2Label.TabIndex = 3;
            this.texto2Label.Text = "Digite um texto em ordem alfabetica";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ConfiguracaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 616);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.texto2TextBox);
            this.Controls.Add(this.texto2Label);
            this.Controls.Add(this.ordenarButton);
            this.Controls.Add(this.texto1TextBox);
            this.Controls.Add(this.texto1Label);
            this.Name = "ConfiguracaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label texto1Label;
        private System.Windows.Forms.TextBox texto1TextBox;
        private System.Windows.Forms.Button ordenarButton;
        private System.Windows.Forms.TextBox texto2TextBox;
        private System.Windows.Forms.Label texto2Label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}