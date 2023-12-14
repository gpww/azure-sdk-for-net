// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Rewrite rule of an application gateway. </summary>
    public partial class ApplicationGatewayRewriteRule
    {
        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayRewriteRule"/>. </summary>
        public ApplicationGatewayRewriteRule()
        {
            Conditions = new ChangeTrackingList<ApplicationGatewayRewriteRuleCondition>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayRewriteRule"/>. </summary>
        /// <param name="name"> Name of the rewrite rule that is unique within an Application Gateway. </param>
        /// <param name="ruleSequence"> Rule Sequence of the rewrite rule that determines the order of execution of a particular rule in a RewriteRuleSet. </param>
        /// <param name="conditions"> Conditions based on which the action set execution will be evaluated. </param>
        /// <param name="actionSet"> Set of actions to be done as part of the rewrite Rule. </param>
        internal ApplicationGatewayRewriteRule(string name, int? ruleSequence, IList<ApplicationGatewayRewriteRuleCondition> conditions, ApplicationGatewayRewriteRuleActionSet actionSet)
        {
            Name = name;
            RuleSequence = ruleSequence;
            Conditions = conditions;
            ActionSet = actionSet;
        }

        /// <summary> Name of the rewrite rule that is unique within an Application Gateway. </summary>
        public string Name { get; set; }
        /// <summary> Rule Sequence of the rewrite rule that determines the order of execution of a particular rule in a RewriteRuleSet. </summary>
        public int? RuleSequence { get; set; }
        /// <summary> Conditions based on which the action set execution will be evaluated. </summary>
        public IList<ApplicationGatewayRewriteRuleCondition> Conditions { get; }
        /// <summary> Set of actions to be done as part of the rewrite Rule. </summary>
        public ApplicationGatewayRewriteRuleActionSet ActionSet { get; set; }
    }
}
