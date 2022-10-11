namespace LabWork_4_1
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
            this.btnyes = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnext = new System.Windows.Forms.Button();
            this.btnmdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnyes
            // 
            this.btnyes.Location = new System.Drawing.Point(12, 34);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(94, 29);
            this.btnyes.TabIndex = 0;
            this.btnyes.Text = "Ok";
            this.btnyes.UseVisualStyleBackColor = true;
            this.btnyes.Click += new System.EventHandler(this.btnyes_Click);
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(126, 34);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(94, 29);
            this.btnno.TabIndex = 1;
            this.btnno.Text = "O!";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            this.btnno.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnno_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "How are you?";
            // 
            // btnext
            // 
            this.btnext.Location = new System.Drawing.Point(240, 34);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(94, 29);
            this.btnext.TabIndex = 3;
            this.btnext.Text = "Extended";
            this.btnext.UseVisualStyleBackColor = true;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // btnmdi
            // 
            this.btnmdi.Location = new System.Drawing.Point(349, 34);
            this.btnmdi.Name = "btnmdi";
            this.btnmdi.Size = new System.Drawing.Size(94, 29);
            this.btnmdi.TabIndex = 4;
            this.btnmdi.Text = "MDIp";
            this.btnmdi.UseVisualStyleBackColor = true;
            this.btnmdi.Click += new System.EventHandler(this.btnmdi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 149);
            this.Controls.Add(this.btnmdi);
            this.Controls.Add(this.btnext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnyes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Important query";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnyes;
        private Button btnno;
        private Label label1;
        private Button btnext;
        private Button btnmdi;
    }
}