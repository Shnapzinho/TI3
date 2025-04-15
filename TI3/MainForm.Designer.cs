namespace TI3
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			lblPrimeP = new Label();
			txtPrimeP = new TextBox();
			lblPrimeStatus = new Label();
			btnFindPrimitiveRoots = new Button();
			lstPrimitiveRoots = new ListBox();
			lblRoots = new Label();
			lblSelectedG = new Label();
			txtSelectedG = new TextBox();
			lblPrivateKeyX = new Label();
			txtPrivateKeyX = new TextBox();
			btnGeneratePublicKey = new Button();
			lblPublicKey = new Label();
			btnSelectInputFile = new Button();
			lblInputFile = new Label();
			rbEncrypt = new RadioButton();
			rbDecrypt = new RadioButton();
			lblKValue = new Label();
			txtKValue = new TextBox();
			btnProcessFile = new Button();
			txtInput = new TextBox();
			txtOutput = new TextBox();
			btnSaveOutput = new Button();
			lblInputData = new Label();
			lblOutputData = new Label();
			splitContainer1 = new SplitContainer();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			SuspendLayout();
			// 
			// lblPrimeP
			// 
			lblPrimeP.AutoSize = true;
			lblPrimeP.Location = new Point(20, 20);
			lblPrimeP.Name = "lblPrimeP";
			lblPrimeP.Size = new Size(155, 25);
			lblPrimeP.TabIndex = 0;
			lblPrimeP.Text = "Простое число p:";
			// 
			// txtPrimeP
			// 
			txtPrimeP.Location = new Point(20, 50);
			txtPrimeP.Name = "txtPrimeP";
			txtPrimeP.Size = new Size(208, 31);
			txtPrimeP.TabIndex = 1;
			txtPrimeP.TextChanged += txtPrimeP_TextChanged;
			// 
			// lblPrimeStatus
			// 
			lblPrimeStatus.AutoSize = true;
			lblPrimeStatus.Location = new Point(262, 56);
			lblPrimeStatus.Name = "lblPrimeStatus";
			lblPrimeStatus.Size = new Size(0, 25);
			lblPrimeStatus.TabIndex = 3;
			// 
			// btnFindPrimitiveRoots
			// 
			btnFindPrimitiveRoots.Enabled = false;
			btnFindPrimitiveRoots.Location = new Point(20, 100);
			btnFindPrimitiveRoots.Name = "btnFindPrimitiveRoots";
			btnFindPrimitiveRoots.Size = new Size(280, 40);
			btnFindPrimitiveRoots.TabIndex = 4;
			btnFindPrimitiveRoots.Text = "Найти первообразные корни";
			btnFindPrimitiveRoots.UseVisualStyleBackColor = true;
			btnFindPrimitiveRoots.Click += btnFindPrimitiveRoots_Click;
			// 
			// lstPrimitiveRoots
			// 
			lstPrimitiveRoots.FormattingEnabled = true;
			lstPrimitiveRoots.ItemHeight = 25;
			lstPrimitiveRoots.Location = new Point(320, 100);
			lstPrimitiveRoots.Name = "lstPrimitiveRoots";
			lstPrimitiveRoots.Size = new Size(150, 254);
			lstPrimitiveRoots.TabIndex = 5;
			lstPrimitiveRoots.SelectedIndexChanged += lstPrimitiveRoots_SelectedIndexChanged;
			// 
			// lblRoots
			// 
			lblRoots.AutoSize = true;
			lblRoots.Location = new Point(20, 159);
			lblRoots.Name = "lblRoots";
			lblRoots.Size = new Size(0, 25);
			lblRoots.TabIndex = 6;
			// 
			// lblSelectedG
			// 
			lblSelectedG.AutoSize = true;
			lblSelectedG.Location = new Point(3, 100);
			lblSelectedG.Name = "lblSelectedG";
			lblSelectedG.Size = new Size(202, 25);
			lblSelectedG.TabIndex = 7;
			lblSelectedG.Text = "Выбранный корень (g):";
			// 
			// txtSelectedG
			// 
			txtSelectedG.Location = new Point(3, 130);
			txtSelectedG.Name = "txtSelectedG";
			txtSelectedG.ReadOnly = true;
			txtSelectedG.Size = new Size(202, 31);
			txtSelectedG.TabIndex = 8;
			// 
			// lblPrivateKeyX
			// 
			lblPrivateKeyX.AutoSize = true;
			lblPrivateKeyX.Location = new Point(252, 100);
			lblPrivateKeyX.Name = "lblPrivateKeyX";
			lblPrivateKeyX.Size = new Size(169, 25);
			lblPrivateKeyX.TabIndex = 9;
			lblPrivateKeyX.Text = "Закрытый ключ (x):";
			// 
			// txtPrivateKeyX
			// 
			txtPrivateKeyX.Location = new Point(252, 130);
			txtPrivateKeyX.Name = "txtPrivateKeyX";
			txtPrivateKeyX.Size = new Size(169, 31);
			txtPrivateKeyX.TabIndex = 10;
			// 
			// btnGeneratePublicKey
			// 
			btnGeneratePublicKey.Location = new Point(80, 186);
			btnGeneratePublicKey.Name = "btnGeneratePublicKey";
			btnGeneratePublicKey.Size = new Size(280, 40);
			btnGeneratePublicKey.TabIndex = 11;
			btnGeneratePublicKey.Text = "Сгенерировать открытый ключ";
			btnGeneratePublicKey.UseVisualStyleBackColor = true;
			btnGeneratePublicKey.Click += btnGeneratePublicKey_Click;
			// 
			// lblPublicKey
			// 
			lblPublicKey.AutoSize = true;
			lblPublicKey.Location = new Point(54, 247);
			lblPublicKey.Name = "lblPublicKey";
			lblPublicKey.Size = new Size(0, 25);
			lblPublicKey.TabIndex = 12;
			// 
			// btnSelectInputFile
			// 
			btnSelectInputFile.Location = new Point(20, 232);
			btnSelectInputFile.Name = "btnSelectInputFile";
			btnSelectInputFile.Size = new Size(193, 40);
			btnSelectInputFile.TabIndex = 14;
			btnSelectInputFile.Text = "Выбрать файл";
			btnSelectInputFile.UseVisualStyleBackColor = true;
			btnSelectInputFile.Click += btnSelectInputFile_Click;
			// 
			// lblInputFile
			// 
			lblInputFile.AutoSize = true;
			lblInputFile.Location = new Point(680, 30);
			lblInputFile.Name = "lblInputFile";
			lblInputFile.Size = new Size(0, 25);
			lblInputFile.TabIndex = 15;
			// 
			// rbEncrypt
			// 
			rbEncrypt.AutoSize = true;
			rbEncrypt.Checked = true;
			rbEncrypt.Location = new Point(262, 382);
			rbEncrypt.Name = "rbEncrypt";
			rbEncrypt.Size = new Size(133, 29);
			rbEncrypt.TabIndex = 16;
			rbEncrypt.TabStop = true;
			rbEncrypt.Text = "Шифровать";
			rbEncrypt.UseVisualStyleBackColor = true;
			rbEncrypt.CheckedChanged += rbEncrypt_CheckedChanged;
			// 
			// rbDecrypt
			// 
			rbDecrypt.AutoSize = true;
			rbDecrypt.Location = new Point(415, 382);
			rbDecrypt.Name = "rbDecrypt";
			rbDecrypt.Size = new Size(151, 29);
			rbDecrypt.TabIndex = 17;
			rbDecrypt.Text = "Дешифровать";
			rbDecrypt.UseVisualStyleBackColor = true;
			rbDecrypt.CheckedChanged += rbDecrypt_CheckedChanged;
			// 
			// lblKValue
			// 
			lblKValue.AutoSize = true;
			lblKValue.Location = new Point(20, 382);
			lblKValue.Name = "lblKValue";
			lblKValue.Size = new Size(25, 25);
			lblKValue.TabIndex = 18;
			lblKValue.Text = "k:";
			// 
			// txtKValue
			// 
			txtKValue.Location = new Point(59, 378);
			txtKValue.Name = "txtKValue";
			txtKValue.Size = new Size(100, 31);
			txtKValue.TabIndex = 19;
			// 
			// btnProcessFile
			// 
			btnProcessFile.Location = new Point(96, 25);
			btnProcessFile.Name = "btnProcessFile";
			btnProcessFile.Size = new Size(150, 35);
			btnProcessFile.TabIndex = 20;
			btnProcessFile.Text = "Выполнить";
			btnProcessFile.UseVisualStyleBackColor = true;
			btnProcessFile.Click += btnProcessFile_Click;
			// 
			// txtInput
			// 
			txtInput.Location = new Point(20, 455);
			txtInput.Multiline = true;
			txtInput.Name = "txtInput";
			txtInput.ScrollBars = ScrollBars.Vertical;
			txtInput.Size = new Size(943, 150);
			txtInput.TabIndex = 22;
			// 
			// txtOutput
			// 
			txtOutput.Location = new Point(20, 636);
			txtOutput.Multiline = true;
			txtOutput.Name = "txtOutput";
			txtOutput.ScrollBars = ScrollBars.Vertical;
			txtOutput.Size = new Size(943, 150);
			txtOutput.TabIndex = 24;
			// 
			// btnSaveOutput
			// 
			btnSaveOutput.Location = new Point(20, 291);
			btnSaveOutput.Name = "btnSaveOutput";
			btnSaveOutput.Size = new Size(193, 40);
			btnSaveOutput.TabIndex = 25;
			btnSaveOutput.Text = "Сохранить в файл";
			btnSaveOutput.UseVisualStyleBackColor = true;
			btnSaveOutput.Click += btnSaveOutput_Click;
			// 
			// lblInputData
			// 
			lblInputData.AutoSize = true;
			lblInputData.Location = new Point(20, 427);
			lblInputData.Name = "lblInputData";
			lblInputData.Size = new Size(153, 25);
			lblInputData.TabIndex = 21;
			lblInputData.Text = "Входные данные:";
			// 
			// lblOutputData
			// 
			lblOutputData.AutoSize = true;
			lblOutputData.Location = new Point(20, 608);
			lblOutputData.Name = "lblOutputData";
			lblOutputData.Size = new Size(166, 25);
			lblOutputData.TabIndex = 23;
			lblOutputData.Text = "Выходные данные:";
			// 
			// splitContainer1
			// 
			splitContainer1.Location = new Point(500, 0);
			splitContainer1.Name = "splitContainer1";
			splitContainer1.Orientation = Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(lblSelectedG);
			splitContainer1.Panel1.Controls.Add(txtSelectedG);
			splitContainer1.Panel1.Controls.Add(lblPrivateKeyX);
			splitContainer1.Panel1.Controls.Add(txtPrivateKeyX);
			splitContainer1.Panel1.Controls.Add(btnGeneratePublicKey);
			splitContainer1.Panel1.Controls.Add(lblPublicKey);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(btnProcessFile);
			splitContainer1.Size = new Size(500, 748);
			splitContainer1.SplitterDistance = 350;
			splitContainer1.TabIndex = 13;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1000, 798);
			Controls.Add(rbDecrypt);
			Controls.Add(btnSaveOutput);
			Controls.Add(txtInput);
			Controls.Add(lblInputData);
			Controls.Add(lblOutputData);
			Controls.Add(txtOutput);
			Controls.Add(rbEncrypt);
			Controls.Add(btnSelectInputFile);
			Controls.Add(txtKValue);
			Controls.Add(lblKValue);
			Controls.Add(lblInputFile);
			Controls.Add(splitContainer1);
			Controls.Add(lblRoots);
			Controls.Add(lstPrimitiveRoots);
			Controls.Add(btnFindPrimitiveRoots);
			Controls.Add(lblPrimeStatus);
			Controls.Add(txtPrimeP);
			Controls.Add(lblPrimeP);
			Name = "MainForm";
			Text = "TI3";
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel1.PerformLayout();
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label lblPrimeP;
		private System.Windows.Forms.TextBox txtPrimeP;
		private System.Windows.Forms.Label lblPrimeStatus;
		private System.Windows.Forms.Button btnFindPrimitiveRoots;
		private System.Windows.Forms.ListBox lstPrimitiveRoots;
		private System.Windows.Forms.Label lblRoots;
		private System.Windows.Forms.Label lblSelectedG;
		private System.Windows.Forms.TextBox txtSelectedG;
		private System.Windows.Forms.Label lblPrivateKeyX;
		private System.Windows.Forms.TextBox txtPrivateKeyX;
		private System.Windows.Forms.Button btnGeneratePublicKey;
		private System.Windows.Forms.Label lblPublicKey;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button btnSelectInputFile;
		private System.Windows.Forms.Label lblInputFile;
		private System.Windows.Forms.RadioButton rbEncrypt;
		private System.Windows.Forms.RadioButton rbDecrypt;
		private System.Windows.Forms.Label lblKValue;
		private System.Windows.Forms.TextBox txtKValue;
		private System.Windows.Forms.Button btnProcessFile;
		private System.Windows.Forms.Label lblInputData;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Label lblOutputData;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.Button btnSaveOutput;
	}
}