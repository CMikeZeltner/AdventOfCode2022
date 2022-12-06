public class Stack{

    private Stack<char> _stack = null;
    public Stack(string stackCol){
        var arr = stackCol.ToCharArray().Reverse();
        _stack = new Stack<char>(arr);

    }

    public void Print(){
        foreach(char c in _stack){
            System.Console.Write(c);
        }
        System.Console.WriteLine();

    }

    public void Push(List<char> arr){
        //Call Reverse for Part Two
        //arr.Reverse();
        foreach(char c in arr){
            _stack.Push(c);
        }
    }

    public char Pop(){
        char c = _stack.Pop();
        return c;
    }

}