
namespace PrimaSGBD
{
    partial class Form2
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
            this.cmbTabel1 = new System.Windows.Forms.ComboBox();
            this.cmbTabel2 = new System.Windows.Forms.ComboBox();
            this.cmbColoana1 = new System.Windows.Forms.ComboBox();
            this.cmbColoana2 = new System.Windows.Forms.ComboBox();
            this.btnAdaugaFK = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbTabel1
            // 
            this.cmbTabel1.FormattingEnabled = true;
            this.cmbTabel1.Location = new System.Drawing.Point(37, 120);
            this.cmbTabel1.Name = "cmbTabel1";
            this.cmbTabel1.Size = new System.Drawing.Size(121, 21);
            this.cmbTabel1.TabIndex = 0;
            this.cmbTabel1.SelectedIndexChanged += new System.EventHandler(this.cmbTabel1_SelectedIndexChanged);
            // 
            // cmbTabel2
            // 
            this.cmbTabel2.FormattingEnabled = true;
            this.cmbTabel2.Location = new System.Drawing.Point(259, 120);
            this.cmbTabel2.Name = "cmbTabel2";
            this.cmbTabel2.Size = new System.Drawing.Size(121, 21);
            this.cmbTabel2.TabIndex = 1;
            this.cmbTabel2.SelectedIndexChanged += new System.EventHandler(this.cmbTabel2_SelectedIndexChanged);
            // 
            // cmbColoana1
            // 
            this.cmbColoana1.FormattingEnabled = true;
            this.cmbColoana1.Location = new System.Drawing.Point(37, 197);
            this.cmbColoana1.Name = "cmbColoana1";
            this.cmbColoana1.Size = new System.Drawing.Size(121, 21);
            this.cmbColoana1.TabIndex = 2;
            // 
            // cmbColoana2
            // 
            this.cmbColoana2.FormattingEnabled = true;
            this.cmbColoana2.Location = new System.Drawing.Point(259, 197);
            this.cmbColoana2.Name = "cmbColoana2";
            this.cmbColoana2.Size = new System.Drawing.Size(121, 21);
            this.cmbColoana2.TabIndex = 3;
            // 
            // btnAdaugaFK
            // 
            this.btnAdaugaFK.Location = new System.Drawing.Point(170, 244);
            this.btnAdaugaFK.Name = "btnAdaugaFK";
            this.btnAdaugaFK.Size = new System.Drawing.Size(82, 23);
            this.btnAdaugaFK.TabIndex = 4;
            this.btnAdaugaFK.Text = "Adauga FK";
            this.btnAdaugaFK.UseVisualStyleBackColor = true;
            this.btnAdaugaFK.Click += new System.EventHandler(this.btnAdaugaFK_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(148, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(114, 24);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Adauga FK";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tabel :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tabel :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Coloana";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Coloana";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 282);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnAdaugaFK);
            this.Controls.Add(this.cmbColoana2);
            this.Controls.Add(this.cmbColoana1);
            this.Controls.Add(this.cmbTabel2);
            this.Controls.Add(this.cmbTabel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTabel1;
        private System.Windows.Forms.ComboBox cmbTabel2;
        private System.Windows.Forms.ComboBox cmbColoana1;
        private System.Windows.Forms.ComboBox cmbColoana2;
        private System.Windows.Forms.Button btnAdaugaFK;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}