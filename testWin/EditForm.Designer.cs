
namespace kursWin
{
    partial class EditForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.volumeSpinBox = new System.Windows.Forms.NumericUpDown();
            this.consumptionSpinBox = new System.Windows.Forms.NumericUpDown();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.powerSpinBox = new System.Windows.Forms.NumericUpDown();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.numericVol = new System.Windows.Forms.NumericUpDown();
            this.numericCon = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericPow = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderType = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPow = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCon = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderVol = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSpinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumptionSpinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerSpinBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPow)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVol)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.volumeSpinBox);
            this.panel1.Controls.Add(this.consumptionSpinBox);
            this.panel1.Controls.Add(this.typeComboBox);
            this.panel1.Controls.Add(this.powerSpinBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 17;
            // 
            // volumeSpinBox
            // 
            this.volumeSpinBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.volumeSpinBox.DecimalPlaces = 2;
            this.volumeSpinBox.InterceptArrowKeys = false;
            this.volumeSpinBox.Location = new System.Drawing.Point(483, 336);
            this.volumeSpinBox.Name = "volumeSpinBox";
            this.volumeSpinBox.Size = new System.Drawing.Size(120, 23);
            this.volumeSpinBox.TabIndex = 9;
            this.volumeSpinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // consumptionSpinBox
            // 
            this.consumptionSpinBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.consumptionSpinBox.DecimalPlaces = 2;
            this.consumptionSpinBox.InterceptArrowKeys = false;
            this.consumptionSpinBox.Location = new System.Drawing.Point(483, 301);
            this.consumptionSpinBox.Name = "consumptionSpinBox";
            this.consumptionSpinBox.Size = new System.Drawing.Size(120, 23);
            this.consumptionSpinBox.TabIndex = 8;
            this.consumptionSpinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // typeComboBox
            // 
            this.typeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.typeComboBox.DisplayMember = "0";
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Car",
            "Truck"});
            this.typeComboBox.Location = new System.Drawing.Point(483, 239);
            this.typeComboBox.MaxDropDownItems = 2;
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.typeComboBox.Size = new System.Drawing.Size(121, 23);
            this.typeComboBox.TabIndex = 0;
            // 
            // powerSpinBox
            // 
            this.powerSpinBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.powerSpinBox.DecimalPlaces = 2;
            this.powerSpinBox.InterceptArrowKeys = false;
            this.powerSpinBox.Location = new System.Drawing.Point(483, 272);
            this.powerSpinBox.Name = "powerSpinBox";
            this.powerSpinBox.Size = new System.Drawing.Size(120, 23);
            this.powerSpinBox.TabIndex = 7;
            this.powerSpinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.Location = new System.Drawing.Point(483, 211);
            this.nameTextBox.MaxLength = 10;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 23);
            this.nameTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(348, 330);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Volume:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(348, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(348, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(348, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Power:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(348, 299);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Consumption:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.numericVol);
            this.panel2.Controls.Add(this.numericCon);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.numericPow);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 212);
            this.panel2.TabIndex = 17;
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Image = global::kursWin.Properties.Resources.deleteall16;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.Location = new System.Drawing.Point(139, 176);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(80, 28);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // numericVol
            // 
            this.numericVol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericVol.DecimalPlaces = 2;
            this.numericVol.InterceptArrowKeys = false;
            this.numericVol.Location = new System.Drawing.Point(198, 131);
            this.numericVol.Name = "numericVol";
            this.numericVol.Size = new System.Drawing.Size(120, 23);
            this.numericVol.TabIndex = 9;
            this.numericVol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericVol.Validating += new System.ComponentModel.CancelEventHandler(this.numericVol_Validating);
            // 
            // numericCon
            // 
            this.numericCon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericCon.DecimalPlaces = 2;
            this.numericCon.InterceptArrowKeys = false;
            this.numericCon.Location = new System.Drawing.Point(198, 96);
            this.numericCon.Name = "numericCon";
            this.numericCon.Size = new System.Drawing.Size(120, 23);
            this.numericCon.TabIndex = 8;
            this.numericCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericCon.Validating += new System.ComponentModel.CancelEventHandler(this.numericCon_Validating);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox1.DisplayMember = "0";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Car",
            "Truck"});
            this.comboBox1.Location = new System.Drawing.Point(198, 34);
            this.comboBox1.MaxDropDownItems = 2;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox1_Validating);
            // 
            // numericPow
            // 
            this.numericPow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericPow.DecimalPlaces = 2;
            this.numericPow.InterceptArrowKeys = false;
            this.numericPow.Location = new System.Drawing.Point(198, 67);
            this.numericPow.Name = "numericPow";
            this.numericPow.Size = new System.Drawing.Size(120, 23);
            this.numericPow.TabIndex = 7;
            this.numericPow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericPow.Validating += new System.ComponentModel.CancelEventHandler(this.numericPow_Validating);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Ford",
            "Mercedes",
            "Honda",
            "Ferrari",
            "Shevrolet",
            "Opel",
            "Nissan",
            "Audi",
            "Lanos",
            "Lamborgini",
            "Fiat",
            "Hyundai",
            "BMW",
            "Mazda"});
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(198, 6);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 23);
            this.textBox1.TabIndex = 6;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(63, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Volume:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(63, 1);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Name:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(63, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Type:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(63, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Power:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(63, 94);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Consumption:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(91, 252);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(238, 0);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(369, 43);
            this.label11.TabIndex = 15;
            this.label11.Text = "Edit item:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Image = global::kursWin.Properties.Resources.cancel16;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancel.Location = new System.Drawing.Point(198, 9);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 28);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.Image = global::kursWin.Properties.Resources.accept16;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEdit.Location = new System.Drawing.Point(82, 9);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(80, 28);
            this.buttonEdit.TabIndex = 0;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonCancel);
            this.panel3.Controls.Add(this.buttonEdit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 255);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(369, 44);
            this.panel3.TabIndex = 18;
            // 
            // errorProviderName
            // 
            this.errorProviderName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderType
            // 
            this.errorProviderType.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderType.ContainerControl = this;
            // 
            // errorProviderPow
            // 
            this.errorProviderPow.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderPow.ContainerControl = this;
            // 
            // errorProviderCon
            // 
            this.errorProviderCon.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderCon.ContainerControl = this;
            // 
            // errorProviderVol
            // 
            this.errorProviderVol.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderVol.ContainerControl = this;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 299);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSpinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumptionSpinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerSpinBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPow)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown volumeSpinBox;
        private System.Windows.Forms.NumericUpDown consumptionSpinBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.NumericUpDown powerSpinBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericVol;
        private System.Windows.Forms.NumericUpDown numericCon;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericPow;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderType;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ErrorProvider errorProviderPow;
        private System.Windows.Forms.ErrorProvider errorProviderCon;
        private System.Windows.Forms.ErrorProvider errorProviderVol;
    }
}