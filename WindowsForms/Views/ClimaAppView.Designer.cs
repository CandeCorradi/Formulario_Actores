namespace WindowsForms
{
    partial class ClimaAppView
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
            menuStrip1 = new MenuStrip();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            subMenuNosotros = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            subMenuSalirDeLaApp = new FontAwesome.Sharp.IconMenuItem();
            toolStrip1 = new ToolStrip();
            botonNosotros = new FontAwesome.Sharp.IconToolStripButton();
            botonSalirApp = new FontAwesome.Sharp.IconToolStripButton();
            labelTituloApp = new Label();
            BtnObtenerClima = new Button();
            labelTemperatura = new Label();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1, iconMenuItem3 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(655, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { subMenuNosotros });
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(137, 29);
            iconMenuItem1.Text = "Acerca de..";
            // 
            // subMenuNosotros
            // 
            subMenuNosotros.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            subMenuNosotros.IconColor = Color.Black;
            subMenuNosotros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuNosotros.Name = "subMenuNosotros";
            subMenuNosotros.Size = new Size(188, 34);
            subMenuNosotros.Text = "Nosotros";
            subMenuNosotros.Click += subMenuNosotros_Click;
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { subMenuSalirDeLaApp });
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            iconMenuItem3.IconColor = Color.Black;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(85, 29);
            iconMenuItem3.Text = "Salir";
            // 
            // subMenuSalirDeLaApp
            // 
            subMenuSalirDeLaApp.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            subMenuSalirDeLaApp.IconColor = Color.Black;
            subMenuSalirDeLaApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuSalirDeLaApp.Name = "subMenuSalirDeLaApp";
            subMenuSalirDeLaApp.Size = new Size(230, 34);
            subMenuSalirDeLaApp.Text = "Salir de la app.";
            subMenuSalirDeLaApp.Click += subMenuSalirDeLaApp_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { botonNosotros, botonSalirApp });
            toolStrip1.Location = new Point(0, 33);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(655, 49);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // botonNosotros
            // 
            botonNosotros.DisplayStyle = ToolStripItemDisplayStyle.Image;
            botonNosotros.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            botonNosotros.IconColor = Color.Black;
            botonNosotros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            botonNosotros.IconSize = 40;
            botonNosotros.ImageScaling = ToolStripItemImageScaling.None;
            botonNosotros.ImageTransparentColor = Color.Magenta;
            botonNosotros.Name = "botonNosotros";
            botonNosotros.Size = new Size(44, 44);
            botonNosotros.Text = "iconToolStripButton1";
            botonNosotros.Click += botonNosotros_Click;
            // 
            // botonSalirApp
            // 
            botonSalirApp.DisplayStyle = ToolStripItemDisplayStyle.Image;
            botonSalirApp.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            botonSalirApp.IconColor = Color.Black;
            botonSalirApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            botonSalirApp.IconSize = 40;
            botonSalirApp.ImageScaling = ToolStripItemImageScaling.None;
            botonSalirApp.ImageTransparentColor = Color.Magenta;
            botonSalirApp.Name = "botonSalirApp";
            botonSalirApp.Size = new Size(44, 44);
            botonSalirApp.Text = "iconToolStripButton2";
            botonSalirApp.Click += botonSalirApp_Click;
            // 
            // labelTituloApp
            // 
            labelTituloApp.AutoSize = true;
            labelTituloApp.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            labelTituloApp.Location = new Point(115, 456);
            labelTituloApp.Name = "labelTituloApp";
            labelTituloApp.Size = new Size(421, 32);
            labelTituloApp.TabIndex = 2;
            labelTituloApp.Text = "App del Clima - ISP20 - 2do año TSDS";
            // 
            // BtnObtenerClima
            // 
            BtnObtenerClima.Location = new Point(52, 194);
            BtnObtenerClima.Name = "BtnObtenerClima";
            BtnObtenerClima.Size = new Size(143, 52);
            BtnObtenerClima.TabIndex = 3;
            BtnObtenerClima.Text = "Obtener clima";
            BtnObtenerClima.UseVisualStyleBackColor = true;
            BtnObtenerClima.Click += BtnObtenerClima_Click;
            // 
            // labelTemperatura
            // 
            labelTemperatura.AutoSize = true;
            labelTemperatura.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTemperatura.Location = new Point(334, 330);
            labelTemperatura.Name = "labelTemperatura";
            labelTemperatura.Size = new Size(0, 48);
            labelTemperatura.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 330);
            label1.Name = "label1";
            label1.Size = new Size(249, 48);
            label1.TabIndex = 5;
            label1.Text = "Temperatura:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // ClimaAppView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 497);
            Controls.Add(label1);
            Controls.Add(labelTemperatura);
            Controls.Add(BtnObtenerClima);
            Controls.Add(labelTituloApp);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "ClimaAppView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "App del clima hoy : 2do año 2025 : TDSD";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem subMenuNosotros;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem subMenuSalirDeLaApp;
        private FontAwesome.Sharp.IconToolStripButton botonNosotros;
        private FontAwesome.Sharp.IconToolStripButton botonSalirApp;
        private Label labelTituloApp;
        private Button BtnObtenerClima;
        private Label labelTemperatura;
        private Label label1;
    }
}