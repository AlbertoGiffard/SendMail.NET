using System.IO;

namespace Entity
{
    public class FileAttach : IValidationAttacher
    {
        private int campaignId;
        private string nameFile;
        private string filePath;

        public FileAttach()
        {
        }

        public FileAttach(string nameFile, string filePath)
        {
            this.campaignId = -1;
            this.nameFile = nameFile;
            this.filePath = filePath;
        }
        public FileAttach(int campaignId, string nameFile, string filePath) : this(nameFile, filePath)
        {
            this.campaignId = campaignId;
        }

        public int CampaignId { get => campaignId; set => campaignId = value; }
        public string NameFile { get => nameFile; set => nameFile = value; }
        public string FilePath { get => filePath; set => filePath = value; }
        /// <summary>
        /// Valida el tamaño del archivo subido
        /// </summary>
        /// <param name="path"></param>
        /// <returns> true si es menor a 5mb</returns>
        public bool ValidateSize(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            long fileSize = fileInfo.Length;
            bool result = true;

            if (fileSize > 5000000)
            {
                result = false;
            }

            return result;
        }
        /// <summary>
        /// Sobreescritura del metodo que trae los datos de la campaña con adjunto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result = $"ID de campaña: {this.campaignId} ; Archivo Adjunto: {this.nameFile}";

            return result;
        }
    }
}
