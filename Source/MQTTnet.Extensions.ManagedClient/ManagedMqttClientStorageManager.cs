// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


/* Unmerged change from project 'MQTTnet.Extensions.ManagedClient (netstandard1.3)'
Before:
using System;
After:
using MQTTnet.Internal;
using System;
*/

/* Unmerged change from project 'MQTTnet.Extensions.ManagedClient (net5.0)'
Before:
using System;
After:
using MQTTnet.Internal;
using System;
*/

/* Unmerged change from project 'MQTTnet.Extensions.ManagedClient (netcoreapp3.1)'
Before:
using System;
After:
using MQTTnet.Internal;
using System;
*/

/* Unmerged change from project 'MQTTnet.Extensions.ManagedClient (net6.0)'
Before:
using System;
After:
using MQTTnet.Internal;
using System;
*/

/* Unmerged change from project 'MQTTnet.Extensions.ManagedClient (uap10.0)'
Before:
using System;
After:
using MQTTnet.Internal;
using System;
*/

/* Unmerged change from project 'MQTTnet.Extensions.ManagedClient (net7.0)'
Before:
using System;
After:
using MQTTnet.Internal;
using System;
*/

/* Unmerged change from project 'MQTTnet.Extensions.ManagedClient (netstandard2.0)'
Before:
using System;
After:
using MQTTnet.Internal;
using System;
*/

/* Unmerged change from project 'MQTTnet.Extensions.ManagedClient (net452)'
Before:
using System;
After:
using MQTTnet.Internal;
using System;
*/

/* Unmerged change from project 'MQTTnet.Extensions.ManagedClient (net48)'
Before:
using System;
After:
using MQTTnet.Internal;
using System;
*/

/* Unmerged change from project 'MQTTnet.Extensions.ManagedClient (net461)'
Before:
using System;
After:
using MQTTnet.Internal;
using System;
*/
using MQTTnet.Internal;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MQTTnet.Extensions.ManagedClient
{
    public class ManagedMqttClientStorageManager
    {
        private readonly List<ManagedMqttApplicationMessage> _messages = new List<ManagedMqttApplicationMessage>();
        private readonly AsyncLock _messagesLock = new AsyncLock();

        private readonly IManagedMqttClientStorage _storage;

        public ManagedMqttClientStorageManager(IManagedMqttClientStorage storage)
        {
            _storage = storage ?? throw new ArgumentNullException(nameof(storage));
        }

        public async Task<List<ManagedMqttApplicationMessage>> LoadQueuedMessagesAsync()
        {
            var loadedMessages = await _storage.LoadQueuedMessagesAsync().ConfigureAwait(false);
            _messages.AddRange(loadedMessages);

            return _messages;
        }

        public async Task AddAsync(ManagedMqttApplicationMessage applicationMessage)
        {
            if (applicationMessage == null) throw new ArgumentNullException(nameof(applicationMessage));

            using (await _messagesLock.EnterAsync().ConfigureAwait(false))
            {
                _messages.Add(applicationMessage);
                await SaveAsync().ConfigureAwait(false);
            }
        }

        public async Task RemoveAsync(ManagedMqttApplicationMessage applicationMessage)
        {
            if (applicationMessage == null) throw new ArgumentNullException(nameof(applicationMessage));

            using (await _messagesLock.EnterAsync().ConfigureAwait(false))
            {
                var index = _messages.IndexOf(applicationMessage);
                if (index == -1)
                {
                    return;
                }

                _messages.RemoveAt(index);
                await SaveAsync().ConfigureAwait(false);
            }
        }

        private Task SaveAsync()
        {
            return _storage.SaveQueuedMessagesAsync(_messages);
        }
    }
}
