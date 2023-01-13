ENCORA TEST

For this challenge, which stated the following:

	"You are given N strings. 
	For each string, perform the following sorting operations: 
	1. Rearrange the alphabets in the string in terms of frequency. i.e. the alphabet having greater frequency comes first. 2. If two or more alphabets have the same frequency, the alphabet which is lexicographically small comes first. 
	Write a program to perform the above sorting operations. 
	Note 
	1. The frequency of an alphabet is the number of times an alphabet appears in a string. 
	Example: Consider the string aabaac; here, the frequency of a is 3, frequency of b is 1, and frequency of c is 1. 
	2. Lexicographic order is the way of ordering words based on the alphabetical order of English letters i.e. "a" is the smallest letter and "z" is the largest letter. 
	Function Description 
	In the provided code snippet, implement the provided sortingOperations (...) method using the variables to print the output. You can write your code in the space below the phrase -WRITE YOUR LOGIC HERE". 
	There will be multiple test cases running so the Input and Output should match exactly as provided. 
	The base output variable result is set to a default value of -404 which can be modified. Additionally, you can add or remove these output variables. 
	Input Format 
	The first line contains N, denoting the number of strings. 
	Next N lines contain strings on which sorting operation has to be performed. 
	Sample Input 
	2 -- denotes N 
	abaccadcc -- denotes a string 
	xyzxy -- denotes a string 
	Output Format 
	The output contains N lines containing strings after the sorting operation is performed. 
	Sample Output 
	ccccaaabd 
	xxyyz 
	Explanation 
	For the first string abaccadcc, "c" has the highest frequency. 
	Hence, we write c followed by "a", "b", and then "d". 
	Hence the output is ccccaaabd. 
	For the second string xyzxy, "x" and "y" both have the same frequencies. 
	Since "x" is lexicographically small, we write that first, followed by "y" and then "z". 
	Hence the output is xyzxy. "
	
I decided to create a consolo application using NET 6. The console application asks the user to input a number (int), then it verifies it is indeed a number. If it is, then it ask to enter N strings of your chooise (being N the number the users first inputs). For each string it verifies it contain only characters, from a to z.
If they do, then it call the service and works each string and creates a new one according to the logic that this exersice requested.

I decided to create an entiy folder for the input class, a DTO folder for the output class, a service folder for service interface and service itself, a helper to manage the exceptions (if the first input is NOT a number and if the string inputs are not string with only a to z charactes) and the program that contains the main method is being run.
Also I created another class library, there I used the xunit framework to create one unit test per image (of the pdf) all of them pass.

