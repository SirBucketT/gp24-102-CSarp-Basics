// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please pass me a seed (integer).");

int userInput = int.Parse(Console.ReadLine());

Random randNoSeed = new Random();
Random seed = new Random(userInput);
    
Console.WriteLine(seed.Next()); // Writes out an random number on the console based on the seed given earlier

Console.WriteLine("Three integers between 0 and 5:");
for (int loop = 0 ; loop < 3; loop++)
    Console.WriteLine(randNoSeed.Next(0, 5)); // writes a output between 0 and 5, excluding 5


Console.WriteLine("Three numbers between 0.0 and 0.5");
for (int loop2 = 0; loop2 < 3; loop2++)
{
    Console.WriteLine(randNoSeed.NextDouble() * 5d); // Writes a output between 0 and 0.4999
    
}

Console.WriteLine("Three numbers between 0.2 and 0.7:");
for (int loop3 = 0; loop3 < 3; loop3++)
{
    Console.WriteLine(randNoSeed.NextDouble() * 0.5 + 0.2); // writes a output between 0.2 and 0.7
}



Console.WriteLine("Give me a crit chance between 0,0 (0%) and 1,0 (100%)");
double critChance = double.Parse(Console.ReadLine());

for (int loop4 = 0; loop4 < 5; loop4++) // creates a random loop that runs 5 times 
{
    double roll = seed.NextDouble(); // creates a new random double named roll that equals to the original seed
    if (roll < critChance) 
    {
        Console.WriteLine("Crit");
    }
    else
    {
        Console.WriteLine("No Crit");
    }
}



Console.WriteLine("press f and enter to wipe console and proceed to next step");
string wiper = Console.ReadLine();
if (wiper == "f" || wiper == "F")
{
    Console.Clear();
}




//part 2 of the assignment
Console.WriteLine("P12_1Random_Coordinates");
Console.WriteLine("Develop a program that generates random X and Y coordinates for an enemy in a 2D game world with 100x100 coordinates. Display these coordinates to the user.");

//Uses random with name coordinates Randomizer
Random coordinatesRandomizer = new Random();

//creates two whole numbers with the int names of x and y and randomizing their location.
int xCordinate = coordinatesRandomizer.Next(0, 101);
int yCordinate = coordinatesRandomizer.Next(0, 101);


Console.WriteLine($"Cordinates of \n X={xCordinate} \n Y={yCordinate}");




Console.WriteLine("press f and enter to wipe console and proceed to next step");
string wiper2 = Console.ReadLine();
if (wiper2 == "f" || wiper2 == "F")
{
    Console.Clear();
}




//part 3 of the assignment
Console.WriteLine("P12_2Random_Password");
Console.WriteLine("Design a program that generates a random password with 6 characters, digits or symbols.");

//create a random generator named password randomizer and creates strigns for digits, characters and symbols
Random passwordRandomizer = new Random();
string digits = "1234567890";
string symbols = "!@#$%^&*()_+-=[]{}|;':\",./<>?";
string characters = "qwertyuiopåäölkjhgfdsazxcvbnmQWERTYUIOPÅÄÖLKJHGFDSAZXCVBNM";

string combiner = digits + characters + symbols; //creates a string that acts as a index for password generator to use
string password = "";

//loop that loops 6 times to generate password
for (int passwordGeneratorLoop = 0; passwordGeneratorLoop < 6; passwordGeneratorLoop++)
{
    int index = passwordRandomizer.Next(combiner.Length);
    password += combiner[index];
}
Console.WriteLine($"Password: {password}");




Console.WriteLine("press f and enter to wipe console and proceed to next step");
string wiper3 = Console.ReadLine();
if (wiper3 == "f" || wiper3 == "F")
{
    Console.Clear();
}



//Part 4 of the assignment
Console.WriteLine("P12_3Random_Item");
Console.WriteLine("Write a program that simulates item drops in a game. Define five different items, and randomly select an item for the player to acquire.");

Random itemLootBox = new Random();

//list of items lootdrop/lootbox will generate though random
string superRareSword = "Super Rare Sword";
string wankySword = "Wanky Sword";
string excaliburSword = "Excalibur Sword";
string rustySword = "Rusty Sword";
string cloakOfInvisibility = "Cloak of Invisibility";
string plateArmor = "Plate Armor";
string chestPlate = "Chest Plate";
string hat = "Hat";
string boot = "Boot";
string pants = "Pants";


int itemGenerator = itemLootBox.Next(0, 101);
int itemGenerator2 = itemLootBox.Next(0, 101);
int itemGenerator3 = itemLootBox.Next(0, 101);
string itemDropped = "";
string itemDropped2 = "";
string itemDropped3 = "";

Console.WriteLine("Type 'fun' to see what loot you get");
string funboxes = Console.ReadLine();
    if (funboxes == "fun" || funboxes == "FUN" || funboxes == "fUn" || funboxes == "Fun")
    {
    


    //item 1 drop
        if (itemGenerator  >= 0){
            itemDropped = pants;
        }else if (itemGenerator >= 5)
        {
            itemDropped = superRareSword;
        }else if (itemGenerator >= 6){
            itemDropped = rustySword;
        } else if (itemGenerator >= 20){ 
            itemDropped = cloakOfInvisibility;
        } else if (itemGenerator >= 30){ 
            itemDropped = wankySword;
        } else if (itemGenerator >= 40){ 
            itemDropped = excaliburSword;
        } else if (itemGenerator >= 42){ 
            itemDropped = hat;
        } else if (itemGenerator >= 50){ 
            itemDropped = plateArmor;
        } else if (itemGenerator >= 70){ 
            itemDropped = boot;
        } else{ 
            itemDropped = chestPlate;
        }

            //item 2 drop
            if (itemGenerator2  >= 0){
                itemDropped2 = pants;
            } else if (itemGenerator2 >= 5){
                itemDropped2 = superRareSword;
            } else if (itemGenerator2 >= 6){
                itemDropped2 = rustySword;
            } else if (itemGenerator2 >= 20){ 
                itemDropped2 = cloakOfInvisibility;
            } else if (itemGenerator2 >= 30){ 
                itemDropped2 = wankySword;
            } else if (itemGenerator2 >= 40){ 
                itemDropped2 = excaliburSword;
            } else if (itemGenerator2 >= 42){ 
                itemDropped2 = hat;
            } else if (itemGenerator2 >= 50){ 
                itemDropped2 = plateArmor;
            } else if (itemGenerator2 >= 70){ 
                itemDropped2 = boot;
            } else{ 
                itemDropped2 = chestPlate;
            }

        //iten 3 drop
        if (itemGenerator3  >= 0){
            itemDropped3 = pants;
        } else if (itemGenerator >= 5){ 
            itemDropped3 = superRareSword;
        } else if (itemGenerator3 >= 6){
            itemDropped3 = rustySword;
        } else if (itemGenerator3 >= 20){ 
            itemDropped3 = cloakOfInvisibility;
        } else if (itemGenerator3 >= 30){ 
            itemDropped3 = wankySword;
        } else if (itemGenerator3 >= 40){ 
            itemDropped3 = excaliburSword;
        } else if (itemGenerator3 >= 42){ 
            itemDropped3 = hat;
        } else if (itemGenerator3 >= 50){ 
            itemDropped3 = plateArmor;
        } else if (itemGenerator3 >= 70){ 
            itemDropped3 = boot;
        } else{ 
            itemDropped3 = chestPlate;
        }

    Console.WriteLine($"Item drops and added to inventory {itemDropped}, {itemDropped2} and {itemDropped3}");
    Console.WriteLine("Type 'Equip' to equip the items or 'Drop' to remove the items from the inventory.");
    string equippedItem = Console.ReadLine();

    if (equippedItem == "Equip" ||  equippedItem == "equip")
    {
        Console.WriteLine($"Charecter equips" + 
                          $"\n {itemDropped}" + 
                          $"\n {itemDropped2} " + 
                          $"\n {itemDropped3}");
    
    }
    else
    {
        Console.WriteLine($"Character dropped" + 
                          $"\n {itemDropped}" + 
                          $"\n {itemDropped2} " + 
                          $"\n {itemDropped3}");
    }
    }