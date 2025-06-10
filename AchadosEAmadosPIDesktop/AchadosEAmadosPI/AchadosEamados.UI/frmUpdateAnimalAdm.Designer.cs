namespace AchadosEamados.UI
{
    partial class frmUpdateAnimalAdm
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
            this.cbTipoAnimal = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.chekbVacinado = new System.Windows.Forms.CheckBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dtpCadastro = new System.Windows.Forms.DateTimePicker();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbAnimal = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBCastrado = new System.Windows.Forms.CheckBox();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTipoAnimal
            // 
            this.cbTipoAnimal.FormattingEnabled = true;
            this.cbTipoAnimal.Items.AddRange(new object[] {
            "Cachorro",
            "Gato",
            "Outros"});
            this.cbTipoAnimal.Location = new System.Drawing.Point(32, 233);
            this.cbTipoAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoAnimal.Name = "cbTipoAnimal";
            this.cbTipoAnimal.Size = new System.Drawing.Size(189, 24);
            this.cbTipoAnimal.TabIndex = 113;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.label8.Location = new System.Drawing.Point(28, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 21);
            this.label8.TabIndex = 112;
            this.label8.Text = "Tipo Animal:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(143)))), ((int)(((byte)(112)))));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(581, 80);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 30);
            this.btnBuscar.TabIndex = 109;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(520, 85);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(55, 22);
            this.txtId.TabIndex = 108;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.label10.Location = new System.Drawing.Point(492, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 21);
            this.label10.TabIndex = 107;
            this.label10.Text = "Id:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(164)))), ((int)(((byte)(117)))));
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(191, 435);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(121, 37);
            this.btnAtualizar.TabIndex = 106;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(164)))), ((int)(((byte)(117)))));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(326, 435);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(121, 37);
            this.btnLimpar.TabIndex = 105;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // chekbVacinado
            // 
            this.chekbVacinado.AutoSize = true;
            this.chekbVacinado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chekbVacinado.Checked = true;
            this.chekbVacinado.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chekbVacinado.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chekbVacinado.Location = new System.Drawing.Point(288, 262);
            this.chekbVacinado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chekbVacinado.Name = "chekbVacinado";
            this.chekbVacinado.Size = new System.Drawing.Size(105, 26);
            this.chekbVacinado.TabIndex = 104;
            this.chekbVacinado.Text = "Vacinado?";
            this.chekbVacinado.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(164)))), ((int)(((byte)(117)))));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.btnVoltar.Location = new System.Drawing.Point(626, 448);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(63, 31);
            this.btnVoltar.TabIndex = 103;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dtpCadastro
            // 
            this.dtpCadastro.Location = new System.Drawing.Point(34, 395);
            this.dtpCadastro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpCadastro.Name = "dtpCadastro";
            this.dtpCadastro.Size = new System.Drawing.Size(260, 22);
            this.dtpCadastro.TabIndex = 102;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(247, 91);
            this.txtIdade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(191, 22);
            this.txtIdade.TabIndex = 101;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(32, 319);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(191, 22);
            this.txtDescricao.TabIndex = 99;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(32, 91);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(191, 22);
            this.txtNome.TabIndex = 98;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.label6.Location = new System.Drawing.Point(242, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 21);
            this.label6.TabIndex = 97;
            this.label6.Text = "Sexo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.label3.Location = new System.Drawing.Point(28, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 96;
            this.label3.Text = "Raça:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.label7.Location = new System.Drawing.Point(28, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 95;
            this.label7.Text = "Descrição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.label5.Location = new System.Drawing.Point(28, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 21);
            this.label5.TabIndex = 93;
            this.label5.Text = "Data de cadastro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.label4.Location = new System.Drawing.Point(242, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 92;
            this.label4.Text = "Idade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.label2.Location = new System.Drawing.Point(28, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 91;
            this.label2.Text = "Nome:";
            // 
            // pbAnimal
            // 
            this.pbAnimal.Location = new System.Drawing.Point(460, 176);
            this.pbAnimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbAnimal.Name = "pbAnimal";
            this.pbAnimal.Size = new System.Drawing.Size(221, 208);
            this.pbAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnimal.TabIndex = 90;
            this.pbAnimal.TabStop = false;
            this.pbAnimal.Click += new System.EventHandler(this.pbAnimal_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(164)))), ((int)(((byte)(117)))));
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.label1.Location = new System.Drawing.Point(-4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(710, 33);
            this.label1.TabIndex = 89;
            this.label1.Text = "Atualização de Animais";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBCastrado
            // 
            this.CBCastrado.AutoSize = true;
            this.CBCastrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CBCastrado.Checked = true;
            this.CBCastrado.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.CBCastrado.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCastrado.Location = new System.Drawing.Point(288, 293);
            this.CBCastrado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBCastrado.Name = "CBCastrado";
            this.CBCastrado.Size = new System.Drawing.Size(104, 26);
            this.CBCastrado.TabIndex = 114;
            this.CBCastrado.Text = "Castrado?";
            this.CBCastrado.UseVisualStyleBackColor = true;
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(32, 161);
            this.txtRaca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(191, 22);
            this.txtRaca.TabIndex = 115;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(164)))), ((int)(((byte)(117)))));
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.label11.Location = new System.Drawing.Point(493, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 33);
            this.label11.TabIndex = 116;
            this.label11.Text = "Imagem do Pet";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(246, 161);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(191, 22);
            this.txtSexo.TabIndex = 117;
            // 
            // frmUpdateAnimalAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(226)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(701, 490);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtRaca);
            this.Controls.Add(this.CBCastrado);
            this.Controls.Add(this.cbTipoAnimal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.chekbVacinado);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dtpCadastro);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbAnimal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUpdateAnimalAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateAnimalAdm";
            this.Load += new System.EventHandler(this.frmUpdateAnimalAdm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipoAnimal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.CheckBox chekbVacinado;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DateTimePicker dtpCadastro;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CBCastrado;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSexo;
    }
}