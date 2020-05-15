using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;

[assembly: LambdaSerializerAttribute(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AwsDotnetCsharp
{
    public class Handler
    {
        public APIGatewayProxyResponse Hello(APIGatewayProxyRequest apiGatewayProxyRequest, ILambdaContext lambdaContext)
        {
            var helloValue = apiGatewayProxyRequest.PathParameters["helloId"];
            var worldValue = apiGatewayProxyRequest.PathParameters["worldId"];
            return new APIGatewayProxyResponse
            {
                StatusCode = 200,
                Body = $"Hello is {helloValue} and world is {worldValue}",

            };
       }
    }
}
