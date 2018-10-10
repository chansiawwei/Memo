using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Net.Http.Headers;
using memo;
using memo.Models;
using memo.Controllers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using memo.Data;
using Moq;
using System.Text.RegularExpressions;
using Xunit;
using Microsoft.EntityFrameworkCore;

namespace integrationTest
{
    public class IntegrationTest
    {
        private TestServer server;
        private HttpClient client;
        private const string AntiForgeryFieldName = "__RequestVerificationToken";
        private const string AntiForgeryCookieName = ".AspNetCore.Antiforgery.oiQ64jtX0QE";

        public IntegrationTest()
        {
            var builder = new WebHostBuilder()
                //Change Root to project directory before testing
            .UseContentRoot(@"C:\Users\Chan Siaw Wei\Desktop\sw_memo(2)\sw_memo\memo")
            .UseEnvironment("Development")
               .UseStartup<Startup>();


            server = new TestServer(builder);

            client = server.CreateClient();
        }


        [Fact]
        public async Task MemoHomeTestNoLogin()
        {
            

            var response = await client.GetAsync("/");

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            Assert.Contains("Please login or register to see list of memos.", responseString);
        }

      /*
        [Fact]
        public async Task LoginTest()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "/Identity/Account/Login");
            request.Headers.Add("Cookie", ".AspNet.Consent=yes");
            var initialResponse = await client.SendAsync(request);

            string antiForgeryCookieValue =
              ExtractAntiForgeryCookieValueFrom(initialResponse);

            string antiForgeryToken =
               ExtractAntiForgeryToken(await initialResponse.Content.ReadAsStringAsync());


            // Create POST request, adding anti forgery cookie and form field
            var postRequest = new HttpRequestMessage(HttpMethod.Post, "/Identity/Account/Login");

            postRequest.Headers.Add("Cookie",
                new CookieHeaderValue(AntiForgeryCookieName,
                                      antiForgeryCookieValue).ToString());

            var formData = new Dictionary<string, string>
            {
               {AntiForgeryFieldName, antiForgeryToken},
                {"Input.Email", "tikchoong@gmail.com"},
                {"Input.Passwprd", "Addiction1@"},
                {"Input.RememberMe", "true"},
                // Frequent flyer number omitted
            };

            postRequest.Content = new FormUrlEncodedContent(formData);

            var postResponse = await client.SendAsync(postRequest);

            postResponse.EnsureSuccessStatusCode();

            var responseString = await postResponse.Content.ReadAsStringAsync();

            request = new HttpRequestMessage(HttpMethod.Get, "/memos");
            request.Headers.Add("Cookie", "AspNet.Consent=yes; "+
                 new CookieHeaderValue(AntiForgeryCookieName,
                                      antiForgeryCookieValue).ToString());

            var memosResponse = await client.SendAsync(request);
            memosResponse.EnsureSuccessStatusCode();

            responseString = await memosResponse.Content.ReadAsStringAsync();


        }
        private static string ExtractAntiForgeryCookieValueFrom(
            HttpResponseMessage response)
        {
            string antiForgeryCookie = response.Headers.GetValues("Set-Cookie")
                .FirstOrDefault(x => x.Contains(AntiForgeryCookieName));

            if (antiForgeryCookie is null)
            {
                throw new ArgumentException(
                    $"Cookie '{AntiForgeryCookieName}' not found in HTTP response",
                    nameof(response));
            }

            string antiForgeryCookieValue =
                SetCookieHeaderValue.Parse(antiForgeryCookie).Value.ToString();

            return antiForgeryCookieValue;
        }

        private string ExtractAntiForgeryToken(string htmlBody)
        {
            var requestVerificationTokenMatch =
                Regex.Match(htmlBody, $@"\<input name=""{AntiForgeryFieldName}"" type=""hidden"" value=""([^""]+)"" \/\>");

            if (requestVerificationTokenMatch.Success)
            {
                return requestVerificationTokenMatch.Groups[1].Captures[0].Value;
            }

            throw new ArgumentException($"Anti forgery token '{AntiForgeryFieldName}' not found in HTML", nameof(htmlBody));
        }
        */
    }
}

 