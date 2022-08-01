
namespace PrimaSGBD
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.tabele = new System.Windows.Forms.ListBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblOp = new System.Windows.Forms.Label();
            this.lblNumeUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.btnAddFK = new System.Windows.Forms.Button();
            this.btnStergeCS = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listfk = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(337, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Conectare";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tabele
            // 
            this.tabele.FormattingEnabled = true;
            this.tabele.Location = new System.Drawing.Point(20, 61);
            this.tabele.Name = "tabele";
            this.tabele.Size = new System.Drawing.Size(96, 277);
            this.tabele.TabIndex = 2;
            this.tabele.SelectedIndexChanged += new System.EventHandler(this.tabele_SelectedIndexChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(17, 15);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(32, 13);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "User ";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(188, 15);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(37, 13);
            this.lblParola.TabIndex = 4;
            this.lblParola.Text = "Parola";
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(231, 8);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(100, 20);
            this.txtParola.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "TABELE";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(337, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblOp.Location = new System.Drawing.Point(106, 2);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(47, 18);
            this.lblOp.TabIndex = 12;
            this.lblOp.Text = "lblOp";
            // 
            // lblNumeUser
            // 
            this.lblNumeUser.AutoSize = true;
            this.lblNumeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeUser.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNumeUser.Location = new System.Drawing.Point(52, 12);
            this.lblNumeUser.Name = "lblNumeUser";
            this.lblNumeUser.Size = new System.Drawing.Size(51, 16);
            this.lblNumeUser.TabIndex = 13;
            this.lblNumeUser.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 2);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nume Tabel:";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(5, 23);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(266, 154);
            this.dgv.TabIndex = 19;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(277, 23);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv1.Size = new System.Drawing.Size(242, 154);
            this.dgv1.TabIndex = 26;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(520, 23);
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv2.Size = new System.Drawing.Size(245, 154);
            this.dgv2.TabIndex = 27;
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(55, 8);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(121, 21);
            this.cmbUser.TabIndex = 25;
            // 
            // dgv3
            // 
            this.dgv3.AllowUserToAddRows = false;
            this.dgv3.AllowUserToDeleteRows = false;
            this.dgv3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Location = new System.Drawing.Point(5, 216);
            this.dgv3.Name = "dgv3";
            this.dgv3.ReadOnly = true;
            this.dgv3.Size = new System.Drawing.Size(443, 154);
            this.dgv3.TabIndex = 28;
            // 
            // btnAddFK
            // 
            this.btnAddFK.Location = new System.Drawing.Point(272, 183);
            this.btnAddFK.Name = "btnAddFK";
            this.btnAddFK.Size = new System.Drawing.Size(99, 23);
            this.btnAddFK.TabIndex = 29;
            this.btnAddFK.Text = "Adauga CS";
            this.btnAddFK.UseVisualStyleBackColor = true;
            this.btnAddFK.Click += new System.EventHandler(this.btnAddFK_Click);
            // 
            // btnStergeCS
            // 
            this.btnStergeCS.Location = new System.Drawing.Point(401, 183);
            this.btnStergeCS.Name = "btnStergeCS";
            this.btnStergeCS.Size = new System.Drawing.Size(113, 23);
            this.btnStergeCS.TabIndex = 31;
            this.btnStergeCS.Text = "Sterge Constrangere";
            this.btnStergeCS.UseVisualStyleBackColor = true;
            this.btnStergeCS.Click += new System.EventHandler(this.btnStergeCS_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(430, 327);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(10, 43);
            this.listBox1.TabIndex = 32;
            // 
            // listfk
            // 
            this.listfk.FormattingEnabled = true;
            this.listfk.Location = new System.Drawing.Point(385, 313);
            this.listfk.Name = "listfk";
            this.listfk.Size = new System.Drawing.Size(10, 43);
            this.listfk.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv3);
            this.panel1.Controls.Add(this.listBox6);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.listBox5);
            this.panel1.Controls.Add(this.listBox4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.listBox3);
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnStergeCS);
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Controls.Add(this.btnAddFK);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.dgv2);
            this.panel1.Controls.Add(this.listfk);
            this.panel1.Controls.Add(this.dgv1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblOp);
            this.panel1.Location = new System.Drawing.Point(122, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 499);
            this.panel1.TabIndex = 34;
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.Location = new System.Drawing.Point(124, 327);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(45, 30);
            this.listBox6.TabIndex = 42;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 251);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 41;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(128, 338);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(51, 17);
            this.listBox5.TabIndex = 40;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(128, 226);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(42, 30);
            this.listBox4.TabIndex = 39;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 242);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 38;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(323, 219);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(45, 17);
            this.listBox3.TabIndex = 37;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(232, 325);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(41, 30);
            this.listBox2.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(517, 3);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Referinte :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 2);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Chei Straine :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 424);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.tabele);
            this.Controls.Add(this.lblNumeUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnLogOut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox tabele;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label lblNumeUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.Button btnAddFK;
        private System.Windows.Forms.Button btnStergeCS;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listfk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox listBox6;
    }
}

