namespace _23_11_22_Predavanje
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculateSqrt = new System.Windows.Forms.Button();
            this.lblShowReturn1 = new System.Windows.Forms.Label();
            this.txtNumberInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblShowReturn2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.btnInputSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesi broj:";
            // 
            // btnCalculateSqrt
            // 
            this.btnCalculateSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCalculateSqrt.Location = new System.Drawing.Point(224, 24);
            this.btnCalculateSqrt.Name = "btnCalculateSqrt";
            this.btnCalculateSqrt.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateSqrt.TabIndex = 1;
            this.btnCalculateSqrt.Text = "Računaj";
            this.btnCalculateSqrt.UseVisualStyleBackColor = true;
            this.btnCalculateSqrt.Click += new System.EventHandler(this.btnCalculateSqrt_Click);
            // 
            // lblShowReturn1
            // 
            this.lblShowReturn1.AutoSize = true;
            this.lblShowReturn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblShowReturn1.Location = new System.Drawing.Point(25, 94);
            this.lblShowReturn1.Name = "lblShowReturn1";
            this.lblShowReturn1.Size = new System.Drawing.Size(0, 15);
            this.lblShowReturn1.TabIndex = 2;
            // 
            // txtNumberInput
            // 
            this.txtNumberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNumberInput.Location = new System.Drawing.Point(106, 24);
            this.txtNumberInput.Name = "txtNumberInput";
            this.txtNumberInput.Size = new System.Drawing.Size(100, 21);
            this.txtNumberInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(485, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Naslov:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(494, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Autor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(487, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cijena:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(477, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Stranica:";
            // 
            // lblShowReturn2
            // 
            this.lblShowReturn2.AutoSize = true;
            this.lblShowReturn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblShowReturn2.Location = new System.Drawing.Point(485, 163);
            this.lblShowReturn2.Name = "lblShowReturn2";
            this.lblShowReturn2.Size = new System.Drawing.Size(0, 15);
            this.lblShowReturn2.TabIndex = 8;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(546, 43);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 9;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(546, 69);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(546, 93);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 11;
            // 
            // txtPages
            // 
            this.txtPages.Location = new System.Drawing.Point(546, 117);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(100, 20);
            this.txtPages.TabIndex = 12;
            // 
            // btnInputSave
            // 
            this.btnInputSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnInputSave.Location = new System.Drawing.Point(683, 73);
            this.btnInputSave.Name = "btnInputSave";
            this.btnInputSave.Size = new System.Drawing.Size(70, 36);
            this.btnInputSave.TabIndex = 13;
            this.btnInputSave.Text = "Unesi";
            this.btnInputSave.UseVisualStyleBackColor = true;
            this.btnInputSave.Click += new System.EventHandler(this.btnInputSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 450);
            this.Controls.Add(this.btnInputSave);
            this.Controls.Add(this.txtPages);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblShowReturn2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumberInput);
            this.Controls.Add(this.lblShowReturn1);
            this.Controls.Add(this.btnCalculateSqrt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculateSqrt;
        private System.Windows.Forms.Label lblShowReturn1;
        private System.Windows.Forms.TextBox txtNumberInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblShowReturn2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.Button btnInputSave;
    }
}

