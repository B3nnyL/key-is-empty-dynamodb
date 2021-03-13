using Amazon.DynamoDBv2.DataModel;

namespace dynamodb_csharp_api
{
    [DynamoDBTable("weather")]
    public class Base
    {
        [DynamoDBHashKey]
        public virtual int? Id { get; set; }
    }
}
