namespace ConsoleGame.Adventures
{
    public class Adventure
    {
        public string GUID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CompletionXPReward { get; set; }
        public int CompletionGoldReward { get; set; }
        public int MaxLevel { get; set; }
        public int MinimumLevel { get; set; }

        public Adventure()
        {

        }

        /// <summary>
        /// This is a method
        ///</summary>
        public void myMethod()
        {

        }
    }
}