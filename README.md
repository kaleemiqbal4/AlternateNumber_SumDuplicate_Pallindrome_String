# Program Collection

This repository contains three distinct C# programs, each with a unique functionality. All programs are implemented in the `Program.cs` file.

## Programs Overview

### 1. Alternate Digits in Reverse Order

**Description:**

This program processes an integer input by reversing its digits and then selecting every alternate digit from the reversed result.

**Usage Example:**

- **Input:** `123456789`
- **Output:** `97531`

**How It Works:**

1. Reverse the digits of the input number.
2. Extract every alternate digit from the reversed number, starting with the first digit.

### 2. Sum of Duplicate Numbers

**Description:**

This program takes an array of integers and calculates the sum of all numbers that appear more than once.

**Usage Example:**

- **Input:** `[1, 1, 3, 5, 5, 2, 6, 3, 3]`
- **Output:** `21` (sum of duplicates: `1 + 1 + 3 + 3 + 3 + 5 + 5`)

**How It Works:**

1. Identify numbers with duplicates in the array.
2. Sum all occurrences of these duplicate numbers.

### 3. Palindrome Checker

**Description:**

This program checks if a given string is a palindrome by comparing the string to its reversed version.

**Usage Example:**

- **Input:** `"radar"`
- **Output:** `True` (since "radar" reads the same forwards and backwards)

**How It Works:**

1. Reverse the input string.
2. Compare the reversed string to the original.
3. Return `True` if they are identical, otherwise return `False`.

## How to Run

To run any of the programs, follow these steps:

1. **Compile the Program:**

   ```bash
   dotnet build
   ```
