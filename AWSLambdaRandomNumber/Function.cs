using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AWSLambdaRandomNumber
{
    public class Function
    {

        private int min = 0;
        private int max = 10;
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public string FunctionHandler(IDictionary<string, string> input, ILambdaContext context)
        {
            
            //return new Random().Next(input., max);
            return "Min=" + input["min"] + "; max=" + input["max"];
        }
    }
}
