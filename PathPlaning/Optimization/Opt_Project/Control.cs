using System;
using System.Collections.Generic;
using System.Text;
//using Adolcdotnet;
//using Adolcdotnet_Tape;

namespace WindowsApplication1
{
    //public class Control
    //{
    //    #region variables
    //    int id;
    //    List<DisControl> discretization;
    //    double lowerconst, upperconst;
    //    bool blowerconst, bupperconst;
    //    #endregion
    //    #region Builders
    //    public Control(int id) 
    //    {
    //        this.id = id;
    //    }
    //    #endregion
    //    #region Properties
    //    public double Lowerconst 
    //    {
    //        get { return lowerconst; }
    //        set { lowerconst = value; }
    //    }
    //    public double Upperconst
    //    {
    //        get { return upperconst; }
    //        set { upperconst = value; }
    //    }
    //    public bool Blowerconst
    //    {
    //        get { return blowerconst; }
    //        set { blowerconst = value; }
    //    }
    //    public bool Bupperconst
    //    {
    //        get { return bupperconst; }
    //        set { bupperconst = value; }
    //    }
    //    public int Id 
    //    {
    //        get { return id; }
    //        set { id = value; }
    //    }
    //    public List<DisControl> Discretization 
    //    {
    //        get { return discretization; }
    //        set { discretization = value;}
    //    }
    //    #endregion
    //    #region Methods
    //    public DisControl FindDC (double time)  
    //    {
    //        if (discretization[0].TimeC == time) return discretization[0];
    //        if (discretization[discretization.Count - 1].TimeC == time) return discretization[discretization.Count - 1];
    //        return FindDC(time, 0, discretization[discretization.Count - 1].Pos);
    //    }
    //    public DisControl FindDC(double time, int posinit, int posend) 
    //    {
    //        if (posend - posinit <= 1) return discretization[posinit];
    //        int poscenter = (posend + posinit) / 2;
    //        DisControl controlcenter = discretization[poscenter];
    //        if (controlcenter.TimeC == time) return controlcenter;
    //        if (controlcenter.TimeC > time) return FindDC(time, posinit, poscenter);
    //        return FindDC(time, poscenter, posend);

    //    }
    //    public double Eval (double time)
    //    {
    //        if (time >= this.discretization[this.discretization.Count-1].TimeC) 
    //            return this.discretization[this.discretization.Count - 1].ValueC;
    //        DisControl dc = FindDC(time);
    //        return Eval (time - dc.TimeC, dc, dc.Param);
    //    }
    //    public ADTools.adouble Eval(double time, ADTools.adouble[] vars) 
    //    {
    //        if (time >= this.discretization[this.discretization.Count - 1].TimeC)
    //        {
    //            return vars[vars.Length-1];
    //        }
    //        DisControl dc = FindDC(time);
    //        return Eval (time - dc.TimeC, dc, dc.Param, vars);
    //    }
    //    public double Eval (double time, Parametrization param)
    //    {
    //        DisControl dc = FindDC(time);
    //        return Eval(time - dc.TimeC, dc, param);
    //    }
    //    public double Eval (double time, DisControl disc) // en estos caso time representa el tiempo despues del tiempo del control
    //    {
    //        return Eval(time, disc, disc.Param);
    //    }
    //    public double Eval(double time, DisControl disc, Parametrization param)
    //    {
    //        if (param == Parametrization.Constant)
    //        {
    //            return discretization[disc.Pos+1].ValueC;                                                                       //interpolacion constante
    //        }
    //        if (disc.Pos == discretization.Count - 1) return disc.ValueC; 
    //        DisControl discnext = discretization[disc.Pos + 1];
    //        if (discnext.TimeC - disc.TimeC < 0.0001) return disc.ValueC;
    //        return (discnext.ValueC - disc.ValueC)*time/(discnext.TimeC - disc.TimeC)+disc.ValueC ; //interpolacion lineal
    //    }
    //    public ADTools.adouble Eval(double time, DisControl disc, Parametrization param, ADTools.adouble[] vars) 
    //    {
    //        if (param == Parametrization.Constant)
    //        {
    //            return vars[disc.Pos+2];                                                  //interpolacion constante
    //        }
    //        if (disc.Pos == discretization.Count - 1) return vars[disc.Pos + 1];
    //        DisControl discnext = discretization[disc.Pos + 1];
    //        if (discnext.TimeC - disc.TimeC < 0.0001) return vars[disc.Pos + 1];
    //        return (vars[discnext.Pos+1] - vars[disc.Pos+1]) * time / (discnext.TimeC - disc.TimeC) + vars [disc.Pos+1]; //interpolacion lineal
    //    }
    //    #endregion
    //}
}
