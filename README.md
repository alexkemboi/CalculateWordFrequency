# Challenge: Word Frequency Counter

Write a program that reads a text file and calculates the frequency of each word in the file. The program should then display the top N most frequent words along with their frequencies.

Requirements:

    The program should prompt the user to enter the path to the text file.
    Handle cases where the file does not exist or cannot be accessed. Display an appropriate error message in such cases.
    Implement a method named CalculateWordFrequency that takes the path to the text file and the desired number of top words as input and returns a dictionary with word-frequency pairs.
    In the CalculateWordFrequency method, consider words as sequences of characters separated by spaces, punctuation marks, or other non-alphabetic characters. Ignore case sensitivity, meaning 
Hello and hello should be treated as the same word.
    Exclude common stop words like a
 
an
 
the
 etc., from the frequency calculation. You can create a list of stop words to use for filtering.
    Implement a method named DisplayTopWords that takes the word-frequency dictionary and the desired number of top words as input and displays the top N most frequent words along with their frequencies in descending order.
    The program should handle ties in frequency counts, displaying words with the same frequency in alphabetical order.

Example Output:

yaml

Enter the path to the text file: C:\path\to\textfile.txt
Enter the number of top words to display: 5

Top 5 words by frequency:
1. Word1: 50 occurrences
2. Word2: 45 occurrences
3. Word3: 32 occurrences
4. Word4: 32 occurrences
5. Word5: 25 occurrences

You can modify and expand upon this challenge as per your requirements. This challenge involves reading from a file, parsing text, implementing frequency calculations, and sorting the results. It requires critical thinking and problem-solving skills to design an efficient solution.

Good luck! Let me know if you have any questions.
