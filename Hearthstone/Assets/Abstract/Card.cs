abstract public class Card {
	public string name;
	public int manaCost;
	abstract public void play (ref Player p);
	public virtual void play(ref Entity e, ref Player p){

	}
}
