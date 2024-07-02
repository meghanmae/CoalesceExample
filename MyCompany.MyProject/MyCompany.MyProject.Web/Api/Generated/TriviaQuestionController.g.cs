
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
    [Route("api/TriviaQuestion")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class TriviaQuestionController
        : BaseApiController<MyCompany.MyProject.Data.Models.TriviaQuestion, TriviaQuestionDtoGen, MyCompany.MyProject.Data.AppDbContext>
    {
        public TriviaQuestionController(CrudContext<MyCompany.MyProject.Data.AppDbContext> context) : base(context)
        {
            GeneratedForClassViewModel = context.ReflectionRepository.GetClassViewModel<MyCompany.MyProject.Data.Models.TriviaQuestion>();
        }

        [HttpGet("get/{id}")]
        [Authorize]
        public virtual Task<ItemResult<TriviaQuestionDtoGen>> Get(
            int id,
            DataSourceParameters parameters,
            IDataSource<MyCompany.MyProject.Data.Models.TriviaQuestion> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [Authorize]
        public virtual Task<ListResult<TriviaQuestionDtoGen>> List(
            ListParameters parameters,
            IDataSource<MyCompany.MyProject.Data.Models.TriviaQuestion> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [Authorize]
        public virtual Task<ItemResult<int>> Count(
            FilterParameters parameters,
            IDataSource<MyCompany.MyProject.Data.Models.TriviaQuestion> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Authorize]
        public virtual Task<ItemResult<TriviaQuestionDtoGen>> Save(
            [FromForm] TriviaQuestionDtoGen dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<MyCompany.MyProject.Data.Models.TriviaQuestion> dataSource,
            IBehaviors<MyCompany.MyProject.Data.Models.TriviaQuestion> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("bulkSave")]
        [Authorize]
        public virtual Task<ItemResult<TriviaQuestionDtoGen>> BulkSave(
            [FromBody] BulkSaveRequest dto,
            [FromQuery] DataSourceParameters parameters,
            [FromServices] IDataSourceFactory dataSourceFactory,
            [FromServices] IBehaviorsFactory behaviorsFactory)
            => BulkSaveImplementation(dto, parameters, dataSourceFactory, behaviorsFactory);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<TriviaQuestionDtoGen>> Delete(
            int id,
            IBehaviors<MyCompany.MyProject.Data.Models.TriviaQuestion> behaviors,
            IDataSource<MyCompany.MyProject.Data.Models.TriviaQuestion> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);
    }
}
