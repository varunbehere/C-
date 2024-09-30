Console.WriteLine("Check if you can go to clob or not ???");


Console.WriteLine("How old are you ??");
int age = int.Parse(Console.ReadLine());

if (age > 18 ){
    Console.WriteLine("You can enter club! Go Party!!");
}

else if( age >= 13){
    Console.WriteLine ("Are you with your parents ? (y/n)");
    string withParents = Console.ReadLine().ToLower();

    if (withParents == "y"){
        Console.WriteLine("Go party with ur parents!");
    }
    else{
        Console.WriteLine("Sorry I cant allow you!, Please come with ur parents!");
    }
} 
else{
    Console.WriteLine("Sorry I cant allow you!, Age criteria doesnt fulfill");
}
