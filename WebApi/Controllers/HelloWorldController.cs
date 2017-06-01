﻿using System.Web.Http;
using BusinessService;

namespace WebApi.Controllers
{
    public class HelloWorldController : ApiController
    {
        private readonly IGreetingService _greeting;

        #region Public Constructor

        /// <summary>
        /// Public constructor to initialize greeting instance
        /// </summary>
        public HelloWorldController()
        {
            _greeting = new GreetingService();
        }

        #endregion

        // GET api/HelloWorld
        public string Get()
        {
            return _greeting.GetHelloWorld();
        }
    }
}
