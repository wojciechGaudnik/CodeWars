package com.example.proxy.proxy;

import com.example.proxy.external.Video;
import com.example.proxy.external.YouTubeLib;
import lombok.extern.slf4j.Slf4j;

@Slf4j
public class YouTubeDownloader {
	private YouTubeLib api;

	public YouTubeDownloader(YouTubeLib api) {
		this.api = api;
	}

	public void renderVideoPage(String videoId) {
		var video = api.getVideo(videoId);
		log.info("\n-------------------------------");
		log.info("Video page (imagine fancy HTML)");
		log.info("ID: " + video.id);
		log.info("Title: " + video.title);
		log.info("Video: " + video.data);
		log.info("-------------------------------\n");
	}

	public void renderPopularVideos() {
		var list = api.getVideos();
		log.info("\n-------------------------------");
		log.info("Most popular videos on YouTube (imagine fancy HTML)");
		for (Video video : list.values()) {
			log.info("ID: " + video.id + " / Title: " + video.title);
		}
		log.info("-------------------------------\n");
	}
}
