import java.util.*;

class Store {
	protected List<Media> entries;

	public Store() {
		// System.out.println("in Store constructor");
		/*
		 * entries = new Media[10];
		 * entries[0] = new Audio("A","B");
		 * entries[1] = new Video("C","D");
		 * index = 2;
		 */
		entries = new ArrayList<>();
		entries.add(new Audio("Another Life", "Motionless in White"));
		entries.add(new Video("Welcome to Horrorwood", "Ice Nine Kills"));
	}

	public void add(Media entry) {
		entries.add(entry);
	}

	public void remove(Media entry) {
		entries.remove(entry);
	}

	public Media getMedia(int index) {
		if ((index < 0) ||
				(index >= entries.size())) {
			throw new IllegalArgumentException();
		}
		return entries.get(index);
	}

	public String toString() {
		Collections.sort(entries);
		String result = "";
		for (int i = 0; i < entries.size(); i++)
			result += (i + 1) + " - " +
					entries.get(i).getTitle() +
					": " +
					entries.get(i).getArtist() +
					"\n";
		return result;
	}
}