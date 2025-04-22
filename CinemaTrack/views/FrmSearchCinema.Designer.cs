namespace CinemaTrack.views
{
    partial class FrmSearchCinema
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSearchOptions = new System.Windows.Forms.ComboBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei Light", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(206, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 47);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search Cinemas";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbSearchOptions
            // 
            this.cmbSearchOptions.FormattingEnabled = true;
            this.cmbSearchOptions.Items.AddRange(new object[] {
            "Name",
            "Address",
            "Manager"});
            this.cmbSearchOptions.Location = new System.Drawing.Point(94, 12);
            this.cmbSearchOptions.Name = "cmbSearchOptions";
            this.cmbSearchOptions.Size = new System.Drawing.Size(106, 21);
            this.cmbSearchOptions.TabIndex = 6;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.Location = new System.Drawing.Point(11, 15);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(68, 13);
            this.lblSearchBy.TabIndex = 5;
            this.lblSearchBy.Text = "Search by:";
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(14, 39);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(186, 20);
            this.txtSearchValue.TabIndex = 8;
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Location = new System.Drawing.Point(12, 78);
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.RowHeadersWidth = 45;
            this.dgvSearchResults.Size = new System.Drawing.Size(313, 239);
            this.dgvSearchResults.TabIndex = 9;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(91, 331);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(131, 13);
            this.lblMessage.TabIndex = 12;
            this.lblMessage.Text = "To show errors or success";
            // 
            // FrmSearchCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 362);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.dgvSearchResults);
            this.Controls.Add(this.txtSearchValue);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbSearchOptions);
            this.Controls.Add(this.lblSearchBy);
            this.Name = "FrmSearchCinema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSearchCinema";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSearchOptions;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.DataGridView dgvSearchResults;
        private System.Windows.Forms.Label lblMessage;
    }
}