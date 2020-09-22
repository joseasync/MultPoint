namespace MultPoint.Models
{
    public class BasicCounter
    {
        
        private int _statusValue;
        public int StatusValue
        {
            get { return _statusValue; }
            set { _statusValue = value; }
        }
        
        public void Increase()
        {
            _statusValue++;
        }
    }
}