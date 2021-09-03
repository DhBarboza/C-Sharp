namespace Class.Heritage
{
    // Herda a Classe "Point" (Só posso herdar de uma única Classe)
    public class Point3D : Point
    {
        public int z;
        public Point3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
            CalculatorDistance();
        }

        public static void Calculator()
        {
            // Faz alguma coisa
        }

        public override void CalculatorDistance3()
        {
            // Faz alguma coisa
            base.CalculatorDistance3();
        }
    }
}