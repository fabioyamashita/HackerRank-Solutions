function compareTriplets(a, b) {
  const arrRes = [0, 0];
  for (let i = 0; i < a.length; i++) {
    if (a[i] > b[i]) arrRes[0]++;
    else if (a[i] < b[i]) arrRes[1]++;
  }

  return arrRes;
}

console.log(compareTriplets([17, 28, 30], [99, 16, 8]));
