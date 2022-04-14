package last_survivors_ep_3.kyu6;

class Kata {
	public static void main(String[] args) {
		System.out.println(lastSurvivors(new String[]{"abc", "   ", " a "}, new int[]{0, 4, 1}));
	}

	public static String lastSurvivors(String[] strs, int[] nums) {
		var arrayBuilders = new StringBuilder[nums.length];
		for (var i = 0; i < arrayBuilders.length; i++) {
			arrayBuilders[i] = new StringBuilder();
		}
		for (String str : strs) {
			for (var x = 0; x < str.length(); x++) {
				arrayBuilders[x] = arrayBuilders[x].append(str.charAt(x));
			}
		}
		var arrayStrings = new String[nums.length];
		for (var i = 0; i < arrayBuilders.length; i++) {
			arrayStrings[i] = arrayBuilders[i].reverse().toString().replace(" ", "");
		}
		var answer = new StringBuilder();
		for (var i = 0; i < nums.length; i++) {
			if (arrayStrings[i].length() > nums[i]) {
				answer.append(arrayStrings[i].substring(nums[i]));
			}
		}
		return answer.toString();
	}
}
