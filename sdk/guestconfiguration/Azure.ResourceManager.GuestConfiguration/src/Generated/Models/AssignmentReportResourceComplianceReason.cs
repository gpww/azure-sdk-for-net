// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    /// <summary> Reason and code for the compliance of the guest configuration assignment resource. </summary>
    public partial class AssignmentReportResourceComplianceReason
    {
        /// <summary> Initializes a new instance of <see cref="AssignmentReportResourceComplianceReason"/>. </summary>
        public AssignmentReportResourceComplianceReason()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AssignmentReportResourceComplianceReason"/>. </summary>
        /// <param name="phrase"> Reason for the compliance of the guest configuration assignment resource. </param>
        /// <param name="code"> Code for the compliance of the guest configuration assignment resource. </param>
        internal AssignmentReportResourceComplianceReason(string phrase, string code)
        {
            Phrase = phrase;
            Code = code;
        }

        /// <summary> Reason for the compliance of the guest configuration assignment resource. </summary>
        public string Phrase { get; }
        /// <summary> Code for the compliance of the guest configuration assignment resource. </summary>
        public string Code { get; }
    }
}
