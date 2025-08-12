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
            label1 = new Label();
            BtnDelete = new Button();
            BtnModificar = new Button();
            BtnGoOut = new Button();
            GridStudy = new DataGridView();
            label3 = new Label();
            BtnAdd = new Button();
            TxtEstudio = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)GridStudy).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 18);
            label1.Name = "label1";
            label1.Size = new Size(224, 34);
            label1.TabIndex = 16;
            label1.Text = "Estudios de Cine";
            // 
            // BtnDelete
            // 
            BtnDelete.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDelete.Location = new Point(228, 192);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(161, 29);
            BtnDelete.TabIndex = 31;
            BtnDelete.Text = "Eliminar";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            BtnModificar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnModificar.Location = new Point(19, 192);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(161, 29);
            BtnModificar.TabIndex = 30;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnGoOut
            // 
            BtnGoOut.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnGoOut.Location = new Point(131, 556);
            BtnGoOut.Margin = new Padding(3, 4, 3, 4);
            BtnGoOut.Name = "BtnGoOut";
            BtnGoOut.Size = new Size(161, 31);
            BtnGoOut.TabIndex = 29;
            BtnGoOut.Text = "Salir";
            BtnGoOut.UseVisualStyleBackColor = true;
            // 
            // GridStudy
            // 
            GridStudy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridStudy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridStudy.Location = new Point(19, 267);
            GridStudy.Margin = new Padding(3, 4, 3, 4);
            GridStudy.Name = "GridStudy";
            GridStudy.RowHeadersWidth = 51;
            GridStudy.Size = new Size(370, 281);
            GridStudy.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 240);
            label3.Name = "label3";
            label3.Size = new Size(173, 23);
            label3.TabIndex = 27;
            label3.Text = "Lista de estudios:";
            // 
            // BtnAdd
            // 
            BtnAdd.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAdd.Location = new Point(19, 147);
            BtnAdd.Margin = new Padding(3, 4, 3, 4);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(370, 31);
            BtnAdd.TabIndex = 26;
            BtnAdd.Text = "Agregar Estudio";
            BtnAdd.UseVisualStyleBackColor = true;
            // 
            // TxtEstudio
            // 
            TxtEstudio.Location = new Point(19, 107);
            TxtEstudio.Margin = new Padding(3, 4, 3, 4);
            TxtEstudio.Name = "TxtEstudio";
            TxtEstudio.Size = new Size(370, 27);
            TxtEstudio.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 77);
            label2.Name = "label2";
            label2.Size = new Size(209, 23);
            label2.TabIndex = 24;
            label2.Text = "Nombre del estudio:";
            // 
            // Cine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(408, 600);
            Controls.Add(BtnDelete);
            Controls.Add(BtnModificar);
            Controls.Add(BtnGoOut);
            Controls.Add(GridStudy);
            Controls.Add(label3);
            Controls.Add(BtnAdd);
            Controls.Add(TxtEstudio);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Cine";
            Text = "Cine";
            ((System.ComponentModel.ISupportInitialize)GridStudy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button BtnDelete;
        private Button BtnModificar;
        private Button BtnGoOut;
        private DataGridView GridStudy;
        private Label label3;
        private Button BtnAdd;
        private TextBox TxtEstudio;
        private Label label2;
    }
}