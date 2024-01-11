namespace EightToTen.Services.RestaurantPicker;

public class RestaurantPickerService : IRestaurantPickerService
{
    Random restaurantRandom = new Random();

    string[] americanRestaurantCategory = {"Public House Downtown", "Buddha Belly Burger", "The Rind", "Cafeteria 15L", "Prelude Kitchen & Bar", "Iron House Tavern", "Hook & Ladder Manufacturing", "Seoul St. Midtown", "Tipsy Putt", "Yard House"};
    string[] mexicanRestaurantCategory  = {"Tres Hermanas", "Tequila Museo Mayahuel", "Polanco Cantina", "Thirtyfour Mexican Cantina", "OMG Cocina", "Zocalo - Midtown", "El Fuego Express", "Azul Mexican Food and Tequila Bar", "La Cosecha", "Chita's"};
    string[] italianRestaurantCategory  = {"Olive Garden", "Adamo's", "Paesanos", "Il Fornaio", "Taste of Tuscany", "Sampino's Kitchen at Joe Marty's", "MidiCi The Neopolitan Pizza Company", "OBO' Italian Table & Bar", "Moxie", "a Trattoria Bohemia"};
    string[] pizzaRestaurantCategory = {"Skipolini's Pizza", "Round Table Pizza", "Mountain Mike's Pizza", "MOD Pizza", "Pizza Guys", "Aladino's Pizza", "Domino's Pizza", "Pizza Hut", "Pizza Twist", "Leonardi's Pizza"};
    string[] burgerRestaurantCategory = {"Hazel's Drive In", "The Habit Burger Grill", "In-N-Out Burger", "HD Burger", "Burger King", "Heart Attack Grill", "Ben's Burger", "Five Guys", "McDonalds", "Burger Lounge"};
    string[] pastaRestaurantCategory = {"Pasta Pelican", "Montecatini", "Pasta Bella", "Olive Garden", "Mangia Bene", "Roma Antica", "Belotti Bottega", "Pasta Supply Co", "Melo's Italian Table", "Pasta Panino"};
    string[] lowRankRestaurantCategory = {"Colony Cafe", "The Copper Barrel", "Famous Original Ray’s Pizza", "Pho 32 & Shabu", "Stir Cafe", "Wolfgang Puck Express", "Steamers Landing", "Jamaica Jamaica Island Grill", "On The Border", "Ruby Tuesday"};
    string[] medRankRestaurantCategory = {"Stubborn Seed", "Sushi Yasaka", "Alinea", "Ben’s Chili Bowl", "MIDA", "Odd Duck", "Pieterzyk Pierogi", "Fore Street Restaurant", "Apteka", "Bazaar Meat"};
    string[] highRankRestaurantCategory = {"Eleven Madison Park", "Karv Kitchen", "Zaab Zaab", "Higgins", "Vera’s Backyard BBQ", "VAGA", "Gautreau’s Restaurant", "Mister Jiu’s", "Lucille’s", "Demi"};

    public string CategoryOrigin(string numberChoice)
    {
        int numberChose = 0;
        bool dataVerify = int.TryParse(numberChoice, out numberChose);

        if (dataVerify == true)
        {
            switch (numberChose) 
            {
                case 1:
                case 2:
                case 3:
                    int randomNumber = restaurantRandom.Next(0, 9);

                    switch (numberChose)
                    {
                        case 1:
                            return $"Restaurant chosen (from American Restaurant Category): {americanRestaurantCategory[randomNumber]}";
                        case 2:
                            return $"Restaurant chosen (from Mexican Restaurant Category): {mexicanRestaurantCategory[randomNumber]}";
                        case 3:
                            return $"Restaurant chosen (from Italian Restaurant Category): {italianRestaurantCategory[randomNumber]}";
                    }
                break;
            }

            return "There are no other categories. Please pick either of the three listed.";
        }
        else
        {   
            return "That is not an option. Please try again.";
        }
    }
    public string CategoryFood(string numberChoice)
    {
        int numberChose = 0;
        bool dataVerify = int.TryParse(numberChoice, out numberChose);

        if (dataVerify == true)
        {
            switch (numberChose) 
            {
                case 1:
                case 2:
                case 3:
                    int randomNumber = restaurantRandom.Next(0, 9);

                    switch (numberChose)
                    {
                        case 1:
                            return $"Restaurant chosen (from Pizza Restaurant Category): {pizzaRestaurantCategory[randomNumber]}";
                        case 2:
                            return $"Restaurant chosen (from Burger Restaurant Category): {burgerRestaurantCategory[randomNumber]}";
                        case 3:
                            return $"Restaurant chosen (from Pasta Restaurant Category): {pastaRestaurantCategory[randomNumber]}";
                    }
                break;
            }

            return "There are no other categories. Please pick either of the three listed.";
        }
        else
        {   
            return "That is not an option. Please try again.";
        }
    }
    public string CategoryRating(string numberChoice)
    {
        int numberChose = 0;
        bool dataVerify = int.TryParse(numberChoice, out numberChose);

        if (dataVerify == true)
        {
            switch (numberChose) 
            {
                case 1:
                case 2:
                case 3:
                    int randomNumber = restaurantRandom.Next(0, 9);

                    switch (numberChose)
                    {
                        case 1:
                            return $"Restaurant chosen (from Low Rated Restaurant Category): {lowRankRestaurantCategory[randomNumber]}";
                        case 2:
                            return $"Restaurant chosen (from Medium Rated Restaurant Category): {medRankRestaurantCategory[randomNumber]}";
                        case 3:
                            return $"Restaurant chosen (from High Rated Restaurant Category): {highRankRestaurantCategory[randomNumber]}";
                    }
                break;
            }

            return "There are no other categories. Please pick either of the three listed.";
        }
        else
        {   
            return "That is not an option. Please try again.";
        }
    }
}
