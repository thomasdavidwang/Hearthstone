using System.Collections;
using System;

public class Player{
	public ArrayList hand, board, oppBoard, deck;
	public Hero hero, opponent;
	public int totalMana;
	public int manaCount;
	int fatigueCount;

	public Player(ref ArrayList d, ref Hero h, ref Hero o, ref ArrayList bo, ref ArrayList ob){
		board = bo;
		oppBoard = ob;
		hand = new ArrayList ();
		deck = d;
		hero = h;
		opponent = o;
		totalMana = 0;
		manaCount = totalMana;
		fatigueCount = 0;
	}

	public void startTurn(){
		drawCard ();
		if (totalMana < 10) {
			totalMana++;
		}
		manaCount = totalMana;
	}

	public void endTurn(){
		foreach (Minion m in board) {
			m.endTurn ();
			if (!m.alive) {
				board.Remove (m);
			}
		}
		foreach (Minion m in oppBoard) {
			if (!m.alive) {
				board.Remove (m);
			}
		}
		hero.heroPower.endTurn ();
	}

	public void useMana(int i){
		manaCount = manaCount - i;
	}

	public void drawCard(){
		if (deck.Count > 0) {
			Random rd = new Random ();
			int r = rd.Next (deck.Count);
			hand.Add (deck [r]);
			deck.RemoveAt (r);
		} else {
			fatigueCount++;
			hero.takeDamage (fatigueCount);
		}
	}
}
