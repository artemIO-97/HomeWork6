namespace HomeWork7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер операции");
            var operation = Convert.ToInt32(Console.ReadLine());
            
          switch (operation)
          {

                case 1:
                    //Circle   
                    Console.Write("Введите радиус круга: ");
                    var radiusInput = Convert.ToDouble(Console.ReadLine());
                    var squareCircle = new Circle() { radius = radiusInput };
                     var result = squareCircle.GetSquare();
                    Console.WriteLine("Площадь круга " + result);
                    


                break;
                    case 2:
                    //Triangle  
                    Console.Write("Введите одну сторону треугольника: ");
                    var otherSideInput = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите высоту треугольника: ");
                    var hightInput = Convert.ToDouble(Console.ReadLine());
                    var squareTriangle = new Triangle() { otherSide = otherSideInput, hight = hightInput };
                    result = squareTriangle.GetSquare();
                    Console.WriteLine("Площадь треуголника " + result);

                    break;
                case 3:
                    //Square
                    Console.Write("Введите одну сторону прямоугольника: ");
                    var firstSideInput = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите высоту треугольника: ");
                    var secondSideInput = Convert.ToDouble(Console.ReadLine());
                    var squareSquare = new Square() {firstSide = firstSideInput, secondSide = secondSideInput };
                    result = squareSquare.GetSquare();
                    Console.WriteLine("Площадь прямоугольника " + result);

                    break;


          }

        }
           
    }
}
           
        
    

