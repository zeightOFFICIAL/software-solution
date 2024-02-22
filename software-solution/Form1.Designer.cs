namespace software_solution
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPageLayout = new System.Windows.Forms.TableLayoutPanel();
            this.loadLayout = new System.Windows.Forms.TableLayoutPanel();
            this.labelForLoadTextbox = new System.Windows.Forms.Label();
            this.loadTitleLabel = new System.Windows.Forms.Label();
            this.loadGridview = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadFieldsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.loadTextbox = new System.Windows.Forms.TextBox();
            this.loadPositionButton = new System.Windows.Forms.Button();
            this.clearDataButton = new System.Windows.Forms.Button();
            this.unloadLayout = new System.Windows.Forms.TableLayoutPanel();
            this.unloadGridview = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelForUnloadTextbox = new System.Windows.Forms.Label();
            this.unloadTitleTable = new System.Windows.Forms.Label();
            this.unloadFieldsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.unloadPositionButton = new System.Windows.Forms.Button();
            this.unloadTextbox = new System.Windows.Forms.TextBox();
            this.saveLoadDataLayout = new System.Windows.Forms.TableLayoutPanel();
            this.saveListsButton = new System.Windows.Forms.Button();
            this.loadDataButton = new System.Windows.Forms.Button();
            this.mainPageLayout.SuspendLayout();
            this.loadLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadGridview)).BeginInit();
            this.loadFieldsLayout.SuspendLayout();
            this.unloadLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unloadGridview)).BeginInit();
            this.unloadFieldsLayout.SuspendLayout();
            this.saveLoadDataLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPageLayout
            // 
            this.mainPageLayout.ColumnCount = 4;
            this.mainPageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.mainPageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.mainPageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.mainPageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.mainPageLayout.Controls.Add(this.loadLayout, 1, 1);
            this.mainPageLayout.Controls.Add(this.unloadLayout, 2, 1);
            this.mainPageLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPageLayout.Location = new System.Drawing.Point(0, 0);
            this.mainPageLayout.Name = "mainPageLayout";
            this.mainPageLayout.RowCount = 3;
            this.mainPageLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.74121F));
            this.mainPageLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.51759F));
            this.mainPageLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.74121F));
            this.mainPageLayout.Size = new System.Drawing.Size(1019, 635);
            this.mainPageLayout.TabIndex = 0;
            // 
            // loadLayout
            // 
            this.loadLayout.BackColor = System.Drawing.Color.LemonChiffon;
            this.loadLayout.ColumnCount = 1;
            this.loadLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.loadLayout.Controls.Add(this.labelForLoadTextbox, 0, 0);
            this.loadLayout.Controls.Add(this.loadTitleLabel, 0, 2);
            this.loadLayout.Controls.Add(this.loadGridview, 0, 3);
            this.loadLayout.Controls.Add(this.loadFieldsLayout, 0, 1);
            this.loadLayout.Controls.Add(this.clearDataButton, 0, 4);
            this.loadLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadLayout.Location = new System.Drawing.Point(87, 71);
            this.loadLayout.Name = "loadLayout";
            this.loadLayout.RowCount = 5;
            this.loadLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.754966F));
            this.loadLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.16949F));
            this.loadLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.627119F));
            this.loadLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.52988F));
            this.loadLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.417219F));
            this.loadLayout.Size = new System.Drawing.Size(418, 492);
            this.loadLayout.TabIndex = 0;
            // 
            // labelForLoadTextbox
            // 
            this.labelForLoadTextbox.AutoSize = true;
            this.labelForLoadTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelForLoadTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForLoadTextbox.Location = new System.Drawing.Point(3, 0);
            this.labelForLoadTextbox.Name = "labelForLoadTextbox";
            this.labelForLoadTextbox.Size = new System.Drawing.Size(412, 33);
            this.labelForLoadTextbox.TabIndex = 1;
            this.labelForLoadTextbox.Text = "Поле для ввода данных для приема";
            this.labelForLoadTextbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadTitleLabel
            // 
            this.loadTitleLabel.AutoSize = true;
            this.loadTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTitleLabel.Location = new System.Drawing.Point(3, 83);
            this.loadTitleLabel.Name = "loadTitleLabel";
            this.loadTitleLabel.Size = new System.Drawing.Size(412, 37);
            this.loadTitleLabel.TabIndex = 2;
            this.loadTitleLabel.Text = "ПРИЕМ";
            this.loadTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadGridview
            // 
            this.loadGridview.AllowUserToAddRows = false;
            this.loadGridview.AllowUserToDeleteRows = false;
            this.loadGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.loadGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.loadGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.amountColumn});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.loadGridview.DefaultCellStyle = dataGridViewCellStyle12;
            this.loadGridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadGridview.Location = new System.Drawing.Point(3, 123);
            this.loadGridview.Name = "loadGridview";
            this.loadGridview.ReadOnly = true;
            this.loadGridview.RowHeadersWidth = 51;
            this.loadGridview.RowTemplate.Height = 24;
            this.loadGridview.ShowCellErrors = false;
            this.loadGridview.ShowEditingIcon = false;
            this.loadGridview.Size = new System.Drawing.Size(412, 327);
            this.loadGridview.TabIndex = 3;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Наименование";
            this.nameColumn.MinimumWidth = 6;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // amountColumn
            // 
            this.amountColumn.HeaderText = "Количество";
            this.amountColumn.MinimumWidth = 6;
            this.amountColumn.Name = "amountColumn";
            this.amountColumn.ReadOnly = true;
            // 
            // loadFieldsLayout
            // 
            this.loadFieldsLayout.ColumnCount = 2;
            this.loadFieldsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.loadFieldsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.loadFieldsLayout.Controls.Add(this.loadTextbox, 0, 0);
            this.loadFieldsLayout.Controls.Add(this.loadPositionButton, 1, 0);
            this.loadFieldsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadFieldsLayout.Location = new System.Drawing.Point(3, 36);
            this.loadFieldsLayout.Name = "loadFieldsLayout";
            this.loadFieldsLayout.RowCount = 1;
            this.loadFieldsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.loadFieldsLayout.Size = new System.Drawing.Size(412, 44);
            this.loadFieldsLayout.TabIndex = 4;
            // 
            // loadTextbox
            // 
            this.loadTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.loadTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTextbox.Location = new System.Drawing.Point(0, 0);
            this.loadTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.loadTextbox.Multiline = true;
            this.loadTextbox.Name = "loadTextbox";
            this.loadTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.loadTextbox.Size = new System.Drawing.Size(309, 44);
            this.loadTextbox.TabIndex = 0;
            this.loadTextbox.WordWrap = false;
            this.loadTextbox.DoubleClick += new System.EventHandler(this.loadTextbox_DoubleClick);
            this.loadTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loadTextbox_KeyPress);
            // 
            // loadPositionButton
            // 
            this.loadPositionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadPositionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadPositionButton.Location = new System.Drawing.Point(312, 3);
            this.loadPositionButton.Name = "loadPositionButton";
            this.loadPositionButton.Size = new System.Drawing.Size(97, 38);
            this.loadPositionButton.TabIndex = 1;
            this.loadPositionButton.Text = "> >";
            this.loadPositionButton.UseVisualStyleBackColor = true;
            this.loadPositionButton.Click += new System.EventHandler(this.loadPositionButton_Click);
            // 
            // clearDataButton
            // 
            this.clearDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearDataButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearDataButton.Location = new System.Drawing.Point(3, 456);
            this.clearDataButton.Name = "clearDataButton";
            this.clearDataButton.Size = new System.Drawing.Size(412, 33);
            this.clearDataButton.TabIndex = 5;
            this.clearDataButton.Text = "Очистить";
            this.clearDataButton.UseVisualStyleBackColor = true;
            this.clearDataButton.Click += new System.EventHandler(this.clearDataButton_Click);
            // 
            // unloadLayout
            // 
            this.unloadLayout.BackColor = System.Drawing.Color.LightCyan;
            this.unloadLayout.ColumnCount = 1;
            this.unloadLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.unloadLayout.Controls.Add(this.unloadGridview, 0, 3);
            this.unloadLayout.Controls.Add(this.labelForUnloadTextbox, 0, 0);
            this.unloadLayout.Controls.Add(this.unloadTitleTable, 0, 2);
            this.unloadLayout.Controls.Add(this.unloadFieldsLayout, 0, 1);
            this.unloadLayout.Controls.Add(this.saveLoadDataLayout, 0, 4);
            this.unloadLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unloadLayout.Location = new System.Drawing.Point(511, 71);
            this.unloadLayout.Name = "unloadLayout";
            this.unloadLayout.RowCount = 5;
            this.unloadLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.622517F));
            this.unloadLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.38136F));
            this.unloadLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.627119F));
            this.unloadLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.52988F));
            this.unloadLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.417219F));
            this.unloadLayout.Size = new System.Drawing.Size(418, 492);
            this.unloadLayout.TabIndex = 1;
            // 
            // unloadGridview
            // 
            this.unloadGridview.AllowUserToAddRows = false;
            this.unloadGridview.AllowUserToDeleteRows = false;
            this.unloadGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.unloadGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.unloadGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.unloadGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unloadGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.unloadGridview.DefaultCellStyle = dataGridViewCellStyle10;
            this.unloadGridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unloadGridview.Location = new System.Drawing.Point(3, 123);
            this.unloadGridview.Name = "unloadGridview";
            this.unloadGridview.ReadOnly = true;
            this.unloadGridview.RowHeadersWidth = 51;
            this.unloadGridview.RowTemplate.Height = 24;
            this.unloadGridview.ShowCellErrors = false;
            this.unloadGridview.ShowEditingIcon = false;
            this.unloadGridview.Size = new System.Drawing.Size(412, 327);
            this.unloadGridview.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // labelForUnloadTextbox
            // 
            this.labelForUnloadTextbox.AutoSize = true;
            this.labelForUnloadTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelForUnloadTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForUnloadTextbox.Location = new System.Drawing.Point(3, 0);
            this.labelForUnloadTextbox.Name = "labelForUnloadTextbox";
            this.labelForUnloadTextbox.Size = new System.Drawing.Size(412, 32);
            this.labelForUnloadTextbox.TabIndex = 1;
            this.labelForUnloadTextbox.Text = "Поле для ввода данных для отгрузки";
            this.labelForUnloadTextbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unloadTitleTable
            // 
            this.unloadTitleTable.AutoSize = true;
            this.unloadTitleTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unloadTitleTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unloadTitleTable.Location = new System.Drawing.Point(3, 83);
            this.unloadTitleTable.Name = "unloadTitleTable";
            this.unloadTitleTable.Size = new System.Drawing.Size(412, 37);
            this.unloadTitleTable.TabIndex = 2;
            this.unloadTitleTable.Text = "ОТГРУЗКА";
            this.unloadTitleTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unloadFieldsLayout
            // 
            this.unloadFieldsLayout.ColumnCount = 2;
            this.unloadFieldsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.unloadFieldsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.unloadFieldsLayout.Controls.Add(this.unloadPositionButton, 1, 0);
            this.unloadFieldsLayout.Controls.Add(this.unloadTextbox, 0, 0);
            this.unloadFieldsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unloadFieldsLayout.Location = new System.Drawing.Point(3, 35);
            this.unloadFieldsLayout.Name = "unloadFieldsLayout";
            this.unloadFieldsLayout.RowCount = 1;
            this.unloadFieldsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.unloadFieldsLayout.Size = new System.Drawing.Size(412, 45);
            this.unloadFieldsLayout.TabIndex = 5;
            // 
            // unloadPositionButton
            // 
            this.unloadPositionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unloadPositionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unloadPositionButton.Location = new System.Drawing.Point(312, 3);
            this.unloadPositionButton.Name = "unloadPositionButton";
            this.unloadPositionButton.Size = new System.Drawing.Size(97, 39);
            this.unloadPositionButton.TabIndex = 0;
            this.unloadPositionButton.Text = "< <";
            this.unloadPositionButton.UseVisualStyleBackColor = true;
            this.unloadPositionButton.Click += new System.EventHandler(this.unloadPositionButton_Click);
            // 
            // unloadTextbox
            // 
            this.unloadTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unloadTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.unloadTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unloadTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unloadTextbox.Location = new System.Drawing.Point(0, 0);
            this.unloadTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.unloadTextbox.Multiline = true;
            this.unloadTextbox.Name = "unloadTextbox";
            this.unloadTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.unloadTextbox.Size = new System.Drawing.Size(309, 45);
            this.unloadTextbox.TabIndex = 0;
            this.unloadTextbox.WordWrap = false;
            this.unloadTextbox.DoubleClick += new System.EventHandler(this.unloadTextbox_DoubleClick);
            this.unloadTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unloadTextbox_KeyPress);
            // 
            // saveLoadDataLayout
            // 
            this.saveLoadDataLayout.ColumnCount = 2;
            this.saveLoadDataLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.saveLoadDataLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.saveLoadDataLayout.Controls.Add(this.saveListsButton, 0, 0);
            this.saveLoadDataLayout.Controls.Add(this.loadDataButton, 1, 0);
            this.saveLoadDataLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveLoadDataLayout.Location = new System.Drawing.Point(3, 456);
            this.saveLoadDataLayout.Name = "saveLoadDataLayout";
            this.saveLoadDataLayout.RowCount = 1;
            this.saveLoadDataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.saveLoadDataLayout.Size = new System.Drawing.Size(412, 33);
            this.saveLoadDataLayout.TabIndex = 6;
            // 
            // saveListsButton
            // 
            this.saveListsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveListsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveListsButton.Location = new System.Drawing.Point(3, 3);
            this.saveListsButton.Name = "saveListsButton";
            this.saveListsButton.Size = new System.Drawing.Size(200, 27);
            this.saveListsButton.TabIndex = 6;
            this.saveListsButton.Text = "Сохранить";
            this.saveListsButton.UseVisualStyleBackColor = true;
            this.saveListsButton.Click += new System.EventHandler(this.saveListsButton_Click);
            // 
            // loadDataButton
            // 
            this.loadDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadDataButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadDataButton.Location = new System.Drawing.Point(209, 3);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(200, 27);
            this.loadDataButton.TabIndex = 7;
            this.loadDataButton.Text = "Загрузить";
            this.loadDataButton.UseVisualStyleBackColor = true;
            this.loadDataButton.Click += new System.EventHandler(this.loadDataButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 635);
            this.Controls.Add(this.mainPageLayout);
            this.MinimumSize = new System.Drawing.Size(930, 550);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainPageLayout.ResumeLayout(false);
            this.loadLayout.ResumeLayout(false);
            this.loadLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadGridview)).EndInit();
            this.loadFieldsLayout.ResumeLayout(false);
            this.loadFieldsLayout.PerformLayout();
            this.unloadLayout.ResumeLayout(false);
            this.unloadLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unloadGridview)).EndInit();
            this.unloadFieldsLayout.ResumeLayout(false);
            this.unloadFieldsLayout.PerformLayout();
            this.saveLoadDataLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPageLayout;
        private System.Windows.Forms.TableLayoutPanel loadLayout;
        private System.Windows.Forms.TableLayoutPanel unloadLayout;
        private System.Windows.Forms.TextBox loadTextbox;
        private System.Windows.Forms.TextBox unloadTextbox;
        private System.Windows.Forms.Label labelForLoadTextbox;
        private System.Windows.Forms.Label loadTitleLabel;
        private System.Windows.Forms.Label labelForUnloadTextbox;
        private System.Windows.Forms.Label unloadTitleTable;
        private System.Windows.Forms.DataGridView loadGridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountColumn;
        private System.Windows.Forms.DataGridView unloadGridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TableLayoutPanel loadFieldsLayout;
        private System.Windows.Forms.Button loadPositionButton;
        private System.Windows.Forms.TableLayoutPanel unloadFieldsLayout;
        private System.Windows.Forms.Button unloadPositionButton;
        private System.Windows.Forms.Button clearDataButton;
        private System.Windows.Forms.Button saveListsButton;
        private System.Windows.Forms.TableLayoutPanel saveLoadDataLayout;
        private System.Windows.Forms.Button loadDataButton;
    }
}

