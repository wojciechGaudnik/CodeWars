package Dinglemouse;

import org.junit.Test;

import java.util.Arrays;
import java.util.List;

import static org.junit.Assert.*;

public class DinglemouseTest {

	@Test
	public void fly() {
		List<String> animals = Arrays.asList(new String[]{"fly"});
		List<String> autopsy = Arrays.asList(new String[]{"fly"});
		assertEquals(autopsy, Dinglemouse.oldLadySwallows(animals));
	}

	@Test
	public void flySpider() {
		List<String> animals = Arrays.asList(new String[]{"fly", "spider"});
		List<String> autopsy = Arrays.asList(new String[]{"spider"});
		assertEquals(autopsy, Dinglemouse.oldLadySwallows(animals));
	}

	@Test
	public void flySpiderBird() {
		List<String> animals = Arrays.asList(new String[]{"fly", "spider", "bird"});
		List<String> autopsy = Arrays.asList(new String[]{"bird"});
		assertEquals(autopsy, Dinglemouse.oldLadySwallows(animals));
	}

	@Test
	public void birdFlySpider() {
		List<String> animals = Arrays.asList(new String[]{"bird", "fly", "spider"});
		List<String> autopsy = Arrays.asList(new String[]{"bird"});
		assertEquals(autopsy, Dinglemouse.oldLadySwallows(animals));
	}

	@Test
	public void rand() {
		List<String> animals = Arrays.asList(new String[]{"cow", "cow", "cat", "dog", "horse", "bird", "cat", "horse", "horse", "goat"});
		List<String> autopsy = Arrays.asList(new String[]{"dog", "horse"});
		assertEquals(autopsy, Dinglemouse.oldLadySwallows(animals));
	}

	@Test
	public void rand1() {
		List<String> animals = Arrays.asList("cow", "cat", "fly", "bird", "spider", "dog", "fly", "dog", "spider", "cow", "horse", "bird", "cat", "goat", "bird", "fly", "cat", "bird", "goat");
		List<String> autopsy = Arrays.asList("spider", "dog", "dog", "spider", "horse");
		assertEquals(autopsy, Dinglemouse.oldLadySwallows(animals));
	}



}