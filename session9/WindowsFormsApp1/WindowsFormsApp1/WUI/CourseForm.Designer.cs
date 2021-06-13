
namespace WindowsFormsApp1.WUI {
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlSave = new System.Windows.Forms.Button();
            this.ctrlExit = new System.Windows.Forms.Button();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlCategory = new DevExpress.XtraEditors.TextEdit();
            this.ctrlHours = new DevExpress.XtraEditors.TextEdit();
            this.ctrlSubject = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlHours.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSubject.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(273, 13);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(196, 33);
            this.labelControl4.TabIndex = 22;
            this.labelControl4.Text = "Add New Course";
            // 
            // ctrlSave
            // 
            this.ctrlSave.Location = new System.Drawing.Point(556, 399);
            this.ctrlSave.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlSave.Name = "ctrlSave";
            this.ctrlSave.Size = new System.Drawing.Size(95, 39);
            this.ctrlSave.TabIndex = 21;
            this.ctrlSave.Text = "Save";
            this.ctrlSave.UseVisualStyleBackColor = true;
            this.ctrlSave.Click += new System.EventHandler(this.ctrlSave_Click);
            // 
            // ctrlExit
            // 
            this.ctrlExit.Location = new System.Drawing.Point(681, 399);
            this.ctrlExit.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlExit.Name = "ctrlExit";
            this.ctrlExit.Size = new System.Drawing.Size(91, 39);
            this.ctrlExit.TabIndex = 20;
            this.ctrlExit.Text = "Exit";
            this.ctrlExit.UseVisualStyleBackColor = true;
            this.ctrlExit.Click += new System.EventHandler(this.ctrlExit_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(34, 231);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 16);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Category :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 163);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 16);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Hours :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(34, 89);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 16);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Subject :";
            // 
            // ctrlCategory
            // 
            this.ctrlCategory.Location = new System.Drawing.Point(184, 225);
            this.ctrlCategory.Name = "ctrlCategory";
            this.ctrlCategory.Size = new System.Drawing.Size(125, 22);
            this.ctrlCategory.TabIndex = 16;
            // 
            // ctrlHours
            // 
            this.ctrlHours.Location = new System.Drawing.Point(184, 157);
            this.ctrlHours.Name = "ctrlHours";
            this.ctrlHours.Size = new System.Drawing.Size(125, 22);
            this.ctrlHours.TabIndex = 15;
            // 
            // ctrlSubject
            // 
            this.ctrlSubject.Location = new System.Drawing.Point(184, 86);
            this.ctrlSubject.Name = "ctrlSubject";
            this.ctrlSubject.Size = new System.Drawing.Size(125, 22);
            this.ctrlSubject.TabIndex = 14;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.ctrlSave);
            this.Controls.Add(this.ctrlExit);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ctrlCategory);
            this.Controls.Add(this.ctrlHours);
            this.Controls.Add(this.ctrlSubject);
            this.Name = "CourseForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlHours.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSubject.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Button ctrlSave;
        private System.Windows.Forms.Button ctrlExit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit ctrlCategory;
        private DevExpress.XtraEditors.TextEdit ctrlHours;
        private DevExpress.XtraEditors.TextEdit ctrlSubject;
    }
}