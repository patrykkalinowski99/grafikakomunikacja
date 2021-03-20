package com.zetcode;

import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.FontMetrics;
import java.awt.Graphics;
import java.awt.Image;
import java.awt.Toolkit;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import javax.swing.*;
public class Plansza extends JPanel implements ActionListener {
    private final int B_WIDTH = 800;
    private final int B_HEIGHT = 800;
    private final int DOT_SIZE = 10;
    private final int ALL_DOTS = 6400; // (800*800)/(20*20)
    private final int RAND_POS = 79;
    private final int DELAY = 100;
    private final int x[] = new int[ALL_DOTS];
    private final int y[] = new int[ALL_DOTS];
    private int dots;
    private int ghost_x;
    private int ghost_y;
    private boolean leftDirection = false;
    private boolean rightDirection = true;
    private boolean upDirection = false;
    private boolean downDirection = false;
    private boolean inGame = true;
    private Timer timer;
    private Image ball;
    private Image apple;
    private Image head;
    private Image Tlo;
    public Plansza() {
        initBoard();
    }
    private void initBoard() {
        addKeyListener(new TAdapter());
        setBackground(Color.black);
        setFocusable(true);

        setPreferredSize(new Dimension(B_WIDTH, B_HEIGHT));
        loadImages();
        initGame();
    }
    private void loadImages() {
        ImageIcon iid = new ImageIcon("src/resources/ghost.png");
        ball = iid.getImage();

        ImageIcon iia = new ImageIcon("src/resources/ghost.png");
        apple = iia.getImage();
    }
    private void initGame() {
        dots = 2;
        for (int z = 0; z < dots; z++) {
            x[z] = 50 - z * 10;
            y[z] = 50;
        }
        locateGhost();
        timer = new Timer(DELAY, this);
        timer.start();
    }
    @Override
    public void paintComponent(Graphics g) {
        super.paintComponent(g);
        doDrawing(g);
    }
    private void doDrawing(Graphics g) {
        if (inGame) {
            g.drawImage(apple, ghost_x, ghost_y, this);
            for (int z = 0; z < dots; z++) {
                if (z == 0) {
                    g.drawImage(head, x[z], y[z], this);
                } else {
                    g.drawImage(ball, x[z], y[z], this);
                }
            }
            Toolkit.getDefaultToolkit().sync();
        } else {
            gameOver(g);
        }
    }
    private void gameOver(Graphics g){
        String msg = "Przegrałeś";
        Font small = new Font("Arial", Font.BOLD, 14);
        FontMetrics metr = getFontMetrics(small);
        g.setColor(Color.yellow);
        g.setFont(small);
        g.drawString(msg, (B_WIDTH - metr.stringWidth(msg)) / 2, B_HEIGHT / 2);
    }
    private void checkGhost() {
        if ((x[0] == ghost_x) && (y[0] == ghost_y)) {
            dots++;
            locateGhost();
        }
    }
    private void move() {
        for (int z = dots; z > 0; z--) {
            x[z] = x[(z - 1)];
            y[z] = y[(z - 1)];
        }
        if (leftDirection) {
            x[0] -= DOT_SIZE;
            ImageIcon iih = new ImageIcon("src/resources/headLeft.png");
            head = iih.getImage();
        }
        if (rightDirection) {
            x[0] += DOT_SIZE;
            ImageIcon iih = new ImageIcon("src/resources/headRight.png");
            head = iih.getImage();
        }
        if (upDirection) {
            y[0] -= DOT_SIZE;
            ImageIcon iih = new ImageIcon("src/resources/headUp.png");
            head = iih.getImage();
        }
        if (downDirection) {
            y[0] += DOT_SIZE;
            ImageIcon iih = new ImageIcon("src/resources/headDown.png");
            head = iih.getImage();
        }
    }
    private void checkCollision() {
        for (int z = dots; z > 0; z--) {

            if ((z > 4) && (x[0] == x[z]) && (y[0] == y[z])) {
                inGame = false;
            }
        }
        if (y[0] >= B_HEIGHT) {
            inGame = false;
        }
        if (y[0] < 0) {
            inGame = false;
        }
        if (x[0] >= B_WIDTH) {
            inGame = false;
        }
        if (x[0] < 0) {
            inGame = false;
        }
        if (!inGame) {
            timer.stop();
        }
    }
    private void locateGhost() {
        int r = (int) (Math.random() * RAND_POS);
        ghost_x = ((r * DOT_SIZE));

        r = (int) (Math.random() * RAND_POS);
        ghost_y = ((r * DOT_SIZE));
    }
    @Override
    public void actionPerformed(ActionEvent e) {
        if (inGame) {
            checkGhost();
            checkCollision();
            move();
        }
        repaint();
    }
    private class TAdapter extends KeyAdapter {
        @Override
        public void keyPressed(KeyEvent e) {
            int key = e.getKeyCode();
            if ((key == KeyEvent.VK_LEFT) && (!rightDirection)) {
                leftDirection = true;
                upDirection = false;
                downDirection = false;
            }
            if ((key == KeyEvent.VK_RIGHT) && (!leftDirection)) {
                rightDirection = true;
                upDirection = false;
                downDirection = false;
            }
            if ((key == KeyEvent.VK_UP) && (!downDirection)) {
                upDirection = true;
                rightDirection = false;
                leftDirection = false;
            }
            if ((key == KeyEvent.VK_DOWN) && (!upDirection)) {
                downDirection = true;
                rightDirection = false;
                leftDirection = false;
            }
        }
    }

}