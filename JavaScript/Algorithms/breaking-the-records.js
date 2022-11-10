function breakingRecords(scores) {
  let maxMinCount = [0, 0];
  let maxMinScore = [scores[0], scores[0]];

  for (let score of scores) {
    if (score > maxMinScore[0]) {
      maxMinCount[0]++;
      maxMinScore[0] = score;
    } else if (score < maxMinScore[1]) {
      maxMinCount[1]++;
      maxMinScore[1] = score;
    }
  }

  return maxMinCount;
}

console.log(breakingRecords([10, 20, 5, 30]));
