# Software Design Principles

The code is designed to be maintainable, scalable, and flexible by following core principles like **Abstraction**, **Encapsulation**, **Polymorphism**, **Inheritance**, and **Composition**. Additionally, the code adheres to the **SOLID principles**, ensuring robust design and easy extensibility.

## Key Principles

### 1. **Abstraction**
- The [`Document`](ConsoleApp/Document.cs#6) class serves as an abstract base class. Specific document types like [`Passport`](ConsoleApp/Document.cs#36) , [`Military`](ConsoleApp/Document.cs#104) , and [`DriveLicense`](ConsoleApp/Document.cs#165)  extend [`Document`](ConsoleApp/Document.cs#6) and implement their own unique behaviors while sharing common properties and methods.

### 2. **Encapsulation**
- Internal state, such as `passportId` in the respective classes, is kept private and accessed only via methods like [`CopyIdentificationCode()`](ConsoleApp/Document.cs#74). 

### 3. **Polymorphism**
- Methods like [`ShowInfo()`](ConsoleApp/Document.cs#32) and [`generateQRCode()`](ConsoleApp/Document.cs#33) are polymorphic. Each document type provides its custom implementation of these methods while maintaining a common interface, allowing flexible interactions with different document types.

### 4. **Composition**
- The [`DriveLicense`](ConsoleApp/Document.cs#165)class demonstrates composition by holding a [`List<Car>`](ConsoleApp/Document.cs#172), indicating a "has-a" relationship between [`DriveLicense`](ConsoleApp/Document.cs#165) and [`Car`](ConsoleApp/Document.cs#151) objects. This allows dynamic associations between objects.

### 5. **Inheritance**
- The document types [`Passport`](ConsoleApp/Document.cs#36), [`Military`](ConsoleApp/Document.cs#104), and [`DriveLicense`](ConsoleApp/Document.cs#165)inherit from the base [`Document`](ConsoleApp/Document.cs#6) class, reducing code duplication and promoting the reuse of common attributes and methods.

### 6. **Single Responsibility Principle (SRP)**
- Each class has a single, focused responsibility. For example, [`Passport`](ConsoleApp/Document.cs#36) manages passport details, [`Military`](ConsoleApp/Document.cs#104) handles military information, and `QRCodeGenerator` focuses on QR code creation. This separation of concerns improves maintainability.

### 7. **Open/Closed Principle (OCP)**
- The code is open for extension but closed for modification. New document types can be added by creating subclasses of [`Document`](ConsoleApp/Document.cs#6) without altering existing code. This allows for easy feature extensions without breaking current functionality.


## SOLID Principles

### 1. **Single Responsibility Principle (SRP)**
- Each class has a single responsibility, such as managing passport details or generating QR codes. This clear focus makes the code easier to maintain and understand.

### 2. **Open/Closed Principle (OCP)**
- The design allows for easy addition of new document types without changing existing code, making it extendable while maintaining stability.

### 3. **Liskov Substitution Principle (LSP)**
- Subtypes can be substituted for their base types. For example, [`Passport`](ConsoleApp/Document.cs#36), [`Military`](ConsoleApp/Document.cs#104), and [`DriveLicense`](ConsoleApp/Document.cs#165)can be used interchangeably as [`Document`](ConsoleApp/Document.cs#6) objects without altering the program’s behavior.

### 4. **Interface Segregation Principle (ISP)**
- Although there are no explicit interfaces, each class implements methods relevant to its task. For example, `ShowInfo()` and `generateQRCode()` are focused on the needs of each specific document type.

### 5. **Dependency Inversion Principle (DIP)**
- The [`DocumentContainer`](ConsoleApp/Document.cs#221) class does not depend on specific document types but instead works with the abstract [`Document`](ConsoleApp/Document.cs#6) class, allowing for loose coupling and greater flexibility.

## Summary

The code demonstrates a strong application of **object-oriented principles** such as **abstraction**, **encapsulation**, **polymorphism**, **inheritance**, and **composition**. It also follows the **SOLID principles**, which ensures that the design is robust, scalable, and easy to maintain. The modular, flexible structure allows for easy extensions while keeping the codebase clean and manageable.
