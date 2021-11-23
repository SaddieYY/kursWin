
namespace kursWin
{
    partial class FilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxGroup = new System.Windows.Forms.CheckBox();
            this.groupBoxSort = new System.Windows.Forms.GroupBox();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.comboBoxHighLow = new System.Windows.Forms.ComboBox();
            this.checkBoxSort = new System.Windows.Forms.CheckBox();
            this.checkBoxFilter = new System.Windows.Forms.CheckBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.labelVolume = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPow = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.checkBoxVolume = new System.Windows.Forms.CheckBox();
            this.trackBarPower = new System.Windows.Forms.TrackBar();
            this.checkBoxCon = new System.Windows.Forms.CheckBox();
            this.checkBoxPower = new System.Windows.Forms.CheckBox();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.trackBarCon = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxType = new System.Windows.Forms.CheckBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderType = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxSort.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderType)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBoxSort);
            this.panel1.Controls.Add(this.checkBoxSort);
            this.panel1.Controls.Add(this.checkBoxFilter);
            this.panel1.Controls.Add(this.groupBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 424);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxGroup);
            this.groupBox1.Location = new System.Drawing.Point(294, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 68);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxGroup
            // 
            this.checkBoxGroup.AutoSize = true;
            this.checkBoxGroup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxGroup.Location = new System.Drawing.Point(23, 29);
            this.checkBoxGroup.Name = "checkBoxGroup";
            this.checkBoxGroup.Size = new System.Drawing.Size(115, 23);
            this.checkBoxGroup.TabIndex = 0;
            this.checkBoxGroup.Text = "group by type";
            this.checkBoxGroup.UseVisualStyleBackColor = true;
            // 
            // groupBoxSort
            // 
            this.groupBoxSort.Controls.Add(this.comboBoxSortBy);
            this.groupBoxSort.Controls.Add(this.comboBoxHighLow);
            this.groupBoxSort.Enabled = false;
            this.groupBoxSort.Location = new System.Drawing.Point(294, 98);
            this.groupBoxSort.Name = "groupBoxSort";
            this.groupBoxSort.Size = new System.Drawing.Size(178, 100);
            this.groupBoxSort.TabIndex = 6;
            this.groupBoxSort.TabStop = false;
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxSortBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSortBy.DisplayMember = "2";
            this.comboBoxSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortBy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSortBy.Items.AddRange(new object[] {
            "Name",
            "Type",
            "Power",
            "Consumption",
            "Volume",
            "Length"});
            this.comboBoxSortBy.Location = new System.Drawing.Point(23, 22);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(121, 25);
            this.comboBoxSortBy.TabIndex = 0;
            this.comboBoxSortBy.ValueMember = "0";
            // 
            // comboBoxHighLow
            // 
            this.comboBoxHighLow.DisplayMember = "0";
            this.comboBoxHighLow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHighLow.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxHighLow.FormattingEnabled = true;
            this.comboBoxHighLow.Items.AddRange(new object[] {
            "Low to High",
            "High to Low"});
            this.comboBoxHighLow.Location = new System.Drawing.Point(23, 51);
            this.comboBoxHighLow.Name = "comboBoxHighLow";
            this.comboBoxHighLow.Size = new System.Drawing.Size(121, 25);
            this.comboBoxHighLow.TabIndex = 2;
            this.comboBoxHighLow.ValueMember = "0";
            // 
            // checkBoxSort
            // 
            this.checkBoxSort.AutoSize = true;
            this.checkBoxSort.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxSort.Location = new System.Drawing.Point(294, 73);
            this.checkBoxSort.Name = "checkBoxSort";
            this.checkBoxSort.Size = new System.Drawing.Size(53, 23);
            this.checkBoxSort.TabIndex = 5;
            this.checkBoxSort.Text = "Sort";
            this.checkBoxSort.UseVisualStyleBackColor = true;
            this.checkBoxSort.CheckedChanged += new System.EventHandler(this.checkBoxSort_CheckedChanged);
            // 
            // checkBoxFilter
            // 
            this.checkBoxFilter.AutoSize = true;
            this.checkBoxFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxFilter.Location = new System.Drawing.Point(29, 73);
            this.checkBoxFilter.Name = "checkBoxFilter";
            this.checkBoxFilter.Size = new System.Drawing.Size(58, 23);
            this.checkBoxFilter.TabIndex = 4;
            this.checkBoxFilter.Text = "Filter";
            this.checkBoxFilter.UseVisualStyleBackColor = true;
            this.checkBoxFilter.CheckedChanged += new System.EventHandler(this.checkBoxFilter_CheckedChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.comboBoxName);
            this.groupBox.Controls.Add(this.labelVolume);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.labelCon);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.labelPow);
            this.groupBox.Controls.Add(this.label15);
            this.groupBox.Controls.Add(this.comboBoxType);
            this.groupBox.Controls.Add(this.checkBoxVolume);
            this.groupBox.Controls.Add(this.trackBarPower);
            this.groupBox.Controls.Add(this.checkBoxCon);
            this.groupBox.Controls.Add(this.checkBoxPower);
            this.groupBox.Controls.Add(this.trackBarVolume);
            this.groupBox.Controls.Add(this.trackBarCon);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.checkBoxType);
            this.groupBox.Controls.Add(this.checkBoxName);
            this.groupBox.Enabled = false;
            this.groupBox.Location = new System.Drawing.Point(29, 98);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(259, 260);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            // 
            // comboBoxName
            // 
            this.comboBoxName.Enabled = false;
            this.comboBoxName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxName.IntegralHeight = false;
            this.comboBoxName.Items.AddRange(new object[] {
            "All names",
            "Only one name"});
            this.comboBoxName.Location = new System.Drawing.Point(84, 22);
            this.comboBoxName.MaxDropDownItems = 3;
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(139, 25);
            this.comboBoxName.TabIndex = 23;
            this.comboBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxName_Validating);
            this.comboBoxName.Validated += new System.EventHandler(this.comboBoxName_Validated);
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVolume.Location = new System.Drawing.Point(220, 238);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelVolume.Size = new System.Drawing.Size(33, 19);
            this.labelVolume.TabIndex = 22;
            this.labelVolume.Text = "100";
            this.labelVolume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(126, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "0";
            // 
            // labelCon
            // 
            this.labelCon.AutoSize = true;
            this.labelCon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCon.Location = new System.Drawing.Point(220, 185);
            this.labelCon.Name = "labelCon";
            this.labelCon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCon.Size = new System.Drawing.Size(33, 19);
            this.labelCon.TabIndex = 20;
            this.labelCon.Text = "100";
            this.labelCon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(126, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "0";
            // 
            // labelPow
            // 
            this.labelPow.AutoSize = true;
            this.labelPow.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPow.Location = new System.Drawing.Point(220, 139);
            this.labelPow.Name = "labelPow";
            this.labelPow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPow.Size = new System.Drawing.Size(33, 19);
            this.labelPow.TabIndex = 18;
            this.labelPow.Text = "100";
            this.labelPow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(126, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 19);
            this.label15.TabIndex = 17;
            this.label15.Text = "0";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Car and Truck",
            "Car",
            "Truck"});
            this.comboBoxType.Location = new System.Drawing.Point(83, 65);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(140, 25);
            this.comboBoxType.TabIndex = 16;
            this.comboBoxType.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxType_Validating);
            this.comboBoxType.Validated += new System.EventHandler(this.comboBoxType_Validated);
            // 
            // checkBoxVolume
            // 
            this.checkBoxVolume.AutoSize = true;
            this.checkBoxVolume.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxVolume.Location = new System.Drawing.Point(19, 218);
            this.checkBoxVolume.Name = "checkBoxVolume";
            this.checkBoxVolume.Size = new System.Drawing.Size(74, 23);
            this.checkBoxVolume.TabIndex = 15;
            this.checkBoxVolume.Text = "Volume";
            this.checkBoxVolume.UseVisualStyleBackColor = true;
            this.checkBoxVolume.CheckedChanged += new System.EventHandler(this.checkBoxVolume_CheckedChanged);
            // 
            // trackBarPower
            // 
            this.trackBarPower.Enabled = false;
            this.trackBarPower.Location = new System.Drawing.Point(119, 105);
            this.trackBarPower.Maximum = 100;
            this.trackBarPower.Name = "trackBarPower";
            this.trackBarPower.Size = new System.Drawing.Size(134, 45);
            this.trackBarPower.TabIndex = 10;
            this.trackBarPower.ValueChanged += new System.EventHandler(this.trackBarPower_ValueChanged);
            // 
            // checkBoxCon
            // 
            this.checkBoxCon.AutoSize = true;
            this.checkBoxCon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxCon.Location = new System.Drawing.Point(19, 172);
            this.checkBoxCon.Name = "checkBoxCon";
            this.checkBoxCon.Size = new System.Drawing.Size(111, 23);
            this.checkBoxCon.TabIndex = 14;
            this.checkBoxCon.Text = "Consumption";
            this.checkBoxCon.UseVisualStyleBackColor = true;
            this.checkBoxCon.CheckedChanged += new System.EventHandler(this.checkBoxCon_CheckedChanged);
            // 
            // checkBoxPower
            // 
            this.checkBoxPower.AutoSize = true;
            this.checkBoxPower.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxPower.Location = new System.Drawing.Point(19, 120);
            this.checkBoxPower.Name = "checkBoxPower";
            this.checkBoxPower.Size = new System.Drawing.Size(65, 23);
            this.checkBoxPower.TabIndex = 13;
            this.checkBoxPower.Text = "Power";
            this.checkBoxPower.UseVisualStyleBackColor = true;
            this.checkBoxPower.CheckedChanged += new System.EventHandler(this.checkBoxPower_CheckedChanged);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Enabled = false;
            this.trackBarVolume.Location = new System.Drawing.Point(119, 207);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(134, 45);
            this.trackBarVolume.TabIndex = 12;
            this.trackBarVolume.ValueChanged += new System.EventHandler(this.trackBarVolume_ValueChanged);
            // 
            // trackBarCon
            // 
            this.trackBarCon.Enabled = false;
            this.trackBarCon.Location = new System.Drawing.Point(119, 156);
            this.trackBarCon.Maximum = 100;
            this.trackBarCon.Name = "trackBarCon";
            this.trackBarCon.Size = new System.Drawing.Size(134, 45);
            this.trackBarCon.TabIndex = 11;
            this.trackBarCon.ValueChanged += new System.EventHandler(this.trackBarCon_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 9;
            // 
            // checkBoxType
            // 
            this.checkBoxType.AutoSize = true;
            this.checkBoxType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxType.Location = new System.Drawing.Point(19, 65);
            this.checkBoxType.Name = "checkBoxType";
            this.checkBoxType.Size = new System.Drawing.Size(56, 23);
            this.checkBoxType.TabIndex = 6;
            this.checkBoxType.Text = "Type";
            this.checkBoxType.UseVisualStyleBackColor = true;
            this.checkBoxType.CheckedChanged += new System.EventHandler(this.checkBoxType_CheckedChanged);
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxName.Location = new System.Drawing.Point(19, 23);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(64, 23);
            this.checkBoxName.TabIndex = 5;
            this.checkBoxName.Text = "Name";
            this.checkBoxName.UseVisualStyleBackColor = true;
            this.checkBoxName.CheckedChanged += new System.EventHandler(this.checkBoxName_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 55);
            this.panel2.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(0, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(484, 55);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Filter items:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.buttonAccept);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 364);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(484, 60);
            this.panel3.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(267, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAccept.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAccept.Image = ((System.Drawing.Image)(resources.GetObject("buttonAccept.Image")));
            this.buttonAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAccept.Location = new System.Drawing.Point(135, 13);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(80, 28);
            this.buttonAccept.TabIndex = 0;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonCancel);
            this.panel4.Controls.Add(this.buttonAdd);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 434);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(484, 35);
            this.panel4.TabIndex = 24;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(198, 9);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAdd.Location = new System.Drawing.Point(82, 9);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(91, 270);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(238, 0);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(369, 31);
            this.label11.TabIndex = 20;
            this.label11.Text = "Edit item:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
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
            // FilterForm
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(484, 424);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FilterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSort.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxHighLow;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxType;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.TrackBar trackBarPower;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.TrackBar trackBarCon;
        private System.Windows.Forms.CheckBox checkBoxVolume;
        private System.Windows.Forms.CheckBox checkBoxCon;
        private System.Windows.Forms.CheckBox checkBoxPower;
        private System.Windows.Forms.CheckBox checkBoxSort;
        private System.Windows.Forms.CheckBox checkBoxFilter;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.GroupBox groupBoxSort;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelPow;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderType;
        private System.Windows.Forms.CheckBox checkBoxGroup;
    }
}