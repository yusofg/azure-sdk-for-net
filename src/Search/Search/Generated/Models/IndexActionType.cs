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

namespace Microsoft.Azure.Search.Models
{
    /// <summary>
    /// Specifies the operation to perform on a document in an indexing batch.
    /// </summary>
    public enum IndexActionType
    {
        /// <summary>
        /// The document will be added to the index, or replaced if it already
        /// exists.
        /// </summary>
        Upload = 0,
        
        /// <summary>
        /// Replaces fields in the document with new values specified in the
        /// request, or fails if the document doesn't exist. You can
        /// explicitly set fields to null to delete them from the document.
        /// </summary>
        Merge = 1,
        
        /// <summary>
        /// Behaves like 'Merge' if the document exists in the index, or like
        /// 'Upload' if the document doesn't exist.
        /// </summary>
        MergeOrUpload = 2,
        
        /// <summary>
        /// Deletes the document from the index. You can specify only the key
        /// field for a delete request.
        /// </summary>
        Delete = 3,
    }
}
