namespace cipherDecoder
{
    partial class frmCodeTranslator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSecretWord = new Label();
            lblInputText = new Label();
            lblOutputText = new Label();
            txtSecretWord = new TextBox();
            txtInputText = new TextBox();
            txtOutputText = new TextBox();
            btnTranslateText = new Button();
            btnClear = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblSecretWord
            // 
            lblSecretWord.AutoSize = true;
            lblSecretWord.Location = new Point(37, 50);
            lblSecretWord.Name = "lblSecretWord";
            lblSecretWord.Size = new Size(122, 15);
            lblSecretWord.TabIndex = 0;
            lblSecretWord.Text = "Cipher \"Secret\" Word:";
            // 
            // lblInputText
            // 
            lblInputText.AutoSize = true;
            lblInputText.Location = new Point(97, 98);
            lblInputText.Name = "lblInputText";
            lblInputText.Size = new Size(62, 15);
            lblInputText.TabIndex = 1;
            lblInputText.Text = "Input Text:";
            // 
            // lblOutputText
            // 
            lblOutputText.AutoSize = true;
            lblOutputText.Location = new Point(87, 169);
            lblOutputText.Name = "lblOutputText";
            lblOutputText.Size = new Size(72, 15);
            lblOutputText.TabIndex = 2;
            lblOutputText.Text = "Output Text:";
            // 
            // txtSecretWord
            // 
            txtSecretWord.CharacterCasing = CharacterCasing.Upper;
            txtSecretWord.Location = new Point(165, 47);
            txtSecretWord.Name = "txtSecretWord";
            txtSecretWord.Size = new Size(189, 23);
            txtSecretWord.TabIndex = 3;
            // 
            // txtInputText
            // 
            txtInputText.CharacterCasing = CharacterCasing.Upper;
            txtInputText.Location = new Point(161, 95);
            txtInputText.Multiline = true;
            txtInputText.Name = "txtInputText";
            txtInputText.Size = new Size(522, 49);
            txtInputText.TabIndex = 4;
            // 
            // txtOutputText
            // 
            txtOutputText.CharacterCasing = CharacterCasing.Upper;
            txtOutputText.Location = new Point(161, 166);
            txtOutputText.Multiline = true;
            txtOutputText.Name = "txtOutputText";
            txtOutputText.ReadOnly = true;
            txtOutputText.Size = new Size(522, 50);
            txtOutputText.TabIndex = 5;
            // 
            // btnTranslateText
            // 
            btnTranslateText.Location = new Point(37, 267);
            btnTranslateText.Name = "btnTranslateText";
            btnTranslateText.Size = new Size(106, 23);
            btnTranslateText.TabIndex = 6;
            btnTranslateText.Text = "Translate Text";
            btnTranslateText.UseVisualStyleBackColor = true;
            btnTranslateText.Click += btnTranslateText_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(161, 267);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(608, 267);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCodeTranslator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 307);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(btnTranslateText);
            Controls.Add(txtOutputText);
            Controls.Add(txtInputText);
            Controls.Add(txtSecretWord);
            Controls.Add(lblOutputText);
            Controls.Add(lblInputText);
            Controls.Add(lblSecretWord);
            Name = "frmCodeTranslator";
            Text = "Code Translator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSecretWord;
        private Label lblInputText;
        private Label lblOutputText;
        private TextBox txtSecretWord;
        private TextBox txtInputText;
        private TextBox txtOutputText;
        private Button btnTranslateText;
        private Button btnClear;
        private Button btnClose;
    }
}
