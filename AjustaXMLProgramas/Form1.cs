using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Reflection;
using System.IO;
using System.Collections;
using System.Xml.Linq;

namespace AjustaXMLProgramas
{
    public partial class FormPrincipal : Form
    {
        public static ProgressBar pBar;
        public FormPrincipal()
        {
            InitializeComponent();
         //  tbPastaXML.Text = @"C:\teste\";
            
        }

        private void btnAbrirPasta_Click(object sender, EventArgs e)
        {
            if (fbdAbrePastaXML.ShowDialog() == DialogResult.OK)
            {
                string caminho = fbdAbrePastaXML.SelectedPath;
                if (!caminho[caminho.Length - 1].Equals('\\'))
                    caminho += @"\";
                tbPastaXML.Text = caminho;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            

                pBar = new System.Windows.Forms.ProgressBar();
                pBar.Location = new System.Drawing.Point(298, 105);
                pBar.Name = "pBar";
                pBar.Size = new System.Drawing.Size(121, 23);
                pBar.TabIndex = 8;
                pBar.Visible = true;
                Controls.Add(pBar);
                btnExecutar.Text = "Aguarde...";
                bkwExecuta.RunWorkerAsync();
            
          
        }
        private void bkwExecuta_DoWork(object sender, DoWorkEventArgs e)
        {
            string arquivo = "";
            try
            {
                //Marca o diretório a ser listado
                DirectoryInfo diretorio = new DirectoryInfo(tbPastaXML.Text);
                //Executa função GetFile(Lista os arquivos desejados de acordo com o parametro)
                FileInfo[] Arquivos = diretorio.GetFiles("*.xml");

                XmlDocument config = null;
                int i = 0;

                foreach (FileInfo fileinfo in Arquivos)
                {
                    // MessageBox.Show(tbPastaXML.Text + fileinfo.Name);
                    i++;
                    int percents = (i * 100) / Arquivos.Count();

                    bkwExecuta.ReportProgress(percents, i);

                    arquivo = tbPastaXML.Text + fileinfo.Name;
                    FileInfo info = new FileInfo(arquivo);
                    //   incrementa();
                    //        MessageBox.Show(tbPastaXML.Text + fileinfo.Name + " tamanho = " + info.Length);
                    if (info.Length > 0)
                    {

                        config = new XmlDocument();
                        config.Load(arquivo);

                        LogHelper.GravarLog()
                    }
                }
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(string.Format("Não foi possível executar a ação. Erro: {0}" + arquivo , ex.InnerException));    
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
            }
        }
              
        private void bkwExecuta_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnExecutar.Text = "Executar";
            pBar.Value = 0;
            pBar.Visible = false;
            MessageBox.Show("Processamento realizado com sucesso!");
        }
        private void bkwExecuta_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pBar.Value = e.ProgressPercentage;
        }

        private void cbTipoGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  MessageBox.Show("selecionou = " + cbTipoGroup.SelectedIndex);
        }

        public int indiceCombo { get; set; }
    }
}
