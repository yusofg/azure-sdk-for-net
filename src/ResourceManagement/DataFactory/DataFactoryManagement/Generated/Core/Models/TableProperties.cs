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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.DataFactories.Common.Models;
using Microsoft.Azure.Management.DataFactories.Core.Models;

namespace Microsoft.Azure.Management.DataFactories.Core.Models
{
    /// <summary>
    /// Table properties.
    /// </summary>
    public partial class TableProperties
    {
        private System.DateTime? _createTime;
        
        /// <summary>
        /// Optional. The time it is created.
        /// </summary>
        public System.DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }
        
        private string _description;
        
        /// <summary>
        /// Optional. Table description.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private string _errorMessage;
        
        /// <summary>
        /// Optional. Error in processing table request.
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }
        
        private string _linkedServiceName;
        
        /// <summary>
        /// Required. The referenced data linkedService name.
        /// </summary>
        public string LinkedServiceName
        {
            get { return this._linkedServiceName; }
            set { this._linkedServiceName = value; }
        }
        
        private Policy _policy;
        
        /// <summary>
        /// Optional. Policy applied to the table.
        /// </summary>
        public Policy Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Optional. The provisioning state of the table.
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        private bool? _published;
        
        /// <summary>
        /// Optional. Table is published to Enterprise Data Directory.
        /// </summary>
        public bool? Published
        {
            get { return this._published; }
            set { this._published = value; }
        }
        
        private SlicingModel _slicingModel;
        
        /// <summary>
        /// Optional. Slicing model for the table
        /// </summary>
        public SlicingModel SlicingModel
        {
            get { return this._slicingModel; }
            set { this._slicingModel = value; }
        }
        
        private IList<DataElement> _structure;
        
        /// <summary>
        /// Optional. Columns that define the structure of the table.
        /// </summary>
        public IList<DataElement> Structure
        {
            get { return this._structure; }
            set { this._structure = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Required. The type of the table. May be the name of a build-in ADF
        /// type or a type registered by a user and available to the data
        /// factory this table is a member of.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        private string _typeProperties;
        
        /// <summary>
        /// Required. The properties specific to the table type.
        /// </summary>
        public string TypeProperties
        {
            get { return this._typeProperties; }
            set { this._typeProperties = value; }
        }
        
        private string _updateMode;
        
        /// <summary>
        /// Required. update mode
        /// </summary>
        public string UpdateMode
        {
            get { return this._updateMode; }
            set { this._updateMode = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the TableProperties class.
        /// </summary>
        public TableProperties()
        {
            this.Structure = new LazyList<DataElement>();
        }
    }
}
