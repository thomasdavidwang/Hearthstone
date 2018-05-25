public class Druid : Hero {
	public Druid(Board other) : base(){
		health = 30;
		maxHealth = 30;
		attack = 0;
		className = "druid";
		heroPower = new Shapeshift (this);
		weapon = null;
		armor = 0;
		board = other;
	}

	public override void endTurn(){
		heroPower.endTurn ();
		base.endTurn ();
	}
}
