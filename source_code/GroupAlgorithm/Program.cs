namespace GroupAlgorithm
{
    /// <summary>
    /// Group Algorithm 설명
    ///
    /// 만약 원본 데이터에 RADIO 3개, TV 1개, RADIO 2개, 그리고 DVD 4개가 있다고 가정을 해봅시다.
    /// 그리고 그룹 알고리즘을 사용하게 되면 결과값은 아래와 같이 될것입니다.
    /// DVD 4개, RADIO 5개, 그리고 TV 1개
    ///
    /// products.txt 내용 (bin -> debug -> dotnet6)
    ///
    /// RADIO, 5
    /// TV, 6
    /// PHONE, 3
    /// RADIO, 2
    /// PHONE, 2
    /// TV, 10
    /// PHONE, 11
    /// TV, 7
    /// PHONE, 4
    /// </summary>
    public class Record : IComparable<Record>
    {
        private string name = "";
        private int quantity = 0;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public Record(string name, int quantity)
        {
            this.name = name;
            this.quantity = quantity;
        }
        public override string ToString()
        {
            return String.Format("Name : {0,5}, Quantity : {1}", name, quantity);
        }
        public int CompareTo(Record? other)
        {
            if (other == null)
            {
                throw new NotImplementedException();
            }
            return name.CompareTo(other.Name);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            // Input
            List<Record> GetRecords(string textFile)
            {
                FileInfo fileInfo = new FileInfo(textFile);
                if (fileInfo.Exists)
                {
                    string[] contents = null;
                    try
                    {
                        contents = File.ReadAllLines(textFile);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error happened while reading contents in the {0} file", textFile);
                        return null;
                    }
                    List<Record> records = new List<Record>();
                    string[] productInformation;
                    foreach(string content in contents)
                    {
                        productInformation = content.Split(",");
                        // Remove any spaces in a each index value
                        for(int i = 0; i < productInformation.Length; i++)
                        {
                            productInformation[i] = productInformation[i].Trim();
                        }
                        string name = productInformation[0];
                        int quantity = 0;
                        try
                        {
                            quantity = Convert.ToInt32(productInformation[1]);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please check the {0} file content format", textFile);
                            Console.WriteLine("The format must be \"product\", \"quantity\"");
                            Console.WriteLine("ex) TV, 3");
                            Console.WriteLine("ex) PHONE, 2");
                            return null;
                        }
                        records.Add(new Record(name, quantity));
                    }
                    return records;
                }
                else
                {
                    Console.WriteLine("{0} file is not exist", textFile);
                    return null;
                }

            }
            // Process
            List<Record> records = GetRecords("products.txt");
            List<Record> groupedRecords = null;
            if (records != null)
            {
                // grouping process
                groupedRecords = new List<Record>();
                records.Sort();
                string name = records[0].Name;
                int quantity = records[0].Quantity;
                for(int i = 1; i < records.Count; i++)
                {
                    if(name == records[i].Name)
                    {
                        quantity += records[i].Quantity;
                    }
                    else
                    {
                        groupedRecords.Add(new Record(name, quantity));
                        name = records[i].Name;
                        quantity = records[i].Quantity;
                    }

                    if(i == records.Count - 1)
                    {
                        groupedRecords.Add(new Record(name, quantity));
                    }
                }
            }
            // Output
            if(groupedRecords == null || records == null)
            {
                Console.WriteLine("Fail for grouping the products");
            }
            else
            {
                Console.WriteLine("Sucess for sorting the products");
                foreach(Record record1 in records)
                {
                    Console.WriteLine(record1.ToString());
                }
                Console.WriteLine("\nSuccess for grouping the products");
                foreach (Record record in groupedRecords)
                {
                    Console.WriteLine(record.ToString());
                }
            }
            // Result
            /*
             *  Sucess for sorting the products
                Name : PHONE, Quantity : 3
                Name : PHONE, Quantity : 2
                Name : PHONE, Quantity : 11
                Name : PHONE, Quantity : 4
                Name : RADIO, Quantity : 5
                Name : RADIO, Quantity : 2
                Name :    TV, Quantity : 6
                Name :    TV, Quantity : 10
                Name :    TV, Quantity : 7

                Success for grouping the products
                Name : PHONE, Quantity : 20
                Name : RADIO, Quantity : 7
                Name :    TV, Quantity : 23
             */

        }
    }
}