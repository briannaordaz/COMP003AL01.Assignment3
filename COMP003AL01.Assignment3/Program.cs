// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Academic & Personal Readiness Evaluator ===");
       
        
        // Behavior 1
        int currentYear;
        currentYear = DateTime.Now.Year;
        Console.WriteLine("Current year: " + currentYear);
        
        Console.WriteLine("Enter your birth year: ");
        int birthYear = Convert.ToInt32(Console.ReadLine());

        int currentAge;
        currentAge = DateTime.Now.Year - birthYear;
        
        Console.WriteLine("Calculated Age: " + currentAge);
        
        string category;
        
        if (currentAge >= 18)
        {
            category = "Adult";
        } 
        else if (currentAge <= 17 && currentAge >= 13)
        {
            category = "Teen (Must be 18 or older to Proceed)";
        }
        else
        {
            category = "Child (Too Young, Cannot Proceed)";
        }

        
        Console.WriteLine("Readiness Category: " + category );
       
        Console.WriteLine("Do you have a valid ID? (Yes/No): ");
        string valid = Console.ReadLine();
        bool validID = valid.Trim().ToLower() == "yes" ? true : false;
        
        Console.WriteLine("Have you completed orientation (Yes/No): ");
        string orientationCompleted = Console.ReadLine();
        bool orientation = orientationCompleted.Trim().ToLower() == "yes" ? true : false;
        
        //Behavior 2:

        if (currentAge >= 18)
        {

            if (validID && orientation)
            {
                Console.WriteLine("Ready");

               
            }
            else if (validID || orientation)
            {
                Console.WriteLine("Conditionally Ready ");
            }
            else
            {
                Console.WriteLine("Not Ready ");
            }
            
        }
        


    }







}



/*
 EXAMPLE:
 
 *=== Academic & Personal Readiness Evaluator ===
   
   Current Year: 2026
   Enter your birth year: 2005
   
   Calculated Age: 21
   Readiness Category: Adult
   
   Do you have a valid ID? (yes/no): yes
   Have you completed orientation? (yes/no): no
   
   Readiness Status: Conditionally Ready
   
   Select a guidance option:
   1 - Academic Planning
   2 - Personal Planning
   3 - Career Planning
   Enter choice: 1
   
   Guidance:
   Meet with an academic advisor to plan your next term.
 *
 * 
 */
 




 /*
  *Behavior 1 — Time-Based Readiness Status
  * 
    Goal: Establish a readiness context using system-provided time information.
    
    Requirements
    * Use one value from DateTime.Now (year or month).
    
    * Prompt the user for one related input (such as birth year or similar).
    
    * Produce a calculated value that will be used later in decision-making.
    
    * Assign exactly one readiness category (at least three possible categories).
    
    Constraints:
    
    * Categories must not overlap.
    
    * Only one category may be displayed.
    
    * All possible inputs must fall into a category.
  */
  




  /*
   Behavior 2 — Multi-Rule Readiness Evaluation
     Goal: Determine whether the user is Ready, Conditionally Ready, or Not Ready.
     Requirements
     
     * The readiness decision must depend on:
        * The result from Behavior 1
    
        * At least two additional yes/no inputs
     
     * At least:
     
        * One rule must be mandatory
     
        * One rule must be optional
     
     * The final outcome must be one of three statuses:
     
        * Ready
     
        * Conditionally Ready
     
        * Not Ready
     
     The logic must include:
     
     * Logical operators (&&, ||)
     
     * At least one dependent decision (one condition evaluated only after another passes)
   * 
   */
  




  /*
   
   *Behavior 3 — Guidance Selection
     Goal: Provide guidance based on readiness status.
     
     Requirements
     * Display a fixed list of guidance options (minimum of three).
     
     * Prompt the user to select an option using a number or code.
     
     * Display a guidance message that corresponds to the selection.
     
     * Include a response for invalid selections.
     
     This behavior must be implemented using a structure appropriate for exact-match choices.
   * 
  */
  