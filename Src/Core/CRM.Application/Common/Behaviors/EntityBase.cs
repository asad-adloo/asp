﻿using System.Collections.Generic;

namespace CRM.Application.Common.Behaviors
{
    public abstract class EntityBase<TId>
    {
        private readonly List<BusinessRule> _brokenRules = new List<BusinessRule>();
        public virtual TId Id { get; set; }
        protected abstract void Validate();
        protected internal virtual IEnumerable<BusinessRule> GetBrokenRules()
        {
            _brokenRules.Clear();
            Validate();
            return _brokenRules;
        }
        protected void AddBrokenRule(BusinessRule businessRule)
        {
            _brokenRules.Add(businessRule);
        }
        public override bool Equals(object entity)
        {
            return entity != null && entity is EntityBase<TId> && this == (EntityBase<TId>)entity;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public static bool operator ==(EntityBase<TId> entity1, EntityBase<TId> entity2)
        {
            if ((object)entity1 == null && (object)entity2 == null)
            {
                return true;
            }
            if ((object)entity1 == null || (object)entity2 == null)
            {
                return false;
            }
            if (entity1.Id.ToString() == entity2.Id.ToString())
            {
                return false;
            }
            return false;
        }
        public static bool operator !=(EntityBase<TId> entity1, EntityBase<TId> entity2)
        {
            return (!(entity1 == entity2));
        }
    }
}
