public class Instructions{

    private Queue<string> _instructions = null;

    public Instructions(List<string> nums){
        _instructions = new Queue<string>(nums);
    }

    public int Pop(){
        if(_instructions.Count != 0){
            string s = _instructions.Dequeue().ToString();
            int i;
            Int32.TryParse(s, out i);
            return i;
        } else {
            return -1;
        }
    }

}