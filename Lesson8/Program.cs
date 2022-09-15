using System;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public void LogicMethod()
        {
            var value1 = 1;
            var value2 = 1;
            bool boolen = value1 == value2;

            if (value1 == 2) { }
            if (value1 != 1) { }
            if (value1 > 1) { }
            if (value1 >= 1) { }
            if (value1 <= 1) { }
            if (value1 < 1) { }

            if (!boolen) { } //Инвертация условного запроса (логическое отрицание)

            if (value1 < 0 && value1 != -1) { } //Сложение условий
            if (value1 < 0 || value1 == 0) { } //Условие "Или", если один вариант верный итог будет True

            if (false || false) { } //false
            if (true && false) { } //false
            if (true && true) { } //true
            if (false || false) { } //false
            if (true || false) { } //true
            if (true || true) { } //true

            string str = null;

            if (str != null && str.Length > 3) { }
            if (str.Length > 3 && str != null) { } //Будет ошибка (у null нет длины значения)

            int r1 = 2;
            int r2 = 4;
            int r3 = 10;
            if (r1 == 1 && (r2 < 10 || r3 > 20)) { } //Комбинация
            
            if (value1 < 0 && value1 != -1) { }

            myClass _myClassTest = new myClass();
            MyStruct _myStruct = new MyStruct();

            if (_myClassTest is myClass) { } //проверка на тип переменной
            if (_myClassTest.GetType() == typeof(myClass)) { } //проверка на тип переменной

            var test1 = _myClassTest as MyParent; //присвоение класса переменной    
            var test2 = (MyParent)_myClassTest;
        }
    }

    class myClass: MyParent { }

    class MyParent { }

    struct MyStruct { }
}
