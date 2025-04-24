namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        // 대리자(delegate) 선언
        delegate void MyDelegate(string msg);
        // 이벤트
        public delegate void MyEventHandler(object sender, EventArgs e);
        public event MyEventHandler SomethingHappend; // 이벤트 선언

        // 대리자에서 호출할 메서드 - 대리자와 파라미터가 일치

        void SayHello(string msg)
        {
            MessageBox.Show($"안녕, {msg}", "메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void SayGoodbye(string msg)
        {
            MessageBox.Show($"내일봐~ {msg}", "메시지", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      
        public FrmMain()
        {
            InitializeComponent();
            Console.WriteLine("1. 폼 생성자 실행");
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            Console.Write("2. 폼로드 이벤트 실행");
        }
        private void FrmMain_Shown(object sender, EventArgs e) {
            Console.Write("4. 폼숀 이벤트 실행");
        }
        private void FrmMain_Activated(object sender, EventArgs e) {
            Console.Write("3. 폼액티베이트 이벤트 실행");
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e) {
            Console.Write("5. 폼클로징 이벤트 실행");
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e) {
            Console.Write("6. 폼클로즈드 이벤트 실행");
        }
        
        private void BtnCheck_Click(object sender, EventArgs e);
        {
        // 1. 직접 호출
        SayHello("Hugo");
        SayGoodbye("Hugo"); // 메서드를 따로 호출

        // 2. 대리자 호출
        MyDelegate del = SayHello;  // 대리자에 호출할 메서드를 묶어줌
        del += SayGoodbye; // 추가도 가능(대리자 체인 추가)
            del -= SayHello; // (대리자 체인 삭제)
            del("Ashely");

        // 3. 반환값 없는 대리자 - Action(보기만 하세요)
        Action<string> act = SayHello;
        act("Chris");

        // 4. 반환값 있는 대리자 - Func(보기만 하세요)
        Func<int, int, int> add = (a, b) => a + b;
        int result = add(7, 8);
        Console.WriteLine(result);

            // 이벤트 실행
            if (SomethingHappend != null)
            {
                SomethingHappend(this, EventArgs.Empty); // 이벤트 실행

    }
}
