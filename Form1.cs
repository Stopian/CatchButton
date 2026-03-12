using System.Media;
using System.IO;
namespace CatchButton
{
    public partial class Form1 : Form
    {
        int score = 0; //게임의 점수

        public Form1()
        {
            InitializeComponent();
        }

        private async void catchMeButton_MouseEnter(object sender, EventArgs e)
        {
            /*
            int x_position = 100;
            int y_position = 150;

            catchMeButton.Location = new Point(x_position, y_position);
            */


            Random rd = new Random(); //  난수생성기준비

            await Task.Delay(100);  // 0.1초 대기 (버튼이 너무 빨리 움직이는 것을 방지)

            int maxX = this.ClientSize.Width; //가용한 최대 X좌표 (버튼 크기 고려 X)
            int maxY = this.ClientSize.Height;//가용한 최대 Y좌표 (버튼 크기 고려 X)

            int nextX = rd.Next(0, maxX - 267); // 0부터 maxX-1까지의 난수 생성 (버튼의 너비 267 고려)
            int nextY = rd.Next(0, maxY - 91); // 0부터 maxY-1까지의 난수 생성 (버튼의 높이 91 고려)

            catchMeButton.Location = new Point(nextX, nextY); //버튼 위치 변경

            this.Text = $"점수: {score} | 버튼 위치: ({nextX}, {nextY})"; //점수와 버튼 위치를 폼의 제목에 표시
            try
            {
                PlaySound(Properties.Resources.walk);
            }
            catch { }
            
            }

        private void catchMeButton_MouseDown(object sender, MouseEventArgs e)
        {
            SystemSounds.Asterisk.Play();

            score += 100;

            PlaySound(Properties.Resources.star);

            MessageBox.Show("축하합니다~!");

            MessageBox.Show("축하합니다~!");// 메시지 박스

        }
        private void PlaySound(byte[] soundData) // byte 배열로부터 사운드를 재생하는 메서드
        {
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(soundData))
            {
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer(ms);
                sp.Play();
            }
        }
    }
}
