namespace HadsKalamat
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
            this.groupBxBala = new System.Windows.Forms.GroupBox();
            this.lblTedad = new System.Windows.Forms.Label();
            this.picBoxAnswer = new System.Windows.Forms.PictureBox();
            this.picBoxPart = new System.Windows.Forms.PictureBox();
            this.btnHadsKalame = new System.Windows.Forms.Button();
            this.txtKalame = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWrong = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.بازیجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNew = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBxBala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBxBala
            // 
            this.groupBxBala.BackColor = System.Drawing.Color.Transparent;
            this.groupBxBala.Controls.Add(this.lblTedad);
            this.groupBxBala.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBxBala.Location = new System.Drawing.Point(27, 81);
            this.groupBxBala.Margin = new System.Windows.Forms.Padding(4);
            this.groupBxBala.Name = "groupBxBala";
            this.groupBxBala.Padding = new System.Windows.Forms.Padding(4);
            this.groupBxBala.Size = new System.Drawing.Size(540, 152);
            this.groupBxBala.TabIndex = 0;
            this.groupBxBala.TabStop = false;
            this.groupBxBala.Enter += new System.EventHandler(this.groupBxBala_Enter);
            // 
            // lblTedad
            // 
            this.lblTedad.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTedad.Location = new System.Drawing.Point(402, 22);
            this.lblTedad.Name = "lblTedad";
            this.lblTedad.Size = new System.Drawing.Size(131, 45);
            this.lblTedad.TabIndex = 0;
            // 
            // picBoxAnswer
            // 
            this.picBoxAnswer.BackColor = System.Drawing.Color.Transparent;
            this.picBoxAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxAnswer.Location = new System.Drawing.Point(574, 54);
            this.picBoxAnswer.Name = "picBoxAnswer";
            this.picBoxAnswer.Size = new System.Drawing.Size(148, 124);
            this.picBoxAnswer.TabIndex = 1;
            this.picBoxAnswer.TabStop = false;
            // 
            // picBoxPart
            // 
            this.picBoxPart.BackColor = System.Drawing.Color.Transparent;
            this.picBoxPart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxPart.Location = new System.Drawing.Point(558, 226);
            this.picBoxPart.Name = "picBoxPart";
            this.picBoxPart.Size = new System.Drawing.Size(104, 166);
            this.picBoxPart.TabIndex = 2;
            this.picBoxPart.TabStop = false;
            // 
            // btnHadsKalame
            // 
            this.btnHadsKalame.BackColor = System.Drawing.Color.Transparent;
            this.btnHadsKalame.FlatAppearance.BorderSize = 0;
            this.btnHadsKalame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHadsKalame.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnHadsKalame.Location = new System.Drawing.Point(148, 270);
            this.btnHadsKalame.Name = "btnHadsKalame";
            this.btnHadsKalame.Size = new System.Drawing.Size(132, 51);
            this.btnHadsKalame.TabIndex = 3;
            this.btnHadsKalame.Text = "حدس کلمه";
            this.btnHadsKalame.UseVisualStyleBackColor = false;
            this.btnHadsKalame.Click += new System.EventHandler(this.btnHadsKalame_Click);
            // 
            // txtKalame
            // 
            this.txtKalame.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtKalame.Location = new System.Drawing.Point(303, 283);
            this.txtKalame.MaxLength = 1;
            this.txtKalame.Name = "txtKalame";
            this.txtKalame.Size = new System.Drawing.Size(100, 30);
            this.txtKalame.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(80, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 44);
            this.label2.TabIndex = 5;
            this.label2.Text = "حروف اشتباه حدس زده شده";
            // 
            // lblWrong
            // 
            this.lblWrong.BackColor = System.Drawing.Color.Transparent;
            this.lblWrong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblWrong.Location = new System.Drawing.Point(296, 348);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(256, 29);
            this.lblWrong.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.بازیجدیدToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // بازیجدیدToolStripMenuItem
            // 
            this.بازیجدیدToolStripMenuItem.Name = "بازیجدیدToolStripMenuItem";
            this.بازیجدیدToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.بازیجدیدToolStripMenuItem.Text = "بازی جدید";
            this.بازیجدیدToolStripMenuItem.Click += new System.EventHandler(this.بازیجدیدToolStripMenuItem_Click);
            // 
            // lblNew
            // 
            this.lblNew.BackColor = System.Drawing.Color.Transparent;
            this.lblNew.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNew.Location = new System.Drawing.Point(184, 392);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(478, 44);
            this.lblNew.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(721, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "mr.heidari1373@gmail.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::HadsKalamat.Properties.Resources.Backg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.lblWrong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKalame);
            this.Controls.Add(this.btnHadsKalame);
            this.Controls.Add(this.picBoxPart);
            this.Controls.Add(this.picBoxAnswer);
            this.Controls.Add(this.groupBxBala);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "بازی کلمات";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBxBala.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBxBala;
        private System.Windows.Forms.Label lblTedad;
        private System.Windows.Forms.PictureBox picBoxAnswer;
        private System.Windows.Forms.PictureBox picBoxPart;
        private System.Windows.Forms.Button btnHadsKalame;
        private System.Windows.Forms.TextBox txtKalame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWrong;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem بازیجدیدToolStripMenuItem;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Label label1;
    }
}

