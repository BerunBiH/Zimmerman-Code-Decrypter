namespace Zimmerman_Code_Encripter_Decripter
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.EncodeBtn = new System.Windows.Forms.Button();
            this.DecodeBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello, and welcome to the Zimmerman Encoder ! ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(57, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(704, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "We can help you decode the Zimmerman Telegraph or encode your own messages with t" +
    "he same code, have fun !";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(57, 115);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(704, 96);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Please put in your message !";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(57, 281);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(704, 157);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // EncodeBtn
            // 
            this.EncodeBtn.Location = new System.Drawing.Point(136, 226);
            this.EncodeBtn.Name = "EncodeBtn";
            this.EncodeBtn.Size = new System.Drawing.Size(191, 23);
            this.EncodeBtn.TabIndex = 5;
            this.EncodeBtn.Text = "Encode ";
            this.EncodeBtn.UseVisualStyleBackColor = true;
            this.EncodeBtn.Click += new System.EventHandler(this.EncodeBtn_Click);
            // 
            // DecodeBtn
            // 
            this.DecodeBtn.Location = new System.Drawing.Point(503, 226);
            this.DecodeBtn.Name = "DecodeBtn";
            this.DecodeBtn.Size = new System.Drawing.Size(191, 23);
            this.DecodeBtn.TabIndex = 6;
            this.DecodeBtn.Text = "Decode";
            this.DecodeBtn.UseVisualStyleBackColor = true;
            this.DecodeBtn.Click += new System.EventHandler(this.DecodeBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Your result :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(96, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(640, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Info : For perfect decoding make sure that there are no breaklines while copying " +
    "the text for example when copying from a pdf copy line for line";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DecodeBtn);
            this.Controls.Add(this.EncodeBtn);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Zimmerman Encoder";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Label label3;
        private RichTextBox richTextBox2;
        private Button EncodeBtn;
        private Button DecodeBtn;
        private Label label4;
        private ErrorProvider errorProvider1;
        private Label label5;
    }
}