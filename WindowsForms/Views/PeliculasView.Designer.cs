namespace WindowsForms.Views
{
    partial class PeliculasView
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
            components = new System.ComponentModel.Container();
            TabControl = new TabControl();
            TabPageLista = new TabPage();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            TxtBuscar = new TextBox();
            label2 = new Label();
            FilmPicture = new PictureBox();
            BtnSalir = new FontAwesome.Sharp.IconButton();
            GridPeliculas = new DataGridView();
            BtnEliminar = new FontAwesome.Sharp.IconButton();
            BtnAgregar = new FontAwesome.Sharp.IconButton();
            BtnModificar = new FontAwesome.Sharp.IconButton();
            TabPageAgregarEditar = new TabPage();
            label6 = new Label();
            NumericCalificacion = new NumericUpDown();
            label5 = new Label();
            NumericDuracion = new NumericUpDown();
            TxtPortada = new TextBox();
            label4 = new Label();
            TxtTitulo = new TextBox();
            label3 = new Label();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            LabelStatusMessage = new ToolStripStatusLabel();
            TimerStatusBar = new System.Windows.Forms.Timer(components);
            TabControl.SuspendLayout();
            TabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FilmPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridPeliculas).BeginInit();
            TabPageAgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericCalificacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericDuracion).BeginInit();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(TabPageLista);
            TabControl.Controls.Add(TabPageAgregarEditar);
            TabControl.Location = new Point(21, 83);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1207, 489);
            TabControl.TabIndex = 6;
            // 
            // TabPageLista
            // 
            TabPageLista.Controls.Add(BtnBuscar);
            TabPageLista.Controls.Add(TxtBuscar);
            TabPageLista.Controls.Add(label2);
            TabPageLista.Controls.Add(FilmPicture);
            TabPageLista.Controls.Add(BtnSalir);
            TabPageLista.Controls.Add(GridPeliculas);
            TabPageLista.Controls.Add(BtnEliminar);
            TabPageLista.Controls.Add(BtnAgregar);
            TabPageLista.Controls.Add(BtnModificar);
            TabPageLista.Location = new Point(4, 34);
            TabPageLista.Name = "TabPageLista";
            TabPageLista.Padding = new Padding(3);
            TabPageLista.Size = new Size(1199, 451);
            TabPageLista.TabIndex = 1;
            TabPageLista.Text = "Lista";
            TabPageLista.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Bottom;
            BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscar.IconColor = Color.Black;
            BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscar.Location = new Point(1050, 8);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(136, 54);
            BtnBuscar.TabIndex = 15;
            BtnBuscar.Text = "&Buscar";
            BtnBuscar.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Location = new Point(85, 22);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(952, 31);
            TxtBuscar.TabIndex = 14;
            TxtBuscar.TextChanged += TxtBuscar_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 13;
            label2.Text = "Buscar:";
            // 
            // FilmPicture
            // 
            FilmPicture.Location = new Point(771, 62);
            FilmPicture.Name = "FilmPicture";
            FilmPicture.Size = new Size(266, 378);
            FilmPicture.SizeMode = PictureBoxSizeMode.Zoom;
            FilmPicture.TabIndex = 12;
            FilmPicture.TabStop = false;
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            BtnSalir.IconColor = Color.Black;
            BtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSalir.Location = new Point(1050, 382);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(136, 51);
            BtnSalir.TabIndex = 11;
            BtnSalir.Text = "Salir";
            BtnSalir.TextAlign = ContentAlignment.MiddleRight;
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // GridPeliculas
            // 
            GridPeliculas.AllowUserToAddRows = false;
            GridPeliculas.AllowUserToDeleteRows = false;
            GridPeliculas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridPeliculas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridPeliculas.Location = new Point(6, 62);
            GridPeliculas.MultiSelect = false;
            GridPeliculas.Name = "GridPeliculas";
            GridPeliculas.ReadOnly = true;
            GridPeliculas.RowHeadersWidth = 62;
            GridPeliculas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridPeliculas.Size = new Size(759, 383);
            GridPeliculas.TabIndex = 7;
            GridPeliculas.SelectionChanged += GridPeliculas_SelectionChanged_1;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Anchor = AnchorStyles.Bottom;
            BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            BtnEliminar.IconColor = Color.Black;
            BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEliminar.Location = new Point(1050, 262);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(136, 53);
            BtnEliminar.TabIndex = 10;
            BtnEliminar.Text = "&Eliminar";
            BtnEliminar.TextAlign = ContentAlignment.MiddleRight;
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click_1;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.Bottom;
            BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            BtnAgregar.IconColor = Color.Black;
            BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregar.Location = new Point(1050, 120);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(136, 54);
            BtnAgregar.TabIndex = 8;
            BtnAgregar.Text = "&Agregar";
            BtnAgregar.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Anchor = AnchorStyles.Bottom;
            BtnModificar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            BtnModificar.IconColor = Color.Black;
            BtnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnModificar.Location = new Point(1050, 195);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(136, 50);
            BtnModificar.TabIndex = 9;
            BtnModificar.Text = "&Modificar";
            BtnModificar.TextAlign = ContentAlignment.MiddleRight;
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // TabPageAgregarEditar
            // 
            TabPageAgregarEditar.Controls.Add(label6);
            TabPageAgregarEditar.Controls.Add(NumericCalificacion);
            TabPageAgregarEditar.Controls.Add(label5);
            TabPageAgregarEditar.Controls.Add(NumericDuracion);
            TabPageAgregarEditar.Controls.Add(TxtPortada);
            TabPageAgregarEditar.Controls.Add(label4);
            TabPageAgregarEditar.Controls.Add(TxtTitulo);
            TabPageAgregarEditar.Controls.Add(label3);
            TabPageAgregarEditar.Controls.Add(BtnCancelar);
            TabPageAgregarEditar.Controls.Add(BtnGuardar);
            TabPageAgregarEditar.Location = new Point(4, 34);
            TabPageAgregarEditar.Name = "TabPageAgregarEditar";
            TabPageAgregarEditar.Padding = new Padding(3);
            TabPageAgregarEditar.Size = new Size(1199, 451);
            TabPageAgregarEditar.TabIndex = 0;
            TabPageAgregarEditar.Text = "Agregar/Editar";
            TabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(106, 286);
            label6.Name = "label6";
            label6.Size = new Size(104, 25);
            label6.TabIndex = 21;
            label6.Text = "Calificación:";
            // 
            // NumericCalificacion
            // 
            NumericCalificacion.DecimalPlaces = 2;
            NumericCalificacion.Location = new Point(219, 286);
            NumericCalificacion.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            NumericCalificacion.Name = "NumericCalificacion";
            NumericCalificacion.Size = new Size(180, 31);
            NumericCalificacion.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 214);
            label5.Name = "label5";
            label5.Size = new Size(181, 25);
            label5.TabIndex = 19;
            label5.Text = "Duración en minutos:";
            // 
            // NumericDuracion
            // 
            NumericDuracion.Location = new Point(219, 214);
            NumericDuracion.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            NumericDuracion.Name = "NumericDuracion";
            NumericDuracion.Size = new Size(180, 31);
            NumericDuracion.TabIndex = 18;
            // 
            // TxtPortada
            // 
            TxtPortada.Location = new Point(219, 134);
            TxtPortada.Name = "TxtPortada";
            TxtPortada.Size = new Size(896, 31);
            TxtPortada.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(133, 137);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 16;
            label4.Text = "Portada:";
            // 
            // TxtTitulo
            // 
            TxtTitulo.Location = new Point(219, 61);
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(896, 31);
            TxtTitulo.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 67);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 11;
            label3.Text = "Título:";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.Bottom;
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(624, 377);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(136, 54);
            BtnCancelar.TabIndex = 10;
            BtnCancelar.Text = "&Cancelar";
            BtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Anchor = AnchorStyles.Bottom;
            BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            BtnGuardar.IconColor = Color.Black;
            BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuardar.Location = new Point(424, 377);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(136, 54);
            BtnGuardar.TabIndex = 9;
            BtnGuardar.Text = "&Guardar";
            BtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1245, 79);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(214, 62);
            label1.TabIndex = 1;
            label1.Text = "Películas";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { LabelStatusMessage });
            statusStrip1.Location = new Point(0, 604);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1240, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // LabelStatusMessage
            // 
            LabelStatusMessage.Name = "LabelStatusMessage";
            LabelStatusMessage.Size = new Size(0, 15);
            // 
            // TimerStatusBar
            // 
            TimerStatusBar.Interval = 5000;
            TimerStatusBar.Tick += TimerStatusBar_Tick;
            // 
            // PeliculasView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 626);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Controls.Add(TabControl);
            Name = "PeliculasView";
            TabControl.ResumeLayout(false);
            TabPageLista.ResumeLayout(false);
            TabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FilmPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridPeliculas).EndInit();
            TabPageAgregarEditar.ResumeLayout(false);
            TabPageAgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericCalificacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericDuracion).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl TabControl;
        private TabPage TabPageLista;
        private TabPage TabPageAgregarEditar;
        private Panel panel1;
        private Label label1;
        private PictureBox FilmPicture;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private DataGridView GridPeliculas;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private FontAwesome.Sharp.IconButton BtnModificar;
        private Label label2;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private TextBox TxtBuscar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private TextBox TxtPortada;
        private Label label4;
        private TextBox TxtTitulo;
        private Label label3;
        private Label label5;
        private NumericUpDown NumericDuracion;
        private Label label6;
        private NumericUpDown NumericCalificacion;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel LabelStatusMessage;
        private System.Windows.Forms.Timer TimerStatusBar;
    }
}