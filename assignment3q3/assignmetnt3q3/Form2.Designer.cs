namespace assignmetnt3q3
{
    partial class newContact
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
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.informationGrid = new System.Windows.Forms.TableLayoutPanel();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.informationGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameBox
            // 
            this.firstNameBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.firstNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameBox.Location = new System.Drawing.Point(159, 3);
            this.firstNameBox.Multiline = true;
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(123, 25);
            this.firstNameBox.TabIndex = 1;
            // 
            // informationGrid
            // 
            this.informationGrid.ColumnCount = 2;
            this.informationGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.informationGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.informationGrid.Controls.Add(this.lastNameBox, 1, 1);
            this.informationGrid.Controls.Add(this.firstNameBox, 1, 0);
            this.informationGrid.Controls.Add(this.firstNameLabel, 0, 0);
            this.informationGrid.Controls.Add(this.lastNameLabel, 0, 1);
            this.informationGrid.Controls.Add(this.label1, 0, 2);
            this.informationGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informationGrid.Location = new System.Drawing.Point(0, 0);
            this.informationGrid.Name = "informationGrid";
            this.informationGrid.RowCount = 5;
            this.informationGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.informationGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.informationGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.informationGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.informationGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.informationGrid.Size = new System.Drawing.Size(285, 329);
            this.informationGrid.TabIndex = 0;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(3, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(115, 31);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name:";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(3, 31);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(115, 31);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name:";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.lastNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameBox.Location = new System.Drawing.Point(159, 34);
            this.lastNameBox.Multiline = true;
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(123, 25);
            this.lastNameBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 329);
            this.Controls.Add(this.informationGrid);
            this.Name = "newContact";
            this.Text = "Form2";
            this.informationGrid.ResumeLayout(false);
            this.informationGrid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TableLayoutPanel informationGrid;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label label1;
    }
}