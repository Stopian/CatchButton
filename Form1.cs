namespace CatchButton
{
    public partial class Form1 : Form
    {
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

            int nextX = rd.Next(0, maxX); // 0부터 maxX-1까지의 난수 생성
            int nextY = rd.Next(0, maxY); // 0부터 maxY-1까지의 난수 생성

            catchMeButton.Location = new Point(nextX, nextY); //버튼 위치 변경

            this.Text = $"버튼위치: ({nextX}, {nextY})"; // 폼의 제목에 버튼의 위치 표시

        }
    }
}
