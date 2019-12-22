using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Application.Common.Behaviors
{
    public abstract class ValueObjectBase
    {
        private readonly List<BusinessRule> _brokenRules = new List<BusinessRule>();
        protected ValueObjectBase() { }
        protected static bool EqualOperator(ValueObjectBase left, ValueObjectBase right)
        {
            if (ReferenceEquals(left, null) ^ ReferenceEquals(right, null))
            {
                return false;
            }
            return ReferenceEquals(left, null) || left.Equals(right);
        }
        protected abstract void Validate();

        public void ThrowExceptionIfInvalid()
        {
            _brokenRules.Clear();
            Validate();
            if (_brokenRules.Count <= 0) return;
            var issues = new StringBuilder();
            foreach (BusinessRule businessRule in _brokenRules)
            {
                issues.AppendLine(businessRule.Rule);
            }
        }
        protected void AddBrokenRule(BusinessRule businessRule)
        {
            _brokenRules.Add(businessRule);
        }
    }
}
