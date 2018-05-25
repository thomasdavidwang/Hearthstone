public class Priest : Hero {
	public Priest(Board other) : base(){
		health = 30;
		maxHealth = 30;
		attack = 0;
		className = "priest";
		weapon = null;
		armor = 0;
		board = other;
	}
}
