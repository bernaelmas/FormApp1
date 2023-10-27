namespace FormApp1
{
    partial class Form1
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
            addButton = new Button();
            deleteButton = new Button();
            textBox = new TextBox();
            Notlarım = new ListBox();
            notGir = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.BackColor = Color.Gainsboro;
            addButton.FlatStyle = FlatStyle.Popup;
            addButton.Font = new Font("Bell MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = SystemColors.ActiveCaptionText;
            addButton.Location = new Point(53, 315);
            addButton.Name = "addButton";
            addButton.Size = new Size(87, 39);
            addButton.TabIndex = 0;
            addButton.Text = "EKLE";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Gainsboro;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Font = new Font("Bell MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.ForeColor = SystemColors.ActiveCaptionText;
            deleteButton.Location = new Point(146, 315);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(87, 39);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "SİL";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // textBox
            // 
            textBox.BackColor = Color.PeachPuff;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox.Location = new Point(42, 43);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(205, 255);
            textBox.TabIndex = 3;
            // 
            // Notlarım
            // 
            Notlarım.BackColor = Color.PeachPuff;
            Notlarım.BorderStyle = BorderStyle.FixedSingle;
            Notlarım.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Notlarım.FormattingEnabled = true;
            Notlarım.ItemHeight = 23;
            Notlarım.Location = new Point(312, 43);
            Notlarım.MultiColumn = true;
            Notlarım.Name = "Notlarım";
            Notlarım.Size = new Size(205, 255);
            Notlarım.TabIndex = 4;
            // 
            // notGir
            // 
            notGir.AutoSize = true;
            notGir.Font = new Font("Bell MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            notGir.Location = new Point(42, 20);
            notGir.Name = "notGir";
            notGir.Size = new Size(70, 21);
            notGir.TabIndex = 5;
            notGir.Text = "Not Gir";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bell MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(312, 19);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 6;
            label1.Text = "Not Listesi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(559, 366);
            Controls.Add(label1);
            Controls.Add(notGir);
            Controls.Add(Notlarım);
            Controls.Add(textBox);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Name = "Form1";
            Text = "NOT LİSTESİ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private Button deleteButton;
        private TextBox textBox;
        private ListBox Notlarım;
        private Label notGir;
        private Label label1;
    }
}