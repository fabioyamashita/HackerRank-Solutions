function diagonalDifference(arr) {
  let primDiag = 0;
  let secDiag = 0;

  for (let i = 0; i < arr.length; i++) {
    primDiag += arr[i][i];
    secDiag += arr[i][arr.length - 1 - i];
  }

  return Math.abs(primDiag - secDiag);
}

console.log([11, 2, 4], [4, 5, 6], [10, 8, -12]);
