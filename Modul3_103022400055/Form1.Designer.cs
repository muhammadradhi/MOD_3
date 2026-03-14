namespace Modul3_103022400055
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
            cbDari = new ComboBox();
            cbKe = new ComboBox();
            txtInput = new TextBox();
            txtHasil = new TextBox();
            btnConvert = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // cbDari
            // 
            cbDari.FormattingEnabled = true;
            cbDari.Items.AddRange(new object[] { "Celcius", "Fahrenheit", "Kelvin", "Reamur" });
            cbDari.Location = new Point(105, 116);
            cbDari.Name = "cbDari";
            cbDari.Size = new Size(151, 28);
            cbDari.TabIndex = 0;
            // 
            // cbKe
            // 
            cbKe.FormattingEnabled = true;
            cbKe.Items.AddRange(new object[] { "Celcius", "Fahrenheit", "Kelvin", "Reamur" });
            cbKe.Location = new Point(105, 210);
            cbKe.Name = "cbKe";
            cbKe.Size = new Size(151, 28);
            cbKe.TabIndex = 1;
            cbKe.SelectedIndexChanged += cbKe_SelectedIndexChanged;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(351, 116);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(206, 27);
            txtInput.TabIndex = 2;
            // 
            // txtHasil
            // 
            txtHasil.Location = new Point(351, 211);
            txtHasil.Name = "txtHasil";
            txtHasil.ReadOnly = true;
            txtHasil.Size = new Size(206, 27);
            txtHasil.TabIndex = 3;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(622, 116);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(103, 28);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 93);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 5;
            label1.Text = "Satuan Awal";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 187);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 6;
            label2.Text = "Satuan Akhir";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 188);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 7;
            label3.Text = "Nilai Akhir";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 93);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 8;
            label4.Text = "Nilai Awal";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConvert);
            Controls.Add(txtHasil);
            Controls.Add(txtInput);
            Controls.Add(cbKe);
            Controls.Add(cbDari);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbDari;
        private ComboBox cbKe;
        private TextBox txtInput;
        private TextBox txtHasil;
        private Button btnConvert;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
