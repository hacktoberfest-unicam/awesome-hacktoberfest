import java.util.Scanner;

public class User {
    private Scanner inputScanner;

    public User() {
        inputScanner = new Scanner(System.in);
    }

    public Move getMove() {
        // Chiedi all'utente di eseguire una mossa
        System.out.print("Sasso, carta o forbice? ");

        // Leggi l'input dell'utente
        String userInput = inputScanner.nextLine();
        userInput = userInput.toUpperCase();
        char firstLetter = userInput.charAt(0);
        if (firstLetter == 'S' || firstLetter == 'C' || firstLetter == 'F') {
            // User has entered a valid input
            switch (firstLetter) {
            case 'S':
                return Move.SASSO;
            case 'C':
                return Move.CARTA;
            case 'F':
                return Move.FORBICE;
            }
        }

        // L'utente non ha inserito una mossa valida. Richiedi l'inserimento di una nuova mossa.
        return getMove();
    }

    public boolean playAgain() {
        System.out.print("Vuoi giocare ancora?[S] ");
        String userInput = inputScanner.nextLine();
        userInput = userInput.toUpperCase();
        return userInput.charAt(0) == 'S';
    }
}
