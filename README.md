# Multiple Choice Question (MCQ) App

## **Table of Contents**

1. [Overview](#overview)
2. [Technologies](#technologies)
3. [Setup](#setup)
4. [Usage](#usage)
5. [Structure](#structure)
6. [Contribution](#contribution)
7. [License](#license)

## **Overview**

This project is a console-based Multiple Choice Question (MCQ) application in C#. The application allows creating a multiple choice test paper and taking the test as a student. It calculates the score based on the answers given by the student and shows the total score percentage.

## **Technologies**

The project is created with:

* C# .NET Core

## **Setup**

To run this project, you need .NET Core SDK installed in your machine. You can download it from [here](https://dotnet.microsoft.com/download). After installing .NET Core SDK, use the following command to run the program:

## **Usage**

The application starts by asking for information to create the test paper such as the subject name, test paper name, question text and the correct answer. After the test paper is created, it allows a student to take the test. The student needs to enter his/her roll number and name. Then, the application shows each question one by one and asks for the answer. After all questions are answered, it calculates the total score percentage and displays it.

## **Structure**

The application has been divided into four main parts:

* **Interfaces**: Defines the interfaces for Test Paper, Question, Option and Student.
* **Classes**: Defines the implementation of interfaces.
* **TestPaperBuilderLibrary**: Contains the TestPaperBuilder class which is responsible for creating a test paper.
* **TestTakerLibrary**: Contains the TestTakerClass which is responsible for taking the test.
* **SharedLibrary**: Contains a helper class, InputValidator, for validating user inputs.

## **Contribution**

Feel free to contribute to this project. Fork this repository, make your changes and create a pull request.

## **License**

This project is under the MIT License. See the [LICENSE](LICENSE) file for more details.

