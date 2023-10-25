namespace TestGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BIlar bilar = new BIlar();
            Flygplan flygplan = new Flygplan();

            Fordon[] fordon = { flygplan, bilar };
            
            foreach (Fordon ford in fordon)
            {
                ford.Go();
            }
        }
    }
}