namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new StackArray(5);
            s.push(12);
            s.push(11);
            s.push(113);
            s.push(413);
            s.push(4131);
            s.display();

        }
    }


}
