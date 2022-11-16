function getMoneySpent(keyboards, drives, b) {
  if (Math.min(...keyboards) + Math.min(...drives) > b) return -1;

  let sumPrices = [];

  for (let keyboard of keyboards) {
    for (let drive of drives) {
      if (keyboard + drive <= b) sumPrices.push(keyboard + drive);
    }
  }

  return Math.max(...sumPrices);
}

console.log(getMoneySpent([3, 1], [5, 2, 8], 5));
