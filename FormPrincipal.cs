using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace InovaRecorder
{
    public partial class FormPrincipal : Form
    {
        private string pasta;
        private int segundosGravados = 0;
        private ConfiguracaoApp configuracoes;

        public FormPrincipal()
        {
            InitializeComponent();

            // CARREGA CONFIGURAÇÕES SALVAS
            configuracoes = GerenciadorConfiguracoes.CarregarConfiguracoes();
            pasta = configuracoes.PastaGravacoes;

            // GARANTE QUE A PASTA EXISTE
            if (!Directory.Exists(pasta))
            {
                try
                {
                    Directory.CreateDirectory(pasta);
                }
                catch (Exception ex)
                {
                    pasta = Path.GetTempPath(); // Usa pasta temporária se der erro
                }
            }

            // CONFIGURA A INTERFACE
            timerGravacao.Interval = 1000;
            timerGravacao.Tick += timerGravacao_Tick;

            this.FormBorderStyle = FormBorderStyle.None;

            listBoxAudios.MouseDown += listBoxAudios_MouseDown;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            panel1.MouseDown += panelBarra_MouseDown;


            // EXIBE O CAMINHO ATUAL NA TEXTBOX
            txtLocalArquivo.Text = pasta;



            // CARREGA OS ARQUIVOS AUTOMATICAMENTE AO INICIAR
            CarregarArquivos();
        }

        // ---- Funções da barra de título ----
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        private void panelBarra_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // ---- Listagem de arquivos COM LISTBOX ----
        private void CarregarArquivos()
        {
            listBoxAudios.Items.Clear();

            if (Directory.Exists(pasta))
            {
                try
                {
                    // Ordena por data e pega os 5 mais recentes
                    var arquivos = Directory.GetFiles(pasta, "*.PNG")
                                           .Select(arquivo => new FileInfo(arquivo))
                                           .OrderByDescending(f => f.LastWriteTime)
                                           .Take(5)
                                           .ToList();

                    foreach (var fileInfo in arquivos)
                    {
                        // Adiciona ao ListBox
                        listBoxAudios.Items.Add(fileInfo.Name);
                    }

                    // Feedback visual
                    if (listBoxAudios.Items.Count == 0)
                    {
                        listBoxAudios.Items.Add("Nenhum arquivo PNG encontrado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar arquivos: {ex.Message}");
                }
            }
            else
            {
                listBoxAudios.Items.Add("Pasta não encontrada: " + pasta);
            }
        }


        // ---- Drag & Drop com ListBox ----
        private void listBoxAudios_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBoxAudios.SelectedItem == null) return;

            if (listBoxAudios.SelectedItem.ToString().StartsWith("Nenhum") ||
                listBoxAudios.SelectedItem.ToString().StartsWith("Pasta"))
                return;

            // Obtém o caminho completo do arquivo selecionado
            string arquivoSelecionado = Path.Combine(pasta, listBoxAudios.SelectedItem.ToString());

            if (File.Exists(arquivoSelecionado))
            {
                var arquivos = new string[] { arquivoSelecionado };
                DataObject data = new DataObject(DataFormats.FileDrop, arquivos);
                DoDragDrop(data, DragDropEffects.Copy);
            }
        }

        private void btnSelecionarPastar_Click(object sender, EventArgs e)
        {
            folderBrowserDialogLocal.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialogLocal.SelectedPath = pasta; // Mostra a pasta atual

            if (folderBrowserDialogLocal.ShowDialog() == DialogResult.OK)
            {
                string caminhoSelecionado = folderBrowserDialogLocal.SelectedPath;

                pasta = caminhoSelecionado;
                configuracoes.PastaGravacoes = pasta;

                GerenciadorConfiguracoes.SalvarConfiguracoes(configuracoes);

                txtLocalArquivo.Text = pasta;

                CarregarArquivos();
            }
        }

        private void btnIniciarGravacao_Click(object sender, EventArgs e)
        {
            btnFinalizarGravacao.Visible = true;
            btnIniciarGravacao.Visible = false;
            segundosGravados = 0;
            lblTempo.Text = "00:00:00";
            timerGravacao.Start();
        }

        private void btnFinalizarGravacao_Click(object sender, EventArgs e)
        {
            btnIniciarGravacao.Visible = true;
            btnFinalizarGravacao.Visible = false;
            timerGravacao.Stop();

            CarregarArquivos();
        }

        private void timerGravacao_Tick(object sender, EventArgs e)
        {
            segundosGravados++;
            lblTempo.Text = TimeSpan.FromSeconds(segundosGravados).ToString(@"hh\:mm\:ss");
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            btnDespausar.Visible = true;
            btnPausar.Visible = false;
        }

        private void btnDespausar_Click(object sender, EventArgs e)
        {
            btnPausar.Visible = true;
            btnDespausar.Visible = false;
        }
    }
}