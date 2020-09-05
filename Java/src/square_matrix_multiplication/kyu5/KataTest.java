package square_matrix_multiplication.kyu5;

import static org.junit.jupiter.api.Assertions.*;

import java.util.Random;
import java.util.function.IntSupplier;

import org.junit.Assert;
import org.junit.Test;

public class KataTest {


	@Test
	public void exampleTest() {

		int[][] a = {
				{1,2},
				{3, 2}};

		int[][] b = {
				{3,2},
				{1, 1}};

		int[][] expected = {
				{5, 4},
				{11, 8}};

		int[][] actual = Kata.matrixMultiplication(a, b);
		Assert.assertArrayEquals(expected, actual);
	}

	@Test
	public void basicTest() {

		{
			int[][] a = {
					{ 9, 7 },
					{ 0, 1 }};

			int[][] b = {
					{ 1, 1 },
					{ 4, 12 }};

			int[][] expected = {
					{ 37, 93 },
					{ 4, 12 }};

			int[][] actual = Kata.matrixMultiplication(a, b);
			Assert.assertArrayEquals(expected, actual);
		}

		{

			int[][] a = {
					{ 1, 2, 3 },
					{ 3, 2, 1 },
					{ 2, 1, 3 }};

			int[][] b = {
					{ 4, 5, 6 },
					{ 6, 5, 4 },
					{ 4, 6, 5 }};

			int[][] expected = {
					{ 28, 33, 29 },
					{ 28, 31, 31 },
					{ 26, 33, 31 }};

			int[][] actual = Kata.matrixMultiplication(a, b);
			Assert.assertArrayEquals(expected, actual);
		}
	}
}
