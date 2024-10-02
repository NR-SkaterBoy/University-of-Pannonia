class Main {
    public static void main(String[] args)
    {
        // String Tests
		String word = new String("Good");
		System.out.println(word + " " + word.hashCode());
		String text = "Morning";
		System.out.println(text);
		String s1 = word;
		String s2 = new String(text);
		s1 = word + text;
		
		
		// Arrays
		int numbers[] = new int[5];
		for (int i = 0; i < numbers.length; i++) {
			numbers[i] = i;
			System.out.println(numbers[i]);
		}
		
		Square sq = new Square(5);
		
		System.out.println(sq.getSize());
		System.out.println(sq.getArea());
    }
}



