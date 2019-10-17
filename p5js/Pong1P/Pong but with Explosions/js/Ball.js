class Ball extends Entity
{
    constructor() 
    {
        super();
        this.x = viewWidth/2;
        this.y = viewHeight/2;
        this.diameter = 30;
  
        this.speed = 8;
        this.hspeed = -Math.round(Math.random()+this.speed)
        this.vspeed = -Math.round(Math.random()+this.speed)
    }
  
    /**
     * reset the ball position
     */
    reset()
    {
        this.x = viewWidth/2;
        this.y = viewHeight/2;

        this.hspeed = -Math.round(Math.random()+this.speed)
        this.vspeed = -Math.round(Math.random()+this.speed)
    }


    update() 
    {
        let collX = false;
        let collY = false;

        //collision check with paddles
        if(point_in_rectangle(this.x-this.diameter/2, this.y, paddle_1.x, paddle_1.y, paddle_1.x+paddle_1.w, paddle_1.y+paddle_1.h))
        {
              collX = true
        }

        if(point_in_rectangle(this.x+this.diameter/2, this.y, paddle_2.x, paddle_2.y, paddle_2.x+paddle_2.w, paddle_2.y+paddle_2.h))
        {
            collX = true
        }

        //collision check with arena border
        if(this.x-this.diameter/2 < 0 || this.x+this.diameter/2 > viewWidth)
        {
            collX = true
        }

        if(this.y-this.diameter/2 < 0 || this.y+this.diameter/2 > arena_max)
        {
            collY = true
        }


        //if collision occur bounce, play sound and create particles
        if(collX == true)
        {
          this.hspeed = -this.hspeed
          sfx_explosion.play()

          for(let i=0; i<50; i++)
          {
            new Explosion(this.x, this.y);
          }
        }

        if(collY == true)
        {
          this.vspeed = -this.vspeed
          sfx_explosion.play()

          for(let i=0; i<50; i++)
          {
            new Explosion(this.x, this.y);
          }
        }
        
        //update position
        this.x = this.x+this.hspeed
        this.y = this.y+this.vspeed


        //goal
        if(this.x <  this.diameter)
        {
          points_2 += 100
          this.reset()
        }
        if(this.x > viewWidth- this.diameter)
        {
          points_1 += 100
          this.reset()
        }


    }
  
    draw()
    {
        fill(0);
        ellipse(this.x, this.y, this.diameter, this.diameter);
    }
  }