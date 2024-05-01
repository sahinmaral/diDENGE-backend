namespace diDENGE.Application.Features.Users.Helpers;

public static class UserHelpers
{
    public static string ConvertPhotoPathToPublicId(string photoPath)
    {
        string modifiedString = photoPath.Replace("image/upload/", "");
        int dotIndex = modifiedString.IndexOf('.');
        modifiedString = modifiedString.Substring(0, dotIndex);
        return modifiedString;
    }
}