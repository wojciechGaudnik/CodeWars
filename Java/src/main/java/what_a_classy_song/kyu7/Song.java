package what_a_classy_song.kyu7;

import java.util.HashSet;
import java.util.List;
import java.util.Set;
import java.util.stream.Collectors;

public class Song {

	private String title;
	private String artist;
	private Set listeners;

	public Song(String title, String artist) {
		this.title = title;
		this.artist = artist;
		this.listeners = new HashSet();
	}

	public String getTitle() {
		return title;
	}

	public String getArtist() {
		return artist;
	}

	public int howMany(List<String> listeners) {
		var count = this.listeners.size();
		this.listeners.addAll(listeners.stream().map(String::toLowerCase).collect(Collectors.toSet()));
		return this.listeners.size() - count;
	}
}
