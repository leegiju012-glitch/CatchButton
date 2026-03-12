namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void moving_button_MouseEnter(object sender, EventArgs e)
        {
            // 1.난수생성기준비
            Random rd = new Random();
            // 2. 가용영역계산(버튼이폼테두리에걸리지않게보호) ClientSize는타이틀바와테두리를제외한실제흰도화지영역임
            int maxX = this.ClientSize.Width - moving_button.Width; int maxY = this.ClientSize.Height - moving_button.Height;
            // 3. 랜덤좌표추출(0 ~ 최대가용치사이)
            int nextX = rd.Next(0, maxX); int nextY = rd.Next(0, maxY);
            // 4. 위치할당(새로운Point 객체생성)
            moving_button.Location = new Point(nextX, nextY);
            // 5. 시각적피드백(폼제목표시줄에좌표출력)
            this.Text = $"버튼위치: ({nextX}, {nextY})";
            // 6. 버튼이 도망갈 때 비프음 재생
            System.Media.SystemSounds.Beep.Play();
        }

        private void moving_button_Click(object sender, EventArgs e)
        {
            // 버튼을 클릭했을 때 비프음 재생과 동시에 축하 메세지 출력
            System.Media.SystemSounds.Asterisk.Play();
            MessageBox.Show("축하합니다~!","성공", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
