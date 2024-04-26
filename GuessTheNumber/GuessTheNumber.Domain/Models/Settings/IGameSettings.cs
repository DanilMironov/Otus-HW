namespace GuessTheNumber.Domain.Models.Settings;

public interface IGameSettings
{
     public int Attempts { get; set; }
     public int From { get; set; }
     public int To { get; set; }
}