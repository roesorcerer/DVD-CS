# DVD Collection Management System

Welcome to the DVD Collection Management System! This console application allows you to create, modify, and view your DVD collection. You can store information about DVD titles, including their name, genre, release year, and rating.

## Features

1. **Open DVD Information**
   - You can search for a specific DVD by its name and view its details.

2. **New DVD Entry**
   - Add a new DVD to your collection by providing the DVD's name, genre, release year, and rating.

3. **Modify DVD Entry**
   - Modify existing DVD entries by specifying the DVD's name and the attribute you want to change (name, genre, year, or rating).

4. **Close Program**
   - Exit the DVD Collection Management System.

## Getting Started

1. Clone or download this repository to your local machine.

2. Compile and run the `Module04Lab1` project using a C# development environment (e.g., Visual Studio).

3. Follow the on-screen instructions to interact with the DVD Collection Management System.

## Usage

When you run the program, you'll be presented with a menu of options:

- Select `1` to open and view information about a specific DVD by entering its name.
- Select `2` to add a new DVD to your collection by providing the name, genre, release year, and rating.
- Select `3` to modify the details of an existing DVD by specifying the DVD's name and the attribute you want to change.
- Select `4` to exit the program.

## File Storage

The program uses a text file located at `C:\CSharpFiles\dvd.txt` to store the DVD collection data. The data is stored in a CSV (Comma-Separated Values) format with the following columns: "DVD Name," "DVD Genre," "DVD Year," and "DVD Rating."

## Data Structure

The program uses an array of DVD objects to store and manage the DVD collection. Each DVD object has the following properties:

- `Name`: The name of the DVD.
- `Genre`: The genre of the DVD.
- `Year`: The release year of the DVD.
- `Rating`: The rating of the DVD.

## Example Usage

Here's an example of how to use the program:

1. Select `2` to add a new DVD.
2. Enter the DVD's name, genre, year, and rating.
3. Select `1` to open and view information about the added DVD.
4. Select `3` to modify the DVD's details if needed.
5. Repeat these steps to manage your entire DVD collection.

## Notes

- Make sure to handle the file path (`C:\CSharpFiles\dvd.txt`) appropriately based on your system's file structure.

## Author

This DVD Collection Management System was created by [Rowan Stratton] as a part of [COP2456C Microsoft C# Programming].

Enjoy managing your DVD collection with this simple and easy-to-use application!
