namespace proje{


    public interface ISwitchable{
        void turnOn();
        void turnOff();
    }

    public interface IAdjustable{
        void adjust(int value);
    }

    public abstract class Device{

        public string Name {get; set;}

        protected bool isOn;
        public Device(string name){
            this.Name = name;
            isOn = false;
        }
        public virtual void turnOn(){
            isOn = true;
            Console.WriteLine($"{Name} is now ON.");
        }
        public virtual void turnOff(){
            isOn = false;
            Console.WriteLine($"{Name} is now OFF.");
        }

        public virtual void adjust(int value)
        {
            Console.WriteLine($"{Name} does not support adjustment.");
        }
        public abstract void DisplayStatus();
    }


    public class Heater: Device, IAdjustable,ISwitchable{
        public int Temp {get; private set;}
        public Heater(string name):  base(name){
            Temp = 2;
        }
        public override void turnOn()
        {
            isOn = true;
            Console.WriteLine($"{Name} is now ON.");
        }
        public override void turnOff()
        {
            isOn = false;
            Console.WriteLine($"{Name} is now OFF.");
        }

        public override void adjust(int value)
        {
            Temp = value;
            Console.WriteLine($"{Name} temperature set to {Temp}°C.");
        }
        
        public override void DisplayStatus()
        {
            Console.WriteLine($"{Name}: {(isOn ? "ON" : "OFF")}, Temperature: {Temp}°C");
        }

    }

    public class Light: Device, IAdjustable{
        
        public int Brightness {get; private set;}


        public Light(string name): base(name){
            
            Brightness = 50;
        }

        public override void turnOn(){
            isOn = true;
            Console.WriteLine($"{Name} is now ON.");
        }
        public override void turnOff(){
            isOn = false;
            Console.WriteLine($"{Name} is now OFF.");
        }
        public override void adjust(int value){
            Brightness = value;
        }
        public override void DisplayStatus()
        {
            Console.WriteLine($"{Name}: {(isOn ? "ON" : "OFF")}, Brightness: {Brightness}%");
        }
    }


    public class HomeAutomationSystem{
        private List<Device> devices;

        public HomeAutomationSystem(){
            devices = new List<Device>();
        }

        public void AddDevice(Device device){
            devices.Add(device);
            Console.WriteLine($"{device.Name} added to the system.");
        }



        public Device FindDevice(string deviceName){
            Device device = devices.Find(d=>d.Name == deviceName);
            return device;
        }

        public void DisplayAllDevices()
        {
            Console.WriteLine("\nDevice Statuses:");
            foreach (var device in devices)
            {
                device.DisplayStatus();
            }
        }
    }


    class Program{
        static void Main(){
            HomeAutomationSystem homeSystem = new HomeAutomationSystem();
            Light livingRoomLight = new Light("Living Room Light");
            Heater bedroomHeater = new Heater("Bedroom Heater");
            homeSystem.AddDevice(livingRoomLight);
            homeSystem.AddDevice(bedroomHeater);

            Device d1 = homeSystem.FindDevice("Living Room Light");
            Device d2 = homeSystem.FindDevice("Bedroom Heater");
            d1.turnOn();
            d2.adjust(28);


            homeSystem.DisplayAllDevices();
        }
    }
}