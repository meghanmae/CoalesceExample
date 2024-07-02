
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
    [Route("api/TriviaGuess")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class TriviaGuessController
        : BaseApiController<MyCompany.MyProject.Data.Models.TriviaGuess, TriviaGuessDtoGen, MyCompany.MyProject.Data.AppDbContext>
    {
        public TriviaGuessController(CrudContext<MyCompany.MyProject.Data.AppDbContext> context) : base(context)
        {
            GeneratedForClassViewModel = context.ReflectionRepository.GetClassViewModel<MyCompany.MyProject.Data.Models.TriviaGuess>();
        }

        [HttpGet("get/{id}")]
        [Authorize]
        public virtual Task<ItemResult<TriviaGuessDtoGen>> Get(
            int id,
            DataSourceParameters parameters,
            IDataSource<MyCompany.MyProject.Data.Models.TriviaGuess> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [Authorize]
        public virtual Task<ListResult<TriviaGuessDtoGen>> List(
            ListParameters parameters,
            IDataSource<MyCompany.MyProject.Data.Models.TriviaGuess> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [Authorize]
        public virtual Task<ItemResult<int>> Count(
            FilterParameters parameters,
            IDataSource<MyCompany.MyProject.Data.Models.TriviaGuess> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Authorize]
        public virtual Task<ItemResult<TriviaGuessDtoGen>> Save(
            [FromForm] TriviaGuessDtoGen dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<MyCompany.MyProject.Data.Models.TriviaGuess> dataSource,
            IBehaviors<MyCompany.MyProject.Data.Models.TriviaGuess> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("bulkSave")]
        [Authorize]
        public virtual Task<ItemResult<TriviaGuessDtoGen>> BulkSave(
            [FromBody] BulkSaveRequest dto,
            [FromQuery] DataSourceParameters parameters,
            [FromServices] IDataSourceFactory dataSourceFactory,
            [FromServices] IBehaviorsFactory behaviorsFactory)
            => BulkSaveImplementation(dto, parameters, dataSourceFactory, behaviorsFactory);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<TriviaGuessDtoGen>> Delete(
            int id,
            IBehaviors<MyCompany.MyProject.Data.Models.TriviaGuess> behaviors,
            IDataSource<MyCompany.MyProject.Data.Models.TriviaGuess> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);
    }
}
