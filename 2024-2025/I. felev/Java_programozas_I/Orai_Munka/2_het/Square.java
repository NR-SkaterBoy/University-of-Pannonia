class Square {
	// Constans
	// Variables
	private double size;
	
	// Constructor
	public Square(double size) {
		this.size = size;
	}
	// Methods
	public double getSize() {
		return this.size;
	}
	
	public double getArea() {
		return this.size * this.size;
	}
}