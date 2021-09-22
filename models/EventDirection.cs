namespace nodiniteLogLibrary.Models 
{
    public enum EventDirection 
    {
        Default = 0,
        ExternalIncoming = 17,
        ExternalIncomingRequest = 21,
        ExternalIncomingResponse = 25,
        ExternalOutgoing = 18,
        ExternalOutgoingRequest = 22,
        ExternalOutgoingResponse = 26,
        InternalIncoming = 33,
        InternalOutgoing = 34,
        ProcessIncoming = 65,
        ProcessOutgoing = 66
    }
}