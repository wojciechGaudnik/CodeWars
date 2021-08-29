package com.example.proxy;

import com.example.proxy.external.YouTubeService;
import com.example.proxy.proxy.YouTubeCacheProxy;
import com.example.proxy.proxy.YouTubeDownloader;
import lombok.extern.slf4j.Slf4j;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@Slf4j
@SpringBootApplication
public class ProxyApplication {

	public static void main(String[] args) {
		SpringApplication.run(ProxyApplication.class, args);
		run();
	}

	private static void run() {
		var directDownloader = new YouTubeDownloader(new YouTubeService());
		var cachedDownloader = new YouTubeDownloader(new YouTubeCacheProxy());
		long direct = test(directDownloader);
		long cached = test(cachedDownloader);
		log.info("Time saved by caching proxy: " + (direct - cached) + "ms");
	}

	private static long test(YouTubeDownloader downloader) {
		var startTime = System.currentTimeMillis();
		downloader.renderPopularVideos();
		downloader.renderVideoPage("Film 1");
		downloader.renderPopularVideos();
		downloader.renderVideoPage("Film 2");
		var estimatedTime = System.currentTimeMillis() - startTime;
		log.info("Time elapsed: " + estimatedTime + "ms");
		return estimatedTime;
	}

}
