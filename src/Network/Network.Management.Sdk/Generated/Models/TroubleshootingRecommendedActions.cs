// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Recommended actions based on discovered issues.
    /// </summary>
    public partial class TroubleshootingRecommendedActions
    {
        /// <summary>
        /// Initializes a new instance of the TroubleshootingRecommendedActions class.
        /// </summary>
        public TroubleshootingRecommendedActions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TroubleshootingRecommendedActions class.
        /// </summary>

        /// <param name="actionId">ID of the recommended action.
        /// </param>

        /// <param name="actionText">Description of recommended actions.
        /// </param>

        /// <param name="actionUri">The uri linking to a documentation for the recommended troubleshooting
        /// actions.
        /// </param>

        /// <param name="actionUriText">The information from the URI for the recommended troubleshooting actions.
        /// </param>
        public TroubleshootingRecommendedActions(string actionId = default(string), string actionText = default(string), string actionUri = default(string), string actionUriText = default(string))

        {
            this.ActionId = actionId;
            this.ActionText = actionText;
            this.ActionUri = actionUri;
            this.ActionUriText = actionUriText;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets iD of the recommended action.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "actionId")]
        public string ActionId {get; set; }

        /// <summary>
        /// Gets or sets description of recommended actions.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "actionText")]
        public string ActionText {get; set; }

        /// <summary>
        /// Gets or sets the uri linking to a documentation for the recommended
        /// troubleshooting actions.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "actionUri")]
        public string ActionUri {get; set; }

        /// <summary>
        /// Gets or sets the information from the URI for the recommended
        /// troubleshooting actions.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "actionUriText")]
        public string ActionUriText {get; set; }
    }
}