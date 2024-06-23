// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


/* Unmerged change from project 'MQTTnet (netstandard2.1)'
Before:
using System;
using System.Linq;
using MQTTnet.Implementations;
using MQTTnet.Internal;
After:
using MQTTnet.Implementations;
using MQTTnet.Internal;
using System;
using System.Linq;
*/

/* Unmerged change from project 'MQTTnet (net7.0)'
Before:
using System;
using System.Linq;
using MQTTnet.Implementations;
using MQTTnet.Internal;
After:
using MQTTnet.Implementations;
using MQTTnet.Internal;
using System;
using System.Linq;
*/

/* Unmerged change from project 'MQTTnet (netcoreapp3.1)'
Before:
using System;
using System.Linq;
using MQTTnet.Implementations;
using MQTTnet.Internal;
After:
using MQTTnet.Implementations;
using MQTTnet.Internal;
using System;
using System.Linq;
*/

/* Unmerged change from project 'MQTTnet (net8.0)'
Before:
using System;
using System.Linq;
using MQTTnet.Implementations;
using MQTTnet.Internal;
After:
using MQTTnet.Implementations;
using MQTTnet.Internal;
using System;
using System.Linq;
*/

/* Unmerged change from project 'MQTTnet (net48)'
Before:
using System;
using System.Linq;
using MQTTnet.Implementations;
using MQTTnet.Internal;
After:
using MQTTnet.Implementations;
using MQTTnet.Internal;
using System;
using System.Linq;
*/

/* Unmerged change from project 'MQTTnet (net461)'
Before:
using System;
using System.Linq;
using MQTTnet.Implementations;
using MQTTnet.Internal;
After:
using MQTTnet.Implementations;
using MQTTnet.Internal;
using System;
using System.Linq;
*/

/* Unmerged change from project 'MQTTnet (netstandard1.3)'
Before:
using System;
using System.Linq;
using MQTTnet.Implementations;
using MQTTnet.Internal;
After:
using MQTTnet.Implementations;
using MQTTnet.Internal;
using System;
using System.Linq;
*/

/* Unmerged change from project 'MQTTnet (net452)'
Before:
using System;
using System.Linq;
using MQTTnet.Implementations;
using MQTTnet.Internal;
After:
using MQTTnet.Implementations;
using MQTTnet.Internal;
using System;
using System.Linq;
*/

/* Unmerged change from project 'MQTTnet (uap10.0)'
Before:
using System;
using System.Linq;
using MQTTnet.Implementations;
using MQTTnet.Internal;
After:
using MQTTnet.Implementations;
using MQTTnet.Internal;
using System;
using System.Linq;
*/

/* Unmerged change from project 'MQTTnet (net5.0)'
Before:
using System;
using System.Linq;
using MQTTnet.Implementations;
using MQTTnet.Internal;
After:
using MQTTnet.Implementations;
using MQTTnet.Internal;
using System;
using System.Linq;
*/

/* Unmerged change from project 'MQTTnet (netstandard2.0)'
Before:
using System;
using System.Linq;
using MQTTnet.Implementations;
using MQTTnet.Internal;
After:
using MQTTnet.Implementations;
using MQTTnet.Internal;
using System;
using System.Linq;
*/
using MQTTnet.Internal;
using System;
using System.Linq;

namespace MQTTnet.Formatter
{
    public readonly struct MqttPacketBuffer
    {

        /* Unmerged change from project 'MQTTnet (netstandard2.1)'
        Before:
                static readonly ArraySegment<byte> EmptyPayload = EmptyBuffer.ArraySegment;

                public MqttPacketBuffer(ArraySegment<byte> packet, ArraySegment<byte> payload)
        After:
                static readonly ArraySegment<byte> EmptyPayload = EmptyBuffer.ArraySegment;

                public MqttPacketBuffer(ArraySegment<byte> packet, ArraySegment<byte> payload)
        */

        /* Unmerged change from project 'MQTTnet (net7.0)'
        Before:
                static readonly ArraySegment<byte> EmptyPayload = EmptyBuffer.ArraySegment;

                public MqttPacketBuffer(ArraySegment<byte> packet, ArraySegment<byte> payload)
        After:
                static readonly ArraySegment<byte> EmptyPayload = EmptyBuffer.ArraySegment;

                public MqttPacketBuffer(ArraySegment<byte> packet, ArraySegment<byte> payload)
        */

        /* Unmerged change from project 'MQTTnet (netcoreapp3.1)'
        Before:
                static readonly ArraySegment<byte> EmptyPayload = EmptyBuffer.ArraySegment;

                public MqttPacketBuffer(ArraySegment<byte> packet, ArraySegment<byte> payload)
        After:
                static readonly ArraySegment<byte> EmptyPayload = EmptyBuffer.ArraySegment;

                public MqttPacketBuffer(ArraySegment<byte> packet, ArraySegment<byte> payload)
        */

        /* Unmerged change from project 'MQTTnet (net8.0)'
        Before:
                static readonly ArraySegment<byte> EmptyPayload = EmptyBuffer.ArraySegment;

                public MqttPacketBuffer(ArraySegment<byte> packet, ArraySegment<byte> payload)
        After:
                static readonly ArraySegment<byte> EmptyPayload = EmptyBuffer.ArraySegment;

                public MqttPacketBuffer(ArraySegment<byte> packet, ArraySegment<byte> payload)
        */

        /* Unmerged change from project 'MQTTnet (net48)'
        Before:
                static readonly ArraySegment<byte> EmptyPayload = EmptyBuffer.ArraySegment;

                public MqttPacketBuffer(ArraySegment<byte> packet, ArraySegment<byte> payload)
        After:
                static readonly ArraySegment<byte> EmptyPayload = EmptyBuffer.ArraySegment;

                public MqttPacketBuffer(ArraySegment<byte> packet, ArraySegment<byte> payload)
        */

        /* Unmerged change from project 'MQTTnet (net461)'
        Before:
                static readonly ArraySegment<byte> EmptyPayload = EmptyBuffer.ArraySegment;

                public MqttPacketBuffer(ArraySegment<byte> packet, ArraySegment<byte> payload)
        After:
                static readonly ArraySegment<byte> EmptyPayload = EmptyBuffer.ArraySegment;

                public MqttPacketBuffer(ArraySegment<byte> packet, ArraySegment<byte> payload)
        */

        /* Unmerged change from project 'MQTTnet (netstandard1.3)'
        Before:
                static readonly ArraySegment<byte> EmptyPayload = EmptyBuffer.ArraySegment;

                public MqttPacketBuffer(ArraySegment<byte> packet, ArraySegment<byte> payload)
        After:
                static readonly ArraySegment<byte> EmptyPayload = EmptyBuffer.ArraySegment;

                public MqttPacketBuffer(ArraySegment<byte> packet, ArraySegment<byte> payload)
        */

        /* Unmerged change from project 'MQTTnet (net452)'
        Before:
                static readonly ArraySegment<byte> EmptyPayload = EmptyBuffer.ArraySegment;

                public MqttPacketBuffer(ArraySegment<byte> packet, ArraySegment<byte> payload)
        After:
                static readonly ArraySegment<byte> EmptyPayload = EmptyBuffer.ArraySegment;

                public MqttPacketBuffer(ArraySegment<byte> packet, ArraySegment<byte> payload)
        */

        /* Unmerged change from project 'MQTTnet (uap10.0)'
        Before:
                static readonly ArraySegment<byte> EmptyPayload = EmptyBuffer.ArraySegment;

                public MqttPacketBuffer(ArraySegment<byte> packet, ArraySegment<byte> payload)
        After:
                static readonly ArraySegment<byte> EmptyPayload = EmptyBuffer.ArraySegment;

                public MqttPacketBuffer(ArraySegment<byte> packet, ArraySegment<byte> payload)
        */

        /* Unmerged change from project 'MQTTnet (net5.0)'
        Before:
                static readonly ArraySegment<byte> EmptyPayload = EmptyBuffer.ArraySegment;

                public MqttPacketBuffer(ArraySegment<byte> packet, ArraySegment<byte> payload)
        After:
                static readonly ArraySegment<byte> EmptyPayload = EmptyBuffer.ArraySegment;

                public MqttPacketBuffer(ArraySegment<byte> packet, ArraySegment<byte> payload)
        */

        /* Unmerged change from project 'MQTTnet (netstandard2.0)'
        Before:
                static readonly ArraySegment<byte> EmptyPayload = EmptyBuffer.ArraySegment;

                public MqttPacketBuffer(ArraySegment<byte> packet, ArraySegment<byte> payload)
        After:
                static readonly ArraySegment<byte> EmptyPayload = EmptyBuffer.ArraySegment;

                public MqttPacketBuffer(ArraySegment<byte> packet, ArraySegment<byte> payload)
        */
        static readonly ArraySegment<byte> EmptyPayload = EmptyBuffer.ArraySegment;

        public MqttPacketBuffer(ArraySegment<byte> packet, ArraySegment<byte> payload)
        {
            Packet = packet;
            Payload = payload;

            Length = Packet.Count + Payload.Count;

            /* Unmerged change from project 'MQTTnet (netstandard2.1)'
            Before:
                    }

                    public MqttPacketBuffer(ArraySegment<byte> packet)
            After:
                    }

                    public MqttPacketBuffer(ArraySegment<byte> packet)
            */

            /* Unmerged change from project 'MQTTnet (net7.0)'
            Before:
                    }

                    public MqttPacketBuffer(ArraySegment<byte> packet)
            After:
                    }

                    public MqttPacketBuffer(ArraySegment<byte> packet)
            */

            /* Unmerged change from project 'MQTTnet (netcoreapp3.1)'
            Before:
                    }

                    public MqttPacketBuffer(ArraySegment<byte> packet)
            After:
                    }

                    public MqttPacketBuffer(ArraySegment<byte> packet)
            */

            /* Unmerged change from project 'MQTTnet (net8.0)'
            Before:
                    }

                    public MqttPacketBuffer(ArraySegment<byte> packet)
            After:
                    }

                    public MqttPacketBuffer(ArraySegment<byte> packet)
            */

            /* Unmerged change from project 'MQTTnet (net48)'
            Before:
                    }

                    public MqttPacketBuffer(ArraySegment<byte> packet)
            After:
                    }

                    public MqttPacketBuffer(ArraySegment<byte> packet)
            */

            /* Unmerged change from project 'MQTTnet (net461)'
            Before:
                    }

                    public MqttPacketBuffer(ArraySegment<byte> packet)
            After:
                    }

                    public MqttPacketBuffer(ArraySegment<byte> packet)
            */

            /* Unmerged change from project 'MQTTnet (netstandard1.3)'
            Before:
                    }

                    public MqttPacketBuffer(ArraySegment<byte> packet)
            After:
                    }

                    public MqttPacketBuffer(ArraySegment<byte> packet)
            */

            /* Unmerged change from project 'MQTTnet (net452)'
            Before:
                    }

                    public MqttPacketBuffer(ArraySegment<byte> packet)
            After:
                    }

                    public MqttPacketBuffer(ArraySegment<byte> packet)
            */

            /* Unmerged change from project 'MQTTnet (uap10.0)'
            Before:
                    }

                    public MqttPacketBuffer(ArraySegment<byte> packet)
            After:
                    }

                    public MqttPacketBuffer(ArraySegment<byte> packet)
            */

            /* Unmerged change from project 'MQTTnet (net5.0)'
            Before:
                    }

                    public MqttPacketBuffer(ArraySegment<byte> packet)
            After:
                    }

                    public MqttPacketBuffer(ArraySegment<byte> packet)
            */

            /* Unmerged change from project 'MQTTnet (netstandard2.0)'
            Before:
                    }

                    public MqttPacketBuffer(ArraySegment<byte> packet)
            After:
                    }

                    public MqttPacketBuffer(ArraySegment<byte> packet)
            */
        }

        public MqttPacketBuffer(ArraySegment<byte> packet)
        {
            Packet = packet;
            Payload = EmptyPayload;

            Length = Packet.Count;
        }

        public int Length { get; }

        public ArraySegment<byte> Packet { get; }

        public ArraySegment<byte> Payload { get; }

        public byte[] ToArray()
        {
            if (Payload.Count == 0)
            {
                return Packet.ToArray();
            }

            var buffer = new byte[Length];
            MqttMemoryHelper.Copy(Packet.Array, Packet.Offset, buffer, 0, Packet.Count);
            MqttMemoryHelper.Copy(Payload.Array, Payload.Offset, buffer, Packet.Count, Payload.Count);

            return buffer;
        }

        public ArraySegment<byte> Join()
        {
            if (Payload.Count == 0)
            {
                return Packet;
            }

            var buffer = new byte[Length];
            MqttMemoryHelper.Copy(Packet.Array, Packet.Offset, buffer, 0, Packet.Count);
            MqttMemoryHelper.Copy(Payload.Array, Payload.Offset, buffer, Packet.Count, Payload.Count);

            return new ArraySegment<byte>(buffer);
        }
    }
}