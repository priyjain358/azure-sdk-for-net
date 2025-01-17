// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Wrapper resource for tags patch API request only. </summary>
    public partial class TagResourceUpdateOptions
    {
        /// <summary> Initializes a new instance of TagResourceUpdateOptions. </summary>
        public TagResourceUpdateOptions()
        {
        }

        /// <summary> The operation type for the patch API. </summary>
        public TagsPatchOperation? Operation { get; set; }
        /// <summary> The set of tags. </summary>
        internal Tag Properties { get; set; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> TagValues
        {
            get
            {
                if (Properties is null)
                    Properties = new Tag();
                return Properties.TagValues;
            }
        }
    }
}
