using System;
using System.Collections;

public class Board {
	public Player curr;
	Player pmage, phunter;
	ArrayList mboard, hboard;
	bool pmageTurn;

	public Board(ref ArrayList d1,ref ArrayList d2,ref Hero mage,ref Hero hunter){
		mboard = new ArrayList ();
		hboard = new ArrayList ();
		pmage = new Player(ref d1,ref mage,ref hunter, ref mboard, ref hboard);
		phunter = new Player(ref d2,ref hunter,ref mage, ref hboard, ref mboard);
		mage.addPlayer (ref pmage);
		hunter.addPlayer (ref phunter);
		Random rd = new Random();
		int r = rd.Next(2);
		pmageTurn = r == 1;
		if (!pmageTurn) {
			pmage.drawCard ();
			pmage.drawCard ();
			phunter.drawCard ();
			phunter.drawCard ();
			phunter.drawCard ();
			phunter.hand.Add (new Coin ());
		}else{
			phunter.drawCard ();
			phunter.drawCard ();
			pmage.drawCard ();
			pmage.drawCard ();
			pmage.drawCard ();
			pmage.hand.Add (new Coin ());
		}
	}

	public void play(int i){
		if(i < curr.hand.Count){
			Card c = (Card) curr.hand [i];
			curr.hand.RemoveAt (i);
			c.play (ref curr);
			if (!(c is Spell)) {
				curr.board.Add (c);
			}
		}
	}

	public void play(Entity e, int i){
		if(i < curr.hand.Count){
			Card c = (Card) curr.hand [i];
			curr.hand.RemoveAt (i);
			c.play (ref e, ref curr);
			if (!(c is Spell)) {
				curr.board.Add (c);
			}
		}
	}

	public void nextTurn(){
		if (pmageTurn) {
			pmage.endTurn ();
			phunter.startTurn ();
			curr = phunter;
			pmageTurn = false;
		} else {
			phunter.endTurn ();
			pmage.startTurn ();
			curr = pmage;
			pmageTurn = true;
		}
	}

	/**
	public Hero getHero(string h){
		Hero outHero;
		switch (h) {
		case "Alleria Windrunner":
			outHero = new AlleriaWindrunner (this.player1);
			break;
		case "Anduin Wrynn":
			outHero = new AnduinWrynn (this);
			break;
		case "Garrosh Hellscream":
			outHero = new GarroshHellscream (this);
			break;
		case "Gul'dan":
			outHero = new Guldan (this);
			break;
		case "Jaina Proudmoore":
			outHero = new JainaProudmoore (this);
			break;
		case "Khadgar":
			outHero = new Khadgar (this);
			break;
		case "Lady Liadrin":
			outHero = new LadyLiadrin (this);
			break;
		case "Lunara":
			outHero = new Lunara (this);
			break;
		case "Magni Bronzebeard":
			outHero = new MagniBronzebeard (this);
			break;
		case "Maiev Shadowsong":
			outHero = new MaievShadowsong (this);
			break;
		case "Malfurion Stormrage":
			outHero = new MalfurionStormrage (this);
			break;
		case "Medivh":
			outHero = new Medivh (this);
			break;
		case "Morgl the Oracle":
			outHero = new MorglTheOracle (this);
			break;
		case "Nemsy Necrofizzle":
			outHero = new NemsyNecrofizzle (this);
			break;
		case "Prince Arthas":
			outHero = new PrinceArthas (this);
			break;
		case "Rexxar":
			outHero = new Rexxar (this);
			break;
		case "Thrall":
			outHero = new Thrall (this);
			break;
		case "Tyrande Whisperwind":
			outHero = new TyrandeWhisperwind (this);
			break;
		case "Uther Lightbringer":
			outHero = new UtherLightbringer (this);
			break;
		case "Valeera Sanguinar":
			outHero = new ValeeraSanguinar (this);
			break;
		default:
			outHero = null;
			break;
		}
		return outHero;
	}
	*/
}
