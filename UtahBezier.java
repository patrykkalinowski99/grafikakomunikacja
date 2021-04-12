import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;
import java.math.BigDecimal;
import java.math.RoundingMode;
import java.io.PrintWriter;
public class UtahBezier {
    private double[][] x_matrix = new double[4][4];
    private double[][] y_matrix = new double[4][4];
    private double[][] z_matrix = new double[4][4];
    private int i, j;
    private static double round(double value, int places) {
        if (places < 0) throw new IllegalArgumentException();
        BigDecimal BigDec = new BigDecimal(Double.toString(value));
        //zaokrąglanie wartości zapisywanych do nowego pliku
        BigDec = BigDec.setScale(places, RoundingMode.HALF_UP);
        return BigDec.doubleValue();
    }
    public void calculate() throws FileNotFoundException{
        //wczytanie plików do zapisu
        PrintWriter teapot = new PrintWriter("C:\\Users\\Patryk\\IdeaProjects\\teapot\\src\\output\\teapot.txt");
        teapot.println("x y z");
        PrintWriter teacup = new PrintWriter("C:\\Users\\Patryk\\IdeaProjects\\teapot\\src\\output\\teacup.txt");
        teacup.println("x y z");
        PrintWriter teaspoon = new PrintWriter("C:\\Users\\Patryk\\IdeaProjects\\teapot\\src\\output\\teaspoon.txt");
        teaspoon.println("x y z");

        double x, y, x_coordinate, y_coordinate, z_coordinate;
        String xyz_coordinates;
        //wczytanie plików do odczytu
        File filePot = new File("C:\\Users\\Patryk\\IdeaProjects\\teapot\\src\\input\\filePot.txt");
        Scanner inPot = new Scanner(filePot);
        File fileCup = new File("C:\\Users\\Patryk\\IdeaProjects\\teapot\\src\\input\\fileCup.txt");
        Scanner inCup = new Scanner(fileCup);
        File fileSpoon = new File("C:\\Users\\Patryk\\IdeaProjects\\teapot\\src\\input\\fileSpoon.txt");
        Scanner inSpoon = new Scanner(fileSpoon);
        //zapis do teapot
        while(inPot.hasNextLine()) {
                for (i = 0; i < 4; i++) {
                    for (j = 0; j < 4; j++) {
                        xyz_coordinates = inPot.next();
                        this.x_matrix[i][j] = Double.parseDouble(xyz_coordinates);
                        xyz_coordinates = inPot.next();
                        this.y_matrix[i][j] = Double.parseDouble(xyz_coordinates);
                        xyz_coordinates = inPot.next();
                        this.z_matrix[i][j] = Double.parseDouble(xyz_coordinates);
                    }
                }
                for (x = 0; x <= 1; x = x + 0.1) {
                    for (y = 0; y <= 1; y = y + 0.1) {
                        x_coordinate = (
                            ((1 - y) * (1 - y) * (1 - y)) * (this.x_matrix[0][0] * (1 - x) * (1 - x) * (1 - x) + 3 * this.x_matrix[0][1] * x * (1 - x) * (1 - x) + 3 * this.x_matrix[0][2] * x * x * (1 - x) + this.x_matrix[0][3] * x * x * x) +
                            (3 * (1 - y) * (1 - y) * y) * (this.x_matrix[1][0] * (1 - x) * (1 - x) * (1 - x) + 3 * this.x_matrix[1][1] * x * (1 - x) * (1 - x) + 3 * this.x_matrix[1][2] * x * x * (1 - x) + this.x_matrix[1][3] * x * x * x) +
                            (3 * (1 - y) * y * y) * (this.x_matrix[2][0] * (1 - x) * (1 - x) * (1 - x) + 3 * this.x_matrix[2][1] * x * (1 - x) * (1 - x) + 3 * this.x_matrix[2][2] * x * x * (1 - x) + this.x_matrix[2][3] * x * x * x) +
                            (y * y * y) * (this.x_matrix[3][0] * (1 - x) * (1 - x) * (1 - x) + 3 * this.x_matrix[3][1] * x * (1 - x) * (1 - x) + 3 * this.x_matrix[3][2] * x * x * (1 - x) + this.x_matrix[3][3] * x * x * x)
                        );
                        y_coordinate = (
                            ((1 - y) * (1 - y) * (1 - y)) * (this.y_matrix[0][0] * (1 - x) * (1 - x) * (1 - x) + 3 * this.y_matrix[0][1] * x * (1 - x) * (1 - x) + 3 * this.y_matrix[0][2] * x * x * (1 - x) + this.y_matrix[0][3] * x * x * x) +
                            (3 * (1 - y) * (1 - y) * y) * (this.y_matrix[1][0] * (1 - x) * (1 - x) * (1 - x) + 3 * this.y_matrix[1][1] * x * (1 - x) * (1 - x) + 3 * this.y_matrix[1][2] * x * x * (1 - x) + this.y_matrix[1][3] * x * x * x) +
                            (3 * (1 - y) * y * y) * (this.y_matrix[2][0] * (1 - x) * (1 - x) * (1 - x) + 3 * this.y_matrix[2][1] * x * (1 - x) * (1 - x) + 3 * this.y_matrix[2][2] * x * x * (1 - x) + this.y_matrix[2][3] * x * x * x) +
                            (y * y * y) * (this.y_matrix[3][0] * (1 - x) * (1 - x) * (1 - x) + 3 * this.y_matrix[3][1] * x * (1 - x) * (1 - x) + 3 * this.y_matrix[3][2] * x * x * (1 - x) + this.y_matrix[3][3] * x * x * x)
                        );
                        z_coordinate = (
                            ((1 - y) * (1 - y) * (1 - y)) * (z_matrix[0][0] * (1 - x) * (1 - x) * (1 - x) + 3 * z_matrix[0][1] * x * (1 - x) * (1 - x) + 3 * z_matrix[0][2] * x * x * (1 - x) + z_matrix[0][3] * x * x * x) +
                            (3 * (1 - y) * (1 - y) * y) * (z_matrix[1][0] * (1 - x) * (1 - x) * (1 - x) + 3 * z_matrix[1][1] * x * (1 - x) * (1 - x) + 3 * z_matrix[1][2] * x * x * (1 - x) + z_matrix[1][3] * x * x * x) +
                            (3 * (1 - y) * y * y) * (z_matrix[2][0] * (1 - x) * (1 - x) * (1 - x) + 3 * z_matrix[2][1] * x * (1 - x) * (1 - x) + 3 * z_matrix[2][2] * x * x * (1 - x) + z_matrix[2][3] * x * x * x) +
                            (y * y * y) * (z_matrix[3][0] * (1 - x) * (1 - x) * (1 - x) + 3 * z_matrix[3][1] * x * (1 - x) * (1 - x) + 3 * z_matrix[3][2] * x * x * (1 - x) + z_matrix[3][3] * x * x * x)
                        );
                        teapot.println(round(x_coordinate, 2) + " " + round(y_coordinate, 2) + " " + round(z_coordinate, 2) + " " + round(x_coordinate + z_coordinate + y_coordinate, 2));
                    }
                }
        }
        teapot.close();
        //zapis do teacup
        while(inCup.hasNextLine()) {
                for (i = 0; i < 4; i++) {
                    for (j = 0; j < 4; j++) {
                        xyz_coordinates = inCup.next();
                        this.x_matrix[i][j] = Double.parseDouble(xyz_coordinates);
                        xyz_coordinates = inCup.next();
                        this.y_matrix[i][j] = Double.parseDouble(xyz_coordinates);
                        xyz_coordinates = inCup.next();
                        z_matrix[i][j] = Double.parseDouble(xyz_coordinates);
                    }
                }
                for (x = 0; x <= 1; x = x + 0.1) {
                    for (y = 0; y <= 1; y = y + 0.1) {
                        x_coordinate = ((1 - y) * (1 - y) * (1 - y)) * (this.x_matrix[0][0] * (1 - x) * (1 - x) * (1 - x) + 3 * this.x_matrix[0][1] * x * (1 - x) * (1 - x) + 3 * this.x_matrix[0][2] * x * x * (1 - x) + this.x_matrix[0][3] * x * x * x) +
                                (3 * (1 - y) * (1 - y) * y) * (this.x_matrix[1][0] * (1 - x) * (1 - x) * (1 - x) + 3 * this.x_matrix[1][1] * x * (1 - x) * (1 - x) + 3 * this.x_matrix[1][2] * x * x * (1 - x) + this.x_matrix[1][3] * x * x * x) +
                                (3 * (1 - y) * y * y) * (this.x_matrix[2][0] * (1 - x) * (1 - x) * (1 - x) + 3 * this.x_matrix[2][1] * x * (1 - x) * (1 - x) + 3 * this.x_matrix[2][2] * x * x * (1 - x) + this.x_matrix[2][3] * x * x * x) +
                                (y * y * y) * (this.x_matrix[3][0] * (1 - x) * (1 - x) * (1 - x) + 3 * this.x_matrix[3][1] * x * (1 - x) * (1 - x) + 3 * this.x_matrix[3][2] * x * x * (1 - x) + this.x_matrix[3][3] * x * x * x);
                        y_coordinate = ((1 - y) * (1 - y) * (1 - y)) * (this.y_matrix[0][0] * (1 - x) * (1 - x) * (1 - x) + 3 * this.y_matrix[0][1] * x * (1 - x) * (1 - x) + 3 * this.y_matrix[0][2] * x * x * (1 - x) + this.y_matrix[0][3] * x * x * x) +
                                (3 * (1 - y) * (1 - y) * y) * (this.y_matrix[1][0] * (1 - x) * (1 - x) * (1 - x) + 3 * this.y_matrix[1][1] * x * (1 - x) * (1 - x) + 3 * this.y_matrix[1][2] * x * x * (1 - x) + this.y_matrix[1][3] * x * x * x) +
                                (3 * (1 - y) * y * y) * (this.y_matrix[2][0] * (1 - x) * (1 - x) * (1 - x) + 3 * this.y_matrix[2][1] * x * (1 - x) * (1 - x) + 3 * this.y_matrix[2][2] * x * x * (1 - x) + this.y_matrix[2][3] * x * x * x) +
                                (y * y * y) * (this.y_matrix[3][0] * (1 - x) * (1 - x) * (1 - x) + 3 * this.y_matrix[3][1] * x * (1 - x) * (1 - x) + 3 * this.y_matrix[3][2] * x * x * (1 - x) + this.y_matrix[3][3] * x * x * x);
                        z_coordinate = ((1 - y) * (1 - y) * (1 - y)) * (z_matrix[0][0] * (1 - x) * (1 - x) * (1 - x) + 3 * z_matrix[0][1] * x * (1 - x) * (1 - x) + 3 * z_matrix[0][2] * x * x * (1 - x) + z_matrix[0][3] * x * x * x) +
                                (3 * (1 - y) * (1 - y) * y) * (z_matrix[1][0] * (1 - x) * (1 - x) * (1 - x) + 3 * z_matrix[1][1] * x * (1 - x) * (1 - x) + 3 * z_matrix[1][2] * x * x * (1 - x) + z_matrix[1][3] * x * x * x) +
                                (3 * (1 - y) * y * y) * (z_matrix[2][0] * (1 - x) * (1 - x) * (1 - x) + 3 * z_matrix[2][1] * x * (1 - x) * (1 - x) + 3 * z_matrix[2][2] * x * x * (1 - x) + z_matrix[2][3] * x * x * x) +
                                (y * y * y) * (z_matrix[3][0] * (1 - x) * (1 - x) * (1 - x) + 3 * z_matrix[3][1] * x * (1 - x) * (1 - x) + 3 * z_matrix[3][2] * x * x * (1 - x) + z_matrix[3][3] * x * x * x);
                        teacup.println(round(x_coordinate, 2) + " " + round(y_coordinate, 2) + " " + round(z_coordinate, 2) + " " + round(x_coordinate + z_coordinate + y_coordinate, 2));
                    }
                }
        }
        teacup.close();
        //zapis do teaspoon
        while(inSpoon.hasNextLine()) {
            for (i = 0; i < 4; i++) {
                for (j = 0; j < 4; j++) {
                    xyz_coordinates = inSpoon.next();
                    this.x_matrix[i][j] = Double.parseDouble(xyz_coordinates);
                    xyz_coordinates = inSpoon.next();
                    this.y_matrix[i][j] = Double.parseDouble(xyz_coordinates);
                    xyz_coordinates = inSpoon.next();
                    z_matrix[i][j] = Double.parseDouble(xyz_coordinates);
                }
            }
            for (x = 0; x <= 1; x = x + 0.1) {
                for (y = 0; y <= 1; y = y + 0.1) {
                    x_coordinate = ((1 - y) * (1 - y) * (1 - y)) * (this.x_matrix[0][0] * (1 - x) * (1 - x) * (1 - x) + 3 * this.x_matrix[0][1] * x * (1 - x) * (1 - x) + 3 * this.x_matrix[0][2] * x * x * (1 - x) + this.x_matrix[0][3] * x * x * x) +
                            (3 * (1 - y) * (1 - y) * y) * (this.x_matrix[1][0] * (1 - x) * (1 - x) * (1 - x) + 3 * this.x_matrix[1][1] * x * (1 - x) * (1 - x) + 3 * this.x_matrix[1][2] * x * x * (1 - x) + this.x_matrix[1][3] * x * x * x) +
                            (3 * (1 - y) * y * y) * (this.x_matrix[2][0] * (1 - x) * (1 - x) * (1 - x) + 3 * this.x_matrix[2][1] * x * (1 - x) * (1 - x) + 3 * this.x_matrix[2][2] * x * x * (1 - x) + this.x_matrix[2][3] * x * x * x) +
                            (y * y * y) * (this.x_matrix[3][0] * (1 - x) * (1 - x) * (1 - x) + 3 * this.x_matrix[3][1] * x * (1 - x) * (1 - x) + 3 * this.x_matrix[3][2] * x * x * (1 - x) + this.x_matrix[3][3] * x * x * x);
                    y_coordinate = ((1 - y) * (1 - y) * (1 - y)) * (this.y_matrix[0][0] * (1 - x) * (1 - x) * (1 - x) + 3 * this.y_matrix[0][1] * x * (1 - x) * (1 - x) + 3 * this.y_matrix[0][2] * x * x * (1 - x) + this.y_matrix[0][3] * x * x * x) +
                            (3 * (1 - y) * (1 - y) * y) * (this.y_matrix[1][0] * (1 - x) * (1 - x) * (1 - x) + 3 * this.y_matrix[1][1] * x * (1 - x) * (1 - x) + 3 * this.y_matrix[1][2] * x * x * (1 - x) + this.y_matrix[1][3] * x * x * x) +
                            (3 * (1 - y) * y * y) * (this.y_matrix[2][0] * (1 - x) * (1 - x) * (1 - x) + 3 * this.y_matrix[2][1] * x * (1 - x) * (1 - x) + 3 * this.y_matrix[2][2] * x * x * (1 - x) + this.y_matrix[2][3] * x * x * x) +
                            (y * y * y) * (this.y_matrix[3][0] * (1 - x) * (1 - x) * (1 - x) + 3 * this.y_matrix[3][1] * x * (1 - x) * (1 - x) + 3 * this.y_matrix[3][2] * x * x * (1 - x) + this.y_matrix[3][3] * x * x * x);
                    z_coordinate = ((1 - y) * (1 - y) * (1 - y)) * (z_matrix[0][0] * (1 - x) * (1 - x) * (1 - x) + 3 * z_matrix[0][1] * x * (1 - x) * (1 - x) + 3 * z_matrix[0][2] * x * x * (1 - x) + z_matrix[0][3] * x * x * x) +
                            (3 * (1 - y) * (1 - y) * y) * (z_matrix[1][0] * (1 - x) * (1 - x) * (1 - x) + 3 * z_matrix[1][1] * x * (1 - x) * (1 - x) + 3 * z_matrix[1][2] * x * x * (1 - x) + z_matrix[1][3] * x * x * x) +
                            (3 * (1 - y) * y * y) * (z_matrix[2][0] * (1 - x) * (1 - x) * (1 - x) + 3 * z_matrix[2][1] * x * (1 - x) * (1 - x) + 3 * z_matrix[2][2] * x * x * (1 - x) + z_matrix[2][3] * x * x * x) +
                            (y * y * y) * (z_matrix[3][0] * (1 - x) * (1 - x) * (1 - x) + 3 * z_matrix[3][1] * x * (1 - x) * (1 - x) + 3 * z_matrix[3][2] * x * x * (1 - x) + z_matrix[3][3] * x * x * x);
                    teaspoon.println(round(x_coordinate, 2) + " " + round(y_coordinate, 2) + " " + round(z_coordinate, 2) + " " + round(x_coordinate + z_coordinate + y_coordinate, 2));
                }
            }
        }
        teaspoon.close();
    }
    public static void main(String[] args) throws FileNotFoundException {
        UtahBezier utah = new UtahBezier();
        utah.calculate();
    }
}