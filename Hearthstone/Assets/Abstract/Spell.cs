abstract public class Spell : Card {
	public int manaCost;
	public string name, cardSet, classCard;

	public override void play(Player p){
		p.useMana (manaCost);
	}
}
