namespace Grid_ado
{
    partial class Form2
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
            this.nvg = new System.Windows.Forms.BindingNavigator(this.components);
            this.fgn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.prdName = new System.Windows.Forms.TextBox();
            this.supplier = new System.Windows.Forms.NumericUpDown();
            this.unitsinstock = new System.Windows.Forms.NumericUpDown();
            this.categoryID = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UnitsOnOrder = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.QuantityPerUnit = new System.Windows.Forms.TextBox();
            this.ReorderLevel = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.m = new System.Windows.Forms.Label();
            this.Discontinued = new System.Windows.Forms.TextBox();
            this.UnitPrice = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nvg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsinstock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsOnOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReorderLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // nvg
            // 
            this.nvg.AddNewItem = null;
            this.nvg.CountItem = null;
            this.nvg.DeleteItem = null;
            this.nvg.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.nvg.Location = new System.Drawing.Point(0, 0);
            this.nvg.MoveFirstItem = null;
            this.nvg.MoveLastItem = null;
            this.nvg.MoveNextItem = null;
            this.nvg.MovePreviousItem = null;
            this.nvg.Name = "nvg";
            this.nvg.PositionItem = null;
            this.nvg.Size = new System.Drawing.Size(100, 25);
            this.nvg.TabIndex = 0;
            // 
            // fgn
            // 
            this.fgn.AutoSize = true;
            this.fgn.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fgn.Location = new System.Drawing.Point(9, 35);
            this.fgn.Name = "fgn";
            this.fgn.Size = new System.Drawing.Size(96, 22);
            this.fgn.TabIndex = 0;
            this.fgn.Text = "product ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "product Name:";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown.ForeColor = System.Drawing.SystemColors.InfoText;
            this.numericUpDown.Location = new System.Drawing.Point(300, 29);
            this.numericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(150, 30);
            this.numericUpDown.TabIndex = 4;
            this.numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "units in stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "supplier ID :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(871, 341);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(871, 289);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(871, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prdName
            // 
            this.prdName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prdName.ForeColor = System.Drawing.Color.Black;
            this.prdName.Location = new System.Drawing.Point(300, 91);
            this.prdName.Name = "prdName";
            this.prdName.Size = new System.Drawing.Size(301, 30);
            this.prdName.TabIndex = 14;
            this.prdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // supplier
            // 
            this.supplier.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.supplier.ForeColor = System.Drawing.SystemColors.InfoText;
            this.supplier.Location = new System.Drawing.Point(300, 158);
            this.supplier.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(150, 30);
            this.supplier.TabIndex = 15;
            this.supplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.supplier.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // unitsinstock
            // 
            this.unitsinstock.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unitsinstock.ForeColor = System.Drawing.SystemColors.InfoText;
            this.unitsinstock.Location = new System.Drawing.Point(300, 391);
            this.unitsinstock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.unitsinstock.Name = "unitsinstock";
            this.unitsinstock.Size = new System.Drawing.Size(150, 30);
            this.unitsinstock.TabIndex = 16;
            this.unitsinstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.unitsinstock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // categoryID
            // 
            this.categoryID.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryID.ForeColor = System.Drawing.SystemColors.InfoText;
            this.categoryID.Location = new System.Drawing.Point(300, 227);
            this.categoryID.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.categoryID.Name = "categoryID";
            this.categoryID.Size = new System.Drawing.Size(150, 30);
            this.categoryID.TabIndex = 18;
            this.categoryID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.categoryID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "category ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "QuantityPerUnit:";
            // 
            // UnitsOnOrder
            // 
            this.UnitsOnOrder.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnitsOnOrder.ForeColor = System.Drawing.SystemColors.InfoText;
            this.UnitsOnOrder.Location = new System.Drawing.Point(300, 344);
            this.UnitsOnOrder.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UnitsOnOrder.Name = "UnitsOnOrder";
            this.UnitsOnOrder.Size = new System.Drawing.Size(150, 30);
            this.UnitsOnOrder.TabIndex = 22;
            this.UnitsOnOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UnitsOnOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "UnitsOnOrder:";
            // 
            // QuantityPerUnit
            // 
            this.QuantityPerUnit.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuantityPerUnit.ForeColor = System.Drawing.Color.Black;
            this.QuantityPerUnit.Location = new System.Drawing.Point(300, 272);
            this.QuantityPerUnit.Name = "QuantityPerUnit";
            this.QuantityPerUnit.Size = new System.Drawing.Size(301, 30);
            this.QuantityPerUnit.TabIndex = 23;
            this.QuantityPerUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReorderLevel
            // 
            this.ReorderLevel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReorderLevel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ReorderLevel.Location = new System.Drawing.Point(827, 27);
            this.ReorderLevel.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ReorderLevel.Name = "ReorderLevel";
            this.ReorderLevel.Size = new System.Drawing.Size(150, 30);
            this.ReorderLevel.TabIndex = 25;
            this.ReorderLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReorderLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(591, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 22);
            this.label7.TabIndex = 24;
            this.label7.Text = "ReorderLevel:";
            // 
            // m
            // 
            this.m.AutoSize = true;
            this.m.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m.Location = new System.Drawing.Point(581, 183);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(114, 22);
            this.m.TabIndex = 27;
            this.m.Text = "Discontinued:";
            // 
            // Discontinued
            // 
            this.Discontinued.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Discontinued.ForeColor = System.Drawing.Color.Black;
            this.Discontinued.Location = new System.Drawing.Point(845, 183);
            this.Discontinued.Name = "Discontinued";
            this.Discontinued.Size = new System.Drawing.Size(174, 30);
            this.Discontinued.TabIndex = 26;
            this.Discontinued.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnitPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UnitPrice.Location = new System.Drawing.Point(845, 232);
            this.UnitPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Size = new System.Drawing.Size(150, 30);
            this.UnitPrice.TabIndex = 29;
            this.UnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UnitPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(567, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 22);
            this.label8.TabIndex = 28;
            this.label8.Text = "UnitPrice:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 450);
            this.Controls.Add(this.UnitPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.m);
            this.Controls.Add(this.Discontinued);
            this.Controls.Add(this.ReorderLevel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.QuantityPerUnit);
            this.Controls.Add(this.UnitsOnOrder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.categoryID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unitsinstock);
            this.Controls.Add(this.supplier);
            this.Controls.Add(this.prdName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fgn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nvg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsinstock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsOnOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReorderLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingNavigator nvg;
        private Label fgn;
        private Label label3;
        private NumericUpDown numericUpDown;
        private Label label2;
        private Label label5;
        private Button btnDelete;
        private Button btnUpdate;
        private Button button1;
        private TextBox prdName;
        private NumericUpDown supplier;
        private NumericUpDown unitsinstock;
        private NumericUpDown categoryID;
        private Label label1;
        private Label label4;
        private NumericUpDown UnitsOnOrder;
        private Label label6;
        private TextBox QuantityPerUnit;
        private NumericUpDown ReorderLevel;
        private Label label7;
        private Label m;
        private TextBox Discontinued;
        private NumericUpDown UnitPrice;
        private Label label8;
    }
}