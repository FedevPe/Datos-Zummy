using FluentFTP;

namespace DatosZummy.Classes
{
    internal class ZummyData
    {
        private ServerConnection connection;

        public async Task<List<FtpListItem>> GetListingAsync(string path)
        {
            List<FtpListItem> ftpFiles = new List<FtpListItem>();
            connection = new ServerConnection();

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
        public async Task<List<FtpListItem>> GetDirectoriesAsync(string path)
        {
            List<FtpListItem> ftpDirectories = new List<FtpListItem>();
            connection = new ServerConnection();

            try
            {
                await connection.ConnectAsync();

                foreach (FtpListItem item in await connection.FtpClient.GetListing(path, FtpListOption.Recursive))
                {
                    if (item.Type == FtpObjectType.Directory)
                    {
                        ftpDirectories.Add(item);
                    }
                }

                return ftpDirectories;
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
