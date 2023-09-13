using System.ComponentModel.DataAnnotations;

namespace BlazorApp8
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public string? Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

    public record CustomerInvite()
    {
        [Required] public string FirstName { get; set; } = "test";
        [Required] public string Email { get; set; } = "test";

        public Mail? Mail1 { get; set; } 
        public Mail? Mail2 { get; set; }
        public bool IsSwitchButtonPressed { get; set; }
    }

    public record Mail
    {

        [Required]
        public string Address { get; set; }
       
    }
}
