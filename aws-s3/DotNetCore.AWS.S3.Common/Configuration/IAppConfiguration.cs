namespace DotNetCore.AWS.S3.Common
{
	public interface IAppConfiguration
	{
		string AwsAccessKey { get; set; }
		string AwsSecretAccessKey { get; set; }
		string AwsSessionToken { get; set; }
		string BucketName { get; set; }
		string Region { get; set; }
	}
}
