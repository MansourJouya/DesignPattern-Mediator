# Design Patterns - Mediator

This repository showcases an implementation of the Mediator design pattern in C#. The code demonstrates how to centralize communication between objects to promote loose coupling, making the system more maintainable and flexible.

## Table of Contents
1. [Introduction](#introduction)
2. [Implementation Overview](#implementation-overview)
3. [Installation](#installation)
4. [Usage](#usage)
5. [Contributing](#contributing)
6. [License](#license)
7. [Contact](#contact)

## Introduction
The Mediator design pattern is a behavioral pattern that centralizes communication between objects to promote loose coupling. It defines an object (the mediator) that coordinates interactions between other objects (colleagues), preventing them from referring to each other explicitly.

## Implementation Overview
This repository provides a C# implementation of the Mediator pattern. Key components of the code include:

- **IMediator Interface**: Defines the contract for the mediator.
- **IColleague Abstract Class**: Represents colleagues that communicate through the mediator.
- **Mediator Class**: Concrete implementation that handles communication between registered colleagues.
- **ConcreteColleagueA & ConcreteColleagueB Classes**: Implementations of colleagues that send and receive messages via the mediator.
- **Program Class**: Demonstrates how to use the Mediator pattern in a client application.

## Installation
To get started with this project, clone the repository to your local machine:

```bash
git clone https://github.com/MansourJouya/DesignPattern-Mediator.git
```

Navigate into the project directory:

```bash
cd DesignPattern-Mediator
```

Open the solution in Visual Studio or your preferred C# development environment to explore the implementation.

## Usage
1. Open the solution file (.sln) in your C# development environment.
2. Run the `Program` class to see the Mediator pattern in action.
3. Modify or extend the `ConcreteColleagueA`, `ConcreteColleagueB`, or `Mediator` classes to simulate different scenarios.

### Example Output:
```
Colleague A sending message: Hello, Colleague B!
Colleague B received message: Hello, Colleague B!
Colleague B sending message: Hi, Colleague A! How are you?
Colleague A received message: Hi, Colleague A! How are you?
```

## Contributing
Contributions are welcome! If you would like to contribute to this project, please follow these steps:

1. Fork the repository.
2. Create a new branch (e.g., `git checkout -b feature/YourFeature`).
3. Make your changes and commit them (e.g., `git commit -m "Add some feature"`).
4. Push to the branch (e.g., `git push origin feature/YourFeature`).
5. Open a pull request.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE.txt) file for details.

## Contact
For any inquiries, feel free to reach out at jouya.m@gmail.com.

