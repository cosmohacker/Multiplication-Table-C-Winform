namespace CarpimTablosu
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
            this.birler = new System.Windows.Forms.ListBox();
            this.ikiler = new System.Windows.Forms.ListBox();
            this.ucler = new System.Windows.Forms.ListBox();
            this.dortler = new System.Windows.Forms.ListBox();
            this.besler = new System.Windows.Forms.ListBox();
            this.altilar = new System.Windows.Forms.ListBox();
            this.yediler = new System.Windows.Forms.ListBox();
            this.sekizler = new System.Windows.Forms.ListBox();
            this.dokuzlar = new System.Windows.Forms.ListBox();
            this.onlar = new System.Windows.Forms.ListBox();
            this.btnYardir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // birler
            // 
            this.birler.FormattingEnabled = true;
            this.birler.Location = new System.Drawing.Point(13, 12);
            this.birler.Name = "birler";
            this.birler.Size = new System.Drawing.Size(120, 173);
            this.birler.TabIndex = 0;
            // 
            // ikiler
            // 
            this.ikiler.FormattingEnabled = true;
            this.ikiler.Location = new System.Drawing.Point(139, 12);
            this.ikiler.Name = "ikiler";
            this.ikiler.Size = new System.Drawing.Size(120, 173);
            this.ikiler.TabIndex = 1;
            // 
            // ucler
            // 
            this.ucler.FormattingEnabled = true;
            this.ucler.Location = new System.Drawing.Point(265, 12);
            this.ucler.Name = "ucler";
            this.ucler.Size = new System.Drawing.Size(120, 173);
            this.ucler.TabIndex = 2;
            // 
            // dortler
            // 
            this.dortler.FormattingEnabled = true;
            this.dortler.Location = new System.Drawing.Point(391, 12);
            this.dortler.Name = "dortler";
            this.dortler.Size = new System.Drawing.Size(120, 173);
            this.dortler.TabIndex = 3;
            // 
            // besler
            // 
            this.besler.FormattingEnabled = true;
            this.besler.Location = new System.Drawing.Point(517, 12);
            this.besler.Name = "besler";
            this.besler.Size = new System.Drawing.Size(120, 173);
            this.besler.TabIndex = 4;
            // 
            // altilar
            // 
            this.altilar.FormattingEnabled = true;
            this.altilar.Location = new System.Drawing.Point(13, 191);
            this.altilar.Name = "altilar";
            this.altilar.Size = new System.Drawing.Size(120, 173);
            this.altilar.TabIndex = 5;
            // 
            // yediler
            // 
            this.yediler.FormattingEnabled = true;
            this.yediler.Location = new System.Drawing.Point(139, 191);
            this.yediler.Name = "yediler";
            this.yediler.Size = new System.Drawing.Size(120, 173);
            this.yediler.TabIndex = 6;
            // 
            // sekizler
            // 
            this.sekizler.FormattingEnabled = true;
            this.sekizler.Location = new System.Drawing.Point(265, 191);
            this.sekizler.Name = "sekizler";
            this.sekizler.Size = new System.Drawing.Size(120, 173);
            this.sekizler.TabIndex = 7;
            // 
            // dokuzlar
            // 
            this.dokuzlar.FormattingEnabled = true;
            this.dokuzlar.Location = new System.Drawing.Point(391, 191);
            this.dokuzlar.Name = "dokuzlar";
            this.dokuzlar.Size = new System.Drawing.Size(120, 173);
            this.dokuzlar.TabIndex = 8;
            // 
            // onlar
            // 
            this.onlar.FormattingEnabled = true;
            this.onlar.Location = new System.Drawing.Point(517, 191);
            this.onlar.Name = "onlar";
            this.onlar.Size = new System.Drawing.Size(120, 173);
            this.onlar.TabIndex = 9;
            // 
            // btnYardir
            // 
            this.btnYardir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYardir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYardir.Location = new System.Drawing.Point(13, 370);
            this.btnYardir.Name = "btnYardir";
            this.btnYardir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnYardir.Size = new System.Drawing.Size(625, 28);
            this.btnYardir.TabIndex = 10;
            this.btnYardir.Text = "Yardır";
            this.btnYardir.UseVisualStyleBackColor = true;
            this.btnYardir.Click += new System.EventHandler(this.btnYardir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 407);
            this.Controls.Add(this.btnYardir);
            this.Controls.Add(this.onlar);
            this.Controls.Add(this.dokuzlar);
            this.Controls.Add(this.sekizler);
            this.Controls.Add(this.yediler);
            this.Controls.Add(this.altilar);
            this.Controls.Add(this.besler);
            this.Controls.Add(this.dortler);
            this.Controls.Add(this.ucler);
            this.Controls.Add(this.ikiler);
            this.Controls.Add(this.birler);
            this.Name = "Form1";
            this.Text = "Çarpım Tablosu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox birler;
        private System.Windows.Forms.ListBox ikiler;
        private System.Windows.Forms.ListBox ucler;
        private System.Windows.Forms.ListBox dortler;
        private System.Windows.Forms.ListBox besler;
        private System.Windows.Forms.ListBox altilar;
        private System.Windows.Forms.ListBox yediler;
        private System.Windows.Forms.ListBox sekizler;
        private System.Windows.Forms.ListBox dokuzlar;
        private System.Windows.Forms.ListBox onlar;
        private System.Windows.Forms.Button btnYardir;
    }
}

