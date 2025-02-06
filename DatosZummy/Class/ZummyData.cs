using FluentFTP;

namespace DatosZummy.Class
{
    internal class ZummyData
    {
        private ServerConnection connection;

        public async Task<List<FtpListItem>> GetFilesAsync(string path)
        {
            List<FtpListItem> ftpFiles = new List<FtpListItem>();
            connection = new ServerConnection();

            try
            {
                await connection.ConnectAsync();

                foreach (FtpListItem item in await connection.FtpClient.GetListing(path, FtpListOption.Recursive))
                {
                    if (item.Type == FtpObjectType.Directory)
                    {
                        ftpFiles.Add(item);
                    }
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
    }
}
