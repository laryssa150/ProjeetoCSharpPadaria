namespace Padaria
{
    partial class frmFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarios));
            this.gpdDadosPessoais = new System.Windows.Forms.GroupBox();
            this.lblCódigo = new System.Windows.Forms.Label();
            this.txtCódigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblDNT = new System.Windows.Forms.Label();
            this.dtpDNT = new System.Windows.Forms.DateTimePicker();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbNãoInformar = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.lblFoto = new System.Windows.Forms.Label();
            this.pctFoto = new System.Windows.Forms.PictureBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.txtEnderço = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNúmero = new System.Windows.Forms.Label();
            this.txtNúmero = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.gpdEndereço = new System.Windows.Forms.GroupBox();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCadastar = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gpdDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).BeginInit();
            this.gpdEndereço.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpdDadosPessoais
            // 
            this.gpdDadosPessoais.Controls.Add(this.btnLimpar);
            this.gpdDadosPessoais.Controls.Add(this.btnAlterar);
            this.gpdDadosPessoais.Controls.Add(this.btnCarregar);
            this.gpdDadosPessoais.Controls.Add(this.pctFoto);
            this.gpdDadosPessoais.Controls.Add(this.lblFoto);
            this.gpdDadosPessoais.Controls.Add(this.grpSexo);
            this.gpdDadosPessoais.Controls.Add(this.mtbTelefone);
            this.gpdDadosPessoais.Controls.Add(this.lblTelefone);
            this.gpdDadosPessoais.Controls.Add(this.dtpDNT);
            this.gpdDadosPessoais.Controls.Add(this.lblDNT);
            this.gpdDadosPessoais.Controls.Add(this.mtbCPF);
            this.gpdDadosPessoais.Controls.Add(this.lblCPF);
            this.gpdDadosPessoais.Controls.Add(this.txtEmail);
            this.gpdDadosPessoais.Controls.Add(this.lblEmail);
            this.gpdDadosPessoais.Controls.Add(this.txtNome);
            this.gpdDadosPessoais.Controls.Add(this.lblNome);
            this.gpdDadosPessoais.Controls.Add(this.label2);
            this.gpdDadosPessoais.Controls.Add(this.txtCódigo);
            this.gpdDadosPessoais.Controls.Add(this.lblCódigo);
            this.gpdDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpdDadosPessoais.Location = new System.Drawing.Point(16, 12);
            this.gpdDadosPessoais.Name = "gpdDadosPessoais";
            this.gpdDadosPessoais.Size = new System.Drawing.Size(919, 277);
            this.gpdDadosPessoais.TabIndex = 0;
            this.gpdDadosPessoais.TabStop = false;
            this.gpdDadosPessoais.Text = "Dados Pessoais";
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.Location = new System.Drawing.Point(25, 51);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(59, 20);
            this.lblCódigo.TabIndex = 0;
            this.lblCódigo.Text = "Código";
            this.lblCódigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCódigo
            // 
            this.txtCódigo.Enabled = false;
            this.txtCódigo.Location = new System.Drawing.Point(90, 45);
            this.txtCódigo.MaxLength = 10;
            this.txtCódigo.Name = "txtCódigo";
            this.txtCódigo.Size = new System.Drawing.Size(183, 26);
            this.txtCódigo.TabIndex = 1;
            this.txtCódigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(333, 48);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(183, 26);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(276, 51);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(582, 48);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(177, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(528, 51);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(44, 89);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(40, 20);
            this.lblCPF.TabIndex = 7;
            this.lblCPF.Text = "CPF";
            this.lblCPF.Click += new System.EventHandler(this.label5_Click);
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(90, 86);
            this.mtbCPF.Mask = "999,999,999-99";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(183, 26);
            this.mtbCPF.TabIndex = 4;
            // 
            // lblDNT
            // 
            this.lblDNT.AutoSize = true;
            this.lblDNT.Location = new System.Drawing.Point(276, 89);
            this.lblDNT.Name = "lblDNT";
            this.lblDNT.Size = new System.Drawing.Size(154, 20);
            this.lblDNT.TabIndex = 9;
            this.lblDNT.Text = "Data de Nascimento";
            // 
            // dtpDNT
            // 
            this.dtpDNT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDNT.Location = new System.Drawing.Point(436, 84);
            this.dtpDNT.Name = "dtpDNT";
            this.dtpDNT.Size = new System.Drawing.Size(119, 26);
            this.dtpDNT.TabIndex = 5;
            this.dtpDNT.Value = new System.DateTime(1753, 12, 31, 0, 0, 0, 0);
            this.dtpDNT.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(561, 89);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(71, 20);
            this.lblTelefone.TabIndex = 11;
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Click += new System.EventHandler(this.label7_Click);
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(630, 86);
            this.mtbTelefone.Mask = "99999-9999";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(129, 26);
            this.mtbTelefone.TabIndex = 6;
            // 
            // grpSexo
            // 
            this.grpSexo.Location = new System.Drawing.Point(39, 128);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(309, 106);
            this.grpSexo.TabIndex = 7;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo";
            this.grpSexo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(102, 190);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 9;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbNãoInformar
            // 
            this.rbNãoInformar.AutoSize = true;
            this.rbNãoInformar.Location = new System.Drawing.Point(102, 214);
            this.rbNãoInformar.Name = "rbNãoInformar";
            this.rbNãoInformar.Size = new System.Drawing.Size(120, 17);
            this.rbNãoInformar.TabIndex = 10;
            this.rbNãoInformar.TabStop = true;
            this.rbNãoInformar.Text = "Não desejo Informar";
            this.rbNãoInformar.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(103, 167);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbFeminino.TabIndex = 8;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(354, 143);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(42, 20);
            this.lblFoto.TabIndex = 17;
            this.lblFoto.Text = "Foto";
            this.lblFoto.Click += new System.EventHandler(this.label8_Click);
            // 
            // pctFoto
            // 
            this.pctFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctFoto.Location = new System.Drawing.Point(402, 143);
            this.pctFoto.Name = "pctFoto";
            this.pctFoto.Size = new System.Drawing.Size(156, 117);
            this.pctFoto.TabIndex = 18;
            this.pctFoto.TabStop = false;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.Image = ((System.Drawing.Image)(resources.GetObject("btnCarregar.Image")));
            this.btnCarregar.Location = new System.Drawing.Point(565, 143);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(74, 32);
            this.btnCarregar.TabIndex = 11;
            this.btnCarregar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(564, 190);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(76, 25);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(564, 233);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(76, 27);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.Location = new System.Drawing.Point(6, 48);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(91, 20);
            this.lblEndereço.TabIndex = 0;
            this.lblEndereço.Text = "Logradouro";
            // 
            // txtEnderço
            // 
            this.txtEnderço.Location = new System.Drawing.Point(103, 45);
            this.txtEnderço.MaxLength = 100;
            this.txtEnderço.Name = "txtEnderço";
            this.txtEnderço.Size = new System.Drawing.Size(322, 26);
            this.txtEnderço.TabIndex = 15;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(0, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(0, 20);
            this.lblEndereco.TabIndex = 14;
            // 
            // lblNúmero
            // 
            this.lblNúmero.AutoSize = true;
            this.lblNúmero.Location = new System.Drawing.Point(447, 45);
            this.lblNúmero.Name = "lblNúmero";
            this.lblNúmero.Size = new System.Drawing.Size(65, 20);
            this.lblNúmero.TabIndex = 3;
            this.lblNúmero.Text = "Número";
            this.lblNúmero.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtNúmero
            // 
            this.txtNúmero.Location = new System.Drawing.Point(518, 45);
            this.txtNúmero.MaxLength = 10;
            this.txtNúmero.Name = "txtNúmero";
            this.txtNúmero.Size = new System.Drawing.Size(40, 26);
            this.txtNúmero.TabIndex = 16;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(593, 51);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(41, 20);
            this.lblCEP.TabIndex = 11;
            this.lblCEP.Text = "CEP";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(11, 87);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(51, 20);
            this.lblBairro.TabIndex = 22;
            this.lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(68, 84);
            this.txtBairro.MaxLength = 100;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(202, 26);
            this.txtBairro.TabIndex = 18;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(282, 90);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(59, 20);
            this.lblCidade.TabIndex = 24;
            this.lblCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(347, 86);
            this.txtCidade.MaxLength = 100;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(133, 26);
            this.txtCidade.TabIndex = 19;
            this.txtCidade.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // gpdEndereço
            // 
            this.gpdEndereço.Controls.Add(this.txtComplemento);
            this.gpdEndereço.Controls.Add(this.lblComplemento);
            this.gpdEndereço.Controls.Add(this.cbxEstado);
            this.gpdEndereço.Controls.Add(this.lblEstado);
            this.gpdEndereço.Controls.Add(this.mtbCEP);
            this.gpdEndereço.Controls.Add(this.txtCidade);
            this.gpdEndereço.Controls.Add(this.lblCidade);
            this.gpdEndereço.Controls.Add(this.txtBairro);
            this.gpdEndereço.Controls.Add(this.lblBairro);
            this.gpdEndereço.Controls.Add(this.lblCEP);
            this.gpdEndereço.Controls.Add(this.txtNúmero);
            this.gpdEndereço.Controls.Add(this.lblNúmero);
            this.gpdEndereço.Controls.Add(this.lblEndereco);
            this.gpdEndereço.Controls.Add(this.txtEnderço);
            this.gpdEndereço.Controls.Add(this.lblEndereço);
            this.gpdEndereço.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpdEndereço.Location = new System.Drawing.Point(20, 307);
            this.gpdEndereço.Name = "gpdEndereço";
            this.gpdEndereço.Size = new System.Drawing.Size(915, 160);
            this.gpdEndereço.TabIndex = 14;
            this.gpdEndereço.TabStop = false;
            this.gpdEndereço.Text = "Endereço";
            // 
            // mtbCEP
            // 
            this.mtbCEP.Location = new System.Drawing.Point(640, 45);
            this.mtbCEP.Mask = "9999-9999";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(95, 26);
            this.mtbCEP.TabIndex = 17;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(491, 89);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 27;
            this.lblEstado.Text = "Estado";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "AC",
            " AL",
            " AP",
            " AM",
            " BA",
            " CE",
            " DF",
            " ES",
            " GO",
            " MA",
            " MT",
            " MS",
            " MG",
            " PA",
            " PB",
            " PR",
            " PE",
            " PI",
            " RJ",
            " RN",
            " RS",
            " RO",
            " RR",
            " SC",
            " SP",
            " SE",
            " TO"});
            this.cbxEstado.Location = new System.Drawing.Point(557, 84);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(177, 28);
            this.cbxEstado.TabIndex = 20;
            this.cbxEstado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(120, 128);
            this.txtComplemento.MaxLength = 30;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(133, 26);
            this.txtComplemento.TabIndex = 21;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(6, 131);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(108, 20);
            this.lblComplemento.TabIndex = 29;
            this.lblComplemento.Text = "Complemento";
            this.lblComplemento.Click += new System.EventHandler(this.label13_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.btnClean);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnAlt);
            this.panel1.Controls.Add(this.btnCadastar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Location = new System.Drawing.Point(30, 488);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 71);
            this.panel1.TabIndex = 22;
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(15, 11);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(89, 34);
            this.btnNovo.TabIndex = 23;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnCadastar
            // 
            this.btnCadastar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastar.Image")));
            this.btnCadastar.Location = new System.Drawing.Point(122, 11);
            this.btnCadastar.Name = "btnCadastar";
            this.btnCadastar.Size = new System.Drawing.Size(93, 34);
            this.btnCadastar.TabIndex = 24;
            this.btnCadastar.Text = "&Cadastrar";
            this.btnCadastar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastar.UseVisualStyleBackColor = true;
            // 
            // btnAlt
            // 
            this.btnAlt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlt.Image = ((System.Drawing.Image)(resources.GetObject("btnAlt.Image")));
            this.btnAlt.Location = new System.Drawing.Point(230, 11);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(83, 34);
            this.btnAlt.TabIndex = 25;
            this.btnAlt.Text = "&Alterar";
            this.btnAlt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlt.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(344, 11);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 34);
            this.btnExcluir.TabIndex = 26;
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(452, 11);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(96, 34);
            this.btnPesquisar.TabIndex = 27;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnClean
            // 
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClean.Image = ((System.Drawing.Image)(resources.GetObject("btnClean.Image")));
            this.btnClean.Location = new System.Drawing.Point(568, 11);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(86, 34);
            this.btnClean.TabIndex = 28;
            this.btnClean.Text = "&Limpar";
            this.btnClean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClean.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(673, 11);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(101, 34);
            this.btnVoltar.TabIndex = 29;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 625);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gpdEndereço);
            this.Controls.Add(this.rbFeminino);
            this.Controls.Add(this.rbNãoInformar);
            this.Controls.Add(this.rbMasculino);
            this.Controls.Add(this.gpdDadosPessoais);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Padaria - Funcionarios";
            this.gpdDadosPessoais.ResumeLayout(false);
            this.gpdDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).EndInit();
            this.gpdEndereço.ResumeLayout(false);
            this.gpdEndereço.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpdDadosPessoais;
        private System.Windows.Forms.TextBox txtCódigo;
        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Label lblDNT;
        private System.Windows.Forms.DateTimePicker dtpDNT;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbNãoInformar;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.PictureBox pctFoto;
        private System.Windows.Forms.Label lblEndereço;
        private System.Windows.Forms.TextBox txtEnderço;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNúmero;
        private System.Windows.Forms.TextBox txtNúmero;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.GroupBox gpdEndereço;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.MaskedTextBox mtbCEP;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnCadastar;
        private System.Windows.Forms.Button btnNovo;
    }
}