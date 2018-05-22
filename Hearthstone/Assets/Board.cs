public class Board {
	public Player player1, player2;
	public int manaCount;

	public Board(Deck deck1, Deck deck2){
		player1 = new Player (deck1);
		player2 = new Player (deck2);
		manaCount = 0;
	}

	public void nextTurn(){
		if (manaCount < 10) {
			manaCount++;
		}
	}
}
