namespace ReSize
{
	partial class ReSize
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReSize));
			this.tbWidth = new System.Windows.Forms.TextBox();
			this.tbHeight = new System.Windows.Forms.TextBox();
			this.lbSizes = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbClientArea = new System.Windows.Forms.CheckBox();
			this.lblOrgWinSize = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblOrgCliSize = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tbClassName = new System.Windows.Forms.TextBox();
			this.tbWndText = new System.Windows.Forms.TextBox();
			this.cbNoTopLvl = new System.Windows.Forms.CheckBox();
			this.cbNoResize = new System.Windows.Forms.CheckBox();
			this.btnSet = new System.Windows.Forms.Button();
			this.cbWndEnable = new System.Windows.Forms.CheckBox();
			this.cbWndEnabler = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// tbWidth
			// 
			this.tbWidth.Location = new System.Drawing.Point(180, 10);
			this.tbWidth.Name = "tbWidth";
			this.tbWidth.Size = new System.Drawing.Size(108, 20);
			this.tbWidth.TabIndex = 0;
			this.tbWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWidth_KeyPress);
			// 
			// tbHeight
			// 
			this.tbHeight.Location = new System.Drawing.Point(180, 36);
			this.tbHeight.Name = "tbHeight";
			this.tbHeight.Size = new System.Drawing.Size(108, 20);
			this.tbHeight.TabIndex = 1;
			this.tbHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHeight_KeyPress);
			// 
			// lbSizes
			// 
			this.lbSizes.FormattingEnabled = true;
			this.lbSizes.Items.AddRange(new object[] {
            "320x200",
            "640x480",
            "720x576",
            "800x600",
            "1024x768",
            "1280x720",
            "1280x960",
            "1280x1024",
            "1366x1024",
            "1400x900",
            "1600x1024 \t",
            "1680x1050",
            "1600x1200",
            "1920x1080",
            "1920x1200",
            "1920x1440"});
			this.lbSizes.Location = new System.Drawing.Point(12, 13);
			this.lbSizes.Name = "lbSizes";
			this.lbSizes.Size = new System.Drawing.Size(121, 212);
			this.lbSizes.TabIndex = 3;
			this.lbSizes.SelectedIndexChanged += new System.EventHandler(this.lbSizes_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(136, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Width:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(136, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Height:";
			// 
			// cbClientArea
			// 
			this.cbClientArea.AutoSize = true;
			this.cbClientArea.Checked = true;
			this.cbClientArea.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbClientArea.Location = new System.Drawing.Point(140, 80);
			this.cbClientArea.Name = "cbClientArea";
			this.cbClientArea.Size = new System.Drawing.Size(76, 17);
			this.cbClientArea.TabIndex = 6;
			this.cbClientArea.Text = "Client area";
			this.cbClientArea.UseVisualStyleBackColor = true;
			// 
			// lblOrgWinSize
			// 
			this.lblOrgWinSize.AutoSize = true;
			this.lblOrgWinSize.Location = new System.Drawing.Point(195, 201);
			this.lblOrgWinSize.Name = "lblOrgWinSize";
			this.lblOrgWinSize.Size = new System.Drawing.Size(0, 13);
			this.lblOrgWinSize.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(136, 201);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "WndSize:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(136, 214);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "ClientSize:";
			// 
			// lblOrgCliSize
			// 
			this.lblOrgCliSize.AutoSize = true;
			this.lblOrgCliSize.Location = new System.Drawing.Point(195, 214);
			this.lblOrgCliSize.Name = "lblOrgCliSize";
			this.lblOrgCliSize.Size = new System.Drawing.Size(0, 13);
			this.lblOrgCliSize.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 239);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "ClassName:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(9, 265);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(54, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "WndText:";
			// 
			// tbClassName
			// 
			this.tbClassName.Location = new System.Drawing.Point(81, 236);
			this.tbClassName.Name = "tbClassName";
			this.tbClassName.ReadOnly = true;
			this.tbClassName.Size = new System.Drawing.Size(207, 20);
			this.tbClassName.TabIndex = 15;
			// 
			// tbWndText
			// 
			this.tbWndText.Location = new System.Drawing.Point(81, 262);
			this.tbWndText.Name = "tbWndText";
			this.tbWndText.ReadOnly = true;
			this.tbWndText.Size = new System.Drawing.Size(207, 20);
			this.tbWndText.TabIndex = 16;
			// 
			// cbNoTopLvl
			// 
			this.cbNoTopLvl.AutoSize = true;
			this.cbNoTopLvl.Location = new System.Drawing.Point(140, 103);
			this.cbNoTopLvl.Name = "cbNoTopLvl";
			this.cbNoTopLvl.Size = new System.Drawing.Size(162, 17);
			this.cbNoTopLvl.TabIndex = 17;
			this.cbNoTopLvl.Text = "Don\'t resolve TopLevel Wnd";
			this.cbNoTopLvl.UseVisualStyleBackColor = true;
			this.cbNoTopLvl.CheckedChanged += new System.EventHandler(this.cbNoTopLvl_CheckedChanged);
			// 
			// cbNoResize
			// 
			this.cbNoResize.AutoSize = true;
			this.cbNoResize.Location = new System.Drawing.Point(140, 57);
			this.cbNoResize.Name = "cbNoResize";
			this.cbNoResize.Size = new System.Drawing.Size(81, 17);
			this.cbNoResize.TabIndex = 18;
			this.cbNoResize.Text = "Don\'t resize";
			this.cbNoResize.UseVisualStyleBackColor = true;
			// 
			// btnSet
			// 
			this.btnSet.BackgroundImage = global::ReSize.Properties.Resources.NoMove2D;
			this.btnSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSet.Location = new System.Drawing.Point(198, 154);
			this.btnSet.Name = "btnSet";
			this.btnSet.Size = new System.Drawing.Size(46, 44);
			this.btnSet.TabIndex = 2;
			this.btnSet.UseVisualStyleBackColor = true;
			this.btnSet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSet_MouseDown);
			this.btnSet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSet_MouseMove_1);
			this.btnSet.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSet_MouseUp);
			// 
			// cbWndEnable
			// 
			this.cbWndEnable.AutoSize = true;
			this.cbWndEnable.Checked = true;
			this.cbWndEnable.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbWndEnable.Location = new System.Drawing.Point(243, 128);
			this.cbWndEnable.Name = "cbWndEnable";
			this.cbWndEnable.Size = new System.Drawing.Size(15, 14);
			this.cbWndEnable.TabIndex = 20;
			this.cbWndEnable.UseVisualStyleBackColor = true;
			// 
			// cbWndEnabler
			// 
			this.cbWndEnabler.AutoSize = true;
			this.cbWndEnabler.Location = new System.Drawing.Point(140, 127);
			this.cbWndEnabler.Name = "cbWndEnabler";
			this.cbWndEnabler.Size = new System.Drawing.Size(97, 17);
			this.cbWndEnabler.TabIndex = 19;
			this.cbWndEnabler.Text = "Enable control:";
			this.cbWndEnabler.UseVisualStyleBackColor = true;
			// 
			// ReSize
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 294);
			this.Controls.Add(this.cbWndEnable);
			this.Controls.Add(this.cbWndEnabler);
			this.Controls.Add(this.cbNoResize);
			this.Controls.Add(this.cbNoTopLvl);
			this.Controls.Add(this.tbWndText);
			this.Controls.Add(this.tbClassName);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblOrgCliSize);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblOrgWinSize);
			this.Controls.Add(this.cbClientArea);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbSizes);
			this.Controls.Add(this.btnSet);
			this.Controls.Add(this.tbHeight);
			this.Controls.Add(this.tbWidth);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ReSize";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ReSize";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbWidth;
		private System.Windows.Forms.TextBox tbHeight;
		private System.Windows.Forms.Button btnSet;
		private System.Windows.Forms.ListBox lbSizes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox cbClientArea;
		private System.Windows.Forms.Label lblOrgWinSize;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblOrgCliSize;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbClassName;
		private System.Windows.Forms.TextBox tbWndText;
		private System.Windows.Forms.CheckBox cbNoTopLvl;
		private System.Windows.Forms.CheckBox cbNoResize;
		private System.Windows.Forms.CheckBox cbWndEnable;
		private System.Windows.Forms.CheckBox cbWndEnabler;
	}
}

