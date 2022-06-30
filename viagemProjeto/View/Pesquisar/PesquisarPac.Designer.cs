
namespace viagemProjeto.View.Pesquisar
{
    partial class PesquisarPac
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAlterarPac = new System.Windows.Forms.Button();
            this.btnDeletarPac = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDestino = new System.Windows.Forms.ComboBox();
            this.btnBuscarCod = new System.Windows.Forms.Button();
            this.cbxOrigem = new System.Windows.Forms.ComboBox();
            this.tbxCod = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblCod = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pbxImg = new System.Windows.Forms.PictureBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.dtpDataVolta = new System.Windows.Forms.DateTimePicker();
            this.lblDestino = new System.Windows.Forms.Label();
            this.dtpDataIda = new System.Windows.Forms.DateTimePicker();
            this.lblDataIda = new System.Windows.Forms.Label();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.lblDataVolta = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbxOrigem = new System.Windows.Forms.TextBox();
            this.dgvOrigem = new System.Windows.Forms.DataGridView();
            this.btnBuscarOrigem = new System.Windows.Forms.Button();
            this.lblNomePac = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbxDestino = new System.Windows.Forms.TextBox();
            this.dgvDestino = new System.Windows.Forms.DataGridView();
            this.btnBuscarDestino = new System.Windows.Forms.Button();
            this.lblDestinoPac = new System.Windows.Forms.Label();
            this.ofdImg = new System.Windows.Forms.OpenFileDialog();
            this.codigoOrigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorOrigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataIdaOrigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVoltaOrigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataIdaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVoltaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrigem)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestino)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(186, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(258, 29);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Pesquisar Pacotes";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAlterarPac);
            this.tabPage1.Controls.Add(this.btnDeletarPac);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbxDestino);
            this.tabPage1.Controls.Add(this.btnBuscarCod);
            this.tabPage1.Controls.Add(this.cbxOrigem);
            this.tabPage1.Controls.Add(this.tbxCod);
            this.tabPage1.Controls.Add(this.btnSalvar);
            this.tabPage1.Controls.Add(this.lblCod);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.pbxImg);
            this.tabPage1.Controls.Add(this.lblValor);
            this.tabPage1.Controls.Add(this.rtbDesc);
            this.tabPage1.Controls.Add(this.lblOrigem);
            this.tabPage1.Controls.Add(this.dtpDataVolta);
            this.tabPage1.Controls.Add(this.lblDestino);
            this.tabPage1.Controls.Add(this.dtpDataIda);
            this.tabPage1.Controls.Add(this.lblDataIda);
            this.tabPage1.Controls.Add(this.tbxValor);
            this.tabPage1.Controls.Add(this.lblDataVolta);
            this.tabPage1.Controls.Add(this.lblDesc);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 281);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Código";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAlterarPac
            // 
            this.btnAlterarPac.Location = new System.Drawing.Point(172, 252);
            this.btnAlterarPac.Name = "btnAlterarPac";
            this.btnAlterarPac.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarPac.TabIndex = 41;
            this.btnAlterarPac.Text = "Alterar";
            this.btnAlterarPac.UseVisualStyleBackColor = true;
            this.btnAlterarPac.Click += new System.EventHandler(this.btnAlterarPac_Click);
            // 
            // btnDeletarPac
            // 
            this.btnDeletarPac.Location = new System.Drawing.Point(253, 252);
            this.btnDeletarPac.Name = "btnDeletarPac";
            this.btnDeletarPac.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarPac.TabIndex = 40;
            this.btnDeletarPac.Text = "Deletar";
            this.btnDeletarPac.UseVisualStyleBackColor = true;
            this.btnDeletarPac.Click += new System.EventHandler(this.btnDeletarPac_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(373, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 39;
            this.label2.Text = "Imagem:";
            // 
            // cbxDestino
            // 
            this.cbxDestino.FormattingEnabled = true;
            this.cbxDestino.Items.AddRange(new object[] {
            "África do Sul - Pretória (executiva) / Bloemfontein (judiciária) / Cidade do Cabo" +
                " (legislativa) ",
            "Angola - Luanda",
            "Argélia - Argel",
            "Benim - Porto-Novo (constitucional) / Cotonu (sede do governo)",
            "Botswana - Gaborone ",
            "Burkina Faso - Ouagadougou",
            "Burundi - Bujumbura",
            "Cabo Verde - Praia",
            "Camarões - Yaoundé",
            "Chade - N\'Djamena",
            "Comores - Moroni",
            "Costa do Marfim - Yamoussoukro",
            "Djibouti - Djibouti",
            "Egito - Cairo",
            "Eritreia - Asmara",
            "Etiópia - Adis-Abeba",
            "Gabão - Libreville",
            "Gana - Acra",
            "Guiné - Conacri",
            "Guiné Equatorial - Malabo",
            "Guiné-Bissau - Bissau",
            "Gâmbia - Banjul",
            "Lesoto - Maseru",
            "Libéria - Monróvia",
            "Líbia - Trípoli",
            "Madagáscar - Antananarivo",
            "Malawi - Lilongwe",
            "Mali - Bamako",
            "Marrocos - Rabat",
            "Mauritânia - Nouakchott",
            "Maurícia - Port Louis",
            "Moçambique - Maputo",
            "Namíbia - Windhoek",
            "Nigéria - Abuja",
            "Níger - Niamey",
            "Quénia - Nairobi",
            "República Centro-Africana - Bangui",
            "República Democrática do Congo - Kinshasa",
            "República do Congo - Brazzaville",
            "Ruanda - Kigali",
            "Senegal - Dakar",
            "Serra Leoa - Freetown",
            "Seychelles - Victoria",
            "Somália - Mogadíscio",
            "Suazilândia - Lobamba (real e legislativa) / Mbabane (administrativa)",
            "Sudão - Cartum",
            "Sudão do Sul - Juba",
            "São Tomé e Príncipe - São Tomé",
            "Tanzânia - Dar es Salaam (administrativa) / Dodoma (oficial)",
            "Togo - Lomé",
            "Tunísia - Tunis",
            "Uganda - Kampala",
            "Zâmbia - Lusaka",
            "Zimbabwe - Harare",
            "Canadá - Otawwa",
            "Estados Unidos da América - Washington",
            "México - Cidade do México",
            "Antígua e Barbuda - Saint John\'s",
            "Bahamas - Nassau",
            "Barbados - Bridgetown",
            "Belize - Belmopan",
            "Costa Rica - São José",
            "Cuba - Havana",
            "Dominica - Roseau",
            "El Salvador - São Salvador",
            "Granada - Saint George\'s",
            "Guatemala - Cidade da Guatemala",
            "Haiti - Porto Príncipe",
            "Honduras - Tegucigalpa",
            "Jamaica - Kingston",
            "Nicarágua - Manágua",
            "Panamá - Cidade de Panamá",
            "República Dominicana - São Domingos",
            "Santa Lúcia - Castries",
            "São Cristóvão e Nevis - Basseterre",
            "São Vicente e Granadinas - Kingstown",
            "Trinidad e Tobago - Porto de Espanha",
            "Argentina - Buenos Aires",
            "Bolívia - La Paz (sede do governo) e Sucre (constitucional)",
            "Brasil - Brasília",
            "Chile - Santiago",
            "Colômbia - Bogotá",
            "Equador - Quito",
            "Guiana - Georgetown",
            "Paraguai - Assunção",
            "Peru - Lima",
            "Suriname - Paramaribo",
            "Uruguai - Montevidéo",
            "Venezuela - Caracas",
            "Afeganistão – Cabul",
            "Arábia Saudita – Riad",
            "Azerbaijão - Baku",
            "Bangladesh – Dacca",
            "Barein – Manama",
            "Brunei – Bandar Seri Begawan",
            "Butão – Timphu",
            "Camboja – Phnom Penh",
            "Cazaquistão – Astana",
            "Catar – Doha",
            "China – Pequim",
            "Cingapura – Cidade de Cingapura",
            "Coreia do Norte – Pyongyang",
            "Coreia do Sul – Seul",
            "Emirados Árabes Unidos – Abu Dhabi",
            "Filipinas – Manila",
            "Iêmen – Sana",
            "Índia – Nova Délhi",
            "Indonésia – Jacarta",
            "Irã – Teerã",
            "Iraque – Bagdá",
            "Israel – Jerusalém",
            "Japão – Tóquio",
            "Jordânia – Amã",
            "Kuwait – Cidade do Kuwait",
            "Laos – Vietiane",
            "Líbano – Beirute",
            "Malásia – Kuala Lumpur",
            "Maldivas – Male",
            "Mianmar – Nay Puy Taw",
            "Mongólia – Ulan Bator",
            "Nepal – Katmandu",
            "Omã – Mascate",
            "Paquistão – Islamabad",
            "Quirguistão – Bishkek",
            "Rússia (parte asiática) - Moscou",
            "Síria – Damasco",
            "Sri Lanka – Colombo",
            "Tailândia – Bangcoc",
            "Tajidquistão – Muchambe",
            "Timor Leste - Dili",
            "Turcomenistão – Ashkhabad",
            "Turquia (parte asiática) - Ancara",
            "Uzbequistão – Tashkent",
            "Vietnã – Hanói",
            "Albânia - Tirana",
            "Alemanha - Berlim",
            "Andorra - Andorra la Vella",
            "Armênia - Erevan",
            "Áustria - Viena",
            "Azerbaijão - Baku",
            "Bielorrússia - Minsk",
            "Bélgica - Bruxelas",
            "Bósnia-Herzegovina - Sarajevo",
            "Bulgária - Sófia",
            "República Tcheca - Praga",
            "Cazaquistão - Astana",
            "Chipre - Nicósia",
            "Croácia - Zagreb",
            "Dinamarca - Copenhagem",
            "Eslováquia - Bratislava",
            "Eslovênia - Liubliana",
            "Espanha - Madrid",
            "Estônia - Tallinn",
            "Finlândia - Helsinque",
            "França - Paris",
            "Grécia - Atenas",
            "Geórgia - Tbilisi",
            "Hungria - Budapeste",
            "Irlanda - Dublin",
            "Islândia - Reiquiavique",
            "Itália - Roma",
            "Letônia - Riga",
            "Liechtenstein - Vaduz",
            "Lituânia - Vilnius ",
            "Luxemburgo - Luxemburgo",
            "República da Macedônia do Norte - Skopje",
            "Malta - Valetta",
            "Moldávia - Chisinau",
            "Mônaco - Monaco-Ville",
            "Montenegro - Podgorica",
            "Noruega - Oslo",
            "Países Baixos - Amsterdã",
            "Polônia - Varsóvia",
            "Portugal - Lisboa",
            "Reino Unido - Londres",
            "Romênia - Bucareste",
            "Rússia - Moscou",
            "Turquia - Ancara",
            "San Marino - San Marino",
            "Sérvia - Belgrado",
            "Suécia - Estocolmo",
            "Suíça - Berna",
            "Ucrânia - Kiev",
            "Vaticano",
            "Austrália - Camberra",
            "Fiji - Suva",
            "Ilhas Marshall - Majuro",
            "Ilhas Salomão - Honiara",
            "Kiribati - Taraua",
            "Micronésia - Paliquir",
            "Nauru - Yaren",
            "Nova Zelândia - Wellington",
            "Palau - Melequeoque",
            "Papua Nova Guiné - Porto Moresby",
            "Samoa - Apia",
            "Tonga - Nucualofa",
            "Tuvalu - Funafuti",
            "Vanuatu - Porto Vila "});
            this.cbxDestino.Location = new System.Drawing.Point(442, 74);
            this.cbxDestino.Name = "cbxDestino";
            this.cbxDestino.Size = new System.Drawing.Size(139, 22);
            this.cbxDestino.TabIndex = 38;
            // 
            // btnBuscarCod
            // 
            this.btnBuscarCod.Location = new System.Drawing.Point(490, 6);
            this.btnBuscarCod.Name = "btnBuscarCod";
            this.btnBuscarCod.Size = new System.Drawing.Size(96, 23);
            this.btnBuscarCod.TabIndex = 7;
            this.btnBuscarCod.Text = "Buscar";
            this.btnBuscarCod.UseVisualStyleBackColor = true;
            this.btnBuscarCod.Click += new System.EventHandler(this.btnBuscarCod_Click);
            // 
            // cbxOrigem
            // 
            this.cbxOrigem.FormattingEnabled = true;
            this.cbxOrigem.Items.AddRange(new object[] {
            "África do Sul - Pretória (executiva) / Bloemfontein (judiciária) / Cidade do Cabo" +
                " (legislativa) ",
            "Angola - Luanda",
            "Argélia - Argel",
            "Benim - Porto-Novo (constitucional) / Cotonu (sede do governo)",
            "Botswana - Gaborone ",
            "Burkina Faso - Ouagadougou",
            "Burundi - Bujumbura",
            "Cabo Verde - Praia",
            "Camarões - Yaoundé",
            "Chade - N\'Djamena",
            "Comores - Moroni",
            "Costa do Marfim - Yamoussoukro",
            "Djibouti - Djibouti",
            "Egito - Cairo",
            "Eritreia - Asmara",
            "Etiópia - Adis-Abeba",
            "Gabão - Libreville",
            "Gana - Acra",
            "Guiné - Conacri",
            "Guiné Equatorial - Malabo",
            "Guiné-Bissau - Bissau",
            "Gâmbia - Banjul",
            "Lesoto - Maseru",
            "Libéria - Monróvia",
            "Líbia - Trípoli",
            "Madagáscar - Antananarivo",
            "Malawi - Lilongwe",
            "Mali - Bamako",
            "Marrocos - Rabat",
            "Mauritânia - Nouakchott",
            "Maurícia - Port Louis",
            "Moçambique - Maputo",
            "Namíbia - Windhoek",
            "Nigéria - Abuja",
            "Níger - Niamey",
            "Quénia - Nairobi",
            "República Centro-Africana - Bangui",
            "República Democrática do Congo - Kinshasa",
            "República do Congo - Brazzaville",
            "Ruanda - Kigali",
            "Senegal - Dakar",
            "Serra Leoa - Freetown",
            "Seychelles - Victoria",
            "Somália - Mogadíscio",
            "Suazilândia - Lobamba (real e legislativa) / Mbabane (administrativa)",
            "Sudão - Cartum",
            "Sudão do Sul - Juba",
            "São Tomé e Príncipe - São Tomé",
            "Tanzânia - Dar es Salaam (administrativa) / Dodoma (oficial)",
            "Togo - Lomé",
            "Tunísia - Tunis",
            "Uganda - Kampala",
            "Zâmbia - Lusaka",
            "Zimbabwe - Harare",
            "Canadá - Otawwa",
            "Estados Unidos da América - Washington",
            "México - Cidade do México",
            "Antígua e Barbuda - Saint John\'s",
            "Bahamas - Nassau",
            "Barbados - Bridgetown",
            "Belize - Belmopan",
            "Costa Rica - São José",
            "Cuba - Havana",
            "Dominica - Roseau",
            "El Salvador - São Salvador",
            "Granada - Saint George\'s",
            "Guatemala - Cidade da Guatemala",
            "Haiti - Porto Príncipe",
            "Honduras - Tegucigalpa",
            "Jamaica - Kingston",
            "Nicarágua - Manágua",
            "Panamá - Cidade de Panamá",
            "República Dominicana - São Domingos",
            "Santa Lúcia - Castries",
            "São Cristóvão e Nevis - Basseterre",
            "São Vicente e Granadinas - Kingstown",
            "Trinidad e Tobago - Porto de Espanha",
            "Argentina - Buenos Aires",
            "Bolívia - La Paz (sede do governo) e Sucre (constitucional)",
            "Brasil - Brasília",
            "Chile - Santiago",
            "Colômbia - Bogotá",
            "Equador - Quito",
            "Guiana - Georgetown",
            "Paraguai - Assunção",
            "Peru - Lima",
            "Suriname - Paramaribo",
            "Uruguai - Montevidéo",
            "Venezuela - Caracas",
            "Afeganistão – Cabul",
            "Arábia Saudita – Riad",
            "Azerbaijão - Baku",
            "Bangladesh – Dacca",
            "Barein – Manama",
            "Brunei – Bandar Seri Begawan",
            "Butão – Timphu",
            "Camboja – Phnom Penh",
            "Cazaquistão – Astana",
            "Catar – Doha",
            "China – Pequim",
            "Cingapura – Cidade de Cingapura",
            "Coreia do Norte – Pyongyang",
            "Coreia do Sul – Seul",
            "Emirados Árabes Unidos – Abu Dhabi",
            "Filipinas – Manila",
            "Iêmen – Sana",
            "Índia – Nova Délhi",
            "Indonésia – Jacarta",
            "Irã – Teerã",
            "Iraque – Bagdá",
            "Israel – Jerusalém",
            "Japão – Tóquio",
            "Jordânia – Amã",
            "Kuwait – Cidade do Kuwait",
            "Laos – Vietiane",
            "Líbano – Beirute",
            "Malásia – Kuala Lumpur",
            "Maldivas – Male",
            "Mianmar – Nay Puy Taw",
            "Mongólia – Ulan Bator",
            "Nepal – Katmandu",
            "Omã – Mascate",
            "Paquistão – Islamabad",
            "Quirguistão – Bishkek",
            "Rússia (parte asiática) - Moscou",
            "Síria – Damasco",
            "Sri Lanka – Colombo",
            "Tailândia – Bangcoc",
            "Tajidquistão – Muchambe",
            "Timor Leste - Dili",
            "Turcomenistão – Ashkhabad",
            "Turquia (parte asiática) - Ancara",
            "Uzbequistão – Tashkent",
            "Vietnã – Hanói",
            "Albânia - Tirana",
            "Alemanha - Berlim",
            "Andorra - Andorra la Vella",
            "Armênia - Erevan",
            "Áustria - Viena",
            "Azerbaijão - Baku",
            "Bielorrússia - Minsk",
            "Bélgica - Bruxelas",
            "Bósnia-Herzegovina - Sarajevo",
            "Bulgária - Sófia",
            "República Tcheca - Praga",
            "Cazaquistão - Astana",
            "Chipre - Nicósia",
            "Croácia - Zagreb",
            "Dinamarca - Copenhagem",
            "Eslováquia - Bratislava",
            "Eslovênia - Liubliana",
            "Espanha - Madrid",
            "Estônia - Tallinn",
            "Finlândia - Helsinque",
            "França - Paris",
            "Grécia - Atenas",
            "Geórgia - Tbilisi",
            "Hungria - Budapeste",
            "Irlanda - Dublin",
            "Islândia - Reiquiavique",
            "Itália - Roma",
            "Letônia - Riga",
            "Liechtenstein - Vaduz",
            "Lituânia - Vilnius ",
            "Luxemburgo - Luxemburgo",
            "República da Macedônia do Norte - Skopje",
            "Malta - Valetta",
            "Moldávia - Chisinau",
            "Mônaco - Monaco-Ville",
            "Montenegro - Podgorica",
            "Noruega - Oslo",
            "Países Baixos - Amsterdã",
            "Polônia - Varsóvia",
            "Portugal - Lisboa",
            "Reino Unido - Londres",
            "Romênia - Bucareste",
            "Rússia - Moscou",
            "Turquia - Ancara",
            "San Marino - San Marino",
            "Sérvia - Belgrado",
            "Suécia - Estocolmo",
            "Suíça - Berna",
            "Ucrânia - Kiev",
            "Vaticano",
            "Austrália - Camberra",
            "Fiji - Suva",
            "Ilhas Marshall - Majuro",
            "Ilhas Salomão - Honiara",
            "Kiribati - Taraua",
            "Micronésia - Paliquir",
            "Nauru - Yaren",
            "Nova Zelândia - Wellington",
            "Palau - Melequeoque",
            "Papua Nova Guiné - Porto Moresby",
            "Samoa - Apia",
            "Tonga - Nucualofa",
            "Tuvalu - Funafuti",
            "Vanuatu - Porto Vila "});
            this.cbxOrigem.Location = new System.Drawing.Point(442, 43);
            this.cbxOrigem.Name = "cbxOrigem";
            this.cbxOrigem.Size = new System.Drawing.Size(139, 22);
            this.cbxOrigem.TabIndex = 37;
            // 
            // tbxCod
            // 
            this.tbxCod.Location = new System.Drawing.Point(112, 6);
            this.tbxCod.Name = "tbxCod";
            this.tbxCod.Size = new System.Drawing.Size(372, 22);
            this.tbxCod.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(259, 356);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 36;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(3, 10);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(108, 14);
            this.lblCod.TabIndex = 5;
            this.lblCod.Text = "Digite o Código:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(508, 253);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pbxImg
            // 
            this.pbxImg.BackColor = System.Drawing.Color.Transparent;
            this.pbxImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImg.Location = new System.Drawing.Point(373, 127);
            this.pbxImg.Name = "pbxImg";
            this.pbxImg.Size = new System.Drawing.Size(210, 119);
            this.pbxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImg.TabIndex = 34;
            this.pbxImg.TabStop = false;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Location = new System.Drawing.Point(63, 43);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(43, 14);
            this.lblValor.TabIndex = 23;
            this.lblValor.Text = "Valor:";
            // 
            // rtbDesc
            // 
            this.rtbDesc.Location = new System.Drawing.Point(112, 142);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(216, 105);
            this.rtbDesc.TabIndex = 33;
            this.rtbDesc.Text = "";
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.BackColor = System.Drawing.Color.Transparent;
            this.lblOrigem.Location = new System.Drawing.Point(379, 46);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(57, 14);
            this.lblOrigem.TabIndex = 24;
            this.lblOrigem.Text = "Origem:";
            // 
            // dtpDataVolta
            // 
            this.dtpDataVolta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVolta.Location = new System.Drawing.Point(112, 108);
            this.dtpDataVolta.Name = "dtpDataVolta";
            this.dtpDataVolta.Size = new System.Drawing.Size(216, 22);
            this.dtpDataVolta.TabIndex = 32;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.BackColor = System.Drawing.Color.Transparent;
            this.lblDestino.Location = new System.Drawing.Point(378, 77);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(60, 14);
            this.lblDestino.TabIndex = 25;
            this.lblDestino.Text = "Destino:";
            // 
            // dtpDataIda
            // 
            this.dtpDataIda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataIda.Location = new System.Drawing.Point(112, 74);
            this.dtpDataIda.Name = "dtpDataIda";
            this.dtpDataIda.Size = new System.Drawing.Size(216, 22);
            this.dtpDataIda.TabIndex = 31;
            // 
            // lblDataIda
            // 
            this.lblDataIda.AutoSize = true;
            this.lblDataIda.BackColor = System.Drawing.Color.Transparent;
            this.lblDataIda.Location = new System.Drawing.Point(19, 77);
            this.lblDataIda.Name = "lblDataIda";
            this.lblDataIda.Size = new System.Drawing.Size(87, 14);
            this.lblDataIda.TabIndex = 26;
            this.lblDataIda.Text = "Data de Ida:";
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(112, 40);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(216, 22);
            this.tbxValor.TabIndex = 30;
            // 
            // lblDataVolta
            // 
            this.lblDataVolta.AutoSize = true;
            this.lblDataVolta.BackColor = System.Drawing.Color.Transparent;
            this.lblDataVolta.Location = new System.Drawing.Point(9, 111);
            this.lblDataVolta.Name = "lblDataVolta";
            this.lblDataVolta.Size = new System.Drawing.Size(97, 14);
            this.lblDataVolta.TabIndex = 27;
            this.lblDataVolta.Text = "Data de Volta:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblDesc.Location = new System.Drawing.Point(34, 145);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(72, 14);
            this.lblDesc.TabIndex = 28;
            this.lblDesc.Text = "Descrição:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 90);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 308);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbxOrigem);
            this.tabPage2.Controls.Add(this.dgvOrigem);
            this.tabPage2.Controls.Add(this.btnBuscarOrigem);
            this.tabPage2.Controls.Add(this.lblNomePac);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(592, 281);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Origem";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbxOrigem
            // 
            this.tbxOrigem.Location = new System.Drawing.Point(79, 18);
            this.tbxOrigem.Name = "tbxOrigem";
            this.tbxOrigem.Size = new System.Drawing.Size(405, 22);
            this.tbxOrigem.TabIndex = 10;
            // 
            // dgvOrigem
            // 
            this.dgvOrigem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrigem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrigem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoOrigem,
            this.valorOrigem,
            this.origem,
            this.dataIdaOrigem,
            this.dataVoltaOrigem});
            this.dgvOrigem.Location = new System.Drawing.Point(0, 62);
            this.dgvOrigem.Name = "dgvOrigem";
            this.dgvOrigem.RowHeadersVisible = false;
            this.dgvOrigem.RowTemplate.Height = 25;
            this.dgvOrigem.Size = new System.Drawing.Size(592, 200);
            this.dgvOrigem.TabIndex = 9;
            // 
            // btnBuscarOrigem
            // 
            this.btnBuscarOrigem.Location = new System.Drawing.Point(490, 18);
            this.btnBuscarOrigem.Name = "btnBuscarOrigem";
            this.btnBuscarOrigem.Size = new System.Drawing.Size(96, 23);
            this.btnBuscarOrigem.TabIndex = 8;
            this.btnBuscarOrigem.Text = "Buscar";
            this.btnBuscarOrigem.UseVisualStyleBackColor = true;
            this.btnBuscarOrigem.Click += new System.EventHandler(this.btnBuscarOrigem_Click);
            // 
            // lblNomePac
            // 
            this.lblNomePac.AutoSize = true;
            this.lblNomePac.Location = new System.Drawing.Point(16, 22);
            this.lblNomePac.Name = "lblNomePac";
            this.lblNomePac.Size = new System.Drawing.Size(57, 14);
            this.lblNomePac.TabIndex = 7;
            this.lblNomePac.Text = "Origem:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbxDestino);
            this.tabPage3.Controls.Add(this.dgvDestino);
            this.tabPage3.Controls.Add(this.btnBuscarDestino);
            this.tabPage3.Controls.Add(this.lblDestinoPac);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(592, 281);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Destino";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbxDestino
            // 
            this.tbxDestino.Location = new System.Drawing.Point(79, 18);
            this.tbxDestino.Name = "tbxDestino";
            this.tbxDestino.Size = new System.Drawing.Size(405, 22);
            this.tbxDestino.TabIndex = 10;
            // 
            // dgvDestino
            // 
            this.dgvDestino.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestino.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDestino,
            this.valorDestino,
            this.destino,
            this.dataIdaDestino,
            this.dataVoltaDestino});
            this.dgvDestino.Location = new System.Drawing.Point(0, 62);
            this.dgvDestino.Name = "dgvDestino";
            this.dgvDestino.RowHeadersVisible = false;
            this.dgvDestino.RowTemplate.Height = 25;
            this.dgvDestino.Size = new System.Drawing.Size(592, 200);
            this.dgvDestino.TabIndex = 9;
            // 
            // btnBuscarDestino
            // 
            this.btnBuscarDestino.Location = new System.Drawing.Point(490, 18);
            this.btnBuscarDestino.Name = "btnBuscarDestino";
            this.btnBuscarDestino.Size = new System.Drawing.Size(96, 23);
            this.btnBuscarDestino.TabIndex = 8;
            this.btnBuscarDestino.Text = "Buscar";
            this.btnBuscarDestino.UseVisualStyleBackColor = true;
            this.btnBuscarDestino.Click += new System.EventHandler(this.btnBuscarDestino_Click);
            // 
            // lblDestinoPac
            // 
            this.lblDestinoPac.AutoSize = true;
            this.lblDestinoPac.Location = new System.Drawing.Point(13, 22);
            this.lblDestinoPac.Name = "lblDestinoPac";
            this.lblDestinoPac.Size = new System.Drawing.Size(60, 14);
            this.lblDestinoPac.TabIndex = 7;
            this.lblDestinoPac.Text = "Destino:";
            // 
            // ofdImg
            // 
            this.ofdImg.FileName = "ofdImg";
            // 
            // codigoOrigem
            // 
            this.codigoOrigem.HeaderText = "Código";
            this.codigoOrigem.Name = "codigoOrigem";
            // 
            // valorOrigem
            // 
            this.valorOrigem.HeaderText = "Valor";
            this.valorOrigem.Name = "valorOrigem";
            // 
            // origem
            // 
            this.origem.HeaderText = "Origem";
            this.origem.Name = "origem";
            // 
            // dataIdaOrigem
            // 
            this.dataIdaOrigem.HeaderText = "Data de Ida";
            this.dataIdaOrigem.Name = "dataIdaOrigem";
            // 
            // dataVoltaOrigem
            // 
            this.dataVoltaOrigem.HeaderText = "Data de Volta";
            this.dataVoltaOrigem.Name = "dataVoltaOrigem";
            // 
            // codigoDestino
            // 
            this.codigoDestino.HeaderText = "Código";
            this.codigoDestino.Name = "codigoDestino";
            // 
            // valorDestino
            // 
            this.valorDestino.HeaderText = "Valor";
            this.valorDestino.Name = "valorDestino";
            // 
            // destino
            // 
            this.destino.HeaderText = "Destino";
            this.destino.Name = "destino";
            // 
            // dataIdaDestino
            // 
            this.dataIdaDestino.HeaderText = "Data de Ida";
            this.dataIdaDestino.Name = "dataIdaDestino";
            // 
            // dataVoltaDestino
            // 
            this.dataVoltaDestino.HeaderText = "Data de Volta";
            this.dataVoltaDestino.Name = "dataVoltaDestino";
            // 
            // PesquisarPac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "PesquisarPac";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Pacote";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrigem)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBuscarCod;
        private System.Windows.Forms.TextBox tbxCod;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbxOrigem;
        private System.Windows.Forms.DataGridView dgvOrigem;
        private System.Windows.Forms.Button btnBuscarOrigem;
        private System.Windows.Forms.Label lblNomePac;
        private System.Windows.Forms.TextBox tbxDestino;
        private System.Windows.Forms.DataGridView dgvDestino;
        private System.Windows.Forms.Button btnBuscarDestino;
        private System.Windows.Forms.Label lblDestinoPac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxDestino;
        private System.Windows.Forms.ComboBox cbxOrigem;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox pbxImg;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.DateTimePicker dtpDataVolta;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.DateTimePicker dtpDataIda;
        private System.Windows.Forms.Label lblDataIda;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.Label lblDataVolta;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnAlterarPac;
        private System.Windows.Forms.Button btnDeletarPac;
        private System.Windows.Forms.OpenFileDialog ofdImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoOrigem;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorOrigem;
        private System.Windows.Forms.DataGridViewTextBoxColumn origem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataIdaOrigem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVoltaOrigem;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataIdaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVoltaDestino;
    }
}