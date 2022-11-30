namespace Lab7
{
    partial class Form_Borrow
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_borrow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(105, 227);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(274, 33);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(274, 33);
            this.comboBox1.TabIndex = 4;
            // 
            // button_borrow
            // 
            this.button_borrow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_borrow.Location = new System.Drawing.Point(132, 322);
            this.button_borrow.Name = "button_borrow";
            this.button_borrow.Size = new System.Drawing.Size(207, 65);
            this.button_borrow.TabIndex = 3;
            this.button_borrow.Text = "Wypożycz";
            this.button_borrow.UseVisualStyleBackColor = true;
            this.button_borrow.Click += new System.EventHandler(this.button_borrow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(116, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "wybierz wypożyczającego";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(146, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "wybierz pozycję";
            // 
            // Form_Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_borrow);
            this.Name = "Form_Borrow";
            this.Text = "Form_Borrow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button_borrow;
        private Label label1;
        private Label label2;
    }
}