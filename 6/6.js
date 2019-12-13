// Write a program that returns the sum of all prime numbers that are less than or equal to num.
// (10) should return 17
// (7) should return 17
// (977) should return 73156
// (20) should return 77


function isPrime(num){
    let i = 2;
    for (; i < num; i++){
      if (num % i === 0){
        return false;
      }
    }
    return true;
  }
  function sumPrimes(num) {
    let i = 2;
    let sum = 0;
    for (; i <= num; i++){
      if (isPrime(i)){
        sum = sum + i;
      }
    }
    return sum;
  }
  sumPrimes(10);