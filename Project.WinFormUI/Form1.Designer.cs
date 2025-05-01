namespace Project.WinFormUI
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
			this.components = new System.ComponentModel.Container();
			this.txtName = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.btnList = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.lstCategories = new System.Windows.Forms.ListBox();
			this.btnForm2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(50, 22);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(155, 22);
			this.txtName.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(50, 76);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(155, 22);
			this.txtDescription.TabIndex = 2;
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(50, 126);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(155, 23);
			this.btnList.TabIndex = 3;
			this.btnList.Text = "List Categories";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(50, 172);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(155, 23);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add Category";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(50, 213);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(155, 23);
			this.btnDelete.TabIndex = 5;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(50, 251);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(155, 23);
			this.btnUpdate.TabIndex = 6;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// lstCategories
			// 
			this.lstCategories.FormattingEnabled = true;
			this.lstCategories.ItemHeight = 16;
			this.lstCategories.Location = new System.Drawing.Point(270, 22);
			this.lstCategories.Name = "lstCategories";
			this.lstCategories.Size = new System.Drawing.Size(397, 260);
			this.lstCategories.TabIndex = 7;
			this.lstCategories.Click += new System.EventHandler(this.lstCategories_Click);
			// 
			// btnForm2
			// 
			this.btnForm2.Location = new System.Drawing.Point(570, 307);
			this.btnForm2.Name = "btnForm2";
			this.btnForm2.Size = new System.Drawing.Size(97, 31);
			this.btnForm2.TabIndex = 8;
			this.btnForm2.Text = "Form2";
			this.btnForm2.UseVisualStyleBackColor = true;
			this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnForm2);
			this.Controls.Add(this.lstCategories);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtName);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.ListBox lstCategories;
		private System.Windows.Forms.Button btnForm2;
	}
}

