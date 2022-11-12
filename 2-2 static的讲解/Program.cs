using System;

namespace _2_2_static的讲解
{
    class Student
    {
        public string name;
        public int def;


         //......
        public static int totalStudents = 0;

        public Student(string name, int def)
        {
            this.name = name;
            this.def = def;
        }

    }

   
class Program
    {
        static Random random;   // Random 是绑定在Program上面的，一开始没有接触面向对象的时候写的一些函数比如static int[] DoubleElement(int[] array)这些都是使用静态，在Main函数中调用的
        static void Main(string[] args)
        {
            /* 一个玩家可以绑定一个背包，一个背包可以绑定三个道具，而每个道具可以绑定次数等等
             * 如果一个玩家消失了，那么对应的后面的信息也直接消失了，这是串联的关系
             * 但是有些名词可以超越个体的概念而存在，比如人口，即便地球毁灭，但是人口这个单词依然是存在的，只是此时的人口数量为0
             * 
             * Console.Write("dddddd"); 静态方法脱离了主语，不属于对象方法。Console就属于是类，主语就是这个类型
          
             */

            random = new Random();

            Student s1 = new Student("小明", 70);
            Student.totalStudents++;
            Student s2 = new Student("小红", 80);
            Student.totalStudents++;


        }
    }
}
