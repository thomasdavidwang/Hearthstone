public class KillCommand : Spell {
	public KillCommand(){
		manaCost = 3;
		name = "kill command";
		cardSet = "basic";
		classCard = "hunter";
	}

	public void play(Entity other, Player p){
		bool temp = false;
		foreach (Minion a in p.board) {
			if (a.tribe == "beast") {
				temp = true;
			}
		}
		if (temp) {
			other.takeDamage (5);
		} else {
			other.takeDamage (3);
		}
		base.play (ref p);
	}
}
