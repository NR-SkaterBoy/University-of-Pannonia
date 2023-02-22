package app;

import java.util.Arrays;
import java.util.Scanner;

class Player {
    int number;
    int age;
    int height;
    int scored;
    int played;
    boolean hasPlayedWc;
}

/* Input
3
1 10 140 45 20 true 
2 20 170 67 40 false 
3 22 167 99 44 true
2
*/

public class ApplicationMain {
    
    public static void printAll(Player[] players) {
        for(int i = 0; i < players.length; i++) {
            Player player = players[i];
            System.out.println(player.number + " " + player.age + "" + player.height + " " + player.scored + " " + player.played + " " + player.hasPlayedWc);
        }
    }
    
    public static Player oldestPlayer(Player[] players) {
        Player oldest = players[0];
        for (int i = 1; i < players.length; i++) {
            if (players[i].age < oldest.age)
                oldest = players[i];
        }  
        return oldest;
    }
    
    public static void playedPlayer(Player[] players, int played) {
        int count = 0;
        for (int i = 0; i < players.length; i++) {
            if (players[i].played >= played)
                count++;
        }
        System.out.println("There is/are " + count + " who already played");
    }
    
    public static Player numberOfPlayer(Player[] players, int personNumber) {
        Player number = players[0];
        for (int i = 0; i < players.length; i++) {
            if (personNumber == players[i].number)
                number = players[i];
        }
        return number;
    }
    
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Give me a number of players! Players: ");
        int numberOfPlayers = input.nextInt();
        Player players[] = new Player[numberOfPlayers];
        for (int i = 0; i < players.length; i++) {
            Player p = new Player();
            p.number = input.nextInt();
            p.age = input.nextInt();
            p.height = input.nextInt();
            p.scored = input.nextInt();
            p.played = input.nextInt();
            p.hasPlayedWc = input.nextBoolean();
            players[i] = p;
        }
        
        printAll(players);
        Player oldest = oldestPlayer(players);
        System.out.println("The oldest player is " + oldest.number + "\nAge: " +
                oldest.age + "\nHeight: " + oldest.height +
                "\nScore: " + oldest.scored + 
                "\nPlayed: " + oldest.played + "\nHasplayed: " + oldest.hasPlayedWc);
        System.out.print("Give me a number of matches! Number: ");
        int played = input.nextInt();
        playedPlayer(players, played);
        System.out.print("Give me an another number of matches! Number: ");
        int played2 = input.nextInt();
        playedPlayer(players, played2);
        System.out.print("Give me the member's number! Number: ");
        int personNumber = input.nextInt();
        Player number = numberOfPlayer(players, personNumber);
        System.out.println("Age: " +
                number.age + "\nHeight: " + number.height +
                "\nScore: " + number.scored + 
                "\nPlayed: " + number.played + "\nHasplayed: " + number.hasPlayedWc);
    }
    
}
