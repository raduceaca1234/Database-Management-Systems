namespace WindowsFormsApp1
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
            this.firstDataGrid = new System.Windows.Forms.DataGridView();
            this.secondDataGrid = new System.Windows.Forms.DataGridView();
            this.firstLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.viewButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.firstDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // firstDataGrid
            // 
            this.firstDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.firstDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.firstDataGrid.Location = new System.Drawing.Point(12, 64);
            this.firstDataGrid.Name = "firstDataGrid";
            this.firstDataGrid.RowTemplate.Height = 45;
            this.firstDataGrid.Size = new System.Drawing.Size(600, 400);
            this.firstDataGrid.TabIndex = 0;
            // 
            // secondDataGrid
            // 
            this.secondDataGrid.AllowUserToAddRows = false;
            this.secondDataGrid.AllowUserToDeleteRows = false;
            this.secondDataGrid.AllowUserToResizeColumns = false;
            this.secondDataGrid.AllowUserToResizeRows = false;
            this.secondDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.secondDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.secondDataGrid.Location = new System.Drawing.Point(785, 64);
            this.secondDataGrid.Name = "secondDataGrid";
            this.secondDataGrid.RowTemplate.Height = 45;
            this.secondDataGrid.Size = new System.Drawing.Size(600, 400);
            this.secondDataGrid.TabIndex = 1;
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Location = new System.Drawing.Point(1073, 28);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(92, 17);
            this.firstLabel.TabIndex = 2;
            this.firstLabel.Text = "Project Table";
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Location = new System.Drawing.Point(200, 28);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(102, 17);
            this.secondLabel.TabIndex = 3;
            this.secondLabel.Text = "Location Table";
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(650, 300);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(100, 37);
            this.viewButton.TabIndex = 4;
            this.viewButton.Text = "View All";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButtonClick);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(650, 200);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 36);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update DB";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 478);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.firstLabel);
            this.Controls.Add(this.secondDataGrid);
            this.Controls.Add(this.firstDataGrid);
            this.Name = "Lab1";
            this.Text = "Lab1";
            ((System.ComponentModel.ISupportInitialize)(this.firstDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView firstDataGrid;
        private System.Windows.Forms.DataGridView secondDataGrid;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button updateButton;
    }
}


