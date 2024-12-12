using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Playlist_test
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Node currentSong;
        private DoublyLinkedList playlist;

        public Form()
        {
            InitializeComponent();
            playlist = new DoublyLinkedList();
            currentSong = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = 50; // Âm lượng mặc định là 50
            trackBarVolume.Value = 50;
            axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange; // Sự kiện để theo dõi trạng thái của trình phát
            Timer1.Tick += Timer1_Tick; // Bộ đếm thời gian của bài nhạc
            Timer1.Start();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentSong != null && currentSong.blink != null && currentSong.blink.element.ToString() != "Header")
            {
                currentSong = currentSong.blink; //Chuyển sang bài trước
                axWindowsMediaPlayer1.URL = currentSong.element.ToString();
                axWindowsMediaPlayer1.Ctlcontrols.play(); //Chạy bài trước

                labelNowPlaying.Text = "Playing: " + Path.GetFileName(currentSong.element.ToString());

                // Đồng bộ SelectedIndex với bài hát hiện tại
                int newIndex = listBoxPlaylist.Items.IndexOf(Path.GetFileNameWithoutExtension(currentSong.element.ToString()));
                listBoxPlaylist.SelectedIndex = newIndex;
                // Cập nhật TrackBar dựa trên tốc độ hiện tại
                trackBarSpeed.Value = (int)(axWindowsMediaPlayer1.settings.rate * 100);
                labelSpeed.Text = $"Speed: {axWindowsMediaPlayer1.settings.rate}x";

            }
            else if (currentSong == null)
            {
                MessageBox.Show("You have to add a song first."); //Thông báo khi chưa add nhạc vào
            }
            else
            {
                MessageBox.Show("You are already at the first song."); //Đã move previous tới bài đầu thì không còn bài nào ở trước nữa nên báo
            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            if (currentSong != null)
            {
                currentSong = playlist.GetFirst(); //về node đầu tiên
                axWindowsMediaPlayer1.URL = currentSong.element.ToString();
                axWindowsMediaPlayer1.Ctlcontrols.play();

                labelNowPlaying.Text = "Playing: " + Path.GetFileName(
                axWindowsMediaPlayer1.URL = currentSong.element.ToString());

                // Đồng bộ SelectedIndex với bài hát hiện tại
                int newIndex = listBoxPlaylist.Items.IndexOf(Path.GetFileNameWithoutExtension(currentSong.element.ToString()));
                listBoxPlaylist.SelectedIndex = newIndex;
                // Cập nhật TrackBar dựa trên tốc độ hiện tại
                trackBarSpeed.Value = (int)(axWindowsMediaPlayer1.settings.rate * 100);
                labelSpeed.Text = $"Speed: {axWindowsMediaPlayer1.settings.rate}x";
            }
            else
            {
                MessageBox.Show("You don't have any songs!"); //Báo không có bài nhạc nào trong playlist
            }

        }
        Bitmap btm_play = Properties.Resources.play; //Dùng để làm icon play
        Bitmap btm_pause = Properties.Resources.pause; //Dùng để làm icon pause 
        private void btn_play_Click(object sender, EventArgs e)
        {
            if (currentSong != null)
            {
                // Kiểm tra trạng thái phát lại hiện tại
                if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    // Nếu đang phát, tạm dừng
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                    btn_play.Image = btm_play; // Đổi button sang Play
                }
                else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    // Nếu đang tạm dừng, tiếp tục phát
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    btn_play.Image = btm_pause; // Đổi button sang Pause
                }
                else
                {
                    // Nếu chưa phát, bắt đầu phát bài hát
                    axWindowsMediaPlayer1.URL = currentSong.element.ToString(); // chỉ gán url ghi state kh phải là play hoặc pause (bài hát mới)
                                                                                // gán url: tải lại bài hát + chơi lại vị trị bắt đầu
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    btn_play.Image = btm_pause; // Đổi button sang Pause
                }


                labelNowPlaying.Text = "Playing: " + Path.GetFileName(currentSong.element.ToString());

                // Đồng bộ SelectedIndex với bài hát hiện tại
                int newIndex = listBoxPlaylist.Items.IndexOf(Path.GetFileNameWithoutExtension(currentSong.element.ToString()));
                listBoxPlaylist.SelectedIndex = newIndex;
                // Cập nhật TrackBar dựa trên tốc độ hiện tại
                trackBarSpeed.Value = (int)(axWindowsMediaPlayer1.settings.rate * 100);
                labelSpeed.Text = $"Speed: {axWindowsMediaPlayer1.settings.rate}x";

            }
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (currentSong != null && currentSong.flink != null)
            {
                currentSong = currentSong.flink; //sang nút tiếp theo
                axWindowsMediaPlayer1.URL = currentSong.element.ToString();
                axWindowsMediaPlayer1.Ctlcontrols.play();
                labelNowPlaying.Text = "Playing: " + Path.GetFileName(currentSong.element.ToString());

                // Đồng bộ SelectedIndex với bài hát hiện tại
                int newIndex = listBoxPlaylist.Items.IndexOf(Path.GetFileNameWithoutExtension(currentSong.element.ToString()));
                listBoxPlaylist.SelectedIndex = newIndex;
                // Cập nhật TrackBar dựa trên tốc độ hiện tại
                trackBarSpeed.Value = (int)(axWindowsMediaPlayer1.settings.rate * 100);
                labelSpeed.Text = $"Speed: {axWindowsMediaPlayer1.settings.rate}x";

            }
            else if (currentSong == null)
            {
                MessageBox.Show("You have to add a song first."); //Báo khi chưa thêm nhạc
            }
            else
            {
                currentSong = playlist.GetFirst(); //next của bài cuối sẽ quay về bài đầu
                axWindowsMediaPlayer1.URL = currentSong.element.ToString();
                axWindowsMediaPlayer1.Ctlcontrols.play();
                labelNowPlaying.Text = "Playing: " + Path.GetFileName(currentSong.element.ToString());

                // Đồng bộ SelectedIndex với bài hát hiện tại
                int newIndex = listBoxPlaylist.Items.IndexOf(Path.GetFileNameWithoutExtension(currentSong.element.ToString()));
                listBoxPlaylist.SelectedIndex = newIndex;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Audio Files|*.mp3;*.wav;*.wma",
                Multiselect = true // Cho phép chọn nhiều tệp
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] selectedFiles = ofd.FileNames; // Lấy tất cả các file được chọn

                foreach (string fileName in selectedFiles)
                {
                    string songName = Path.GetFileNameWithoutExtension(fileName); // Tên bài hát không có phần mở rộng

                    if (playlist.GetFirst() == null)
                    {
                        // Thêm bài hát đầu tiên nếu danh sách trống
                        playlist.Insert(fileName, "Header");
                        currentSong = playlist.GetFirst();
                    }
                    else
                    {
                        // Thêm bài hát vào cuối danh sách
                        Node lastNode = playlist.GetFirst();
                        while (lastNode.flink != null)
                        {
                            lastNode = lastNode.flink;
                        }
                        playlist.Insert(fileName, lastNode.element);
                    }

                    // Thêm bài hát vào ListBox hiển thị playlist
                    listBoxPlaylist.Items.Add(songName);

                    // Cập nhật danh sách ban đầu
                    if (originalMusicFiles != null)
                    {
                        originalMusicFiles = originalMusicFiles.Concat(new[] { songName }).ToArray();
                    }
                    else
                    {
                        originalMusicFiles = new[] { songName };
                    }
                }
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (currentSong != null)
            {
                string songToRemove = currentSong.element.ToString();
                playlist.Remove(songToRemove);
                listBoxPlaylist.Items.Remove(Path.GetFileNameWithoutExtension(songToRemove));

                // Sau khi remove thì chạy bài tiếp theo hoặc bài trước
                if (currentSong.flink != null)
                {
                    currentSong = currentSong.flink;
                }
                else if (currentSong.blink != null && currentSong.blink.element.ToString() != "Header")
                {
                    currentSong = currentSong.blink;
                }
                else
                {
                    currentSong = null; 
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    labelNowPlaying.Text = "No song playing";
                    pictureBox1.Image = null;
                    return;
                }

                // Remove xong thì cập nhật bìa nhạc của bài kế tiếp
                axWindowsMediaPlayer1.URL = currentSong.element.ToString();
                axWindowsMediaPlayer1.Ctlcontrols.play();
                labelNowPlaying.Text = "Playing: " + Path.GetFileName(currentSong.element.ToString());
                try
                {
                    TagLib.File file = TagLib.File.Create(currentSong.element.ToString());
                    byte[] bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                    pictureBox1.Image = Image.FromStream(new MemoryStream(bin));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Hoặc Zoom
                }
                catch
                {
                    // Nếu không có bìa nhạc, đặt hình bìa về null
                    pictureBox1.Image = null;
                }
            }
        } 

        private void btn_shuffle_Click(object sender, EventArgs e)
        {
            if (playlist.GetFirst() == null)
            {
                MessageBox.Show("Playlist is empty. You have to add songs before shuffling.");
                return;
            }

            playlist.Shuffle();

            // Cập nhật listbox hiển thị playlist
            listBoxPlaylist.Items.Clear();
            Node current = playlist.GetFirst();
            while (current != null)
            {
                string songName = Path.GetFileNameWithoutExtension(current.element.ToString());
                listBoxPlaylist.Items.Add(songName);
                current = current.flink;
            }

            MessageBox.Show("Playlist shuffled!");
        }
        private void btn_sort_Click(object sender, EventArgs e)
        {
            if (playlist.GetFirst() == null)
            {
                MessageBox.Show("Playlist is empty. You have to add songs before sorting.");
                return;
            }

            playlist.SortAsc();

            // Cập nhật listbox hiển thị playlist
            listBoxPlaylist.Items.Clear();
            Node current = playlist.GetFirst();
            while (current != null)
            {
                string songName = Path.GetFileNameWithoutExtension(current.element.ToString());
                listBoxPlaylist.Items.Add(songName);
                current = current.flink;
            }

            // Cập nhật currentSong sau khi sắp xếp
            if (currentSong != null)
            {
                string currentSongName = Path.GetFileNameWithoutExtension(currentSong.element.ToString());
                Node newCurrent = playlist.GetFirst();
                while (newCurrent != null)
                {
                    if (Path.GetFileNameWithoutExtension(newCurrent.element.ToString()) == currentSongName)
                    {
                        currentSong = newCurrent; // Cập nhật currentSong theo danh sách đã sắp xếp
                        break;
                    }
                    newCurrent = newCurrent.flink;
                }
            }
            MessageBox.Show("Playlist sorted!");
        }
        private void btn_sortDESC_Click(object sender, EventArgs e)
        {
            if (playlist.GetFirst() == null)
            {
                MessageBox.Show("Playlist is empty. You have to add songs before sorting.");
                return;
            }

            playlist.SortDesc();

            // Cập nhật listbox hiển thị playlist
            listBoxPlaylist.Items.Clear();
            Node current = playlist.GetFirst();
            while (current != null)
            {
                string songName = Path.GetFileNameWithoutExtension(current.element.ToString());
                listBoxPlaylist.Items.Add(songName);
                current = current.flink;
            }
            // Cập nhật currentSong sau khi sắp xếp
            if (currentSong != null)
            {
                string currentSongName = Path.GetFileNameWithoutExtension(currentSong.element.ToString());
                Node newCurrent = playlist.GetFirst();
                while (newCurrent != null)
                {
                    if (Path.GetFileNameWithoutExtension(newCurrent.element.ToString()) == currentSongName)
                    {
                        currentSong = newCurrent; // Cập nhật currentSong theo danh sách đã sắp xếp
                        break;
                    }
                    newCurrent = newCurrent.flink;
                }
            }
            MessageBox.Show("Playlist sorted!");
        }
        
        private void listBoxPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPlaylist.SelectedIndex >= 0)
            {
                string selectedSong = listBoxPlaylist.SelectedItem.ToString();
                Node node = playlist.GetFirst();
                int index = 0; //chỉ số của bài hát trong playlist
                while (node != null)
                {
                    if (Path.GetFileNameWithoutExtension(node.element.ToString()) == selectedSong)
                    {
                        currentSong = node;
                        axWindowsMediaPlayer1.URL = node.element.ToString();
                        axWindowsMediaPlayer1.Ctlcontrols.play();

                        labelNowPlaying.Text = "Playing: " + selectedSong;

                        try
                        {
                            TagLib.File file = TagLib.File.Create(node.element.ToString());
                            byte[] bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                            pictureBox1.Image = Image.FromStream(new MemoryStream(bin));
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Hoặc Zoom
                        }
                        catch
                        {
                            // Nếu không có bìa nhạc
                            pictureBox1.Image = null;
                        }
                        break;
                    }
                    node = node.flink; //sang bài kế tiếp, tăng index lên 1
                    index++;
                }
            }
        }
        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            // Tính toán tỷ lệ tốc độ từ TrackBar (từ 0.5x đến 2x)
            double speed = trackBarSpeed.Value / 100.0;

            // Cập nhật tốc độ phát lại của MediaPlayer
            axWindowsMediaPlayer1.settings.rate = speed;

            // Cập nhật nhãn hiển thị tốc độ hiện tại
            labelSpeed.Text = $"Speed: {speed}x";

        }
        
        public static string RemoveDiacritics(string Text) //bỏ dấu của Tiếng Việt đi
        {
            string NormalizedText = Text.Normalize(NormalizationForm.FormD);
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            return regex.Replace(NormalizedText, string.Empty).Normalize(NormalizationForm.FormC);
        }
        bool SearchFlag = true; //biến bool để kiểm soát hàm tìm kiếm
        private string[] originalMusicFiles; // Lưu trữ bản gốc của list trước khi search
        private void search_TextChanged(object sender, EventArgs e)
        {
            if (SearchFlag)
            {
                SearchFlag = false;

                // Lưu trẽ danh sách gốc nếu chưa được lưu trữ
                if (originalMusicFiles == null)
                {
                    originalMusicFiles = listBoxPlaylist.Items.Cast<string>().ToArray();
                }

                // Bỏ dấu của tiếng việt, chuyển thành chữ thường và bỏ những khoảng cách
                string SearchTerm = RemoveDiacritics(search.Text.ToLower().Trim());

                List<string> Result = new List<string>(); //Tạo list Result để lưu tên bài hát nếu tìm ra
                foreach (string FileName in originalMusicFiles)
                {
                    if (!string.IsNullOrEmpty(FileName) && RemoveDiacritics(FileName.ToLower().Trim()).Contains(SearchTerm))
                    {
                        Result.Add(FileName);
                    }
                }

                // Cập nhật lại listBox với những kết quả từ list Result đã search thấy
                listBoxPlaylist.Items.Clear();
                foreach (string file in Result)
                {
                    listBoxPlaylist.Items.Add(file);
                }

                if (string.IsNullOrEmpty(search.Text.Trim())) //khi xóa đi nội dung tìm kiếm trên thanh search, trả tất cả bài hát về listBox như ban đầu
                {
                    listBoxPlaylist.Items.Clear();
                    foreach (string file in originalMusicFiles)
                    {
                        listBoxPlaylist.Items.Add(file);
                    }
                }

                SearchFlag = true;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            // Dừng trình phát nhạc nếu đang phát
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying ||
                axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop(); // Dừng phát nhạc
            }

            playlist.Clear(); //Xóa tất cả dữ liệu bài hát ra khỏi danh sách liên kết
            listBoxPlaylist.Items.Clear(); //Xóa tất cả tên bài hát ra khỏi listBox
            currentSong = null;

            // Xóa thông tin hiển thị
            labelNowPlaying.Text = "No song playing";
            btn_play.Image = btm_play; // Đặt lại trạng thái nút thành "Play"
            pictureBox1.Image = null; // Xóa bìa nhạc nếu có

            // Đặt lại TrackBar và các nhãn thời gian
            trackBarProgress.Value = 0;
            trackBarProgress.Maximum = 0;
            labelTotalTime.Text = "00:00";
            labelCurrentTime.Text = "00:00";

            // Đặt lại TrackBar tốc độ và âm lượng
            trackBarSpeed.Value = 100; // Giá trị mặc định (1x tốc độ)
            axWindowsMediaPlayer1.settings.rate = 1.0; // Đặt tốc độ phát về mặc định
            labelSpeed.Text = "Speed: 1.0x"; // Cập nhật nhãn tốc độ

            trackBarVolume.Value = 50; // Giá trị mặc định (50% âm lượng)
            axWindowsMediaPlayer1.settings.volume = 50; // Đặt âm lượng về mặc định

            originalMusicFiles = null; //Cập nhật dữ liệu gốc về null
            MessageBox.Show("Playlist cleared!");
        }

        private void btn_minus15_Click(object sender, EventArgs e)
        {
            // Tua lại 15 giây
            if (axWindowsMediaPlayer1.Ctlcontrols.currentPosition >= 15)
            {
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition -= 15;
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = 0; // Nếu nhỏ hơn 15s thì về đầu bài
            }
        }

        private void btn_add15_Click(object sender, EventArgs e)
        {
            // Tua tới 15 giây
            if (axWindowsMediaPlayer1.Ctlcontrols.currentPosition + 15 <= axWindowsMediaPlayer1.currentMedia.duration)
            {
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition += 15;
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = axWindowsMediaPlayer1.currentMedia.duration; // Nếu vượt quá thì về cuối bài
            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8) // MediaEnded state, trạng thái mặc định sau khi chơi hết bài
            {
                // Gọi method để tự động chơi bài tiếp theo
                PlayNextSong();
                UpdateTrackBarAndLabels(); // Cập nhật label và thanh tua thời gian
            }
        }
        private void PlayNextSong() //Tự động sang bài khi bài đang phát kết thúc
        {
            if (currentSong != null && currentSong.flink != null)
            {
                // Chuyển sang bài tiếp theo trong list
                currentSong = currentSong.flink;
            }
            else if (currentSong == null || currentSong.flink == null)
            {
                // Nếu đến bài cuối thì quay lại bài đầu
                currentSong = playlist.GetFirst();
            }
            if (currentSong != null)
            {
                // Set đường dẫn URL của bài tiếp theo
                axWindowsMediaPlayer1.URL = currentSong.element.ToString();

                // Hoãn hành động trong 200ms trước khi thực hiện play
                Task.Delay(200).ContinueWith(t =>
                {
                    // Bắt đầu chơi bài kế tiếp
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                });

                // Cập nhật label 
                labelNowPlaying.Text = "Playing: " + Path.GetFileName(currentSong.element.ToString());
                int newIndex = listBoxPlaylist.Items.IndexOf(Path.GetFileNameWithoutExtension(currentSong.element.ToString()));
                listBoxPlaylist.SelectedIndex = newIndex;

                // Cập nhật speed
                trackBarSpeed.Value = (int)(axWindowsMediaPlayer1.settings.rate * 100);
                labelSpeed.Text = $"Speed: {axWindowsMediaPlayer1.settings.rate}x";

            }
        }
        private void UpdateTrackBarAndLabels()
        {
            if (axWindowsMediaPlayer1.currentMedia != null)
            {
                // Cập nhật giá trị TrackBar
                trackBarProgress.Maximum = (int)axWindowsMediaPlayer1.currentMedia.duration;
                trackBarProgress.Value = 0;

                // Cập nhật nhãn thời gian
                labelTotalTime.Text = TimeSpan.FromSeconds(axWindowsMediaPlayer1.currentMedia.duration).ToString(@"mm\:ss");
                labelCurrentTime.Text = "00:00";
            }
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            // Điều chỉnh âm lượng
            axWindowsMediaPlayer1.settings.volume = trackBarVolume.Value;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                // Cập nhật thời gian tối đa theo thời lượng bài hát
                if (axWindowsMediaPlayer1.currentMedia != null)
                {
                    trackBarProgress.Maximum = (int)axWindowsMediaPlayer1.currentMedia.duration;
                    trackBarProgress.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;


                    // Cập nhật thời lượng hiện tại và thời lượng bài hát
                    labelCurrentTime.Text = TimeSpan.FromSeconds(axWindowsMediaPlayer1.Ctlcontrols.currentPosition).ToString(@"mm\:ss");
                    labelTotalTime.Text = TimeSpan.FromSeconds(axWindowsMediaPlayer1.currentMedia.duration).ToString(@"mm\:ss");
                }
            }
        }

        private void trackBarProgress_Scroll(object sender, EventArgs e)
        {
            // Điều chỉnh tiến trình thời lượng bài hát
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = trackBarProgress.Value;
        }

        private void btnAvatar_Click(object sender, EventArgs e) //Cho người dùng cập nhật ảnh đại diện
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    image1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("not supported files"/*, MessageBoxButtons.OK, MessageBoxIcon.Error*/);
            }
        }
    }
}
