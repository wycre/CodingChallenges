using System;

namespace DeviceManagement
{
    // Abstract Class
    public abstract class Device
    {
        public string Name { get; set; }

        public Device(string name)
        {
            Name = name;
        }

        // Method to display device name
        public void DisplayDeviceInfo()
        {
            Console.WriteLine($"Device: {Name}");
        }
    }

    // IConnectable Interface
    public interface IConnectable
    {
        void Connect();
        bool IsConnected { get; set; }
    }

    // IDisconnectable Interface
    public interface IDisconnectable
    {
        void Disconnect();
        bool IsDisconnected { get; set; }
    }

    // Laptop Class - Inherits from Device and implements IConnectable and IDisconnectable
    public class Laptop : Device, IConnectable, IDisconnectable
    {
        public bool IsConnected { get; set; }
        public bool IsDisconnected { get; set; }

        public Laptop(string name) : base(name) { }

        public void Connect()
        {
            // complete this part
            IsConnected = true;
            IsDisconnected = false;
            Console.WriteLine($"{Name} has connected to the Wi-Fi.");
        }

        public void Disconnect()
        {
            // complete this part
            IsDisconnected = true;
            IsConnected = false;
            Console.WriteLine($"{Name} has disconnected from the Wi-Fi.");
        }

        
    }

    // Smartphone Class - Inherits from Device and implements IConnectable and IDisconnectable
    public class Smartphone : Device, IConnectable, IDisconnectable
    {
        
        public bool IsConnected { get; set; }
        public bool IsDisconnected { get; set; }
        
        public Smartphone(string name) : base(name) { }

        public void Connect()
        {
            IsConnected = true;
            IsDisconnected = false;
            Console.WriteLine($"{Name} has connected to the mobile network.");
        }

        public void Disconnect()
        {
            IsConnected = false;
            IsDisconnected = true;
            Console.WriteLine($"{Name} has disconnected from the mobile network.");
        }
        
        
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of Laptop and Smartphone
            Laptop laptop = new Laptop("Dell XPS");
            Smartphone smartphone = new Smartphone("Samsung Galaxy");

            // Display device info and test connection/disconnection
            laptop.DisplayDeviceInfo();
            laptop.Connect();
            laptop.Disconnect();

            smartphone.DisplayDeviceInfo();
            smartphone.Connect();
            smartphone.Disconnect();
        }
    }
}
