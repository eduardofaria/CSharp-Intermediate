namespace Interface_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IConsole msg = new MessageError();
            IConsole msg2 = new MessageWarning();
            var usarClasse = new MessageError();


            msg.MsgInConsole("Teste de interface");
            msg2.MsgInConsole("Teste de interface");

            usarClasse.MsgInConsole("Teste de classe");

        }
    }
}
