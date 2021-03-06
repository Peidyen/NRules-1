using System;
using System.Collections.Generic;

namespace NRules.RuleModel
{
    /// <summary>
    /// Rule element that serves as a source to pattern elements.
    /// </summary>
    public abstract class PatternSourceElement : RuleLeftElement
    {
        private readonly Type _resultType;

        /// <summary>
        /// Type of the result that this rule element yields.
        /// </summary>
        public Type ResultType
        {
            get { return _resultType; }
        }

        internal PatternSourceElement(IEnumerable<Declaration> declarations, Type resultType)
            : base(declarations)
        {
            _resultType = resultType;
        }
    }
}