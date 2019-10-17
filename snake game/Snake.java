import java.awt.*;
import java.awt.event.*;
import static java.lang.String.format;
import java.util.*;
import java.util.List;
import java.util.concurrent.ThreadLocalRandom;
import javax.swing.*;
 
public class Snake extends JPanel implements Runnable {
                                                                                                                                                                                     enum
        Dir {sopra(0, -1), destra(1, 0), sotto(0, 1), sinistra(-1, 0);
 
        Dir(int x, int y) {
            this.x = x; this.y = y;
        }
 
        int x, y;
    }
 
     Random rand = new Random();
     int MURO = -1;
     int MASSIMA_ENERGIA = 1500;
 
     boolean gameOver = true;
 
    Thread gameThread;
    int punteggio;
    int record;
    int nRighe = 44;
    int nColonne = 64;
    Dir dir;
    int energia;
 
    int[][] grid;
    List<Point> snake, cibo;
    Font smallFont;
 
    public Snake() {
         
        setPreferredSize(new Dimension(640, 440));
        setBackground(Color.WHITE);
        setFont(new Font("SansSerif", Font.BOLD, 50));
        setFocusable(true);
 
        smallFont = getFont().deriveFont(Font.BOLD, 20);
        initGrid();
 
        addMouseListener(new MouseAdapter() {
            @Override
            public void mousePressed(MouseEvent e) {
                if (gameOver) {
                    startNewGame();
                    repaint();
                }
            }
        });
 
        addKeyListener(new KeyAdapter() {
 
            @Override
            public void keyPressed(KeyEvent e) {
 
                switch (e.getKeyCode()) {
 
                    case KeyEvent.VK_UP:
                      
                            dir = Dir.sopra;
                        break;
 
                    case KeyEvent.VK_LEFT:
                      
                            dir = Dir.sinistra;
                        break;
 
                    case KeyEvent.VK_RIGHT:
                   
                            dir = Dir.destra;
                        break;
 
                    case KeyEvent.VK_DOWN:
                        
                            dir = Dir.sotto;
                        break;
                }
                repaint();
            }
        });
    }
 
    void startNewGame() {
        gameOver = false;
 
        stop();
        initGrid();
        cibo = new LinkedList<>();
 
        dir = Dir.sinistra;
        energia = MASSIMA_ENERGIA;
 
        if (punteggio > record)
            record = punteggio;
        punteggio = 0;
 
        snake = new ArrayList<>();
        for (int x = 0; x < 7; x++)
            snake.add(new Point(nColonne / 2 , nRighe / 2));
 
        do
            addTreat();
        while(cibo.isEmpty());
 
        (gameThread = new Thread(this)).start();
    }
 
    void stop() {
        if (gameThread != null) {
          gameThread = null;
           }
    }
 
    void initGrid() {
        grid = new int[nRighe][nColonne];
        for (int r = 0; r < nRighe; r++) {
            for (int c = 0; c < nColonne; c++) {
                if (c == 0 || c == nColonne -1 || r == 0 || r == nRighe - 1)
                    grid[r][c] = MURO;
            }
        }
    }
 
    @Override
    public void run() {
 
        while (Thread.currentThread() == gameThread) {
 
            try {
                Thread.sleep(Math.max(77 - punteggio, 25));
            } catch (InterruptedException e) {
            }
 
            if (energyUsed() || hitsWall() || hitsSnake()) {
                gameOver();
            } else {
                if (mangiaCibo()) {
                    punteggio++;
                    energia = MASSIMA_ENERGIA;
                    growSnake();
                }
                moveSnake();
                addTreat();
            }
            repaint();
        }
    }
 
    boolean energyUsed() {
        energia -= 10;
        if(energia==0) return true;
        else return false;
    }
 
    boolean hitsWall() {
        Point head = snake.get(0);
        int nextCol = head.x + dir.x;
        int nextRow = head.y + dir.y;
        if(grid[nextRow][nextCol] == MURO) return true;
        else return false; 
    }
 
    boolean hitsSnake() {
        Point head = snake.get(0);
        int nextCol = head.x + dir.x;
        int nextRow = head.y + dir.y;
        for (Point p : snake)
            if (p.x == nextCol && p.y == nextRow)
                return true;
        return false;
    }
 
    boolean mangiaCibo() {
        Point head = snake.get(0);
        int nextCol = head.x + dir.x;
        int nextRow = head.y + dir.y;
        for (Point p : cibo)
            if (p.x == nextCol && p.y == nextRow) {
                cibo.remove(p);
                return true;
            }
        return false;
    }
 
    void gameOver() {
        gameOver = true;
        stop();
    }
 
    void moveSnake() {
        for (int i = snake.size() - 1; i > 0; i--) {
            Point p1 = snake.get(i - 1);
            Point p2 = snake.get(i);
            p2.x = p1.x;
            p2.y = p1.y;
        }
        Point head = snake.get(0);
        head.x += dir.x;
        head.y += dir.y;
    }
 
    void growSnake() {
        Point tail = snake.get(snake.size() - 1);
        int x = tail.x + dir.x;
        int y = tail.y + dir.y;
        snake.add(new Point(x, y));
    }
    void addTreat() {
        if (cibo.size() < 3) {
 
            if (rand.nextInt(10) == 0) {
 
                if (rand.nextInt(4) != 0) {  
                        int x = ThreadLocalRandom.current().nextInt(10,nColonne);
                        int y = ThreadLocalRandom.current().nextInt(10,nRighe);
                        Point p = new Point(x, y); 
                        cibo.add(p);
                } 
            }
        }
    }
    void drawGrid(Graphics2D g) {
        g.setColor(Color.black);
        for (int r = 0; r < nRighe; r++) {
            for (int c = 0; c < nColonne; c++) {
                if (grid[r][c] == MURO)
                    g.fillRect(c * 10, r * 10, 10, 10);
            }
        }
    }
 
    void drawSnake(Graphics2D g) {
        g.setColor(Color.blue);
        for (Point p : snake)
            g.fillRect(p.x * 10, p.y * 10, 10, 10);
 
        g.setColor(energia < 500 ? Color.red : Color.orange);
        Point head = snake.get(0); 
        g.fillRect(head.x * 10, head.y * 10, 10, 10); 
    }
 
    void drawTreats(Graphics2D g) {
        g.setColor(Color.green);
        for (Point p : cibo) 
            g.fillRect(p.x * 10, p.y * 10, 10, 10);
    }
 
    void drawStartScreen(Graphics2D g) {
        g.setColor(Color.blue);
        g.setFont(getFont());
        g.drawString("Snake", 240, 190);
        g.setColor(Color.orange);
        g.setFont(smallFont);
        g.drawString("Premi Start", 260, 240);
    }
 
    void drawScore(Graphics2D g) {
        int h = getHeight();
        g.setFont(smallFont);
        g.setColor(getForeground());
        String s = format("Record %d    Punteggio %d", record, punteggio);
        g.drawString(s, 30, h - 30);
        g.drawString(format("Energia %d", energia), getWidth() - 150, h - 30);
    }
    @Override
    public void paintComponent(Graphics gg) {
        super.paintComponent(gg);
        Graphics2D g = (Graphics2D) gg;
        g.setRenderingHint(RenderingHints.KEY_ANTIALIASING,
                RenderingHints.VALUE_ANTIALIAS_ON);
 
        drawGrid(g);
 
        if (gameOver) {
            drawStartScreen(g);
        } else {
            drawSnake(g);
            drawTreats(g);
            drawScore(g);
        }
    }
 
    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            JFrame f = new JFrame();
            f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
            f.setTitle("Snake");
            f.setResizable(false);
            f.add(new Snake(), BorderLayout.CENTER);
            f.pack();
            f.setLocationRelativeTo(null);
            f.setVisible(true);
        });
    }
} 