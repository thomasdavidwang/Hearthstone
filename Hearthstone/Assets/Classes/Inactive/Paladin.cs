public class Paladin : Hero {
	public Paladin(Board other) : base(){
		health = 30;
		maxHealth = 30;
		attack = 0;
		className = "paladin";
		weapon = null;
		armor = 0;
		board = other;
	}
}
