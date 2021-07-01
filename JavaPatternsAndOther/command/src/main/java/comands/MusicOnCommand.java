package comands;

import hardware.Music;

public class MusicOnCommand implements Command {

	Music music;

	public MusicOnCommand(Music music) {
		this.music = music;
	}

	@Override
	public void execute() {
		music.setVolume(0);
		music.setStation(0);
		music.off();
	}
}
