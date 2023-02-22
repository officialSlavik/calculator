interface Calculator {
  add: (a: number, b: number) => number;
  subtract: (a: number, b: number) => number;
  multiply: (a: number, b: number) => number;
  divide: (a: number, b: number) => number;
}

class SimpleCalculator implements Calculator {
  add(a: number, b: number) {
    return a + b;
  }
  
  subtract(a: number, b: number) {
    return a - b;
  }
  
  multiply(a: number, b: number) {
    return a * b;
  }
  
  divide(a: number, b: number) {
    if (b === 0) {
      throw new Error('Cannot divide by zero!');
    }
    
    return a / b;
  }
}

// Usage example
const calculator = new SimpleCalculator();
console.log(calculator.add(1, 2)); // Output: 3
console.log(calculator.subtract(5, 3)); // Output: 2
console.log(calculator.multiply(4, 5)); // Output: 20
console.log(calculator.divide(10, 2)); // Output: 5
console.log(calculator.divide(10, 0)); // Throws an error: Cannot divide by zero!
