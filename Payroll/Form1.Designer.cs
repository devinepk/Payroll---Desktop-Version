namespace Payroll
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
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.TotalPayInput = new System.Windows.Forms.TextBox();
            this.ExtraInput = new System.Windows.Forms.TextBox();
            this.QtyInput = new System.Windows.Forms.TextBox();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.LastNameInput = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.Qty = new System.Windows.Forms.Label();
            this.Extra = new System.Windows.Forms.Label();
            this.totalPay = new System.Windows.Forms.Label();
            this.comments = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.payRate = new System.Windows.Forms.Label();
            this.FirstNameInput = new System.Windows.Forms.TextBox();
            this.CommentsInput = new System.Windows.Forms.TextBox();
            this.PayRateInput = new System.Windows.Forms.TextBox();
            this.PayPeriodStartPicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PayPeriodEndPicker = new System.Windows.Forms.DateTimePicker();
            this.AddRow = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SendingAddress = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SendEmail = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FN_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LN_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayRate_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extra_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPay_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainTable.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 8;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainTable.Controls.Add(this.TotalPayInput, 6, 1);
            this.MainTable.Controls.Add(this.ExtraInput, 5, 1);
            this.MainTable.Controls.Add(this.QtyInput, 4, 1);
            this.MainTable.Controls.Add(this.EmailInput, 2, 1);
            this.MainTable.Controls.Add(this.LastNameInput, 1, 1);
            this.MainTable.Controls.Add(this.firstName, 0, 0);
            this.MainTable.Controls.Add(this.lastName, 1, 0);
            this.MainTable.Controls.Add(this.Qty, 4, 0);
            this.MainTable.Controls.Add(this.Extra, 5, 0);
            this.MainTable.Controls.Add(this.totalPay, 6, 0);
            this.MainTable.Controls.Add(this.comments, 7, 0);
            this.MainTable.Controls.Add(this.Email, 2, 0);
            this.MainTable.Controls.Add(this.payRate, 3, 0);
            this.MainTable.Controls.Add(this.FirstNameInput, 0, 1);
            this.MainTable.Controls.Add(this.CommentsInput, 7, 1);
            this.MainTable.Controls.Add(this.PayRateInput, 3, 1);
            this.MainTable.Location = new System.Drawing.Point(12, 165);
            this.MainTable.Name = "MainTable";
            this.MainTable.Padding = new System.Windows.Forms.Padding(3);
            this.MainTable.RowCount = 2;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.63636F));
            this.MainTable.Size = new System.Drawing.Size(906, 66);
            this.MainTable.TabIndex = 0;
            this.MainTable.Paint += new System.Windows.Forms.PaintEventHandler(this.MainTable_Paint);
            // 
            // TotalPayInput
            // 
            this.TotalPayInput.Location = new System.Drawing.Point(678, 27);
            this.TotalPayInput.Name = "TotalPayInput";
            this.TotalPayInput.ReadOnly = true;
            this.TotalPayInput.Size = new System.Drawing.Size(100, 20);
            this.TotalPayInput.TabIndex = 0;
            this.TotalPayInput.TabStop = false;
            this.TotalPayInput.TextChanged += new System.EventHandler(this.TotalPayInput_TextChanged);
            // 
            // ExtraInput
            // 
            this.ExtraInput.Location = new System.Drawing.Point(566, 27);
            this.ExtraInput.Name = "ExtraInput";
            this.ExtraInput.Size = new System.Drawing.Size(100, 20);
            this.ExtraInput.TabIndex = 9;
            this.ExtraInput.TextChanged += new System.EventHandler(this.ExtraInput_TextChanged);
            // 
            // QtyInput
            // 
            this.QtyInput.Location = new System.Drawing.Point(454, 27);
            this.QtyInput.Name = "QtyInput";
            this.QtyInput.Size = new System.Drawing.Size(100, 20);
            this.QtyInput.TabIndex = 8;
            this.QtyInput.TextChanged += new System.EventHandler(this.QtyInput_TextChanged);
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(230, 27);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(100, 20);
            this.EmailInput.TabIndex = 6;
            this.EmailInput.TextChanged += new System.EventHandler(this.EmailInput_TextChanged);
            // 
            // LastNameInput
            // 
            this.LastNameInput.Location = new System.Drawing.Point(118, 27);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(100, 20);
            this.LastNameInput.TabIndex = 5;
            this.LastNameInput.TextChanged += new System.EventHandler(this.LastNameInput_TextChanged);
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(6, 3);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(76, 17);
            this.firstName.TabIndex = 1;
            this.firstName.Text = "First Name";
            this.firstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.firstName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(118, 3);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(76, 17);
            this.lastName.TabIndex = 2;
            this.lastName.Text = "Last Name";
            this.lastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lastName.Click += new System.EventHandler(this.label2_Click);
            // 
            // Qty
            // 
            this.Qty.AutoSize = true;
            this.Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty.Location = new System.Drawing.Point(454, 3);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(61, 17);
            this.Qty.TabIndex = 5;
            this.Qty.Text = "Quantity";
            this.Qty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Qty.Click += new System.EventHandler(this.label5_Click);
            // 
            // Extra
            // 
            this.Extra.AutoSize = true;
            this.Extra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Extra.Location = new System.Drawing.Point(566, 3);
            this.Extra.Name = "Extra";
            this.Extra.Size = new System.Drawing.Size(40, 17);
            this.Extra.TabIndex = 6;
            this.Extra.Text = "Extra";
            this.Extra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalPay
            // 
            this.totalPay.AutoSize = true;
            this.totalPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPay.Location = new System.Drawing.Point(678, 3);
            this.totalPay.Name = "totalPay";
            this.totalPay.Size = new System.Drawing.Size(90, 17);
            this.totalPay.TabIndex = 7;
            this.totalPay.Text = "Total Pay ($)";
            this.totalPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comments
            // 
            this.comments.AutoSize = true;
            this.comments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comments.Location = new System.Drawing.Point(790, 3);
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(74, 17);
            this.comments.TabIndex = 8;
            this.comments.Text = "Comments";
            this.comments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.comments.Click += new System.EventHandler(this.label8_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(230, 3);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 17);
            this.Email.TabIndex = 3;
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // payRate
            // 
            this.payRate.AutoSize = true;
            this.payRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payRate.Location = new System.Drawing.Point(342, 3);
            this.payRate.Name = "payRate";
            this.payRate.Size = new System.Drawing.Size(88, 17);
            this.payRate.TabIndex = 4;
            this.payRate.Text = "Pay Rate ($)";
            this.payRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.payRate.Click += new System.EventHandler(this.label4_Click);
            // 
            // FirstNameInput
            // 
            this.FirstNameInput.Location = new System.Drawing.Point(6, 27);
            this.FirstNameInput.Name = "FirstNameInput";
            this.FirstNameInput.Size = new System.Drawing.Size(100, 20);
            this.FirstNameInput.TabIndex = 4;
            this.FirstNameInput.TextChanged += new System.EventHandler(this.FirstNameInput_TextChanged);
            // 
            // CommentsInput
            // 
            this.CommentsInput.Location = new System.Drawing.Point(790, 27);
            this.CommentsInput.Multiline = true;
            this.CommentsInput.Name = "CommentsInput";
            this.CommentsInput.Size = new System.Drawing.Size(100, 20);
            this.CommentsInput.TabIndex = 10;
            this.CommentsInput.TextChanged += new System.EventHandler(this.CommentsInput_TextChanged);
            // 
            // PayRateInput
            // 
            this.PayRateInput.Location = new System.Drawing.Point(342, 27);
            this.PayRateInput.Name = "PayRateInput";
            this.PayRateInput.Size = new System.Drawing.Size(100, 20);
            this.PayRateInput.TabIndex = 7;
            this.PayRateInput.TextChanged += new System.EventHandler(this.PayRateInput_TextChanged);
            // 
            // PayPeriodStartPicker
            // 
            this.PayPeriodStartPicker.Location = new System.Drawing.Point(18, 122);
            this.PayPeriodStartPicker.Name = "PayPeriodStartPicker";
            this.PayPeriodStartPicker.Size = new System.Drawing.Size(200, 20);
            this.PayPeriodStartPicker.TabIndex = 2;
            this.PayPeriodStartPicker.ValueChanged += new System.EventHandler(this.PayPeriodStart_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Pay Period Start";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(242, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Pay Period End";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // PayPeriodEndPicker
            // 
            this.PayPeriodEndPicker.Location = new System.Drawing.Point(245, 122);
            this.PayPeriodEndPicker.Name = "PayPeriodEndPicker";
            this.PayPeriodEndPicker.Size = new System.Drawing.Size(200, 20);
            this.PayPeriodEndPicker.TabIndex = 3;
            this.PayPeriodEndPicker.ValueChanged += new System.EventHandler(this.PayPeriodEnd_ValueChanged);
            // 
            // AddRow
            // 
            this.AddRow.AutoSize = true;
            this.AddRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRow.Location = new System.Drawing.Point(3, 3);
            this.AddRow.Name = "AddRow";
            this.AddRow.Size = new System.Drawing.Size(74, 27);
            this.AddRow.TabIndex = 11;
            this.AddRow.Text = "Add Row";
            this.AddRow.UseVisualStyleBackColor = true;
            this.AddRow.Click += new System.EventHandler(this.AddRow_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Email Sender";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // SendingAddress
            // 
            this.SendingAddress.Location = new System.Drawing.Point(18, 53);
            this.SendingAddress.Name = "SendingAddress";
            this.SendingAddress.Size = new System.Drawing.Size(100, 20);
            this.SendingAddress.TabIndex = 1;
            this.SendingAddress.TextChanged += new System.EventHandler(this.SendingEmail_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.AddRow);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(924, 190);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(84, 41);
            this.flowLayoutPanel1.TabIndex = 18;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // SendEmail
            // 
            this.SendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendEmail.Location = new System.Drawing.Point(3, 3);
            this.SendEmail.Name = "SendEmail";
            this.SendEmail.Size = new System.Drawing.Size(75, 23);
            this.SendEmail.TabIndex = 13;
            this.SendEmail.Text = "Email Payroll";
            this.SendEmail.UseVisualStyleBackColor = true;
            this.SendEmail.Click += new System.EventHandler(this.SendEmail_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.SendEmail);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(924, 267);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(84, 41);
            this.flowLayoutPanel2.TabIndex = 21;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FN_Column,
            this.LN_Column,
            this.Email_Column,
            this.PayRate_Column,
            this.Qty_Column,
            this.Extra_Column,
            this.TotalPay_Column,
            this.Comments_Column});
            this.dataGridView1.Location = new System.Drawing.Point(12, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(906, 277);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.UseWaitCursor = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FN_Column
            // 
            this.FN_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FN_Column.HeaderText = "First Name";
            this.FN_Column.Name = "FN_Column";
            // 
            // LN_Column
            // 
            this.LN_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LN_Column.HeaderText = "Last Name";
            this.LN_Column.Name = "LN_Column";
            // 
            // Email_Column
            // 
            this.Email_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email_Column.HeaderText = "Email";
            this.Email_Column.Name = "Email_Column";
            // 
            // PayRate_Column
            // 
            this.PayRate_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PayRate_Column.HeaderText = "Pay Rate";
            this.PayRate_Column.Name = "PayRate_Column";
            // 
            // Qty_Column
            // 
            this.Qty_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Qty_Column.HeaderText = "Quantity";
            this.Qty_Column.Name = "Qty_Column";
            // 
            // Extra_Column
            // 
            this.Extra_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Extra_Column.HeaderText = "Extra";
            this.Extra_Column.Name = "Extra_Column";
            // 
            // TotalPay_Column
            // 
            this.TotalPay_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalPay_Column.HeaderText = "Total Pay";
            this.TotalPay_Column.Name = "TotalPay_Column";
            this.TotalPay_Column.ReadOnly = true;
            // 
            // Comments_Column
            // 
            this.Comments_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Comments_Column.HeaderText = "Comments";
            this.Comments_Column.Name = "Comments_Column";
            this.Comments_Column.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1047, 606);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.SendingAddress);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PayPeriodEndPicker);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PayPeriodStartPicker);
            this.Controls.Add(this.MainTable);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Payroll";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainTable.ResumeLayout(false);
            this.MainTable.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label payRate;
        private System.Windows.Forms.Label Qty;
        private System.Windows.Forms.Label Extra;
        private System.Windows.Forms.DateTimePicker PayPeriodStartPicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker PayPeriodEndPicker;
        private System.Windows.Forms.Button AddRow;
        private System.Windows.Forms.TextBox ExtraInput;
        private System.Windows.Forms.TextBox QtyInput;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.TextBox LastNameInput;
        private System.Windows.Forms.TextBox FirstNameInput;
        private System.Windows.Forms.TextBox CommentsInput;
        private System.Windows.Forms.TextBox PayRateInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox SendingAddress;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button SendEmail;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TotalPayInput;
        private System.Windows.Forms.Label totalPay;
        private System.Windows.Forms.Label comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn FN_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn LN_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayRate_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extra_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPay_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments_Column;
    }
}

