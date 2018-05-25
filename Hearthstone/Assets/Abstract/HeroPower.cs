abstract public class HeroPower : Card{
	public bool active;
	public Player player;
	public int manaCost;

	public HeroPower(){
		active = true;
		manaCost = 2;
	}

	public override void play(){
		active = false;
	}

	public override void endTurn(){
		active = true;
	}
}
