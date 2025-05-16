using System;
// 1. define the delegate
public delegate void buttonClickHandler(string msg);

// 2. declare the event in publisher class
// 3. declare the event - clicked
// 4. raise the event if there are subscribers | safe invocation of the event
// 5. ? mark event as nullable
public class Button{
    public event buttonClickHandler? clicked;

    public void click(){
        Console.WriteLine("button clicked");
        // if(clicked != null){
        //     Console.WriteLine("button was clicked");
        // }
        clicked?.Invoke("button was clicked");
    }
}

// 5. subscriber class
// 6. subscribe to the event using an eventHandler method
// 7. simulate the button
class Program{
    static void onButtonClick(string msg){
        Console.WriteLine("event received: " + msg);
    }
    static void Main(){
        Button button = new Button();
        button.clicked += onButtonClick;
        button.click();
    }
}   

/*
1. button.clicked += OnButtonClick; — now OnButtonClick is subscribed
2. button.click(); — simulates the click
3. inside click(), the clicked event is raised: clicked("...")
4. all methods subscribed to the event (like OnButtonClick) are executed in order
5. OnButtonClick("button was clicked") runs and prints the message

?
1. OnButtonClick is not called directly by the code
2. it is called automatically by the event system when clicked(event) is invoked
3. it's the response to the event — what the system should do when the button is clicked
*/