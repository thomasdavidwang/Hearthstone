abstract public class HeroPower : Card{
	public bool active;
	public Player player;
	public int manaCost;

	public HeroPower(){
		active = true;
		manaCost = 2;
	}

	public override void play(Player p){
		p.useMana (2);
		active = false;
	}

	public void endTurn(){
		active = true;
	}
}
