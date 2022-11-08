function timeConversion(s) {
  if (s.includes("PM") && s.slice(0, 2) != 12)
    return s.replace("PM", "").replace(/^.{2}/g, Number(s.slice(0, 2)) + 12);
  else if (s.includes("AM") && s.slice(0, 2) == 12)
    return s.replace("AM", "").replace(/^.{2}/g, "00");

  return s.slice(0, -2);
}

console.log(timeConversion("12:05:45AM"));
