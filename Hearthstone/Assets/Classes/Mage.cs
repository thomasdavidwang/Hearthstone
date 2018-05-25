public class Mage : Hero {
	public Mage(Player p) : base(){
		health = 30;
		maxHealth = 30;
		attack = 0;
		className = "mage";
		heroPower = new Fireblast ();
		weapon = null;
		armor = 0;
		player = p;
	}
}
