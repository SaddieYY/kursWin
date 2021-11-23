
namespace kursWin
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.powerSpinBox = new System.Windows.Forms.NumericUpDown();
            this.consumptionSpinBox = new System.Windows.Forms.NumericUpDown();
            this.volumeSpinBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderType = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPow = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCon = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderVol = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.powerSpinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumptionSpinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSpinBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVol)).BeginInit();
            this.SuspendLayout();
            // 
            // typeComboBox
            // 
            this.typeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.typeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.typeComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.typeComboBox.DisplayMember = "0";
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeComboBox.Items.AddRange(new object[] {
            "Car",
            "Truck"});
            this.typeComboBox.Location = new System.Drawing.Point(202, 45);
            this.typeComboBox.MaxDropDownItems = 2;
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.typeComboBox.Size = new System.Drawing.Size(121, 25);
            this.typeComboBox.TabIndex = 0;
            this.typeComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.typeComboBox_Validating);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.nameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.nameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.Location = new System.Drawing.Point(202, 17);
            this.nameTextBox.MaxLength = 20;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ShortcutsEnabled = false;
            this.nameTextBox.Size = new System.Drawing.Size(121, 25);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
            // 
            // powerSpinBox
            // 
            this.powerSpinBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.powerSpinBox.DecimalPlaces = 2;
            this.powerSpinBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.powerSpinBox.InterceptArrowKeys = false;
            this.powerSpinBox.Location = new System.Drawing.Point(202, 78);
            this.powerSpinBox.Name = "powerSpinBox";
            this.powerSpinBox.Size = new System.Drawing.Size(120, 25);
            this.powerSpinBox.TabIndex = 7;
            this.powerSpinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.powerSpinBox.Validating += new System.ComponentModel.CancelEventHandler(this.powerSpinBox_Validating);
            // 
            // consumptionSpinBox
            // 
            this.consumptionSpinBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.consumptionSpinBox.DecimalPlaces = 2;
            this.consumptionSpinBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.consumptionSpinBox.InterceptArrowKeys = false;
            this.consumptionSpinBox.Location = new System.Drawing.Point(202, 107);
            this.consumptionSpinBox.Name = "consumptionSpinBox";
            this.consumptionSpinBox.Size = new System.Drawing.Size(120, 25);
            this.consumptionSpinBox.TabIndex = 8;
            this.consumptionSpinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.consumptionSpinBox.Validating += new System.ComponentModel.CancelEventHandler(this.consumptionSpinBox_Validating);
            // 
            // volumeSpinBox
            // 
            this.volumeSpinBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.volumeSpinBox.DecimalPlaces = 2;
            this.volumeSpinBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.volumeSpinBox.InterceptArrowKeys = false;
            this.volumeSpinBox.Location = new System.Drawing.Point(202, 142);
            this.volumeSpinBox.Name = "volumeSpinBox";
            this.volumeSpinBox.Size = new System.Drawing.Size(120, 25);
            this.volumeSpinBox.TabIndex = 9;
            this.volumeSpinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.volumeSpinBox.Validating += new System.ComponentModel.CancelEventHandler(this.volumeSpinBox_Validating);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(67, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Consumption:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(67, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Power:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(67, 12);
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
            this.label2.Location = new System.Drawing.Point(67, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type:";
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(370, 52);
            this.label6.TabIndex = 11;
            this.label6.Text = "Add item:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(91, 240);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(156, 0);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Image = global::kursWin.Properties.Resources.accept16;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.Location = new System.Drawing.Point(82, 9);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 28);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
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
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
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
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 238);
            this.panel1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(67, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Volume:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 55);
            this.panel2.TabIndex = 14;
            // 
            // errorProviderName
            // 
            this.errorProviderName.BlinkRate = 0;
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
            // AddForm
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(370, 290);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddForm";
            ((System.ComponentModel.ISupportInitialize)(this.powerSpinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumptionSpinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSpinBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.NumericUpDown powerSpinBox;
        private System.Windows.Forms.NumericUpDown consumptionSpinBox;
        private System.Windows.Forms.NumericUpDown volumeSpinBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderType;
        private System.Windows.Forms.ErrorProvider errorProviderPow;
        private System.Windows.Forms.ErrorProvider errorProviderCon;
        private System.Windows.Forms.ErrorProvider errorProviderVol;
    }
}