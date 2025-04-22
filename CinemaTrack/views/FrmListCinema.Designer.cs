namespace CinemaTrack.views
{
    partial class FrmListCinema
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
            this.lblSortBy = new System.Windows.Forms.Label();
            this.cmbSortOptions = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.dgvCinemas = new System.Windows.Forms.DataGridView();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinemas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBy.Location = new System.Drawing.Point(147, 21);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(51, 13);
            this.lblSortBy.TabIndex = 0;
            this.lblSortBy.Text = "Sort by:";
            // 
            // cmbSortOptions
            // 
            this.cmbSortOptions.FormattingEnabled = true;
            this.cmbSortOptions.Items.AddRange(new object[] {
            "Area",
            "Name",
            "Address",
            "Manager",
            "RoomCount"});
            this.cmbSortOptions.Location = new System.Drawing.Point(219, 18);
            this.cmbSortOptions.Name = "cmbSortOptions";
            this.cmbSortOptions.Size = new System.Drawing.Size(106, 21);
            this.cmbSortOptions.TabIndex = 1;
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Microsoft YaHei Light", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(12, 12);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(118, 33);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // dgvCinemas
            // 
            this.dgvCinemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCinemas.Location = new System.Drawing.Point(12, 68);
            this.dgvCinemas.Name = "dgvCinemas";
            this.dgvCinemas.RowHeadersWidth = 45;
            this.dgvCinemas.Size = new System.Drawing.Size(313, 239);
            this.dgvCinemas.TabIndex = 5;
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Font = new System.Drawing.Font("Microsoft YaHei Light", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelected.Location = new System.Drawing.Point(12, 325);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(313, 33);
            this.btnDeleteSelected.TabIndex = 6;
            this.btnDeleteSelected.Text = "Delete Selected Cinema";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(98, 373);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(131, 13);
            this.lblMessage.TabIndex = 12;
            this.lblMessage.Text = "To show errors or success";
            // 
            // FrmListCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 407);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.dgvCinemas);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.cmbSortOptions);
            this.Controls.Add(this.lblSortBy);
            this.Name = "FrmListCinema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListCinema";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinemas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.ComboBox cmbSortOptions;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.DataGridView dgvCinemas;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Label lblMessage;
    }
}