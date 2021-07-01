package comands;

import hardware.KitchenLights;
import hardware.Music;

public class EverythingOffCommand implements Command {

	Music music;
	KitchenLights kitchenLights;

	public EverythingOffCommand(Music music, KitchenLights kitchenLights) {
		this.music = music;
		this.kitchenLights = kitchenLights;
	}

	@Override
	public void execute() {
		music.off();
		kitchenLights.off();
		System.out.println("ALL OFF");
	}
}
