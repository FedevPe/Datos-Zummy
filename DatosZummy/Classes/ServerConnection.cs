using System.Net;
using FluentFTP;

namespace DatosZummy.Classes
{
    internal class ServerConnection
    {
        public AsyncFtpClient FtpClient { get; set; } = new AsyncFtpClient();
        public Exception Ex { get; set; } = new();

        public async Task<bool> ConnectAsync()
        {
            try
            {
                var token = new CancellationToken();

                FtpClient.Host = "127.0.0.1";
                FtpClient.Port = 2121;
                FtpClient.Credentials = new NetworkCredential("CONFIDENTIAL", "");

                await FtpClient.Connect(token);

                if (FtpClient.IsConnected)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Ex = ex;
                return false;
            }
        }
        public void DisconnectServerFTP()
        {
            FtpClient.Disconnect();
        }

    }
}
