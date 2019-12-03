namespace EstacionamentoFramework
{
    partial class FormEstacionamento
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
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.textBoxQuantidadeVagas = new System.Windows.Forms.TextBox();
            this.labelQuantidadeVagas = new System.Windows.Forms.Label();
            this.textBoxCancelaSaida = new System.Windows.Forms.TextBox();
            this.labelCancelasEntrada = new System.Windows.Forms.Label();
            this.labelCancelaSaida = new System.Windows.Forms.Label();
            this.textBoxCancelaEntrada = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonEntraCarro = new System.Windows.Forms.Button();
            this.textBoxQuantidadeCarroEntrar = new System.Windows.Forms.TextBox();
            this.panelConfig = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxQuantidadeCarroSair = new System.Windows.Forms.TextBox();
            this.buttonSairCarro = new System.Windows.Forms.Button();
            this.panelConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Location = new System.Drawing.Point(22, 113);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(203, 20);
            this.buttonIniciar.TabIndex = 4;
            this.buttonIniciar.Text = "Iniciar";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // textBoxQuantidadeVagas
            // 
            this.textBoxQuantidadeVagas.Location = new System.Drawing.Point(139, 37);
            this.textBoxQuantidadeVagas.Name = "textBoxQuantidadeVagas";
            this.textBoxQuantidadeVagas.Size = new System.Drawing.Size(86, 20);
            this.textBoxQuantidadeVagas.TabIndex = 1;
            this.textBoxQuantidadeVagas.Text = "10";
            // 
            // labelQuantidadeVagas
            // 
            this.labelQuantidadeVagas.AutoSize = true;
            this.labelQuantidadeVagas.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.labelQuantidadeVagas.Location = new System.Drawing.Point(20, 40);
            this.labelQuantidadeVagas.Name = "labelQuantidadeVagas";
            this.labelQuantidadeVagas.Size = new System.Drawing.Size(113, 13);
            this.labelQuantidadeVagas.TabIndex = 2;
            this.labelQuantidadeVagas.Text = "Quantidade de Vagas:";
            // 
            // textBoxCancelaSaida
            // 
            this.textBoxCancelaSaida.Location = new System.Drawing.Point(139, 87);
            this.textBoxCancelaSaida.Name = "textBoxCancelaSaida";
            this.textBoxCancelaSaida.Size = new System.Drawing.Size(86, 20);
            this.textBoxCancelaSaida.TabIndex = 3;
            this.textBoxCancelaSaida.Text = "2";
            // 
            // labelCancelasEntrada
            // 
            this.labelCancelasEntrada.AutoSize = true;
            this.labelCancelasEntrada.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.labelCancelasEntrada.Location = new System.Drawing.Point(20, 64);
            this.labelCancelasEntrada.Name = "labelCancelasEntrada";
            this.labelCancelasEntrada.Size = new System.Drawing.Size(109, 13);
            this.labelCancelasEntrada.TabIndex = 2;
            this.labelCancelasEntrada.Text = "Cancelas de Entrada:";
            // 
            // labelCancelaSaida
            // 
            this.labelCancelaSaida.AutoSize = true;
            this.labelCancelaSaida.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.labelCancelaSaida.Location = new System.Drawing.Point(20, 90);
            this.labelCancelaSaida.Name = "labelCancelaSaida";
            this.labelCancelaSaida.Size = new System.Drawing.Size(99, 13);
            this.labelCancelaSaida.TabIndex = 2;
            this.labelCancelaSaida.Text = "Cancelas de Saida:";
            // 
            // textBoxCancelaEntrada
            // 
            this.textBoxCancelaEntrada.Location = new System.Drawing.Point(139, 61);
            this.textBoxCancelaEntrada.Name = "textBoxCancelaEntrada";
            this.textBoxCancelaEntrada.Size = new System.Drawing.Size(86, 20);
            this.textBoxCancelaEntrada.TabIndex = 2;
            this.textBoxCancelaEntrada.Text = "2";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(383, 140);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(0, 13);
            this.labelOutput.TabIndex = 3;
            // 
            // buttonEntraCarro
            // 
            this.buttonEntraCarro.Location = new System.Drawing.Point(24, 312);
            this.buttonEntraCarro.Name = "buttonEntraCarro";
            this.buttonEntraCarro.Size = new System.Drawing.Size(107, 20);
            this.buttonEntraCarro.TabIndex = 4;
            this.buttonEntraCarro.Text = "Entrar Carro";
            this.buttonEntraCarro.UseVisualStyleBackColor = true;
            this.buttonEntraCarro.Click += new System.EventHandler(this.buttonEntraCarro_Click);
            // 
            // textBoxQuantidadeCarroEntrar
            // 
            this.textBoxQuantidadeCarroEntrar.Location = new System.Drawing.Point(136, 313);
            this.textBoxQuantidadeCarroEntrar.Name = "textBoxQuantidadeCarroEntrar";
            this.textBoxQuantidadeCarroEntrar.Size = new System.Drawing.Size(86, 20);
            this.textBoxQuantidadeCarroEntrar.TabIndex = 5;
            this.textBoxQuantidadeCarroEntrar.Text = "1";
            // 
            // panelConfig
            // 
            this.panelConfig.Controls.Add(this.labelQuantidadeVagas);
            this.panelConfig.Controls.Add(this.labelCancelasEntrada);
            this.panelConfig.Controls.Add(this.textBoxCancelaSaida);
            this.panelConfig.Controls.Add(this.buttonIniciar);
            this.panelConfig.Controls.Add(this.labelCancelaSaida);
            this.panelConfig.Controls.Add(this.textBoxQuantidadeVagas);
            this.panelConfig.Controls.Add(this.textBoxCancelaEntrada);
            this.panelConfig.Location = new System.Drawing.Point(12, 12);
            this.panelConfig.Name = "panelConfig";
            this.panelConfig.Size = new System.Drawing.Size(246, 141);
            this.panelConfig.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Livre});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(443, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 390);
            this.dataGridView1.TabIndex = 7;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Vaga";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Livre
            // 
            this.Livre.HeaderText = "Disponivel";
            this.Livre.Name = "Livre";
            this.Livre.ReadOnly = true;
            // 
            // textBoxQuantidadeCarroSair
            // 
            this.textBoxQuantidadeCarroSair.Location = new System.Drawing.Point(136, 339);
            this.textBoxQuantidadeCarroSair.Name = "textBoxQuantidadeCarroSair";
            this.textBoxQuantidadeCarroSair.Size = new System.Drawing.Size(86, 20);
            this.textBoxQuantidadeCarroSair.TabIndex = 9;
            this.textBoxQuantidadeCarroSair.Text = "1";
            // 
            // buttonSairCarro
            // 
            this.buttonSairCarro.Location = new System.Drawing.Point(24, 338);
            this.buttonSairCarro.Name = "buttonSairCarro";
            this.buttonSairCarro.Size = new System.Drawing.Size(107, 20);
            this.buttonSairCarro.TabIndex = 8;
            this.buttonSairCarro.Text = "Sair Carro";
            this.buttonSairCarro.UseVisualStyleBackColor = true;
            this.buttonSairCarro.Click += new System.EventHandler(this.buttonSairCarro_Click);
            // 
            // FormEstacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.textBoxQuantidadeCarroSair);
            this.Controls.Add(this.buttonSairCarro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelConfig);
            this.Controls.Add(this.textBoxQuantidadeCarroEntrar);
            this.Controls.Add(this.buttonEntraCarro);
            this.Controls.Add(this.labelOutput);
            this.Name = "FormEstacionamento";
            this.Text = "FormEstacionamento";
            this.panelConfig.ResumeLayout(false);
            this.panelConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.TextBox textBoxQuantidadeVagas;
        private System.Windows.Forms.Label labelQuantidadeVagas;
        private System.Windows.Forms.TextBox textBoxCancelaSaida;
        private System.Windows.Forms.Label labelCancelasEntrada;
        private System.Windows.Forms.Label labelCancelaSaida;
        private System.Windows.Forms.TextBox textBoxCancelaEntrada;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonEntraCarro;
        private System.Windows.Forms.TextBox textBoxQuantidadeCarroEntrar;
        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Livre;
        private System.Windows.Forms.TextBox textBoxQuantidadeCarroSair;
        private System.Windows.Forms.Button buttonSairCarro;
    }
}
