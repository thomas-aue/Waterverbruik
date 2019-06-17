namespace Waterverbruik
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
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxVerbruik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxTotaal = new System.Windows.Forms.TextBox();
            this.labelUitleg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verbruik in m3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Totaalbedrag";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Bereken";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBoxVerbruik
            // 
            this.textBoxVerbruik.Location = new System.Drawing.Point(129, 80);
            this.textBoxVerbruik.Name = "textBoxVerbruik";
            this.textBoxVerbruik.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxVerbruik.Size = new System.Drawing.Size(100, 20);
            this.textBoxVerbruik.TabIndex = 4;
            this.textBoxVerbruik.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxVerbruik.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.textBoxVerbruik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tarief";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.comboBox1.Location = new System.Drawing.Point(129, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // textBoxTotaal
            // 
            this.textBoxTotaal.Location = new System.Drawing.Point(129, 170);
            this.textBoxTotaal.Name = "textBoxTotaal";
            this.textBoxTotaal.ReadOnly = true;
            this.textBoxTotaal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotaal.TabIndex = 7;
            this.textBoxTotaal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelUitleg
            // 
            this.labelUitleg.AutoSize = true;
            this.labelUitleg.Location = new System.Drawing.Point(126, 144);
            this.labelUitleg.Name = "labelUitleg";
            this.labelUitleg.Size = new System.Drawing.Size(0, 13);
            this.labelUitleg.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 238);
            this.Controls.Add(this.labelUitleg);
            this.Controls.Add(this.textBoxTotaal);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxVerbruik);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Waterverbruik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxVerbruik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxTotaal;
        private System.Windows.Forms.Label labelUitleg;
    }
}

