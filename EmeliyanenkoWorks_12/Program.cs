// Zadacha 1 variant 12
// Method Niutona
/*double[] x = new double[] { 2.12, 3.432 };
int n = 5;
double afla = 0.001;
Console.WriteLine(f(x, n, afla));


double Shtraf(double[] X, int n, double alfa)
{
    double ogr1 = X[0] + X[1] - 5;
    double ogr2 = -X[0] + 2 * X[1] - 6;
    double ogr3 = -X[1] - 2;
    ogr1 = Min(ogr1);
    ogr2 = Min(ogr2);
    ogr3 = Min(ogr3);
    return (alfa * (ogr1 * ogr1 + ogr2 * ogr2 + ogr3 * ogr3));
}

double f(double[] X, int n, double alfa)
{
    double f = (Math.Pow(X[0],2) - (6 * X[0]) + 4 + Math.Exp(2 * X[0])) + Shtraf(X, n, alfa);
    return f;
}

double Min(double z)
{
    double rez;
    if (z < 0)
        rez = z;
    else
        rez = 0;
    return rez;
}*/
// Method Hord
/*
double x0 = 2;
double x1 = 10;
double e = 0.001;
double x = method_chord(x0, x1, e);
Console.WriteLine(x);
Console.ReadLine();
static double method_chord(double x_prev, double x_curr, double e)
{
    double x_next = 0;
    double tmp;

    do
    {
        tmp = x_next;
        x_next = x_curr - f(x_curr) * (x_prev - x_curr) / (f(x_prev) - f(x_curr));
        x_prev = x_curr;
        x_curr = tmp;
    } while (Math.Abs(x_next - x_curr) > e);

    return x_next;
}
 static double f(double x)
{
    return (Math.Pow(x, 2) - (6 * x) + 4 + Math.Exp(2 * x));
}
    

static void MiddlePoint(int a, int b, double e)
{
    int Xk = (a + b) / 2;

    if (Math.Abs(b - a) < e)
        Console.WriteLine("Экстремум находится в точке: {0}", Xk);

    else
    {
        double result = f(Xk);

        if (result < 0)
        {
            a = a + 1;
            b = b + 1;
        }

        else
        {
            a = a + 1;
            b = Xk;
        }

        MiddlePoint(a, b, e);
    }
}*/
// Zadacha 2 variant 12
/*static double f(double x1, double x2, double a, double b, double c, double d, double p)
{
    return (a * x1 + b * x2 + c * Math.Pow(x1, 2) + d * Math.Pow(x2, 2)) + p;
}

static double f2(double x1, double x2, double a, double b, double c, double d)
{
    return a * x1 + b * x2 + Math.Exp(c * Math.Pow(x1, 2) + d * Math.Pow(x2, 2));
}
double a = 19;
double a2 = 12;
double b = 12;
double b2 = -0.3;
double c = -9;
double c2 = 1.44;
double d = -1;
double d2 = 0.22;
double e = 0;
double x1 = 2;
double x2 = 1;
Console.WriteLine("MaxResult1: "+f(x1, x2, a, b, c, d, e));
Console.WriteLine("MaxResult2: "+f(x1, x2, a2, b2, c2, d2, e));

Console.WriteLine("MinResult1: " + f2(x1, x2, a, b, c, d));
Console.WriteLine("MinResult2: " + f2(x1, x2, a2, b2, c2, d2));*/