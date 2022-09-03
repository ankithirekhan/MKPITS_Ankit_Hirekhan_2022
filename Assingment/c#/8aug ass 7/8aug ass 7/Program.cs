using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*create a class student having fields,rno,name,mathsmarks,chemmarks,phymarks total,per,grade and method
result to calculate and display total,per,and grade*/
namespace _8aug_ass_7
{
    class student
    {
        int rno, mathsmarks, chemmarks, phymarks;
        string name, grade;
        public void calculate(int rno,int mathsmarks,int chemmarks,int phymarks, string name,string grade)
        {
            this.rno = rno;
            this.mathsmarks = mathsmarks;
            this.chemmarks = chemmarks;
            this.phymarks=phymarks;
            this.name = name;
            this.grade = grade;

        }
            

    }
        

    internal class Program
    {
        static void Main(string[] args)
        {
            student student = new student();
            Console.WriteLine("enter rno: ");
            int  rno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter mathmarks: ");
            int rno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter chem: ");
            int rno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter physics : ");
            int rno = Convert.ToInt32(Console.ReadLine());
        }
    }
}
