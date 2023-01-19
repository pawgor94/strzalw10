namespace Giveaway
{
	partial class Settingsy
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(12, 22);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(179, 253);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Przydzial strzałów";
			// 
			// panel3
			// 
			this.panel3.Location = new System.Drawing.Point(209, 22);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(179, 253);
			this.panel3.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(213, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Bonus dla subków";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(141, 334);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(486, 50);
			this.label3.TabIndex = 3;
			this.label3.Text = "WORK IN PROGRESS";
			// 
			// Settingsy
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Name = "Settingsy";
			this.Text = "Ustawienia";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Panel panel3;
		private Label label2;
		private Label label3;
	}
}