public class Shaman : Hero {
	public Shaman(Player p) : base(){
		health = 30;
		maxHealth = 30;
		attack = 0;
		className = "shaman";
		weapon = null;
		armor = 0;
		player = p;
	}
}
