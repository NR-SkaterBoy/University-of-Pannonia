//import java.io.IOException;
//import java.io.BufferedReader;
//import java.io.InputStreamReader;
import java.io.*;

class IOTest{

	public static void main(String[] args){
		IOTest prog = new IOTest();
		prog.start();
	}
	
	public void start(){
		//keyboardInputTest();
		//fileInputTest();
		fileOutputTest();
	}
	
	private void keyboardInputTest(){
		try{
			// this is our code 
			BufferedReader kb = 
				new BufferedReader(
					new InputStreamReader(
						System.in));
			//int value = System.in.read();
			System.out.print("Type a word: ");
			String value = kb.readLine();
			System.out.println(value);
		}catch(IOException ex){
			ex.printStackTrace();
		}
	}
	
	private void fileInputTest(){
		try{
			// this is our code 
			BufferedReader datafile = 
					new BufferedReader(
						new FileReader("text.txt"));
		/*	boolean finished = false;
			while (!finished){				
				String value = datafile.readLine();
				System.out.println(value);
				if (value == null)
					finished = true;
			}
		*/	
			String value;
			while ((value = datafile.readLine()) != null){				
				System.out.println(value);
			}
		}catch(IOException ex){
			ex.printStackTrace();
		}
	}

	private void fileOutputTest(){
		PrintWriter datafile = null;
		//boolean append = true;
		//boolean autoFlush = true;
		try{
			datafile = 
				new PrintWriter(
					new FileWriter("data.txt", append),
					autoFlush);

			datafile.println("One");
			datafile.println("Two");
			datafile.println("Three");
			//datafile.flush(); // explicit flush
		}catch(IOException ex){
			ex.printStackTrace();
		}finally{
			if (datafile != null) 
				datafile.close();
		}			
	}
}