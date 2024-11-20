using System;

public struct Point3D {
    public Point3D(double x, double y, double z) {
        X = x;
        Y = y;
        Z = z;
    }

    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public double DistanceToOrigin() {
        return Math.Sqrt((Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2)));
    }
    //Vérifier que l'échange d'une variable de type Value doive se faire avec le modificateur ref.
    public static void SwapPoints(ref Point3D point1, ref Point3D point2) {
        //L'échange entre les deux points est correctement effectué avec des variables temporaires (tmp1, tmp2, tmp3) pour stocker les coordonnées
        //Cette logique respecte la sémantique VT demandée.
        double tmp1 = point1.X;
        double tmp2 = point1.Y;
        double tmp3 = point1.Z;

        point1.X = point2.X;
        point1.Y = point2.Y;
        point1.Z = point2.Z;
        point2.X = tmp1;
        point2.Y = tmp2;
        point2.Z = tmp3;
    }

    public override string ToString() => $"({X}, {Y}, {Z})";
}

namespace Exercice1 {
    class Program {
        static void Main(string[] args) {

            Point3D pt1 = new Point3D(10, 5, -10);
            Point3D pt2 = new Point3D(2, 2, 2);

            Console.WriteLine("Points : ");
            Console.WriteLine("Point 1 " + pt1);
            Console.WriteLine("Point 2 " + pt2);

            Console.WriteLine("Échange de points : ");
            Point3D.SwapPoints(ref pt1, ref pt2);
            Console.WriteLine("Point 1 " + pt1);
            Console.WriteLine("Point 2 " + pt2);

            Console.WriteLine("Distances à l'origine : ");
            Console.WriteLine("Point 1 distance à l'origine " + pt1.DistanceToOrigin());
            Console.WriteLine("Point 2 distance à l'origine " + pt2.DistanceToOrigin());
        }
    }
}
