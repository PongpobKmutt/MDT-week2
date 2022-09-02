using System;

public class UnitConverter {

    private int ratio;

    public UnitConverter(int ratio) {

            this.ratio = ratio;
    }
    public int Convert(int unit) {

        return unit * this.ratio;

    }


}



class Program {

    

    
    
    
    
    
    
    
    public static void Main(string[] args) {

        UnitConverter feetToInchesConverter = new UnitConverter(12);
        UnitConverter milesToFeetConverter = new UnitConverter(5280);

        Console.WriteLine("Feet to inches: {0}", feetToInchesConverter.Convert(30));
        Console.WriteLine("Miles to Inches: {0}", milesToFeetConverter.Convert(1));
        Console.WriteLine("Feet to Inches from miles : {0}", feetToInchesConverter.Convert(milesToFeetConverter.Convert(2)));

        
        




    }



}


