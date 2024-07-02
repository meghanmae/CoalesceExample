
using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Api;
using IntelliTect.Coalesce.Api.Behaviors;
using IntelliTect.Coalesce.Api.Controllers;
using IntelliTect.Coalesce.Api.DataSources;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Mapping.IncludeTrees;
using IntelliTect.Coalesce.Models;
using IntelliTect.Coalesce.TypeDefinition;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCompany.MyProject.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MyCompany.MyProject.Web.Api
{
    [Route("api/ApplicationUser")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class ApplicationUserController
        : BaseApiController<MyCompany.MyProject.Data.Models.ApplicationUser, ApplicationUserDtoGen, MyCompany.MyProject.Data.AppDbContext>
    {
        public ApplicationUserController(CrudContext<MyCompany.MyProject.Data.AppDbContext> context) : base(context)
        {
            GeneratedForClassViewModel = context.ReflectionRepository.GetClassViewModel<MyCompany.MyProject.Data.Models.ApplicationUser>();
        }

        [HttpGet("get/{id}")]
        [Authorize]
        public virtual Task<ItemResult<ApplicationUserDtoGen>> Get(
            string id,
            DataSourceParameters parameters,
            IDataSource<MyCompany.MyProject.Data.Models.ApplicationUser> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [Authorize]
        public virtual Task<ListResult<ApplicationUserDtoGen>> List(
            ListParameters parameters,
            IDataSource<MyCompany.MyProject.Data.Models.ApplicationUser> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [Authorize]
        public virtual Task<ItemResult<int>> Count(
            FilterParameters parameters,
            IDataSource<MyCompany.MyProject.Data.Models.ApplicationUser> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Authorize]
        public virtual Task<ItemResult<ApplicationUserDtoGen>> Save(
            [FromForm] ApplicationUserDtoGen dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<MyCompany.MyProject.Data.Models.ApplicationUser> dataSource,
            IBehaviors<MyCompany.MyProject.Data.Models.ApplicationUser> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("bulkSave")]
        [Authorize]
        public virtual Task<ItemResult<ApplicationUserDtoGen>> BulkSave(
            [FromBody] BulkSaveRequest dto,
            [FromQuery] DataSourceParameters parameters,
            [FromServices] IDataSourceFactory dataSourceFactory,
            [FromServices] IBehaviorsFactory behaviorsFactory)
            => BulkSaveImplementation(dto, parameters, dataSourceFactory, behaviorsFactory);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<ApplicationUserDtoGen>> Delete(
            string id,
            IBehaviors<MyCompany.MyProject.Data.Models.ApplicationUser> behaviors,
            IDataSource<MyCompany.MyProject.Data.Models.ApplicationUser> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);
    }
}
