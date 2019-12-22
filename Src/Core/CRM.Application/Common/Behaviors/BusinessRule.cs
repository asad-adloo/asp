
namespace CRM.Application.Common.Behaviors
{
    public class BusinessRule
    {
        private string _property;
        private string _rule;

        public BusinessRule(string property, string rule)
        {
            _rule = rule;
            _property = property;
        }
        public string Property
        {
            get { return _property; }
            set { _property = value; }
        }
        public string Rule
        {
            get { return _rule; }
            set { _rule = value; }
        }
    }

}
