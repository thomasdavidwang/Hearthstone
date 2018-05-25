public class Rogue : Hero {
	public Rogue(Board other) : base(){
		health = 30;
		maxHealth = 30;
		attack = 0;
		className = "rogue";
		weapon = null;
		armor = 0;
		board = other;
	}
}
