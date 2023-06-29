let from = 12;
let to = 25;

let sum = 0;
let count = 0;

for (let number = from; number < to; number++) //n
{

  if (number < 2) //n*n
  {

    break;

  }

  let isPrime = true;

  for (let i = 2; i <= Math.sqrt(number); i++) //n*n
  {
    if (number % i == 0) //n*n*n
    {
      isPrime = false;
      break;
    }
  }

  if (isPrime) //n*n
  {
    sum += number;
    count++;
  }
}

let avarage = sum / count;
console.log(avarage)
// Big-O = o(n^10)
