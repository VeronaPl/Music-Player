using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Mp3_Player
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            lbl_title.Text = "Название";
            lbl_singer.Text = "Певец";
            lbl_album.Text = "Альбом";
            lbl_genre.Text = "Жанр";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tb_title.Text = Buffer.Title_Buffer;
            tb_singer.Text = Buffer.Singer_Buffer;
            tb_album.Text = Buffer.Album_Buffer;
            tb_genre.Text = Buffer.Genre_Buffer;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Buffer.Title_Buffer = tb_title.Text;
            Buffer.Singer_Buffer = tb_singer.Text;
            Buffer.Album_Buffer = tb_album.Text;
            Buffer.Genre_Buffer = tb_genre.Text;
            this.Close();
        }
    }
}
