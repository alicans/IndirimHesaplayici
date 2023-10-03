namespace IndirimHesaplayici
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
            grbIndirimler = new GroupBox();
            chkIndirim5 = new CheckBox();
            chkIndirim10 = new CheckBox();
            chkIndirim15 = new CheckBox();
            grbHesaplama = new GroupBox();
            lblTutar = new Label();
            txbTutar = new TextBox();
            btnHesapla = new Button();
            grbIndirimler.SuspendLayout();
            grbHesaplama.SuspendLayout();
            SuspendLayout();
            // 
            // grbIndirimler
            // 
            grbIndirimler.Controls.Add(chkIndirim15);
            grbIndirimler.Controls.Add(chkIndirim10);
            grbIndirimler.Controls.Add(chkIndirim5);
            grbIndirimler.Location = new Point(12, 12);
            grbIndirimler.Name = "grbIndirimler";
            grbIndirimler.Size = new Size(202, 189);
            grbIndirimler.TabIndex = 0;
            grbIndirimler.TabStop = false;
            grbIndirimler.Text = "İndirimler";
            // 
            // chkIndirim5
            // 
            chkIndirim5.AutoSize = true;
            chkIndirim5.Location = new Point(24, 41);
            chkIndirim5.Name = "chkIndirim5";
            chkIndirim5.Size = new Size(117, 19);
            chkIndirim5.TabIndex = 0;
            chkIndirim5.Text = "%5 Nakit İndirimi";
            chkIndirim5.UseVisualStyleBackColor = true;
            // 
            // chkIndirim10
            // 
            chkIndirim10.AutoSize = true;
            chkIndirim10.Location = new Point(24, 85);
            chkIndirim10.Name = "chkIndirim10";
            chkIndirim10.Size = new Size(151, 19);
            chkIndirim10.TabIndex = 1;
            chkIndirim10.Text = "%10 Kampanya İndirimi";
            chkIndirim10.UseVisualStyleBackColor = true;
            // 
            // chkIndirim15
            // 
            chkIndirim15.AutoSize = true;
            chkIndirim15.Location = new Point(24, 127);
            chkIndirim15.Name = "chkIndirim15";
            chkIndirim15.Size = new Size(115, 19);
            chkIndirim15.TabIndex = 2;
            chkIndirim15.Text = "%15 Özel İndirim";
            chkIndirim15.UseVisualStyleBackColor = true;
            // 
            // grbHesaplama
            // 
            grbHesaplama.Controls.Add(btnHesapla);
            grbHesaplama.Controls.Add(txbTutar);
            grbHesaplama.Controls.Add(lblTutar);
            grbHesaplama.Location = new Point(235, 12);
            grbHesaplama.Name = "grbHesaplama";
            grbHesaplama.Size = new Size(202, 189);
            grbHesaplama.TabIndex = 1;
            grbHesaplama.TabStop = false;
            grbHesaplama.Text = "Hesaplama";
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Location = new Point(10, 42);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(44, 15);
            lblTutar.TabIndex = 0;
            lblTutar.Text = "TUTAR:";
            // 
            // txbTutar
            // 
            txbTutar.Location = new Point(60, 39);
            txbTutar.Name = "txbTutar";
            txbTutar.Size = new Size(136, 23);
            txbTutar.TabIndex = 1;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(19, 85);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(167, 49);
            btnHesapla.TabIndex = 2;
            btnHesapla.Text = "HESAPLA";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 213);
            Controls.Add(grbHesaplama);
            Controls.Add(grbIndirimler);
            Name = "Form1";
            Text = "Form1";
            grbIndirimler.ResumeLayout(false);
            grbIndirimler.PerformLayout();
            grbHesaplama.ResumeLayout(false);
            grbHesaplama.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbIndirimler;
        private CheckBox chkIndirim15;
        private CheckBox chkIndirim10;
        private CheckBox chkIndirim5;
        private GroupBox grbHesaplama;
        private Label lblTutar;
        private Button btnHesapla;
        private TextBox txbTutar;
    }
}