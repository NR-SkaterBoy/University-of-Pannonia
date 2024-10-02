public class Store {

	private Media[] entries;
	private int idx;

	public Store() {
        this.entries = new Media[10];
		entries[0] = new Video("Ice Nine Kills", "Grave Mistake");
		entries[1] = new Audio("Motionless In White", "Another Life");
		idx = 2;

    }
	
	public void add(Media entry) {

		if( idx >= entries.length) throw new IllegalArgumentException("Media store is full!");

		entries[idx] = entry;
		idx++;
	}
}
