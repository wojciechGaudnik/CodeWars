package columnize.kyu6;

class Kata {

	public static String columnize(String[] input, int numberOfColumns) {
		int[] listOfPads = getListOfPads(input, numberOfColumns);
		return formatColumns(input, numberOfColumns, listOfPads);
	}

	private static String formatColumns(String[] input, int numberOfColumns, int[] listOfPads) {
		var answer = new StringBuilder();
		var last = 0;
		for (var i = 0; i < input.length; i++) {
			var pad = (listOfPads[i % numberOfColumns] == 0) ? "%s": "%-" + listOfPads[i % numberOfColumns] + "s";
			if ((i + 1) % numberOfColumns != 0) {
				answer.append(String.format(pad, input[i])).append(" | ");
				last = 3;
			} else {
				answer.append(String.format(pad, input[i])).append("\n");
				last = 1;
			}
		}
		return answer.substring(0, answer.length() - last);
	}

	private static int[] getListOfPads(String[] input, int numberOfColumns) {
		var listOfPads = new int[numberOfColumns];
		for (var i = 0; i < numberOfColumns; i++) {
			listOfPads[i] = 0;
			for (var j = i; j < input.length; j += numberOfColumns) {
				if (listOfPads[i] < input[j].length()) {
					listOfPads[i] = input[j].length();
				}
			}
		}
		return listOfPads;
	}

}
