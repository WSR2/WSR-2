
namespace wsr2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Кегли = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Кегли)).BeginInit();
            this.SuspendLayout();
            // 
            // Кегли
            // 
            this.Кегли.Image = ((System.Drawing.Image)(resources.GetObject("Кегли.Image")));
            this.Кегли.Location = new System.Drawing.Point(12, 12);
            this.Кегли.Name = "Кегли";
            this.Кегли.Size = new System.Drawing.Size(496, 497);
            this.Кегли.TabIndex = 0;
            this.Кегли.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(525, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(351, 128);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Наименование товара \nОписание товара\nПроизводитель:\nЦена:";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(954, 27);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(100, 96);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "Наличие на складе";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 569);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Кегли);
            this.Name = "Form2";
            this.Text = "Список товаров";
            ((System.ComponentModel.ISupportInitialize)(this.Кегли)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Кегли;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}