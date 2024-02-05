namespace MiniChallengeFiveToSeven___Endpoints.Services.Endpoint1;

public class MadLib : IMadLib
{
    public string LibGenerator(string day, string name, string mood, string activity, string structure, string sound, string feeling, string name2, string item, string feeling2)
    {
        return $"Story time: On {day}, {name} was quite {mood} doing {activity} at a(n) {structure} when suddenly there was a loud {sound}. {name} was feeling quite {feeling} because of the loud {sound.ToLower()}. Soon afterwards, {name}'s friend, {name2}, walked in the room carrying a(n) {item} and {name} was no longer {feeling} but now {feeling2}. End";
    }
}