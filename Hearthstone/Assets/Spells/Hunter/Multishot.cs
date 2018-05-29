using System.Collections;
using System;

public class Multishot : Spell {
	//Can be nondistinct minions
	public Multishot(){
		manaCost = 4;
		name = "multi-shot";
		cardSet = "basic";
		classCard = "hunter";
	}

	public void play(Player p){
		if (p.oppBoard.Count < 3) {
			foreach (Minion m in p.oppBoard) {
				m.takeDamage (3);
			}
		} else {
			Random rd = new Random();
			int r = rd.Next(p.oppBoard.Count);
			int s = rd.Next (p.oppBoard.Count);
			((Minion) (p.oppBoard [r])).takeDamage (3);
			((Minion) (p.oppBoard [s])).takeDamage (3);
		}
		base.play (ref p);
	}
}
