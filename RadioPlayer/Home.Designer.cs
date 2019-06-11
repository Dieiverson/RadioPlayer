namespace RadioPlayer
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.WindowsMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtGrid_Radios = new System.Windows.Forms.DataGridView();
            this.lbl_radioAtual = new System.Windows.Forms.Label();
            this.cbb_filtro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Radios)).BeginInit();
            this.SuspendLayout();
            // 
            // WindowsMP
            // 
            this.WindowsMP.Enabled = true;
            this.WindowsMP.Location = new System.Drawing.Point(16, 259);
            this.WindowsMP.Name = "WindowsMP";
            this.WindowsMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMP.OcxState")));
            this.WindowsMP.Size = new System.Drawing.Size(579, 138);
            this.WindowsMP.TabIndex = 0;
            this.WindowsMP.Enter += new System.EventHandler(this.WindowsMP_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o link:";
            // 
            // txt_ip
            // 
            this.txt_ip.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ip.Location = new System.Drawing.Point(98, 235);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(443, 22);
            this.txt_ip.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(547, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dtGrid_Radios
            // 
            this.dtGrid_Radios.AllowUserToAddRows = false;
            this.dtGrid_Radios.AllowUserToDeleteRows = false;
            this.dtGrid_Radios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGrid_Radios.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtGrid_Radios.Location = new System.Drawing.Point(12, 30);
            this.dtGrid_Radios.Name = "dtGrid_Radios";
            this.dtGrid_Radios.ReadOnly = true;
            this.dtGrid_Radios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrid_Radios.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtGrid_Radios.RowHeadersVisible = false;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGrid_Radios.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dtGrid_Radios.Size = new System.Drawing.Size(583, 179);
            this.dtGrid_Radios.TabIndex = 4;
            this.dtGrid_Radios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGrid_Radios_CellClick);
            this.dtGrid_Radios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dtGrid_Radios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGrid_Radios_CellDoubleClick);
            // 
            // lbl_radioAtual
            // 
            this.lbl_radioAtual.AutoSize = true;
            this.lbl_radioAtual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_radioAtual.Location = new System.Drawing.Point(12, 8);
            this.lbl_radioAtual.Name = "lbl_radioAtual";
            this.lbl_radioAtual.Size = new System.Drawing.Size(166, 19);
            this.lbl_radioAtual.TabIndex = 5;
            this.lbl_radioAtual.Text = "Tocando : Massa FM";
            // 
            // cbb_filtro
            // 
            this.cbb_filtro.FormattingEnabled = true;
            this.cbb_filtro.Location = new System.Drawing.Point(78, 408);
            this.cbb_filtro.Name = "cbb_filtro";
            this.cbb_filtro.Size = new System.Drawing.Size(182, 21);
            this.cbb_filtro.TabIndex = 6;
            this.cbb_filtro.SelectedIndexChanged += new System.EventHandler(this.Cbb_filtro_SelectedIndexChanged);
            this.cbb_filtro.TextChanged += new System.EventHandler(this.Cbb_filtro_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Gênero:";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "Rádio By Dieiverson";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.NotifyIcon1_DoubleClick);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(434, 403);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(161, 29);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "Encerrar Aplicação";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 434);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_filtro);
            this.Controls.Add(this.lbl_radioAtual);
            this.Controls.Add(this.dtGrid_Radios);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WindowsMP);
            this.Name = "Home";
            this.Text = "Radio Streaming";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Radios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WindowsMP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtGrid_Radios;
        private System.Windows.Forms.Label lbl_radioAtual;
        private System.Windows.Forms.ComboBox cbb_filtro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btn_close;
    }
}

