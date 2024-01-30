
namespace Triangolo
{
    internal class Triangolo_op
    {
        public int latoA { get; set; }
        public int latoB { get; set; }
        public int latoC { get; set; }

        public string CheckTypeTriangle()
        {
            if (latoA == latoB && latoB == latoC)
            {    
                return "Il tuo rettagnolo è equilatero";
            } 

            else if (latoA == latoB ||  latoB == latoC || latoC == latoA)
            {
                return "il tuo rettangolo è isoscele";
            }

            else
            {
                return "Scaleno";
            }
        }

        public Triangolo_op(int latoA, int latoB, int latoC)
        {
            this.latoA = latoA;
            this.latoB = latoB;
            this.latoC = latoC;
        }
    }
}
