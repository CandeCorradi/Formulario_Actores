using WindowsForms.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            label1 = new Label();
            BtnDelete = new Button();
            BtnModificar = new Button();
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
            ((System.ComponentModel.ISupportInitialize)GridActor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Elephant", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(161, 29);
            label1.Name = "label1";
            label1.Size = new Size(146, 43);
            label1.TabIndex = 9;
            label1.Text = "Actores";
            // 
            // BtnDelete
            // 
            BtnDelete.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDelete.Location = new Point(242, 284);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(190, 29);
            BtnDelete.TabIndex = 39;
            BtnDelete.Text = "Eliminar";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnModificar.Location = new Point(40, 284);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(191, 29);
            BtnModificar.TabIndex = 38;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnGoOut
            // 
            BtnGoOut.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnGoOut.Location = new Point(140, 538);
            BtnGoOut.Margin = new Padding(3, 4, 3, 4);
            BtnGoOut.Name = "BtnGoOut";
            BtnGoOut.Size = new Size(190, 31);
            BtnGoOut.TabIndex = 37;
            BtnGoOut.Text = "Salir";
            BtnGoOut.UseVisualStyleBackColor = true;
            // 
            // GridActor
            // 
            GridActor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridActor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridActor.Columns.AddRange(new DataGridViewColumn[] { Nombre, Pais });
            GridActor.Location = new Point(41, 360);
            GridActor.Margin = new Padding(3, 4, 3, 4);
            GridActor.Name = "GridActor";
            GridActor.RowHeadersWidth = 51;
            GridActor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridActor.Size = new Size(391, 165);
            GridActor.TabIndex = 36;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MaxInputLength = 60000;
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // Pais
            // 
            Pais.HeaderText = "País";
            Pais.MaxInputLength = 60000;
            Pais.MinimumWidth = 6;
            Pais.Name = "Pais";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 325);
            label4.Name = "label4";
            label4.Size = new Size(158, 22);
            label4.TabIndex = 35;
            label4.Text = "Lista de actores:";
            // 
            // BtnAdd
            // 
            BtnAdd.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAdd.Location = new Point(40, 232);
            BtnAdd.Margin = new Padding(3, 4, 3, 4);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(390, 31);
            BtnAdd.TabIndex = 34;
            BtnAdd.Text = "Agregar";
            BtnAdd.UseVisualStyleBackColor = true;
            // 
            // CmbPaisActor
            // 
            CmbPaisActor.FormattingEnabled = true;
            CmbPaisActor.Location = new Point(41, 189);
            CmbPaisActor.Margin = new Padding(3, 4, 3, 4);
            CmbPaisActor.Name = "CmbPaisActor";
            CmbPaisActor.Size = new Size(390, 28);
            CmbPaisActor.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 158);
            label3.Name = "label3";
            label3.Size = new Size(49, 22);
            label3.TabIndex = 32;
            label3.Text = "País:";
            // 
            // TxtNameActor
            // 
            TxtNameActor.Location = new Point(40, 127);
            TxtNameActor.Margin = new Padding(3, 4, 3, 4);
            TxtNameActor.Name = "TxtNameActor";
            TxtNameActor.Size = new Size(390, 27);
            TxtNameActor.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 91);
            label2.Name = "label2";
            label2.Size = new Size(177, 22);
            label2.TabIndex = 30;
            label2.Text = "Nombre del actor:";
            // 
            // Actores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 592);
            Controls.Add(BtnDelete);
            Controls.Add(BtnModificar);
            Controls.Add(BtnGoOut);
            Controls.Add(label4);
            Controls.Add(BtnAdd);
            Controls.Add(CmbPaisActor);
            Controls.Add(label3);
            Controls.Add(TxtNameActor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GridActor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Actores";
            Text = "Actores";
            ((System.ComponentModel.ISupportInitialize)GridActor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Pais;
        private Label label1;
        private Button BtnDelete;
        private Button BtnModificar;
        private Button BtnGoOut;
        private DataGridView GridActor;
        private Label label4;
        private Button BtnAdd;
        private ComboBox CmbPaisActor;
        private Label label3;
        private TextBox TxtNameActor;
        private Label label2;
    }
}