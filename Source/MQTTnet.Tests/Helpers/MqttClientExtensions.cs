// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using MQTTnet.Client;
using MQTTnet.Tests.Mockups;
using System;

namespace MQTTnet.Tests.Helpers
{
    public static class MqttClientExtensions
    {
        public static TestApplicationMessageReceivedHandler TrackReceivedMessages(this IMqttClient client)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            return new TestApplicationMessageReceivedHandler(client);
        }
    }
}