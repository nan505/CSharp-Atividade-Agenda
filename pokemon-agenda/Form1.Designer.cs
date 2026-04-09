namespace pokemon_agenda
{
    partial class fmCadastroPokemon
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmCadastroPokemon));
            this.lbTituloAgenda = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.numNivel = new System.Windows.Forms.NumericUpDown();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.dgvListaPokemon = new System.Windows.Forms.DataGridView();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTituloAgenda
            // 
            this.lbTituloAgenda.AutoSize = true;
            this.lbTituloAgenda.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloAgenda.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTituloAgenda.Location = new System.Drawing.Point(82, 22);
            this.lbTituloAgenda.Name = "lbTituloAgenda";
            this.lbTituloAgenda.Size = new System.Drawing.Size(305, 42);
            this.lbTituloAgenda.TabIndex = 1;
            this.lbTituloAgenda.Text = "Agenda Pokémon";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTipo);
            this.groupBox1.Controls.Add(this.numNivel);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 200);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Pokémon";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Normal",
            "Fogo",
            "Água",
            "Grama",
            "Pedra",
            "Terra",
            "Psíquico",
            "Dragão",
            "Fada",
            "Metal",
            "Fantasma",
            "Voador",
            "Sombrio",
            "Elétrico",
            "Inseto",
            "Venenoso",
            "Gelo",
            "Lutador"});
            this.cbTipo.Location = new System.Drawing.Point(86, 64);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(193, 33);
            this.cbTipo.TabIndex = 3;
            // 
            // numNivel
            // 
            this.numNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNivel.Location = new System.Drawing.Point(86, 101);
            this.numNivel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNivel.Name = "numNivel";
            this.numNivel.Size = new System.Drawing.Size(193, 31);
            this.numNivel.TabIndex = 3;
            this.numNivel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(151, 162);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(145, 32);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(6, 162);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(145, 32);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nível:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(86, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(193, 31);
            this.txtNome.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pokemon_agenda.Properties.Resources.pokeball2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAjuda
            // 
            this.btnAjuda.Location = new System.Drawing.Point(18, 415);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(75, 23);
            this.btnAjuda.TabIndex = 8;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.UseVisualStyleBackColor = true;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // dgvListaPokemon
            // 
            this.dgvListaPokemon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaPokemon.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvListaPokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPokemon.Location = new System.Drawing.Point(369, 100);
            this.dgvListaPokemon.Name = "dgvListaPokemon";
            this.dgvListaPokemon.Size = new System.Drawing.Size(394, 200);
            this.dgvListaPokemon.TabIndex = 3;
            this.dgvListaPokemon.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvListaPokemon_DataBindingComplete);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Location = new System.Drawing.Point(369, 307);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(219, 34);
            this.btnVisualizar.TabIndex = 9;
            this.btnVisualizar.Text = "Visualizar detalhes";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // fmCadastroPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.dgvListaPokemon);
            this.Controls.Add(this.btnAjuda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTituloAgenda);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmCadastroPokemon";
            this.Text = "Agenda Pokémon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTituloAgenda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.NumericUpDown numNivel;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.DataGridView dgvListaPokemon;
        private System.Windows.Forms.Button btnVisualizar;
    }
}

