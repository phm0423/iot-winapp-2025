// using... 네임스페이스 추가
// C,C++ #include / Python import 와 동일
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;   // 진단네임스페이스 Debug클래스포함
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxWinApp02
{
    internal class MobileDevice
    {
        public MobileDevice() { }
    }

    // sealed 더이상 자식 클래스를 만들고 싶지 않을 때
    internal class Computer
    {
        public Computer() {
            Debug.WriteLine("Computer 객체 생성1");
            Console.WriteLine("Computer 객체 생성2");
        }

        bool powerOn;
        public void Boot()
        {
            Console.WriteLine("컴퓨터 부팅");
        }
        public void shutDown() 
        {
            Console.WriteLine("컴퓨터 셧다운!!");
        }
        public void Reset() { }

    }
    // C++에서는 다중상속이가능
    // Java, C#은 다중상속을 막음
    internal class NoteBook: Computer, IMobile, IMessageFilter, IOrderedQueryable
    {
        public void Call()
        {
            Console.WriteLine("노트북으로 전화걸기");
        }

        public string GetList()
        {
            string phoneList = "010-999-9900;010-8888-7777;";
            return phoneList;
        }

        // 부모클래스 ShutDown을 자식 클래스에서 재정의
        public void shutDown()
        {
            Console.WriteLine("노트북 닫기");
        }
        public NoteBook()
        {
            Console.WriteLine("NoteBook 객체 생성");
            base.Boot();    // 부모클래스의 Boot() 메서드 실행
        }


        bool fingerScan; // 지문인식

        public Type ElementType => throw new NotImplementedException();

        public Expression Expression => throw new NotImplementedException();

        public IQueryProvider Provider => throw new NotImplementedException();

        // 파라미터가 없는 메서드
        public bool HasFingerScanDevice() { return this.fingerScan; }

        // 파라미터가 있는 메서드
        public bool HasFingerScanDevice(bool fingerScan)
        {
            this.fingerScan = fingerScan;
            return this.fingerScan;
        }

        public bool PreFilterMessage(ref Message m)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    internal class Server: Computer
    {
        public string Name { get; set; } // 이름 속성 추가
        public Server(){Console.WriteLine("Server 객체 생성");}

        bool storage; // 스토리지
        public bool HasStoreage() { return this.storage; }

        // 깊은 복사 메서드
        public Server DeepCopy()
        {
            return new Server { Name = this.Name };
        }
    }
}
