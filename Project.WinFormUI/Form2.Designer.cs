namespace Project.WinFormUI
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
			this.lstProducts = new System.Windows.Forms.ListBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnList = new System.Windows.Forms.Button();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.cmbCategories = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// lstProducts
			// 
			this.lstProducts.FormattingEnabled = true;
			this.lstProducts.ItemHeight = 16;
			this.lstProducts.Location = new System.Drawing.Point(247, 24);
			this.lstProducts.Name = "lstProducts";
			this.lstProducts.Size = new System.Drawing.Size(397, 260);
			this.lstProducts.TabIndex = 15;
			this.lstProducts.Click += new System.EventHandler(this.lstProducts_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(27, 282);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(155, 23);
			this.btnUpdate.TabIndex = 14;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(27, 244);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(155, 23);
			this.btnDelete.TabIndex = 13;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(27, 203);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(155, 23);
			this.btnAdd.TabIndex = 12;
			this.btnAdd.Text = "Add Product";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(27, 157);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(155, 23);
			this.btnList.TabIndex = 11;
			this.btnList.Text = "List Products";
			this.btnList.UseVisualStyleBackColor = true;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(27, 78);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(155, 22);
			this.txtPrice.TabIndex = 10;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(27, 24);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(155, 22);
			this.txtName.TabIndex = 9;
			// 
			// cmbCategories
			// 
			this.cmbCategories.FormattingEnabled = true;
			this.cmbCategories.Location = new System.Drawing.Point(27, 116);
			this.cmbCategories.Name = "cmbCategories";
			this.cmbCategories.Size = new System.Drawing.Size(155, 24);
			this.cmbCategories.TabIndex = 17;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cmbCategories);
			this.Controls.Add(this.lstProducts);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.txtName);
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ListBox lstProducts;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.ComboBox cmbCategories;
	}
}