package Supernatural;

public class Supernatural {
	public static String bob(String monsterName) {
		String reply = "";

		switch (monsterName) {
			case "werewolf":
				reply = "Silver knife or bullet to the heart";
				break;
			case "vampire":
				reply = "Behead it with a machete";
				break;
			case "wendigo":
				reply = "Burn it to death";
				break;
			case "shapeshifter":
				reply = "Silver knife or bullet to the heart";
				break;
			case "angel":
				reply = "Use the angelic blade";
				break;
			case "demon":
				reply = "Use Ruby's knife, or some Jesus-juice";
				break;
			case "ghost":
				reply = "Salt and iron, and don't forget to burn the corpse";
				break;
			case "dragon":
				reply = "You have to find the excalibur for that";
				break;
			case "djinn":
				reply = "Stab it with silver knife dipped in a lamb's blood";
				break;
			case "pagan god":
				reply = "It depends on which one it is";
				break;
			case "leviathan":
				reply = "Use some Borax, then kill Dick";
				break;
			case "ghoul":
				reply = "Behead it";
				break;
			case "jefferson starship":
				reply = "Behead it with a silver blade";
				break;
			case "reaper":
				reply = "If it's nasty, you should gank who controls it";
				break;
			case "rugaru":
				reply = "Burn it alive";
				break;
			case "skinwalker":
				reply = "A silver bullet will do it";
				break;
			case "phoenix":
				reply = "Use the colt";
				break;
			case "witch":
				reply = "They are humans";
				break;
			default:
				reply = "I have friggin no idea yet";
				break;
		}

		return reply + ", idjits!";
	}
}
