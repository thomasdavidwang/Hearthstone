public class Shaman : Hero {
	public Shaman(Board other) : base(){
		health = 30;
		maxHealth = 30;
		attack = 0;
		className = "shaman";
		weapon = null;
		armor = 0;
		board = other;
	}
}
