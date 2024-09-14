//start main

string enjoymentLevel= GetEnjoymentLevel();
string stadium= GetStadiumRecommendations(enjoymentLevel);
string game= GetGameRecommendations(stadium);
DisplayStadiumDetails (enjoymentLevel, stadium, game);

//end main

static string GetEnjoymentLevel(){
    Console.Clear();
    System.Console.WriteLine("Enter your enjoyment level from either (boring,average,fun,epic)");
    return (Console.ReadLine());
}

static string GetStadiumRecommendations(string enjoymentLevel){
    if (enjoymentLevel.ToLower() == "boring"){
        return "Neyland Stadium";
     }
     else if (enjoymentLevel.ToLower() == "average"){
        return "Jordan- Hare Stadium";
     }
     else if (enjoymentLevel.ToLower() == "fun"){
        return "Tiger Stadium";
     }
     else if(enjoymentLevel.ToLower() =="epic"){
        return "Saban Field at Bryant Denny Stadium";
     }
     else 
     return "unknown enjoyment level, please try again!!";
}

static string GetGameRecommendations(string stadium){
    if (stadium.ToLower() == "neyland stadium"){
        return "vs. Kent State";
     }
     else if (stadium.ToLower() == "jordan- hare stadium"){
        return "vs. Kentucky";
     }
     else if (stadium.ToLower() == "tiger stadium"){
        return "vs. Alabama";
     }
     else if(stadium.ToLower() =="saban field at bryant denny stadium"){
        return "vs. Auburn";
     }
     else 
     return "unknown stadium, please try again!!";

}
    
static void DisplayStadiumDetails(string enjoymentLevel, string stadium, string game){
    System.Console.WriteLine($"You entered {enjoymentLevel}. Recommended stadium: {stadium}. Recommended game: {game}");
}

