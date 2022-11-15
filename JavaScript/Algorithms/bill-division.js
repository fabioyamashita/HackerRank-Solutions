function bonAppetit(bill, k, b) {
  const total = bill.reduce((acc, curr) => acc + curr, 0);
  const actual = (total - bill[k]) / 2;

  actual === b ? console.log("Bon Appetit") : console.log(total / 2 - actual);
}

bonAppetit([3, 10, 2, 9], 1, 7);
