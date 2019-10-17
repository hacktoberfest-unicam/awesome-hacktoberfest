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
        }
        if(keyIsDown(DOWN_ARROW)){
        }
        if(keyIsDown(DOWN_ARROW)){
        }
        if(keyIsDown(DOWN_ARROW)){
        }
        this.x += this.delta_x;
        this.y = this.delta_y;
    }
}

let snake;

function setup(){
    createCanvas(SCREEN_WIDTH, SCREEN_HEIGHT);
    snake = new Snake();
}

function draw(){
    background(200,200,200);
    snake.display();
    snake.move();
}