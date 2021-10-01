﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureCQRS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController : Controller
    {
        private ISender _mediator;

        protected ISender Mediator => _mediator ??= (ISender)HttpContext.RequestServices.GetService(typeof(ISender));
    }
}
