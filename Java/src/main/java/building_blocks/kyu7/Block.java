package building_blocks.kyu7;

public class Block {

	int width;
	int length;
	int height;

	public Block(int[] size) {
		width = size[0];
		length = size[1];
		height = size[2];
	}

	public int getWidth() {
		return width;
	}

	public int getLength() {
		return length;
	}

	public int getHeight() {
		return height;
	}

	public int getVolume() {
		return width * length * height;
	}

	public int getSurfaceArea() {
		return 2 * length * width + 2 * length * height + 2 * width * height;
	}

}
