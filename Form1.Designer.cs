namespace AFEFWFV05221018
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.UltraWinDataSource.UltraDataBand ultraDataBand1 = new Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 2");
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("LovePets", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PetID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PetName");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PetType");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PetBreed");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PetDOB");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("OwnerID");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbRaza = new System.Windows.Forms.TextBox();
            this.btSelect = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.nuIdMascotas = new System.Windows.Forms.NumericUpDown();
            this.nuAmo = new System.Windows.Forms.NumericUpDown();
            this.DTPFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.CBTipoAnimal = new System.Windows.Forms.ComboBox();
            this.ultraDataSource1 = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.btCheqeo = new System.Windows.Forms.Button();
            this.BSPET = new System.Windows.Forms.BindingSource(this.components);
            this.veterianDataSet = new AFEFWFV05221018.VeterianDataSet();
            this.BSLovePets = new System.Windows.Forms.BindingSource(this.components);
            this.veterianDataSet2 = new AFEFWFV05221018.VeterianDataSet2();
            this.veterianDataSet1 = new AFEFWFV05221018.VeterianDataSet1();
            this.ultraGrid1 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.BTUltragrid = new System.Windows.Forms.Button();
            this.btPruebas = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btPRBNumeric = new System.Windows.Forms.Button();
            this.btComboBox = new System.Windows.Forms.Button();
            this.btForm2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btFormUG1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nuIdMascotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuAmo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSPET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterianDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSLovePets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterianDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterianDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Raza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "amo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "tipoAnimal";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "IdMascotas";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(197, 94);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(126, 22);
            this.tbNombre.TabIndex = 7;
            this.tbNombre.Text = "foo";
            // 
            // tbRaza
            // 
            this.tbRaza.Location = new System.Drawing.Point(197, 182);
            this.tbRaza.Name = "tbRaza";
            this.tbRaza.Size = new System.Drawing.Size(126, 22);
            this.tbRaza.TabIndex = 9;
            this.tbRaza.Text = "bar";
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(403, 79);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(75, 23);
            this.btSelect.TabIndex = 11;
            this.btSelect.Text = "Select";
            this.btSelect.UseVisualStyleBackColor = true;
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(403, 127);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(75, 23);
            this.btInsert.TabIndex = 12;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(403, 179);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 13;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(403, 222);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 14;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // nuIdMascotas
            // 
            this.nuIdMascotas.Location = new System.Drawing.Point(197, 46);
            this.nuIdMascotas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuIdMascotas.Name = "nuIdMascotas";
            this.nuIdMascotas.Size = new System.Drawing.Size(120, 22);
            this.nuIdMascotas.TabIndex = 15;
            this.nuIdMascotas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuIdMascotas.ValueChanged += new System.EventHandler(this.nuIdMascotas_ValueChanged);
            // 
            // nuAmo
            // 
            this.nuAmo.Location = new System.Drawing.Point(197, 228);
            this.nuAmo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuAmo.Name = "nuAmo";
            this.nuAmo.Size = new System.Drawing.Size(120, 22);
            this.nuAmo.TabIndex = 16;
            this.nuAmo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DTPFechaNacimiento
            // 
            this.DTPFechaNacimiento.Location = new System.Drawing.Point(197, 279);
            this.DTPFechaNacimiento.Name = "DTPFechaNacimiento";
            this.DTPFechaNacimiento.Size = new System.Drawing.Size(200, 22);
            this.DTPFechaNacimiento.TabIndex = 17;
            this.DTPFechaNacimiento.ValueChanged += new System.EventHandler(this.DTPFechaNacimiento_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "FechaNacimiento";
            // 
            // CBTipoAnimal
            // 
            this.CBTipoAnimal.FormattingEnabled = true;
            this.CBTipoAnimal.Location = new System.Drawing.Point(197, 139);
            this.CBTipoAnimal.Name = "CBTipoAnimal";
            this.CBTipoAnimal.Size = new System.Drawing.Size(121, 24);
            this.CBTipoAnimal.TabIndex = 19;
            this.CBTipoAnimal.SelectedIndexChanged += new System.EventHandler(this.CBTipoAnimal_SelectedIndexChanged);
            // 
            // ultraDataSource1
            // 
            this.ultraDataSource1.Band.ChildBands.AddRange(new object[] {
            ultraDataBand1});
            // 
            // btCheqeo
            // 
            this.btCheqeo.Location = new System.Drawing.Point(12, 12);
            this.btCheqeo.Name = "btCheqeo";
            this.btCheqeo.Size = new System.Drawing.Size(75, 23);
            this.btCheqeo.TabIndex = 20;
            this.btCheqeo.Text = "Chequeo";
            this.btCheqeo.UseVisualStyleBackColor = true;
            // 
            // BSPET
            // 
            this.BSPET.DataSource = this.veterianDataSet;
            this.BSPET.Position = 0;
            // 
            // veterianDataSet
            // 
            this.veterianDataSet.DataSetName = "VeterianDataSet";
            this.veterianDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BSLovePets
            // 
            this.BSLovePets.DataSource = this.veterianDataSet2;
            this.BSLovePets.Position = 0;
            // 
            // veterianDataSet2
            // 
            this.veterianDataSet2.DataSetName = "VeterianDataSet2";
            this.veterianDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veterianDataSet1
            // 
            this.veterianDataSet1.DataSetName = "VeterianDataSet1";
            this.veterianDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraGrid1
            // 
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ultraGrid1.DisplayLayout.Appearance = appearance1;
            ultraGridBand1.AutoPreviewEnabled = true;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6});
            this.ultraGrid1.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
            this.ultraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance4.BackColor2 = System.Drawing.SystemColors.Control;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGrid1.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
            this.ultraGrid1.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraGrid1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ultraGrid1.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.Highlight;
            appearance6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ultraGrid1.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.ultraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ultraGrid1.DisplayLayout.Override.CellAppearance = appearance8;
            this.ultraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraGrid1.DisplayLayout.Override.CellPadding = 0;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.Override.GroupByRowAppearance = appearance9;
            appearance10.TextHAlignAsString = "Left";
            this.ultraGrid1.DisplayLayout.Override.HeaderAppearance = appearance10;
            this.ultraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.ultraGrid1.DisplayLayout.Override.RowAppearance = appearance11;
            this.ultraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraGrid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
            this.ultraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGrid1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraGrid1.Location = new System.Drawing.Point(12, 312);
            this.ultraGrid1.Name = "ultraGrid1";
            this.ultraGrid1.Size = new System.Drawing.Size(700, 300);
            this.ultraGrid1.TabIndex = 21;
            this.ultraGrid1.Text = "ultraGrid1";
            this.ultraGrid1.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.ultraGrid1_InitializeLayout);
            // 
            // BTUltragrid
            // 
            this.BTUltragrid.Location = new System.Drawing.Point(114, 12);
            this.BTUltragrid.Name = "BTUltragrid";
            this.BTUltragrid.Size = new System.Drawing.Size(75, 23);
            this.BTUltragrid.TabIndex = 22;
            this.BTUltragrid.Text = "ultraGrid";
            this.BTUltragrid.UseVisualStyleBackColor = true;
            this.BTUltragrid.Click += new System.EventHandler(this.BTUltragrid_Click);
            // 
            // btPruebas
            // 
            this.btPruebas.Location = new System.Drawing.Point(215, 12);
            this.btPruebas.Name = "btPruebas";
            this.btPruebas.Size = new System.Drawing.Size(75, 23);
            this.btPruebas.TabIndex = 23;
            this.btPruebas.Text = "PRUEBAS";
            this.btPruebas.UseVisualStyleBackColor = true;
            this.btPruebas.Click += new System.EventHandler(this.btPruebas_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(322, 12);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 24;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btPRBNumeric
            // 
            this.btPRBNumeric.Location = new System.Drawing.Point(428, 12);
            this.btPRBNumeric.Name = "btPRBNumeric";
            this.btPRBNumeric.Size = new System.Drawing.Size(75, 23);
            this.btPRBNumeric.TabIndex = 25;
            this.btPRBNumeric.Text = "prbNumeric";
            this.btPRBNumeric.UseVisualStyleBackColor = true;
            this.btPRBNumeric.Click += new System.EventHandler(this.btPRBNumeric_Click);
            // 
            // btComboBox
            // 
            this.btComboBox.Location = new System.Drawing.Point(536, 12);
            this.btComboBox.Name = "btComboBox";
            this.btComboBox.Size = new System.Drawing.Size(75, 23);
            this.btComboBox.TabIndex = 26;
            this.btComboBox.Text = "prbCB";
            this.btComboBox.UseVisualStyleBackColor = true;
            // 
            // btForm2
            // 
            this.btForm2.Location = new System.Drawing.Point(640, 12);
            this.btForm2.Name = "btForm2";
            this.btForm2.Size = new System.Drawing.Size(75, 23);
            this.btForm2.TabIndex = 27;
            this.btForm2.Text = "IrForm2";
            this.btForm2.UseVisualStyleBackColor = true;
            this.btForm2.Click += new System.EventHandler(this.btForm2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 682);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 682);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 639);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "ZonaUltraGrid";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btFormUG1
            // 
            this.btFormUG1.Location = new System.Drawing.Point(637, 51);
            this.btFormUG1.Name = "btFormUG1";
            this.btFormUG1.Size = new System.Drawing.Size(75, 23);
            this.btFormUG1.TabIndex = 32;
            this.btFormUG1.Text = "UG1";
            this.btFormUG1.UseVisualStyleBackColor = true;
            this.btFormUG1.Click += new System.EventHandler(this.btFormUG1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 768);
            this.Controls.Add(this.btFormUG1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btForm2);
            this.Controls.Add(this.btComboBox);
            this.Controls.Add(this.btPRBNumeric);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btPruebas);
            this.Controls.Add(this.BTUltragrid);
            this.Controls.Add(this.ultraGrid1);
            this.Controls.Add(this.btCheqeo);
            this.Controls.Add(this.CBTipoAnimal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DTPFechaNacimiento);
            this.Controls.Add(this.nuAmo);
            this.Controls.Add(this.nuIdMascotas);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.tbRaza);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nuIdMascotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuAmo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSPET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterianDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSLovePets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterianDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterianDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbRaza;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.NumericUpDown nuIdMascotas;
        private System.Windows.Forms.NumericUpDown nuAmo;
        private System.Windows.Forms.DateTimePicker DTPFechaNacimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBTipoAnimal;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSource1;
        private System.Windows.Forms.Button btCheqeo;
        private System.Windows.Forms.BindingSource BSPET;
        private VeterianDataSet veterianDataSet;
        private System.Windows.Forms.BindingSource BSLovePets;
        private VeterianDataSet2 veterianDataSet2;
        private VeterianDataSet1 veterianDataSet1;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid1;
        private System.Windows.Forms.Button BTUltragrid;
        private System.Windows.Forms.Button btPruebas;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btPRBNumeric;
        private System.Windows.Forms.Button btComboBox;
        private System.Windows.Forms.Button btForm2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btFormUG1;
    }
}

