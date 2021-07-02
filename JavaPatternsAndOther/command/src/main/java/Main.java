import comands.EverythingOffCommand;
import comands.EverythingOnCommand;
import comands.KitchenLightsOffCommand;
import comands.KitchenLightsOnCommand;
import hardware.AlexaDevice;
import hardware.KitchenLights;
import hardware.Music;

public class Main {
	public static void main(String[] args) {
		var alexaDevice = new AlexaDevice();
		System.out.println(alexaDevice);
		var kitchenLights = new KitchenLights();
		var music = new Music();
		alexaDevice.setCommand(
				0,
				new KitchenLightsOnCommand(kitchenLights),
				new KitchenLightsOffCommand(kitchenLights));

		System.out.println(alexaDevice);
		alexaDevice.activateSlot(0);
		alexaDevice.deactivateSlot(0);

		alexaDevice.setCommand(
				1,
				new EverythingOnCommand(music, kitchenLights),
				new EverythingOffCommand(music, kitchenLights)
		);
		alexaDevice.activateSlot(1);
		alexaDevice.deactivateSlot(1);
	}
}
