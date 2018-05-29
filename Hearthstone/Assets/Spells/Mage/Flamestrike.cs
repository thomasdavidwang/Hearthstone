public class Flamestrike : Spell {
	public Flamestrike(){
		manaCost = 7;
		name = "frostbolt";
		cardSet = "basic";
		classCard = "mage";
	}

	public void play(Player p){
		foreach(Minion m in p.oppBoard){
			m.takeDamage (4);
		}
		base.play (ref p);
	}
}
