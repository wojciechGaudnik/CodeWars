package com.example.proxy.proxy;

import com.example.proxy.external.Video;
import com.example.proxy.external.YouTubeLib;
import com.example.proxy.external.YouTubeService;
import lombok.extern.slf4j.Slf4j;
import org.springframework.stereotype.Service;

import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;

@Slf4j
@Service
public class YouTubeCacheProxy implements YouTubeLib {

	private YouTubeService youTubeService;
	private Map<String, Video> cachePopular = new ConcurrentHashMap<>();
	private Map<String, Video> cacheAll = new ConcurrentHashMap<>();

	public YouTubeCacheProxy() {
		this.youTubeService = new YouTubeService();
	}

	@Override
	public Map<String, Video> getVideos() {
		if (cachePopular.isEmpty()) {
			cachePopular = youTubeService.getVideos();
		} else {
			log.info("Retrieved list from cache.");
		}
		return cachePopular;
	}

	@Override
	public Video getVideo(String videoId) {
		var video = cacheAll.get(videoId);
		if (video == null) {
			video = youTubeService.getVideo(videoId);
		} else {
			log.info("Retrieved video from cache.");
		}
		return video;
	}

	public void reset() {
		cachePopular.clear();
		cacheAll.clear();
	}
}
