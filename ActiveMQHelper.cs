using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Apache.NMS.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zsq.Utils
{
    public sealed class ActiveMQHelper: IDisposable
    {
        private string _url;
        private string _user;
        private string _password;
        private IConnectionFactory _connectionFactory;
        private IConnection _connection;
        private ISession _session;

        public ActiveMQHelper(string _url,string _user,string _password)
        {
            this._url = _url;
            this._user = _user;
            this._password = _user;
        }

        public bool Connect()
        {
            _connectionFactory = new ConnectionFactory(_url);
            _connection = _connectionFactory.CreateConnection(_user, _password);
            _session = _connection.CreateSession();
            _connection.Start();

            return false;
        }

        public void Dispose()
        {
            _connection.Stop();
            _connection.Close();
            _connection.Dispose();
            _session.Close();
            _session.Dispose();
        }

        public bool WriteString(string queuesNameESF,string textmessage)
        {
            var destination = SessionUtil.GetDestination(_session, queuesNameESF);
            using (var producer = _session.CreateProducer(destination))
            {
                var request = _session.CreateTextMessage(textmessage);
                producer.Send(request);
            }
            return false;
        }

        public bool ReadString(string queuesNameESF)
        {
            var destination = SessionUtil.GetDestination(_session, queuesNameESF);
            using (var consumer = _session.CreateConsumer(destination))
            {
                var message = consumer.Receive() as ITextMessage;
            }
            return false;
        }
    }
}
