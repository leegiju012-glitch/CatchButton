using System.Drawing.Text;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        //현재 점수 저장
        private int score = 1000;

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
            // 5. 시각적피드백(폼제목표시줄에좌표출력,점수 표시)
            this.Text = $"점수: {score} - 버튼위치: ({nextX}, {nextY})";
            // 6. 버튼이 도망갈 때 비프음 재생
            System.Media.SystemSounds.Beep.Play();
            // 7. 점수 감소 
            score -= 10;
        }

        private void moving_button_Click(object sender, EventArgs e)
        {
            // 8. 점수 증가

            score += 100;
            // 9. 버튼 크기 감소 
            int newW = Math.Max(30, (int)(moving_button.Width * 0.9));
            int newH = Math.Max(20, (int)(moving_button.Height * 0.9));
            moving_button.Size = new Size(newW, newH);
            //점수판 갱신
            this.Text = $"점수: {score}";
            // 버튼을 클릭했을 때 비프음 재생과 동시에 축하 메세지 출력
            System.Media.SystemSounds.Asterisk.Play();
            MessageBox.Show("축하합니다~!","성공", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
