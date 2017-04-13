using FizzBuzz.Services;
using Xunit;

namespace FizzBuzzTests
{
    public class FizzBuzzServiceShould
    {
        private readonly FizzBuzzService _service;
        public FizzBuzzServiceShould() {
            _service = new FizzBuzzService();
        }
        [Fact]
        public void CreateAFizzBuzz()
        {
            int[] original = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16};
            var expected = "1,2,FIZZ,4,BUZZ,FIZZ,7,8,FIZZ,BUZZ,11,FIZZ,13,14,FIZZBUZZ,16";
            var result = _service.CreateFizzBuzz(original);

            Assert.Equal<string>(expected, result);
        }
    }
}
