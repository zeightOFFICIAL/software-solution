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
            this.mainPageLayout = new System.Windows.Forms.TableLayoutPanel();
            this.loadLayout = new System.Windows.Forms.TableLayoutPanel();
            this.labelForLoadTextbox = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loadGridview = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadFieldsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.loadTextbox = new System.Windows.Forms.TextBox();
            this.loadPositionButton = new System.Windows.Forms.Button();
            this.unloadLayout = new System.Windows.Forms.TableLayoutPanel();
            this.unloadGridview = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelForUnloadTextbox = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.unloadFieldsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.unloadPositionButton = new System.Windows.Forms.Button();
            this.unloadTextbox = new System.Windows.Forms.TextBox();
            this.mainPageLayout.SuspendLayout();
            this.loadLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadGridview)).BeginInit();
            this.loadFieldsLayout.SuspendLayout();
            this.unloadLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unloadGridview)).BeginInit();
            this.unloadFieldsLayout.SuspendLayout();
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
            this.mainPageLayout.Size = new System.Drawing.Size(912, 503);
            this.mainPageLayout.TabIndex = 0;
            // 
            // loadLayout
            // 
            this.loadLayout.BackColor = System.Drawing.Color.LemonChiffon;
            this.loadLayout.ColumnCount = 1;
            this.loadLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.loadLayout.Controls.Add(this.labelForLoadTextbox, 0, 0);
            this.loadLayout.Controls.Add(this.label4, 0, 2);
            this.loadLayout.Controls.Add(this.loadGridview, 0, 3);
            this.loadLayout.Controls.Add(this.loadFieldsLayout, 0, 1);
            this.loadLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadLayout.Location = new System.Drawing.Point(78, 57);
            this.loadLayout.Name = "loadLayout";
            this.loadLayout.RowCount = 5;
            this.loadLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.754966F));
            this.loadLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.16949F));
            this.loadLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.627119F));
            this.loadLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.52988F));
            this.loadLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.417219F));
            this.loadLayout.Size = new System.Drawing.Size(374, 388);
            this.loadLayout.TabIndex = 0;
            // 
            // labelForLoadTextbox
            // 
            this.labelForLoadTextbox.AutoSize = true;
            this.labelForLoadTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelForLoadTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForLoadTextbox.Location = new System.Drawing.Point(3, 0);
            this.labelForLoadTextbox.Name = "labelForLoadTextbox";
            this.labelForLoadTextbox.Size = new System.Drawing.Size(368, 26);
            this.labelForLoadTextbox.TabIndex = 1;
            this.labelForLoadTextbox.Text = "Поле для ввода данных для приема";
            this.labelForLoadTextbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(368, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "ПРИЕМ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadGridview
            // 
            this.loadGridview.AllowUserToAddRows = false;
            this.loadGridview.AllowUserToDeleteRows = false;
            this.loadGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loadGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.amountColumn});
            this.loadGridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadGridview.Location = new System.Drawing.Point(3, 97);
            this.loadGridview.Name = "loadGridview";
            this.loadGridview.ReadOnly = true;
            this.loadGridview.RowHeadersWidth = 51;
            this.loadGridview.RowTemplate.Height = 24;
            this.loadGridview.ShowCellErrors = false;
            this.loadGridview.ShowEditingIcon = false;
            this.loadGridview.Size = new System.Drawing.Size(368, 257);
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
            this.loadFieldsLayout.Location = new System.Drawing.Point(3, 29);
            this.loadFieldsLayout.Name = "loadFieldsLayout";
            this.loadFieldsLayout.RowCount = 1;
            this.loadFieldsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.loadFieldsLayout.Size = new System.Drawing.Size(368, 33);
            this.loadFieldsLayout.TabIndex = 4;
            // 
            // loadTextbox
            // 
            this.loadTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTextbox.Location = new System.Drawing.Point(15, 3);
            this.loadTextbox.Margin = new System.Windows.Forms.Padding(15, 3, 40, 3);
            this.loadTextbox.Name = "loadTextbox";
            this.loadTextbox.Size = new System.Drawing.Size(221, 28);
            this.loadTextbox.TabIndex = 0;
            this.loadTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loadTextbox_KeyPress);
            // 
            // loadPositionButton
            // 
            this.loadPositionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadPositionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadPositionButton.Location = new System.Drawing.Point(279, 3);
            this.loadPositionButton.Name = "loadPositionButton";
            this.loadPositionButton.Size = new System.Drawing.Size(86, 27);
            this.loadPositionButton.TabIndex = 1;
            this.loadPositionButton.Text = "> >";
            this.loadPositionButton.UseVisualStyleBackColor = true;
            // 
            // unloadLayout
            // 
            this.unloadLayout.BackColor = System.Drawing.Color.LightCyan;
            this.unloadLayout.ColumnCount = 1;
            this.unloadLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.unloadLayout.Controls.Add(this.unloadGridview, 0, 3);
            this.unloadLayout.Controls.Add(this.labelForUnloadTextbox, 0, 0);
            this.unloadLayout.Controls.Add(this.label3, 0, 2);
            this.unloadLayout.Controls.Add(this.unloadFieldsLayout, 0, 1);
            this.unloadLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unloadLayout.Location = new System.Drawing.Point(458, 57);
            this.unloadLayout.Name = "unloadLayout";
            this.unloadLayout.RowCount = 5;
            this.unloadLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.622517F));
            this.unloadLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.38136F));
            this.unloadLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.627119F));
            this.unloadLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.52988F));
            this.unloadLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.417219F));
            this.unloadLayout.Size = new System.Drawing.Size(374, 388);
            this.unloadLayout.TabIndex = 1;
            // 
            // unloadGridview
            // 
            this.unloadGridview.AllowUserToAddRows = false;
            this.unloadGridview.AllowUserToDeleteRows = false;
            this.unloadGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.unloadGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unloadGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unloadGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.unloadGridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unloadGridview.Location = new System.Drawing.Point(3, 97);
            this.unloadGridview.Name = "unloadGridview";
            this.unloadGridview.ReadOnly = true;
            this.unloadGridview.RowHeadersWidth = 51;
            this.unloadGridview.RowTemplate.Height = 24;
            this.unloadGridview.ShowCellErrors = false;
            this.unloadGridview.ShowEditingIcon = false;
            this.unloadGridview.Size = new System.Drawing.Size(368, 257);
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
            this.labelForUnloadTextbox.Size = new System.Drawing.Size(368, 25);
            this.labelForUnloadTextbox.TabIndex = 1;
            this.labelForUnloadTextbox.Text = "Поле для ввода данных для отгрузки";
            this.labelForUnloadTextbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "ОТГРУЗКА";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unloadFieldsLayout
            // 
            this.unloadFieldsLayout.ColumnCount = 2;
            this.unloadFieldsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.unloadFieldsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.unloadFieldsLayout.Controls.Add(this.unloadPositionButton, 1, 0);
            this.unloadFieldsLayout.Controls.Add(this.unloadTextbox, 0, 0);
            this.unloadFieldsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unloadFieldsLayout.Location = new System.Drawing.Point(3, 28);
            this.unloadFieldsLayout.Name = "unloadFieldsLayout";
            this.unloadFieldsLayout.RowCount = 1;
            this.unloadFieldsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.unloadFieldsLayout.Size = new System.Drawing.Size(368, 34);
            this.unloadFieldsLayout.TabIndex = 5;
            // 
            // unloadPositionButton
            // 
            this.unloadPositionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unloadPositionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unloadPositionButton.Location = new System.Drawing.Point(279, 3);
            this.unloadPositionButton.Name = "unloadPositionButton";
            this.unloadPositionButton.Size = new System.Drawing.Size(86, 28);
            this.unloadPositionButton.TabIndex = 0;
            this.unloadPositionButton.Text = "< <";
            this.unloadPositionButton.UseVisualStyleBackColor = true;
            // 
            // unloadTextbox
            // 
            this.unloadTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unloadTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unloadTextbox.Location = new System.Drawing.Point(40, 3);
            this.unloadTextbox.Margin = new System.Windows.Forms.Padding(40, 3, 15, 3);
            this.unloadTextbox.Name = "unloadTextbox";
            this.unloadTextbox.Size = new System.Drawing.Size(221, 28);
            this.unloadTextbox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 503);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPageLayout;
        private System.Windows.Forms.TableLayoutPanel loadLayout;
        private System.Windows.Forms.TableLayoutPanel unloadLayout;
        private System.Windows.Forms.TextBox loadTextbox;
        private System.Windows.Forms.TextBox unloadTextbox;
        private System.Windows.Forms.Label labelForLoadTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelForUnloadTextbox;
        private System.Windows.Forms.Label label3;
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
    }
}

