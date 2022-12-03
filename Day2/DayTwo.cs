static class DayTwo{

    public static void Run(){
        StreamReader sr = new StreamReader("Day2/input.txt");
        string line = "";
        int oppMove = 0;
        int yourMove = 0;
        int total = 0;
        Dictionary<char, int> dict = new Dictionary<char, int>{
            ['A'] = 1,
            ['B'] = 2,
            ['C'] = 3,
            ['X'] = 1,
            ['Y'] = 2,
            ['Z'] = 3
        };

        line = sr.ReadLine();
        while(line != null){
            oppMove = dict[line[0]];
            yourMove = dict[line[2]];
            total += getRoundTotal(oppMove, yourMove);
            line = sr.ReadLine();
        }

        System.Console.WriteLine(total);

        //Part 2 Solution
        int getRoundTotal(int oppMove, int yourMove){
        //Lose
        if(yourMove == 1){
            if(oppMove == 1){
                return 3; //Rock beats Scissors
            } else if(oppMove == 2){
                return 1; //Paper beats Rock
            } else {
                return 2; //Scissors beats Paper
            }

        } else if (yourMove == 2){ //Tie
            return oppMove + 3; //Their move + tie bonus (3)

        } else { //Win
            if(oppMove == 1){
                return 2 + 6; //Rock loses to Paper (2)
            } else if(oppMove == 2){
                return 3 + 6; //Paper loses to Scissors (3)
            } else {
                return 1 + 6; //Scissors loses to Rock (1)
            }

        }
        
    }
        
        //Part 1 Solution
        // int getRoundTotal(int oppMove, int yourMove){
        //     //Rock
        //     if(oppMove == 1){
        //         if(yourMove == 1){
        //             return yourMove + 3;
        //         } else if (yourMove == 2){
        //             return yourMove + 6;
        //         } else {
        //             return yourMove;
        //         }
        //     } else if(oppMove == 2){ //Paper
        //         if(yourMove == 1){
        //             return yourMove;
        //         } else if (yourMove == 2){
        //             return yourMove + 3;
        //         } else {
        //             return yourMove + 6;
        //         }
        //     } else { //Scissors
        //         if(yourMove == 1){
        //             return yourMove + 6;
        //         } else if (yourMove == 2){
        //             return yourMove;
        //         } else {
        //             return yourMove + 3;
        //         }
        //     }
        // }


    }
}