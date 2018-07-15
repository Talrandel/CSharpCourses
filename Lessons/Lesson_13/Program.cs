using System;

namespace Lesson_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.UnivercityName = "МАИ";
            StudentWithoutUnivercity another_student = new StudentWithoutUnivercity();

            Teacher t = new Teacher();
            t.SubjectName = "Математический анализ";
            ParttimeTeacher pt = new ParttimeTeacher();
            pt.SubjectName = "ПнЯВУ";
            StudentTeacher st = new StudentTeacher();
            st.UnivercityName = "МАИ";
            st.SubjectName = "ТВиМС";

            //s.Study();
            //Console.WriteLine();
            //t.Teach();
            //Console.WriteLine();
            //pt.Teach();
            //Console.WriteLine("\n\n\n");

            //ITeacher it = t;
            //it.Teach();
            Console.WriteLine("\n\n\n");

            //ITeacher[] teachers = { t, pt, st};
            //for (int i = 0; i < teachers.Length; i++)
            //{
            //    teachers[i].Teach();
            //}

            //Console.WriteLine("\n\n\n");
            //IStudent[] students = { s, another_student, st};
            //for (int i = 0; i < students.Length; i++)
            //{
            //    students[i].Study();
            //}

            //ITeacher it2 = another_student as ITeacher;
            //if (it2 != null)
            //{
            //    it2.Teach();
            //}

            //if (another_student is ITeacher)
            //{
            //    ITeacher it4 = another_student as ITeacher;
            //    it4.Teach();
            //    Console.WriteLine("another_student реализует ITeacher");
            //}
            //else
            //    Console.WriteLine("another_student не реализует ITeacher");

            //ITeacher it3 = st as ITeacher;
            //it3.Teach();

            //IStudent ist = st as IStudent;
            //ist.Study();

            //st.Study();
            //st.Teach();

            StudentPupil sp = new StudentPupil();
            IStudent student1 = sp;
            IPupil pupil1 = sp;

            (sp as IStudent).Study();
            student1.Study();

            ((IPupil)sp).Study();
            pupil1.Study();

            Console.WriteLine();
            Console.WriteLine();

            CoolerStudentPupil csp = new CoolerStudentPupil();
            csp.Study();
            Console.WriteLine();
            (csp as IStudent).Study();
            ((IPupil)csp).Study();

            Console.Read();
        }
    }

    #region Account

    class BankAccount
    {
        public int MoneyAmount { get; set; }

        public int ExistingDays { get; set; }
    }

    class MicroAccount : BankAccount
    {
        // Ограничение на количество денег и время жизни счета
    }

    class ImmutableAccount : BankAccount
    {
        // Нельзя ни вкладывать, ни снимать деньги
    }

    class ReplenishAccount : BankAccount
    {
        // Можно только вкладывать
    }

    class TrustAccount : BankAccount
    {
        // Без пополнения. Только снятие
    }

    class FullAccessAccount : BankAccount
    {
        // А с этим можно делать все, что угодно
    } 
    #endregion

    // Реализация интерфейса
    class Teacher : ITeacher
    {
        private string _subjectName;
        public string SubjectName
        {
            get { return _subjectName; }
            set { _subjectName = value; }
        }

        public void Teach()
        {
            Console.WriteLine("Я преподаватель на полную ставку. Преподаю предмет " + SubjectName);
        }

        public void DoSomeOtherJob()
        {
            Console.WriteLine("Заполнение бумажек на кафедре.");
        }
    }

    class ParttimeTeacher : ITeacher
    {
        public string SubjectName { get; set; }

        public void Teach()
        {
            Console.WriteLine("Я преподаватель на полставки. Преподаю предмет " + SubjectName);
        }
    }


    class Student : IStudentWithUnivercity
    {
        public string UnivercityName { get; set; }

        public void Study()
        {
            Console.WriteLine("Я студент и я учусь в " + UnivercityName);
        }
    }

    class StudentWithoutUnivercity : IStudent
    {
        public void Study()
        {
            Console.WriteLine("Я необычный студент, я не учусь в институте, я учусь дома. Поэтому UnivercityName у меня пустой.");
        }
    }

    class StudentTeacher : ITeacher, IStudentWithUnivercity
    {
        public string SubjectName { get; set; }

        public string UnivercityName { get; set; }

        public void Study()
        {
            Console.WriteLine("Я студент-преподаватель и я учусь в " + UnivercityName);
        }

        public void Teach()
        {
            Console.WriteLine("Я преподаватель-студент. Преподаю предмет " + SubjectName);
        }
    }

    public class StudentPupil : IStudent, IPupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Study - StudentPupil");
        }

        void IPupil.Study()
        {
            Console.WriteLine("Study - IPupil");
        }

        void IStudent.Study()
        {
            Console.WriteLine("Study - IStudent");
        }
    }

    public class CoolerStudentPupil : StudentPupil, IStudent
    {
        public override void Study()
        {
            base.Study();
            Console.WriteLine("Study - CoolerStudentPupil");
        }

        void IStudent.Study()
        {
            Console.WriteLine("\n Неожиданный результат!");
            Console.WriteLine("Study - CoolerStudentPupil");
        }
    }













    interface ITeacher
    {
        string SubjectName { get; set; }

        void Teach();
    }

    interface IStudent
    {
        void Study();
    }

    interface IPupil
    {
        void Study();
    }

    interface IStudentWithUnivercity : IStudent
    {
        string UnivercityName { get; set; }
    }
}