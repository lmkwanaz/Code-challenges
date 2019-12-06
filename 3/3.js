// Given an array of numbers, return the indexes of two numbers that adds up to the given target
// Target-1 = 13,
// Target-2 = 6.
// Array1 = [4,2,5,3,8,7]
// Array2 = [3,7,8,5,4,2]

function add_to_target(arr, target) {
    let arr_index = [];
    for (let i = 0; i < arr.length; i++) {
        for (let j = i + 1; j < arr.length; j++) {
            let sum = arr[i] + arr[j];
            if (sum === target) {
                arr_index.push(i);
                arr_index.push(j);
                return arr_index;
​
            }
        }
    }
}
​
​
let arr1 = [4, 2, 5, 3, 8, 7];
let arr2 = [3, 7, 8, 5, 4, 2];
let target1 = 13;
console.log(add_to_target(arr2, target1), "  This is the answer");
