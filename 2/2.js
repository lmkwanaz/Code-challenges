let arr2 = [];
function pattern(x) {
    if (x % 2 == 0) {
        //Argument even
        let y = x / 2;
        if (y == 1) {
            //Argument divide by 2 ==1
            arr2.push(1);
            return arr2;
        } else {
            //Argument divide by 2 greater than 1
            arr2.push(y)
            return pattern(y)
        }
    } else {
        //Argument odd.Recursive call
        return pattern(x * 3 + 1)
    }
}

console.log(pattern(17));
