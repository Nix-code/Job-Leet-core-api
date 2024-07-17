﻿using JobLeet.WebApi.JobLeet.Api.Logging;
using JobLeet.WebApi.JobLeet.Api.Models.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Services.MessageBroker.Publisher;
using Microsoft.AspNetCore.Components;

namespace JobLeet.WebApi.JobLeet.Api.Controllers.Accounts.V1
{
    [Route("api/v1/roles")]
    public class RoleController : BaseApiController<Role,RoleModel, IRoleRepository>
    {
        public RoleController(IRoleRepository roleRepository, ILoggerManagerV1 loggerManagerV1, RabbitMQService rabbitMQService)
            : base(roleRepository, loggerManagerV1, rabbitMQService) 
        {
        
        }
    }
}
