namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvOrders = new DataGridView();
            lblCompanyName = new Label();
            lblCompanyAddress = new Label();
            btnReset = new Button();
            lblError = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(107, 32);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(194, 23);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(323, 32);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(107, 141);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.Size = new Size(533, 283);
            dgvOrders.TabIndex = 2;
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Font = new Font("Segoe UI", 12F);
            lblCompanyName.Location = new Point(107, 79);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(0, 21);
            lblCompanyName.TabIndex = 3;
            // 
            // lblCompanyAddress
            // 
            lblCompanyAddress.AutoSize = true;
            lblCompanyAddress.Font = new Font("Segoe UI", 12F);
            lblCompanyAddress.Location = new Point(385, 79);
            lblCompanyAddress.Name = "lblCompanyAddress";
            lblCompanyAddress.Size = new Size(0, 21);
            lblCompanyAddress.TabIndex = 4;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(404, 32);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 5;
            btnReset.Text = "Refrescar";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 12F);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(107, 117);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 21);
            lblError.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblError);
            Controls.Add(btnReset);
            Controls.Add(lblCompanyAddress);
            Controls.Add(lblCompanyName);
            Controls.Add(dgvOrders);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvOrders;
        private Label lblCompanyName;
        private Label lblCompanyAddress;
        private Button btnReset;
        private Label lblError;
    }
}
