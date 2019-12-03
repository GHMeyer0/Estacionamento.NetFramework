namespace EstacionamentoSem
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
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Location = new System.Drawing.Point(630, 25);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(154, 23);
            this.buttonIniciar.TabIndex = 4;
            this.buttonIniciar.Text = "Iniciar";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // textBoxQuantidadeVagas
            // 
            this.textBoxQuantidadeVagas.Location = new System.Drawing.Point(148, 25);
            this.textBoxQuantidadeVagas.Name = "textBoxQuantidadeVagas";
            this.textBoxQuantidadeVagas.Size = new System.Drawing.Size(100, 23);
            this.textBoxQuantidadeVagas.TabIndex = 1;
            // 
            // labelQuantidadeVagas
            // 
            this.labelQuantidadeVagas.AutoSize = true;
            this.labelQuantidadeVagas.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.labelQuantidadeVagas.Location = new System.Drawing.Point(21, 29);
            this.labelQuantidadeVagas.Name = "labelQuantidadeVagas";
            this.labelQuantidadeVagas.Size = new System.Drawing.Size(121, 15);
            this.labelQuantidadeVagas.TabIndex = 2;
            this.labelQuantidadeVagas.Text = "Quantidade de Vagas:";
            // 
            // textBoxCancelaSaida
            // 
            this.textBoxCancelaSaida.Location = new System.Drawing.Point(147, 83);
            this.textBoxCancelaSaida.Name = "textBoxCancelaSaida";
            this.textBoxCancelaSaida.Size = new System.Drawing.Size(100, 23);
            this.textBoxCancelaSaida.TabIndex = 3;
            // 
            // labelCancelasEntrada
            // 
            this.labelCancelasEntrada.AutoSize = true;
            this.labelCancelasEntrada.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.labelCancelasEntrada.Location = new System.Drawing.Point(21, 57);
            this.labelCancelasEntrada.Name = "labelCancelasEntrada";
            this.labelCancelasEntrada.Size = new System.Drawing.Size(116, 15);
            this.labelCancelasEntrada.TabIndex = 2;
            this.labelCancelasEntrada.Text = "Cancelas de Entrada:";
            // 
            // labelCancelaSaida
            // 
            this.labelCancelaSaida.AutoSize = true;
            this.labelCancelaSaida.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.labelCancelaSaida.Location = new System.Drawing.Point(21, 86);
            this.labelCancelaSaida.Name = "labelCancelaSaida";
            this.labelCancelaSaida.Size = new System.Drawing.Size(104, 15);
            this.labelCancelaSaida.TabIndex = 2;
            this.labelCancelaSaida.Text = "Cancelas de Saida:";
            // 
            // textBoxCancelaEntrada
            // 
            this.textBoxCancelaEntrada.Location = new System.Drawing.Point(147, 54);
            this.textBoxCancelaEntrada.Name = "textBoxCancelaEntrada";
            this.textBoxCancelaEntrada.Size = new System.Drawing.Size(100, 23);
            this.textBoxCancelaEntrada.TabIndex = 2;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(447, 161);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(0, 15);
            this.labelOutput.TabIndex = 3;
            // 
            // buttonEntraCarro
            // 
            this.buttonEntraCarro.Location = new System.Drawing.Point(21, 395);
            this.buttonEntraCarro.Name = "buttonEntraCarro";
            this.buttonEntraCarro.Size = new System.Drawing.Size(125, 23);
            this.buttonEntraCarro.TabIndex = 4;
            this.buttonEntraCarro.Text = "Entrar Carro";
            this.buttonEntraCarro.UseVisualStyleBackColor = true;
            this.buttonEntraCarro.Click += new System.EventHandler(this.buttonEntraCarro_Click);
            // 
            // textBoxQuantidadeCarroEntrar
            // 
            this.textBoxQuantidadeCarroEntrar.Location = new System.Drawing.Point(152, 396);
            this.textBoxQuantidadeCarroEntrar.Name = "textBoxQuantidadeCarroEntrar";
            this.textBoxQuantidadeCarroEntrar.Size = new System.Drawing.Size(100, 23);
            this.textBoxQuantidadeCarroEntrar.TabIndex = 5;
            this.textBoxQuantidadeCarroEntrar.Text = "1";
            // 
            // FormEstacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxQuantidadeCarroEntrar);
            this.Controls.Add(this.buttonEntraCarro);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelCancelaSaida);
            this.Controls.Add(this.labelQuantidadeVagas);
            this.Controls.Add(this.textBoxCancelaEntrada);
            this.Controls.Add(this.textBoxQuantidadeVagas);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.textBoxCancelaSaida);
            this.Controls.Add(this.labelCancelasEntrada);
            this.Name = "FormEstacionamento";
            this.Text = "FormEstacionamento";

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
    }
}