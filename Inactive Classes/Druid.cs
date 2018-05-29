public class Druid : Hero {
	public Druid(Player p) : base(){
		health = 30;
		maxHealth = 30;
		attack = 0;
		className = "druid";
		heroPower = new Shapeshift (p);
		weapon = null;
		armor = 0;
		player = p;
	}

	public override void endTurn(){
		heroPower.endTurn ();
		base.endTurn ();
	}
}
