namespace GravarDadosMYSQL
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            button1 = new Button();
            list_contatos = new ListView();
            label4 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 39);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "NOME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 94);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "TELEFONE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 164);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "EMAIL";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(35, 56);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(211, 23);
            txtNome.TabIndex = 3;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(35, 112);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(211, 23);
            txtTelefone.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(36, 182);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 23);
            txtEmail.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(171, 252);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "SALVAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // list_contatos
            // 
            list_contatos.Location = new Point(277, 94);
            list_contatos.Name = "list_contatos";
            list_contatos.Size = new Size(327, 170);
            list_contatos.TabIndex = 7;
            list_contatos.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(277, 39);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 8;
            label4.Text = "BUSCAR CONTATO";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(277, 65);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(276, 23);
            txtBuscar.TabIndex = 9;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(579, 64);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 357);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label4);
            Controls.Add(list_contatos);
            Controls.Add(button1);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Button button1;
        private ListView list_contatos;
        private Label label4;
        private TextBox txtBuscar;
        private Button btnBuscar;
    }
}