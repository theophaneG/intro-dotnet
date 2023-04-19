namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            listBox1 = new System.Windows.Forms.ListBox();
            personRepositoryBindingSource1 = new System.Windows.Forms.BindingSource(components);
            personRepositoryBindingSource = new System.Windows.Forms.BindingSource(components);
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)personRepositoryBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personRepositoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new System.Drawing.Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(275, 429);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // personRepositoryBindingSource1
            // 
            personRepositoryBindingSource1.DataSource = typeof(DataProvider.PersonRepository);
            // 
            // personRepositoryBindingSource
            // 
            personRepositoryBindingSource.DataSource = typeof(DataProvider.PersonRepository);
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(367, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(421, 31);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(367, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 25);
            label1.TabIndex = 3;
            label1.Text = "nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(367, 86);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 25);
            label2.TabIndex = 5;
            label2.Text = "prenom";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(367, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(421, 31);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyPress += textBox1_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(367, 159);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(41, 25);
            label3.TabIndex = 7;
            label3.Text = "age";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(367, 187);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(421, 31);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.KeyPress += textBox1_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)personRepositoryBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)personRepositoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource personRepositoryBindingSource;
        private System.Windows.Forms.BindingSource personRepositoryBindingSource1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
    }
}
