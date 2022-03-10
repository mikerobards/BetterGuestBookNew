using GuestBookNewLibrary.Models;

// Capture the info about each guest (assumption is at least one guest and unknown maximum)
// info to capture: First Name, Last Name, Message to host
// once done, loop through each guest and print their info

List<GuestModel> guests = new List<GuestModel>();

GetGuestInfomation(guests);

PrintGuestInformation(guests);

static void PrintGuestInformation(List<GuestModel> guests)
{
    foreach (GuestModel guest in guests)
    {
        Console.WriteLine(guest.GuestInfo);
    }
}

static void GetGuestInfomation(List<GuestModel> guests)
{
    string moreGuestsComing = "";

    do
    {
        GuestModel guest = new GuestModel(guests);

        guest.FirstName = GetInfoFromConsole("What is your first name: ");
        guest.LastName = GetInfoFromConsole("What is your last name: ");
        guest.MessageToHost = GetInfoFromConsole("What message would you like to tell your host: ");
        moreGuestsComing = GetInfoFromConsole("Are more guests coming (yes/no): ");

        guests.Add(guest);

        Console.Clear();
    } while (moreGuestsComing.ToLower() == "yes");
}

static string GetInfoFromConsole(string message)
{
    string output = "";

    Console.Write(message);
    output = Console.ReadLine();

    return output;
}
