# Coffee Shop Locator

## Problem Description  

Takes a user's coordinates and a list of coffee shops and returns the closest three.

## Input  

The program receives three command-line arguments:
1. user x coordinate
2. user y coordinate
3. shop data url – A URL pointing to a CSV file containing coffee shop locations.

The coffee shop list is in CSV format, where each row has the following structure: Name,Y Coordinate,X Coordinate.
Malformed entries in the CSV should cause the program to exit.

## Output  
The program outputs the three closest coffee shops in ascending order of distance. Each line should contain: <Shop Name>,<Distance>

## How to Run the Program
Using the CLI: dotnet run -- <user_x> <user_y> <shop_data_url>

Example of a successful run: dotnet run -- 47.6 -122.4 https://raw.githubusercontent.com/Agilefreaks/test_oop/master/coffee_shops.csv
Note: The result of this run is different from the expected output in the task. That is probably because the structure of the rows specified in the task is (Name,Y Coordinate,X Coordinate), whereas the output example uses (Name, X Coordinate, Y Coordinate).

Example for badly formatted data: dotnet run -- 47.6 -122.4 https://raw.githubusercontent.com/datasciencedojo/datasets/master/titanic.csv