using System.IO;
using System.Media;
using static System.Net.Mime.MediaTypeNames;
namespace CatchButton
{
    public partial class Form1 : Form
    {
        int score = 0; //게임의 점수
        int MissCount = 0;  //놓친 횟수
        Random rd = new Random(); //  난수생성기준


        public Form1()
        {
            InitializeComponent();
        }

        private async void catchMeButton_MouseEnter(object sender, EventArgs e)
        {

            if (score > 0)
            {
                score -= 10; //점수 감소
            }

            await Task.Delay(40);  // 0.4초 대기 (버튼이 너무 빨리 움직이는 것을 방지)

            int maxX = this.ClientSize.Width; //가용한 최대 X좌표 (버튼 크기 고려 X)
            int maxY = this.ClientSize.Height;//가용한 최대 Y좌표 (버튼 크기 고려 X)

            int nextX = rd.Next(0, maxX - catchMeButton.Width); // 0부터 maxX-1까지의 난수 생성 (버튼의 너비 고려)
            int nextY = rd.Next(0, maxY - catchMeButton.Height); // 0부터 maxY-1까지의 난수 생성 (버튼의 높이 고려)

            catchMeButton.Location = new Point(nextX, nextY); //버튼 위치 변경

            this.Text = $"점수: {score} | 버튼 위치: ({nextX}, {nextY})"; //점수와 버튼 위치를 폼의 제목에 표시
            PlaySound(Properties.Resources.walk);
            ++MissCount;   //놓친 횟수 증가

            if (MissCount >= 20)
            {
                GameOver(); // 게임 오버 처리
                MessageBox.Show("게임 오버! 놓친 횟수가 20회 이상입니다.");

            }

        }


        private void catchMeButton_MouseDown(object sender, MouseEventArgs e)
        {
            SystemSounds.Asterisk.Play();

            score += 100;

            PlaySound(Properties.Resources.star);

            MessageBox.Show("축하합니다~!");// 메시지 박스
            catchMeButton.Width = (int)(catchMeButton.Width * 0.9); //버튼의 너비를 10% 줄임   
            catchMeButton.Height = (int)(catchMeButton.Height * 0.9); //버튼의 높이를 10% 줄임
            float FontNewSize = catchMeButton.Font.Size * 0.9f;
            catchMeButton.Font = new System.Drawing.Font(catchMeButton.Font.FontFamily,
                FontNewSize, catchMeButton.Font.Style); //버튼의 폰트 크기를 10% 줄임
        }
        private void PlaySound(byte[] soundData) // byte 배열로부터 사운드를 재생하는 메서드
        {
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(soundData))
            {
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer(ms);
                sp.Play();
            }
        }
        private void GameOver()
        {
            catchMeButton.Enabled = false; // 버튼 비활성화
            catchMeButton.Visible = false;
            lastScore.Visible = true; // 최종 점수 보이기
            lastScore.Text = $"최종 점수: {score}"; // 최종 점수 표시
            GameOverButton.Visible = true; // 게임 오버 버튼 보이기
            GameOverButton.Enabled = true;

        }

        private void GameOverButton_MouseDown(object sender, MouseEventArgs e)
        {
            GameOverButton.Visible = false;
            GameOverButton.Enabled = false;

            score = 0; //점수 초기화
            MissCount = 0; //놓친 횟수 초기화
            this.Text = "점수 : 0";
            catchMeButton.Visible = true; // 버튼 보이기
            catchMeButton.Enabled = true;
            lastScore.Visible = false; // 최종 점수 숨기기

            catchMeButton.Location = new Point(this.ClientSize.Width / 2 - catchMeButton.Width / 2,
                this.ClientSize.Height / 2 - catchMeButton.Height / 2); // 버튼 위치를 폼의 중앙으로 설정

            catchMeButton.Size = new Size(267, 91); //버튼 크기를 초기값으로 설정
            catchMeButton.Font = new System.Drawing.Font(catchMeButton.Font.FontFamily, 15); //버튼 폰트 크기를 초기값으로 설정

        }
    }
}
