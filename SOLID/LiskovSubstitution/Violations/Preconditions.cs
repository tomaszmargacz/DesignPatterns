using NUnit.Framework;

namespace ViolationExample
{
    public class PreconditionsBase
    {
        public virtual void Call(int x)
        {
            Assert.IsTrue(x >= 5);
        }
    };

    //W podtypie nie można wzmocnić warunków wstępnych
    //Podtyp nie może być bardziej wybredny niż typ bazowy, musi umieć obsłużyć przynajmniej taki sam zakres danych
    class PreconditionsDerived : PreconditionsBase
    {
        public override void Call(int x)
        {
            Assert.IsTrue(x >= 8);
            //Assert.IsTrue(x >= 5);
            //Assert.IsTrue(x > 0);
        }
    }

    //Widać, że typ Base obsłuży kilka liczb, których nie obsłuży typ Derived (5, 6, 7). Zatem nasz program nie zadziała prawidłowo dla typu Derived
    public class Preconditions
    {
        public void Run()
        {
            PreconditionsBase a = new PreconditionsBase();
            PreconditionsBase b = new PreconditionsDerived();
            a.Call(6);
            b.Call(6); //Unhandled Exception: NUnit.Framework.AssertionException
        }
    }
}
