namespace Contact {
    internal class Program {
        static string Input(string prompt) {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        //making data available everywhere
        struct Contact {
            public string firstName;
            public string lastName;
            public string address;
            public string city;
            public string state;
            public string zipCode;
            public string title;
        }//end struct


        static void Main(string[] args) {
            static void Main(string[] args) {
            int userSelection = 0;

            while (userSelection != 3) {
                userSelection = Menu();

                switch (userSelection) {
                    case 0: { Search(); break; }
                    case 1: { Add(); break; }
                    case 2: { Exit(); break; }
                    }//end
                    if (userSelection != 15) {
                        Input("Press enter to go back to the menu");
                    }
                }
                Console.WriteLine("Thanks for using my program");
            }//end main
            static int Menu() {
                int userSelection = 0;

                do {
                    Console.Clear();
                    Console.WriteLine("Please make a selection from the menu.");
                    Console.WriteLine("1. Search");
                    Console.WriteLine("2. Add");
                    Console.WriteLine("3. Exit");

                    userSelection = int.Parse(Input("Selection"));
                } while (userSelection < 0 || userSelection > 3);
                //return selection
                return userSelection;
            }//end menu

            static void Search();
            {

            }
            static void Add();
            {

            }
            static void Exit() { }



             //creates variable for file
            string path = "C:\\Users\\Cody\\contacts.dat";
            string data = "";
            string[] records;
            string name = Input("Please enter the first name of the person you're searching.");
            string name2 = Input("Please enter the last name of the person you're searching.");

            Contact[] info;

            //read data from file
            FileStream inFile = new FileStream(path, FileMode.Open);
            while (inFile.Position < inFile.Length) {
                data += (char)inFile.ReadByte();
            }//end while

            inFile.Close();

            //split data to records
            records = data.Split($"{30}");
            char unitSeperator = (char)31;
            //create array to hold records of contact
            info = new Contact[records.Length - 1];

            for (int recordNum = 0; recordNum < records.Length; recordNum++) {
                string currentrecord = records[recordNum];
                string[] field = currentrecord.Split($"{31}");

                info[recordNum - 1].firstName = field[0];
                info[recordNum - 1].lastName = field[1];
                info[recordNum - 1].address = field[2];
                info[recordNum - 1].city = field[3];
                info[recordNum - 1].state = field[4];
                info[recordNum - 1].zipCode = field[5];
                info[recordNum - 1].title = field[6];
                //
            }
        }
    }
}