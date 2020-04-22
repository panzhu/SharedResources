﻿using System;
using JetBrains.Annotations;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace EasyAbp.SharedResources.ResourceItems
{
    public class ResourceItem : FullAuditedAggregateRoot<Guid>, IMultiTenant
    {
        public virtual Guid? TenantId { get; protected set; }
        
        public virtual Guid ResourceId { get; protected set; }
        
        [NotNull]
        public virtual string Name { get; protected set; }
        
        [CanBeNull]
        public virtual string Description { get; protected set; }

        public virtual bool IsPublished { get; protected set; }
        
        public virtual bool IsPublic { get; protected set; }
    }
}