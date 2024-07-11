using DIP1.Bad.Modals;
using DIP1.Bad.Services;

LightBulb lightBulb = new LightBulb();
Radio radio = new Radio();

SwitchService switchService = new SwitchService(lightBulb);
switchService.Switch();
switchService.Switch();

Console.ReadLine();