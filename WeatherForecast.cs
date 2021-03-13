using System;
using Amazon.DynamoDBv2.DataModel;

namespace dynamodb_csharp_api
{
    public class WeatherForecast: Base
    {
        public override int? Id { get; set; }

        public DateTime? Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
