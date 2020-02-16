using NUnit.Framework;

namespace ViolationExample
{
    public class PostconditionsBase
    {
        public virtual int Call()
        {
            int result;
            //code
            result = 2;
            //code
            Assert.IsTrue(result >= 1);
            return result;
        }
    }
    public class PostconditionsDerived : PostconditionsBase
    {
        public override int Call()
        {
            int result;
            //code
            result = 0;
            //code
            Assert.IsTrue(result >= 0);
            return result;
        }
    }

    //Jak widać, typ Derived może zwrócić liczbę 0, która to nie jest dozwolona dla typu Base. Zatem warunki końcowe są mniej restrykcyjne w typie Derived niż w typie Base
    //Typ Derived musi wpasować się w ograniczenia narzucone w typie Base.
    public class Postconditions
    {
        public void Run()
        {
            PostconditionsBase a = new PostconditionsBase();
            PostconditionsBase b = new PostconditionsDerived();
            var result = 1 / a.Call();
            result  = 1 / b.Call(); //Unhandled Exception: System.DivideByZeroException
        }
    }
}
