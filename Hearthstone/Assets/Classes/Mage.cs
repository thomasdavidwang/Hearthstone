public class Mage : Hero {
	public Mage(Board b) : base(){
		health = 30;
		maxHealth = 30;
		attack = 0;
		className = "mage";
		heroPower = new Fireblast (b);
		weapon = null;
		armor = 0;
		board = b;
	}
}
