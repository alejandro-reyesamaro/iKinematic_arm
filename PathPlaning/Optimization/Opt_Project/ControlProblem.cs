using System;
using System.Collections.Generic;
using System.Text;
//using Adolcdotnet;
//using Adolcdotnet_Tape;
//using ADTools;
namespace WindowsApplication1
{
    //public class ControlProblem
    //{
    //    #region variables
    //    public static ControlProblem activeproblem;
    //    public List<Control> controls;
    //    public List<double> disctimes;
    //    public List<List<DisControl>> tvsc;
    //    public double timeinit, timeend, difh;
    //    public int numbervardisc, problemid, iters, methodid;
    //    double[] state, initialcond, lowconst, upconst;
    //    public Parametrization p;
    //    bool[] lc, uc;
        
       
    //    #endregion

    //    public ControlProblem(int problemid, int timediscamount, int controlamount, int stateamount, double timeinit, double timeend, Parametrization p, bool [] lc, double [] lowconst, bool [] uc, double [] upconst) 
    //    {
    //        this.methodid = 1;
    //        this.p = p;                                 
    //        state = new double[stateamount+1];
    //        initialcond = new double[stateamount + 1];
            
    //        controls = new List<Control>();
    //        for (int i = 0; i < controlamount; i++)
    //        {
    //            tvsc = new List<List<DisControl>>();
    //            controls.Add(new Control(i));
    //            controls[i].Blowerconst = lc[i];
    //            controls[i].Bupperconst = uc[i];
    //            controls[i].Lowerconst = lowconst[i];
    //            controls[i].Upperconst = upconst[i];
    //            controls[i].Discretization = new List<DisControl>();
    //        }
    //        this.iters = 0;
    //        this.problemid = problemid;
    //        this.timeinit = timeinit;
    //        this.timeend = timeend;
    //        this.lowconst = lowconst;
    //        this.upconst = upconst;
    //        this.uc = uc;
    //        this.lc = lc;
    //        this.difh = 0.0000001;
    //        InitCond();
    //        Initcontrols(timediscamount, p); //se pasa la cantidad de controles discretizados iniciales por cada control
    //    }

    //    #region Methods
    //    public void Readjust(double[] vars)
    //    {
    //        UpdateControl(vars);
    //        List<double> disctimesnew = new List<double>();
    //        List<List<DisControl>> tvscnew = new List<List<DisControl>>();
    //        List<DisControl> discret = new List<DisControl>();
    //        numbervardisc = 1;
    //        disctimesnew.Add(disctimes[0]);
    //        tvscnew.Add(tvsc[0]);
    //        discret.Add(tvsc[0][0]);
    //        int i;
    //        for (i = 1; i < tvsc.Count - 1; i++)
    //        {
    //            DisControl dci = tvsc[i][0];
    //            DisControl dc1i = tvsc[i - 1][0];
    //            DisControl dci1 = tvsc[i + 1][0];
    //            if ((Math.Abs((dci.ValueC - dc1i.ValueC) / (dci.TimeC - dc1i.TimeC)) < 0.001) && (Math.Abs((dci1.ValueC - dci.ValueC) / (dci1.TimeC - dci.TimeC)) < 0.001)) //pendiente pequenna
    //            {

    //                if (i < tvsc.Count - 2)
    //                {
    //                    disctimesnew.Add(disctimes[i + 1]);
    //                    (tvsc[i + 1][0]).Pos = numbervardisc;
    //                    tvscnew.Add(tvsc[i + 1]);
    //                    discret.Add(tvsc[i + 1][0]);
    //                    numbervardisc++;
    //                    i++;
    //                }

    //            }
    //            else
    //            {
    //                if ((Math.Abs((dci.ValueC - dc1i.ValueC) / (dci.TimeC - dc1i.TimeC)) > 0.5) && (!((numbervardisc == 1) && (dci.Param == Parametrization.Constant))))
    //                {
    //                    DisControl dc = new DisControl(dc1i.Ctr, numbervardisc, (dci.TimeC + dc1i.TimeC) / 2, dc1i.ValueC, Parametrization.Linear);//agrego un punto
    //                    disctimesnew.Add((dc1i.TimeC + dci.TimeC) / 2);
    //                    List<DisControl> dcl = new List<DisControl>();
    //                    dcl.Add(dc);
    //                    tvscnew.Add(dcl);
    //                    discret.Add(dc);
    //                    numbervardisc++;

    //                }
    //                disctimesnew.Add(disctimes[i]);
    //                (tvsc[i][0]).Pos = numbervardisc;
    //                tvscnew.Add(tvsc[i]);
    //                discret.Add(tvsc[i][0]);
    //                numbervardisc++;
    //            }


    //        }
    //        if ((Math.Abs(((tvsc[disctimes.Count - 2][0]).ValueC - (tvsc[disctimes.Count - 1][0]).ValueC) / ((tvsc[disctimes.Count - 2][0]).TimeC - (tvsc[disctimes.Count - 1][0]).TimeC)) > 0.5))
    //        {
    //            DisControl dc = new DisControl((tvsc[disctimes.Count - 2][0]).Ctr, numbervardisc, ((tvsc[disctimes.Count - 1][0]).TimeC + (tvsc[disctimes.Count - 2][0]).TimeC) / 2, (tvsc[disctimes.Count - 2][0]).ValueC, Parametrization.Linear);//agrego un punto
    //            disctimesnew.Add(((tvsc[disctimes.Count - 2][0]).TimeC + (tvsc[disctimes.Count - 1][0]).TimeC) / 2);
    //            List<DisControl> dcl = new List<DisControl>();
    //            dcl.Add(dc);
    //            tvscnew.Add(dcl);
    //            discret.Add(dc);
    //            numbervardisc++;

    //        }
    //        disctimesnew.Add(disctimes[disctimes.Count - 1]);  //Se annade el ultimo punto
    //        (tvsc[disctimes.Count - 1][0]).Pos = numbervardisc;
    //        tvscnew.Add(tvsc[disctimes.Count - 1]);
    //        discret.Add(tvsc[disctimes.Count - 1][0]);
    //        numbervardisc++;
    //        controls[0].Discretization = discret;
    //        this.tvsc = tvscnew;
    //        this.disctimes = disctimesnew;
    //        double ob = Objective();
    //    }
        
    //    public void Reset(int iters, double[] vars) 
    //    {
    //        int info = -1;
    //        int iteration = -1;
    //        double f = -1;
    //        double epsinfo = -1;
    //        this.iters += iters;
    //        Readjust(vars);
    //        Optimize(ref iteration, ref epsinfo, ref f, ref info);
    //    }
    //    public double[] Gradientf(double time) 
    //    {
    //        double funcvalue = Objective(time);
    //        double[] vars = new double[numbervardisc+1];
    //        int index = 0;
    //        for (int i = 0; i < tvsc.Count; i++)
    //        {
    //            for (int j = 0; j < tvsc[i].Count; j++)
    //            {
    //                (tvsc[i])[j].ValueC += difh;
    //                vars[index+1] = (Objective(time)-funcvalue)/difh;
    //                (tvsc[i])[j].ValueC -= difh;
    //                index++;
    //            }
    //        }
    //        return vars;
    //    }
    //    public double[] Gradientf() { return Gradientf(timeend); }
    //    public double Objective() { return Objective(timeend); }
    //    public ADTools.adouble Objective(ADTools.adouble[] vars) { return Objective(vars, timeend); }
    //    public double Objective(double time)
    //    {
    //        double [] y = new double[state.Length];
    //        for (int i = 1; i < y.Length; i++)
    //            y[i]=initialcond[i];
    //        rungekuttasys.solvesystemrungekutta(this.timeinit, this.timeend, 400, state.Length - 1, ref y);

    //        if (problemid == 1) return -y[1] - 10 * y[2]; //Example 1. A simple problem from economics
    //        if (problemid == 2) return y[3];              //Example 2. The Rayleigh equation
    //        if (problemid == 3) return y[2];              //Example 3. Unconstrained problem
    //        return 0;
           
    //    }
    //    public ADTools.adouble Objective(ADTools.adouble[] vars, double time)
    //    {
    //        ADTools.adouble[] y = new ADTools.adouble[state.Length];
    //        for (int i = 1; i < y.Length; i++)
    //        {
    //            y[i] = new ADTools.adouble(initialcond[i]);                            
    //        }
    //        rungekuttasys.solvesystemrungekutta(this.timeinit, this.timeend, 400, state.Length - 1, ref y, vars);
           
    //        if (problemid == 1)                          //Example 1. A simple problem from economics 
    //        {
    //           return -1*y[1] - 10 * y[2]; 
    //        }
    //        if (problemid == 2) return y[3];              //Example 2. The Rayleigh equation
    //        if (problemid == 3) return y[2];              //Example 3. Unconstrained problem
    //        return null;
    //    }
      
        
    //    public double StateValue(int st, double time, double[] y)    //se puede mejorar utilizando el control discretizado activo en cada caso 
    //    {
    //        if (problemid == 1)                               //Example 1. A simple problem from economics
    //        {
    //            double pt = 0;
    //            if (time >= 0 && time <= 4)
    //                pt = 6 + 0.5 * time;
    //            else if (time > 4 && time <= 6)
    //                pt = 4 + time;
    //            else if (time >= 6 && time <= 8)
    //                pt = 10;
    //            double ut = this.controls[0].Eval(time);
    //            if (st == 1)
    //                return -0.25 * y[2] - pt * ut;
    //            return ut;
    //        }
    //        if (problemid == 2)                              //Example 2. The Rayleigh equation
    //        {
    //            double ut = this.controls[0].Eval(time);
    //            if (st == 1)
    //                return y[2];
    //            if (st == 2)
    //                return -y[1] + y[2] * (1.4 - 0.14 * y[2] * y[2]) + 4 * ut;
    //            return ut * ut + y[1] * y[1];
    //        }
    //        if (problemid == 3)                              //Example 3. Unconstrained problem
    //        {
    //            double ut = this.controls[0].Eval(time);
    //            if (st == 1)
    //                return 0.5 * y[1] + ut;
    //            return y[1] * y[1] + 0.5 * ut * ut;
    //        }
    //        return 0;
                       
    //    }
    //    public ADTools.adouble StateValue(int st, double time, ADTools.adouble[] y, ADTools.adouble[] vars)    //se puede mejorar utilizando el control discretizado activo en cada caso 
    //    {
    //        if (problemid == 1)                               //Example 1. A simple problem from economics
    //        {
    //            double pt = 0;
    //            if (time >= 0 && time <= 4)
    //                pt = 6 + 0.5 * time;
    //            else if (time > 4 && time <= 6)
    //                pt = 4 + time;
    //            else if (time >= 6 && time <= 8)
    //                pt = 10;
    //            ADTools.adouble ut = this.controls[0].Eval(time, vars);    
    //            if (st == 1)
    //            {                   
    //                return -0.25 * y[2] - pt * ut;
    //            }
    //            return ut;
    //        }
    //        if (problemid == 2)                              //Example 2. The Rayleigh equation
    //        {
    //            ADTools.adouble ut = this.controls[0].Eval(time, vars);
                
    //            if (st == 1)
    //                return y[2];
    //            if (st == 2)
    //            {                    
    //                return -1*y[1] + y[2] * (1.4 - 0.14 * y[2] * y[2]) + 4 * ut;
    //            }
    //            return ut * ut + y[1] * y[1];
    //        }
    //        if (problemid == 3)                              //Example 3. Unconstrained problem
    //        {
    //            ADTools.adouble ut = this.controls[0].Eval(time, vars);
    //            if (st == 1)
    //            {
    //                return 0.5 * y[1] + ut;
    //            }
    //            return y[1] * y[1] + 0.5 * ut * ut;
    //        }
    //        return null;

    //    }
       
    //    public void InitCond() 
    //    {
    //        if (problemid == 1)           //Example 1. A simple problem from economics
    //        {
    //            initialcond[1] = 100;
    //            initialcond[2] = 0;
    //        }
    //        else if (problemid == 2)      //Example 2. The Rayleigh equation
    //        {
    //            initialcond[1] = -5;
    //            initialcond[2] = -5;
    //            initialcond[3] = 0;
    //        }
    //        else if (problemid == 3)      //Example 3. Unconstrained problem
    //        {
    //            initialcond[1] = 1;
    //            initialcond[2] = 0;
    //        }
            
    //    }
    //    public void Initcontrols(int discnumber, Parametrization param)     //cantidad de intervalos  y parametrizacion
    //    {
    //        numbervardisc = (discnumber + 1) * controls.Count;
    //        disctimes = new List<double>();
    //        double h = (timeend - timeinit) / discnumber;
    //        double time = timeinit;                         
    //        for (int i = 0; i < discnumber ; i++) 
    //        {
    //            tvsc.Add(new List<DisControl>());
    //            disctimes.Add(time);
    //            foreach (Control c in controls)
    //            {
    //                DisControl dc = new DisControl(c, i, time,0, param);
    //                c.Discretization.Add(dc);   //se inicializa el control con 0 y parametrizacion lineal
    //                tvsc[i].Add(dc);
    //            }
    //            time += h;
    //        }
    //        tvsc.Add(new List<DisControl>());
    //        disctimes.Add(timeend);
    //        foreach (Control c in controls)
    //        {
    //            DisControl dc = new DisControl(c, discnumber, timeend, 0, param);
    //            c.Discretization.Add(dc);   //se inicializa el control con 0 y parametrizacion lineal
    //            tvsc[discnumber].Add(dc);
    //        }
    //    }
    //    public void UpdateControl(double[] vars)
    //    {
    //        int index = 0;
    //        for (int i = 0; i < tvsc.Count; i++) 
    //        {
    //            for (int j = 0; j < tvsc[i].Count; j++) 
    //            {
    //                (tvsc[i])[j].ValueC = vars[index+1];
    //                index++;
    //            }
    //        }
    //    }
    //    public double[] DiscVars() 
    //    {
    //        double[] vars = new double[numbervardisc+1];
    //        int index = 0;
    //        for (int i = 0; i < tvsc.Count; i++)
    //        {
    //            for (int j = 0; j < tvsc[i].Count; j++)
    //            {
    //                vars[index+1] = (tvsc[i])[j].ValueC;
    //                index++;
    //            }
    //        }
    //        return vars;

    //    }
    //    public double[] Optimize(int maxiters, double epsgrad, double epsfunc, double epsx, ref int iteration, ref double epsinfo, ref double f, ref int info ) 
    //    {
    //        double[] vars = new double[numbervardisc + 1];
    //        int[] bounds = new int[numbervardisc + 1];
    //        double[] lowbound = new double[numbervardisc + 1];
    //        double[] upbound = new double[numbervardisc + 1];
    //        Control c;
    //        int contval;
    //        int index = 0;
    //        for (int i = 0; i < tvsc.Count; i++)    //Se preparan los datos para la llamada del algoritmo de optimizacion
    //        {
    //            for (int j = 0; j < tvsc[i].Count; j++)
    //            {
    //                c = (tvsc[i])[j].Ctr;
    //                if (c.Blowerconst && c.Bupperconst) contval = 2;
    //                else if (c.Blowerconst && !c.Bupperconst) contval = 1;
    //                else if (!c.Blowerconst && c.Bupperconst) contval = 3;
    //                else contval = 0;
    //                bounds[index + 1] = contval;
    //                lowbound[index + 1] = c.Lowerconst;
    //                upbound[index + 1] = c.Upperconst;
    //                vars[index + 1] = (tvsc[i])[j].ValueC;
    //                index++;
    //            }
    //        }
    //        int m=7;
    //        if (numbervardisc <= 7) m = numbervardisc;
    //        lbfgsb.lbfgsbminimize(numbervardisc, m, ref vars, epsgrad, epsfunc, epsx, maxiters, ref bounds, ref lowbound, ref upbound, ref info, ref iteration, ref epsinfo, ref f);
    //            this.UpdateControl(vars);
    //            f = this.Objective();
          
    //        return vars;
    //    }
    //    public double[] Optimize(ref int iteration, ref double epsinfo, ref double f, ref int info)
    //    {
    //        return Optimize(100, 0.00000001, 0.00000001, 0.00000001, ref iteration, ref epsinfo, ref f, ref info);
    //    }
    //    public override string ToString()
    //    {
    //        string s="initial";
    //        if (problemid == 1) 
    //        {
    //            s = "  Problem 1. A Simple Problem From Economics\n\n  Minimize     J(y(8)) = - y1(8) - p(8)y2(8)\n\n  Subject to   dy1(t) = - 0.25y2(t) - p(t)u(t)     y1(0) = 0\n                     dy2(t) = u(t)                               y2(0) = 100\n\n                   - 1 =< u(t) =< 1\n\n                     | 6 + 0.5t     0 =< t =< 4\n         p(t) = < 4 + t           4 =< t =< 6\n                     | 10              6 =< t =< 8";                                                                            
    //        }
    //        if (problemid == 2) 
    //        {
    //            s = "  Problem 2. The Rayleigh Equation\n\n  Minimize     J(y(2.5)) = y3(2.5)\n\n  st   dy1(t) = y2(t)\n        dy2(t) = - y1(t) + y2(t)(1.4 - 0.4y2(t)y2(t)) + 4u(t)   \n        dy3(t) = u(t)u(t) + y1(t)y1(t) \n        y1(0) = - 5\n        y2(0) = - 5\n        y3(0) =  0\n\n        - 1 =< u(t) =< 1\n";  
    //        }
    //        if (problemid == 3) 
    //        {
    //            s = "  Problem 3. Unconstrained Problem\n\n  Minimize     J(y(1)) = y2(1)\n\n  st   dy1(t) = 0.5y1(t) + u(t)                         y1(0) = - 5\n        dy2(t) = y1(t)y1(t) + 0.5u(t)u(t)            y2(0) = - 5\n ";
    //        }

    //        return s;
    //    }
    //    #endregion
    //}
}
