class Explosion
{
    static list = [];

    constructor(x,y)
    {
        this.x = x
        this.y = y
        this.size = 150

        this.hspeed = random_range(-8,8)
        this.vspeed =random_range(-8,8)

        this.id = Explosion.list.length
        Explosion.list[this.id] = this;
    }


    update()
    {
        this.x += this.hspeed
        this.y += this.vspeed    
        
        if(this.size <= 0)
        {
            this.size = 0

            Explosion.list.splice(this.id,1)
            delete this
        }
        else
        {
            this.size -= 5
        }
    }


    draw()
    {
        if(this.size > 0)
        {
            image(spr_explosion, this.x, this.y, this.size, this.size)
        }
        
    }
}