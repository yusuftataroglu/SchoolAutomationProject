namespace SchoolAutomationProject.Infrastructure.Helpers.FileUploadHelpers
{
    public static class FileUploader
    {
        public static string Upload(string fileName)
        {

            string newFileName = "";

            var uniqueName = Guid.NewGuid().ToString();

            var fileArray = fileName.Split('.');

            var extension = fileArray[fileArray.Length - 1];

            if (extension == "png" || extension == "jpg" || extension == "jpeg" || extension == "pdf" || extension == "docx" || extension == "txt")
            {
                newFileName = uniqueName + "." + extension;

                return newFileName;

            }
            else
            {
                return "0";
            }

        }
    }
}
