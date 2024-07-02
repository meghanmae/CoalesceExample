
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
    [Route("api/TriviaAnswer")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class TriviaAnswerController
        : BaseApiController<MyCompany.MyProject.Data.Models.TriviaAnswer, TriviaAnswerDtoGen, MyCompany.MyProject.Data.AppDbContext>
    {
        public TriviaAnswerController(CrudContext<MyCompany.MyProject.Data.AppDbContext> context) : base(context)
        {
            GeneratedForClassViewModel = context.ReflectionRepository.GetClassViewModel<MyCompany.MyProject.Data.Models.TriviaAnswer>();
        }

        [HttpGet("get/{id}")]
        [Authorize]
        public virtual Task<ItemResult<TriviaAnswerDtoGen>> Get(
            int id,
            DataSourceParameters parameters,
            IDataSource<MyCompany.MyProject.Data.Models.TriviaAnswer> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [Authorize]
        public virtual Task<ListResult<TriviaAnswerDtoGen>> List(
            ListParameters parameters,
            IDataSource<MyCompany.MyProject.Data.Models.TriviaAnswer> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [Authorize]
        public virtual Task<ItemResult<int>> Count(
            FilterParameters parameters,
            IDataSource<MyCompany.MyProject.Data.Models.TriviaAnswer> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Authorize]
        public virtual Task<ItemResult<TriviaAnswerDtoGen>> Save(
            [FromForm] TriviaAnswerDtoGen dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<MyCompany.MyProject.Data.Models.TriviaAnswer> dataSource,
            IBehaviors<MyCompany.MyProject.Data.Models.TriviaAnswer> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("bulkSave")]
        [Authorize]
        public virtual Task<ItemResult<TriviaAnswerDtoGen>> BulkSave(
            [FromBody] BulkSaveRequest dto,
            [FromQuery] DataSourceParameters parameters,
            [FromServices] IDataSourceFactory dataSourceFactory,
            [FromServices] IBehaviorsFactory behaviorsFactory)
            => BulkSaveImplementation(dto, parameters, dataSourceFactory, behaviorsFactory);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<TriviaAnswerDtoGen>> Delete(
            int id,
            IBehaviors<MyCompany.MyProject.Data.Models.TriviaAnswer> behaviors,
            IDataSource<MyCompany.MyProject.Data.Models.TriviaAnswer> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);
    }
}
