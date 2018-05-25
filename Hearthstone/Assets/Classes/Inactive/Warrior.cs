public class Warrior : Hero {
	public Warrior(Board other) : base(){
		health = 30;
		maxHealth = 30;
		attack = 0;
		className = "warrior";
		weapon = null;
		armor = 0;
		board = other;
	}
}
