static class DayOne{
    public static void Run(){
        StreamReader sr = new StreamReader("Day1/input.txt");
        List<int> list = new List<int>();
        string line = "";
        int num = 0;
        while(line != null){
            line = sr.ReadLine();
            if(line == ""){
                list.Add(num);
                num = 0;
            } else if (line == null) {
                break;
            } else {
                num += Int32.Parse(line);
            }
        }


        list.Sort();
        list.Reverse();
        //Part 1 answer
        //Console.WriteLine(list[0]);

        //Part 2
        int answer = 0;
        for(int i = 0; i < 3; i++){
            answer += list[i];
        }

        System.Console.WriteLine(answer);
    }
}