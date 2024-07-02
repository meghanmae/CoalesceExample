using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace MyCompany.MyProject.Web.Models
{
    public partial class TriviaGuessDtoGen : GeneratedDto<MyCompany.MyProject.Data.Models.TriviaGuess>
    {
        public TriviaGuessDtoGen() { }

        private int? _TriviaGuessId;
        private string _ApplicationUserId;
        private MyCompany.MyProject.Web.Models.ApplicationUserDtoGen _ApplicationUser;
        private int? _TriviaAnswerId;
        private MyCompany.MyProject.Web.Models.TriviaAnswerDtoGen _TriviaAnswer;
        private string _EventId;
        private MyCompany.MyProject.Web.Models.EventDtoGen _Event;

        public int? TriviaGuessId
        {
            get => _TriviaGuessId;
            set { _TriviaGuessId = value; Changed(nameof(TriviaGuessId)); }
        }
        public string ApplicationUserId
        {
            get => _ApplicationUserId;
            set { _ApplicationUserId = value; Changed(nameof(ApplicationUserId)); }
        }
        public MyCompany.MyProject.Web.Models.ApplicationUserDtoGen ApplicationUser
        {
            get => _ApplicationUser;
            set { _ApplicationUser = value; Changed(nameof(ApplicationUser)); }
        }
        public int? TriviaAnswerId
        {
            get => _TriviaAnswerId;
            set { _TriviaAnswerId = value; Changed(nameof(TriviaAnswerId)); }
        }
        public MyCompany.MyProject.Web.Models.TriviaAnswerDtoGen TriviaAnswer
        {
            get => _TriviaAnswer;
            set { _TriviaAnswer = value; Changed(nameof(TriviaAnswer)); }
        }
        public string EventId
        {
            get => _EventId;
            set { _EventId = value; Changed(nameof(EventId)); }
        }
        public MyCompany.MyProject.Web.Models.EventDtoGen Event
        {
            get => _Event;
            set { _Event = value; Changed(nameof(Event)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(MyCompany.MyProject.Data.Models.TriviaGuess obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.TriviaGuessId = obj.TriviaGuessId;
            this.ApplicationUserId = obj.ApplicationUserId;
            this.TriviaAnswerId = obj.TriviaAnswerId;
            this.EventId = obj.EventId;
            if (tree == null || tree[nameof(this.ApplicationUser)] != null)
                this.ApplicationUser = obj.ApplicationUser.MapToDto<MyCompany.MyProject.Data.Models.ApplicationUser, ApplicationUserDtoGen>(context, tree?[nameof(this.ApplicationUser)]);

            if (tree == null || tree[nameof(this.TriviaAnswer)] != null)
                this.TriviaAnswer = obj.TriviaAnswer.MapToDto<MyCompany.MyProject.Data.Models.TriviaAnswer, TriviaAnswerDtoGen>(context, tree?[nameof(this.TriviaAnswer)]);

            if (tree == null || tree[nameof(this.Event)] != null)
                this.Event = obj.Event.MapToDto<MyCompany.MyProject.Data.Models.Event, EventDtoGen>(context, tree?[nameof(this.Event)]);

        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(MyCompany.MyProject.Data.Models.TriviaGuess entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(TriviaGuessId))) entity.TriviaGuessId = (TriviaGuessId ?? entity.TriviaGuessId);
            if (ShouldMapTo(nameof(ApplicationUserId))) entity.ApplicationUserId = ApplicationUserId;
            if (ShouldMapTo(nameof(TriviaAnswerId))) entity.TriviaAnswerId = (TriviaAnswerId ?? entity.TriviaAnswerId);
            if (ShouldMapTo(nameof(EventId))) entity.EventId = EventId;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override MyCompany.MyProject.Data.Models.TriviaGuess MapToNew(IMappingContext context)
        {
            var entity = new MyCompany.MyProject.Data.Models.TriviaGuess();
            MapTo(entity, context);
            return entity;
        }
    }
}
