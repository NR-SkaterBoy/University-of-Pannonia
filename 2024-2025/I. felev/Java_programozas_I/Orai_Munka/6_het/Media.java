import java.util.*;

class Media implements Comparable {

	protected String title;
	protected String artist;
	protected int length; // audio length in seconds
	protected String path;
	protected String genre;

	public int CompareTo(T target) {
		this.title.compareTo(target);
	}

	public Media(String title, String artist) {
		this.title = title;
		this.artist = artist;
	}

	public String getTitle() {
		return title;
	}

	public String getArtist() {
		return artist;
	}

}