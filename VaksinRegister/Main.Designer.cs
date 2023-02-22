
namespace VaksinRegister
{
    partial class Main
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btnsebelum = new System.Windows.Forms.Button();
            this.Btnsetelah = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Btnsetelah, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btnsebelum, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(559, 119);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Btnsebelum
            // 
            this.Btnsebelum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btnsebelum.Location = new System.Drawing.Point(3, 3);
            this.Btnsebelum.Name = "Btnsebelum";
            this.Btnsebelum.Size = new System.Drawing.Size(273, 113);
            this.Btnsebelum.TabIndex = 1;
            this.Btnsebelum.Text = "SEBELUM VAKSIN";
            this.Btnsebelum.UseVisualStyleBackColor = true;
            this.Btnsebelum.Click += new System.EventHandler(this.Btnsebelum_Click);
            // 
            // Btnsetelah
            // 
            this.Btnsetelah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btnsetelah.Location = new System.Drawing.Point(282, 3);
            this.Btnsetelah.Name = "Btnsetelah";
            this.Btnsetelah.Size = new System.Drawing.Size(274, 113);
            this.Btnsetelah.TabIndex = 2;
            this.Btnsetelah.Text = "SETELAH VAKSIN";
            this.Btnsetelah.UseVisualStyleBackColor = true;
            this.Btnsetelah.Click += new System.EventHandler(this.Btnsetelah_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 119);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Btnsetelah;
        private System.Windows.Forms.Button Btnsebelum;
    }
}