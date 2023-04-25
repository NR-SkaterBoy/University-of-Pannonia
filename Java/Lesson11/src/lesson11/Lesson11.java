/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package lesson11;

/**
 *
 * @author nrric
 */

abstract class Shape {
    public abstract double area();
}

class Circle extends Shape {
    @Override
    public double area() {
        return 20;
    };
}

public class Lesson11 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Shape[] shapes = new Shape[2];
        shapes[0] = new Circle();
        shapes[1] = new Circle();
        double sumArea = 0;
        for (Shape shape : shapes) {
            sumArea += shape.area();
        }
        System.out.println("sumArea = " + sumArea);
    }
    
}
