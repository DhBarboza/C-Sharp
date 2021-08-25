namespace Class.Heritage
{
    public class Point
    {
        public int x, y;
        private int distance;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected void CalculatorDistance()
        {
            // Faz alguma coisa
        }

        private void CalculatorDistance2()
        {
            // Faz alguma coisa
        }

        public virtual void CalculatorDistance3()
        {
            // Faz alguma coisa
        }
    }
}