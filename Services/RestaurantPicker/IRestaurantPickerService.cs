namespace EightToTen.Services.RestaurantPicker;

public interface IRestaurantPickerService
{
    string CategoryOrigin(string numberChoice); 
    string CategoryFood(string numberChoice);
    string CategoryRating(string numberChoice);
}