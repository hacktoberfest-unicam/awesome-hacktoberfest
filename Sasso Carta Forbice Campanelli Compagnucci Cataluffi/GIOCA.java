import java.util.Random;
import java.util.Scanner;

public class GIOCA {
    private User user;
    private Computer computer;
    private int userScore;
    private int computerScore;
    private int numberOfGames;

    public GIOCA() {
        user = new User();
        computer = new Computer();
        userScore = 0;
        computerScore = 0;
        numberOfGames = 0;
    }

    public void startGame() {
        System.out.println("SASSO, CARTA, FORBICI!");

        // Esegui le mosse
        Move userMove = user.getMove();
        Move computerMove = computer.getMove();
        System.out.println("\nHai giocato " + userMove + ".");
        System.out.println("Il Computer ha giocato " + computerMove + ".\n");

        // Confronta le mosse fatte per determinare il vincitore
        int compareMoves = userMove.compareTo(computerMove);
        switch (compareMoves) {
        case 0: // Pareggio
            System.out.println("Pareggio!");
            break;
        case 1: // Vince l'utente
            System.out.println(userMove + " batte " + computerMove + ". Hai vinto!");
            userScore++;
            break;
        case -1: // Vince il Computer
            System.out.println(computerMove + " batte " + userMove + ". Hai perso.");
            computerScore++;
            break;
        }
        numberOfGames++;

        // Chiedi all'utente se vuole giocare ancora
        if (user.playAgain()) {
            System.out.println();
            startGame();
        } else {
            printGameStats();
        }
    }

    /**
     * Stampa le statistiche della partita. La percentuale di vittorie tiene conto dei pareggi come 
     * fossero 1/2 punto.
     */
    private void printGameStats() {
        int wins = userScore;
        int losses = computerScore;
        int ties = numberOfGames - userScore - computerScore;
        double percentageWon = (wins + ((double) ties) / 2) / numberOfGames;
    
        // Stampa una linea
        System.out.print("+");
        printDashes(68);
        System.out.println("+");
    
        // Stampa le intestazioni 
        System.out.printf("|  %6s  |  %6s  |  %6s  |  %12s  |  %14s  |\n",
                "VITTORIE", "SCONFITTE", "PAREGGI", "PARTITE GIOCATE", "PERCENTUALE DI VITTORIE");
    
        // Stampa le linee di separazione
        System.out.print("|");
        printDashes(10);
        System.out.print("+");
        printDashes(10);
        System.out.print("+");
        printDashes(10);
        System.out.print("+");
        printDashes(16);
        System.out.print("+");
        printDashes(18);
        System.out.println("|");
    
        // stampa i valori
        System.out.printf("|  %6d  |  %6d  |  %6d  |  %12d  |  %13.2f%%  |\n",
                wins, losses, ties, numberOfGames, percentageWon * 100);
    
        // stampa la linea di chiusura
        System.out.print("+");
        printDashes(68);
        System.out.println("+");
    }

    private void printDashes(int numberOfDashes) {
        for (int i = 0; i < numberOfDashes; i++) {
            System.out.print("-");
        }
    }

    public static void main(String[] args) {
        GIOCA game = new GIOCA();
        game.startGame();
    }
}
