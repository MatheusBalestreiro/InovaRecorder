namespace InovaRecorder
{
    partial class FormPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            btnAbrirGravacoes = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            btnIniciarGravacao = new Button();
            btnPausar = new Button();
            label2 = new Label();
            panel2 = new Panel();
            btnSelecionarPastar = new Button();
            panel3 = new Panel();
            txtLocalArquivo = new TextBox();
            btnDespausar = new Button();
            panel4 = new Panel();
            listBoxAudios = new ListBox();
            btnFinalizarGravacao = new Button();
            folderBrowserDialogLocal = new FolderBrowserDialog();
            lblTempo = new Label();
            timerGravacao = new System.Windows.Forms.Timer(components);
            folderBrowserDialog1 = new FolderBrowserDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnAbrirGravacoes
            // 
            btnAbrirGravacoes.BackColor = Color.FromArgb(49, 51, 61);
            btnAbrirGravacoes.FlatAppearance.BorderSize = 0;
            btnAbrirGravacoes.FlatStyle = FlatStyle.Flat;
            btnAbrirGravacoes.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAbrirGravacoes.ForeColor = Color.White;
            btnAbrirGravacoes.Image = (Image)resources.GetObject("btnAbrirGravacoes.Image");
            btnAbrirGravacoes.Location = new Point(292, 149);
            btnAbrirGravacoes.Name = "btnAbrirGravacoes";
            btnAbrirGravacoes.Size = new Size(122, 88);
            btnAbrirGravacoes.TabIndex = 0;
            btnAbrirGravacoes.Text = "Gravações";
            btnAbrirGravacoes.TextAlign = ContentAlignment.BottomCenter;
            btnAbrirGravacoes.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAbrirGravacoes.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 36);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(16, 16);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(171, 175, 181);
            button3.Location = new Point(364, 7);
            button3.Name = "button3";
            button3.Size = new Size(26, 23);
            button3.TabIndex = 5;
            button3.Text = "_";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(194, 36, 36);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(171, 175, 181);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(396, 7);
            button2.Name = "button2";
            button2.Size = new Size(26, 23);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(171, 175, 181);
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 17);
            label1.TabIndex = 3;
            label1.Text = "Gravador de Áudio";
            // 
            // btnIniciarGravacao
            // 
            btnIniciarGravacao.BackColor = SystemColors.Highlight;
            btnIniciarGravacao.FlatAppearance.BorderSize = 0;
            btnIniciarGravacao.FlatStyle = FlatStyle.Flat;
            btnIniciarGravacao.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarGravacao.ForeColor = Color.White;
            btnIniciarGravacao.Image = (Image)resources.GetObject("btnIniciarGravacao.Image");
            btnIniciarGravacao.Location = new Point(10, 47);
            btnIniciarGravacao.Name = "btnIniciarGravacao";
            btnIniciarGravacao.Size = new Size(100, 43);
            btnIniciarGravacao.TabIndex = 3;
            btnIniciarGravacao.Text = " Gravar ";
            btnIniciarGravacao.TextAlign = ContentAlignment.MiddleRight;
            btnIniciarGravacao.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIniciarGravacao.UseVisualStyleBackColor = false;
            btnIniciarGravacao.Click += btnIniciarGravacao_Click;
            // 
            // btnPausar
            // 
            btnPausar.BackColor = Color.FromArgb(49, 51, 61);
            btnPausar.FlatAppearance.BorderSize = 0;
            btnPausar.FlatStyle = FlatStyle.Flat;
            btnPausar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPausar.ForeColor = Color.White;
            btnPausar.Image = (Image)resources.GetObject("btnPausar.Image");
            btnPausar.Location = new Point(127, 47);
            btnPausar.Name = "btnPausar";
            btnPausar.Size = new Size(100, 43);
            btnPausar.TabIndex = 4;
            btnPausar.Text = " Pausar";
            btnPausar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPausar.UseVisualStyleBackColor = false;
            btnPausar.Click += btnPausar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 109);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 5;
            label2.Text = "Salvar em: ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(62, 62, 71);
            panel2.Controls.Add(btnSelecionarPastar);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(82, 103);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(1);
            panel2.Size = new Size(339, 31);
            panel2.TabIndex = 6;
            // 
            // btnSelecionarPastar
            // 
            btnSelecionarPastar.Dock = DockStyle.Right;
            btnSelecionarPastar.FlatAppearance.BorderSize = 0;
            btnSelecionarPastar.FlatStyle = FlatStyle.Flat;
            btnSelecionarPastar.Image = (Image)resources.GetObject("btnSelecionarPastar.Image");
            btnSelecionarPastar.Location = new Point(308, 1);
            btnSelecionarPastar.Name = "btnSelecionarPastar";
            btnSelecionarPastar.Size = new Size(30, 29);
            btnSelecionarPastar.TabIndex = 9;
            btnSelecionarPastar.UseVisualStyleBackColor = true;
            btnSelecionarPastar.Click += btnSelecionarPastar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(40, 43, 50);
            panel3.Controls.Add(txtLocalArquivo);
            panel3.Location = new Point(1, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(307, 29);
            panel3.TabIndex = 7;
            // 
            // txtLocalArquivo
            // 
            txtLocalArquivo.BackColor = Color.FromArgb(40, 43, 50);
            txtLocalArquivo.BorderStyle = BorderStyle.None;
            txtLocalArquivo.Font = new Font("Segoe UI", 10F);
            txtLocalArquivo.ForeColor = Color.White;
            txtLocalArquivo.Location = new Point(8, 5);
            txtLocalArquivo.Name = "txtLocalArquivo";
            txtLocalArquivo.Size = new Size(293, 18);
            txtLocalArquivo.TabIndex = 0;
            // 
            // btnDespausar
            // 
            btnDespausar.BackColor = Color.FromArgb(49, 51, 61);
            btnDespausar.FlatAppearance.BorderSize = 0;
            btnDespausar.FlatStyle = FlatStyle.Flat;
            btnDespausar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDespausar.ForeColor = Color.White;
            btnDespausar.Image = (Image)resources.GetObject("btnDespausar.Image");
            btnDespausar.Location = new Point(127, 47);
            btnDespausar.Name = "btnDespausar";
            btnDespausar.Size = new Size(100, 43);
            btnDespausar.TabIndex = 10;
            btnDespausar.Text = " Continuar";
            btnDespausar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDespausar.UseVisualStyleBackColor = false;
            btnDespausar.Visible = false;
            btnDespausar.Click += btnDespausar_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(62, 62, 71);
            panel4.Controls.Add(listBoxAudios);
            panel4.Location = new Point(12, 149);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(1);
            panel4.Size = new Size(262, 89);
            panel4.TabIndex = 7;
            // 
            // listBoxAudios
            // 
            listBoxAudios.AllowDrop = true;
            listBoxAudios.BackColor = Color.FromArgb(40, 43, 50);
            listBoxAudios.BorderStyle = BorderStyle.None;
            listBoxAudios.Dock = DockStyle.Fill;
            listBoxAudios.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            listBoxAudios.ForeColor = Color.White;
            listBoxAudios.FormattingEnabled = true;
            listBoxAudios.ItemHeight = 17;
            listBoxAudios.Location = new Point(1, 1);
            listBoxAudios.Name = "listBoxAudios";
            listBoxAudios.Size = new Size(260, 87);
            listBoxAudios.TabIndex = 11;
            // 
            // btnFinalizarGravacao
            // 
            btnFinalizarGravacao.BackColor = Color.FromArgb(255, 51, 51);
            btnFinalizarGravacao.FlatAppearance.BorderSize = 0;
            btnFinalizarGravacao.FlatStyle = FlatStyle.Flat;
            btnFinalizarGravacao.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizarGravacao.ForeColor = Color.White;
            btnFinalizarGravacao.Image = (Image)resources.GetObject("btnFinalizarGravacao.Image");
            btnFinalizarGravacao.Location = new Point(10, 47);
            btnFinalizarGravacao.Name = "btnFinalizarGravacao";
            btnFinalizarGravacao.Size = new Size(100, 43);
            btnFinalizarGravacao.TabIndex = 8;
            btnFinalizarGravacao.Text = " Finalizar";
            btnFinalizarGravacao.TextAlign = ContentAlignment.MiddleRight;
            btnFinalizarGravacao.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFinalizarGravacao.UseVisualStyleBackColor = false;
            btnFinalizarGravacao.Visible = false;
            btnFinalizarGravacao.Click += btnFinalizarGravacao_Click;
            // 
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.BackColor = Color.Transparent;
            lblTempo.Font = new Font("Segoe UI Semibold", 28F, FontStyle.Bold);
            lblTempo.ForeColor = Color.White;
            lblTempo.Location = new Point(248, 42);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(166, 51);
            lblTempo.TabIndex = 9;
            lblTempo.Text = "00:00:00";
            // 
            // timerGravacao
            // 
            timerGravacao.Interval = 1000;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 38, 45);
            ClientSize = new Size(427, 251);
            Controls.Add(btnDespausar);
            Controls.Add(lblTempo);
            Controls.Add(btnFinalizarGravacao);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(btnPausar);
            Controls.Add(btnIniciarGravacao);
            Controls.Add(panel1);
            Controls.Add(btnAbrirGravacoes);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAbrirGravacoes;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnIniciarGravacao;
        private Button btnPausar;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TextBox txtLocalArquivo;
        private Button btnFinalizarGravacao;
        private Button btnSelecionarPastar;
        private FolderBrowserDialog folderBrowserDialogLocal;
        private ListView listViewAudios;
        private Label lblTempo;
        private System.Windows.Forms.Timer timerGravacao;
        private Button btnDespausar;
        private FolderBrowserDialog folderBrowserDialog1;
        private ListBox listBoxAudios;
    }
}
