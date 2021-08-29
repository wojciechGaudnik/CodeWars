package com.example.proxy.external;

import java.util.Map;

public interface YouTubeLib {
	Map<String, Video> getVideos();

	Video getVideo(String videoId);

}
