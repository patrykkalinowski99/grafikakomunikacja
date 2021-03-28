import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

class pk extends Component implements ActionListener {
    //wspolrzedne x
    private final int pX[][] = {
            {503, 450, 653, 727},
            {503, 527, 587, 558},
            {501, 567, 612, 558},
            {501, 451, 441, 578},
            {753, 713, 662, 574},
            {753, 774, 972, 887},
            {746, 774, 843, 887},
            {746, 728, 731, 780},
            {863, 825, 808, 780},
            {863, 887, 871, 847},
            {782, 813, 844, 847},
            {782, 743, 704, 730},
            {905, 822, 733, 730},
            {905, 938, 993, 852},
            {727, 735, 828, 852},
            {1067, 1181, 1208, 1298},
            {1187, 1258, 1285, 1298},
            {1187, 1138, 1097, 1087},
            {1108, 1104, 1081, 1087},
            {1108, 1133, 1158, 1175},
            {1238, 1219, 1208, 1175},
            {1238, 1224, 1184, 1120},
            {1011, 1014, 1098, 1120},
            {1011, 1012, 1029, 1047},
            {1070, 1082, 1085, 1044},
            {1070, 1090, 1100, 1060},
            {996, 999, 1008, 1060},
            {996, 999, 968, 1069},
            {1419, 1412, 1316, 1179},
            {1303, 1315, 1147, 1179},
            {1303, 1279, 1265, 1259},
            {1314, 1283, 1255, 1259},
            {1314, 1371, 1365, 1341},
            {1286, 1302, 1318, 1341},
            {1286, 1284, 1267, 1285},
            {1312, 1323, 1297, 1285},
            {1312, 1308, 1221, 1159},
            {1261, 1177, 1148, 1159},
            {1261, 1333, 1324, 1376},
            {1426, 1478, 1420, 1376},
            {1426, 1396, 1409, 1417},
            {1455, 1469, 1428, 1417},
            {1455, 1456, 1435, 1403}
    };
    //wspolrzedne y
    private final int pY[][] = {
            {436,543,557,133},
            {436, 384, 395, 442},
            {398, 340, 429, 442},
            {398, 442, 567, 503},
            {172, 336, 461, 504},
            {172, 75, 63, 229},
            {346, 365, 316, 229},
            {346, 341, 272, 332},
            {350, 364, 364, 332},
            {350, 345, 328, 341},
            {311, 361, 343, 341},
            {311, 269, 313, 352},
            {240, 387, 366, 352},
            {240, 178, 23, 50},
            {135, 86, 52, 50},
            {481, 472, 308, 63},
            {96, 156, 42, 63},
            {96, 51, 70, 109},
            {100, 98, 140, 109},
            {100, 70, 90, 106},
            {130, 139, 130, 106},
            {130, 150, 328, 416},
            {419, 480, 444, 416},
            {419, 374, 352, 354},
            {398, 383, 348, 354},
            {398, 426, 346, 346},
            {403, 379, 340, 346},
            {403, 379, 491, 480},
            {116, 75, 247, 271},
            {281, 185, 270, 271},
            {281, 364, 389, 432},
            {446, 469, 479, 432},
            {446, 405, 387, 406},
            {445, 449, 429, 406},
            {445, 447, 424, 386},
            {248, 291, 342, 386},
            {248, 226, 191, 267},
            {257, 303, 279, 267},
            {257, 212, 201, 159},
            {147, 102, 117, 159},
            {147, 167, 190, 165},
            {114, 147, 143, 165},
            {114, 101, 94, 115}
    };
    //tworzenie rysunku
    public void paint(Graphics g) {
        Graphics2D g2d = (Graphics2D) g;
        g2d.setRenderingHint(RenderingHints.KEY_ANTIALIASING, RenderingHints.VALUE_ANTIALIAS_ON);
        g2d.setRenderingHint(RenderingHints.KEY_RENDERING, RenderingHints.VALUE_RENDER_QUALITY);
        g.setColor(Color.BLUE);
        for (int k = 0; k < pX.length; k++){
            for (double t=0.0; t<=1.0; t+=0.0005){
                double tx=(1-t)*(1-t)*(1-t)* pX[k][0]+3*t*(1-t)*(1-t)* pX[k][1]+3*t*t*(1-t)* pX[k][2]+t*t*t* pX[k][3];
                double ty=(1-t)*(1-t)*(1-t)* pY[k][0]+3*t*(1-t)*(1-t)* pY[k][1]+3*t*t*(1-t)* pY[k][2]+t*t*t* pY[k][3];
                int px = (int)tx;
                int py = (int)ty;
                g.drawLine(px,py,px,py);
            }
        }
        g2d.dispose();
    }
    @Override
    //malowanie
    public void actionPerformed(ActionEvent arg0) {
        repaint();
    }
}
//wywolanie funkcji
public class Main extends JFrame {
    public Main() {
        initUI();
    }
    private void initUI() {
        //tworzenie nowego obrazka i ustawienie rozdzielczosci
        add(new pk());
        setTitle("PL");
        setSize(1920, 1080);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
    public static void main(String[] args) {
        EventQueue.invokeLater(new Runnable() {
            @Override
            //uruchomienie obrazka
            public void run() {
                Main ex = new Main();
                ex.setVisible(true);
            }
        });
    }
}