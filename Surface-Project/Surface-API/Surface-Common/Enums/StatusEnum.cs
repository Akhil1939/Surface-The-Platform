namespace Surface.Common.Enums;
public static class StatusEnum
{
    public enum UserStatus // status group  1
    {
        Active = 1,
        Inactive = 2,
        Reported = 3,
        Blocked = 4,
        Deleted = 5,
        Locked = 6,
    }

    public enum ProjectStatus //2
    {
        Planning = 7,
        Active = 8,
        OnHold = 9,
        Completed = 10,
        Cancelled = 11,

    }

    public enum TaskStatus   //3
    {
        ToDo = 12,
        InProgress = 13,
        Blocked = 14,
        Completed = 15,
        Deferred = 16
    }

    public enum FeatureStatus  //4
    {
        Idea = 17,
        Backlog=18,
        InProgress = 19,
        Testing = 20,
        Released = 21,

    }

    public enum BugStatus   //5
    {
        Reported = 22,
        InProgress =23,
        Reproduced = 24,
        Fixed = 25,
        Verified = 26,

    }
    public enum CustomerStoryStatus //6
    {
        Pending = 27,
        Reviewed = 28,
        InProgress = 29,
        Closed = 30,

    }
    public enum TeamMember  //7
    {
        Active =31,
        OnLeave = 32,
        Pending =33,
        Completed = 34,
        Resigned = 35,
        Suspended = 36,
        NotAssigned = 37
    }
}
