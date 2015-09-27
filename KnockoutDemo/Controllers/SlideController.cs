namespace KnockoutDemo.Controllers
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using Domain.Types;

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
            if (ModelState.IsValid)
            {
                // Do something with the slide.

                return new HttpResponseMessage(HttpStatusCode.OK);
            }

            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        }
    }
}
