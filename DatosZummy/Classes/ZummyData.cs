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
                throw;
            }
            finally
            {
                connection.DisconnectServerFTP();
            }
        }
        public async Task DownloadFilesFTP(string pathLocal, List<string> filePathDownload)
        {
            try
            {
                await connection.ConnectAsync();
                await connection.FtpClient.DownloadFiles(pathLocal, filePathDownload);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.DisconnectServerFTP();
            }

        }
    }
}
