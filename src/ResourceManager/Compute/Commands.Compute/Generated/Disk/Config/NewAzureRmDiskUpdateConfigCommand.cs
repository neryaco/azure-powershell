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

using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Management.Compute.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet("New", "AzureRmDiskUpdateConfig", SupportsShouldProcess = true)]
    [OutputType(typeof(PSDiskUpdate))]
    public partial class NewAzureRmDiskUpdateConfigCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = false,
            Position = 0,
            ValueFromPipelineByPropertyName = true)]
        [Alias("AccountType")]
        public string SkuName { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        public OperatingSystemTypes? OsType { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public int DiskSizeGB { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipelineByPropertyName = true)]
        public Hashtable Tag { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public bool? EncryptionSettingsEnabled { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public KeyVaultAndSecretReference DiskEncryptionKey { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public KeyVaultAndKeyReference KeyEncryptionKey { get; set; }

        protected override void ProcessRecord()
        {
            if (ShouldProcess("DiskUpdate", "New"))
            {
                Run();
            }
        }

        private void Run()
        {
            // EncryptionSettings
            Microsoft.Azure.Management.Compute.Models.EncryptionSettings vEncryptionSettings = null;

            // Sku
            Microsoft.Azure.Management.Compute.Models.DiskSku vSku = null;

            if (this.MyInvocation.BoundParameters.ContainsKey("EncryptionSettingsEnabled"))
            {
                if (vEncryptionSettings == null)
                {
                    vEncryptionSettings = new Microsoft.Azure.Management.Compute.Models.EncryptionSettings();
                }
                vEncryptionSettings.Enabled = this.EncryptionSettingsEnabled;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("DiskEncryptionKey"))
            {
                if (vEncryptionSettings == null)
                {
                    vEncryptionSettings = new Microsoft.Azure.Management.Compute.Models.EncryptionSettings();
                }
                vEncryptionSettings.DiskEncryptionKey = this.DiskEncryptionKey;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("KeyEncryptionKey"))
            {
                if (vEncryptionSettings == null)
                {
                    vEncryptionSettings = new Microsoft.Azure.Management.Compute.Models.EncryptionSettings();
                }
                vEncryptionSettings.KeyEncryptionKey = this.KeyEncryptionKey;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("SkuName"))
            {
                if (vSku == null)
                {
                    vSku = new Microsoft.Azure.Management.Compute.Models.DiskSku();
                }
                vSku.Name = this.SkuName;
            }

            var vDiskUpdate = new PSDiskUpdate
            {
                OsType = this.MyInvocation.BoundParameters.ContainsKey("OsType") ? this.OsType : (OperatingSystemTypes?) null,
                DiskSizeGB = this.MyInvocation.BoundParameters.ContainsKey("DiskSizeGB") ? this.DiskSizeGB : (int?) null,
                Tags = this.MyInvocation.BoundParameters.ContainsKey("Tag") ? this.Tag.Cast<DictionaryEntry>().ToDictionary(ht => (string)ht.Key, ht => (string)ht.Value) : null,
                EncryptionSettings = vEncryptionSettings,
                Sku = vSku,
            };

            WriteObject(vDiskUpdate);
        }
    }
}

