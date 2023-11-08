public class Square: Shape
{
    private double _side;

    public Square(double side)
    {
        _side = side;

        
    }

    public override GetArea(double side)
    {
        double area = side * side;  
    
    }


}