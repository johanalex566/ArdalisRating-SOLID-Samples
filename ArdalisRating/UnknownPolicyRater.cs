namespace ArdalisRating
{
    public class UnknownPolicyRater : Rater
    {
        private ConsoleLogger _logger;

        public UnknownPolicyRater(RatingEngine engine, ConsoleLogger logger)
            : base(logger)
        {
            _logger = logger;
        }

        public override void Rate(Policy policy)
        {
            _logger.Log("Unknown policy type");
        }
    }
}
