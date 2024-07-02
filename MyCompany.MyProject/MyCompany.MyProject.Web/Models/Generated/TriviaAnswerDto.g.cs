using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace MyCompany.MyProject.Web.Models
{
    public partial class TriviaAnswerDtoGen : GeneratedDto<MyCompany.MyProject.Data.Models.TriviaAnswer>
    {
        public TriviaAnswerDtoGen() { }

        private int? _TriviaAnswerId;
        private string _Text;
        private bool? _IsCorrect;
        private int? _TriviaQuestionId;
        private MyCompany.MyProject.Web.Models.TriviaQuestionDtoGen _TriviaQuestion;
        private string _EventId;
        private MyCompany.MyProject.Web.Models.EventDtoGen _Event;

        public int? TriviaAnswerId
        {
            get => _TriviaAnswerId;
            set { _TriviaAnswerId = value; Changed(nameof(TriviaAnswerId)); }
        }
        public string Text
        {
            get => _Text;
            set { _Text = value; Changed(nameof(Text)); }
        }
        public bool? IsCorrect
        {
            get => _IsCorrect;
            set { _IsCorrect = value; Changed(nameof(IsCorrect)); }
        }
        public int? TriviaQuestionId
        {
            get => _TriviaQuestionId;
            set { _TriviaQuestionId = value; Changed(nameof(TriviaQuestionId)); }
        }
        public MyCompany.MyProject.Web.Models.TriviaQuestionDtoGen TriviaQuestion
        {
            get => _TriviaQuestion;
            set { _TriviaQuestion = value; Changed(nameof(TriviaQuestion)); }
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
        public override void MapFrom(MyCompany.MyProject.Data.Models.TriviaAnswer obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.TriviaAnswerId = obj.TriviaAnswerId;
            this.Text = obj.Text;
            this.IsCorrect = obj.IsCorrect;
            this.TriviaQuestionId = obj.TriviaQuestionId;
            this.EventId = obj.EventId;
            if (tree == null || tree[nameof(this.TriviaQuestion)] != null)
                this.TriviaQuestion = obj.TriviaQuestion.MapToDto<MyCompany.MyProject.Data.Models.TriviaQuestion, TriviaQuestionDtoGen>(context, tree?[nameof(this.TriviaQuestion)]);

            if (tree == null || tree[nameof(this.Event)] != null)
                this.Event = obj.Event.MapToDto<MyCompany.MyProject.Data.Models.Event, EventDtoGen>(context, tree?[nameof(this.Event)]);

        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(MyCompany.MyProject.Data.Models.TriviaAnswer entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(TriviaAnswerId))) entity.TriviaAnswerId = (TriviaAnswerId ?? entity.TriviaAnswerId);
            if (ShouldMapTo(nameof(Text))) entity.Text = Text;
            if (ShouldMapTo(nameof(IsCorrect))) entity.IsCorrect = (IsCorrect ?? entity.IsCorrect);
            if (ShouldMapTo(nameof(TriviaQuestionId))) entity.TriviaQuestionId = (TriviaQuestionId ?? entity.TriviaQuestionId);
            if (ShouldMapTo(nameof(EventId))) entity.EventId = EventId;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override MyCompany.MyProject.Data.Models.TriviaAnswer MapToNew(IMappingContext context)
        {
            var includes = context.Includes;

            var entity = new MyCompany.MyProject.Data.Models.TriviaAnswer()
            {
                Text = Text,
            };

            if (OnUpdate(entity, context)) return entity;
            if (ShouldMapTo(nameof(TriviaAnswerId))) entity.TriviaAnswerId = (TriviaAnswerId ?? entity.TriviaAnswerId);
            if (ShouldMapTo(nameof(IsCorrect))) entity.IsCorrect = (IsCorrect ?? entity.IsCorrect);
            if (ShouldMapTo(nameof(TriviaQuestionId))) entity.TriviaQuestionId = (TriviaQuestionId ?? entity.TriviaQuestionId);
            if (ShouldMapTo(nameof(EventId))) entity.EventId = EventId;

            return entity;
        }
    }
}
