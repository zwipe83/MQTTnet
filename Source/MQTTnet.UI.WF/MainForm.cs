using MQTTnet.Client;
using System.Security.Authentication;
using System.Text;

namespace MQTTnet.UI.WF
{
    public partial class MainForm : Form
    {

        // Assuming you need a custom signature for your event. If not, use an existing standard event delegate
        public delegate void myDelegate(object sender, MqttApplicationMessageReceivedEventArgs e);

        // Expose the event off your component
        public event myDelegate? MessageReceived;

        public MainForm()
        {
            InitializeComponent();

            InitGUI();
        }

        private void InitGUI()
        {
            txtBroker.Text = "fd1b9e0f0f2b4c72af7eb03f4eb96551.s1.eu.hivemq.cloud";
            txtPort.Text = "8883";
            txtUser.Text = "rootroot!";
            txtPass.Text = "Pass1234!";
            txtTopic.Text = "beer";

            lstResponse.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lstResponse.View = View.Details;
            lstResponse.Columns.Add("Responses");
            lstResponse.Items.Clear();
            lstResponse.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Clickable;
            lstResponse.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //Connect_Client_Using_TLS_1_2();
            TlsSubscribe(txtBroker.Text, int.Parse(txtPort.Text), txtUser.Text, txtPass.Text, txtTopic.Text);
        }
        public static string PayloadToString(byte[] _array, int _offset, int _count)
        {
            var payloadText = string.Empty;
            if (_count > 0)
            {
                payloadText = Encoding.UTF8.GetString(
                    _array,
                    _offset,
                    _count);

            }
            return payloadText;
        }

        public async Task TlsSubscribe(string broker, int port, string user, string pass, string topic)//(string ca, string user, string pass, string topic)
        {
            //string broker = "fd1b9e0f0f2b4c72af7eb03f4eb96551.s1.eu.hivemq.cloud";
            //int port = 8883;
            string clientId = Guid.NewGuid().ToString();

            // Create a MQTT client factory
            var factory = new MqttFactory();

            // Create a MQTT client instance
            var mqttClient = factory.CreateMqttClient();

            // Create MQTT client options
            var options = new MqttClientOptionsBuilder()
                .WithTcpServer(broker, port) // MQTT broker address and port
                .WithCredentials(user, pass) // Set username and password
                .WithClientId(clientId)
                .WithCleanSession()
                    .WithTlsOptions(
                        o =>
                        {
                            // The used public broker sometimes has invalid certificates. This sample accepts all
                            // certificates. This should not be used in live environments.
                            o.WithCertificateValidationHandler(_ => true);

                            // The default value is determined by the OS. Set manually to force version.
                            o.WithSslProtocols(SslProtocols.Tls12);
                            o.WithAllowUntrustedCertificates(true);
                        })
                    .Build();

            // Connect to MQTT broker
            var connectResult = await mqttClient.ConnectAsync(options);

            if (connectResult.ResultCode == MqttClientConnectResultCode.Success)
            {
                //Console.WriteLine("Connected to MQTT broker successfully.");
                btnConnect.Enabled = false;

                // Subscribe to a topic
                await mqttClient.SubscribeAsync(topic);

                // Callback function when a message is received
                mqttClient.ApplicationMessageReceivedAsync += e =>
                {
                    MessageReceived?.Invoke(this, e);

                    AddItemToListView(e);

                    return Task.CompletedTask;
                };
            }
            else
            {
                var dummy = 0;
            }
        }
        private void AddItemToListView(MqttApplicationMessageReceivedEventArgs e)
        {
            string s = PayloadToString(e.ApplicationMessage.PayloadSegment.Array, e.ApplicationMessage.PayloadSegment.Offset, e.ApplicationMessage.PayloadSegment.Count);

            // Invoke the UI thread to add the item to the lstResponse control
            Invoke((MethodInvoker)delegate
            {
                lstResponse.Items.Add(s);
                lstResponse.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lstResponse.Refresh();
            });
        }

        public static async Task Connect_Client_Using_TLS_1_2()
        {
            /*
             * This sample creates a simple MQTT client and connects to a public broker using TLS 1.2 encryption.
             * 
             * This is a modified version of the sample _Connect_Client_! See other sample for more details.
             */

            var mqttFactory = new MqttFactory();

            using (var mqttClient = mqttFactory.CreateMqttClient())
            {
                var mqttClientOptions = new MqttClientOptionsBuilder().WithTcpServer("fd1b9e0f0f2b4c72af7eb03f4eb96551.s1.eu.hivemq.cloud", 8883)
                    .WithCredentials("rootroot!", "Pass1234!")
                    .WithTlsOptions(
                        o =>
                        {
                            // The used public broker sometimes has invalid certificates. This sample accepts all
                            // certificates. This should not be used in live environments.
                            o.WithCertificateValidationHandler(_ => true);

                            // The default value is determined by the OS. Set manually to force version.
                            o.WithSslProtocols(SslProtocols.Tls12);
                            o.WithAllowUntrustedCertificates(true);
                        })
                    .Build();

                using (var timeout = new CancellationTokenSource(25000))
                {
                    await mqttClient.ConnectAsync(mqttClientOptions, timeout.Token);
                    Console.WriteLine("The MQTT client is connected.");
                }
            }
        }

        public static async Task Connect_Client()
        {
            /*
             * This sample creates a simple MQTT client and connects to a public broker.
             *
             * Always dispose the client when it is no longer used.
             * The default version of MQTT is 3.1.1.
             */

            var mqttFactory = new MqttFactory();

            using (var mqttClient = mqttFactory.CreateMqttClient())
            {
                // Use builder classes where possible in this project.
                var mqttClientOptions = new MqttClientOptionsBuilder().WithTcpServer("fd1b9e0f0f2b4c72af7eb03f4eb96551.s1.eu.hivemq.cloud", 8883).Build();

                string pass = "Pass1234!";
                byte[] passBytes = Encoding.UTF8.GetBytes(pass);

                //mqttClientOptions.Credentials = new MqttClientCredentials("rootroot!", passBytes);
                // This will throw an exception if the server is not available.
                // The result from this message returns additional data which was sent 
                // from the server. Please refer to the MQTT protocol specification for details.
                var response = await mqttClient.ConnectAsync(mqttClientOptions, CancellationToken.None);

                Console.WriteLine("The MQTT client is connected.");

                //response.DumpToConsole();

                // Send a clean disconnect to the server by calling _DisconnectAsync_. Without this the TCP connection
                // gets dropped and the server will handle this as a non clean disconnect (see MQTT spec for details).
                var mqttClientDisconnectOptions = mqttFactory.CreateClientDisconnectOptionsBuilder().Build();

                await mqttClient.DisconnectAsync(mqttClientDisconnectOptions, CancellationToken.None);
            }
        }
    }
}
