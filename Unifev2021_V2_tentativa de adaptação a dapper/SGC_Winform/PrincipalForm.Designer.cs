namespace SGC_Winform
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Arquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Janelas = new System.Windows.Forms.ToolStripMenuItem();
            this.cascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladoALadoHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladoALadoVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ajuda = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.DataStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Sair2 = new System.Windows.Forms.ToolStripButton();
            this.Sobre2 = new System.Windows.Forms.ToolStripButton();
            this.Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.Sobre = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Arquivo,
            this.Janelas,
            this.Ajuda,
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Arquivo
            // 
            this.Arquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem,
            this.Sair});
            this.Arquivo.Name = "Arquivo";
            this.Arquivo.Size = new System.Drawing.Size(61, 20);
            this.Arquivo.Text = "Arquivo";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.configToolStripMenuItem.Text = "Configurações";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // Janelas
            // 
            this.Janelas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascataToolStripMenuItem,
            this.iconesToolStripMenuItem,
            this.ladoALadoHorizontalToolStripMenuItem,
            this.ladoALadoVerticalToolStripMenuItem});
            this.Janelas.Name = "Janelas";
            this.Janelas.Size = new System.Drawing.Size(56, 20);
            this.Janelas.Text = "Janelas";
            // 
            // cascataToolStripMenuItem
            // 
            this.cascataToolStripMenuItem.Name = "cascataToolStripMenuItem";
            this.cascataToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.cascataToolStripMenuItem.Text = "Cascata";
            this.cascataToolStripMenuItem.Click += new System.EventHandler(this.cascataToolStripMenuItem_Click);
            // 
            // iconesToolStripMenuItem
            // 
            this.iconesToolStripMenuItem.Name = "iconesToolStripMenuItem";
            this.iconesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.iconesToolStripMenuItem.Text = "Icones";
            this.iconesToolStripMenuItem.Click += new System.EventHandler(this.iconesToolStripMenuItem_Click);
            // 
            // ladoALadoHorizontalToolStripMenuItem
            // 
            this.ladoALadoHorizontalToolStripMenuItem.Name = "ladoALadoHorizontalToolStripMenuItem";
            this.ladoALadoHorizontalToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.ladoALadoHorizontalToolStripMenuItem.Text = "Lado a lado horizontal";
            this.ladoALadoHorizontalToolStripMenuItem.Click += new System.EventHandler(this.ladoALadoHorizontalToolStripMenuItem_Click);
            // 
            // ladoALadoVerticalToolStripMenuItem
            // 
            this.ladoALadoVerticalToolStripMenuItem.Name = "ladoALadoVerticalToolStripMenuItem";
            this.ladoALadoVerticalToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.ladoALadoVerticalToolStripMenuItem.Text = "Lado a lado Vertical";
            this.ladoALadoVerticalToolStripMenuItem.Click += new System.EventHandler(this.ladoALadoVerticalToolStripMenuItem_Click);
            // 
            // Ajuda
            // 
            this.Ajuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sobre});
            this.Ajuda.Name = "Ajuda";
            this.Ajuda.Size = new System.Drawing.Size(50, 20);
            this.Ajuda.Text = "Ajuda";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sair2,
            this.Sobre2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 54);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.DataStatus,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(155, 17);
            this.toolStripStatusLabel1.Text = "Todos os direitos reservados";
            // 
            // DataStatus
            // 
            this.DataStatus.Name = "DataStatus";
            this.DataStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Sair2
            // 
            this.Sair2.Image = global::SGC_Winform.Properties.Resources.iconfinder_logout_close_sign_out_exit_access_3994382__1_;
            this.Sair2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sair2.Name = "Sair2";
            this.Sair2.Size = new System.Drawing.Size(36, 51);
            this.Sair2.Text = "Sair";
            this.Sair2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Sair2.Click += new System.EventHandler(this.Sair2_Click);
            // 
            // Sobre2
            // 
            this.Sobre2.Image = global::SGC_Winform.Properties.Resources.iconfinder_info_outline_326659__1_;
            this.Sobre2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sobre2.Name = "Sobre2";
            this.Sobre2.Size = new System.Drawing.Size(41, 51);
            this.Sobre2.Text = "Sobre";
            this.Sobre2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Sobre2.Click += new System.EventHandler(this.Sobre2_Click);
            // 
            // Sair
            // 
            this.Sair.Image = global::SGC_Winform.Properties.Resources.iconfinder_logout_close_sign_out_exit_access_3994382;
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(151, 22);
            this.Sair.Text = "Sair";
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Sobre
            // 
            this.Sobre.Image = global::SGC_Winform.Properties.Resources.iconfinder_gear_setting_appearance_process_2203539;
            this.Sobre.Name = "Sobre";
            this.Sobre.Size = new System.Drawing.Size(104, 22);
            this.Sobre.Text = "Sobre";
            this.Sobre.Click += new System.EventHandler(this.Sobre_Click);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SGC - Sistema de Gerenciamento Comercial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Arquivo;
        private System.Windows.Forms.ToolStripMenuItem Sair;
        private System.Windows.Forms.ToolStripMenuItem Janelas;
        private System.Windows.Forms.ToolStripMenuItem Ajuda;
        private System.Windows.Forms.ToolStripMenuItem Sobre;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Sair2;
        private System.Windows.Forms.ToolStripButton Sobre2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel DataStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iconesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladoALadoHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladoALadoVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
    }
}

