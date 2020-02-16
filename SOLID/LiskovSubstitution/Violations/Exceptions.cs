using System;

namespace ViolationExample
{
    class ExceptionsBase
    {
        public virtual void Call()
        {
            throw new ArgumentException();
        }
    }

    class ExceptionsDerived : ExceptionsBase
    {
        public override void Call()
        {
            throw new NullReferenceException();

            //Typ Derived nie powinien rzucać nowych wyjątków. Może rzucać ArgumentException lub wyjątki będące podtypem ArgumentException, np. ArgumentNullException.
            //throw new ArgumentNullException();
        }
    }

    //Metody podtypu nie powinny rzucać żadnych nowych wyjątków, oprócz sytuacji, gdy nowe wyjątki są podtypami zgłaszanych metod nadtypu.
    public class Exceptions
    {
        public void Run()
        {
            ExceptionsBase a = new ExceptionsBase();
            ExceptionsBase b = new ExceptionsDerived();
            CallExecute(a);
            CallExecute(b);
        }

        private void CallExecute(ExceptionsBase exceptionsBase)
        {
            try
            {
                exceptionsBase.Call();
            }
            catch (ArgumentException)
            {

            }
        }
    }
}
