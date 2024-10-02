class Player {

	private Store store;
	private PlayList[] playlist;
	private int plIdx;

	public static void main(String[] args) {
		new Player().start();
	}
	
	public Player() {
		store = new Store();
		playlist = new PlayList[4];
		plIdx = 0;
	}

	public void start() {
		// TODO: Create a  media player
		addNewPlayer();
		listSongs();
	}

	// TODO: functions one-by-one
	public void addNewPlayer() {
		playlist[plIdx] = new PlayList("playlist-" + (plIdx + 1));
		plIdx++;
	}

	public void listSongs() {
        System.out.println(store.toString());
        // TODO: Implement the listSongs method
    }
}