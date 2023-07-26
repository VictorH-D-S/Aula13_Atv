namespace Aula13_Atv
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
            txtNome = new TextBox();
            groupBox1 = new GroupBox();
            btnSalvar = new Button();
            label4 = new Label();
            txtCidade = new TextBox();
            label3 = new Label();
            txtRua = new TextBox();
            label2 = new Label();
            txtIdade = new TextBox();
            label1 = new Label();
            listView1 = new ListView();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 46);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(188, 23);
            txtNome.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCidade);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtRua);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtIdade);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 305);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(15, 245);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(159, 36);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 184);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 7;
            label4.Text = "Cidade:";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(6, 202);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(188, 23);
            txtCidade.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 131);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 5;
            label3.Text = "Rua:";
            // 
            // txtRua
            // 
            txtRua.Location = new Point(6, 149);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(188, 23);
            txtRua.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 78);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Idade:";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(6, 96);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(188, 23);
            txtIdade.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // listView1
            // 
            listView1.Location = new Point(227, 21);
            listView1.Name = "listView1";
            listView1.Size = new Size(214, 216);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 378);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNome;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtCidade;
        private Label label3;
        private TextBox txtRua;
        private Label label2;
        private TextBox txtIdade;
        private Label label1;
        private Button btnSalvar;
        private ListView listView1;
    }
}