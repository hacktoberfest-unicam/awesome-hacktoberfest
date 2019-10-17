

/** Convert degrees to radians
* @param {number} degrees
*/
function d_to_r(degrees)
{
    var pi = Math.PI;
    return degrees * (pi/180);
}


/** Return true if the given point are inside the given rectangle
* @param {number} pointX
* @param {number} pointY
* @param {number} rectX
* @param {number} rectY
* @param {number} rectW
* @param {number} rectH
*/
function point_in_rectangle(x,y, rx,ry,rw,rh)
{
    if(x < rw && x > rx && y < rh && y > ry)
    {
        return true;
    }
    else
    {
        return false;
    }
}

/** Random number between range
* @param {number} min
* @param {number} max
*/
function random_range(min, max) 
{ 
  return Math.floor(Math.random() * (max - min + 1) + min);
}