package com.zetcode;
import java.awt.*;
import javax.swing.*;
public class SnakePacMan extends JFrame {
    public SnakePacMan() {
        initUI();
    }
    private void initUI() {
        add(new Plansza());
        setResizable(false);
        pack();
        setTitle("Reverse Pac-Man");
        setLocationRelativeTo(null);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
    public static void main(String[] args){
        EventQueue.invokeLater(() -> {
            JFrame ex = new com.zetcode.SnakePacMan();
            ex.setVisible(true);
        });

    }
}