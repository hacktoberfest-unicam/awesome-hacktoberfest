//CONSTANTS
//screen
SCREEN_WIDTH = 800;
SCREEN_HEIGHT = 500;
HEAD_SIZE = 15;
SNAKE_SPEED = 5;

class Snake{
    constructor(){
        this.x = SCREEN_WIDTH / 2;
        this.y = SCREEN_HEIGHT / 2;
        this.size = HEAD_SIZE;
        this.hue = 0;
        this.delta_x = 0;
        this.delta_y = 0;
    }

    display(){
        fill(255,0,0);
        noStroke();
        ellipse(this.x, this.y, this.size, this.size);
    }

    move(){
        if(keyIsDown(UP_ARROW)){
            this.delta_y = -SNAKE_SPEED;
            this.delta_x = 0;
        }
        if(keyIsDown(DOWN_ARROW)){
            this.delta_y = SNAKE_SPEED;
            this.delta_x = 0;
        }
        if(keyIsDown(LEFT_ARROW)){
            this.delta_x = -SNAKE_SPEED;
            this.delta_y = 0;
        }
        if(keyIsDown(RIGHT_ARROW)){
            this.delta_x = SNAKE_SPEED;
            this.delta_y = 0;
        }
        this.x += this.delta_x;
        this.y += this.delta_y;
    }
}

let snake;

function setup(){
    createCanvas(SCREEN_WIDTH, SCREEN_HEIGHT);
    snake = new Snake();
}

function draw(){
    noFill();
    rect(0, 0, SCREEN_WIDTH, SCREEN_HEIGHT);
    snake.display();
    snake.move();
}