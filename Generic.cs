namespace CodeSnippets
{
    class Test<T>
    {
        T _value;
        public Test(T t)
        {
            this._value = t;
        }
        public void Write()
        {
            Console.WriteLine(this._value);
        }
    }
}