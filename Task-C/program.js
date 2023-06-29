let from = 12;
let to = 25;

let sum = 0;
let count = 0;

for (let number = from; number < to; number++) 
{

  if (number < 2) 
  {

    break;

  }

  let isPrime = true;

  for (let i = 2; i <= Math.sqrt(number); i++) 
  {
    if (number % i == 0) 
    {
      isPrime = false;
      break;
    }
  }

  if (isPrime) 
  {
    sum += number;
    count++;
  }
}

let avarage = sum / count;
console.log(avarage)