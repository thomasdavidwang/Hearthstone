using System.Collections;
using System;

public class Player{
	public ArrayList hand, board, oppBoard, deck;
	public Hero hero, opponent;
	public int totalMana;
	public int manaCount;

	public Player(ArrayList d, Hero h, Hero o){
		deck = d;
		hero = h;
		opponent = o;
		totalMana = 0;
		manaCount = totalMana;
	}

	public void drawCard(){
		Random rd = new Random();
		int r = rd.Next(deck.Count);
		hand.Add(deck [r]);
		deck.RemoveAt (r);
	}
}
