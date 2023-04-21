using System.ComponentModel.Design;

Console.WriteLine("Welcome to the Indigenous Treaties Scavenger Hunt!");

Console.WriteLine("Go to the websit eunder the link trcm.ca  . On the home page, there should" +
    "be a large picture of a colorful stick. The picture of the stick repeats on the webpage in " +
    "a smaller form. Click on the smaller stick to see where it leads.");

string[] answers = { "visit", "treaty 5", "1908-1910", "adhesion", "hudson bay", "treaty 2", "lake manitoba", "keeseekowenin" };

string[] hints = { "HINT: the answer is another word for physically going to a place.", "HINT: The answer is a past tense of a word that means" +
        "going to a place.", "HINT: The answer starts with the letter 'v' and ends with the letter 't'.", "HINT: The answer, scrambled, is 'tivsi'.", "HINT: " +
        "The aswer, written backwards, is 'tisiv'." };

string[] hints1 = { "HINT: The answer is one of the treaties.", "HINT: The answer is one of the treaties, but it is not one of the first three " +
        "treaties.", "HINT: The answer is not the 8th, 9th, 10th, or 11th treaty.", "HINT: The answer, scrambled, is 't5eyart'.", "HINT: The answer, " +
        "written backwards, is '5 ytaert'." };

string[] hints2 = { "HINT: The answe is in the 1900s.", "HINT: The first number is before 1909 but after 1907.", "HINT: The first number is " +
        "before 1909 but after 1907, and the second number is 4 years before 1914.", "HINT: If you will solve 1918 - 10, you will get your" +
        "first number.", "HINT: If you solve 1918 - 10 you will get your first number. If you will do 1905 + 5 you will get your second " +
        "number.", "The answer, if written backwards, is 0191 - 8091." };

string[] hints3 = { "HINT: The answer is another word for 'adding on'.", "HINT: The answer is another word for 'attaching on'. ", "HINT: The answer, " +
        "when scrabled, is 'henoiad", "The answer, when written backwards, is 'noisehda'.", "HINT: The answer, with all the letter a's removed is " +
        "...dhesion." };

string[] hints4 = { "HINT: The answer is a body of water where a famous explorer visited.", "HINT: The answer is a body of water located north " +
        "of the province of Manitoba.", "HINT: The body of water is named after Henry Hudson.", "HINT: The body of water that is located north " +
        "of Manitoba is named after the famous explorer Henry Hudson.", "HINT: The answer is the last name of a person named Henry Hudson with the word " +
        "'bay' at the end."};

string[] hints5 = { "HINT: The answer is one of the treaties in Manitoba.", "HINT: The answer is one of the first treaties signed in Canada.", "The " +
        "answer is one of the first treaties signed in Canada and it is located in Manitoba.", "HINT: The answer is a treaty that was signed after " +
        "treaty 1.", "HINT: The answer, scrambled, is yte2rea.", "The answer, written backwards, is 2 ytaert."};

string[] hints6 = { "HINT: the answer is a body of water in Manitoba.", "HINT: The answer is a body of water in Manitoba that has the word of the " +
        "province in it.", "HINT: The answer is a body of water that has the word 'Manitoba' in it.", "HINT: The answer is a body of water that has " +
        "the word Manitoba in it and it is a lake.", "HINT: The answer's first word is 'lake' and the secind is the name of the province that it is in." };

string[] hints7 = { "The answer has 13 letters in it.", "HINT: The answer has 13 letters in it and starts with a 'k'. ", "HINT: The answer has 13 " +
        "letters in it, starts with a k and ends with an 'n'. ", "The answer, scramled, is 'eekonineweek'. ", "HINT: The answer, written backwards, is " +
        "'ninewokeeseek'." };

string inputOne = "";
string inputTwo = "";
string inputThree = "";
string str = "";
int wrong = 0; 
string hint;

Console.WriteLine("QUESTION: A picture of a fort will greet you. Under the image, there is a " +
   "link that says click here to -----. What is the missing word?");
do
{
    inputOne = Console.ReadLine();
    str = inputOne.ToLower();
    wrong = 0;

    if (str != answers[0])
    {
        Console.WriteLine("The answer is incorrect. Please try again. ");
        do
        {
            Console.WriteLine(" " + hints[wrong]);
            inputTwo = Console.ReadLine();
            str = inputTwo.ToLower();
            if(wrong == 4)
            {
                Console.WriteLine("The answer for question one is " + answers[0]);
                str = answers[0];
            }
            if(str != answers[0])
            {
                Console.WriteLine("The answer is incorrect. Please try again. ");
                wrong++;
            }
        } while (str != answers[0]);
    }
} while (str != answers[0]);

Console.WriteLine("QUESTION: Click on the link. A map will display upon your arrival, with boundries " +
    "outlined in yellow what is largest area that is outlined? Click to find the number of " +
    "the treaty. Add a number to your answer. Example of an answer: Treaty 6.");
do
{
    inputOne = Console.ReadLine();
    str = inputOne.ToLower();
    wrong = 0;
    if (str != answers[1])
    {
        Console.WriteLine("The answer is incorrect. Please try again. ");
        do
        {
            Console.WriteLine(" " + hints1[wrong]);
            inputTwo = Console.ReadLine();
            str = inputTwo.ToLower();
            if (wrong == 4)
            {
                Console.WriteLine("The answer for question two is " + answers[1]);
                str = answers[1];
            }
            if (str != answers[1])
            {
                Console.WriteLine("The answer is incorrect. Please try again. ");
                wrong++;
            }
        } while (str != answers[1]);
    }
} while (str != answers[1]);

Console.WriteLine("QUESTION: Scroll down the website. Using the treaty from the previosu clue, find" +
    "what year it was signed. There should also be a year of adhesion. What are the years of the " +
    "adhesion? Include the dash (-) in your answer. Example for an answer: 1790-1795  .");
do
{
    inputOne = Console.ReadLine();
    str = inputOne.ToLower();
    wrong = 0;
    if (str != answers[2])
    {
        Console.WriteLine("The answer is incorrect. Please try again. ");
        do
        {
            Console.WriteLine(" " + hints2[wrong]);
            inputTwo = Console.ReadLine();
            str = inputTwo.ToLower();
            if (wrong == 4)
            {
                Console.WriteLine("ANSWER: " + answers[1]);
                str = answers[2];
            }
            if (str != answers[2])
            {
                Console.WriteLine("The answer is incorrect. Please try again. ");
                wrong++;
            }
        } while (str != answers[2]);
    }
} while (str != answers[2]);

Console.WriteLine("QUESTION: Find the map of the Treaty from the previous clues by scrolling " +
    "through the webpage. What is larger; the adhesion or the original treaty?.");
do
{
    inputOne = Console.ReadLine();
    str = inputOne.ToLower();
    wrong = 0;
    if (str != answers[3])
    {
        Console.WriteLine("The answer is incorrect. Please try again. ");
        do
        {
            Console.WriteLine(" " + hints3[wrong]);
            inputTwo = Console.ReadLine();
            str = inputTwo.ToLower();
            if (wrong == 4)
            {
                Console.WriteLine("ANSWER: " + answers[3]);
                str = answers[3];
            }
            if (str != answers[3])
            {
                Console.WriteLine("The answer is incorrect. Please try again. ");
                wrong++;
            }
        } while (str != answers[3]);

    }
} while (str != answers[3]);

Console.WriteLine("QUESTION: What large body of water does the treaty 5 adhesion touch?");

do
{
    inputOne = Console.ReadLine();
    str = inputOne.ToLower();
    wrong = 0;
    if (str != answers[4])
    {
        Console.WriteLine("The answer is incorrect. Please try again. ");
        do
        {
            Console.WriteLine(" " + hints4[wrong]);
            inputTwo = Console.ReadLine();
            str = inputTwo.ToLower();
            if (wrong == 4)
            {
                Console.WriteLine("ANSWER: " + answers[4]);
                str = answers[4];
            }
            if (str != answers[4])
            {
                Console.WriteLine("The answer is incorrect. Please try again. ");
                wrong++;
            }
        } while (str != answers[4]);
    }
} while (str != answers[4]);

Console.WriteLine("QUESTION: Find the timeline again. Which is the second treaty that was signed in 1871?" +
    "Add a number to your answer. Example: Treaty 6.");

do
{
    inputOne = Console.ReadLine();
    str = inputOne.ToLower();
    wrong = 0;
    if (str != answers[5])
    {
        Console.WriteLine("The answer is incorrect. Please try again. ");
        do
        {
            Console.WriteLine(" " + hints5[wrong]);
            inputTwo = Console.ReadLine();
            str = inputTwo.ToLower();
            if (wrong == 4)
            {
                Console.WriteLine("ANSWER: " + answers[5]);
                str = answers[5];
            }
            if (str != answers[5])
            {
                Console.WriteLine("The answer is incorrect. Please try again. ");
                wrong++;
            }
        } while (str != answers[5]);
    }
} while (str != answers[5]);

Console.WriteLine("QUESTION: By using the treaty from before, scroll through the website find the " +
    "map of a map under the category of that treaty. There is a map with two t" +
    "hings labeled. What is the thing in blue with a white outline (or darker than " +
    "the other thing labelled? What does it say?");

do
{
    inputOne = Console.ReadLine();
    str = inputOne.ToLower();
    wrong = 0;
    if (str != answers[6])
    {
        Console.WriteLine("The answer is incorrect. Please try again. ");
        do
        {
            Console.WriteLine(" " + hints6[wrong]);
            inputTwo = Console.ReadLine();
            str = inputTwo.ToLower();
            if (wrong == 4)
            {
                Console.WriteLine("ANSWER: " + answers[6]);
                str = answers[6];
            }
            if (str != answers[6])
            {
                Console.WriteLine("The answer is incorrect. Please try again. ");
                wrong++;
            }
        } while (str != answers[6]);
    }
} while (str != answers[6]);
Console.WriteLine("QUESTION: Under the image, there should be a link. By clicking on the " +
    "link, you will be welcomed with the details of each treaty. Using the treaty " +
    "from the previous clue, find it. What is the first First Nation listed that " +
    "signed the treaty?");
do
{
    inputOne = Console.ReadLine();
    str = inputOne.ToLower();
    if (str != answers[7])
    {
        Console.WriteLine("The answer is incorrect. Please try again. ");
        do
        {
            Console.WriteLine(" " + hints7[wrong]);
            inputTwo = Console.ReadLine();
            str = inputTwo.ToLower();
            if (wrong == 4)
            {
                Console.WriteLine("ANSWER: " + answers[7]);
                str = answers[7];
            }
            if (str != answers[7])
            {
                Console.WriteLine("The answer is incorrect. Please try again. ");
                wrong++;
            }
        } while (str != answers[7]);
    }
} while (str != answers[7]);
Console.WriteLine("Yay! You finished the Scavenger Hunt! Congradulations! We hope you have a " +
    "great rest of your day!");