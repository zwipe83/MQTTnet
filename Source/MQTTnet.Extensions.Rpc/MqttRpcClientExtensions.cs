// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using MQTTnet.Protocol;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MQTTnet.Extensions.Rpc
{
    public static class MqttRpcClientExtensions
    {
        public static Task<byte[]> ExecuteAsync(this IMqttRpcClient client, TimeSpan timeout, string methodName, string payload, MqttQualityOfServiceLevel qualityOfServiceLevel, IDictionary<string, object> parameters = null)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));

            var buffer = Encoding.UTF8.GetBytes(payload ?? string.Empty);

            return client.ExecuteAsync(timeout, methodName, buffer, qualityOfServiceLevel, parameters);
        }
    }
}