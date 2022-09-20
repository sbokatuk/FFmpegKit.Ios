using ObjCRuntime;
using System;

namespace FFmpegKit.Ios
{ 
    [Native]
    public enum LogRedirectionStrategy : ulong
    {
        AlwaysPrintLogs,
        PrintLogsWhenNoCallbacksDefined,
        PrintLogsWhenGlobalCallbackNotDefined,
        PrintLogsWhenSessionCallbackNotDefined,
        NeverPrintLogs
    }

    [Native]
    public enum ReturnCodeEnum : ulong
    {
        Success = 0,
        Cancel = 255
    }

    [Native]
    public enum SessionState : ulong
    {
        Created,
        Running,
        Failed,
        Completed
    }
}