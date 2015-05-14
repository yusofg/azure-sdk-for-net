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

namespace Microsoft.Azure.Management.RemoteApp.Models
{
    /// <summary>
    /// Current status of a long-running operation.
    /// </summary>
    public enum RemoteAppOperationStatus
    {
        /// <summary>
        /// The operation is pending.
        /// </summary>
        Pending = 0,
        
        /// <summary>
        /// The operation is in progress.
        /// </summary>
        InProgress = 1,
        
        /// <summary>
        /// The operation was successfully completed.
        /// </summary>
        Success = 2,
        
        /// <summary>
        /// The operation failed.
        /// </summary>
        Failed = 3,
    }
}