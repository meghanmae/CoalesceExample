using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace MyCompany.MyProject.Web.Models
{
    public partial class OrganizationDtoGen : GeneratedDto<MyCompany.MyProject.Data.Models.Organization>
    {
        public OrganizationDtoGen() { }

        private string _OrganizationId;
        private string _Name;

        public string OrganizationId
        {
            get => _OrganizationId;
            set { _OrganizationId = value; Changed(nameof(OrganizationId)); }
        }
        public string Name
        {
            get => _Name;
            set { _Name = value; Changed(nameof(Name)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(MyCompany.MyProject.Data.Models.Organization obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.OrganizationId = obj.OrganizationId;
            this.Name = obj.Name;
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(MyCompany.MyProject.Data.Models.Organization entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(OrganizationId))) entity.OrganizationId = OrganizationId;
            if (ShouldMapTo(nameof(Name))) entity.Name = Name;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override MyCompany.MyProject.Data.Models.Organization MapToNew(IMappingContext context)
        {
            var includes = context.Includes;

            var entity = new MyCompany.MyProject.Data.Models.Organization()
            {
                Name = Name,
            };

            if (OnUpdate(entity, context)) return entity;
            if (ShouldMapTo(nameof(OrganizationId))) entity.OrganizationId = OrganizationId;

            return entity;
        }
    }
}
