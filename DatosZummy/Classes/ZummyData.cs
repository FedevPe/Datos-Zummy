using FluentFTP;

namespace DatosZummy.Classes
{
    internal class ZummyData
    {
        private ServerConnection connection = new();

        public async Task<List<FtpListItem>> GetListingAsync(string path)
        {
            List<FtpListItem> ftpFiles = new List<FtpListItem>();

            try
            {
                await connection.ConnectAsync();
                foreach (FtpListItem item in await connection.FtpClient.GetListing(path))
                {                    
                    ftpFiles.Add(item);
                }
                
                return ftpFiles;
            }
            catch (Exception)
            {
                connection.DisconnectServerFTP();
                throw;
            }
        }
        public async Task DownloadFilesFTP(string localPath, List<string> remotePathItems)
        {
            try
            {
                if (connection.FtpClient.IsConnected) 
                {                
                    await connection.FtpClient.DownloadFiles(localPath, remotePathItems, FtpLocalExists.Overwrite);
                }
            }
            catch (Exception)
            {
                connection.DisconnectServerFTP();
                throw;
            }

        }
    }
}
