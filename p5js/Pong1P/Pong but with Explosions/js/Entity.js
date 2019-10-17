class Entity 
{
    static entityList = [];

    constructor()
    {
        //add a new entity to the enityt list
        Entity.entityList[Entity.entityList.length] = this;
    }
}