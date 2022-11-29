namespace CalCube
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Proccess1 = new System.Windows.Forms.Button();
            this.Proccess2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Squares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cubes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ProccessName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Proccess1
            // 
            this.Proccess1.Location = new System.Drawing.Point(1, 1);
            this.Proccess1.Name = "Proccess1";
            this.Proccess1.Size = new System.Drawing.Size(81, 40);
            this.Proccess1.TabIndex = 0;
            this.Proccess1.Text = "Proccess  1";
            this.Proccess1.UseVisualStyleBackColor = true;
            this.Proccess1.Click += new System.EventHandler(this.Proccess1_Click);
            // 
            // Proccess2
            // 
            this.Proccess2.Location = new System.Drawing.Point(88, 1);
            this.Proccess2.Name = "Proccess2";
            this.Proccess2.Size = new System.Drawing.Size(79, 40);
            this.Proccess2.TabIndex = 1;
            this.Proccess2.Text = "Proccess 2";
            this.Proccess2.UseVisualStyleBackColor = true;
            this.Proccess2.Click += new System.EventHandler(this.Proccess2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Squares,
            this.Cubes});
            this.dataGridView1.Location = new System.Drawing.Point(1, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(343, 394);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            // 
            // Squares
            // 
            this.Squares.HeaderText = "Squares";
            this.Squares.Name = "Squares";
            // 
            // Cubes
            // 
            this.Cubes.HeaderText = "Cubes";
            this.Cubes.Name = "Cubes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "ProccessName :";
            // 
            // ProccessName
            // 
            this.ProccessName.AutoSize = true;
            this.ProccessName.Location = new System.Drawing.Point(100, 50);
            this.ProccessName.Name = "ProccessName";
            this.ProccessName.Size = new System.Drawing.Size(0, 15);
            this.ProccessName.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 464);
            this.Controls.Add(this.ProccessName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Proccess2);
            this.Controls.Add(this.Proccess1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Proccess1;
        private Button Proccess2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Squares;
        private DataGridViewTextBoxColumn Cubes;
        private Label label1;
        private Label ProccessName;
    }
}