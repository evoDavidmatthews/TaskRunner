using Infrastructure.Models;
using Infrastructure.Repositories.Functions;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FunctionsController : ControllerBase
    {
        private readonly ILogger<FunctionsController> _logger;

        public FunctionsController(ILogger<FunctionsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetFunctions")]
        public IEnumerable<FunctionDto> Get()
        {
            FunctionsRepository functionsRepository = new FunctionsRepository();
            IEnumerable<Function> functions = functionsRepository.GetAll();
            foreach (Function function in functions) 
            {
                List<ArgumentDto> args = new List<ArgumentDto>();
                foreach (var item in function.Arguments)
                {
                    args.Add(new ArgumentDto() 
                    {
                        Type = item.GetType().FullName, 
                        Value = item
                    });
                }

                yield return new FunctionDto() 
                {
                    Id = function.Id,
                    Name = function.Name,
                    Arguments = args,
                    Description = function.Description,
                };
            }
        }
    }
}
