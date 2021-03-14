package com.zetcode;

import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.util.Random;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.Timer;

class Surface extends JPanel implements ActionListener {
    private final int DELAY = 500;
    private Timer timer;
    public Surface() {
        initTimer();
    }
    private void initTimer() {
        timer = new Timer(DELAY, this);
        timer.start();
    }
    public Timer getTimer() {

        return timer;
    }
    private void doDrawing(Graphics g) {
        Graphics2D g2d = (Graphics2D) g;
        //rysujemy niebo
        g.setColor (new Color(26, 102, 255));
        g.fillRect (0,0,900,500);
        //rysujemy słońce
        ((Graphics2D) g).setPaint(Color.YELLOW);
        g.fillArc (20,20,80,80,0,360);
        //pierwsza chmurka
        g.setColor (Color.LIGHT_GRAY);
        g.fillArc (70,20,80,50,0,360);
        g.fillArc (130,20,100,50,0,360);
        g.fillArc (110,00,80,50,0,360);
        //druga chmurka
        g.fillArc (300,10,80,50,0,360);
        g.fillArc (320,30,100,50,0,360);
        g.fillArc (370,13,80,50,0,360);
        //trzecia chmurka
        g.fillArc (500,50,80,50,0,360);
        g.fillArc (530,50,100,50,0,360);
        g.fillArc (510,30,80,50,0,360);
        //czwarta chmurka
        g.fillArc (750,50,80,50,0,360);
        g.fillArc (780,59,100,50,0,360);
        //rysujemy trawe
        g.setColor (Color.green);
        g.fillRect (0,400,900,100);
        //domek
        g.setColor (new Color(255,204,153));
        g.fillRect (250,200,150,200);
        g.fillRect (400,200,150,200);
        g.fillRect (550,200,150,200);
        //dach
        g.setColor (new Color(128,43,0));
        int c [] = {250,475,700};
        int d [] = {200,100,200};
        g.fillPolygon (c, d, 3);
        //komin
        g.fillRect (300,140,30,40);
        g.setColor (new Color(128,43,0));
        //dym z komina
        g.setColor (Color.WHITE);
        g.fillArc (310,110,15,30,0,360);
        g.fillArc (310,100,10,20,0,360);
        g.fillArc (320,80,7,10,0,360);
        g.fillArc (310,85,7,10,0,360);
        //okno lewe
        g.setColor (new Color(0,0,0));
        g.fillRect (300,270,70,80);
        g.setColor (new Color(0,102,255));
        g.fillRect (302,272,66,76);
        g.setColor (new Color(0,0,0));
        g.fillRect (334,272,2,76);
        //okno prawe
        g.setColor (new Color(0,0,0));
        g.fillRect (580,270,70,80);
        g.setColor (new Color(0,102,255));
        g.fillRect (582,272,66,76);
        g.setColor (new Color(0,0,0));
        g.fillRect (614,272,2,76);
        //drzwi
        g.setColor (new Color(0,0,0));
        g.fillRect (450,270,50,130);
        g.setColor (new Color(96,32,32));
        g.fillRect (452,272,46,128);
        //klamka drzwi
        g.setColor (new Color(179,179,204));
        g.fillRect (455,340,10,2);
        //wizjer drzwi
        g.setColor (new Color(179,179,204));
        g.fillRect (475,305,2,2);
        //kaluze pod domkiem
        g.setColor (Color.BLUE);
        g.fillArc (50,405,80,50,0,360);
        g.fillArc (100,405,30,50,0,360);
        //po lewej
        g.fillArc (50,405,80,50,0,360);
        g.fillArc (100,405,30,50,0,360);
        //srodek
        g.fillArc (300,410,100,50,0,360);
        //po prawej
        g.fillArc (700,413,120,30,0,360);
        g.fillArc (730,421,100,30,0,360);
        //buda dla pieska
        g.setColor (new Color(102,51,0));
        g.fillRect (50,350,70,50);
        //wejscie do budy
        g.setColor (Color.BLACK);
        g.fillArc (70,360,30,30,0,360);
        //dach budy
        g.setColor (new Color(77,38,0));
        int k [] = {50,85,120};
        int l [] = {350,320,350};
        g.fillPolygon (k, l, 3);
        //deszcz
        g2d.setPaint(Color.BLUE);
        int w = getWidth();
        int h = getHeight();
        Random r = new Random();
        for (int i = 0; i < 500; i++) {
            int x = Math.abs(r.nextInt()) % w;
            int y = Math.abs(r.nextInt()) % h;
            g2d.drawLine(x, y, x, y);
        }
    }
    @Override
    public void paintComponent(Graphics g) {
        super.paintComponent(g);
        doDrawing(g);
    }
    @Override
    public void actionPerformed(ActionEvent e) {
        repaint();
    }
}
public class rysunek extends JFrame {
    public rysunek() {
        initUI();
    }
    private void initUI() {
        final Surface surface = new Surface();
        add(surface);
        addWindowListener(new WindowAdapter() {
            @Override
            public void windowClosing(WindowEvent e) {
                Timer timer = surface.getTimer();
                timer.stop();
            }
        });
        setTitle("Rysunek");
        setSize(900, 500);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
    public static void main(String[] args) {
        EventQueue.invokeLater(new Runnable() {
            @Override
            public void run() {
                rysunek ex = new rysunek();
                ex.setVisible(true);
            }
        });
    }
}