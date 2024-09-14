namespace Adventure_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this prints the opening scene
            Console.ForegroundColor = ConsoleColor.Blue; // that is really cool, I can change the color
            Console.WriteLine("All inputs take the form of a single, lowercased word. For example, instead of open door, you say door to investigate the door.");
            Console.WriteLine();
            //Console.ResetColor(); theoretically I could use this to brute force setting different colors for the protagonist, npcs, and descriptions
            //there is probably a method or something to make it simpler
            Console.WriteLine("You are Lovean Martak, the son of an Earl from the coastal kingdom of Gauss. You remember the night prior you had been in an inn in the outskirts of the city.");
            Console.WriteLine("You wake in a dark and damp room with stone floors and walls and nothing but your clothes. As you try to orient yourself you see a heavy wooden door on the west wall, and a small pile of hay on the south wall.");
            Console.WriteLine("Would you like to look at the pile of hay or the door?");
            
            Console.Write("> "); //prompt the user for a choice
            string haydoorchoice = Console.ReadLine();
            //ask the player what they want to do
            if (haydoorchoice == "door")
            {
                Console.WriteLine("You go to check the door.");
                Console.WriteLine("As you touch it you feel it is firmly in place. Locked, and far too heavy for you to budge open.");
                Console.WriteLine("You do notice however, a small slat near the bottom to slide things through, presumably for prisoner meals. Wait long enough and you might get something");
                Console.WriteLine("Would you like to knock on the door or wait?");
                Console.WriteLine("> ");//in the future see if I can do this without just repeating it every time
                string knockwait = Console.ReadLine(); //do they want to wait or use the door
                if (knockwait == "knock")
                {
                    Console.WriteLine("You bang on the door. Not much sound gets out, you figure you have to be especially loud to be heard.");
                    Console.WriteLine("You bang on the door again slightly louder, your hand feels a bit sore. Still no response, but you hear distant, plodding footsteps down the hall. A guard, you'd assume.");
                    Console.WriteLine("You continue to bang vigorously on the door for a minute straight. Your dominant hand is nearly fully numb as the footsteps finally near your door and stop.");
                    Console.WriteLine("You hear a grouchy voice grumbling to itself. The guard opens the door and is clearly angry.");
                    Console.WriteLine("\"Oi what's this noise all about? What makes you think you can cause a racket criminal scum?\"");
                    Console.WriteLine("Would you like to explain yourself, or try and fight him?");
                    string explainfight = Console.ReadLine(); //explain or fight
                    if (explainfight == "explain") //choosing to explain yourself
                    {
                        Console.WriteLine("\"Wait! Please, I am a noble! My father is the Earl of Hull! Surely this is a mistake! There must be someone I can speak to clear this up.\"");
                        Console.WriteLine("The guard does not seem swayed. You start to panic and see if you have anything in your pockets to prove your parentage until you feel it. Your belt.");
                        Console.WriteLine("Your belt buckle was made in the shape of the symbol of the house of Hull, all members of the house wore that symbol on their person");
                        Console.WriteLine("You remove your belt and hand it over to him to inspect the buckle. The guard studies it, and reluctantly hands it back");
                        Console.WriteLine("\"Don't think I believe your story for a moment lad. Though, it's odd you'd have that, I'm taking you to speak with the warden, he'll know what to do with you.\"");
                        Console.WriteLine("Ending 1:You went to explain your case with the warden. What comes next? Find out in the next installment!");
                    }
                    else if (explainfight == "fight") //choosing to fight him
                    {
                        Console.WriteLine("Due to being in good shape you opt to try and fight him. You get one punch in against the stout man, and a kick against his shin.");
                        Console.WriteLine("Unfortunately, he is both armored and armed, while you are unarmed and injured from knocking so hard. You don't get another hit in before he bashes your cranium with his flanged mace.");
                        Console.WriteLine("You died before you hit the ground. Please restart and try another path.");
                        //in the future I want to have something that allows you to reset the game all the way to the beginning when you die, also there has to be some kind of like method framework so I don't have to nest ifs
                    }
                }
                else if (knockwait == "wait") //waiting by the door
                {
                    Console.WriteLine("You wait. After a few minutes you get bored, and do some stretches to keep yourself active. After a while though you choose to sit in silence and reflect.");
                    Console.WriteLine("After an hour of waiting by the door some food is passed through... Unfortunately it is spoiled, though given the bizarre color and unrecognizable shape, you doubt it'd be appetizing even if fresh.");
                    Console.WriteLine("You considered laying on the pile of hay to sleep and conserve your energy until you spot a piece of metal poking out from beneath the revolting sludge.");
                    Console.WriteLine("You cover your nose with your hand and look away as you sift through it. If it looked disgusting, the touch alone is enough to make lesser men retch. After a minute you pull out an iron key, and wipe it and your hand off");
                    Console.WriteLine("You try the key on the door and to your astonishment it works. This only raises more questions in your mind. Why are you here? Who would be helping you? You put these questions on hold and walk out the door.");
                    Console.WriteLine("Ending 2: You managed to escape your cell using a key from an unknown benefactor. What comes next? Find out in the next installment!");
                }

            }
            else if (haydoorchoice == "hay") //search the hay pile
            {
                Console.WriteLine("You go to the hay pile. It is messily strewn acoss the floor. Given the lack of any bedroll or cot, you presume this odious arrangement is where you are meant to sleep. Thankfully you don't feel tired yet.");
                Console.WriteLine("You swear you see something under the hay pile, and curiosoity overtaking you, you sweep the hay to the side to investigae. Underneath you spot a large iron grate. Past the grate is a tunnel straight down.");
                Console.WriteLine("You cannot tell how far down exactly, the holy is entirely pitch black. You could try and find some rope to tie to the grate, or you could try jumping straight down.");
                Console.WriteLine("Would you like to search for rope, or try your chances with jumping down?");
            }
        }
    }
}
