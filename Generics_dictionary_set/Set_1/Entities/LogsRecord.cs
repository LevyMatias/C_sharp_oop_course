using System;
using System.Collections.Generic;

namespace Set_1.Entities
{
    class LogsRecord
    {
        public string UserName { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is LogsRecord))
            {
                return false;
            }
            LogsRecord other = obj as LogsRecord;
            return UserName.Equals(other.UserName);
        }
    }
}
