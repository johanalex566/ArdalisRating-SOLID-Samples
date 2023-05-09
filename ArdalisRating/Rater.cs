namespace ArdalisRating
{
    public abstract class Rater
    {
        public ConsoleLogger Logger { get; set; }

        public Rater(ConsoleLogger logger)
        {
            Logger = logger;
        }

        public abstract void Rate(Policy policy);
    }
}