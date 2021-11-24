using System;

namespace ConsoleApp11abstract
{

    //يستخدم لتجهيز الشغل
    //لا استطيع ان اعمل منه اوبجكت
    //انا اعمل  علشان اخلي  كلاسات  اخري تقوم بوراثه
    //استطيع ان  اعمل  متغيرات ان ابني  شغل  عادي
    //الحاجة الابستراكت يجب ان اضعها  في كلاس ابستراكت
    //يعني مثود او بروبرتي ابستراكت يجب ان اضعها في كلاس ابستراكت
    //استطيع ان اعمل  مثود وبروبرتي
    abstract class BasePerson : Class1
    {
        //protected معناه ان العنصر يظهر في الكلاس الموجود فيه وفي الكلاسات الوارثه من هذا الكلاس

        protected string _Name;
        public string Address;

        //  public string Name
        // { get { return _Name; } set { _Name = value; } }

        //اذا جعلت البروبرتي ابستراكت فيجب ان اكتبها بهذه الطريقه

        public abstract string Name
        { get; set; }

        //هذة البروبرتي سوف تبني في الكلاس الذي سوف يرت الابستراكت كلاس

        public abstract void printData();
        //{}هذه المثود  لانها ابستراكت  تكتب هكذا  فقط  ولا يجوزان اضع لها تلك الاقواس
        // لانها  ابستراكت وسوف تبني في الكلاسات التي تقوم بوراثه
        //استطيع ان اعمل حاجات عاديه وحاجات ابستراكت في نفس الوقت داخل الابستراكت كلاس

        public void Test()
        {
            i1 = 1;
            i2 = 2;
        }

    }



    class Employee : BasePerson
    {
        public override string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public override void printData()
        {
            Console.WriteLine(_Name + ";" + Address);
        }
    }


    class Class1
    {
        protected int i1;
        protected int i2;
    }



    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Name = "khaled";
            e1.Address = "cairo";
            e1.printData();
        }
    }
}
