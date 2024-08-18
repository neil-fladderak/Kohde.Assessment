using System;

namespace Kohde.Assessment
{
    public delegate void MyEventHandler(string foo);

    public class DisposableObject : IDisposable
    {
        public event MyEventHandler SomethingHappened;

        public int Counter { get; private set; }

        public void PerformSomeLongRunningOperation()
        {
            // Better to use standard for loop if you know the range in terms of performance
            for (int i = 1; i < 11; i++)
                this.SomethingHappened += HandleSomethingHappened;

        }

        public void RaiseEvent(string data)
        {
            this.SomethingHappened?.Invoke(data);
        }

        private void HandleSomethingHappened(string foo)
        {
            this.Counter++;
            Console.WriteLine("HIT {0} => HandleSomethingHappened. Data: {1}", this.Counter, foo);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Dispose managed resources
            }

            // Free native resources
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~DisposableObject()
        {
            Dispose(false);
        }
    }
}