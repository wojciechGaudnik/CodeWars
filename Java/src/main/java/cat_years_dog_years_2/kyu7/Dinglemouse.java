package cat_years_dog_years_2.kyu7;

public class Dinglemouse {
	public static int[] ownedCatAndDog(final int catYears, final int dogYears) {
		int[] dogArr = new int[]{15, 9, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5};
		int[] catArr = new int[]{15, 9, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4};
		return new int[]{convert(catYears, catArr), convert(dogYears, dogArr)};
	}

	private static int convert(int human, int[] years) {
		int cat = 0;
		for (var i = 0; human > 0; i++) {
			human -= years[i];
			if (human >= 0) {
				cat++;
			}

		}
		return cat;
	}


}
