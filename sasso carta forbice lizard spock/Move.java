

public enum Move {
	SASSO, CARTA, FORBICE, LIZARD, SPOCK;

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
        if (this.equals(otherMove))
            return 0;

        switch (this) {
        case SASSO:
        		return ((otherMove.equals(FORBICE))||(otherMove.equals(LIZARD))) ? 1 : -1;
        case CARTA:
            //return (otherMove == SASSO||SPOCK ? 1 : -1);
        	return ((otherMove.equals(SASSO))||(otherMove.equals(SPOCK))) ? 1 : -1;
        case FORBICE:
            //return (otherMove == CARTA|| LIZARD ? 1 : -1);
        	return ((otherMove.equals(CARTA))||(otherMove.equals(LIZARD))) ? 1 : -1;
        case LIZARD:
           // return (otherMove == CARTA|| SPOCK ? 1 : -1);
        	return ((otherMove.equals(CARTA))||(otherMove.equals(SPOCK))) ? 1 : -1;
        case SPOCK:
            //return (otherMove == FORBICE|| SASSO ? 1 : -1);
        	return ((otherMove.equals(FORBICE))||(otherMove.equals(SASSO))) ? 1 : -1;
        
        }

        return 0;
    }
}
