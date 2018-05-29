using System;
using System.Collections;

public class Board {
	public Player player1, player2;

	public Board(ArrayList d1, ArrayList d2, string h1, string h2){
		player1 = new Player(d1, getHero(h1), getHero(h2));
		player2 = new Player(d2, getHero(h2), getHero(h1));
	}

	public Board(Player p1, Player p2){
		player1 = p1;
		player2 = p2;
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

	public void nextTurn(){
		
	}
}
