
namespace CodeAcedmyCompany
{
    public static class DocumentConf
    {
        public static string DocumentUpload(IFormFile file , string folderName)
        {
          
            string folderpath = Path.Combine(Directory .GetCurrentDirectory(), "wwwroot, Files",folderName);
            string fileName = $"{Guid.NewGuid()}{file.Name}";
            string filePath = Path.Combine(folderpath, fileName);

            var fs = new FileStream(filePath, FileMode.Create);
            file.CopyTo(fs);

            return filePath;
        }
    }
}
