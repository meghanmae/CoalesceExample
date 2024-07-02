using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace MyCompany.MyProject.Web.Models
{
    public partial class ApplicationUserDtoGen : GeneratedDto<MyCompany.MyProject.Data.Models.ApplicationUser>
    {
        public ApplicationUserDtoGen() { }

        private string _ApplicationUserId;
        private string _Name;
        private string _Email;
        private string _OrganizationId;
        private MyCompany.MyProject.Web.Models.OrganizationDtoGen _Organization;

        public string ApplicationUserId
        {
            get => _ApplicationUserId;
            set { _ApplicationUserId = value; Changed(nameof(ApplicationUserId)); }
        }
        public string Name
        {
            get => _Name;
            set { _Name = value; Changed(nameof(Name)); }
        }
        public string Email
        {
            get => _Email;
            set { _Email = value; Changed(nameof(Email)); }
        }
        public string OrganizationId
        {
            get => _OrganizationId;
            set { _OrganizationId = value; Changed(nameof(OrganizationId)); }
        }
        public MyCompany.MyProject.Web.Models.OrganizationDtoGen Organization
        {
            get => _Organization;
            set { _Organization = value; Changed(nameof(Organization)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(MyCompany.MyProject.Data.Models.ApplicationUser obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.ApplicationUserId = obj.ApplicationUserId;
            this.Name = obj.Name;
            this.Email = obj.Email;
            this.OrganizationId = obj.OrganizationId;
            if (tree == null || tree[nameof(this.Organization)] != null)
                this.Organization = obj.Organization.MapToDto<MyCompany.MyProject.Data.Models.Organization, OrganizationDtoGen>(context, tree?[nameof(this.Organization)]);

        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(MyCompany.MyProject.Data.Models.ApplicationUser entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(ApplicationUserId))) entity.ApplicationUserId = ApplicationUserId;
            if (ShouldMapTo(nameof(Name))) entity.Name = Name;
            if (ShouldMapTo(nameof(Email))) entity.Email = Email;
            if (ShouldMapTo(nameof(OrganizationId))) entity.OrganizationId = OrganizationId;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override MyCompany.MyProject.Data.Models.ApplicationUser MapToNew(IMappingContext context)
        {
            var includes = context.Includes;

            var entity = new MyCompany.MyProject.Data.Models.ApplicationUser()
            {
                Name = Name,
                Email = Email,
            };

            if (OnUpdate(entity, context)) return entity;
            if (ShouldMapTo(nameof(ApplicationUserId))) entity.ApplicationUserId = ApplicationUserId;
            if (ShouldMapTo(nameof(OrganizationId))) entity.OrganizationId = OrganizationId;

            return entity;
        }
    }
}
