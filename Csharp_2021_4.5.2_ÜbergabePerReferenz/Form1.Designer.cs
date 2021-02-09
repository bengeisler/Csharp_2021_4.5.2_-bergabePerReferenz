
namespace Csharp_2021_4._5._2_ÜbergabePerReferenz
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnKopie = new System.Windows.Forms.Button();
			this.btnReferenz = new System.Windows.Forms.Button();
			this.lblAnzeige = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnKopie
			// 
			this.btnKopie.Location = new System.Drawing.Point(183, 8);
			this.btnKopie.Name = "btnKopie";
			this.btnKopie.Size = new System.Drawing.Size(75, 23);
			this.btnKopie.TabIndex = 0;
			this.btnKopie.Text = "Kopie";
			this.btnKopie.UseVisualStyleBackColor = true;
			this.btnKopie.Click += new System.EventHandler(this.btnKopie_Click);
			// 
			// btnReferenz
			// 
			this.btnReferenz.Location = new System.Drawing.Point(183, 37);
			this.btnReferenz.Name = "btnReferenz";
			this.btnReferenz.Size = new System.Drawing.Size(75, 23);
			this.btnReferenz.TabIndex = 1;
			this.btnReferenz.Text = "Referenz";
			this.btnReferenz.UseVisualStyleBackColor = true;
			this.btnReferenz.Click += new System.EventHandler(this.btnReferenz_Click);
			// 
			// lblAnzeige
			// 
			this.lblAnzeige.AutoSize = true;
			this.lblAnzeige.Location = new System.Drawing.Point(13, 13);
			this.lblAnzeige.Name = "lblAnzeige";
			this.lblAnzeige.Size = new System.Drawing.Size(35, 13);
			this.lblAnzeige.TabIndex = 2;
			this.lblAnzeige.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(285, 80);
			this.Controls.Add(this.lblAnzeige);
			this.Controls.Add(this.btnReferenz);
			this.Controls.Add(this.btnKopie);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnKopie;
		private System.Windows.Forms.Button btnReferenz;
		private System.Windows.Forms.Label lblAnzeige;
	}
}

