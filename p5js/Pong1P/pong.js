//CONSTANTS

//screen
SCREEN_WIDTH = 800;
SCREEN_HEIGHT = 500;

//ball
BALL_SIZE = 15;
BALL_SPEED = 5;

//paddle
PADDLE_WIDTH = 10;
PADDLE_HEIGHT = 50;
PADDLE_SPEED = 10;

//player
PLAYER_X = 5;
PLAYER_Y = (SCREEN_HEIGHT / 2) - (PADDLE_HEIGHT / 2);

//cpu
CUP_X = SCREEN_WIDTH - 15;
CUP_Y = (SCREEN_HEIGHT / 2) - (PADDLE_HEIGHT / 2);


//ball class
class Ball{
    constructor(delta_x, delta_y){
        this.diameter = BALL_SIZE;
        this.speed = BALL_SPEED;
        this.x = SCREEN_WIDTH/2;
        this.y = SCREEN_HEIGHT/2;
        this.delta_x = delta_x;
        this.delta_y = delta_y;
    }

    display(){
        fill(255, 255, 255);
	    noStroke();
        ellipse(this.x, this.y, this.diameter, this.diameter);
    }

    move(){
        this.x += this.delta_x;
        this.y += this.delta_y;
    }
}

class Paddle{
    constructor(x, y, cpu){
        this.x = x;
        this.y = y;
        this.width = PADDLE_WIDTH;
        this.height = PADDLE_HEIGHT;
        this.isCPU = cpu;
    }

    display(){
        fill(255, 255, 255);
        noStroke();
        rect(this.x, this.y, this.width, this.height);
    }

    move(){
        if(!this.isCPU){
            if(keyIsDown(UP_ARROW)){
                if(player.y > 0){
                    player.y -= PADDLE_SPEED;
                }
            }
            if(keyIsDown(DOWN_ARROW)){
                if(player.y < SCREEN_HEIGHT - PADDLE_HEIGHT)
                player.y += 10;
            }
        }
    }
}

//init elements

let ball;
let player;
let cpu;

//canvas setup
function setup(){
    createCanvas(SCREEN_WIDTH,SCREEN_HEIGHT);
    ball = new Ball(1, 0);
    player = new Paddle(PLAYER_X, PLAYER_Y, false);
    cpu = new Paddle(CUP_X, CUP_Y, true)
}

//draw function
function draw(){
    background(0);
    ball.display();
    player.display();
    cpu.display();
    ball.move();
    player.move();
    cpu.move();
}

function checkCollision(){
    if(ball.x >= SCREEN_WIDTH - (BALL_SIZE / 2)){
        
    }
}
