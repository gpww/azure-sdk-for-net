// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Describe the additional data of governance assignment - optional. </summary>
    public partial class GovernanceAssignmentAdditionalInfo
    {
        /// <summary> Initializes a new instance of <see cref="GovernanceAssignmentAdditionalInfo"/>. </summary>
        public GovernanceAssignmentAdditionalInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GovernanceAssignmentAdditionalInfo"/>. </summary>
        /// <param name="ticketNumber"> Ticket number associated with this governance assignment. </param>
        /// <param name="ticketLink"> Ticket link associated with this governance assignment - for example: https://snow.com. </param>
        /// <param name="ticketStatus"> The ticket status associated with this governance assignment - for example: Active. </param>
        internal GovernanceAssignmentAdditionalInfo(int? ticketNumber, string ticketLink, string ticketStatus)
        {
            TicketNumber = ticketNumber;
            TicketLink = ticketLink;
            TicketStatus = ticketStatus;
        }

        /// <summary> Ticket number associated with this governance assignment. </summary>
        public int? TicketNumber { get; set; }
        /// <summary> Ticket link associated with this governance assignment - for example: https://snow.com. </summary>
        public string TicketLink { get; set; }
        /// <summary> The ticket status associated with this governance assignment - for example: Active. </summary>
        public string TicketStatus { get; set; }
    }
}
