namespace WindowsForms.Views
{
    partial class Actores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actores));
            pictureBox1 = new PictureBox();
            BtnGoOut = new Button();
            GridActor = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Pais = new DataGridViewTextBoxColumn();
            label4 = new Label();
            BtnAdd = new Button();
            CmbPaisActor = new ComboBox();
            label3 = new Label();
            TxtNameActor = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridActor).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gradient_Wallpaper;
            pictureBox1.Location = new Point(-1, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(736, 1070);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnGoOut
            // 
            BtnGoOut.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnGoOut.Location = new Point(305, 399);
            BtnGoOut.Name = "BtnGoOut";
            BtnGoOut.Size = new Size(75, 23);
            BtnGoOut.TabIndex = 17;
            BtnGoOut.Text = "Salir";
            BtnGoOut.UseVisualStyleBackColor = true;
            BtnGoOut.Click += BtnGoOut_Click;
            // 
            // GridActor
            // 
            GridActor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridActor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridActor.Columns.AddRange(new DataGridViewColumn[] { Nombre, Pais });
            GridActor.Location = new Point(38, 269);
            GridActor.Name = "GridActor";
            GridActor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridActor.Size = new Size(342, 124);
            GridActor.TabIndex = 16;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MaxInputLength = 60000;
            Nombre.Name = "Nombre";
            // 
            // Pais
            // 
            Pais.HeaderText = "País";
            Pais.MaxInputLength = 60000;
            Pais.Name = "Pais";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 237);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 15;
            label4.Text = "Lista de actores:";
            // 
            // BtnAdd
            // 
            BtnAdd.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAdd.Location = new Point(38, 201);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(342, 23);
            BtnAdd.TabIndex = 14;
            BtnAdd.Text = "Agregar Actor";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // CmbPaisActor
            // 
            CmbPaisActor.FormattingEnabled = true;
            CmbPaisActor.Location = new Point(38, 166);
            CmbPaisActor.Name = "CmbPaisActor";
            CmbPaisActor.Size = new Size(342, 23);
            CmbPaisActor.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 134);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 12;
            label3.Text = "País:";
            // 
            // TxtNameActor
            // 
            TxtNameActor.Location = new Point(38, 100);
            TxtNameActor.Name = "TxtNameActor";
            TxtNameActor.Size = new Size(342, 23);
            TxtNameActor.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 72);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 10;
            label2.Text = "Nombre del actor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Muthiara -Demo Version-", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(149, 19);
            label1.Name = "label1";
            label1.Size = new Size(111, 43);
            label1.TabIndex = 9;
            label1.Text = "Actores";
            // 
            // Actores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 444);
            Controls.Add(BtnGoOut);
            Controls.Add(GridActor);
            Controls.Add(label4);
            Controls.Add(BtnAdd);
            Controls.Add(CmbPaisActor);
            Controls.Add(label3);
            Controls.Add(TxtNameActor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Actores";
            Text = "Actores";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridActor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnGoOut;
        private DataGridView GridActor;
        private Label label4;
        private Button BtnAdd;
        private ComboBox CmbPaisActor;
        private Label label3;
        private TextBox TxtNameActor;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Pais;
    }
}