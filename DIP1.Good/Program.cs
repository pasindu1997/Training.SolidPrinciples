using DIP1.Bad.Modals;
using DIP1.Bad.Services;
using DIP1.Good.Modals;

LightBulb lightBulb = new LightBulb();
Radio radio = new Radio();

SwitchService switchService = new SwitchService(lightBulb);
switchService.Switch();
switchService.Switch();

SwitchService switchService2 = new SwitchService(radio);
switchService2.Switch();
switchService2.Switch();

Console.ReadLine();