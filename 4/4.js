function triangle(x,y,z){
    let largest = 0;
    let var1 = 0
    let var2 = 0
    //Ensure that there is no side that is of length zero or negative
    if (x <= 0 || y <= 0 || z <= 0) {
        return false;
    }
    //Finding the largest length
    if (x > y && x > z) {
        largest = x;
        var1 = y;
        var2 = z;
    } else if (y > z && y > x) {
        largest = y
        var1 = x;
        var2 = z;
    } else {
        largest = z;
        var1 = x;
        var2 = y;
    }
    //Using pythagorus theorem and it states that the sqaure root of the sum of the opposite sqaured 
    //and adjacent is equal to the hyponues  
    let lastEdge = Math.pow(var1, 2) + Math.pow(var2, 2);
    if (Math.sqrt(lastEdge) === largest) {
        return true
    } else {
        return false
    }
}