function birthday(s, d, m) {
  let countSegments = 0;

  for (let i = 0; i < s.length - m + 1; i++) {
    const sum = s.slice(i, i + m).reduce((acc, curr) => acc + curr, 0);
    if (sum === d) countSegments++;
  }

  return countSegments;
}

console.log(birthday([1, 2, 1, 3, 2], 3, 2));
