public class DayThree{

    string line = "";
    string line2 = "";
    string line3 = "";
    string first = "";
    string second = "";

    List<char> list = new List<char>();
    Dictionary<char, int> dict = new Dictionary<char, int>();
    StreamReader  sr = new StreamReader("Day3/input.txt");

    public DayThree(){
        fillDictionary();
        //PartOne();
        PartTwo();
    }

    public void PartTwo(){
        line = sr.ReadLine();
        line2 = sr.ReadLine();
        line3 = sr.ReadLine();

        while(line3 != null){
            var common = line.Intersect(line2);
            char common1 = common.Intersect(line3).First();
            list.Add(common1);

            line = sr.ReadLine();
            line2 = sr.ReadLine();
            line3 = sr.ReadLine();
        }

        int total = getTotal();
        System.Console.WriteLine(total);

    }

    public void PartOne(){
        line = sr.ReadLine();

        while(line != null){
            first = line[..(line.Length / 2)];
            second = line[(line.Length / 2)..];
            char common = first.Intersect(second).First();
            list.Add(common);
            line = sr.ReadLine();
       }
       
       int total = getTotal();
       System.Console.WriteLine(total);
    }

    public int getTotal(){
        int total = 0;
        foreach(char c in list){
            total += dict[c];
        }
        return total;
    }

    public void fillDictionary(){
        
        for(int i = 1; i < 27; i++){
            dict.Add(Convert.ToChar(i + 96), i);
        }

        for(int i = 27; i < 53; i++){
            dict.Add(Convert.ToChar(i + 38), i);
        }
    }

     

}