using Core;
using System.Collections.Generic;
using System.Web.Http;

namespace Web.Controllers
{
    [RoutePrefix("api/Numbers")]
    public class SequenceController : ApiController
    {
        [HttpGet]
        [Route("AllNumbers/{number}")]
        public List<int> AllNumbers(int number)
        {
            ISequence<int> allNumbers = new AllNumbers();
            return allNumbers.CreateSequence(number);
        }

        [HttpGet]
        [Route("AllOddNumbers/{number}")]
        public List<int> AllOddNumbers(int number)
        {
            ISequence<int> allOddNumbers = new AllOddNumbers();
            return allOddNumbers.CreateSequence(number);
        }

        [HttpGet]
        [Route("AllEvenNumbers/{number}")]
        public List<int> AllEvenNumbers(int number)
        {
            ISequence<int> allEvenNumbers = new AllEvenNumbers();
            return allEvenNumbers.CreateSequence(number);
        }

        [HttpGet]
        [Route("AllExtendedFizzBuzzs/{number}")]
        public List<string> AllExtendedFizzBuzzs(int number)
        {
            ISequence<string> allExtendedFizzBuzzs = new AllExtendedFizzBuzzs();
            return allExtendedFizzBuzzs.CreateSequence(number);
        }

        [HttpGet]
        [Route("AllFibonacciNumbers/{number}")]
        public List<long> AllFibonacciNumbers(int number)
        {
            ISequence<long> allFibonacciNumbers = new AllFibonacciNumbers();
            return allFibonacciNumbers.CreateSequence(number);
        }
    }
}
