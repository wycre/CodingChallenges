namespace CodingPractice1;

// Define a delegate
public delegate void MyEventHandler(string message);

class Program
{
    // Declare event using delegate
    public static event MyEventHandler MyEvent;
    
    static void Main(string[] args)
    {
        // Subscribe to the event with a handler method
        MyEvent = EventHanlderMethod;

        // Raise the event by invoking it
        OnMyEvent("This is the event");

        // Unsubscribe from the event if necessary
        MyEvent -= EventHanlderMethod;
    }

    static void EventHanlderMethod(string message)
    {
        Console.WriteLine("Event Received: " + message);
    }
    
    // this method raises the event
    static void OnMyEvent(string message)
    {
        MyEvent?.Invoke(message);
    }
}