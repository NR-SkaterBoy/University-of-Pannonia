import java.util.*;
import java.io.*;

class Player {
	private Store store;
	// private PlayList[] playlist;
	private List<PlayList> playlists;
	// private int plIndex;

	public static void main(String[] args) {
		new Player().start();
		// sortDemo();
	}

	public static void sortDemo() {
		List<String> words = new ArrayList<>();
		words.add("red");
		words.add("blue");
		words.add("green");
		words.add("yellow");
		for (int i = 0; i < words.size(); i++)
			System.out.println(words.get(i));

		System.out.println("After sorting:");
		Collections.sort(words);

		for (int j = 0; j < words.size(); j++)
			System.out.println(words.get(j));

	}

	public Player() {
		store = new Store();
		// playlist = new PlayList[4];
		playlists = new ArrayList<>();
		// plIndex = 0;
	}

	public void start() {
		// create a media player
		addNewPlaylist();
		listSongs();
		String value = getUserInput();
		System.out.println(value);
		// retrieve song
		int songIndex = 0;
		try {
			songIndex = Integer.valueOf(value) - 1;
			Media song = store.getMedia(songIndex);
			// play song
			play(song);
			playlists.get(0).add(song);
			System.out.println(playlists.get(0));
		} catch (NumberFormatException ex) {
		}

	}

	// functions one-by-one
	public void addNewPlaylist() {
		/*
		 * if (plIndex >= playlist.length)
		 * throw new
		 * IllegalArgumentException(
		 * "Playlist store is full.");
		 * 
		 * playlist[plIndex] =
		 * new PlayList("playlist-" +
		 * (plIndex + 1));
		 */ playlists.add(new PlayList("playlist-" +
				(playlists.size() + 1)));
		// plIndex++;
	}

	public void listSongs() {
		System.out.println(store);
	}

	public String getUserInput() {
		try {
			// this is our code
			BufferedReader kb = new BufferedReader(
					new InputStreamReader(
							System.in));
			// System.out.print("Type a word: ");
			String value = kb.readLine();
			if (value == null)
				return "";
			else
				return value;
		} catch (IOException ex) {
			ex.printStackTrace();
		}
		return "";
	}

	public void play(Media media) {
		// play selected song
		System.out.println("Playing selected song...");
	}
}