namespace Gestao_Turmas
{
    partial class Alunos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.l_inicial = new System.Windows.Forms.Label();
            this.l_nome = new System.Windows.Forms.Label();
            this.l_num_aluno = new System.Windows.Forms.Label();
            this.l_email = new System.Windows.Forms.Label();
            this.l_contacto = new System.Windows.Forms.Label();
            this.l_genero = new System.Windows.Forms.Label();
            this.dt_nasc = new System.Windows.Forms.DateTimePicker();
            this.l_data_nasc = new System.Windows.Forms.Label();
            this.txt_nome_alunos = new System.Windows.Forms.TextBox();
            this.txt_email_alunos = new System.Windows.Forms.TextBox();
            this.txt_contacto_alunos = new System.Windows.Forms.TextBox();
            this.txt_num_aluno = new System.Windows.Forms.TextBox();
            this.bt_menu = new System.Windows.Forms.Button();
            this.bt_alterar = new System.Windows.Forms.Button();
            this.bt_adicionar = new System.Windows.Forms.Button();
            this.bt_remover = new System.Windows.Forms.Button();
            this.dgv_alunos = new System.Windows.Forms.DataGridView();
            this.l_turmas = new System.Windows.Forms.Label();
            this.cb_turmas = new System.Windows.Forms.ComboBox();
            this.check_genero = new System.Windows.Forms.CheckedListBox();
            this.procurar_turma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).BeginInit();
            this.SuspendLayout();
            // 
            // l_inicial
            // 
            this.l_inicial.AutoSize = true;
            this.l_inicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_inicial.Location = new System.Drawing.Point(706, 31);
            this.l_inicial.Name = "l_inicial";
            this.l_inicial.Size = new System.Drawing.Size(235, 73);
            this.l_inicial.TabIndex = 0;
            this.l_inicial.Text = "Alunos";
            this.l_inicial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_nome
            // 
            this.l_nome.AutoSize = true;
            this.l_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_nome.Location = new System.Drawing.Point(115, 171);
            this.l_nome.Name = "l_nome";
            this.l_nome.Size = new System.Drawing.Size(267, 31);
            this.l_nome.TabIndex = 1;
            this.l_nome.Text = "NOME COMPLETO";
            // 
            // l_num_aluno
            // 
            this.l_num_aluno.AutoSize = true;
            this.l_num_aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_num_aluno.Location = new System.Drawing.Point(115, 512);
            this.l_num_aluno.Name = "l_num_aluno";
            this.l_num_aluno.Size = new System.Drawing.Size(296, 31);
            this.l_num_aluno.TabIndex = 2;
            this.l_num_aluno.Text = "NÚMERO DE ALUNO";
            // 
            // l_email
            // 
            this.l_email.AutoSize = true;
            this.l_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_email.Location = new System.Drawing.Point(115, 393);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(100, 31);
            this.l_email.TabIndex = 3;
            this.l_email.Text = "EMAIL";
            // 
            // l_contacto
            // 
            this.l_contacto.AutoSize = true;
            this.l_contacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_contacto.Location = new System.Drawing.Point(532, 171);
            this.l_contacto.Name = "l_contacto";
            this.l_contacto.Size = new System.Drawing.Size(176, 31);
            this.l_contacto.TabIndex = 4;
            this.l_contacto.Text = "CONTACTO";
            // 
            // l_genero
            // 
            this.l_genero.AutoSize = true;
            this.l_genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_genero.Location = new System.Drawing.Point(532, 284);
            this.l_genero.Name = "l_genero";
            this.l_genero.Size = new System.Drawing.Size(138, 31);
            this.l_genero.TabIndex = 5;
            this.l_genero.Text = "GÉNERO";
            // 
            // dt_nasc
            // 
            this.dt_nasc.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dt_nasc.Checked = false;
            this.dt_nasc.CustomFormat = "";
            this.dt_nasc.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dt_nasc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_nasc.Location = new System.Drawing.Point(214, 332);
            this.dt_nasc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_nasc.MaxDate = new System.DateTime(2025, 5, 3, 0, 0, 0, 0);
            this.dt_nasc.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dt_nasc.Name = "dt_nasc";
            this.dt_nasc.RightToLeftLayout = true;
            this.dt_nasc.Size = new System.Drawing.Size(153, 26);
            this.dt_nasc.TabIndex = 6;
            this.dt_nasc.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // l_data_nasc
            // 
            this.l_data_nasc.AutoSize = true;
            this.l_data_nasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_data_nasc.Location = new System.Drawing.Point(115, 284);
            this.l_data_nasc.Name = "l_data_nasc";
            this.l_data_nasc.Size = new System.Drawing.Size(347, 31);
            this.l_data_nasc.TabIndex = 7;
            this.l_data_nasc.Text = "DATA  DE NASCIMENTO";
            // 
            // txt_nome_alunos
            // 
            this.txt_nome_alunos.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_nome_alunos.Location = new System.Drawing.Point(115, 218);
            this.txt_nome_alunos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nome_alunos.Name = "txt_nome_alunos";
            this.txt_nome_alunos.Size = new System.Drawing.Size(334, 29);
            this.txt_nome_alunos.TabIndex = 8;
            this.txt_nome_alunos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_email_alunos
            // 
            this.txt_email_alunos.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_email_alunos.Location = new System.Drawing.Point(115, 439);
            this.txt_email_alunos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_email_alunos.Name = "txt_email_alunos";
            this.txt_email_alunos.Size = new System.Drawing.Size(334, 29);
            this.txt_email_alunos.TabIndex = 9;
            this.txt_email_alunos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_contacto_alunos
            // 
            this.txt_contacto_alunos.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_contacto_alunos.Location = new System.Drawing.Point(532, 218);
            this.txt_contacto_alunos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_contacto_alunos.Name = "txt_contacto_alunos";
            this.txt_contacto_alunos.Size = new System.Drawing.Size(235, 29);
            this.txt_contacto_alunos.TabIndex = 10;
            this.txt_contacto_alunos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_num_aluno
            // 
            this.txt_num_aluno.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_num_aluno.Location = new System.Drawing.Point(115, 566);
            this.txt_num_aluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_num_aluno.Name = "txt_num_aluno";
            this.txt_num_aluno.Size = new System.Drawing.Size(138, 29);
            this.txt_num_aluno.TabIndex = 12;
            this.txt_num_aluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_menu
            // 
            this.bt_menu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_menu.ForeColor = System.Drawing.Color.White;
            this.bt_menu.Location = new System.Drawing.Point(115, 31);
            this.bt_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_menu.Name = "bt_menu";
            this.bt_menu.Size = new System.Drawing.Size(206, 49);
            this.bt_menu.TabIndex = 25;
            this.bt_menu.Text = "MENU";
            this.bt_menu.UseVisualStyleBackColor = false;
            this.bt_menu.Click += new System.EventHandler(this.bt_menu_Click);
            // 
            // bt_alterar
            // 
            this.bt_alterar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_alterar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_alterar.Location = new System.Drawing.Point(561, 650);
            this.bt_alterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_alterar.Name = "bt_alterar";
            this.bt_alterar.Size = new System.Drawing.Size(206, 49);
            this.bt_alterar.TabIndex = 26;
            this.bt_alterar.Text = "ALTERAR";
            this.bt_alterar.UseVisualStyleBackColor = false;
            this.bt_alterar.Click += new System.EventHandler(this.bt_alterar_Click);
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_adicionar.Location = new System.Drawing.Point(115, 650);
            this.bt_adicionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_adicionar.Name = "bt_adicionar";
            this.bt_adicionar.Size = new System.Drawing.Size(206, 49);
            this.bt_adicionar.TabIndex = 27;
            this.bt_adicionar.Text = "ADICIONAR";
            this.bt_adicionar.UseVisualStyleBackColor = false;
            this.bt_adicionar.Click += new System.EventHandler(this.bt_adicionar_Click);
            // 
            // bt_remover
            // 
            this.bt_remover.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_remover.Location = new System.Drawing.Point(339, 650);
            this.bt_remover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(206, 49);
            this.bt_remover.TabIndex = 28;
            this.bt_remover.Text = "REMOVER";
            this.bt_remover.UseVisualStyleBackColor = false;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click);
            // 
            // dgv_alunos
            // 
            this.dgv_alunos.AllowUserToResizeColumns = false;
            this.dgv_alunos.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_alunos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_alunos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_alunos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_alunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_alunos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_alunos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_alunos.GridColor = System.Drawing.SystemColors.MenuText;
            this.dgv_alunos.Location = new System.Drawing.Point(866, 218);
            this.dgv_alunos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_alunos.Name = "dgv_alunos";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_alunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_alunos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_alunos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_alunos.RowTemplate.Height = 29;
            this.dgv_alunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_alunos.Size = new System.Drawing.Size(669, 481);
            this.dgv_alunos.TabIndex = 30;
            this.dgv_alunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_alunos_CellContentClick);
            // 
            // l_turmas
            // 
            this.l_turmas.AutoSize = true;
            this.l_turmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_turmas.Location = new System.Drawing.Point(540, 462);
            this.l_turmas.Name = "l_turmas";
            this.l_turmas.Size = new System.Drawing.Size(157, 37);
            this.l_turmas.TabIndex = 32;
            this.l_turmas.Text = "TURMAS";
            // 
            // cb_turmas
            // 
            this.cb_turmas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_turmas.FormattingEnabled = true;
            this.cb_turmas.Location = new System.Drawing.Point(540, 512);
            this.cb_turmas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_turmas.Name = "cb_turmas";
            this.cb_turmas.Size = new System.Drawing.Size(227, 29);
            this.cb_turmas.TabIndex = 34;
            this.cb_turmas.SelectedIndexChanged += new System.EventHandler(this.cb_turmas_SelectedIndexChanged_1);
            // 
            // check_genero
            // 
            this.check_genero.CheckOnClick = true;
            this.check_genero.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.check_genero.FormattingEnabled = true;
            this.check_genero.Location = new System.Drawing.Point(540, 332);
            this.check_genero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check_genero.Name = "check_genero";
            this.check_genero.Size = new System.Drawing.Size(227, 76);
            this.check_genero.TabIndex = 35;
            this.check_genero.SelectedIndexChanged += new System.EventHandler(this.check_genero_SelectedIndexChanged);
            // 
            // procurar_turma
            // 
            this.procurar_turma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.procurar_turma.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.procurar_turma.ForeColor = System.Drawing.SystemColors.WindowText;
            this.procurar_turma.Location = new System.Drawing.Point(866, 181);
            this.procurar_turma.Name = "procurar_turma";
            this.procurar_turma.PlaceholderText = "  🔍  Procurar Turma";
            this.procurar_turma.Size = new System.Drawing.Size(669, 32);
            this.procurar_turma.TabIndex = 105;
            this.procurar_turma.TextChanged += new System.EventHandler(this.search_nome_TextChanged);
            // 
            // Alunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1664, 775);
            this.Controls.Add(this.procurar_turma);
            this.Controls.Add(this.check_genero);
            this.Controls.Add(this.cb_turmas);
            this.Controls.Add(this.l_turmas);
            this.Controls.Add(this.dgv_alunos);
            this.Controls.Add(this.bt_remover);
            this.Controls.Add(this.bt_adicionar);
            this.Controls.Add(this.bt_alterar);
            this.Controls.Add(this.bt_menu);
            this.Controls.Add(this.txt_num_aluno);
            this.Controls.Add(this.txt_contacto_alunos);
            this.Controls.Add(this.txt_email_alunos);
            this.Controls.Add(this.txt_nome_alunos);
            this.Controls.Add(this.l_data_nasc);
            this.Controls.Add(this.dt_nasc);
            this.Controls.Add(this.l_genero);
            this.Controls.Add(this.l_contacto);
            this.Controls.Add(this.l_email);
            this.Controls.Add(this.l_num_aluno);
            this.Controls.Add(this.l_nome);
            this.Controls.Add(this.l_inicial);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Alunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alunos";
            this.Load += new System.EventHandler(this.Alunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label l_inicial;
        private Label l_nome;
        private Label l_num_aluno;
        private Label l_email;
        private Label l_contacto;
        private Label l_genero;
        private DateTimePicker dt_nasc;
        private Label l_data_nasc;
        private TextBox txt_nome_alunos;
        private TextBox txt_email_alunos;
        private TextBox txt_contacto_alunos;
        private TextBox txt_num_aluno;
        private Button bt_menu;
        private Button bt_alterar;
        private Button bt_adicionar;
        private Button bt_remover;
        private TextBox txt_genero;
        private DataGridView dgv_alunos;
        private Label l_turmas;
        private ComboBox cb_turmas;
        private CheckedListBox check_genero;
        private TextBox procurar_turma;
    }
}