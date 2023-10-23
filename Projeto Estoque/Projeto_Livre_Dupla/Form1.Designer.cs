
namespace Projeto_Livre_Dupla
{
    partial class Form1
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
            this.Pic_Imagem = new System.Windows.Forms.PictureBox();
            this.Lbl_Supy = new System.Windows.Forms.Label();
            this.Grp_Categorias = new System.Windows.Forms.GroupBox();
            this.Rad_Infantil = new System.Windows.Forms.RadioButton();
            this.Rad_Masculina = new System.Windows.Forms.RadioButton();
            this.Rad_Feminina = new System.Windows.Forms.RadioButton();
            this.Rad_Unissex = new System.Windows.Forms.RadioButton();
            this.Btn_Solicitar = new System.Windows.Forms.Button();
            this.Grp_Tamanhos = new System.Windows.Forms.GroupBox();
            this.Rad_40e46 = new System.Windows.Forms.RadioButton();
            this.Rad_30e39 = new System.Windows.Forms.RadioButton();
            this.Rad_37e42 = new System.Windows.Forms.RadioButton();
            this.Rad_17e30 = new System.Windows.Forms.RadioButton();
            this.Grp_Modelos = new System.Windows.Forms.GroupBox();
            this.Rad_Alto = new System.Windows.Forms.RadioButton();
            this.Rad_Medio = new System.Windows.Forms.RadioButton();
            this.Rad_Curto = new System.Windows.Forms.RadioButton();
            this.Lbl_Categorias = new System.Windows.Forms.Label();
            this.Lbl_Modelos = new System.Windows.Forms.Label();
            this.Lbl_Tamanhos = new System.Windows.Forms.Label();
            this.Cmb_Lote = new System.Windows.Forms.ComboBox();
            this.Grp_Requisicao = new System.Windows.Forms.GroupBox();
            this.Lbl_ComboBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Imagem)).BeginInit();
            this.Grp_Categorias.SuspendLayout();
            this.Grp_Tamanhos.SuspendLayout();
            this.Grp_Modelos.SuspendLayout();
            this.Grp_Requisicao.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pic_Imagem
            // 
            this.Pic_Imagem.Location = new System.Drawing.Point(285, 75);
            this.Pic_Imagem.Name = "Pic_Imagem";
            this.Pic_Imagem.Size = new System.Drawing.Size(308, 460);
            this.Pic_Imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Imagem.TabIndex = 1;
            this.Pic_Imagem.TabStop = false;
            // 
            // Lbl_Supy
            // 
            this.Lbl_Supy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Supy.ForeColor = System.Drawing.Color.White;
            this.Lbl_Supy.Location = new System.Drawing.Point(290, 20);
            this.Lbl_Supy.Name = "Lbl_Supy";
            this.Lbl_Supy.Size = new System.Drawing.Size(292, 34);
            this.Lbl_Supy.TabIndex = 2;
            this.Lbl_Supy.Text = "Su;py ";
            this.Lbl_Supy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Grp_Categorias
            // 
            this.Grp_Categorias.Controls.Add(this.Rad_Infantil);
            this.Grp_Categorias.Controls.Add(this.Rad_Masculina);
            this.Grp_Categorias.Controls.Add(this.Rad_Feminina);
            this.Grp_Categorias.Controls.Add(this.Rad_Unissex);
            this.Grp_Categorias.ForeColor = System.Drawing.Color.White;
            this.Grp_Categorias.Location = new System.Drawing.Point(25, 98);
            this.Grp_Categorias.Name = "Grp_Categorias";
            this.Grp_Categorias.Size = new System.Drawing.Size(176, 167);
            this.Grp_Categorias.TabIndex = 3;
            this.Grp_Categorias.TabStop = false;
            this.Grp_Categorias.Text = "Categorias";
            this.Grp_Categorias.Enter += new System.EventHandler(this.Grp_Categorias_Enter);
            // 
            // Rad_Infantil
            // 
            this.Rad_Infantil.AutoSize = true;
            this.Rad_Infantil.Enabled = false;
            this.Rad_Infantil.ForeColor = System.Drawing.Color.White;
            this.Rad_Infantil.Location = new System.Drawing.Point(24, 126);
            this.Rad_Infantil.Name = "Rad_Infantil";
            this.Rad_Infantil.Size = new System.Drawing.Size(56, 17);
            this.Rad_Infantil.TabIndex = 3;
            this.Rad_Infantil.Text = "Infantil";
            this.Rad_Infantil.UseVisualStyleBackColor = true;
            this.Rad_Infantil.CheckedChanged += new System.EventHandler(this.Rad_Infantil_CheckedChanged);
            // 
            // Rad_Masculina
            // 
            this.Rad_Masculina.AutoSize = true;
            this.Rad_Masculina.Enabled = false;
            this.Rad_Masculina.ForeColor = System.Drawing.Color.White;
            this.Rad_Masculina.Location = new System.Drawing.Point(24, 90);
            this.Rad_Masculina.Name = "Rad_Masculina";
            this.Rad_Masculina.Size = new System.Drawing.Size(73, 17);
            this.Rad_Masculina.TabIndex = 2;
            this.Rad_Masculina.Text = "Masculina";
            this.Rad_Masculina.UseVisualStyleBackColor = true;
            this.Rad_Masculina.CheckedChanged += new System.EventHandler(this.Rad_Masculina_CheckedChanged);
            // 
            // Rad_Feminina
            // 
            this.Rad_Feminina.AutoSize = true;
            this.Rad_Feminina.Enabled = false;
            this.Rad_Feminina.ForeColor = System.Drawing.Color.White;
            this.Rad_Feminina.Location = new System.Drawing.Point(24, 53);
            this.Rad_Feminina.Name = "Rad_Feminina";
            this.Rad_Feminina.Size = new System.Drawing.Size(67, 17);
            this.Rad_Feminina.TabIndex = 1;
            this.Rad_Feminina.Text = "Feminina";
            this.Rad_Feminina.UseVisualStyleBackColor = true;
            this.Rad_Feminina.CheckedChanged += new System.EventHandler(this.Rad_Feminina_CheckedChanged);
            // 
            // Rad_Unissex
            // 
            this.Rad_Unissex.AutoSize = true;
            this.Rad_Unissex.Enabled = false;
            this.Rad_Unissex.ForeColor = System.Drawing.Color.White;
            this.Rad_Unissex.Location = new System.Drawing.Point(24, 19);
            this.Rad_Unissex.Name = "Rad_Unissex";
            this.Rad_Unissex.Size = new System.Drawing.Size(62, 17);
            this.Rad_Unissex.TabIndex = 0;
            this.Rad_Unissex.Text = "Unissex";
            this.Rad_Unissex.UseVisualStyleBackColor = true;
            this.Rad_Unissex.CheckedChanged += new System.EventHandler(this.Rad_Unissex_CheckedChanged);
            // 
            // Btn_Solicitar
            // 
            this.Btn_Solicitar.Enabled = false;
            this.Btn_Solicitar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Solicitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Solicitar.ForeColor = System.Drawing.Color.White;
            this.Btn_Solicitar.Location = new System.Drawing.Point(676, 457);
            this.Btn_Solicitar.Name = "Btn_Solicitar";
            this.Btn_Solicitar.Size = new System.Drawing.Size(106, 37);
            this.Btn_Solicitar.TabIndex = 9;
            this.Btn_Solicitar.Text = "Solicitar";
            this.Btn_Solicitar.UseVisualStyleBackColor = true;
            this.Btn_Solicitar.Click += new System.EventHandler(this.Btn_Finalizar_Click);
            // 
            // Grp_Tamanhos
            // 
            this.Grp_Tamanhos.Controls.Add(this.Rad_40e46);
            this.Grp_Tamanhos.Controls.Add(this.Rad_30e39);
            this.Grp_Tamanhos.Controls.Add(this.Rad_37e42);
            this.Grp_Tamanhos.Controls.Add(this.Rad_17e30);
            this.Grp_Tamanhos.ForeColor = System.Drawing.Color.White;
            this.Grp_Tamanhos.Location = new System.Drawing.Point(25, 457);
            this.Grp_Tamanhos.Name = "Grp_Tamanhos";
            this.Grp_Tamanhos.Size = new System.Drawing.Size(213, 84);
            this.Grp_Tamanhos.TabIndex = 18;
            this.Grp_Tamanhos.TabStop = false;
            this.Grp_Tamanhos.Text = "Tamanhos";
            this.Grp_Tamanhos.Enter += new System.EventHandler(this.Grp_Tamanhos_Enter);
            // 
            // Rad_40e46
            // 
            this.Rad_40e46.AutoSize = true;
            this.Rad_40e46.Enabled = false;
            this.Rad_40e46.Location = new System.Drawing.Point(124, 61);
            this.Rad_40e46.Name = "Rad_40e46";
            this.Rad_40e46.Size = new System.Drawing.Size(52, 17);
            this.Rad_40e46.TabIndex = 3;
            this.Rad_40e46.TabStop = true;
            this.Rad_40e46.Text = "40-46";
            this.Rad_40e46.UseVisualStyleBackColor = true;
            this.Rad_40e46.CheckedChanged += new System.EventHandler(this.Rad_4_CheckedChanged);
            // 
            // Rad_30e39
            // 
            this.Rad_30e39.AutoSize = true;
            this.Rad_30e39.Enabled = false;
            this.Rad_30e39.Location = new System.Drawing.Point(10, 61);
            this.Rad_30e39.Name = "Rad_30e39";
            this.Rad_30e39.Size = new System.Drawing.Size(52, 17);
            this.Rad_30e39.TabIndex = 2;
            this.Rad_30e39.TabStop = true;
            this.Rad_30e39.Text = "30-39";
            this.Rad_30e39.UseVisualStyleBackColor = true;
            this.Rad_30e39.CheckedChanged += new System.EventHandler(this.Rad_3_CheckedChanged);
            // 
            // Rad_37e42
            // 
            this.Rad_37e42.AutoSize = true;
            this.Rad_37e42.Enabled = false;
            this.Rad_37e42.Location = new System.Drawing.Point(124, 19);
            this.Rad_37e42.Name = "Rad_37e42";
            this.Rad_37e42.Size = new System.Drawing.Size(52, 17);
            this.Rad_37e42.TabIndex = 1;
            this.Rad_37e42.TabStop = true;
            this.Rad_37e42.Text = "37-42";
            this.Rad_37e42.UseVisualStyleBackColor = true;
            this.Rad_37e42.CheckedChanged += new System.EventHandler(this.Rad_2_CheckedChanged);
            // 
            // Rad_17e30
            // 
            this.Rad_17e30.AutoSize = true;
            this.Rad_17e30.Enabled = false;
            this.Rad_17e30.Location = new System.Drawing.Point(7, 19);
            this.Rad_17e30.Name = "Rad_17e30";
            this.Rad_17e30.Size = new System.Drawing.Size(55, 17);
            this.Rad_17e30.TabIndex = 0;
            this.Rad_17e30.TabStop = true;
            this.Rad_17e30.Text = " 17-30";
            this.Rad_17e30.UseVisualStyleBackColor = true;
            this.Rad_17e30.CheckedChanged += new System.EventHandler(this.Rad_1_CheckedChanged);
            // 
            // Grp_Modelos
            // 
            this.Grp_Modelos.Controls.Add(this.Rad_Alto);
            this.Grp_Modelos.Controls.Add(this.Rad_Medio);
            this.Grp_Modelos.Controls.Add(this.Rad_Curto);
            this.Grp_Modelos.ForeColor = System.Drawing.Color.White;
            this.Grp_Modelos.Location = new System.Drawing.Point(25, 307);
            this.Grp_Modelos.Name = "Grp_Modelos";
            this.Grp_Modelos.Size = new System.Drawing.Size(180, 109);
            this.Grp_Modelos.TabIndex = 19;
            this.Grp_Modelos.TabStop = false;
            this.Grp_Modelos.Text = "Modelos";
            this.Grp_Modelos.Enter += new System.EventHandler(this.Grp_Modelos_Enter);
            // 
            // Rad_Alto
            // 
            this.Rad_Alto.AutoSize = true;
            this.Rad_Alto.Enabled = false;
            this.Rad_Alto.Location = new System.Drawing.Point(12, 74);
            this.Rad_Alto.Name = "Rad_Alto";
            this.Rad_Alto.Size = new System.Drawing.Size(71, 17);
            this.Rad_Alto.TabIndex = 2;
            this.Rad_Alto.Text = "Cano Alto";
            this.Rad_Alto.UseVisualStyleBackColor = true;
            this.Rad_Alto.CheckedChanged += new System.EventHandler(this.Rad_Alto_CheckedChanged);
            // 
            // Rad_Medio
            // 
            this.Rad_Medio.AutoSize = true;
            this.Rad_Medio.Enabled = false;
            this.Rad_Medio.Location = new System.Drawing.Point(11, 47);
            this.Rad_Medio.Name = "Rad_Medio";
            this.Rad_Medio.Size = new System.Drawing.Size(82, 17);
            this.Rad_Medio.TabIndex = 1;
            this.Rad_Medio.Text = "Cano Médio";
            this.Rad_Medio.UseVisualStyleBackColor = true;
            this.Rad_Medio.CheckedChanged += new System.EventHandler(this.Rad_Medio_CheckedChanged);
            // 
            // Rad_Curto
            // 
            this.Rad_Curto.AutoSize = true;
            this.Rad_Curto.Enabled = false;
            this.Rad_Curto.Location = new System.Drawing.Point(11, 21);
            this.Rad_Curto.Name = "Rad_Curto";
            this.Rad_Curto.Size = new System.Drawing.Size(78, 17);
            this.Rad_Curto.TabIndex = 0;
            this.Rad_Curto.Text = "Cano Curto";
            this.Rad_Curto.UseVisualStyleBackColor = true;
            this.Rad_Curto.CheckedChanged += new System.EventHandler(this.Rad_Curto_CheckedChanged);
            // 
            // Lbl_Categorias
            // 
            this.Lbl_Categorias.Location = new System.Drawing.Point(26, 68);
            this.Lbl_Categorias.Name = "Lbl_Categorias";
            this.Lbl_Categorias.Size = new System.Drawing.Size(90, 23);
            this.Lbl_Categorias.TabIndex = 22;
            this.Lbl_Categorias.Text = "label1";
            this.Lbl_Categorias.Visible = false;
            // 
            // Lbl_Modelos
            // 
            this.Lbl_Modelos.Location = new System.Drawing.Point(26, 103);
            this.Lbl_Modelos.Name = "Lbl_Modelos";
            this.Lbl_Modelos.Size = new System.Drawing.Size(100, 23);
            this.Lbl_Modelos.TabIndex = 23;
            this.Lbl_Modelos.Text = "label1";
            this.Lbl_Modelos.Visible = false;
            this.Lbl_Modelos.Click += new System.EventHandler(this.Lbl_Modelos_Click);
            // 
            // Lbl_Tamanhos
            // 
            this.Lbl_Tamanhos.Location = new System.Drawing.Point(26, 135);
            this.Lbl_Tamanhos.Name = "Lbl_Tamanhos";
            this.Lbl_Tamanhos.Size = new System.Drawing.Size(90, 21);
            this.Lbl_Tamanhos.TabIndex = 24;
            this.Lbl_Tamanhos.Text = "label1";
            this.Lbl_Tamanhos.Visible = false;
            // 
            // Cmb_Lote
            // 
            this.Cmb_Lote.FormattingEnabled = true;
            this.Cmb_Lote.Items.AddRange(new object[] {
            "Lote 000000",
            "Lote 000001",
            "Lote 000002",
            "Lote 000003",
            "Lote 000004",
            "Lote 000005"});
            this.Cmb_Lote.Location = new System.Drawing.Point(49, 33);
            this.Cmb_Lote.Name = "Cmb_Lote";
            this.Cmb_Lote.Size = new System.Drawing.Size(121, 21);
            this.Cmb_Lote.TabIndex = 25;
            this.Cmb_Lote.Text = "Selecione o Lote";
            this.Cmb_Lote.SelectedIndexChanged += new System.EventHandler(this.Cmb_Lote_SelectedIndexChanged);
            // 
            // Grp_Requisicao
            // 
            this.Grp_Requisicao.Controls.Add(this.Lbl_ComboBox);
            this.Grp_Requisicao.Controls.Add(this.Lbl_Modelos);
            this.Grp_Requisicao.Controls.Add(this.Lbl_Categorias);
            this.Grp_Requisicao.Controls.Add(this.Lbl_Tamanhos);
            this.Grp_Requisicao.ForeColor = System.Drawing.Color.White;
            this.Grp_Requisicao.Location = new System.Drawing.Point(656, 75);
            this.Grp_Requisicao.Name = "Grp_Requisicao";
            this.Grp_Requisicao.Size = new System.Drawing.Size(143, 190);
            this.Grp_Requisicao.TabIndex = 26;
            this.Grp_Requisicao.TabStop = false;
            this.Grp_Requisicao.Text = "Requisição";
            this.Grp_Requisicao.Enter += new System.EventHandler(this.Grp_label_Enter);
            // 
            // Lbl_ComboBox
            // 
            this.Lbl_ComboBox.Location = new System.Drawing.Point(26, 37);
            this.Lbl_ComboBox.Name = "Lbl_ComboBox";
            this.Lbl_ComboBox.Size = new System.Drawing.Size(100, 23);
            this.Lbl_ComboBox.TabIndex = 25;
            this.Lbl_ComboBox.Text = "label1";
            this.Lbl_ComboBox.UseCompatibleTextRendering = true;
            this.Lbl_ComboBox.Click += new System.EventHandler(this.Lbl_ComboBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(877, 571);
            this.Controls.Add(this.Grp_Requisicao);
            this.Controls.Add(this.Cmb_Lote);
            this.Controls.Add(this.Grp_Modelos);
            this.Controls.Add(this.Grp_Tamanhos);
            this.Controls.Add(this.Btn_Solicitar);
            this.Controls.Add(this.Grp_Categorias);
            this.Controls.Add(this.Lbl_Supy);
            this.Controls.Add(this.Pic_Imagem);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "ESTOQUE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Imagem)).EndInit();
            this.Grp_Categorias.ResumeLayout(false);
            this.Grp_Categorias.PerformLayout();
            this.Grp_Tamanhos.ResumeLayout(false);
            this.Grp_Tamanhos.PerformLayout();
            this.Grp_Modelos.ResumeLayout(false);
            this.Grp_Modelos.PerformLayout();
            this.Grp_Requisicao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Pic_Imagem;
        private System.Windows.Forms.Label Lbl_Supy;
        private System.Windows.Forms.GroupBox Grp_Categorias;
        private System.Windows.Forms.RadioButton Rad_Infantil;
        private System.Windows.Forms.RadioButton Rad_Masculina;
        private System.Windows.Forms.RadioButton Rad_Feminina;
        private System.Windows.Forms.Button Btn_Solicitar;
        private System.Windows.Forms.GroupBox Grp_Tamanhos;
        private System.Windows.Forms.RadioButton Rad_40e46;
        private System.Windows.Forms.RadioButton Rad_30e39;
        private System.Windows.Forms.RadioButton Rad_37e42;
        private System.Windows.Forms.RadioButton Rad_17e30;
        private System.Windows.Forms.GroupBox Grp_Modelos;
        private System.Windows.Forms.RadioButton Rad_Alto;
        private System.Windows.Forms.RadioButton Rad_Medio;
        private System.Windows.Forms.RadioButton Rad_Curto;
        private System.Windows.Forms.Label Lbl_Categorias;
        private System.Windows.Forms.Label Lbl_Modelos;
        private System.Windows.Forms.Label Lbl_Tamanhos;
        private System.Windows.Forms.GroupBox Grp_Requisicao;
        private System.Windows.Forms.Label Lbl_ComboBox;
        private System.Windows.Forms.ComboBox Cmb_Lote;
        private System.Windows.Forms.RadioButton Rad_Unissex;
    }
}

