public class Mage : Hero {
	public Mage() : base(){
		health = 30;
		maxHealth = 30;
		attack = 0;
		className = "mage";
		heroPower = new Fireblast ();
		weapon = null;
		armor = 0;
	}

	public override void addPlayer(ref Player p){
		player = p;
	}
}
