# CSVDataManagementTool

## Overview

The CSV Data Management System is a robust tool designed to handle and manipulate CSV files using object-oriented principles. This project consists of a class library and a console application, adhering to key software engineering principles such as Single Responsibility, Liskov Substitution, and Dependency Inversion Principles.

## Project Structure

### 1. Class Library

- **Purpose**: Implements core classes and data structures for handling CSV data.
- **Requirements**:
  - Implement the required data types and structures as specified.
  - Ensure encapsulation and adherence to OOP principles.
  - Provide public access to classes and methods as needed.
  - Include a parameterless constructor or equivalent for every class.
  - Maintain the specified data structures and behaviors; avoid modifications.
  - Extensions and additional functionality are allowed if they comply with OOP principles.
  - Usage of abstract data types like `List`, `ArrayList`, `Set`, `Stack` is permitted but should not replace specified structures.
  - Document all design decisions and code implementations clearly.

### 2. Console Application

- **Purpose**: Provides a user interface for interacting with CSV files.
- **Features**:
  - **Open CSV File**: Load and validate CSV files. Handle file errors or invalid data gracefully. User provides file paths.
  - **View Data**: Display the first \( N \) or last \( N \) records from the file. User specifies \( N \) and chooses between top or bottom records using enums.
  - **Sort/Filter Data**: Sort or filter data based on specified fields. User provides criteria for filtering.
  - **Save Results**: Save results to a CSV file. Options include creating a new file, replacing an existing file, or appending to an existing file. User specifies file paths.
- **Input Validation**: Validate all user inputs and handle exceptions, including those from the class library.
- **Data Handling**: Ensure accurate reading and writing of CSV files and proper handling of text data, including non-English characters.
- **Error Handling**: Manage exceptions related to data input, array/string operations, and library method calls effectively.

## Getting Started

1. **Clone or Download**: Obtain the project files from the repository.
2. **Build the Solution**: Compile the solution using Visual Studio or a compatible IDE.
3. **Run the Application**: Start the console application and follow the prompts to interact with CSV files.

## Usage

1. **Open a CSV File**:
   - Provide the file path to open a CSV file.
   - The application will validate the file and display errors if any issues occur.

2. **View Data**:
   - Select to view the first \( N \) or last \( N \) records.
   - Specify \( N \) and choose the viewing option (top or bottom).

3. **Sort/Filter Data**:
   - Enter criteria for sorting or filtering based on the available fields.
   - The application will process the data accordingly.

4. **Save Results**:
   - Choose the save mode: create a new file, replace an existing file, or append to an existing file.
   - Specify the file path for saving the results.
