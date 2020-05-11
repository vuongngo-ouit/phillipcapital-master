using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PhillipCapital.Utilities
{
    public static class HttpClientExt
    {
        public static void SetBearerToken(this HttpRequestMessage request)
        {
            //var user = JsonFileHelper.GetUser();
            //if (user == null || string.IsNullOrEmpty(user.AccessToken))
            //{
            //    return;
            //}

            //request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", user.AccessToken);
        }
    }

    public class HttpClientHandlerExt : HttpClientHandler
    {
        private readonly string _functionKey;

        public HttpClientHandlerExt(string functionKey)
        {
            _functionKey = functionKey;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            //
            // Set function key and access token
            request.Headers.Add("x-functions-key", _functionKey);
            //request.SetBearerToken();
            //
            // TODO: Handler error
            var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
            //
            // Return raw http response
            return response;
        }
    }
}
