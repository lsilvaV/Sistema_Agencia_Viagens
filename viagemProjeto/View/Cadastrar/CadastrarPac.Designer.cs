
namespace viagemProjeto.View.Cadastrar
{
    partial class CadastrarPac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarPac));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblDataIda = new System.Windows.Forms.Label();
            this.lblDataVolta = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblImg = new System.Windows.Forms.Label();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.dtpDataIda = new System.Windows.Forms.DateTimePicker();
            this.dtpDataVolta = new System.Windows.Forms.DateTimePicker();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.pbxImg = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbxOrigem = new System.Windows.Forms.ComboBox();
            this.cbxDestino = new System.Windows.Forms.ComboBox();
            this.ofdImg = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(66, 51);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(272, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastro de Pacote";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Location = new System.Drawing.Point(65, 107);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(43, 14);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor:";
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.BackColor = System.Drawing.Color.Transparent;
            this.lblOrigem.Location = new System.Drawing.Point(51, 141);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(57, 14);
            this.lblOrigem.TabIndex = 2;
            this.lblOrigem.Text = "Origem:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.BackColor = System.Drawing.Color.Transparent;
            this.lblDestino.Location = new System.Drawing.Point(48, 175);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(60, 14);
            this.lblDestino.TabIndex = 3;
            this.lblDestino.Text = "Destino:";
            // 
            // lblDataIda
            // 
            this.lblDataIda.AutoSize = true;
            this.lblDataIda.BackColor = System.Drawing.Color.Transparent;
            this.lblDataIda.Location = new System.Drawing.Point(21, 209);
            this.lblDataIda.Name = "lblDataIda";
            this.lblDataIda.Size = new System.Drawing.Size(87, 14);
            this.lblDataIda.TabIndex = 4;
            this.lblDataIda.Text = "Data de Ida:";
            // 
            // lblDataVolta
            // 
            this.lblDataVolta.AutoSize = true;
            this.lblDataVolta.BackColor = System.Drawing.Color.Transparent;
            this.lblDataVolta.Location = new System.Drawing.Point(11, 243);
            this.lblDataVolta.Name = "lblDataVolta";
            this.lblDataVolta.Size = new System.Drawing.Size(97, 14);
            this.lblDataVolta.TabIndex = 5;
            this.lblDataVolta.Text = "Data de Volta:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblDesc.Location = new System.Drawing.Point(36, 277);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(72, 14);
            this.lblDesc.TabIndex = 6;
            this.lblDesc.Text = "Descrição:";
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.BackColor = System.Drawing.Color.Transparent;
            this.lblImg.Location = new System.Drawing.Point(367, 104);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(63, 14);
            this.lblImg.TabIndex = 7;
            this.lblImg.Text = "Imagem:";
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(122, 104);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(216, 22);
            this.tbxValor.TabIndex = 8;
            // 
            // dtpDataIda
            // 
            this.dtpDataIda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataIda.Location = new System.Drawing.Point(122, 206);
            this.dtpDataIda.Name = "dtpDataIda";
            this.dtpDataIda.Size = new System.Drawing.Size(216, 22);
            this.dtpDataIda.TabIndex = 14;
            // 
            // dtpDataVolta
            // 
            this.dtpDataVolta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVolta.Location = new System.Drawing.Point(122, 240);
            this.dtpDataVolta.Name = "dtpDataVolta";
            this.dtpDataVolta.Size = new System.Drawing.Size(216, 22);
            this.dtpDataVolta.TabIndex = 15;
            // 
            // rtbDesc
            // 
            this.rtbDesc.Location = new System.Drawing.Point(122, 274);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(216, 96);
            this.rtbDesc.TabIndex = 16;
            this.rtbDesc.Text = "";
            // 
            // pbxImg
            // 
            this.pbxImg.BackColor = System.Drawing.Color.Transparent;
            this.pbxImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImg.Location = new System.Drawing.Point(367, 121);
            this.pbxImg.Name = "pbxImg";
            this.pbxImg.Size = new System.Drawing.Size(222, 141);
            this.pbxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImg.TabIndex = 17;
            this.pbxImg.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(514, 268);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(263, 376);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            this.cbxOrigem.Location = new System.Drawing.Point(122, 138);
            this.cbxOrigem.Name = "cbxOrigem";
            this.cbxOrigem.Size = new System.Drawing.Size(216, 22);
            this.cbxOrigem.TabIndex = 20;
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
            this.cbxDestino.Location = new System.Drawing.Point(122, 172);
            this.cbxDestino.Name = "cbxDestino";
            this.cbxDestino.Size = new System.Drawing.Size(216, 22);
            this.cbxDestino.TabIndex = 21;
            // 
            // ofdImg
            // 
            this.ofdImg.FileName = "ofdImg";
            // 
            // CadastrarPac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.cbxDestino);
            this.Controls.Add(this.cbxOrigem);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pbxImg);
            this.Controls.Add(this.rtbDesc);
            this.Controls.Add(this.dtpDataVolta);
            this.Controls.Add(this.dtpDataIda);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.lblImg);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblDataVolta);
            this.Controls.Add(this.lblDataIda);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblOrigem);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "CadastrarPac";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Pacote";
            this.Load += new System.EventHandler(this.CadastrarPac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblDataIda;
        private System.Windows.Forms.Label lblDataVolta;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.DateTimePicker dtpDataIda;
        private System.Windows.Forms.DateTimePicker dtpDataVolta;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.PictureBox pbxImg;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbxOrigem;
        private System.Windows.Forms.ComboBox cbxDestino;
        private System.Windows.Forms.OpenFileDialog ofdImg;
    }
}