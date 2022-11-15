// HOW TO REMOVE DUPLICATES IN JS
// https://stackoverflow.com/questions/1960473/get-all-unique-values-in-a-javascript-array-remove-duplicates

function sockMerchant(n, ar) {
  let count = 0;

  ar.filter((value, index, self) => self.indexOf(value) === index).forEach(
    (uniqueValue) => {
      count += Math.trunc(
        ar.filter((value) => value === uniqueValue).length / 2
      );
    }
  );

  return count;
}

console.log(sockMerchant(7, [3, 2, 1, 2, 1, 1, 2]));
