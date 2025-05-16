/*
1. Multiple Subscribers
    - A Logger that logs the click
    - A UI Render that updates the screen
    - Unsubscribing the Logger after one click
2. Define the delegate
3. Publisher class 
    - Raise the event
4. Subscriber class - Logger
5. Subscriber class - UI
6. Main class
    - Subscribe both methods to the event
    - On first click, both subscribers respond
    - After first click the Logger unsubscribed
    - On second click, only UI responds
*/

public delegate void buttonClickHandler(string msg);

public class Button{
    public event buttonClickHandler? click;

    public void buttonClick(){
        Console.WriteLine("button clicked");
        click.Invoke("button click detected");
    }
}

public class Logger{
    public void logEvent(string msg){
        Console.WriteLine("Logger: " + msg);
    }
}

public class UI{
    public void UIRender(string msg){
        Console.WriteLine("UI Render after event: " + msg);
    }
}

class Program{
    static void onClick(string msg){
        Console.Write("Event recieved: " + msg);
    }

    static void Main(){
        Button button = new Button();
        Logger logger = new Logger();
        UI ui = new UI();

        button.click += logger.logEvent;
        button.click += ui.UIRender;

        button.buttonClick();
        button.click -= logger.logEvent;
        button.buttonClick();
    }
}


