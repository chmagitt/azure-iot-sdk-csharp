﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.Azure.Devices.Shared;
using Newtonsoft.Json;

namespace Microsoft.Azure.Devices.Provisioning.Service
{
    public class RegistrationRequest
    {
        /// <summary>
        /// Registration ID.
        /// </summary>
        [JsonProperty(PropertyName = "registrationId")]
        public string RegistrationId { get; set; }

        /// <summary>
        /// Device ID.
        /// </summary>
        [JsonProperty(PropertyName = "deviceId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Attestation mechanism.
        /// </summary>
        [JsonProperty(PropertyName = "attestation")]
        public AttestationMechanism Attestation { get; set; }

        /// <summary>
        /// Device current state (current properties)
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public TwinCollection DeviceProperties { get; set; }

    }
}
