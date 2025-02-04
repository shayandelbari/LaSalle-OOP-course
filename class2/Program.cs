namespace class2
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("hello world");
        }
    }

    class Bank
    {
        private string balance;
        public string Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        private string accountNumber;
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
    }
}