using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace1//名前空間1
{
    public class Class1//名前空間1のクラス1
    {
        static void Main(string[] args)//メインメソッド
        {
            Namespace1.Class1.test();//名前空間1のクラス1のメソッドtest()を呼ぶ
            Namespace2.Class1.test();//名前空間2のクラス1のメソッドtest()を呼ぶ
            Console.WriteLine("何かキーを入力してください");
            Console.ReadKey();
        }

        public static void hello()//名前空間1のメソッドhello()
        {
            Console.WriteLine("Namespace1のClass1のhello()");
        }

        public static void test()//名前空間1のメソッドtest()
        {
            hello();
            //名前空間1と2に同名のメソッドが存在するが、特に指定をしていないため
            //ここでは同じ名前空間に属する名前空間1のメソッドhello()が呼ばれる

            Class1.hello();
            //名前空間1と2に同名のクラスが存在するが、特に指定をしていないため
            //ここでは同じ名前空間に属する名前空間1のクラス1のメソッドhello()が呼ばれる

            Namespace1.Class1.hello();
            //名前空間から指定しているため、名前空間1のクラス1のメソッドhello()が呼ばれる

            Namespace2.Class1.hello();
            //名前空間から指定しているため、名前空間2のクラス1のメソッドhello()が呼ばれる
        }
    }
}

namespace Namespace2//名前空間2
{
    public class Class1//名前空間2のクラス1
    {
        public static void hello()//名前空間2のメソッドhello()
        {
            Console.WriteLine("Namespace2のClass1のhello()");
        }

        public static void test()//名前空間2のメソッドtest()
        {
            hello();
            //名前空間1と2に同名のメソッドが存在するが、特に指定をしていないため
            //ここでは同じ名前空間に属する名前空間2のメソッドhello()が呼ばれる

            Class1.hello();
            //名前空間1と2に同名のクラスが存在するが、特に指定をしていないため
            //ここでは同じ名前空間に属する名前空間2のクラス1のメソッドhello()が呼ばれる

            Namespace1.Class1.hello();
            //名前空間から指定しているため、名前空間1のクラス1のメソッドhello()が呼ばれる

            Namespace2.Class1.hello();
            //名前空間から指定しているため、名前空間2のクラス1のメソッドhello()が呼ばれる
        }
    }
}