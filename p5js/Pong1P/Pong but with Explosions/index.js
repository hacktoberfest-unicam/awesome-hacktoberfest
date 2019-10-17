
function setup() 
{
    viewWidth = innerWidth
    viewHeight = innerHeight

    start = false

    createCanvas(viewWidth, viewHeight);

    ball = null;
    paddle_1 = null;
    paddle_2 = null;

    points_1 = 0
    points_2 = 0
    
    key_up = false;
    key_dw = false;
    arena_min = 10;
    arena_max = viewHeight-10;

    sfx_explosion = loadSound('res/explosion.wav')
    spr_explosion = loadImage('res/spr_explosion.png');

    play = createButton('PLAY');
    play.position(viewWidth/2, viewHeight/2);
    play.size(500,300)
    play.center()
    play.style('font-size', '90px');
    play.mousePressed(function()
    {
        start = true

        ball = new Ball();
        paddle_1 = new Paddle(0);
        paddle_2 = new Paddle(1);

        play.remove()
    });

}


//keyboard pressing check
function keyPressed() 
{
    if (keyCode === UP_ARROW) 
    {
        key_up = true;
    } 
    else 
    if (keyCode === DOWN_ARROW) 
    {
        key_dw = true;
    }
}


function keyReleased() 
{
    if (keyCode === UP_ARROW) 
    {
        key_up = false;
    } 
    else 
    if (keyCode === DOWN_ARROW) 
    {
        key_dw = false;
    }
}


function draw() 
{
    clear();

    //draw background
    fill(255, 204, 0);
    rect(0, 0, viewWidth, viewHeight);

    if(start == true)
    {
    
        //loop all instances and update them
        for(let i=0; i<Entity.entityList.length; i++)
        {
            Entity.entityList[i].update()
        }

        //loop all instances and draw them
        for(let i=0; i<Entity.entityList.length; i++)
        {
            Entity.entityList[i].draw()
        }

        //loop all explosion particle and draw them
        for(let i=0; i<Explosion.list.length; i++)
        {
            let current = Explosion.list[i]
            current.update()
            current.draw()
        }

        //draw the score
        textSize(32);
        let p1 = "PLAYER 1 : "+points_1.toString()
        let p2 = "PLAYER 2 : "+points_2.toString()
        text(p1, 200, 50);
        text(p2, viewWidth-400, 50);
    }
}


