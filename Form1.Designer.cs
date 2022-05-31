
namespace RadioButton_and_CheckBoxes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tv21_cb = new System.Windows.Forms.CheckBox();
            this.tv14_cb = new System.Windows.Forms.CheckBox();
            this.tv12_cb = new System.Windows.Forms.CheckBox();
            this.five_rb = new System.Windows.Forms.RadioButton();
            this.ten_rb = new System.Windows.Forms.RadioButton();
            this.fifteen_rb = new System.Windows.Forms.RadioButton();
            this.compute_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subtotal_txtbox = new System.Windows.Forms.TextBox();
            this.discount_txtbox = new System.Windows.Forms.TextBox();
            this.netamount_txtbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.tv12_cb);
            this.groupBox1.Controls.Add(this.tv14_cb);
            this.groupBox1.Controls.Add(this.tv21_cb);
            this.groupBox1.Location = new System.Drawing.Point(22, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Items Here:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.fifteen_rb);
            this.groupBox2.Controls.Add(this.ten_rb);
            this.groupBox2.Controls.Add(this.five_rb);
            this.groupBox2.Location = new System.Drawing.Point(299, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 169);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // tv21_cb
            // 
            this.tv21_cb.AutoSize = true;
            this.tv21_cb.Location = new System.Drawing.Point(27, 38);
            this.tv21_cb.Name = "tv21_cb";
            this.tv21_cb.Size = new System.Drawing.Size(139, 17);
            this.tv21_cb.TabIndex = 0;
            this.tv21_cb.Text = "TV 21\" (Php 10,000.00)";
            this.tv21_cb.UseVisualStyleBackColor = true;
            // 
            // tv14_cb
            // 
            this.tv14_cb.AutoSize = true;
            this.tv14_cb.Location = new System.Drawing.Point(27, 82);
            this.tv14_cb.Name = "tv14_cb";
            this.tv14_cb.Size = new System.Drawing.Size(133, 17);
            this.tv14_cb.TabIndex = 1;
            this.tv14_cb.Text = "TV 14\" (Php 7,500.00)";
            this.tv14_cb.UseVisualStyleBackColor = true;
            // 
            // tv12_cb
            // 
            this.tv12_cb.AutoSize = true;
            this.tv12_cb.Location = new System.Drawing.Point(27, 124);
            this.tv12_cb.Name = "tv12_cb";
            this.tv12_cb.Size = new System.Drawing.Size(133, 17);
            this.tv12_cb.TabIndex = 2;
            this.tv12_cb.Text = "TV 12\" (Php 5,000.00)";
            this.tv12_cb.UseVisualStyleBackColor = true;
            // 
            // five_rb
            // 
            this.five_rb.AutoSize = true;
            this.five_rb.Location = new System.Drawing.Point(16, 38);
            this.five_rb.Name = "five_rb";
            this.five_rb.Size = new System.Drawing.Size(39, 17);
            this.five_rb.TabIndex = 0;
            this.five_rb.TabStop = true;
            this.five_rb.Text = "5%";
            this.five_rb.UseVisualStyleBackColor = true;
            // 
            // ten_rb
            // 
            this.ten_rb.AutoSize = true;
            this.ten_rb.Location = new System.Drawing.Point(16, 81);
            this.ten_rb.Name = "ten_rb";
            this.ten_rb.Size = new System.Drawing.Size(45, 17);
            this.ten_rb.TabIndex = 1;
            this.ten_rb.TabStop = true;
            this.ten_rb.Text = "10%";
            this.ten_rb.UseVisualStyleBackColor = true;
            // 
            // fifteen_rb
            // 
            this.fifteen_rb.AutoSize = true;
            this.fifteen_rb.Location = new System.Drawing.Point(16, 123);
            this.fifteen_rb.Name = "fifteen_rb";
            this.fifteen_rb.Size = new System.Drawing.Size(45, 17);
            this.fifteen_rb.TabIndex = 2;
            this.fifteen_rb.TabStop = true;
            this.fifteen_rb.Text = "15%";
            this.fifteen_rb.UseVisualStyleBackColor = true;
            // 
            // compute_btn
            // 
            this.compute_btn.BackColor = System.Drawing.Color.White;
            this.compute_btn.Location = new System.Drawing.Point(22, 225);
            this.compute_btn.Name = "compute_btn";
            this.compute_btn.Size = new System.Drawing.Size(136, 23);
            this.compute_btn.TabIndex = 2;
            this.compute_btn.Text = "Compute";
            this.compute_btn.UseVisualStyleBackColor = false;
            this.compute_btn.Click += new System.EventHandler(this.compute_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.White;
            this.clear_btn.Location = new System.Drawing.Point(22, 267);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(136, 23);
            this.clear_btn.TabIndex = 3;
            this.clear_btn.Text = "Clear All";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(22, 308);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(136, 23);
            this.close_btn.TabIndex = 4;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sub-total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Discount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Net Amount";
            // 
            // subtotal_txtbox
            // 
            this.subtotal_txtbox.Location = new System.Drawing.Point(300, 227);
            this.subtotal_txtbox.Name = "subtotal_txtbox";
            this.subtotal_txtbox.Size = new System.Drawing.Size(138, 20);
            this.subtotal_txtbox.TabIndex = 8;
            // 
            // discount_txtbox
            // 
            this.discount_txtbox.Location = new System.Drawing.Point(299, 269);
            this.discount_txtbox.Name = "discount_txtbox";
            this.discount_txtbox.Size = new System.Drawing.Size(138, 20);
            this.discount_txtbox.TabIndex = 9;
            // 
            // netamount_txtbox
            // 
            this.netamount_txtbox.Location = new System.Drawing.Point(300, 310);
            this.netamount_txtbox.Name = "netamount_txtbox";
            this.netamount_txtbox.Size = new System.Drawing.Size(138, 20);
            this.netamount_txtbox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(464, 369);
            this.Controls.Add(this.netamount_txtbox);
            this.Controls.Add(this.discount_txtbox);
            this.Controls.Add(this.subtotal_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.compute_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox tv12_cb;
        private System.Windows.Forms.CheckBox tv14_cb;
        private System.Windows.Forms.CheckBox tv21_cb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton fifteen_rb;
        private System.Windows.Forms.RadioButton ten_rb;
        private System.Windows.Forms.RadioButton five_rb;
        private System.Windows.Forms.Button compute_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subtotal_txtbox;
        private System.Windows.Forms.TextBox discount_txtbox;
        private System.Windows.Forms.TextBox netamount_txtbox;
    }
}

