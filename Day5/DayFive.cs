public class DayFive{

    StreamReader sr = new StreamReader("Day5/input.txt");
    List<Stack> stacks = new List<Stack>();
    Instructions instructions = null;
    string line = "";
    string tempLine = "";

    public DayFive(){
        SetStackData();
        SetInstructions();
        //See Stack.Push method for part two solution
        Run();
    }


    public void Run(){
        //Move [num] amount
        //From [num] stack
        //To [num] stack
        int moveAmount = instructions.Pop();
        int fromStack = 0;
        int toStack = 0;
        while(moveAmount != -1){
            //Subtract one to offset 0 based index
            fromStack = instructions.Pop() - 1;
            toStack = instructions.Pop() - 1;


            List<char> list = new List<char>();
            for(int i = 0; i < moveAmount; i++){
                list.Add(stacks[fromStack].Pop());
            }
            stacks[toStack].Push(list);
            moveAmount = instructions.Pop();
        }

        foreach(Stack s in stacks){
            char c = s.Pop();
            System.Console.Write(c);
        }
    }

    public void SetInstructions(){
        string line = "";
        string tempLine = sr.ReadLine();
        while(tempLine != null){
            line += tempLine + " ";
            tempLine = sr.ReadLine();
        }
        var temp = line.Split(new char[] {' ', '\n'});
        
        List<string> list = new List<string>();

        foreach(string s in temp){
            int i = 0;
            if(Int32.TryParse(s, out i)){
                list.Add(s);
            }
        }
        instructions = new Instructions(list);
        
    }



    public void SetStackData(){
        tempLine = sr.ReadLine();
        while(tempLine != ""){
            line += tempLine + "\n";
            tempLine = sr.ReadLine();
        }

        //Stack 1 starts at index 1, each stack after is 4 spaces away (1,5,9,13...)
        var split = line.Split("\n");

        string stackCol = "";

        for(int i = 1; i < split[0].Length; i += 4){
            for(int j = 0; j < split.Length - 2; j++){
                stackCol += split[j][i];
            }
            stackCol = stackCol.Trim();
            stacks.Add(new Stack(stackCol));
            stackCol = "";
    }  

    }
}