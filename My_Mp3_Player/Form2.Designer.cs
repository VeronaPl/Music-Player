
namespace My_Mp3_Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_singer = new System.Windows.Forms.Label();
            this.lbl_album = new System.Windows.Forms.Label();
            this.lbl_genre = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.tb_singer = new System.Windows.Forms.TextBox();
            this.tb_album = new System.Windows.Forms.TextBox();
            this.tb_genre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_title.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_title.Location = new System.Drawing.Point(88, 163);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(107, 23);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Название";
            // 
            // lbl_singer
            // 
            this.lbl_singer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_singer.AutoSize = true;
            this.lbl_singer.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_singer.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_singer.Location = new System.Drawing.Point(86, 256);
            this.lbl_singer.Name = "lbl_singer";
            this.lbl_singer.Size = new System.Drawing.Size(142, 23);
            this.lbl_singer.TabIndex = 1;
            this.lbl_singer.Text = "Исполнитель";
            // 
            // lbl_album
            // 
            this.lbl_album.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_album.AutoSize = true;
            this.lbl_album.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_album.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_album.Location = new System.Drawing.Point(86, 349);
            this.lbl_album.Name = "lbl_album";
            this.lbl_album.Size = new System.Drawing.Size(88, 23);
            this.lbl_album.TabIndex = 2;
            this.lbl_album.Text = "Альбом";
            // 
            // lbl_genre
            // 
            this.lbl_genre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_genre.AutoSize = true;
            this.lbl_genre.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_genre.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_genre.Location = new System.Drawing.Point(88, 442);
            this.lbl_genre.Name = "lbl_genre";
            this.lbl_genre.Size = new System.Drawing.Size(67, 23);
            this.lbl_genre.TabIndex = 3;
            this.lbl_genre.Text = "Жанр";
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.Black;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_save.ForeColor = System.Drawing.Color.Lime;
            this.btn_save.Location = new System.Drawing.Point(496, 49);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(120, 50);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tb_title
            // 
            this.tb_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_title.BackColor = System.Drawing.Color.White;
            this.tb_title.ForeColor = System.Drawing.Color.DarkMagenta;
            this.tb_title.Location = new System.Drawing.Point(362, 160);
            this.tb_title.Multiline = true;
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(379, 26);
            this.tb_title.TabIndex = 7;
            // 
            // tb_singer
            // 
            this.tb_singer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_singer.BackColor = System.Drawing.Color.White;
            this.tb_singer.ForeColor = System.Drawing.Color.DarkMagenta;
            this.tb_singer.Location = new System.Drawing.Point(362, 253);
            this.tb_singer.Multiline = true;
            this.tb_singer.Name = "tb_singer";
            this.tb_singer.Size = new System.Drawing.Size(379, 26);
            this.tb_singer.TabIndex = 8;
            // 
            // tb_album
            // 
            this.tb_album.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_album.BackColor = System.Drawing.Color.White;
            this.tb_album.ForeColor = System.Drawing.Color.DarkMagenta;
            this.tb_album.Location = new System.Drawing.Point(362, 346);
            this.tb_album.Multiline = true;
            this.tb_album.Name = "tb_album";
            this.tb_album.Size = new System.Drawing.Size(379, 26);
            this.tb_album.TabIndex = 9;
            // 
            // tb_genre
            // 
            this.tb_genre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_genre.BackColor = System.Drawing.Color.White;
            this.tb_genre.ForeColor = System.Drawing.Color.DarkMagenta;
            this.tb_genre.Location = new System.Drawing.Point(362, 439);
            this.tb_genre.Multiline = true;
            this.tb_genre.Name = "tb_genre";
            this.tb_genre.Size = new System.Drawing.Size(379, 26);
            this.tb_genre.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(816, 551);
            this.Controls.Add(this.tb_genre);
            this.Controls.Add(this.tb_album);
            this.Controls.Add(this.tb_singer);
            this.Controls.Add(this.tb_title);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_genre);
            this.Controls.Add(this.lbl_album);
            this.Controls.Add(this.lbl_singer);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form2";
            this.Text = "Meta data \"Verona\"";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_singer;
        private System.Windows.Forms.Label lbl_album;
        private System.Windows.Forms.Label lbl_genre;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.TextBox tb_singer;
        private System.Windows.Forms.TextBox tb_album;
        private System.Windows.Forms.TextBox tb_genre;
    }
}