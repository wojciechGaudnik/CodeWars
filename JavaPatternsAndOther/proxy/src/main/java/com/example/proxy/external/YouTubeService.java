package com.example.proxy.external;

import lombok.extern.slf4j.Slf4j;
import org.springframework.stereotype.Service;

import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;

@Slf4j
@Service
public
class YouTubeService implements YouTubeLib {

	Map<String, Video> videos;

	public YouTubeService() {
		log.info("Loading videos...");
		experienceNetworkLatency();
		videos = new ConcurrentHashMap<>();
		videos.put("Film 1", new Video("id video 1", "title video 1", "data for video number 1"));
		videos.put("Film 2", new Video("id video 2", "title video 2", "data for video number 2"));
		videos.put("Film 3", new Video("id video 3", "title video 3", "data for video number 3"));
		videos.put("Film 4", new Video("id video 4", "title video 4", "data for video number 4"));
		videos.put("Film 5", new Video("id video 5", "title video 5", "data for video number 5"));
		log.info("Done!" + "\n" );
	}

	@Override
	public Map<String, Video> getVideos() {
		connectToServer("http://www.youtoube.com");
		return videos;
	}

	@Override
	public Video getVideo(String videoId) {
		connectToServer("http://www.youtube.com/" + videoId);
		return videos.entrySet().stream().filter(v -> v.getKey().equals(videoId)).findFirst().map(Map.Entry::getValue).orElseThrow(RuntimeException::new);
	}

	private void connectToServer(String server) {
		log.info("Connecting to " + server + "... ");
		experienceNetworkLatency();
		log.info("Connected!" + "\n");
	}

	private void experienceNetworkLatency() {
		int randomLatency = random(5, 10);
		for (int i = 0; i < randomLatency; i++) {
			try {
				Thread.sleep(100);
			} catch (InterruptedException e) {
				e.printStackTrace();
				Thread.currentThread().interrupt();
			}

		}
	}

	private int random(int min, int max) {
		return min + (int) (Math.random() * ((max - min) + 1));
	}
}
