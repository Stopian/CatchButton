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
            int x_position = 100;
            int y_position = 150;

            catchMeButton.Location = new Point(x_position, y_position);
        }
    }
}
