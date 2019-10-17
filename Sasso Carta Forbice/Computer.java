import java.util.Random;

public class Computer {
	 public Move getMove() {
         Move[] moves = Move.values();
         Random random = new Random();
         int index = random.nextInt(moves.length);
         return moves[index];
     }
}
