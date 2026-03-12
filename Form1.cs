using System.Media;
namespace CatchButton
{
    public partial class Form1 : Form
    {
        int score = 0; //게임의 점수
        public Form1()
        {
            InitializeComponent();
        }

        private void catchMeButton_MouseEnter(object sender, EventArgs e)
        {
            /*
            int x_position = 100;
            int y_position = 150;

            catchMeButton.Location = new Point(x_position, y_position);
            */


            Random rd = new Random(); //  난수생성기준비

            int maxX = this.ClientSize.Width; //가용한 최대 X좌표 (버튼 크기 고려 X)
            int maxY = this.ClientSize.Height;//가용한 최대 Y좌표 (버튼 크기 고려 X)

            int nextX = rd.Next(0, maxX - 267); // 0부터 maxX-1까지의 난수 생성 (버튼의 너비 267 고려)
            int nextY = rd.Next(0, maxY - 91); // 0부터 maxY-1까지의 난수 생성 (버튼의 높이 91 고려)

            catchMeButton.Location = new Point(nextX, nextY); //버튼 위치 변경

            this.Text = $"버튼위치: ({nextX}, {nextY})"; // 폼의 제목에 버튼의 위치 표시

            this.Text = "점수 : " + score; // 폼의 제목에 게임 점수 표시

            /*SoundPlayer player = new SoundPlayer("escape.mp3"); // 버튼이 움직일 때 효과음
            player.Play();
            */
        }

        private void catchMeButton_MouseDown(object sender, MouseEventArgs e)
        {
            /*
            SoundPlayer player = new SoundPlayer("success.mp3");// 잡았을 때 효과음
            player.Play();*/

            score += 100;

            this.Text = "점수 : " + score;

            MessageBox.Show("축하합니다~!");

            MessageBox.Show("축하합니다~!");// 메시지 박스

        }
    }
}
