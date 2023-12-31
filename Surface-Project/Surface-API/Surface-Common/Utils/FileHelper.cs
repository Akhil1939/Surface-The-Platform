
using Common.CustomExceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Surface.Common.Constants;

namespace   Surface.Common.Utils;

public class FileHepler
{
    private readonly IHostEnvironment _env;

    public FileHepler(IHostEnvironment env) { _env = env; }

    public async Task<KeyValuePair<string, string>> UploadFileToDestination(IFormFile file, string TargetDirectoryName, long UserId)
    {
        try
        {
            string TargetDirectoryPath = _env.ContentRootPath + SystemConstant.WWWROOT_PATH + SystemConstant.ASSETS_PATH + TargetDirectoryName;
            if (!Directory.Exists(TargetDirectoryPath))
            {
                Directory.CreateDirectory(TargetDirectoryPath);
            }
            string currentTime = DateTimeOffset.Now.ToString("yyyyMMddHHmmss");
            string UniqueFileName = $"{UserId}_{currentTime}_{file.FileName}";
            string TargetFilePath = Path.Combine(TargetDirectoryPath, UniqueFileName);

            using (var fileStream = new FileStream(TargetFilePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            string RelativeFilePath = $"{SystemConstant.ASSETS_PATH}{TargetDirectoryName}/{UniqueFileName}";
            return new KeyValuePair<string, string>(RelativeFilePath, file.ContentType);
        }
        catch
        {
            throw new FileNullException("File NOt Found");
        }
    }

    //TODO : Changes related to requirement
    public bool DeleteFileFromDestination(string FilePath)
    {
        if (FilePath.Equals(SystemConstant.DEFAULT_AVATAR)) return true;
        try
        {
            string TargetFilePath = $"{_env.ContentRootPath}{FilePath}";
            if (File.Exists(TargetFilePath))
            {
                File.Delete(TargetFilePath);
            }
            return true;
        }
        catch (Exception)
        {
            throw new FileNotFoundException($"{FilePath} not found");
        }
    }

    public void Dispose()
    {

    }
}
