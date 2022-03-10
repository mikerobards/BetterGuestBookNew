using GuestBookNewLibrary.Models;

// Capture the info about each guest (assumption is at least one guest and unknown maximum)
// info to capture: First Name, Last Name, Message to host
// once done, loop through each guest and print their info


List<GuestModel> guests = new List<GuestModel>();
string moreGuestsComing = "";

do
{
    GuestModel guest = new GuestModel();
    Console.Write("What is your first name: ");
    guest.FirstName = Console.ReadLine();

} while (moreGuestsComing.ToLower() == "yes");


