using System;

namespace ShapesDrawing{

    public class Square: IShape{

        private Point topLeftPoint;
        private int height;

        public Square(){
            topLeftPoint = new Point();
        }

        public Square(Point newPoint,int height){
            this.height = height;
            topLeftPoint = new Point(newPoint.GetXCoordinate(), newPoint.GetYCoordinate());
        }

        public void ReadSquareInfo(){
            Console.WriteLine();
            Console.WriteLine("Top left point");
            Console.Write("Xcoordinate:");
            string var = Console.ReadLine();
            int result = Int32.Parse(var);
            if(result<0)
                    throw new ArgumentOutOfRangeException("Coordinate must be a positive number !");
                else
                     topLeftPoint.SetXCoordinate(result);

            Console.Write("Ycoordinate:");
            var =  Console.ReadLine();
            result = Int32.Parse(var);
            if(result<0)
                    throw new ArgumentOutOfRangeException("Coordinate must be a positive number !");
                else
                     topLeftPoint.SetYCoordinate(result);

            Console.Write("Height:");
            var = Console.ReadLine();
            result = Int32.Parse(var);
            if(result<0)
                    throw new ArgumentOutOfRangeException("Radius must be a positive number !");
                else
                    height = result;
            Console.WriteLine();
        
        }

        public void Draw(){
            Console.WriteLine("Square added ! -> TopLeftPoint ({0},{1}) and height = {2}",topLeftPoint.GetXCoordinate(),topLeftPoint.GetYCoordinate(),height);
            
        }
    }

}