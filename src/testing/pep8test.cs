namespace Python.Test
{
    public class Pep8Test
    {
        public string Foo() => "hello";

        private int _bar = 1;
        public int Bar
        {
            get { return _bar; }
            set { _bar = value; }
        }

        public double BazPi = 3.14;
    }
}