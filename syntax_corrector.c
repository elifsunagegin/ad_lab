#include <math.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>

// Calculating Levenshtein Distance
int minDistance(char *str1, char *str2, char *operations) {
    int len1 = strlen(str1);
    int len2 = strlen(str2);
    int dp[len1 + 1][len2 + 1];
    int i, j;

    for (i = 0; i <= len1; i++) {
        for (j = 0; j <= len2; j++) {
            if (i == 0) {
                dp[i][j] = j;
            } else if (j == 0) {
                dp[i][j] = i;
            } else if (str1[i - 1] == str2[j - 1]) {
                dp[i][j] = dp[i - 1][j - 1];
            } else {
                dp[i][j] = 1 + fmin(dp[i][j - 1], fmin(dp[i - 1][j], dp[i - 1][j - 1]));
            }
        }
    }

    // Operations
    i = len1;
    j = len2;
    int opIndex = 0;
    char tempOperations[len1 + len2 + 1]; // Temporary array to store operations
    while (i > 0 && j > 0) {
        if (str1[i - 1] == str2[j - 1]) {
            i--;
            j--;
        } else if (dp[i][j] == dp[i - 1][j - 1] + 1) {
            tempOperations[opIndex++] = 'S'; // Substitution
            i--;
            j--;
        } else if (dp[i][j] == dp[i - 1][j] + 1) {
            tempOperations[opIndex++] = 'D'; // Deletion
            i--;
        } else if (dp[i][j] == dp[i][j - 1] + 1) {
            tempOperations[opIndex++] = 'I'; // Insertion
            j--;
        }
    }

    while (i > 0) {
        tempOperations[opIndex++] = 'D';
        i--;
    }

    while (j > 0) {
        tempOperations[opIndex++] = 'I';
        j--;
    }

    
    for (int k = 0; k < opIndex; k++) {
        operations[k] = tempOperations[opIndex - k - 1];
    }
    operations[opIndex] = '\0'; // Finish the operation

    return dp[len1][len2];
}

// Syntax Correction Function
void correctSyntax(char *input, char *rule) {
    char operations[strlen(input) + strlen(rule)];
    int distance = minDistance(input, rule, operations);

    printf("Minimum number of operations required to correct the syntax: %d\n", distance);

    printf("Operations: ");
    for (int i = 0; i < strlen(operations); i++) {
        if (operations[i] == 'S') {
            printf("Substitution ");
        } else if (operations[i] == 'D') {
            printf("Deletion ");
        } else if (operations[i] == 'I') {
            printf("Insertion ");
        }
    }
    printf("\n");
}

int main() {
    char input[] = "helo wrld";
    char rule[] = "hello world";
    
    printf("Original Code: %s\n", input);
    printf("Syntax Rule: %s\n", rule);

    correctSyntax(input, rule);
    return 0;
}