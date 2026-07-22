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
 *   Activity 4:
 *   - Writing coding standards for money calculations: QA. 
 *   create preventive measure to ensure there would be no calculation mistakes
 *   - Running unit tests for withdrawal behaviour: QC. 
 *   verifies if a specific function works as intended and if it is working correctly
 *   - Reviewing requirements for ambiguity: QA.
 *   improves the quality of the requirements and makes sure that there are no implementations misinterpreted
 *   - Testing negative deposit unit: QC.
 *   makes sure that the deposit function is working properly for edge cases and makes sure that there are no faults in input handling
 *   - Analysing repeated transaction defects: QA.
 *   Root cause analysis finds the source of the defect and stops it from happening again.
 *   - reporting a failed test case: QC.
 *   records a defect found that is to be fixed
 *   - Creating a checklist for financial validation rules: QA.
 *   makes sure that rules are being followed and that it is high quality
 *   - Retesting after fixing withdrawal logic: QC.
 *   makes sure that the changes fixed the issue and the code is working as intended
 *   
 * Activity 9:
 * 1) The Stakeholders are the people who would be using the banking app to make withdrawals and deposits and the people who would be managing the bank accounts. The developers are the people who would be creating the banking app and making sure it works as intended. 
 * The testers are the people who would be testing the banking app to make sure it works as intended and that there are no bugs or issues with the app.
 * 2) Quality to the stakeholders mean that the app should respond quickly (under 2 seconds), must be very secure so that no data is leaked, easy to maintain
 * so that the developers can fix issues that could appear at anytime and it should be intuitive and easy to use for the users.
 * 3) defects through testing was detected with withdrawing negative amounts, depositing negative amounts and opening an account with a negative balance.
 * 4) deposit and withdrawing 0 and below could have been prevented through QA activities
 * 5) Copilot helped by helping me understand where issues occur and where tests fail so that i could fix them
 * 6) a suggestion for the throwexceptions in the BankAccount class where it wants to use ArgumentOutOfRange Exception instead of Argument Exception which would be
 * unnecessary.
*/
using ENSE707_Week1_Lab_23206450;

BankAccount account = new BankAccount("Student User", 100);
account.Deposit(50);
account.Withdraw(30);

Console.WriteLine($"Account holder: {account.AccountHolder}");
Console.WriteLine($"Current balance: {account.Balance}");
Console.WriteLine($"fee on $167: {account.CalculateTransactionFee(100)}");