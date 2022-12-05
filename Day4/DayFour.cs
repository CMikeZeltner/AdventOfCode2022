public class DayFour{

    StreamReader sr = new StreamReader("Day4/input.txt");
    // int pair1Start = 0;
    // int pair1End = 0;
    // int pair2Start = 0;
    // int pair2End = 0;
    string line = "";
    int count = 0;

    public DayFour(){
        BothParts();

    }

    public void BothParts(){
        line = sr.ReadLine();
        while(line != null){
            var split = line.Replace(",", "-").Split("-");
            var ints = Array.ConvertAll(split, int.Parse);
            //count += TestRanges(ints); 
            count += TestRangesPartTwo(ints);
            line = sr.ReadLine();
        }
        
        System.Console.WriteLine(count);
        

    }

    public int TestRanges(int[] arr){
        if(arr[0] <= arr[2] && arr[1] >= arr[3]){
            return 1;
        }

        if(arr[2] <= arr[0] && arr[3] >= arr[1]){
            return 1;
        }

        return 0;
    }

    public int TestRangesPartTwo(int[] arr){
    if(arr[0] >= arr[2] && arr[0] <= arr[3]){
        return 1;
    }

    if(arr[1] >= arr[2] && arr[1] <= arr[3]){
        return 1;
    }

    if(arr[2] >= arr[0] && arr[2] <= arr[1]){
        return 1;
    }

    if(arr[3] >= arr[0] && arr[3] <= arr[1]){
        return 1;
    }

    return 0;
}
}