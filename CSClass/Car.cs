using System;

namespace CSClass
{
    internal class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        public void SetTime()
        {
            this.inTime = DateTime.Now;
        }

        public void SetoutTime()
        {
            this.outTime = DateTime.Now;
        }

        public void SetOutTime()
        {
            throw new NotImplementedException();
        }

        public void SetInTime()
        {
            throw new NotImplementedException();
        }
    }
}