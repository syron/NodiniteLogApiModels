using System;
using System.Collections.Generic;

namespace nodiniteLogLibrary.Models
{
    public class LogEvent
    {
        public int LogAgentValueId { get; set; }
        public string EndPointName { get; set; }
        public string EndPointUri { get; set; }
        public EndPointDirection EndPointDirection { get; set; }
        public int EndPointTypeId { get; set; }
        public string OriginalMessageTypeName { get; set; }
        public EventDirection EventDirection { get; set; }
        public DateTimeOffset LogDateTime { get; set; }
        public string ProcessingUser { get; set; }
        public int SequenceNo { get; set; }
        public int EventNumber { get; set; }
        public string LogText { get; set; }
        public string ApplicationInterchangeId { get; set; }
        public int LogStatus { get; set; }
        public string ProcessName { get; set; }
        public string ProcessingMachineName { get; set; }
        public string ProcessingModuleName { get; set; }
        public string ProcessingModuleType { get; set; }
        public long ProcessingTime { get; set; }
        public string Body { get; set; }
        public Dictionary<string, string> Context { get; set; }
    }
}
