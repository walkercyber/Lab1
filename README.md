#Find Numbers in String C# Console App

This C# console application scans a text string and finds substrings that are numbers meeting specific criteria:

The number starts and ends with the same digit

The starting/ending digit does not appear anywhere in the middle

The substring contains only digits (no letters or symbols in between)

For example:

✅ 3463 → valid

❌ 34363 → invalid (the digit 3 appears again inside)

❌ 95a9 → invalid (contains a letter)

When a match is found, the program prints the entire input string, highlighting the matching substring in pink.
