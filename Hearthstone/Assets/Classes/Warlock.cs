public class Warlock : Hero {
	public Warlock(Player p) : base(){
		health = 30;
		maxHealth = 30;
		attack = 0;
		className = "warlock";
		heroPower = new LifeTap ();
		weapon = null;
		armor = 0;
		player = p;
	}
}
