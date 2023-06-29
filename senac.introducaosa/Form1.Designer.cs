namespace senac.introducaosa
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
            lblProfessor = new Label();
            lblAluno = new Label();
            lblAula = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            dtpData = new DateTimePicker();
            comboBox4 = new ComboBox();
            txtProfessor = new TextBox();
            txtAula = new TextBox();
            txtAluno = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // lblProfessor
            // 
            lblProfessor.AutoSize = true;
            lblProfessor.Location = new Point(3, 56);
            lblProfessor.Name = "lblProfessor";
            lblProfessor.Size = new Size(56, 15);
            lblProfessor.TabIndex = 0;
            lblProfessor.Text = "Professor";
            // 
            // lblAluno
            // 
            lblAluno.AutoSize = true;
            lblAluno.Location = new Point(162, 56);
            lblAluno.Name = "lblAluno";
            lblAluno.Size = new Size(39, 15);
            lblAluno.TabIndex = 1;
            lblAluno.Text = "Aluno";
            // 
            // lblAula
            // 
            lblAula.AutoSize = true;
            lblAula.Location = new Point(3, 117);
            lblAula.Name = "lblAula";
            lblAula.Size = new Size(31, 15);
            lblAula.TabIndex = 2;
            lblAula.Text = "Aula";
            // 
            // button1
            // 
            button1.Location = new Point(3, 294);
            button1.Name = "button1";
            button1.Size = new Size(86, 32);
            button1.TabIndex = 3;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Location = new Point(403, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(154, 43);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quantidade Alunos";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(15, 20);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(99, 23);
            numericUpDown1.TabIndex = 10;
            // 
            // dtpData
            // 
            dtpData.Location = new Point(150, 135);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(112, 23);
            dtpData.TabIndex = 9;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(0, 204);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(103, 23);
            comboBox4.TabIndex = 10;
            // 
            // txtProfessor
            // 
            txtProfessor.Location = new Point(3, 74);
            txtProfessor.Name = "txtProfessor";
            txtProfessor.Size = new Size(100, 23);
            txtProfessor.TabIndex = 11;
            // 
            // txtAula
            // 
            txtAula.Location = new Point(0, 135);
            txtAula.Name = "txtAula";
            txtAula.Size = new Size(100, 23);
            txtAula.TabIndex = 12;
            
            // 
            // txtAluno
            // 
            txtAluno.Location = new Point(150, 74);
            txtAluno.Name = "txtAluno";
            txtAluno.Size = new Size(100, 23);
            txtAluno.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAluno);
            Controls.Add(txtAula);
            Controls.Add(txtProfessor);
            Controls.Add(comboBox4);
            Controls.Add(dtpData);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(lblAula);
            Controls.Add(lblAluno);
            Controls.Add(lblProfessor);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProfessor;
        private Label lblAluno;
        private Label lblAula;
        private Button button1;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dtpData;
        private ComboBox comboBox4;
        private TextBox txtProfessor;
        private TextBox txtAula;
        private TextBox txtAluno;
    }
}