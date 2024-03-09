
namespace Lab3
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.txtSide2 = new System.Windows.Forms.TextBox();
            this.txtSide1 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.rbRightTriangle = new System.Windows.Forms.RadioButton();
            this.rbIsoscelesTriangle = new System.Windows.Forms.RadioButton();
            this.rbEquilateralTriangle = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtAngle);
            this.tabPage1.Controls.Add(this.txtSide2);
            this.tabPage1.Controls.Add(this.txtSide1);
            this.tabPage1.Controls.Add(this.btnCalculate);
            this.tabPage1.Controls.Add(this.rbRightTriangle);
            this.tabPage1.Controls.Add(this.rbIsoscelesTriangle);
            this.tabPage1.Controls.Add(this.rbEquilateralTriangle);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(249, 20);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(100, 20);
            this.txtAngle.TabIndex = 5;
            this.txtAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAngle_KeyPress);
            // 
            // txtSide2
            // 
            this.txtSide2.Location = new System.Drawing.Point(130, 20);
            this.txtSide2.Name = "txtSide2";
            this.txtSide2.Size = new System.Drawing.Size(100, 20);
            this.txtSide2.TabIndex = 4;
            this.txtSide2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSide2_KeyPress);
            // 
            // txtSide1
            // 
            this.txtSide1.Location = new System.Drawing.Point(13, 20);
            this.txtSide1.Name = "txtSide1";
            this.txtSide1.Size = new System.Drawing.Size(100, 20);
            this.txtSide1.TabIndex = 3;
            this.txtSide1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSide1_KeyPress);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(194, 79);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "button1";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // rbRightTriangle
            // 
            this.rbRightTriangle.AutoSize = true;
            this.rbRightTriangle.Checked = true;
            this.rbRightTriangle.Location = new System.Drawing.Point(13, 56);
            this.rbRightTriangle.Name = "rbRightTriangle";
            this.rbRightTriangle.Size = new System.Drawing.Size(141, 17);
            this.rbRightTriangle.TabIndex = 0;
            this.rbRightTriangle.TabStop = true;
            this.rbRightTriangle.Text = "Правильний трикутник";
            this.rbRightTriangle.UseVisualStyleBackColor = true;
            // 
            // rbIsoscelesTriangle
            // 
            this.rbIsoscelesTriangle.AutoSize = true;
            this.rbIsoscelesTriangle.Location = new System.Drawing.Point(13, 79);
            this.rbIsoscelesTriangle.Name = "rbIsoscelesTriangle";
            this.rbIsoscelesTriangle.Size = new System.Drawing.Size(154, 17);
            this.rbIsoscelesTriangle.TabIndex = 1;
            this.rbIsoscelesTriangle.Text = "Рівнобедрений трикутник";
            this.rbIsoscelesTriangle.UseVisualStyleBackColor = true;
            // 
            // rbEquilateralTriangle
            // 
            this.rbEquilateralTriangle.AutoSize = true;
            this.rbEquilateralTriangle.Location = new System.Drawing.Point(13, 102);
            this.rbEquilateralTriangle.Name = "rbEquilateralTriangle";
            this.rbEquilateralTriangle.Size = new System.Drawing.Size(155, 17);
            this.rbEquilateralTriangle.TabIndex = 2;
            this.rbEquilateralTriangle.Text = "Рівносторонній трикутник";
            this.rbEquilateralTriangle.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.TextBox txtSide2;
        private System.Windows.Forms.TextBox txtSide1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton rbRightTriangle;
        private System.Windows.Forms.RadioButton rbIsoscelesTriangle;
        private System.Windows.Forms.RadioButton rbEquilateralTriangle;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

