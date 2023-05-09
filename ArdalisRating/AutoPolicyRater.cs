using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating
{
    public class AutoPolicyRater : Rater
    {
        private readonly RatingEngine _engine;
        private ConsoleLogger _logger;

        public AutoPolicyRater(RatingEngine engin, ConsoleLogger logger): base(logger)
        {
            _engine = engin;
            _logger = logger;
        }

        public override void Rate(Policy policy)
        {
            _logger.Log("Rating AUTO policy...");
            _logger.Log("Validating policy.");

            if (String.IsNullOrEmpty(policy.Make))
            {
                _logger.Log("Auto policy must specify Make");
                return;
            }
            if (policy.Make == "BMW")
            {
                if (policy.Deductible < 500)
                {
                    _engine.Rating = 1000m;
                }
                _engine.Rating = 900m;
            }
        }

    }
}
