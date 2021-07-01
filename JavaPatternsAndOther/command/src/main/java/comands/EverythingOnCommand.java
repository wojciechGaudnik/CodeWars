package comands;

import hardware.KitchenLights;
import hardware.Music;

public class EverythingOnCommand implements Command {

	Music music;

	public EverythingOnCommand(Music music, KitchenLights kitchenLights) {
		this.music = music;
		this.kitchenLights = kitchenLights;
	}

	KitchenLights kitchenLights;

	@Override
	public void execute() {
		System.out.println("--- ITS PARTY TIME! ---");
		kitchenLights.on();
		music.on();
		music.setVolume(10);
		music.setStation(99.9F);
	}
}
