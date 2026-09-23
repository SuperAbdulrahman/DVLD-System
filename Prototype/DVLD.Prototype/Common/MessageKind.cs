namespace DVLD.Prototype.Common
{
    /// <summary>
    /// The 3 dialog variants formalized from the original app's de-facto
    /// convention (report: "Confirm changes"/"Caution" OKCancel Exclamation
    /// -> "Success" OK Information -> "Failure"/"Error" OK Error).
    /// </summary>
    public enum MessageKind
    {
        Confirm,
        Success,
        Failure,
    }
}
