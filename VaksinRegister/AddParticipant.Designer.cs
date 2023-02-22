
namespace VaksinRegister
{
    partial class AddParticipant
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_nik = new System.Windows.Forms.TextBox();
            this.TabNonkar = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnSavekar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnPeserta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_peserta_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_peserta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LbNourut = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.TabNonkar.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 37);
            this.panel1.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "ABSENSI VAKSINASI SBI";
            // 
            // Txt_nik
            // 
            this.Txt_nik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_nik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nik.Location = new System.Drawing.Point(110, 28);
            this.Txt_nik.Multiline = true;
            this.Txt_nik.Name = "Txt_nik";
            this.Txt_nik.Size = new System.Drawing.Size(121, 30);
            this.Txt_nik.TabIndex = 0;
            this.Txt_nik.TextChanged += new System.EventHandler(this.Txt_nik_TextChanged);
            // 
            // TabNonkar
            // 
            this.TabNonkar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabNonkar.Controls.Add(this.tabPage1);
            this.TabNonkar.Controls.Add(this.tabPage2);
            this.TabNonkar.Location = new System.Drawing.Point(17, 57);
            this.TabNonkar.Name = "TabNonkar";
            this.TabNonkar.SelectedIndex = 0;
            this.TabNonkar.Size = new System.Drawing.Size(599, 223);
            this.TabNonkar.TabIndex = 59;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnSavekar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Txt_name);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Txt_nik);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(591, 197);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "KARYAWAN";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnSavekar
            // 
            this.BtnSavekar.Location = new System.Drawing.Point(178, 112);
            this.BtnSavekar.Name = "BtnSavekar";
            this.BtnSavekar.Size = new System.Drawing.Size(145, 23);
            this.BtnSavekar.TabIndex = 4;
            this.BtnSavekar.Text = "SIMPAN";
            this.BtnSavekar.UseVisualStyleBackColor = true;
            this.BtnSavekar.Click += new System.EventHandler(this.BtnSavekar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NAMA";
            // 
            // Txt_name
            // 
            this.Txt_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_name.Location = new System.Drawing.Point(110, 76);
            this.Txt_name.Multiline = true;
            this.Txt_name.Name = "Txt_name";
            this.Txt_name.Size = new System.Drawing.Size(213, 30);
            this.Txt_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NIK";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LbNourut);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.BtnPeserta);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Txt_peserta_name);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.Txt_peserta);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(591, 197);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "NON KARYAWAN";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnPeserta
            // 
            this.BtnPeserta.Location = new System.Drawing.Point(176, 111);
            this.BtnPeserta.Name = "BtnPeserta";
            this.BtnPeserta.Size = new System.Drawing.Size(145, 23);
            this.BtnPeserta.TabIndex = 9;
            this.BtnPeserta.Text = "SIMPAN";
            this.BtnPeserta.UseVisualStyleBackColor = true;
            this.BtnPeserta.Click += new System.EventHandler(this.BtnPeserta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "NAMA";
            // 
            // Txt_peserta_name
            // 
            this.Txt_peserta_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_peserta_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_peserta_name.Location = new System.Drawing.Point(108, 75);
            this.Txt_peserta_name.Multiline = true;
            this.Txt_peserta_name.Name = "Txt_peserta_name";
            this.Txt_peserta_name.Size = new System.Drawing.Size(213, 30);
            this.Txt_peserta_name.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "NO PESERTA";
            // 
            // Txt_peserta
            // 
            this.Txt_peserta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_peserta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_peserta.Location = new System.Drawing.Point(108, 28);
            this.Txt_peserta.Multiline = true;
            this.Txt_peserta.Name = "Txt_peserta";
            this.Txt_peserta.Size = new System.Drawing.Size(121, 30);
            this.Txt_peserta.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Peserta Terakhir";
            // 
            // LbNourut
            // 
            this.LbNourut.AutoSize = true;
            this.LbNourut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNourut.Location = new System.Drawing.Point(336, 38);
            this.LbNourut.Name = "LbNourut";
            this.LbNourut.Size = new System.Drawing.Size(0, 13);
            this.LbNourut.TabIndex = 11;
            // 
            // AddParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(628, 292);
            this.Controls.Add(this.TabNonkar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddParticipant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddParticipant";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabNonkar.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_nik;
        private System.Windows.Forms.TabControl TabNonkar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnSavekar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPeserta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_peserta_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_peserta;
        private System.Windows.Forms.Label LbNourut;
        private System.Windows.Forms.Label label6;
    }
}