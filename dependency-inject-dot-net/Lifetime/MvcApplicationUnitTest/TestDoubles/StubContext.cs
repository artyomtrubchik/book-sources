﻿using System.Web;

namespace Ploeh.Samples.Lifetime.MvcApplication.UnitTest
{
    class StubContext : HttpContextBase
    {
        StubRequest request;

        public StubContext(string relativeUrl)
        {
            request = new StubRequest(relativeUrl);
        }

        public override HttpRequestBase Request
        {
            get { return request; }
        }
    }
}
