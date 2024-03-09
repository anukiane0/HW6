// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//gets array size from console, n element will be saved in array
// we should have to array one for evens one for odds


//int n = Convert.ToInt32(Console.ReadLine());

//int[] arraycons = new int[n];

//for(int i=0; i<n; i++)
//{
//    //var array = Console.WriteLine($"{i+1}");
//    var array = i + 1;
//}

//for (int i=0; i<n; i++)
//{
//    if (i % 2 == 0)
//    {
//        var arrayeven = 
//    }
//}



// contacts app where we can delete, update and create contact

// popping up question and asking which activity we want to execute
// creating dictionary for contacts
// if delete - finds contact and removes from contact dict, if wrong contact "number is wrong"
// if update - finds contact and replaces key and value, if there is not such contact - "contact not found"
// if adding - adds new dict value in dictionary

Console.WriteLine("Choose Number:");
Console.WriteLine("1. Add Contact");
Console.WriteLine("2. Delete Contact");
Console.WriteLine("3. Update Contact");

//int answer = Convert.ToInt32(Console.ReadLine());

Dictionary<string, int> contacts = new Dictionary<string, int>();

int answer;
if (int.TryParse(Console.ReadLine(), out answer))

    if (answer == 1)
    {
        Console.WriteLine("Add Contact");

        Console.WriteLine("Write name of new conatct:");
        var key1 = Console.ReadLine();

        Console.WriteLine("Write number of new conatct:");
        int value1 = Convert.ToInt32(Console.ReadLine());

        contacts.Add(key1, value1);

        Console.WriteLine("Added successfully");
        foreach (var contact in contacts)
        {
            Console.WriteLine($"Name: {contact.Key} Number: {contact.Value}");
        }

    }
    else
    {
        if(answer == 2)
        {
            Console.WriteLine("Delete Contact");

            Console.WriteLine("Write name of contact you want to delete:");
            var key1 = Console.ReadLine();
            contacts.Remove(key1);

            Console.WriteLine("Removed successfully");

            foreach (var contact in contacts)
            {
                Console.WriteLine($"Name: {contact.Key} Number: {contact.Value}");
            }
        }
        else
        {
            Console.WriteLine("Update Contact");
            Console.WriteLine("Write name of contact you want to update:");

            var key1 = Console.ReadLine();

            if (contacts.ContainsKey(key1))
            {
                Console.WriteLine("Write the new phone number for the contact:");

                var newValue = Convert.ToInt32(Console.ReadLine());

                contacts[key1] = newValue;

                Console.WriteLine("Contact updated successfully");

                foreach (var contact in contacts)
                {
                    Console.WriteLine($"Name: {contact.Key} Number: {contact.Value}");
                }
            }
            else
            {
                Console.WriteLine($"Contact doesn't exist.");
            }

        }
    }
else
{
    Console.WriteLine("Invalid Input");
}