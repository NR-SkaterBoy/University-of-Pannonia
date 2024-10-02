public class Media {
	protected String title;
	protected String artist;
	protected int length; // sudio length in seconds
	protected String path;
	protected String genree;

	public Media(String artist, String songTitle) {
		this.artist = artist;
		this.title = songTitle;
	}
}
