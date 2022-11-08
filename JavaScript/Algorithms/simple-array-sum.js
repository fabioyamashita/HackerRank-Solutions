function simpleArraySum(ar) {
  return ar.reduce((a, b) => a + b, 0);
}

console.log(simpleArraySum([1, 2, 3, 4]));
