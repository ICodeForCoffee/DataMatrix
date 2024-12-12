namespace DataMatrix
{
    ///Just some data
    public class Data 
    {
        public List<string> FirstNameList { get; set; }
        public List<string> LastNameList { get; set; }

        public Data()
        {
            FirstNameList = new List<string>() { "Alex", "Bobby", "Janet", "James"};
            LastNameList = new List<string>() {"Carter", "Smith"};
        }
    }
}