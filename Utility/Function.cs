using Amazon.Lambda.Core;
using Amazon.Lambda.Serialization.Json;
using System;
using Utility.Helpers;
using Utility.Models;

[assembly: LambdaSerializer(typeof(JsonSerializer))]

namespace Utility
{
    public class Function
    {

        [LambdaSerializer(typeof(JsonSerializer))]
        public int FunctionHandler(CalculateBusinessDateModel input, ILambdaContext context)
        {
            var businessDays = 0;

            try
            {
                //string fromDate = input["fromDate"].ToString();
                //string toName = input["toDate"].ToString();
                
                var fromDate = input.FromDate;
                var toDate = input.ToDate;
                LambdaLogger.Log($"fromDate: {fromDate} toDate: {toDate}");

                businessDays = DateTimeHelper.GetBusinessDays(fromDate, toDate);
            }
            catch (Exception ex)
            {
                LambdaLogger.Log("Exception: " + ex.Message);
            }

            LambdaLogger.Log($"businessDays: {businessDays}");

            return businessDays;
        }
    }
}
