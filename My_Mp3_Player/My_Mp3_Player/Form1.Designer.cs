
namespace My_Mp3_Player
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_open = new System.Windows.Forms.Button();
            this.p_bar = new System.Windows.Forms.ProgressBar();
            this.track_list = new System.Windows.Forms.ListBox();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_mute = new System.Windows.Forms.PictureBox();
            this.pic_album = new System.Windows.Forms.PictureBox();
            this.lbl_track_end = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.about_the_creator = new System.Windows.Forms.ToolStripMenuItem();
            this.language = new System.Windows.Forms.ToolStripMenuItem();
            this.english = new System.Windows.Forms.ToolStripMenuItem();
            this.russian = new System.Windows.Forms.ToolStripMenuItem();
            this.meta_data = new System.Windows.Forms.ToolStripMenuItem();
            this.information = new System.Windows.Forms.ToolStripMenuItem();
            this.change = new System.Windows.Forms.ToolStripMenuItem();
            this.search = new System.Windows.Forms.ToolStripMenuItem();
            this.xml = new System.Windows.Forms.ToolStripMenuItem();
            this.create = new System.Windows.Forms.ToolStripMenuItem();
            this.read = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.pic_search = new System.Windows.Forms.PictureBox();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_album)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_open
            // 
            this.btn_open.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_open.AutoEllipsis = true;
            this.btn_open.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_open.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn_open.Location = new System.Drawing.Point(410, 473);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(120, 49);
            this.btn_open.TabIndex = 8;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // p_bar
            // 
            this.p_bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_bar.BackColor = System.Drawing.Color.Thistle;
            this.p_bar.ForeColor = System.Drawing.Color.LimeGreen;
            this.p_bar.Location = new System.Drawing.Point(29, 423);
            this.p_bar.Name = "p_bar";
            this.p_bar.Size = new System.Drawing.Size(750, 23);
            this.p_bar.TabIndex = 9;
            this.p_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_bar_MouseDown);
            // 
            // track_list
            // 
            this.track_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.track_list.BackColor = System.Drawing.Color.Thistle;
            this.track_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.track_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.track_list.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.track_list.ForeColor = System.Drawing.Color.DarkMagenta;
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 23;
            this.track_list.Location = new System.Drawing.Point(238, 22);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(469, 184);
            this.track_list.TabIndex = 10;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // player
            // 
            this.player.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(816, 124);
            this.player.TabIndex = 12;
            // 
            // track_volume
            // 
            this.track_volume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.track_volume.BackColor = System.Drawing.Color.DarkMagenta;
            this.track_volume.LargeChange = 1;
            this.track_volume.Location = new System.Drawing.Point(735, 39);
            this.track_volume.Maximum = 100;
            this.track_volume.Name = "track_volume";
            this.track_volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track_volume.Size = new System.Drawing.Size(69, 145);
            this.track_volume.TabIndex = 13;
            this.track_volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.track_volume.Value = 50;
            this.track_volume.Scroll += new System.EventHandler(this.track_volume_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkMagenta;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(722, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Volume";
            // 
            // lbl_volume
            // 
            this.lbl_volume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.BackColor = System.Drawing.Color.DarkMagenta;
            this.lbl_volume.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_volume.ForeColor = System.Drawing.Color.White;
            this.lbl_volume.Location = new System.Drawing.Point(729, 17);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(50, 19);
            this.lbl_volume.TabIndex = 15;
            this.lbl_volume.Text = "100%";
            // 
            // lbl_track_start
            // 
            this.lbl_track_start.AutoSize = true;
            this.lbl_track_start.BackColor = System.Drawing.Color.Black;
            this.lbl_track_start.Enabled = false;
            this.lbl_track_start.Font = new System.Drawing.Font("Informal Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_start.ForeColor = System.Drawing.Color.Lime;
            this.lbl_track_start.Location = new System.Drawing.Point(64, 82);
            this.lbl_track_start.Name = "lbl_track_start";
            this.lbl_track_start.Size = new System.Drawing.Size(153, 61);
            this.lbl_track_start.TabIndex = 16;
            this.lbl_track_start.Text = "00:00";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel1.Controls.Add(this.pic_mute);
            this.panel1.Controls.Add(this.pic_album);
            this.panel1.Controls.Add(this.track_list);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.track_volume);
            this.panel1.Controls.Add(this.lbl_volume);
            this.panel1.Location = new System.Drawing.Point(0, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 231);
            this.panel1.TabIndex = 18;
            // 
            // pic_mute
            // 
            this.pic_mute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_mute.BackColor = System.Drawing.Color.DarkMagenta;
            this.pic_mute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_mute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_mute.Image = global::My_Mp3_Player.Properties.Resources.volume_mute;
            this.pic_mute.Location = new System.Drawing.Point(775, 160);
            this.pic_mute.Name = "pic_mute";
            this.pic_mute.Size = new System.Drawing.Size(24, 24);
            this.pic_mute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_mute.TabIndex = 16;
            this.pic_mute.TabStop = false;
            this.pic_mute.Click += new System.EventHandler(this.pic_mute_Click);
            // 
            // pic_album
            // 
            this.pic_album.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_album.BackColor = System.Drawing.Color.Thistle;
            this.pic_album.Image = global::My_Mp3_Player.Properties.Resources.плеер;
            this.pic_album.Location = new System.Drawing.Point(30, 22);
            this.pic_album.Name = "pic_album";
            this.pic_album.Size = new System.Drawing.Size(188, 188);
            this.pic_album.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_album.TabIndex = 11;
            this.pic_album.TabStop = false;
            // 
            // lbl_track_end
            // 
            this.lbl_track_end.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_track_end.AutoSize = true;
            this.lbl_track_end.BackColor = System.Drawing.Color.Black;
            this.lbl_track_end.Enabled = false;
            this.lbl_track_end.Font = new System.Drawing.Font("Informal Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_end.ForeColor = System.Drawing.Color.Lime;
            this.lbl_track_end.Location = new System.Drawing.Point(589, 82);
            this.lbl_track_end.Name = "lbl_track_end";
            this.lbl_track_end.Size = new System.Drawing.Size(153, 61);
            this.lbl_track_end.TabIndex = 19;
            this.lbl_track_end.Text = "00:00";
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.AutoEllipsis = true;
            this.btn_save.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_save.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn_save.Location = new System.Drawing.Point(662, 473);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(120, 49);
            this.btn_save.TabIndex = 20;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.AutoEllipsis = true;
            this.btn_delete.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_delete.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn_delete.Location = new System.Drawing.Point(536, 473);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(120, 49);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click_1);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.player);
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 130);
            this.panel2.TabIndex = 22;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Thistle;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 36);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about_the_creator,
            this.language,
            this.meta_data,
            this.search,
            this.xml});
            this.menu.ForeColor = System.Drawing.Color.DarkMagenta;
            this.menu.Image = global::My_Mp3_Player.Properties.Resources.bars;
            this.menu.ImageTransparentColor = System.Drawing.Color.Lavender;
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(100, 30);
            this.menu.Text = "Menu";
            // 
            // about_the_creator
            // 
            this.about_the_creator.BackColor = System.Drawing.Color.Black;
            this.about_the_creator.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.about_the_creator.ForeColor = System.Drawing.Color.Lime;
            this.about_the_creator.Name = "about_the_creator";
            this.about_the_creator.Size = new System.Drawing.Size(270, 34);
            this.about_the_creator.Text = "About the creator";
            this.about_the_creator.Click += new System.EventHandler(this.about_the_creator_Click);
            // 
            // language
            // 
            this.language.BackColor = System.Drawing.Color.Black;
            this.language.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.english,
            this.russian});
            this.language.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.language.ForeColor = System.Drawing.Color.Lime;
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(270, 34);
            this.language.Text = "Language";
            // 
            // english
            // 
            this.english.BackColor = System.Drawing.Color.Black;
            this.english.ForeColor = System.Drawing.Color.Lime;
            this.english.Name = "english";
            this.english.Size = new System.Drawing.Size(174, 34);
            this.english.Text = "English";
            this.english.Click += new System.EventHandler(this.english_Click);
            // 
            // russian
            // 
            this.russian.BackColor = System.Drawing.Color.Black;
            this.russian.ForeColor = System.Drawing.Color.Lime;
            this.russian.Name = "russian";
            this.russian.Size = new System.Drawing.Size(174, 34);
            this.russian.Text = "Russian";
            this.russian.Click += new System.EventHandler(this.russian_Click);
            // 
            // meta_data
            // 
            this.meta_data.BackColor = System.Drawing.Color.Black;
            this.meta_data.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.information,
            this.change});
            this.meta_data.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.meta_data.ForeColor = System.Drawing.Color.Lime;
            this.meta_data.Name = "meta_data";
            this.meta_data.Size = new System.Drawing.Size(270, 34);
            this.meta_data.Text = "Meta data";
            // 
            // information
            // 
            this.information.BackColor = System.Drawing.Color.Black;
            this.information.ForeColor = System.Drawing.Color.Lime;
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(270, 34);
            this.information.Text = "Information";
            this.information.Click += new System.EventHandler(this.information_Click);
            // 
            // change
            // 
            this.change.BackColor = System.Drawing.Color.Black;
            this.change.ForeColor = System.Drawing.Color.Lime;
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(270, 34);
            this.change.Text = "Change";
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Black;
            this.search.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search.ForeColor = System.Drawing.Color.Lime;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(270, 34);
            this.search.Text = "Search";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // xml
            // 
            this.xml.BackColor = System.Drawing.Color.Black;
            this.xml.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.create,
            this.read});
            this.xml.ForeColor = System.Drawing.Color.Lime;
            this.xml.Name = "xml";
            this.xml.Size = new System.Drawing.Size(270, 34);
            this.xml.Text = "XML";
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.Black;
            this.create.ForeColor = System.Drawing.Color.Lime;
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(270, 34);
            this.create.Text = "Create";
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // read
            // 
            this.read.BackColor = System.Drawing.Color.Black;
            this.read.ForeColor = System.Drawing.Color.Lime;
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(270, 34);
            this.read.Text = "Read";
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.LavenderBlush;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_search.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txt_search.Location = new System.Drawing.Point(267, 10);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(292, 25);
            this.txt_search.TabIndex = 24;
            this.txt_search.Text = "Search";
            this.txt_search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_search_MouseClick);
            this.txt_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyUp);
            // 
            // pic_search
            // 
            this.pic_search.Image = global::My_Mp3_Player.Properties.Resources.search;
            this.pic_search.Location = new System.Drawing.Point(238, 11);
            this.pic_search.Name = "pic_search";
            this.pic_search.Size = new System.Drawing.Size(24, 24);
            this.pic_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_search.TabIndex = 25;
            this.pic_search.TabStop = false;
            // 
            // btn_stop
            // 
            this.btn_stop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_stop.AutoEllipsis = true;
            this.btn_stop.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_stop.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn_stop.Image = global::My_Mp3_Player.Properties.Resources.stop;
            this.btn_stop.Location = new System.Drawing.Point(220, 473);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(89, 49);
            this.btn_stop.TabIndex = 7;
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_play
            // 
            this.btn_play.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_play.AutoEllipsis = true;
            this.btn_play.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_play.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn_play.Image = global::My_Mp3_Player.Properties.Resources.play;
            this.btn_play.Location = new System.Drawing.Point(125, 473);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(89, 49);
            this.btn_play.TabIndex = 5;
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_next
            // 
            this.btn_next.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_next.AutoEllipsis = true;
            this.btn_next.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_next.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn_next.Image = global::My_Mp3_Player.Properties.Resources.step_forward;
            this.btn_next.Location = new System.Drawing.Point(315, 473);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(89, 49);
            this.btn_next.TabIndex = 4;
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_preview.AutoEllipsis = true;
            this.btn_preview.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_preview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_preview.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_preview.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn_preview.Image = global::My_Mp3_Player.Properties.Resources.step_backward;
            this.btn_preview.Location = new System.Drawing.Point(30, 473);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(89, 49);
            this.btn_preview.TabIndex = 0;
            this.btn_preview.UseVisualStyleBackColor = false;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(816, 551);
            this.Controls.Add(this.pic_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_track_end);
            this.Controls.Add(this.lbl_track_start);
            this.Controls.Add(this.p_bar);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player \"Verona\"";
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_album)).EndInit();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ProgressBar p_bar;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.PictureBox pic_album;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.TrackBar track_volume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_track_end;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem about_the_creator;
        private System.Windows.Forms.ToolStripMenuItem language;
        private System.Windows.Forms.ToolStripMenuItem meta_data;
        private System.Windows.Forms.ToolStripMenuItem search;
        private System.Windows.Forms.ToolStripMenuItem english;
        private System.Windows.Forms.ToolStripMenuItem russian;
        private System.Windows.Forms.ToolStripMenuItem information;
        private System.Windows.Forms.ToolStripMenuItem change;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.PictureBox pic_search;
        private System.Windows.Forms.PictureBox pic_mute;
        private System.Windows.Forms.ToolStripMenuItem xml;
        private System.Windows.Forms.ToolStripMenuItem create;
        private System.Windows.Forms.ToolStripMenuItem read;
    }
}

