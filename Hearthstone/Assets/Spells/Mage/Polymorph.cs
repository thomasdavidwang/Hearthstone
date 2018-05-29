public class Polymorph : Spell {
	public Polymorph(){
		manaCost = 4;
		name = "polymorph";
		cardSet = "basic";
		classCard = "mage";
	}

	public void play(Minion other, Player p){
		other.maxHealth = 1;
		other.attack = 1;
		base.play (ref p);
	}
}
