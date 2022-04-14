package TheBigPronicChallenge;

import static org.junit.Assert.*;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

import org.junit.runners.JUnit4;

import java.util.Random;

public class SolutionTest {

	@Test
	public void isPronicTests() {
		for (int p = 24; p <= 31; p++) {
			long basis = 1L << p;
			for (int i = 0; i < 10000; i++) {
				long cand = basis + i;
				long pronic = cand * (cand + 1);
				assertEquals(true, Kata.isPronic(pronic));
			}
		}
		long basis = 185363L << 14;
		for (int i = 0; i < 10000; i++) {
			long cand = basis + i;
			long pronic = cand * (cand + 1);
			assertEquals(true, Kata.isPronic(pronic));
		}
	}

	@Test
	public void isNotPronicTests() {
		for (int p = 24; p <= 31; p++) {
			long basis = 1L << p;
			for (int i = 0; i < 10000; i++) {
				long cand = basis + i;
				long pronic = cand * (cand + 1) - 1;
				assertEquals(false, Kata.isPronic(pronic));
			}
		}
		long basis = 185363L << 14;
		for (int i = 0; i < 10000; i++) {
			long cand = basis + i;
			long pronic = cand * (cand + 1) - 1;
			assertEquals(false, Kata.isPronic(pronic));
		}
	}

	@Test
	public void IndividualPronicTests() {
		assertEquals(true, Kata.isPronic(0));
		assertEquals(true, Kata.isPronic(2));
		assertEquals(true, Kata.isPronic(6));
		assertEquals(true, Kata.isPronic(12));
		assertEquals(true, Kata.isPronic(20));
		assertEquals(true, Kata.isPronic(30));
		assertEquals(true, Kata.isPronic(42));
		assertEquals(true, Kata.isPronic(9223372033963249500L));
		assertEquals(false, Kata.isPronic(1));
		assertEquals(false, Kata.isPronic(Long.MIN_VALUE));
		assertEquals(false, Kata.isPronic(Long.MIN_VALUE / 2));
		assertEquals(false, Kata.isPronic(Long.MAX_VALUE));
	}

	@Test
	public void RandomTests() {
		Random r = new Random();
		for (int i = 0; i < 100000; i++) {
			long cand;
			// Prevent 0 from being passed into pronic test, and prevent overflow.
			while ((cand = (long) Math.sqrt(r.nextLong() >> 1)) == 0) {
			}
			;
			if (cand > 0) {
				long pronic = cand * (cand - 1);
				assertEquals(true, Kata.isPronic(pronic));
				assertEquals(false, Kata.isPronic(pronic - 2));
			} else {
				assertEquals(false, Kata.isPronic(cand * (cand - 1)));
			}
		}
	}
}