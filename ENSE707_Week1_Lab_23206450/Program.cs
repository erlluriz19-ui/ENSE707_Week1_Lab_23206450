//ENSE707 Bank Lab (Lab1)

/* Activity 1:
 * 1) commiting regularly can make it easier to roll back to an older version if a fatal bug affecting the software 
 * 
 * 2) by showing that the person working on the project has been continuously working on it by making meaningful commits and showing
 * what they have worked on in their session of writing up lines for the project
 *
 *Activity 3:
 * 1) It would continue the calculations which would breach Functional Stability as the account would start in debt,
 * this would likely be invalid for the system which could lead to incorrect account behaviour. fix by making 
 * be validated first to ensure it is zero or more opening balance 
 * 
 * 2) it would continue on with the calculation which means it would treat it like it was a withdrawal which
 *  would also breach Functional Stability. To fix this it should first validate if the deposit amount is positive
 *  and is greater than 0
 *  
 *  3) The calculation would continue and would make the new balance go into the negatives
 *  
 *  4) Yes as it shows on the console the fee amount calculated from balance
 *  
 *  5) most likely as you would likely only need to make a few test cases in the main Program.cs
 *   to test for bugs or for variables that shouldn't change in a certain  way
 *   
 *   6) functional requirements missing:
 *   - withdrawing should always be positive 
 *   - depositing should be positive
 *   - account should be validated for its opening balance and current balance
 *   
 *   7) non-functional requirements missing:
 *   - security of the account and its data
 *   - the correctness and how it handles the money and the calculations
 *
*/
using ENSE707_Week1_Lab_23206450;

BankAccount account = new BankAccount("Student User", 100);
account.Deposit(-50);
account.Withdraw(30);

Console.WriteLine($"Account holder: {account.AccountHolder}");
Console.WriteLine($"Current balance: {account.Balance}");
Console.WriteLine($"fee on $167: {account.CalculateTransactionFee(100)}");