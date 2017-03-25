
using System;
using System.Collections.Generic;
using WindowsApplication1;
//using Adolcdotnet;
//using Adolcdotnet_Tape;

//class rungekuttasys
//{
   
//    static double f(int i, double x, double[] y)  
//    {              
//        return ControlProblem.activeproblem.StateValue(i, x, y);
//    }
//    static ADTools.adouble f(int i, double x, ADTools.adouble[] y, ADTools.adouble[] vars) 
//    {
//        return ControlProblem.activeproblem.StateValue(i,x,y,vars);
//    }


//    public static void solvesystemrungekutta(double x,
//        double x1,
//        int m,
//        int n,
//        ref double[] y)
//    {
//        double h = 0;
//        int amount = 0;
//        List<double> dt = ControlProblem.activeproblem.disctimes;
//        for (int j = 1; j < dt.Count; j++)
//        {
//            h = dt[j] - dt[j - 1];
//            amount = Math.Max((int)Math.Floor(m * h / (x1 - x)),1);
//            for (int i = 0; i <= amount - 1; i++)
//            {
//                solvesystemrungekuttastep(dt[j - 1] + i * (dt[j] - dt[j - 1]) / amount, (dt[j] - dt[j - 1]) / amount, n, ref y);
//            }
//        }       
        
//    }
//    public static void solvesystemrungekutta(double x,
//        double x1,
//        int m,
//        int n,
//        ref ADTools.adouble[] y,
//        ADTools.adouble[] vars)
//    {
//        double h = 0;
//        int amount = 0;
//        List<double> dt = ControlProblem.activeproblem.disctimes;
//        for (int j = 1; j < dt.Count; j++)
//        {
//            h = dt[j] - dt[j - 1];
//            amount = Math.Max((int)Math.Floor(m * h / (x1 - x)), 1);
//            for (int i = 0; i <= amount - 1; i++)
//            {
//                solvesystemrungekuttastep(dt[j - 1] + i * (dt[j] - dt[j - 1]) / amount, (dt[j] - dt[j - 1]) / amount, n, ref y, vars);
//            }
//        }       
//    }

//    public static void solvesystemrungekuttastep(double x,
//       double h,
//       int n,
//       ref ADTools.adouble[] y, ADTools.adouble[] vars)
//    {
//        int i = 0;
//        ADTools.adouble[] yt = new ADTools.adouble[n + 1];
//        ADTools.adouble[] k1 = new ADTools.adouble[n + 1];
//        ADTools.adouble[] k2 = new ADTools.adouble[n + 1];
//        ADTools.adouble[] k3 = new ADTools.adouble[n + 1];
//        ADTools.adouble[] k4 = new ADTools.adouble[n + 1];
//        ADTools.adouble aux = new ADTools.adouble();
//        for (i = 1; i <= n; i++)
//        {
//            k1[i] = h * f(i, x, y, vars);
//        }
//        for (i = 1; i <= n; i++)
//        {
//            yt[i] = y[i] + 0.5 * k1[i];
//        }
//        for (i = 1; i <= n; i++)
//        {
//            k2[i] = h * f(i, x + h * 0.5, yt, vars);
//        }
//        for (i = 1; i <= n; i++)
//        {
//           yt[i] = y[i] + 0.5 * k2[i];
//        }
//        for (i = 1; i <= n; i++)
//        {
//            k3[i] = h * f(i, x + h * 0.5, yt, vars);
//        }
//        for (i = 1; i <= n; i++)
//        {
//            yt[i] = y[i] + k3[i];
//        }
//        for (i = 1; i <= n; i++)
//        {
//            k4[i] = h * f(i, x + h, yt, vars);
//        }
//        for (i = 1; i <= n; i++)
//        {
//            y[i] = y[i] + (k1[i] + 2.0 * k2[i] + 2.0 * k3[i] + k4[i]) / 6;
//        }
//    }
//    public static void solvesystemrungekuttastep(double x,
//        double h,
//        int n,
//        ref double[] y)
//    {
//        int i = 0;
//        double[] yt = new double[n+1];
//        double[] k1 = new double[n+1];
//        double[] k2 = new double[n+1];
//        double[] k3 = new double[n+1];
//        double[] k4 = new double[n+1];
//        for(i=1; i<=n; i++)
//        {
//            k1[i] = h*f(i, x, y);
//        }
//        for(i=1; i<=n; i++)
//        {
//            yt[i] = y[i]+0.5*k1[i];
//        }
//        for(i=1; i<=n; i++)
//        {
//            k2[i] = h*f(i, x+h*0.5, yt);
//        }
//        for(i=1; i<=n; i++)
//        {
//            yt[i] = y[i]+0.5*k2[i];
//        }
//        for(i=1; i<=n; i++)
//        {
//            k3[i] = h*f(i, x+h*0.5, yt);
//        }
//        for(i=1; i<=n; i++)
//        {
//            yt[i] = y[i]+k3[i];
//        }
//        for(i=1; i<=n; i++)
//        {
//            k4[i] = h*f(i, x+h, yt);
//        }
//        for(i=1; i<=n; i++)
//        {
//            y[i] = y[i]+(k1[i]+2.0*k2[i]+2.0*k3[i]+k4[i])/6;
//        }
//    }
//}
