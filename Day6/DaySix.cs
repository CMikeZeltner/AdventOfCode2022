public class DaySix{

    StreamReader sr = new StreamReader("Day6/input.txt");

    public DaySix(){
        int i = 4;
        //Comment out above, uncomment out below for solution 2
        //int i = 14;
        Run(i);
    }


    public void Run(int numChars){
        string line = sr.ReadLine();
        bool answer = false;
        int i = 0;

        while(i < line.Length - numChars && answer == false){
            string subString = line.Substring(i, numChars);
            answer = CheckUnqiue(subString);
            i++;
        }
        System.Console.WriteLine(i + numChars - 1);
    }

    public bool CheckUnqiue(string sub){
        for(int i = 0; i < sub.Length; i++){
            for(int j = i + 1; j < sub.Length; j++){
                if(sub[i] == sub[j]){
                    return false;
                }
            }
        }

        return true;

    }

}