namespace MyConeClassLibrary
{
    public class Cone
    {
        int radius, height;
        public Cone(int radius, int height)
        {
            this.radius = radius;
            this.height = height;
        }

        public double getFullSurfaceArea()
        {
            double sideArea = getBaseSurfaceArea();
            double baseArea = Math.PI * (radius ^ 2);

            return sideArea + baseArea;
        }

        public double getBaseSurfaceArea()
        {
            double length = Math.Sqrt((radius ^ 2) + (height ^ 2));

            return Math.PI * radius * length;
        }

    }
}