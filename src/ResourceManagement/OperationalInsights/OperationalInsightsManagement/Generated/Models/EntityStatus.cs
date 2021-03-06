// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    /// <summary>
    /// The status of an entity.
    /// </summary>
    public static partial class EntityStatus
    {
        /// <summary>
        /// Resource is being created.
        /// </summary>
        public const string Creating = "Creating";
        
        /// <summary>
        /// Resource creation succeeded.
        /// </summary>
        public const string Succeeded = "Succeeded";
        
        /// <summary>
        /// Resource creation failed.
        /// </summary>
        public const string Failed = "Failed";
        
        /// <summary>
        /// Resource creation was canceled.
        /// </summary>
        public const string Canceled = "Canceled";
        
        /// <summary>
        /// Resource is being deleted.
        /// </summary>
        public const string Deleting = "Deleting";
        
        /// <summary>
        /// Resource is provisioning the account.
        /// </summary>
        public const string ProvisioningAccount = "ProvisioningAccount";
    }
}
