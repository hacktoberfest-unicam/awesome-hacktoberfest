

public enum Move {
	SASSO, CARTA, FORBICE;

    /**
  * Confrontiamo la mossa corrente con la mossa precedente per determinare se è un pareggio, se 
 * vince o se perde
 * 
 * @parametro otherMove
 *           per eseguire il confronto
 * @return 1 se questa mossa batte l'altra, -1 se questa mossa viene battuta dall'altra
 *   0 se si tratta di un pareggio
 */
    public int compareMoves(Move otherMove) {
        // Pareggio
        if (this == otherMove)
            return 0;

        switch (this) {
        case SASSO:
            return (otherMove == FORBICE ? 1 : -1);
        case CARTA:
            return (otherMove == SASSO ? 1 : -1);
        case FORBICE:
            return (otherMove == CARTA ? 1 : -1);
        }

        return 0;
    }
}
