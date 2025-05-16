/*
SCENARIO: TEMPERATURE SENSOR MONITORING SYSTEM
    - Temperature sensor monitors temperature
    - If temp exceeds a threshold, an event is triggered and a Cooling System responds by taking action
1. Subscriber(Notifier) : TempSensor
2. Publisher(Listener) : Cooler
*/

public class TempEventArgs : EventArgs{
    public double Tc{ get; }
    public TempEventArgs(double T){
        Tc = T;
    }
}

public class TempSensor{
    private double _Tt;
    public TempSensor(double Threshold){
        _Tt = Threshold;
    }

    public event EventHandler<TempEventArgs>? Overheat;

    public void checkT(double T){
        Console.WriteLine($"Current Temperature: {T}^oC");
        
        if(T >= _Tt){
            onOverheat(T);
        }
    }

    protected virtual void onOverheat(double Temp){
        Overheat?.Invoke(this, new TempEventArgs(Temp));
    }
}

public class Cooler{
    public void OverheatDetection(object sender, TempEventArgs e){
        Console.WriteLine($"[CoolingSystem Activated] Temperature {e.Tc}^oC exceeded threshold");
    }
}

class Program{
    static void Main(){
        TempSensor sensor = new TempSensor(30.0);
        Cooler cooler = new Cooler();
        sensor.Overheat += cooler.OverheatDetection;

        double[] TRange = { 25.3, 28.5, 31.2, 29.0, 35.6 };
        foreach(var t in TRange){
            sensor.checkT(t);
        } 
    }
}