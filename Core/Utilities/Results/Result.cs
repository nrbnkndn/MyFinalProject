using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success) //bu constructor çalışırken aşağıdaki constructorı da çalıştırması için this vererek çağırabiliriz.
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; } //getter read onlydir ancak sadece constructorlarda set edilebilir.

        public string Message { get; }
    }
}
