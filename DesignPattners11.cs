using System;

public class Light
{
    public void TurnOn() => Console.WriteLine("Світло увімкнено");
    public void TurnOff() => Console.WriteLine("Світло вимкнено");
}

public interface ICommand
{
    void Execute();
}

public class TurnOnCommand : ICommand
{
    private Light _light;
    public TurnOnCommand(Light light) => _light = light;
    public void Execute() => _light.TurnOn();
}

public class TurnOffCommand : ICommand
{
    private Light _light;
    public TurnOffCommand(Light light) => _light = light;
    public void Execute() => _light.TurnOff();
}

class Program
{
    static void Main()
    {
        Light light = new Light();

        ICommand turnOn = new TurnOnCommand(light);
        ICommand turnOff = new TurnOffCommand(light);

        turnOn.Execute();
        turnOff.Execute();
    }
}
