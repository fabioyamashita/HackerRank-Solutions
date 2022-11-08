function birthdayCakeCandles(candles) {
  const maxValue = Math.max(...candles);
  return candles.filter((c) => c === maxValue).length;
}

console.log(birthdayCakeCandles([3, 2, 1, 3]));
