using System;
using System.Text;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace DemoResumeBuilderAPI
{
	class Program
	{
		static HttpClient http = new HttpClient();
		static readonly string url = "http://localhost:61171/api/Users";
		static readonly string testUrl = "http://localhost:61171/api/test";

		static void Main(string[] args)
		{
			TestAPI();

			Console.WriteLine("We're going to try and move information into and out of the ResumeBuilder Database through the API");

			GatherInformationAboutUser(out var user);

			TryPostingUserToAPI(user);

			Console.WriteLine("Press any key to exit");
			Console.ReadLine();
		}

		private static void TestAPI()
		{
			Console.WriteLine("Let's start by testing if the API is accessible or not");
			try
			{
				var test = http.GetAsync(testUrl).Result;

				Console.WriteLine("Test complete!");

				if (test.StatusCode == HttpStatusCode.OK)
				{
					Console.WriteLine("It seems the API is returning information, so we're good to go! Hit any key to continue");
					Console.ReadLine();
				}
				else
				{
					Console.WriteLine("Something is wrong with the API");
					Console.WriteLine("Make sure under ResumeBuilder > Properties > Debug > Web Server Settings that only Enable Anonymous Authentication is checked");
					Console.WriteLine("Hit any key to exit the program");
					Console.ReadLine();
					Environment.Exit(-1);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine($"Exception: {e}");
			}
		}

		private static void GatherInformationAboutUser(out SampleUser user)
		{
			Console.WriteLine("Lets start by entering some of your information");

			user = new SampleUser();

			Console.WriteLine("First Name:");
			user.FirstName = Console.ReadLine();
			Console.WriteLine("Middle Name:");
			user.MiddleName = Console.ReadLine();
			Console.WriteLine("Last Name:");
			user.LastName = Console.ReadLine();
			Console.WriteLine("Phone:");
			user.Phone = Console.ReadLine();
			Console.WriteLine("Email Address:");
			user.Email = Console.ReadLine();

			return;
		}

		private static void TryPostingUserToAPI(SampleUser user)
		{
			var json = JsonConvert.SerializeObject(user);

			var request = new StringContent(json, Encoding.UTF8, "application/json");

			var response = http.PostAsync(url, request);
			var httpResult = response.Result;
			var content = httpResult.Content;
			var resultString = content.ReadAsStringAsync().Result;

			Console.WriteLine("Here's what came back:");
			Console.WriteLine(JsonConvert.DeserializeObject(resultString, typeof(object)));
		}
	}
}
