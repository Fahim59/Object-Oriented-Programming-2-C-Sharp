namespace Calculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.fn = new System.Windows.Forms.TextBox();
            this.sn = new System.Windows.Forms.TextBox();
            this.plusBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.mulBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.acBtn = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number";
            // 
            // fn
            // 
            this.fn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fn.Location = new System.Drawing.Point(252, 48);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(125, 30);
            this.fn.TabIndex = 3;
            // 
            // sn
            // 
            this.sn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sn.Location = new System.Drawing.Point(252, 88);
            this.sn.Name = "sn";
            this.sn.Size = new System.Drawing.Size(125, 30);
            this.sn.TabIndex = 4;
            // 
            // plusBtn
            // 
            this.plusBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.plusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plusBtn.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBtn.Location = new System.Drawing.Point(81, 176);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(53, 41);
            this.plusBtn.TabIndex = 8;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = false;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.divBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.divBtn.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divBtn.Location = new System.Drawing.Point(288, 176);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(53, 41);
            this.divBtn.TabIndex = 9;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = false;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // mulBtn
            // 
            this.mulBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.mulBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mulBtn.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulBtn.Location = new System.Drawing.Point(219, 177);
            this.mulBtn.Name = "mulBtn";
            this.mulBtn.Size = new System.Drawing.Size(53, 41);
            this.mulBtn.TabIndex = 10;
            this.mulBtn.Text = "*";
            this.mulBtn.UseVisualStyleBackColor = false;
            this.mulBtn.Click += new System.EventHandler(this.mulBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.minusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minusBtn.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusBtn.Location = new System.Drawing.Point(150, 176);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(53, 41);
            this.minusBtn.TabIndex = 11;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = false;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // acBtn
            // 
            this.acBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.acBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.acBtn.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acBtn.Location = new System.Drawing.Point(356, 176);
            this.acBtn.Name = "acBtn";
            this.acBtn.Size = new System.Drawing.Size(53, 41);
            this.acBtn.TabIndex = 12;
            this.acBtn.Text = "AC";
            this.acBtn.UseVisualStyleBackColor = false;
            this.acBtn.Click += new System.EventHandler(this.acBtn_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.SystemColors.Window;
            this.result.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(251, 130);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 22);
            this.result.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(463, 266);
            this.Controls.Add(this.result);
            this.Controls.Add(this.acBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.mulBtn);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.sn);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fn;
        private System.Windows.Forms.TextBox sn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button mulBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button acBtn;
        private System.Windows.Forms.Label result;
        
    }
}

