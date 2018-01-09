namespace AjustaXMLProgramas
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.tbPastaXML = new System.Windows.Forms.TextBox();
            this.fbdAbrePastaXML = new System.Windows.Forms.FolderBrowserDialog();
            this.btnAbrirPasta = new System.Windows.Forms.Button();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.bkwExecuta = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe a Pasta:";
            // 
            // tbPastaXML
            // 
            this.tbPastaXML.Location = new System.Drawing.Point(90, 17);
            this.tbPastaXML.Name = "tbPastaXML";
            this.tbPastaXML.Size = new System.Drawing.Size(227, 20);
            this.tbPastaXML.TabIndex = 1;
            // 
            // btnAbrirPasta
            // 
            this.btnAbrirPasta.Location = new System.Drawing.Point(323, 17);
            this.btnAbrirPasta.Name = "btnAbrirPasta";
            this.btnAbrirPasta.Size = new System.Drawing.Size(39, 23);
            this.btnAbrirPasta.TabIndex = 2;
            this.btnAbrirPasta.Text = "....";
            this.btnAbrirPasta.UseVisualStyleBackColor = true;
            this.btnAbrirPasta.Click += new System.EventHandler(this.btnAbrirPasta_Click);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(97, 66);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 23);
            this.btnExecutar.TabIndex = 3;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(178, 66);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // bkwExecuta
            // 
            this.bkwExecuta.WorkerReportsProgress = true;
            this.bkwExecuta.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkwExecuta_DoWork);
            this.bkwExecuta.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkwExecuta_ProgressChanged);
            this.bkwExecuta.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkwExecuta_RunWorkerCompleted);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 140);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.btnAbrirPasta);
            this.Controls.Add(this.tbPastaXML);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altera XML Programa Unipass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPastaXML;
        private System.Windows.Forms.FolderBrowserDialog fbdAbrePastaXML;
        private System.Windows.Forms.Button btnAbrirPasta;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Button btnCancelar;
        public System.ComponentModel.BackgroundWorker bkwExecuta;
    }
}

