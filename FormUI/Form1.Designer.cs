
namespace FormUI
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAdd = new System.Windows.Forms.Label();
            this.tbxfirstName = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTelephone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAdress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(328, 119);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(52, 63);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(64, 15);
            this.lblAdd.TabIndex = 1;
            this.lblAdd.Text = "First Name";
            // 
            // tbxfirstName
            // 
            this.tbxfirstName.Location = new System.Drawing.Point(140, 60);
            this.tbxfirstName.Name = "tbxfirstName";
            this.tbxfirstName.Size = new System.Drawing.Size(100, 23);
            this.tbxfirstName.TabIndex = 2;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(138, 97);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(102, 23);
            this.tbxLastName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Surname";
            // 
            // tbxTelephone
            // 
            this.tbxTelephone.Location = new System.Drawing.Point(138, 138);
            this.tbxTelephone.Name = "tbxTelephone";
            this.tbxTelephone.Size = new System.Drawing.Size(102, 23);
            this.tbxTelephone.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Telephone";
            // 
            // tbxAdress
            // 
            this.tbxAdress.Location = new System.Drawing.Point(138, 179);
            this.tbxAdress.Name = "tbxAdress";
            this.tbxAdress.Size = new System.Drawing.Size(102, 23);
            this.tbxAdress.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.tbxAdress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxTelephone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxfirstName);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.TextBox tbxfirstName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTelephone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxAdress;
    }
}

