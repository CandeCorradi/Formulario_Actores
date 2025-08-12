namespace WindowsForms.Views
{
    partial class Cine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cine));
            pictureBox1 = new PictureBox();
            BtnGoOut = new Button();
            GridStudy = new DataGridView();
            label3 = new Label();
            BtnAdd = new Button();
            TxtEstudio = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridStudy).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._212c3d35_d132_4246_96cf_ab0135fc25fc;
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(359, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnGoOut
            // 
            BtnGoOut.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnGoOut.Location = new Point(265, 403);
            BtnGoOut.Name = "BtnGoOut";
            BtnGoOut.Size = new Size(75, 23);
            BtnGoOut.TabIndex = 14;
            BtnGoOut.Text = "Salir";
            BtnGoOut.UseVisualStyleBackColor = true;
            BtnGoOut.Click += BtnGoOut_Click;
            // 
            // GridStudy
            // 
            GridStudy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridStudy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridStudy.Location = new Point(16, 186);
            GridStudy.Name = "GridStudy";
            GridStudy.Size = new Size(324, 211);
            GridStudy.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 162);
            label3.Name = "label3";
            label3.Size = new Size(140, 21);
            label3.TabIndex = 12;
            label3.Text = "Lista de estudios:";
            // 
            // BtnAdd
            // 
            BtnAdd.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAdd.Location = new Point(16, 121);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(324, 23);
            BtnAdd.TabIndex = 11;
            BtnAdd.Text = "Agregar Estudio";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // TxtEstudio
            // 
            TxtEstudio.Location = new Point(16, 92);
            TxtEstudio.Name = "TxtEstudio";
            TxtEstudio.Size = new Size(324, 23);
            TxtEstudio.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 68);
            label2.Name = "label2";
            label2.Size = new Size(166, 21);
            label2.TabIndex = 9;
            label2.Text = "Nombre del estudio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 24);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 8;
            label1.Text = "Estudios de Cine";
            // 
            // Cine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(357, 450);
            Controls.Add(BtnGoOut);
            Controls.Add(GridStudy);
            Controls.Add(label3);
            Controls.Add(BtnAdd);
            Controls.Add(TxtEstudio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Cine";
            Text = "Cine";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridStudy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnGoOut;
        private DataGridView GridStudy;
        private Label label3;
        private Button BtnAdd;
        private TextBox TxtEstudio;
        private Label label2;
        private Label label1;
    }
}