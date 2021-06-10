
namespace WindowsFormsApp1 {
    partial class CourseForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.tbProfessors = new System.Windows.Forms.TextBox();
            this.tbEcts = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tbDiscription = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(547, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(640, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subject :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Professors :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "ECTS :";
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(306, 81);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(144, 22);
            this.tbSubject.TabIndex = 5;
            // 
            // tbProfessors
            // 
            this.tbProfessors.Location = new System.Drawing.Point(306, 136);
            this.tbProfessors.Name = "tbProfessors";
            this.tbProfessors.Size = new System.Drawing.Size(144, 22);
            this.tbProfessors.TabIndex = 6;
            // 
            // tbEcts
            // 
            this.tbEcts.Location = new System.Drawing.Point(306, 203);
            this.tbEcts.Name = "tbEcts";
            this.tbEcts.Size = new System.Drawing.Size(144, 22);
            this.tbEcts.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(306, 277);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(144, 84);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // tbDiscription
            // 
            this.tbDiscription.AutoSize = true;
            this.tbDiscription.Location = new System.Drawing.Point(156, 277);
            this.tbDiscription.Name = "tbDiscription";
            this.tbDiscription.Size = new System.Drawing.Size(82, 17);
            this.tbDiscription.TabIndex = 9;
            this.tbDiscription.Text = "Discription :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(273, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Add New Course";
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 434);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDiscription);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tbEcts);
            this.Controls.Add(this.tbProfessors);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "CourseForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.TextBox tbProfessors;
        private System.Windows.Forms.TextBox tbEcts;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label tbDiscription;
        private System.Windows.Forms.Label label4;
    }
}