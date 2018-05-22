using System.Collections;

public class Player{
	public ArrayList hand, board;
	public Deck deck;
	public Hero hero;

	public Player(Deck d){
		deck = d;
		hero = d.hero;
	}

	public void drawCard(){
		
	}
}
