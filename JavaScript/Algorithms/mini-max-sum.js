function miniMaxSum(arr) {
  const sortedArr = arr.sort();
  const sumArr = sortedArr.reduce((a, b) => a + b, 0);

  const minSum = sumArr - sortedArr[arr.length - 1];
  const maxSum = sumArr - sortedArr[0];

  console.log(`${minSum} ${maxSum}`);
}

miniMaxSum([1, 2, 3, 4, 5]);
