using System.Threading.Tasks;

namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        // async 비동기로 동작하는 메서드라고 선언
        // async, await는 항상 같이 사용
        private async void BtnStart_Click(object sender, EventArgs e)
        {
            // *: UI스레드가 관리
            LblCurrState.Text = "현재상태: 진행"; // ui처리
            BtnStart.Text = "진행중";  // ui처리
            BtnStart.Enabled = false; // 못쓰게 함  // ui처리

            // 엄청난 시간이 걸리는 연산을 수행
            long MaxVal = 200;
            long total = 0;
            PrgProcess.Minimum = 0; // ui처리
            PrgProcess.Maximum = 100;   // ui처리

            // await 사용
            await Task.Run(() =>
            {
                for (int i = 0; i < MaxVal; i++)
                {
                    total += i % 3;

                    int progress = (int)(i * 100 / MaxVal) + 1;
                    // UI스레드 내에 있는 제어를 하도록 처리하는 메서드
                    Console.WriteLine(progress.ToString());
                    this.Invoke(new Action(() =>
                    {
                        TxtLog.Text += i.ToString() + "\r\n";
                        TxtLog.SelectionStart = TxtLog.Text.Length;
                        TxtLog.ScrollToCaret(); // 스크롤을 제일 밑으로
                        PrgProcess.Value = progress;
                                          // Application.DoEvents();  // 권장하지 않음
                    }));
                    Thread.Sleep(50); // 50ms 동안 대기(대량의 일을 처리하는 것 처럼)
                }
            });


                LblCurrState.Text = "현재상태: 중지";
            BtnStart.Text = "시작";
            BtnStart.Enabled = true;
        }
    }
}
