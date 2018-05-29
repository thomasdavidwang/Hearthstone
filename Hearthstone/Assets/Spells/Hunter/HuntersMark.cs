public class HuntersMark : Spell {
	public HuntersMark(){
		manaCost = 1;
		name = "hunter's mark";
		cardSet = "basic";
		classCard = "hunter";
	}

	public void play(Entity other, Player p){
		other.health = 1;
		other.maxHealth = 1;
		base.play (ref p);
	}
}
