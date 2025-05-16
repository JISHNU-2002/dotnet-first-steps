/*
USING EventHandler - STANDARD PATTERN
    - No need to create custom delegate
    - Follows .NET conventions
    - Supports sender & EventArgs, giving the context and flexibility

SCENARIO - BUTTON CLICK SIMULATION
1. Publisher class - Button
2. Subsciber class - Program
3. Event - Click of type EventHandler

If you don’t need to send any extra data, just trigger the event
4. Click?.Invoke(this, EventArgs.Empty)
    - Subscriber is only notified that "an event occurred", with no details
5. To pass additional info (like a message, timestamp, etc.) to the subscriber
    - Create custom EventArgs
*/

public class buttonClickEventArgs : EventArgs{
    public string message{ get; set; }
}

public class Button{
    //public event EventHandler<EventArgs>? Click;
    public event EventHandler<buttonClickEventArgs>? Click;

    public void buttonClick(){
        Console.WriteLine("Button clicked");
        //Click?.Invoke(this, EventArgs.Empty);
        Click?.Invoke(this, new buttonClickEventArgs{
            message = "Click event triggered"
        });
    }
}

class Program{
    static void Main(){
        Button button = new Button();
        button.Click += onClick;
        button.buttonClick();
    }

    static void onClick(object? sender, buttonClickEventArgs e){
        Console.WriteLine("Publisher: " + sender.GetType().Name);  
        Console.WriteLine("Event recieved in Subscriber: " + e.message);
    }
}

/*
object? sender   
    - This refers to the source (publisher) of the event — the object that raised it
    - Here, it will be the Button object
    - ? allows it to be null (optional in modern C#)
*/