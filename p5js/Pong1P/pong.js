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

//player
PLAYER_X = 5;
PLAYER_Y = (SCREEN_HEIGHT / 2) - (PADDLE_HEIGHT / 2);
PLAYER_SPEED = 10;

//cpu
CPU_X = SCREEN_WIDTH - 15;
CPU_Y = (SCREEN_HEIGHT / 2) - (PADDLE_HEIGHT / 2);
CPU_SPEED = 5;


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
        fill(0, 255, 0);
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
        if(this.isCPU){
            fill(255, 0, 0);
        }
        else{
            fill(0, 0, 255);
        }
        noStroke();
        rect(this.x, this.y, this.width, this.height);
    }

    //cpu requires ball for tracking its position
    move(ball){
        if(!this.isCPU){
            if(keyIsDown(UP_ARROW)){
                if(player.y > 0){
                    player.y -= PLAYER_SPEED;
                }
            }
            if(keyIsDown(DOWN_ARROW)){
                if(player.y < SCREEN_HEIGHT - PADDLE_HEIGHT){
                    player.y += PLAYER_SPEED;
                }
            }
        }
        else{
            if((this.y + (this.width / 2)) < ball.y){
                this.y += CPU_SPEED;
            }
            if(this.y + (this.width / 2) > ball.y){
                this.y -= CPU_SPEED;
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
    ball = new Ball(5, 5);
    player = new Paddle(PLAYER_X, PLAYER_Y, false);
    cpu = new Paddle(CPU_X, CPU_Y, true)
}

//draw function
function draw(){
    //setup background
    background(0);

    //display elements
    ball.display();
    player.display();
    cpu.display();

    //setup movement for elements
    ball.move();
    player.move();
    cpu.move(ball);


    checkCollision();
}

function checkCollision(){
    //cpu
    if(ball.x >= (SCREEN_WIDTH - cpu.width - (BALL_SIZE / 2))){
        //cpu collision
        if(ball.y >= cpu.y && ball.y <= cpu.y + cpu.height){
            ball.delta_x = -ball.delta_x;
        }
        //player wins
        else{
            noLoop();
            fill(0, 0, 255);
            textSize(24);
	        text("Player won!", (SCREEN_WIDTH / 2) - 50, SCREEN_HEIGHT / 2);
        }
    }
    //player 
    if(ball.x <= (player.width + (BALL_SIZE / 2))){
        //player collision
        if (ball.y >= player.y && ball.y <= player.y + player.height){
            ball.delta_x = -ball.delta_x;
        }
        //cpu wins
        else{
            noLoop();
            fill(255, 0, 0);
            textSize(24);
	        text("CPU won!", (SCREEN_WIDTH / 2) - 50, SCREEN_HEIGHT / 2);
        }
    } 
    //screen boundaries
    if(ball.y <= (BALL_SIZE / 2) || ball.y >= SCREEN_HEIGHT - (BALL_SIZE / 2)){
        ball.delta_y = -ball.delta_y;
    }
}
