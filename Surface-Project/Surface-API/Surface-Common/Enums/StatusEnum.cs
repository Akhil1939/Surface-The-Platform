namespace Surface.Common.Enums;
public static class StatusEnum
{
    public enum UserStatus
    {
        Active = 1,
        Inactive = 2,
        Reported = 3,
        Blocked = 4,
        Deleted = 5,
        Locked = 6,
    }

    public enum LanguageStatus
    {
        English = 1,
        French = 2,
    }

    public enum ProjectStatus
    {
        Planning = 7,
        Active = 8,
        OnHold = 9,
        Completed = 10,
        Cancelled = 11,
    }
}
