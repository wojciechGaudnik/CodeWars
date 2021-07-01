package hardware;

import comands.Command;
import comands.NoOpCommand;
import lombok.NonNull;

public class AlexaDevice {
	Command[] onCommands;
	Command [] offCommands;
	int slot = 3;

	public AlexaDevice() {
		onCommands = new Command[slot];
		offCommands = new Command[slot];
		for (int i = 0; i < slot; i++) {
			onCommands[i] = new NoOpCommand();
			offCommands[i] = new NoOpCommand();
		}
	}

	public void setCommand(int slot, @NonNull Command onCommand, @NonNull Command offCommand) {
		onCommands[slot] = onCommand;
		offCommands[slot] = offCommand;
	}

}
