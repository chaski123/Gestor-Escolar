
namespace Gestor_Escolar
{
    partial class Inicio
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
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.Principal = new FontAwesome.Sharp.IconMenuItem();
            this.gestionPersonal = new FontAwesome.Sharp.IconMenuItem();
            this.gestionEscuelaGrados = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.otrosTramites = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1287, 72);
            this.menuTitulo.TabIndex = 0;
            this.menuTitulo.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Principal,
            this.gestionPersonal,
            this.gestionEscuelaGrados,
            this.iconMenuItem1,
            this.otrosTramites,
            this.iconMenuItem2});
            this.menu.Location = new System.Drawing.Point(0, 72);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1287, 58);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip2";
            // 
            // Principal
            // 
            this.Principal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Principal.IconChar = FontAwesome.Sharp.IconChar.House;
            this.Principal.IconColor = System.Drawing.Color.SteelBlue;
            this.Principal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Principal.IconSize = 50;
            this.Principal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(132, 54);
            this.Principal.Text = "Principal";
            this.Principal.Click += new System.EventHandler(this.Principal_Click);
            // 
            // gestionPersonal
            // 
            this.gestionPersonal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionPersonal.IconChar = FontAwesome.Sharp.IconChar.UsersRectangle;
            this.gestionPersonal.IconColor = System.Drawing.Color.SteelBlue;
            this.gestionPersonal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.gestionPersonal.IconSize = 50;
            this.gestionPersonal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.gestionPersonal.Name = "gestionPersonal";
            this.gestionPersonal.Size = new System.Drawing.Size(190, 54);
            this.gestionPersonal.Text = "Gestion Usuarios";
            // 
            // gestionEscuelaGrados
            // 
            this.gestionEscuelaGrados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionEscuelaGrados.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.gestionEscuelaGrados.IconColor = System.Drawing.Color.SteelBlue;
            this.gestionEscuelaGrados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.gestionEscuelaGrados.IconSize = 50;
            this.gestionEscuelaGrados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.gestionEscuelaGrados.Name = "gestionEscuelaGrados";
            this.gestionEscuelaGrados.Size = new System.Drawing.Size(180, 54);
            this.gestionEscuelaGrados.Text = "Gestion Escuela";
            this.gestionEscuelaGrados.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.iconMenuItem1.IconColor = System.Drawing.Color.SteelBlue;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.IconSize = 50;
            this.iconMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(138, 54);
            this.iconMenuItem1.Text = "Reportes ";
            // 
            // otrosTramites
            // 
            this.otrosTramites.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otrosTramites.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.otrosTramites.IconColor = System.Drawing.Color.SteelBlue;
            this.otrosTramites.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.otrosTramites.IconSize = 50;
            this.otrosTramites.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.otrosTramites.Name = "otrosTramites";
            this.otrosTramites.Size = new System.Drawing.Size(131, 54);
            this.otrosTramites.Text = "Tramites";
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconMenuItem2.IconColor = System.Drawing.Color.SteelBlue;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.IconSize = 50;
            this.iconMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(99, 54);
            this.iconMenuItem2.Text = "Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema Escolar";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 130);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1287, 420);
            this.contenedor.TabIndex = 3;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 550);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menuTitulo;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem Principal;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem gestionPersonal;
        private FontAwesome.Sharp.IconMenuItem gestionEscuelaGrados;
        private FontAwesome.Sharp.IconMenuItem otrosTramites;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
    }
}