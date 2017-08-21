namespace Indexer
{
    public class Student
    {
        private int[] _examScores = { 9, 8, 5, 9, 10, 6 };

        public int this[int index]
        {
            get { return _examScores[index]; }
            set { _examScores[index] = value; }
        }
    }
}