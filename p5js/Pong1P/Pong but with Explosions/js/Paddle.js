class Paddle extends Entity
{
    constructor(number) 
    {
        super();

        this.x = 0;
        this.y = viewHeight/2;
        this.w = 50
        this.h = 200;

        this.speed = 10;
        this.AI = false;

        if(number == 0)
        {
            this.x = 200;
            this.AI = false;
        }
        else
        {
            this.x = viewWidth-200-this.w
            this.AI = true;
        }
    }
  
    update() 
    {
        //giocatore
        if(this.AI == false)
        {
            if(key_up == true && this.y > arena_min)
            {
                this.y -= this.speed
            }
    
            if(key_dw == true && this.y+this.h < arena_max)
            {
                this.y += this.speed
            }
        }
        else //AI
        {
            if(ball.x > viewWidth/2)
            {
                if(ball.y > this.y  && this.y+this.h < arena_max)
                {
                    this.y += this.speed-Math.random()*4
                }
                if(ball.y < this.y  && this.y > arena_min)
                {
                    this.y -= this.speed-Math.random()*4
                }
            }
        }
        
    }
  
    draw()
    {
        fill(0);
        rect(this.x, this.y, this.w, this.h, 20);
    }
  }