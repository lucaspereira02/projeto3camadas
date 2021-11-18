
namespace Projeto3Camadas.Ui
{
    partial class Netflix
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblMedicamento = new System.Windows.Forms.Label();
            this.lblComposicao = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtfilme = new System.Windows.Forms.TextBox();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvNetflix = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNetflix)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(47, 40);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID";
            // 
            // lblMedicamento
            // 
            this.lblMedicamento.AutoSize = true;
            this.lblMedicamento.Location = new System.Drawing.Point(188, 40);
            this.lblMedicamento.Name = "lblMedicamento";
            this.lblMedicamento.Size = new System.Drawing.Size(38, 13);
            this.lblMedicamento.TabIndex = 2;
            this.lblMedicamento.Text = "FILME";
            this.lblMedicamento.Click += new System.EventHandler(this.lblMedicamento_Click);
            // 
            // lblComposicao
            // 
            this.lblComposicao.AutoSize = true;
            this.lblComposicao.Location = new System.Drawing.Point(300, 40);
            this.lblComposicao.Name = "lblComposicao";
            this.lblComposicao.Size = new System.Drawing.Size(69, 13);
            this.lblComposicao.TabIndex = 3;
            this.lblComposicao.Text = "CATEGORIA";
            this.lblComposicao.Click += new System.EventHandler(this.lblComposicao_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 56);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 4;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtfilme
            // 
            this.txtfilme.Location = new System.Drawing.Point(156, 56);
            this.txtfilme.Name = "txtfilme";
            this.txtfilme.Size = new System.Drawing.Size(100, 20);
            this.txtfilme.TabIndex = 5;
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(286, 56);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(100, 20);
            this.txtcategoria.TabIndex = 6;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 104);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 23);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(156, 104);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(286, 104);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 23);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // dgvNetflix
            // 
            this.dgvNetflix.BackgroundColor = System.Drawing.Color.White;
            this.dgvNetflix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNetflix.Location = new System.Drawing.Point(22, 146);
            this.dgvNetflix.Name = "dgvNetflix";
            this.dgvNetflix.Size = new System.Drawing.Size(364, 185);
            this.dgvNetflix.TabIndex = 10;
            this.dgvNetflix.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNetflix_CellContentClick);
            // 
            // Netflix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(416, 365);
            this.Controls.Add(this.dgvNetflix);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.txtfilme);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblComposicao);
            this.Controls.Add(this.lblMedicamento);
            this.Controls.Add(this.lblId);
            this.Name = "Netflix";
            this.Text = "Netflix";
            this.Load += new System.EventHandler(this.Netflix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNetflix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblMedicamento;
        private System.Windows.Forms.Label lblComposicao;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtfilme;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvNetflix;
    }
}