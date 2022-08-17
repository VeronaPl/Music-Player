using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using TagLib;
using WMPLib;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace My_Mp3_Player
{
    public partial class Form1 : Form
    {
        string[] trackName, trackPath;
        int vol;
        bool isPlaying, en_flag;
        WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
            track_volume.Value = 50;
            lbl_volume.Text = "50%";
            isPlaying = false;
            en_flag = true;
            txt_search.Visible = false;
            pic_search.Visible = false;
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Multiselect = true;
            OFD.Filter = "(mp3,wav,avi,3gp,flv)|*.mp3;*.wav; *.3gp; *.avi; *.flv | all files | *.* ";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                trackName = OFD.SafeFileNames;
                trackPath = OFD.FileNames;
                track_list.Sorted = true;
                for(int i = 0; i < trackName.Length; i++)
                {
                    track_list.Items.Add(trackName[i]);
                } 
            }
        }

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                player.URL = trackPath[track_list.SelectedIndex];
                lbl_track_start.Enabled = true;
                lbl_track_end.Enabled = true;
                player.Ctlcontrols.play();
                btn_play.Image = Properties.Resources.pause;
                isPlaying = true;
                var file = TagLib.File.Create(trackPath[track_list.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                pic_album.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch
            {

            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if ((track_list.Items.Count == 0) && (en_flag == true)) MessageBox.Show("Playlist is empty!");
            else if((track_list.Items.Count == 0) && (en_flag == false)) MessageBox.Show("Плейлист пуст");
            else if (track_list.SelectedItem != null)// Play\Stop
            {
                if (isPlaying)
                {
                    player.Ctlcontrols.stop();
                    btn_play.Image = Properties.Resources.play;
                    p_bar.Value = 0;
                    isPlaying = false;
                }
                else
                {
                    player.Ctlcontrols.play();
                    btn_play.Image = Properties.Resources.pause;
                    isPlaying = true;
                }
            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (en_flag == true) txt_search.Text = "Search";
            else txt_search.Text = "Поиск";
            if ((track_list.Items.Count == 0) && (en_flag == true)) MessageBox.Show("Playlist is empty!");
            else if ((track_list.Items.Count == 0) && (en_flag == false)) MessageBox.Show("Плейлист пуст!");
            else if (track_list.SelectedItem != null)// Play\Pause
            {
                if(!isPlaying)
                {
                    player.Ctlcontrols.play();
                    btn_play.Image = Properties.Resources.pause;
                    isPlaying = true;
                }
                else
                {
                    player.Ctlcontrols.pause();
                    btn_play.Image = Properties.Resources.play;
                    isPlaying = false;
                }
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if ((track_list.Items.Count == 0) && (en_flag == true)) MessageBox.Show("Playlist is empty!");
            else if ((track_list.Items.Count == 0) && (en_flag == false)) MessageBox.Show("Плейлист пуст!");
            else
            {
                if (track_list.SelectedIndex < track_list.Items.Count - 1)
                {
                    track_list.SelectedIndex += 1;
                }
                else if(track_list.SelectedIndex == track_list.Items.Count - 1)
                {
                    track_list.SelectedIndex = 0;
                }
            }
            
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            if ((track_list.Items.Count == 0) && (en_flag == true)) MessageBox.Show("Playlist is empty!");
            else if ((track_list.Items.Count == 0) && (en_flag == false)) MessageBox.Show("Плейлист пуст!");
            else
            {
                if (track_list.SelectedIndex > 0)
                {
                    track_list.SelectedIndex -= 1;
                }
                else if(track_list.SelectedIndex == 0)
                {
                    track_list.SelectedIndex = track_list.Items.Count - 1;
                }
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                p_bar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                p_bar.Value = (int)player.Ctlcontrols.currentPosition;
            }
            try
            {
                lbl_track_start.Text = player.Ctlcontrols.currentPositionString;
                //lbl_track_end.Text = player.Ctlcontrols.currentItem.durationString.ToString();
                lbl_track_end.Text = String.Format("{0:D2}:{1:D2}",(int)p_bar.Maximum/60, (int)p_bar.Maximum - ((int)p_bar.Maximum / 60)*60);
            }
            catch { }
        }

        private void track_volume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = track_volume.Value;
            lbl_volume.Text = track_volume.Value.ToString() + "%";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "Text files (*.txt)|*.txt";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                StreamWriter player_playlist = System.IO.File.CreateText(SFD.FileName);
                if (SFD.FilterIndex == 1 | SFD.FilterIndex == 2)
                {
                    for (int i = 0; i < track_list.Items.Count; i++)
                    {
                        track_list.SelectedIndex = i;
                        player_playlist.WriteLine(track_list.SelectedItem.ToString());
                    }
                }
                player_playlist.Close();
            }
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (player.URL == track_list.SelectedItem.ToString())
                {
                    player.Ctlcontrols.stop();
                    p_bar.Value = 0;
                    isPlaying = false;
                    player.URL = "";
                }
                track_list.Items.Remove(track_list.SelectedItem);
            }
            catch 
            {
                if (en_flag == true) MessageBox.Show("Firstly, you should select a track!"); 
                else MessageBox.Show("Сначала выберите трек!");
            }
        }

        private void about_the_creator_Click(object sender, EventArgs e)
        {
            if (en_flag == true) MessageBox.Show("Copyright belongs to:  Verona\n\nTelegram:  @ragazza_verona\nGmail:  vp31102003@gmail.com", "Information about the creator");
            else MessageBox.Show("Авторские права принадлежат:  Verona\n\nТелеграм:  @ragazza_verona\nПочта:  vp31102003@gmail.com","Информация об авторе");
        }

        private void information_Click(object sender, EventArgs e)
        {
            try
            {
                var audio = TagLib.File.Create(@trackPath[track_list.SelectedIndex]);
                ////title
                //Buffer.Title_Buffer = audio.Tag.Title;

                ////artist
                //Buffer.Singer_Buffer = String.Join(", ", audio.Tag.Performers);

                ////album
                //Buffer.Album_Buffer = audio.Tag.Album;

                ////genre
                //Buffer.Genre_Buffer = String.Join(", ", audio.Tag.Genres);

                if (en_flag == true) MessageBox.Show($"Title: {audio.Tag.Title}\nSinger: {String.Join(", ", audio.Tag.Performers)}\nAlbum: {audio.Tag.Album}\nYear: {audio.Tag.Year}\nGenre: {String.Join(", ", audio.Tag.Genres)}\nDuration: {audio.Properties.Duration.ToString("mm\\:ss")}", "Information about the track");
                else MessageBox.Show($"Название: {audio.Tag.Title}\nИсполнитель: {String.Join(", ", audio.Tag.Performers)}\nАльбом: {audio.Tag.Album}\nГод: {audio.Tag.Year}\nЖанр: {String.Join(", ", audio.Tag.Genres)}\nДлительность: {audio.Properties.Duration.ToString("mm\\:ss")}", "Информация о треке");
            }
            catch 
            {
                if ((track_list.Items.Count == 0) && (en_flag == true)) MessageBox.Show("Playlist is empty!");
                else if ((track_list.Items.Count == 0) && (en_flag == false)) MessageBox.Show("Плейлист пуст!");
                else if (en_flag == true) MessageBox.Show("Firstly, you should select a track!");
                else MessageBox.Show("Сначала выберите трек!");
            }
            
        }

        private void change_Click(object sender, EventArgs e)
        {
            try
            {
                var audio = TagLib.File.Create(@trackPath[track_list.SelectedIndex]);
                Buffer.ValueChanged += (object sender1, EventArgs el) =>
                {
                    audio.Tag.Title = Buffer.Title_Buffer;

                    string singer = Buffer.Singer_Buffer;
                    string[] singers = new string[] { singer };
                    audio.Tag.Performers = singers;

                    audio.Tag.Album = Buffer.Album_Buffer;

                    string genre = Buffer.Genre_Buffer;
                    string[] genres = new string[] { genre };
                    audio.Tag.Genres = genres;

                    //audio.Save();
                };
                Form2 fr2 = new Form2();
                fr2.Show();
            }
            catch
            {
                if ((track_list.Items.Count == 0) && (en_flag == true)) MessageBox.Show("Playlist is empty!");
                else if ((track_list.Items.Count == 0) && (en_flag == false)) MessageBox.Show("Плейлист пуст!");
                else if (en_flag == true) MessageBox.Show("Firstly, you should select a track!");
                else MessageBox.Show("Сначала выберите трек!");
            }
            
        }

        private void search_Click(object sender, EventArgs e)
        {
            txt_search.Visible = true;
            pic_search.Visible = true;
        }

        private void txt_search_MouseClick(object sender, MouseEventArgs e)
        {
            txt_search.Text = "";
        }

        private void english_Click(object sender, EventArgs e)
        {
            en_flag = true; // language = english
            btn_open.Text = "Open";
            btn_delete.Text = "Delete";
            btn_save.Text = "Save";
            label1.Text = "Volume";
            txt_search.Text = "Search";
            menu.Text = "Menu";
            about_the_creator.Text = "About the creator";
            language.Text = "Language";
            english.Text = "English";
            russian.Text = "Russian";
            meta_data.Text = "Meta data";
            information.Text = "Information";
            change.Text = "Change";
            search.Text = "Search";
            create.Text = "Create";
            read.Text = "Read";
        }

        private void russian_Click(object sender, EventArgs e)
        {
            en_flag = false; // language = russian
            btn_open.Text = "Открыть";
            btn_delete.Text = "Удалить";
            btn_save.Text = "Сохранить";
            label1.Text = "Громкость";
            txt_search.Text = "Поиск";
            menu.Text = "Меню";
            about_the_creator.Text = "Об авторе";
            language.Text = "Язык";
            english.Text = "Английский";
            russian.Text = "Русский";
            meta_data.Text = "Метаданные";
            information.Text = "Свойства";
            change.Text = "Изменить";
            search.Text = "Поиск";
            create.Text = "Создать";
            read.Text = "Считать";
        }

        private void pic_mute_Click(object sender, EventArgs e)
        {
            if (track_volume.Value > 0)
            {
                vol = track_volume.Value;
                track_volume.Value = 0;
                player.settings.volume = track_volume.Value;
                pic_mute.Image = Properties.Resources.volume_mute2;
                lbl_volume.Text = "0%";

            }
            else
            {
                track_volume.Value = vol;
                player.settings.volume = track_volume.Value;
                pic_mute.Image = Properties.Resources.volume_mute;
                lbl_volume.Text = track_volume.Value.ToString() + "%";
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            if ((track_list.Items.Count == 0) && (en_flag == true)) MessageBox.Show("Playlist is empty!");
            else if ((track_list.Items.Count == 0) && (en_flag == false)) MessageBox.Show("Плейлист пуст!");
            XmlTextWriter XML = new XmlTextWriter(@"PL.xml", Encoding.UTF8);
            XML.WriteStartDocument();
            XML.WriteStartElement("head");
            XML.WriteEndElement();
            XML.Close();

            XmlDocument doc = new XmlDocument();
            doc.Load(@"PL.xml");

            for (int i = 0; i < track_list.Items.Count; i++)
            {
                track_list.SelectedIndex = i;
                var audio = TagLib.File.Create(@trackPath[track_list.SelectedIndex]);
                XmlNode el = doc.CreateElement("track_info");
                doc.DocumentElement.AppendChild(el);
                XmlAttribute attr = doc.CreateAttribute("number");
                attr.Value = (i + 1).ToString();
                el.Attributes.Append(attr);
                XmlNode subEl_1 = doc.CreateElement("track_title");
                subEl_1.InnerText = " " + audio.Tag.Title + " ";
                el.AppendChild(subEl_1);
                XmlNode subEl_2 = doc.CreateElement("track_path");
                subEl_2.InnerText = " " + @trackPath[track_list.SelectedIndex] + " ";
                el.AppendChild(subEl_2);
                XmlNode subEl_3 = doc.CreateElement("track_singer");
                subEl_3.InnerText = " " + String.Join(", ", audio.Tag.Performers) + " ";
                el.AppendChild(subEl_3);
                XmlNode subEl_4 = doc.CreateElement("track_album");
                subEl_4.InnerText = " " + audio.Tag.Album + " ";
                el.AppendChild(subEl_4);
                XmlNode subEl_5 = doc.CreateElement("track_year");
                subEl_5.InnerText = " " + audio.Tag.Year.ToString() + " ";
                el.AppendChild(subEl_5);
                XmlNode subEl_6 = doc.CreateElement("track_genre");
                subEl_6.InnerText = " " + String.Join(", ", audio.Tag.Genres) + " ";
                el.AppendChild(subEl_6);
                XmlNode subEl_7 = doc.CreateElement("track_duration");
                subEl_7.InnerText = " " + audio.Properties.Duration.ToString("mm\\:ss") + " ";
                el.AppendChild(subEl_7);
                doc.Save(@"PL.xml");
            }          
        }

        private void read_Click(object sender, EventArgs e)
        {
            if ((track_list.Items.Count == 0) && (en_flag == true)) MessageBox.Show("Playlist is empty!");
            else if ((track_list.Items.Count == 0) && (en_flag == false)) MessageBox.Show("Плейлист пуст!");
            XmlDocument doc = new XmlDocument();
            doc.Load(@"PL.xml");
            XmlNode node = doc.DocumentElement.SelectSingleNode("track_info/track_name");
            foreach (XmlNode nodel in doc.DocumentElement.ChildNodes)
            {
                string text = nodel.InnerText;
                string attr = nodel.Attributes["number"]?.InnerText;
                MessageBox.Show($"{text}", $"#{attr}");
            }
        }

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            if ((track_list.Items.Count == 0) && (en_flag == true)) MessageBox.Show("Playlist is empty!");
            else if ((track_list.Items.Count == 0) && (en_flag == false)) MessageBox.Show("Плейлист пуст!");
            else
            {
                int index = track_list.FindString(txt_search.Text);
                if (0 <= index)
                {
                    track_list.SelectedIndex = index;
                }
            }
        }

        private void p_bar_MouseDown(object sender, MouseEventArgs e)
        {
            if ((track_list.Items.Count == 0) && (en_flag == true)) MessageBox.Show("Playlist is empty!");
            else if ((track_list.Items.Count == 0) && (en_flag == false)) MessageBox.Show("Плейлист пуст!");
            else if (track_list.SelectedItem != null) player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / p_bar.Width;
        }
    }
}
