using System.Drawing.Text;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 초기 버튼 상태와 난수 생성기 초기화
            initialButtonSize = moving_button.Size;
            initialButtonLocation = moving_button.Location;
            rd = new Random();
        }
        //현재 점수 저장
        private int score = 1000;

        // 난수 재사용을 위한 필드
        private Random rd;

        //버튼 놓친 횟수
        private int missCount = 0;

        //버튼 놓칠 수 있는 최대횟수
        private const int MAX_MISSES = 20;

        //초기 버튼 상태
        private Size initialButtonSize;
        private Point initialButtonLocation;


        private void moving_button_MouseEnter(object sender, EventArgs e)
        {
            // 1.난수생성기준비
            //Random rd = new Random();
            // 2. 가용영역계산(버튼이폼테두리에걸리지않게보호) ClientSize는타이틀바와테두리를제외한실제흰도화지영역임
            int maxX = this.ClientSize.Width - moving_button.Width; int maxY = this.ClientSize.Height - moving_button.Height;
            // 3. 랜덤좌표추출(0 ~ 최대가용치사이)
            int nextX = rd.Next(0, maxX); int nextY = rd.Next(0, maxY);
            // 4. 위치할당(새로운Point 객체생성)
            moving_button.Location = new Point(nextX, nextY);
            // 5. 버튼이 도망갈 때 비프음 재생
            System.Media.SystemSounds.Beep.Play();
            // 6. 점수 감소 
            score = Math.Max(0, score - 10);
            //MissCount 증가
            missCount++;
            // 7. 시각적피드백(폼제목표시줄에좌표출력,점수 표시)
            this.Text = $"점수: {score} - 버튼위치: ({nextX}, {nextY}) - 놓친횟수: {missCount}";
            //게임 오버 
            if (missCount >= MAX_MISSES)
            {
                MessageBox.Show("Game Over", "게임 종료");

                // 버튼 비활성화
                moving_button.Enabled = false;
            }
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
            MessageBox.Show("축하합니다~!", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            // 점수 초기화
            score = 1000;

            // 놓친 횟수 초기화
            missCount = 0;

            // 버튼 크기 초기화
            moving_button.Size = initialButtonSize;

            // 버튼 위치 초기화
            moving_button.Location = initialButtonLocation;

            // 버튼 다시 활성화
            moving_button.Enabled = true;

            // 제목 초기화
            this.Text = "Catch Button Game";
        }
    }
}
