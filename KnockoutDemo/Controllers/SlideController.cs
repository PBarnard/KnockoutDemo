namespace KnockoutDemo.Controllers
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using Models;

    public class SlideController : ApiController
    {
        public Slide Get()
        {
            return new Slide
            {
                Provider = "Provider 1",
                ReferenceNumber = "REF #789",
                SlideType = "Detail",
                From = new DateTime(2015, 9, 1),
                To = new DateTime(2016, 9, 1)
            };
        }

        public Slide Get(long id)
        {
            return new Slide
            {
                Provider = "Provider 1",
                ReferenceNumber = "REF #789",
                SlideType = "Detail",
                From = new DateTime(2015, 9, 1),
                To = new DateTime(2016, 9, 1)
            };
        }

        public HttpResponseMessage Post(Slide slide)
        {
            //// Update Slide here

            var response = Request.CreateResponse(HttpStatusCode.Created, slide);

            var uri = Url.Link("DefaultApi", new { id = slide.Id });

            response.Headers.Location = new Uri(uri);

            return response;
        }
    }
}
