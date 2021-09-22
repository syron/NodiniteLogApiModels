namespace nodiniteLogLibrary.Models 
{
    public enum EndPointDirection 
    {
        Receive = 0,
        Send = 1,
        TwoWayReceive = 10,
        TwoWaySend = 11,
        None = -2,
        Unknown = -1
    }
}