/*
* MATLAB Compiler: 4.14 (R2010b)
* Date: Thu Oct 04 08:01:31 2012
* Arguments: "-B" "macro_default" "-W"
* "dotnet:IK_ParticleFiltering_NET,Matlab_PF_Class,0.0,private" "-T" "link:lib" "-d"
* "I:\Investigacion\Tesis de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
* 04102012\MatlabProyect\IK_ParticleFiltering_NET\src" "-w"
* "enable:specified_file_mismatch" "-w" "enable:repeated_file" "-w"
* "enable:switch_ignored" "-w" "enable:missing_lib_sentinel" "-w" "enable:demo_license"
* "-v" "class{Matlab_PF_Class:I:\Investigacion\Tesis de Maestria\Proyecto de Tesis
* [ultimo]\MATH\Built - 04102012\IK_ParticleFiltering_NET\angulo.m,I:\Investigacion\Tesis
* de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
* 04102012\IK_ParticleFiltering_NET\chain2positions.m,I:\Investigacion\Tesis de
* Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
* 04102012\IK_ParticleFiltering_NET\chainEndEffectorPosition.m,I:\Investigacion\Tesis de
* Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
* 04102012\IK_ParticleFiltering_NET\chainQuTEMSampling.m,I:\Investigacion\Tesis de
* Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
* 04102012\IK_ParticleFiltering_NET\createChain.m,I:\Investigacion\Tesis de
* Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
* 04102012\IK_ParticleFiltering_NET\createParticle.m,I:\Investigacion\Tesis de
* Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
* 04102012\IK_ParticleFiltering_NET\dentro.m,I:\Investigacion\Tesis de Maestria\Proyecto
* de Tesis [ultimo]\MATH\Built -
* 04102012\IK_ParticleFiltering_NET\euclidianDistance.m,I:\Investigacion\Tesis de
* Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
* 04102012\IK_ParticleFiltering_NET\evalua_recta.m,I:\Investigacion\Tesis de
* Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
* 04102012\IK_ParticleFiltering_NET\mas.m,I:\Investigacion\Tesis de Maestria\Proyecto de
* Tesis [ultimo]\MATH\Built -
* 04102012\IK_ParticleFiltering_NET\obstaculo_crecido.m,I:\Investigacion\Tesis de
* Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
* 04102012\IK_ParticleFiltering_NET\PF.m,I:\Investigacion\Tesis de Maestria\Proyecto de
* Tesis [ultimo]\MATH\Built -
* 04102012\IK_ParticleFiltering_NET\pik.m,I:\Investigacion\Tesis de Maestria\Proyecto de
* Tesis [ultimo]\MATH\Built -
* 04102012\IK_ParticleFiltering_NET\positions2chain.m,I:\Investigacion\Tesis de
* Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
* 04102012\IK_ParticleFiltering_NET\PrtFltr_MkwskSum.m,I:\Investigacion\Tesis de
* Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
* 04102012\IK_ParticleFiltering_NET\quaternion.m,I:\Investigacion\Tesis de
* Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
* 04102012\IK_ParticleFiltering_NET\quaternionConjugate.m,I:\Investigacion\Tesis de
* Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
* 04102012\IK_ParticleFiltering_NET\quaternionExponentialMap.m,I:\Investigacion\Tesis de
* Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
* 04102012\IK_ParticleFiltering_NET\quaternionProduct.m,I:\Investigacion\Tesis de
* Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
* 04102012\IK_ParticleFiltering_NET\quaternionQuTEMSampling.m,I:\Investigacion\Tesis de
* Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
* 04102012\IK_ParticleFiltering_NET\quaternionRotation.m,I:\Investigacion\Tesis de
* Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
* 04102012\IK_ParticleFiltering_NET\remostrejar.m,I:\Investigacion\Tesis de
* Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
* 04102012\IK_ParticleFiltering_NET\S_Touch.m,I:\Investigacion\Tesis de Maestria\Proyecto
* de Tesis [ultimo]\MATH\Built -
* 04102012\IK_ParticleFiltering_NET\setGaussianParameters.m,I:\Investigacion\Tesis de
* Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
* 04102012\IK_ParticleFiltering_NET\weightFunction.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace IK_ParticleFiltering_NETNative
{
  /// <summary>
  /// The Matlab_PF_Class class provides a CLS compliant, Object (native) interface to
  /// the M-functions contained in the files:
  /// <newpara></newpara>
  /// I:\Investigacion\Tesis de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
  /// 04102012\IK_ParticleFiltering_NET\angulo.m
  /// <newpara></newpara>
  /// I:\Investigacion\Tesis de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
  /// 04102012\IK_ParticleFiltering_NET\chain2positions.m
  /// <newpara></newpara>
  /// I:\Investigacion\Tesis de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
  /// 04102012\IK_ParticleFiltering_NET\chainEndEffectorPosition.m
  /// <newpara></newpara>
  /// I:\Investigacion\Tesis de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
  /// 04102012\IK_ParticleFiltering_NET\chainQuTEMSampling.m
  /// <newpara></newpara>
  /// I:\Investigacion\Tesis de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
  /// 04102012\IK_ParticleFiltering_NET\createChain.m
  /// <newpara></newpara>
  /// I:\Investigacion\Tesis de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
  /// 04102012\IK_ParticleFiltering_NET\createParticle.m
  /// <newpara></newpara>
  /// I:\Investigacion\Tesis de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
  /// 04102012\IK_ParticleFiltering_NET\dentro.m
  /// <newpara></newpara>
  /// I:\Investigacion\Tesis de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
  /// 04102012\IK_ParticleFiltering_NET\euclidianDistance.m
  /// <newpara></newpara>
  /// I:\Investigacion\Tesis de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
  /// 04102012\IK_ParticleFiltering_NET\evalua_recta.m
  /// <newpara></newpara>
  /// I:\Investigacion\Tesis de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
  /// 04102012\IK_ParticleFiltering_NET\mas.m
  /// <newpara></newpara>
  /// I:\Investigacion\Tesis de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
  /// 04102012\IK_ParticleFiltering_NET\obstaculo_crecido.m
  /// <newpara></newpara>
  /// I:\Investigacion\Tesis de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
  /// 04102012\IK_ParticleFiltering_NET\PF.m
  /// <newpara></newpara>
  /// I:\Investigacion\Tesis de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
  /// 04102012\IK_ParticleFiltering_NET\pik.m
  /// <newpara></newpara>
  /// I:\Investigacion\Tesis de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
  /// 04102012\IK_ParticleFiltering_NET\positions2chain.m
  /// <newpara></newpara>
  /// I:\Investigacion\Tesis de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
  /// 04102012\IK_ParticleFiltering_NET\PrtFltr_MkwskSum.m
  /// <newpara></newpara>
  /// I:\Investigacion\Tesis de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
  /// 04102012\IK_ParticleFiltering_NET\quaternion.m
  /// <newpara></newpara>
  /// I:\Investigacion\Tesis de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
  /// 04102012\IK_ParticleFiltering_NET\quaternionConjugate.m
  /// <newpara></newpara>
  /// I:\Investigacion\Tesis de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
  /// 04102012\IK_ParticleFiltering_NET\quaternionExponentialMap.m
  /// <newpara></newpara>
  /// I:\Investigacion\Tesis de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
  /// 04102012\IK_ParticleFiltering_NET\quaternionProduct.m
  /// <newpara></newpara>
  /// I:\Investigacion\Tesis de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
  /// 04102012\IK_ParticleFiltering_NET\quaternionQuTEMSampling.m
  /// <newpara></newpara>
  /// I:\Investigacion\Tesis de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
  /// 04102012\IK_ParticleFiltering_NET\quaternionRotation.m
  /// <newpara></newpara>
  /// I:\Investigacion\Tesis de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
  /// 04102012\IK_ParticleFiltering_NET\remostrejar.m
  /// <newpara></newpara>
  /// I:\Investigacion\Tesis de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
  /// 04102012\IK_ParticleFiltering_NET\S_Touch.m
  /// <newpara></newpara>
  /// I:\Investigacion\Tesis de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
  /// 04102012\IK_ParticleFiltering_NET\setGaussianParameters.m
  /// <newpara></newpara>
  /// I:\Investigacion\Tesis de Maestria\Proyecto de Tesis [ultimo]\MATH\Built -
  /// 04102012\IK_ParticleFiltering_NET\weightFunction.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class Matlab_PF_Class : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static Matlab_PF_Class()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = "IK_ParticleFiltering_NET.ctf";

        Stream embeddedCtfStream = null;

        String[] resourceStrings = assembly.GetManifestResourceNames();

        foreach (String name in resourceStrings)
        {
          if (name.Contains(ctfFileName))
          {
            embeddedCtfStream = assembly.GetManifestResourceStream(name);
            break;
          }
        }
        mcr= new MWMCR("",
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the Matlab_PF_Class class.
    /// </summary>
    public Matlab_PF_Class()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~Matlab_PF_Class()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the angulo M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object angulo()
    {
      return mcr.EvaluateFunction("angulo", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the angulo M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="p1">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object angulo(Object p1)
    {
      return mcr.EvaluateFunction("angulo", p1);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the angulo M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="p1">Input argument #1</param>
    /// <param name="p2">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object angulo(Object p1, Object p2)
    {
      return mcr.EvaluateFunction("angulo", p1, p2);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the angulo M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="p1">Input argument #1</param>
    /// <param name="p2">Input argument #2</param>
    /// <param name="antan">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object angulo(Object p1, Object p2, Object antan)
    {
      return mcr.EvaluateFunction("angulo", p1, p2, antan);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the angulo M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] angulo(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "angulo", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the angulo M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="p1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] angulo(int numArgsOut, Object p1)
    {
      return mcr.EvaluateFunction(numArgsOut, "angulo", p1);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the angulo M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="p1">Input argument #1</param>
    /// <param name="p2">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] angulo(int numArgsOut, Object p1, Object p2)
    {
      return mcr.EvaluateFunction(numArgsOut, "angulo", p1, p2);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the angulo M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="p1">Input argument #1</param>
    /// <param name="p2">Input argument #2</param>
    /// <param name="antan">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] angulo(int numArgsOut, Object p1, Object p2, Object antan)
    {
      return mcr.EvaluateFunction(numArgsOut, "angulo", p1, p2, antan);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the chain2positions
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// TODO: Valid for matrix</remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object chain2positions()
    {
      return mcr.EvaluateFunction("chain2positions", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the chain2positions
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// TODO: Valid for matrix</remarks>
    /// <param name="chain">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object chain2positions(Object chain)
    {
      return mcr.EvaluateFunction("chain2positions", chain);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the chain2positions M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// TODO: Valid for matrix</remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] chain2positions(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "chain2positions", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the chain2positions M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// TODO: Valid for matrix</remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="chain">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] chain2positions(int numArgsOut, Object chain)
    {
      return mcr.EvaluateFunction(numArgsOut, "chain2positions", chain);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the chainEndEffectorPosition
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object chainEndEffectorPosition()
    {
      return mcr.EvaluateFunction("chainEndEffectorPosition", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the chainEndEffectorPosition
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="chain">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object chainEndEffectorPosition(Object chain)
    {
      return mcr.EvaluateFunction("chainEndEffectorPosition", chain);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the chainEndEffectorPosition
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] chainEndEffectorPosition(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "chainEndEffectorPosition", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the chainEndEffectorPosition
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="chain">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] chainEndEffectorPosition(int numArgsOut, Object chain)
    {
      return mcr.EvaluateFunction(numArgsOut, "chainEndEffectorPosition", chain);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the chainQuTEMSampling
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object chainQuTEMSampling()
    {
      return mcr.EvaluateFunction("chainQuTEMSampling", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the chainQuTEMSampling
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="g">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object chainQuTEMSampling(Object g)
    {
      return mcr.EvaluateFunction("chainQuTEMSampling", g);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the chainQuTEMSampling
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="g">Input argument #1</param>
    /// <param name="chain">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object chainQuTEMSampling(Object g, Object chain)
    {
      return mcr.EvaluateFunction("chainQuTEMSampling", g, chain);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the chainQuTEMSampling
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] chainQuTEMSampling(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "chainQuTEMSampling", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the chainQuTEMSampling
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="g">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] chainQuTEMSampling(int numArgsOut, Object g)
    {
      return mcr.EvaluateFunction(numArgsOut, "chainQuTEMSampling", g);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the chainQuTEMSampling
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="g">Input argument #1</param>
    /// <param name="chain">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] chainQuTEMSampling(int numArgsOut, Object g, Object chain)
    {
      return mcr.EvaluateFunction(numArgsOut, "chainQuTEMSampling", g, chain);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the createChain M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object createChain()
    {
      return mcr.EvaluateFunction("createChain", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the createChain M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="vectores_canonicos">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object createChain(Object vectores_canonicos)
    {
      return mcr.EvaluateFunction("createChain", vectores_canonicos);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the createChain M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] createChain(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "createChain", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the createChain M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="vectores_canonicos">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] createChain(int numArgsOut, Object vectores_canonicos)
    {
      return mcr.EvaluateFunction(numArgsOut, "createChain", vectores_canonicos);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the createParticle
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object createParticle()
    {
      return mcr.EvaluateFunction("createParticle", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the createParticle
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="chain">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object createParticle(Object chain)
    {
      return mcr.EvaluateFunction("createParticle", chain);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the createParticle
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="chain">Input argument #1</param>
    /// <param name="samples">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object createParticle(Object chain, Object samples)
    {
      return mcr.EvaluateFunction("createParticle", chain, samples);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the createParticle
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="chain">Input argument #1</param>
    /// <param name="samples">Input argument #2</param>
    /// <param name="pg">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object createParticle(Object chain, Object samples, Object pg)
    {
      return mcr.EvaluateFunction("createParticle", chain, samples, pg);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the createParticle
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="chain">Input argument #1</param>
    /// <param name="samples">Input argument #2</param>
    /// <param name="pg">Input argument #3</param>
    /// <param name="equal">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object createParticle(Object chain, Object samples, Object pg, Object equal)
    {
      return mcr.EvaluateFunction("createParticle", chain, samples, pg, equal);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the createParticle M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] createParticle(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "createParticle", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the createParticle M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="chain">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] createParticle(int numArgsOut, Object chain)
    {
      return mcr.EvaluateFunction(numArgsOut, "createParticle", chain);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the createParticle M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="chain">Input argument #1</param>
    /// <param name="samples">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] createParticle(int numArgsOut, Object chain, Object samples)
    {
      return mcr.EvaluateFunction(numArgsOut, "createParticle", chain, samples);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the createParticle M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="chain">Input argument #1</param>
    /// <param name="samples">Input argument #2</param>
    /// <param name="pg">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] createParticle(int numArgsOut, Object chain, Object samples, Object 
                             pg)
    {
      return mcr.EvaluateFunction(numArgsOut, "createParticle", chain, samples, pg);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the createParticle M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="chain">Input argument #1</param>
    /// <param name="samples">Input argument #2</param>
    /// <param name="pg">Input argument #3</param>
    /// <param name="equal">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] createParticle(int numArgsOut, Object chain, Object samples, Object 
                             pg, Object equal)
    {
      return mcr.EvaluateFunction(numArgsOut, "createParticle", chain, samples, pg, equal);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the dentro M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion nos dir'a si un punto est'a dentro de un poligono (convexo)
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object dentro()
    {
      return mcr.EvaluateFunction("dentro", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the dentro M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion nos dir'a si un punto est'a dentro de un poligono (convexo)
    /// </remarks>
    /// <param name="P">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object dentro(Object P)
    {
      return mcr.EvaluateFunction("dentro", P);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the dentro M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion nos dir'a si un punto est'a dentro de un poligono (convexo)
    /// </remarks>
    /// <param name="P">Input argument #1</param>
    /// <param name="p">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object dentro(Object P, Object p)
    {
      return mcr.EvaluateFunction("dentro", P, p);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the dentro M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion nos dir'a si un punto est'a dentro de un poligono (convexo)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] dentro(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "dentro", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the dentro M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion nos dir'a si un punto est'a dentro de un poligono (convexo)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="P">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] dentro(int numArgsOut, Object P)
    {
      return mcr.EvaluateFunction(numArgsOut, "dentro", P);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the dentro M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion nos dir'a si un punto est'a dentro de un poligono (convexo)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="P">Input argument #1</param>
    /// <param name="p">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] dentro(int numArgsOut, Object P, Object p)
    {
      return mcr.EvaluateFunction(numArgsOut, "dentro", P, p);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the euclidianDistance
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object euclidianDistance()
    {
      return mcr.EvaluateFunction("euclidianDistance", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the euclidianDistance
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="p1">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object euclidianDistance(Object p1)
    {
      return mcr.EvaluateFunction("euclidianDistance", p1);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the euclidianDistance
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="p1">Input argument #1</param>
    /// <param name="p2">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object euclidianDistance(Object p1, Object p2)
    {
      return mcr.EvaluateFunction("euclidianDistance", p1, p2);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the euclidianDistance
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] euclidianDistance(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "euclidianDistance", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the euclidianDistance
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="p1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] euclidianDistance(int numArgsOut, Object p1)
    {
      return mcr.EvaluateFunction(numArgsOut, "euclidianDistance", p1);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the euclidianDistance
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="p1">Input argument #1</param>
    /// <param name="p2">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] euclidianDistance(int numArgsOut, Object p1, Object p2)
    {
      return mcr.EvaluateFunction(numArgsOut, "euclidianDistance", p1, p2);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the evalua_recta M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Calculo de la ecuación d ela recta
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object evalua_recta()
    {
      return mcr.EvaluateFunction("evalua_recta", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the evalua_recta M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Calculo de la ecuación d ela recta
    /// </remarks>
    /// <param name="r">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object evalua_recta(Object r)
    {
      return mcr.EvaluateFunction("evalua_recta", r);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the evalua_recta M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Calculo de la ecuación d ela recta
    /// </remarks>
    /// <param name="r">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object evalua_recta(Object r, Object x)
    {
      return mcr.EvaluateFunction("evalua_recta", r, x);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the evalua_recta M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Calculo de la ecuación d ela recta
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] evalua_recta(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "evalua_recta", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the evalua_recta M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Calculo de la ecuación d ela recta
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="r">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] evalua_recta(int numArgsOut, Object r)
    {
      return mcr.EvaluateFunction(numArgsOut, "evalua_recta", r);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the evalua_recta M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Calculo de la ecuación d ela recta
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="r">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] evalua_recta(int numArgsOut, Object r, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "evalua_recta", r, x);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the mas M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Retorna la suma vectorial de dos puntos
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mas()
    {
      return mcr.EvaluateFunction("mas", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the mas M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Retorna la suma vectorial de dos puntos
    /// </remarks>
    /// <param name="p1">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mas(Object p1)
    {
      return mcr.EvaluateFunction("mas", p1);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the mas M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Retorna la suma vectorial de dos puntos
    /// </remarks>
    /// <param name="p1">Input argument #1</param>
    /// <param name="p2">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mas(Object p1, Object p2)
    {
      return mcr.EvaluateFunction("mas", p1, p2);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the mas M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Retorna la suma vectorial de dos puntos
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mas(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "mas", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the mas M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Retorna la suma vectorial de dos puntos
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="p1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mas(int numArgsOut, Object p1)
    {
      return mcr.EvaluateFunction(numArgsOut, "mas", p1);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the mas M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Retorna la suma vectorial de dos puntos
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="p1">Input argument #1</param>
    /// <param name="p2">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mas(int numArgsOut, Object p1, Object p2)
    {
      return mcr.EvaluateFunction(numArgsOut, "mas", p1, p2);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the obstaculo_crecido
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta función calcula espacio prohibido de configuraciones de un brazo
    /// mecanico representado por el segmento "a". El resultado es una lista de
    /// puntos que representan el obstáculo crecido: "RmasP"
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object obstaculo_crecido()
    {
      return mcr.EvaluateFunction("obstaculo_crecido", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the obstaculo_crecido
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta función calcula espacio prohibido de configuraciones de un brazo
    /// mecanico representado por el segmento "a". El resultado es una lista de
    /// puntos que representan el obstáculo crecido: "RmasP"
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object obstaculo_crecido(Object a)
    {
      return mcr.EvaluateFunction("obstaculo_crecido", a);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the obstaculo_crecido
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta función calcula espacio prohibido de configuraciones de un brazo
    /// mecanico representado por el segmento "a". El resultado es una lista de
    /// puntos que representan el obstáculo crecido: "RmasP"
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <param name="L_puntos">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object obstaculo_crecido(Object a, Object L_puntos)
    {
      return mcr.EvaluateFunction("obstaculo_crecido", a, L_puntos);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the obstaculo_crecido
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta función calcula espacio prohibido de configuraciones de un brazo
    /// mecanico representado por el segmento "a". El resultado es una lista de
    /// puntos que representan el obstáculo crecido: "RmasP"
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] obstaculo_crecido(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "obstaculo_crecido", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the obstaculo_crecido
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta función calcula espacio prohibido de configuraciones de un brazo
    /// mecanico representado por el segmento "a". El resultado es una lista de
    /// puntos que representan el obstáculo crecido: "RmasP"
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] obstaculo_crecido(int numArgsOut, Object a)
    {
      return mcr.EvaluateFunction(numArgsOut, "obstaculo_crecido", a);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the obstaculo_crecido
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta función calcula espacio prohibido de configuraciones de un brazo
    /// mecanico representado por el segmento "a". El resultado es una lista de
    /// puntos que representan el obstáculo crecido: "RmasP"
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <param name="L_puntos">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] obstaculo_crecido(int numArgsOut, Object a, Object L_puntos)
    {
      return mcr.EvaluateFunction(numArgsOut, "obstaculo_crecido", a, L_puntos);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the PF M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// sampling
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PF()
    {
      return mcr.EvaluateFunction("PF", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the PF M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// sampling
    /// </remarks>
    /// <param name="goal">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PF(Object goal)
    {
      return mcr.EvaluateFunction("PF", goal);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the PF M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// sampling
    /// </remarks>
    /// <param name="goal">Input argument #1</param>
    /// <param name="particles">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PF(Object goal, Object particles)
    {
      return mcr.EvaluateFunction("PF", goal, particles);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the PF M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// sampling
    /// </remarks>
    /// <param name="goal">Input argument #1</param>
    /// <param name="particles">Input argument #2</param>
    /// <param name="S">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PF(Object goal, Object particles, Object S)
    {
      return mcr.EvaluateFunction("PF", goal, particles, S);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the PF M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// sampling
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PF(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "PF", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the PF M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// sampling
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="goal">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PF(int numArgsOut, Object goal)
    {
      return mcr.EvaluateFunction(numArgsOut, "PF", goal);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the PF M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// sampling
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="goal">Input argument #1</param>
    /// <param name="particles">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PF(int numArgsOut, Object goal, Object particles)
    {
      return mcr.EvaluateFunction(numArgsOut, "PF", goal, particles);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the PF M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// sampling
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="goal">Input argument #1</param>
    /// <param name="particles">Input argument #2</param>
    /// <param name="S">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PF(int numArgsOut, Object goal, Object particles, Object S)
    {
      return mcr.EvaluateFunction(numArgsOut, "PF", goal, particles, S);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the pik M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// chainResult = chain;
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object pik()
    {
      return mcr.EvaluateFunction("pik", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the pik M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// chainResult = chain;
    /// </remarks>
    /// <param name="max_iter">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object pik(Object max_iter)
    {
      return mcr.EvaluateFunction("pik", max_iter);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the pik M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// chainResult = chain;
    /// </remarks>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object pik(Object max_iter, Object epsilon)
    {
      return mcr.EvaluateFunction("pik", max_iter, epsilon);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the pik M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// chainResult = chain;
    /// </remarks>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <param name="chain">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object pik(Object max_iter, Object epsilon, Object chain)
    {
      return mcr.EvaluateFunction("pik", max_iter, epsilon, chain);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the pik M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// chainResult = chain;
    /// </remarks>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <param name="chain">Input argument #3</param>
    /// <param name="goal">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object pik(Object max_iter, Object epsilon, Object chain, Object goal)
    {
      return mcr.EvaluateFunction("pik", max_iter, epsilon, chain, goal);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the pik M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// chainResult = chain;
    /// </remarks>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <param name="chain">Input argument #3</param>
    /// <param name="goal">Input argument #4</param>
    /// <param name="particles">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object pik(Object max_iter, Object epsilon, Object chain, Object goal, Object 
                particles)
    {
      return mcr.EvaluateFunction("pik", max_iter, epsilon, chain, goal, particles);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the pik M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// chainResult = chain;
    /// </remarks>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <param name="chain">Input argument #3</param>
    /// <param name="goal">Input argument #4</param>
    /// <param name="particles">Input argument #5</param>
    /// <param name="S">Input argument #6</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object pik(Object max_iter, Object epsilon, Object chain, Object goal, Object 
                particles, Object S)
    {
      return mcr.EvaluateFunction("pik", max_iter, epsilon, chain, goal, particles, S);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the pik M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// chainResult = chain;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] pik(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "pik", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the pik M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// chainResult = chain;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="max_iter">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] pik(int numArgsOut, Object max_iter)
    {
      return mcr.EvaluateFunction(numArgsOut, "pik", max_iter);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the pik M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// chainResult = chain;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] pik(int numArgsOut, Object max_iter, Object epsilon)
    {
      return mcr.EvaluateFunction(numArgsOut, "pik", max_iter, epsilon);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the pik M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// chainResult = chain;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <param name="chain">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] pik(int numArgsOut, Object max_iter, Object epsilon, Object chain)
    {
      return mcr.EvaluateFunction(numArgsOut, "pik", max_iter, epsilon, chain);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the pik M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// chainResult = chain;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <param name="chain">Input argument #3</param>
    /// <param name="goal">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] pik(int numArgsOut, Object max_iter, Object epsilon, Object chain, 
                  Object goal)
    {
      return mcr.EvaluateFunction(numArgsOut, "pik", max_iter, epsilon, chain, goal);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the pik M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// chainResult = chain;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <param name="chain">Input argument #3</param>
    /// <param name="goal">Input argument #4</param>
    /// <param name="particles">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] pik(int numArgsOut, Object max_iter, Object epsilon, Object chain, 
                  Object goal, Object particles)
    {
      return mcr.EvaluateFunction(numArgsOut, "pik", max_iter, epsilon, chain, goal, particles);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the pik M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// chainResult = chain;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <param name="chain">Input argument #3</param>
    /// <param name="goal">Input argument #4</param>
    /// <param name="particles">Input argument #5</param>
    /// <param name="S">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] pik(int numArgsOut, Object max_iter, Object epsilon, Object chain, 
                  Object goal, Object particles, Object S)
    {
      return mcr.EvaluateFunction(numArgsOut, "pik", max_iter, epsilon, chain, goal, particles, S);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the positions2chain
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Se asume que la primera posicion es el (0,0)
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object positions2chain()
    {
      return mcr.EvaluateFunction("positions2chain", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the positions2chain
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Se asume que la primera posicion es el (0,0)
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object positions2chain(Object x)
    {
      return mcr.EvaluateFunction("positions2chain", x);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the positions2chain
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Se asume que la primera posicion es el (0,0)
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object positions2chain(Object x, Object y)
    {
      return mcr.EvaluateFunction("positions2chain", x, y);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the positions2chain M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Se asume que la primera posicion es el (0,0)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] positions2chain(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "positions2chain", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the positions2chain M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Se asume que la primera posicion es el (0,0)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] positions2chain(int numArgsOut, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "positions2chain", x);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the positions2chain M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Se asume que la primera posicion es el (0,0)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] positions2chain(int numArgsOut, Object x, Object y)
    {
      return mcr.EvaluateFunction(numArgsOut, "positions2chain", x, y);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the PrtFltr_MkwskSum
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion es la que engloba los algoritmos de Filtro de Particulas
    /// y Suma de Minkowski. Como parámetros se le pasa:
    /// max_iter: Maximo de iteraciones que realizara el filtraje
    /// epsilon:  tolerancia de cercanía con el objetivo
    /// S:        el sistema de obstaculos
    /// x_axis:   posiciones en el eje x de la cadena en su posición "inicial" 
    /// y_axis:   posiciones en el eje y de la cadena en su posición "inicial" 
    /// obj:      objetivo intermedio 
    /// samples:  cantidad de particulas que se generaran
    /// media_gausiana: media para la generación de particulas (0.03)
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos, ordenados tomando como principio el que menos
    /// coordenada "y" tenga (menos "x") en caso de empate y siguiendo el orden
    /// inverso a a las manesillas del reloj
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PrtFltr_MkwskSum()
    {
      return mcr.EvaluateFunction("PrtFltr_MkwskSum", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the PrtFltr_MkwskSum
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion es la que engloba los algoritmos de Filtro de Particulas
    /// y Suma de Minkowski. Como parámetros se le pasa:
    /// max_iter: Maximo de iteraciones que realizara el filtraje
    /// epsilon:  tolerancia de cercanía con el objetivo
    /// S:        el sistema de obstaculos
    /// x_axis:   posiciones en el eje x de la cadena en su posición "inicial" 
    /// y_axis:   posiciones en el eje y de la cadena en su posición "inicial" 
    /// obj:      objetivo intermedio 
    /// samples:  cantidad de particulas que se generaran
    /// media_gausiana: media para la generación de particulas (0.03)
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos, ordenados tomando como principio el que menos
    /// coordenada "y" tenga (menos "x") en caso de empate y siguiendo el orden
    /// inverso a a las manesillas del reloj
    /// </remarks>
    /// <param name="max_iter">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PrtFltr_MkwskSum(Object max_iter)
    {
      return mcr.EvaluateFunction("PrtFltr_MkwskSum", max_iter);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the PrtFltr_MkwskSum
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion es la que engloba los algoritmos de Filtro de Particulas
    /// y Suma de Minkowski. Como parámetros se le pasa:
    /// max_iter: Maximo de iteraciones que realizara el filtraje
    /// epsilon:  tolerancia de cercanía con el objetivo
    /// S:        el sistema de obstaculos
    /// x_axis:   posiciones en el eje x de la cadena en su posición "inicial" 
    /// y_axis:   posiciones en el eje y de la cadena en su posición "inicial" 
    /// obj:      objetivo intermedio 
    /// samples:  cantidad de particulas que se generaran
    /// media_gausiana: media para la generación de particulas (0.03)
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos, ordenados tomando como principio el que menos
    /// coordenada "y" tenga (menos "x") en caso de empate y siguiendo el orden
    /// inverso a a las manesillas del reloj
    /// </remarks>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PrtFltr_MkwskSum(Object max_iter, Object epsilon)
    {
      return mcr.EvaluateFunction("PrtFltr_MkwskSum", max_iter, epsilon);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the PrtFltr_MkwskSum
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion es la que engloba los algoritmos de Filtro de Particulas
    /// y Suma de Minkowski. Como parámetros se le pasa:
    /// max_iter: Maximo de iteraciones que realizara el filtraje
    /// epsilon:  tolerancia de cercanía con el objetivo
    /// S:        el sistema de obstaculos
    /// x_axis:   posiciones en el eje x de la cadena en su posición "inicial" 
    /// y_axis:   posiciones en el eje y de la cadena en su posición "inicial" 
    /// obj:      objetivo intermedio 
    /// samples:  cantidad de particulas que se generaran
    /// media_gausiana: media para la generación de particulas (0.03)
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos, ordenados tomando como principio el que menos
    /// coordenada "y" tenga (menos "x") en caso de empate y siguiendo el orden
    /// inverso a a las manesillas del reloj
    /// </remarks>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <param name="obst_ranks">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PrtFltr_MkwskSum(Object max_iter, Object epsilon, Object obst_ranks)
    {
      return mcr.EvaluateFunction("PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the PrtFltr_MkwskSum
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion es la que engloba los algoritmos de Filtro de Particulas
    /// y Suma de Minkowski. Como parámetros se le pasa:
    /// max_iter: Maximo de iteraciones que realizara el filtraje
    /// epsilon:  tolerancia de cercanía con el objetivo
    /// S:        el sistema de obstaculos
    /// x_axis:   posiciones en el eje x de la cadena en su posición "inicial" 
    /// y_axis:   posiciones en el eje y de la cadena en su posición "inicial" 
    /// obj:      objetivo intermedio 
    /// samples:  cantidad de particulas que se generaran
    /// media_gausiana: media para la generación de particulas (0.03)
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos, ordenados tomando como principio el que menos
    /// coordenada "y" tenga (menos "x") en caso de empate y siguiendo el orden
    /// inverso a a las manesillas del reloj
    /// </remarks>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <param name="obst_ranks">Input argument #3</param>
    /// <param name="x_obst">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PrtFltr_MkwskSum(Object max_iter, Object epsilon, Object obst_ranks, 
                             Object x_obst)
    {
      return mcr.EvaluateFunction("PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the PrtFltr_MkwskSum
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion es la que engloba los algoritmos de Filtro de Particulas
    /// y Suma de Minkowski. Como parámetros se le pasa:
    /// max_iter: Maximo de iteraciones que realizara el filtraje
    /// epsilon:  tolerancia de cercanía con el objetivo
    /// S:        el sistema de obstaculos
    /// x_axis:   posiciones en el eje x de la cadena en su posición "inicial" 
    /// y_axis:   posiciones en el eje y de la cadena en su posición "inicial" 
    /// obj:      objetivo intermedio 
    /// samples:  cantidad de particulas que se generaran
    /// media_gausiana: media para la generación de particulas (0.03)
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos, ordenados tomando como principio el que menos
    /// coordenada "y" tenga (menos "x") en caso de empate y siguiendo el orden
    /// inverso a a las manesillas del reloj
    /// </remarks>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <param name="obst_ranks">Input argument #3</param>
    /// <param name="x_obst">Input argument #4</param>
    /// <param name="y_obst">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PrtFltr_MkwskSum(Object max_iter, Object epsilon, Object obst_ranks, 
                             Object x_obst, Object y_obst)
    {
      return mcr.EvaluateFunction("PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst, y_obst);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the PrtFltr_MkwskSum
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion es la que engloba los algoritmos de Filtro de Particulas
    /// y Suma de Minkowski. Como parámetros se le pasa:
    /// max_iter: Maximo de iteraciones que realizara el filtraje
    /// epsilon:  tolerancia de cercanía con el objetivo
    /// S:        el sistema de obstaculos
    /// x_axis:   posiciones en el eje x de la cadena en su posición "inicial" 
    /// y_axis:   posiciones en el eje y de la cadena en su posición "inicial" 
    /// obj:      objetivo intermedio 
    /// samples:  cantidad de particulas que se generaran
    /// media_gausiana: media para la generación de particulas (0.03)
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos, ordenados tomando como principio el que menos
    /// coordenada "y" tenga (menos "x") en caso de empate y siguiendo el orden
    /// inverso a a las manesillas del reloj
    /// </remarks>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <param name="obst_ranks">Input argument #3</param>
    /// <param name="x_obst">Input argument #4</param>
    /// <param name="y_obst">Input argument #5</param>
    /// <param name="x_axis">Input argument #6</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PrtFltr_MkwskSum(Object max_iter, Object epsilon, Object obst_ranks, 
                             Object x_obst, Object y_obst, Object x_axis)
    {
      return mcr.EvaluateFunction("PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst, y_obst, x_axis);
    }


    /// <summary>
    /// Provides a single output, 7-input Objectinterface to the PrtFltr_MkwskSum
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion es la que engloba los algoritmos de Filtro de Particulas
    /// y Suma de Minkowski. Como parámetros se le pasa:
    /// max_iter: Maximo de iteraciones que realizara el filtraje
    /// epsilon:  tolerancia de cercanía con el objetivo
    /// S:        el sistema de obstaculos
    /// x_axis:   posiciones en el eje x de la cadena en su posición "inicial" 
    /// y_axis:   posiciones en el eje y de la cadena en su posición "inicial" 
    /// obj:      objetivo intermedio 
    /// samples:  cantidad de particulas que se generaran
    /// media_gausiana: media para la generación de particulas (0.03)
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos, ordenados tomando como principio el que menos
    /// coordenada "y" tenga (menos "x") en caso de empate y siguiendo el orden
    /// inverso a a las manesillas del reloj
    /// </remarks>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <param name="obst_ranks">Input argument #3</param>
    /// <param name="x_obst">Input argument #4</param>
    /// <param name="y_obst">Input argument #5</param>
    /// <param name="x_axis">Input argument #6</param>
    /// <param name="y_axis">Input argument #7</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PrtFltr_MkwskSum(Object max_iter, Object epsilon, Object obst_ranks, 
                             Object x_obst, Object y_obst, Object x_axis, Object y_axis)
    {
      return mcr.EvaluateFunction("PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst, y_obst, x_axis, y_axis);
    }


    /// <summary>
    /// Provides a single output, 8-input Objectinterface to the PrtFltr_MkwskSum
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion es la que engloba los algoritmos de Filtro de Particulas
    /// y Suma de Minkowski. Como parámetros se le pasa:
    /// max_iter: Maximo de iteraciones que realizara el filtraje
    /// epsilon:  tolerancia de cercanía con el objetivo
    /// S:        el sistema de obstaculos
    /// x_axis:   posiciones en el eje x de la cadena en su posición "inicial" 
    /// y_axis:   posiciones en el eje y de la cadena en su posición "inicial" 
    /// obj:      objetivo intermedio 
    /// samples:  cantidad de particulas que se generaran
    /// media_gausiana: media para la generación de particulas (0.03)
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos, ordenados tomando como principio el que menos
    /// coordenada "y" tenga (menos "x") en caso de empate y siguiendo el orden
    /// inverso a a las manesillas del reloj
    /// </remarks>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <param name="obst_ranks">Input argument #3</param>
    /// <param name="x_obst">Input argument #4</param>
    /// <param name="y_obst">Input argument #5</param>
    /// <param name="x_axis">Input argument #6</param>
    /// <param name="y_axis">Input argument #7</param>
    /// <param name="obj">Input argument #8</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PrtFltr_MkwskSum(Object max_iter, Object epsilon, Object obst_ranks, 
                             Object x_obst, Object y_obst, Object x_axis, Object y_axis, 
                             Object obj)
    {
      return mcr.EvaluateFunction("PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst, y_obst, x_axis, y_axis, obj);
    }


    /// <summary>
    /// Provides a single output, 9-input Objectinterface to the PrtFltr_MkwskSum
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion es la que engloba los algoritmos de Filtro de Particulas
    /// y Suma de Minkowski. Como parámetros se le pasa:
    /// max_iter: Maximo de iteraciones que realizara el filtraje
    /// epsilon:  tolerancia de cercanía con el objetivo
    /// S:        el sistema de obstaculos
    /// x_axis:   posiciones en el eje x de la cadena en su posición "inicial" 
    /// y_axis:   posiciones en el eje y de la cadena en su posición "inicial" 
    /// obj:      objetivo intermedio 
    /// samples:  cantidad de particulas que se generaran
    /// media_gausiana: media para la generación de particulas (0.03)
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos, ordenados tomando como principio el que menos
    /// coordenada "y" tenga (menos "x") en caso de empate y siguiendo el orden
    /// inverso a a las manesillas del reloj
    /// </remarks>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <param name="obst_ranks">Input argument #3</param>
    /// <param name="x_obst">Input argument #4</param>
    /// <param name="y_obst">Input argument #5</param>
    /// <param name="x_axis">Input argument #6</param>
    /// <param name="y_axis">Input argument #7</param>
    /// <param name="obj">Input argument #8</param>
    /// <param name="samples">Input argument #9</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PrtFltr_MkwskSum(Object max_iter, Object epsilon, Object obst_ranks, 
                             Object x_obst, Object y_obst, Object x_axis, Object y_axis, 
                             Object obj, Object samples)
    {
      return mcr.EvaluateFunction("PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst, y_obst, x_axis, y_axis, obj, samples);
    }


    /// <summary>
    /// Provides a single output, 10-input Objectinterface to the PrtFltr_MkwskSum
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion es la que engloba los algoritmos de Filtro de Particulas
    /// y Suma de Minkowski. Como parámetros se le pasa:
    /// max_iter: Maximo de iteraciones que realizara el filtraje
    /// epsilon:  tolerancia de cercanía con el objetivo
    /// S:        el sistema de obstaculos
    /// x_axis:   posiciones en el eje x de la cadena en su posición "inicial" 
    /// y_axis:   posiciones en el eje y de la cadena en su posición "inicial" 
    /// obj:      objetivo intermedio 
    /// samples:  cantidad de particulas que se generaran
    /// media_gausiana: media para la generación de particulas (0.03)
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos, ordenados tomando como principio el que menos
    /// coordenada "y" tenga (menos "x") en caso de empate y siguiendo el orden
    /// inverso a a las manesillas del reloj
    /// </remarks>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <param name="obst_ranks">Input argument #3</param>
    /// <param name="x_obst">Input argument #4</param>
    /// <param name="y_obst">Input argument #5</param>
    /// <param name="x_axis">Input argument #6</param>
    /// <param name="y_axis">Input argument #7</param>
    /// <param name="obj">Input argument #8</param>
    /// <param name="samples">Input argument #9</param>
    /// <param name="media_gausiana">Input argument #10</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PrtFltr_MkwskSum(Object max_iter, Object epsilon, Object obst_ranks, 
                             Object x_obst, Object y_obst, Object x_axis, Object y_axis, 
                             Object obj, Object samples, Object media_gausiana)
    {
      return mcr.EvaluateFunction("PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst, y_obst, x_axis, y_axis, obj, samples, media_gausiana);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the PrtFltr_MkwskSum
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion es la que engloba los algoritmos de Filtro de Particulas
    /// y Suma de Minkowski. Como parámetros se le pasa:
    /// max_iter: Maximo de iteraciones que realizara el filtraje
    /// epsilon:  tolerancia de cercanía con el objetivo
    /// S:        el sistema de obstaculos
    /// x_axis:   posiciones en el eje x de la cadena en su posición "inicial" 
    /// y_axis:   posiciones en el eje y de la cadena en su posición "inicial" 
    /// obj:      objetivo intermedio 
    /// samples:  cantidad de particulas que se generaran
    /// media_gausiana: media para la generación de particulas (0.03)
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos, ordenados tomando como principio el que menos
    /// coordenada "y" tenga (menos "x") en caso de empate y siguiendo el orden
    /// inverso a a las manesillas del reloj
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PrtFltr_MkwskSum(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "PrtFltr_MkwskSum", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the PrtFltr_MkwskSum
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion es la que engloba los algoritmos de Filtro de Particulas
    /// y Suma de Minkowski. Como parámetros se le pasa:
    /// max_iter: Maximo de iteraciones que realizara el filtraje
    /// epsilon:  tolerancia de cercanía con el objetivo
    /// S:        el sistema de obstaculos
    /// x_axis:   posiciones en el eje x de la cadena en su posición "inicial" 
    /// y_axis:   posiciones en el eje y de la cadena en su posición "inicial" 
    /// obj:      objetivo intermedio 
    /// samples:  cantidad de particulas que se generaran
    /// media_gausiana: media para la generación de particulas (0.03)
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos, ordenados tomando como principio el que menos
    /// coordenada "y" tenga (menos "x") en caso de empate y siguiendo el orden
    /// inverso a a las manesillas del reloj
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="max_iter">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PrtFltr_MkwskSum(int numArgsOut, Object max_iter)
    {
      return mcr.EvaluateFunction(numArgsOut, "PrtFltr_MkwskSum", max_iter);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the PrtFltr_MkwskSum
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion es la que engloba los algoritmos de Filtro de Particulas
    /// y Suma de Minkowski. Como parámetros se le pasa:
    /// max_iter: Maximo de iteraciones que realizara el filtraje
    /// epsilon:  tolerancia de cercanía con el objetivo
    /// S:        el sistema de obstaculos
    /// x_axis:   posiciones en el eje x de la cadena en su posición "inicial" 
    /// y_axis:   posiciones en el eje y de la cadena en su posición "inicial" 
    /// obj:      objetivo intermedio 
    /// samples:  cantidad de particulas que se generaran
    /// media_gausiana: media para la generación de particulas (0.03)
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos, ordenados tomando como principio el que menos
    /// coordenada "y" tenga (menos "x") en caso de empate y siguiendo el orden
    /// inverso a a las manesillas del reloj
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PrtFltr_MkwskSum(int numArgsOut, Object max_iter, Object epsilon)
    {
      return mcr.EvaluateFunction(numArgsOut, "PrtFltr_MkwskSum", max_iter, epsilon);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the PrtFltr_MkwskSum
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion es la que engloba los algoritmos de Filtro de Particulas
    /// y Suma de Minkowski. Como parámetros se le pasa:
    /// max_iter: Maximo de iteraciones que realizara el filtraje
    /// epsilon:  tolerancia de cercanía con el objetivo
    /// S:        el sistema de obstaculos
    /// x_axis:   posiciones en el eje x de la cadena en su posición "inicial" 
    /// y_axis:   posiciones en el eje y de la cadena en su posición "inicial" 
    /// obj:      objetivo intermedio 
    /// samples:  cantidad de particulas que se generaran
    /// media_gausiana: media para la generación de particulas (0.03)
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos, ordenados tomando como principio el que menos
    /// coordenada "y" tenga (menos "x") en caso de empate y siguiendo el orden
    /// inverso a a las manesillas del reloj
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <param name="obst_ranks">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PrtFltr_MkwskSum(int numArgsOut, Object max_iter, Object epsilon, 
                               Object obst_ranks)
    {
      return mcr.EvaluateFunction(numArgsOut, "PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the PrtFltr_MkwskSum
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion es la que engloba los algoritmos de Filtro de Particulas
    /// y Suma de Minkowski. Como parámetros se le pasa:
    /// max_iter: Maximo de iteraciones que realizara el filtraje
    /// epsilon:  tolerancia de cercanía con el objetivo
    /// S:        el sistema de obstaculos
    /// x_axis:   posiciones en el eje x de la cadena en su posición "inicial" 
    /// y_axis:   posiciones en el eje y de la cadena en su posición "inicial" 
    /// obj:      objetivo intermedio 
    /// samples:  cantidad de particulas que se generaran
    /// media_gausiana: media para la generación de particulas (0.03)
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos, ordenados tomando como principio el que menos
    /// coordenada "y" tenga (menos "x") en caso de empate y siguiendo el orden
    /// inverso a a las manesillas del reloj
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <param name="obst_ranks">Input argument #3</param>
    /// <param name="x_obst">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PrtFltr_MkwskSum(int numArgsOut, Object max_iter, Object epsilon, 
                               Object obst_ranks, Object x_obst)
    {
      return mcr.EvaluateFunction(numArgsOut, "PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the PrtFltr_MkwskSum
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion es la que engloba los algoritmos de Filtro de Particulas
    /// y Suma de Minkowski. Como parámetros se le pasa:
    /// max_iter: Maximo de iteraciones que realizara el filtraje
    /// epsilon:  tolerancia de cercanía con el objetivo
    /// S:        el sistema de obstaculos
    /// x_axis:   posiciones en el eje x de la cadena en su posición "inicial" 
    /// y_axis:   posiciones en el eje y de la cadena en su posición "inicial" 
    /// obj:      objetivo intermedio 
    /// samples:  cantidad de particulas que se generaran
    /// media_gausiana: media para la generación de particulas (0.03)
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos, ordenados tomando como principio el que menos
    /// coordenada "y" tenga (menos "x") en caso de empate y siguiendo el orden
    /// inverso a a las manesillas del reloj
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <param name="obst_ranks">Input argument #3</param>
    /// <param name="x_obst">Input argument #4</param>
    /// <param name="y_obst">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PrtFltr_MkwskSum(int numArgsOut, Object max_iter, Object epsilon, 
                               Object obst_ranks, Object x_obst, Object y_obst)
    {
      return mcr.EvaluateFunction(numArgsOut, "PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst, y_obst);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the PrtFltr_MkwskSum
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion es la que engloba los algoritmos de Filtro de Particulas
    /// y Suma de Minkowski. Como parámetros se le pasa:
    /// max_iter: Maximo de iteraciones que realizara el filtraje
    /// epsilon:  tolerancia de cercanía con el objetivo
    /// S:        el sistema de obstaculos
    /// x_axis:   posiciones en el eje x de la cadena en su posición "inicial" 
    /// y_axis:   posiciones en el eje y de la cadena en su posición "inicial" 
    /// obj:      objetivo intermedio 
    /// samples:  cantidad de particulas que se generaran
    /// media_gausiana: media para la generación de particulas (0.03)
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos, ordenados tomando como principio el que menos
    /// coordenada "y" tenga (menos "x") en caso de empate y siguiendo el orden
    /// inverso a a las manesillas del reloj
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <param name="obst_ranks">Input argument #3</param>
    /// <param name="x_obst">Input argument #4</param>
    /// <param name="y_obst">Input argument #5</param>
    /// <param name="x_axis">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PrtFltr_MkwskSum(int numArgsOut, Object max_iter, Object epsilon, 
                               Object obst_ranks, Object x_obst, Object y_obst, Object 
                               x_axis)
    {
      return mcr.EvaluateFunction(numArgsOut, "PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst, y_obst, x_axis);
    }


    /// <summary>
    /// Provides the standard 7-input Object interface to the PrtFltr_MkwskSum
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion es la que engloba los algoritmos de Filtro de Particulas
    /// y Suma de Minkowski. Como parámetros se le pasa:
    /// max_iter: Maximo de iteraciones que realizara el filtraje
    /// epsilon:  tolerancia de cercanía con el objetivo
    /// S:        el sistema de obstaculos
    /// x_axis:   posiciones en el eje x de la cadena en su posición "inicial" 
    /// y_axis:   posiciones en el eje y de la cadena en su posición "inicial" 
    /// obj:      objetivo intermedio 
    /// samples:  cantidad de particulas que se generaran
    /// media_gausiana: media para la generación de particulas (0.03)
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos, ordenados tomando como principio el que menos
    /// coordenada "y" tenga (menos "x") en caso de empate y siguiendo el orden
    /// inverso a a las manesillas del reloj
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <param name="obst_ranks">Input argument #3</param>
    /// <param name="x_obst">Input argument #4</param>
    /// <param name="y_obst">Input argument #5</param>
    /// <param name="x_axis">Input argument #6</param>
    /// <param name="y_axis">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PrtFltr_MkwskSum(int numArgsOut, Object max_iter, Object epsilon, 
                               Object obst_ranks, Object x_obst, Object y_obst, Object 
                               x_axis, Object y_axis)
    {
      return mcr.EvaluateFunction(numArgsOut, "PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst, y_obst, x_axis, y_axis);
    }


    /// <summary>
    /// Provides the standard 8-input Object interface to the PrtFltr_MkwskSum
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion es la que engloba los algoritmos de Filtro de Particulas
    /// y Suma de Minkowski. Como parámetros se le pasa:
    /// max_iter: Maximo de iteraciones que realizara el filtraje
    /// epsilon:  tolerancia de cercanía con el objetivo
    /// S:        el sistema de obstaculos
    /// x_axis:   posiciones en el eje x de la cadena en su posición "inicial" 
    /// y_axis:   posiciones en el eje y de la cadena en su posición "inicial" 
    /// obj:      objetivo intermedio 
    /// samples:  cantidad de particulas que se generaran
    /// media_gausiana: media para la generación de particulas (0.03)
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos, ordenados tomando como principio el que menos
    /// coordenada "y" tenga (menos "x") en caso de empate y siguiendo el orden
    /// inverso a a las manesillas del reloj
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <param name="obst_ranks">Input argument #3</param>
    /// <param name="x_obst">Input argument #4</param>
    /// <param name="y_obst">Input argument #5</param>
    /// <param name="x_axis">Input argument #6</param>
    /// <param name="y_axis">Input argument #7</param>
    /// <param name="obj">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PrtFltr_MkwskSum(int numArgsOut, Object max_iter, Object epsilon, 
                               Object obst_ranks, Object x_obst, Object y_obst, Object 
                               x_axis, Object y_axis, Object obj)
    {
      return mcr.EvaluateFunction(numArgsOut, "PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst, y_obst, x_axis, y_axis, obj);
    }


    /// <summary>
    /// Provides the standard 9-input Object interface to the PrtFltr_MkwskSum
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion es la que engloba los algoritmos de Filtro de Particulas
    /// y Suma de Minkowski. Como parámetros se le pasa:
    /// max_iter: Maximo de iteraciones que realizara el filtraje
    /// epsilon:  tolerancia de cercanía con el objetivo
    /// S:        el sistema de obstaculos
    /// x_axis:   posiciones en el eje x de la cadena en su posición "inicial" 
    /// y_axis:   posiciones en el eje y de la cadena en su posición "inicial" 
    /// obj:      objetivo intermedio 
    /// samples:  cantidad de particulas que se generaran
    /// media_gausiana: media para la generación de particulas (0.03)
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos, ordenados tomando como principio el que menos
    /// coordenada "y" tenga (menos "x") en caso de empate y siguiendo el orden
    /// inverso a a las manesillas del reloj
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <param name="obst_ranks">Input argument #3</param>
    /// <param name="x_obst">Input argument #4</param>
    /// <param name="y_obst">Input argument #5</param>
    /// <param name="x_axis">Input argument #6</param>
    /// <param name="y_axis">Input argument #7</param>
    /// <param name="obj">Input argument #8</param>
    /// <param name="samples">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PrtFltr_MkwskSum(int numArgsOut, Object max_iter, Object epsilon, 
                               Object obst_ranks, Object x_obst, Object y_obst, Object 
                               x_axis, Object y_axis, Object obj, Object samples)
    {
      return mcr.EvaluateFunction(numArgsOut, "PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst, y_obst, x_axis, y_axis, obj, samples);
    }


    /// <summary>
    /// Provides the standard 10-input Object interface to the PrtFltr_MkwskSum
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion es la que engloba los algoritmos de Filtro de Particulas
    /// y Suma de Minkowski. Como parámetros se le pasa:
    /// max_iter: Maximo de iteraciones que realizara el filtraje
    /// epsilon:  tolerancia de cercanía con el objetivo
    /// S:        el sistema de obstaculos
    /// x_axis:   posiciones en el eje x de la cadena en su posición "inicial" 
    /// y_axis:   posiciones en el eje y de la cadena en su posición "inicial" 
    /// obj:      objetivo intermedio 
    /// samples:  cantidad de particulas que se generaran
    /// media_gausiana: media para la generación de particulas (0.03)
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos, ordenados tomando como principio el que menos
    /// coordenada "y" tenga (menos "x") en caso de empate y siguiendo el orden
    /// inverso a a las manesillas del reloj
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <param name="obst_ranks">Input argument #3</param>
    /// <param name="x_obst">Input argument #4</param>
    /// <param name="y_obst">Input argument #5</param>
    /// <param name="x_axis">Input argument #6</param>
    /// <param name="y_axis">Input argument #7</param>
    /// <param name="obj">Input argument #8</param>
    /// <param name="samples">Input argument #9</param>
    /// <param name="media_gausiana">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PrtFltr_MkwskSum(int numArgsOut, Object max_iter, Object epsilon, 
                               Object obst_ranks, Object x_obst, Object y_obst, Object 
                               x_axis, Object y_axis, Object obj, Object samples, Object 
                               media_gausiana)
    {
      return mcr.EvaluateFunction(numArgsOut, "PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst, y_obst, x_axis, y_axis, obj, samples, media_gausiana);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the quaternion M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// TODO: Tal vegada s'hauria de fer un get i set per quaternion. Per ara ho
    /// deixam aixÃ­.
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object quaternion()
    {
      return mcr.EvaluateFunction("quaternion", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the quaternion M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// TODO: Tal vegada s'hauria de fer un get i set per quaternion. Per ara ho
    /// deixam aixÃ­.
    /// </remarks>
    /// <param name="s">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object quaternion(Object s)
    {
      return mcr.EvaluateFunction("quaternion", s);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the quaternion M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// TODO: Tal vegada s'hauria de fer un get i set per quaternion. Per ara ho
    /// deixam aixÃ­.
    /// </remarks>
    /// <param name="s">Input argument #1</param>
    /// <param name="p">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object quaternion(Object s, Object p)
    {
      return mcr.EvaluateFunction("quaternion", s, p);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the quaternion M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// TODO: Tal vegada s'hauria de fer un get i set per quaternion. Per ara ho
    /// deixam aixÃ­.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] quaternion(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternion", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the quaternion M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// TODO: Tal vegada s'hauria de fer un get i set per quaternion. Per ara ho
    /// deixam aixÃ­.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="s">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] quaternion(int numArgsOut, Object s)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternion", s);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the quaternion M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// TODO: Tal vegada s'hauria de fer un get i set per quaternion. Per ara ho
    /// deixam aixÃ­.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="s">Input argument #1</param>
    /// <param name="p">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] quaternion(int numArgsOut, Object s, Object p)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternion", s, p);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the quaternionConjugate
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object quaternionConjugate()
    {
      return mcr.EvaluateFunction("quaternionConjugate", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the quaternionConjugate
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="q">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object quaternionConjugate(Object q)
    {
      return mcr.EvaluateFunction("quaternionConjugate", q);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the quaternionConjugate
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] quaternionConjugate(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionConjugate", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the quaternionConjugate
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="q">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] quaternionConjugate(int numArgsOut, Object q)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionConjugate", q);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the quaternionExponentialMap
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object quaternionExponentialMap()
    {
      return mcr.EvaluateFunction("quaternionExponentialMap", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the quaternionExponentialMap
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="p">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object quaternionExponentialMap(Object p)
    {
      return mcr.EvaluateFunction("quaternionExponentialMap", p);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the quaternionExponentialMap
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] quaternionExponentialMap(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionExponentialMap", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the quaternionExponentialMap
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="p">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] quaternionExponentialMap(int numArgsOut, Object p)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionExponentialMap", p);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the quaternionProduct
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// x = q1(2) * q2(1)  + q1(3) * q2(4) - q1(4) * q2(3) + q1(1) * q2(2);
    /// y = -q1(2) * q2(4) + q1(3) * q2(1) + q1(4) * q2(2) + q1(1) * q2(3);
    /// z = q1(2) * q2(3)  - q1(3) * q2(2) + q1(4) * q2(1) + q1(1) * q2(4);
    /// s = -q1(2) * q2(2) - q1(3) * q2(3) - q1(4) * q2(4) + q1(1) * q2(1);
    /// q=[s,x,y,z];</remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object quaternionProduct()
    {
      return mcr.EvaluateFunction("quaternionProduct", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the quaternionProduct
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// x = q1(2) * q2(1)  + q1(3) * q2(4) - q1(4) * q2(3) + q1(1) * q2(2);
    /// y = -q1(2) * q2(4) + q1(3) * q2(1) + q1(4) * q2(2) + q1(1) * q2(3);
    /// z = q1(2) * q2(3)  - q1(3) * q2(2) + q1(4) * q2(1) + q1(1) * q2(4);
    /// s = -q1(2) * q2(2) - q1(3) * q2(3) - q1(4) * q2(4) + q1(1) * q2(1);
    /// q=[s,x,y,z];</remarks>
    /// <param name="q1">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object quaternionProduct(Object q1)
    {
      return mcr.EvaluateFunction("quaternionProduct", q1);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the quaternionProduct
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// x = q1(2) * q2(1)  + q1(3) * q2(4) - q1(4) * q2(3) + q1(1) * q2(2);
    /// y = -q1(2) * q2(4) + q1(3) * q2(1) + q1(4) * q2(2) + q1(1) * q2(3);
    /// z = q1(2) * q2(3)  - q1(3) * q2(2) + q1(4) * q2(1) + q1(1) * q2(4);
    /// s = -q1(2) * q2(2) - q1(3) * q2(3) - q1(4) * q2(4) + q1(1) * q2(1);
    /// q=[s,x,y,z];</remarks>
    /// <param name="q1">Input argument #1</param>
    /// <param name="q2">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object quaternionProduct(Object q1, Object q2)
    {
      return mcr.EvaluateFunction("quaternionProduct", q1, q2);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the quaternionProduct
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// x = q1(2) * q2(1)  + q1(3) * q2(4) - q1(4) * q2(3) + q1(1) * q2(2);
    /// y = -q1(2) * q2(4) + q1(3) * q2(1) + q1(4) * q2(2) + q1(1) * q2(3);
    /// z = q1(2) * q2(3)  - q1(3) * q2(2) + q1(4) * q2(1) + q1(1) * q2(4);
    /// s = -q1(2) * q2(2) - q1(3) * q2(3) - q1(4) * q2(4) + q1(1) * q2(1);
    /// q=[s,x,y,z];</remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] quaternionProduct(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionProduct", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the quaternionProduct
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// x = q1(2) * q2(1)  + q1(3) * q2(4) - q1(4) * q2(3) + q1(1) * q2(2);
    /// y = -q1(2) * q2(4) + q1(3) * q2(1) + q1(4) * q2(2) + q1(1) * q2(3);
    /// z = q1(2) * q2(3)  - q1(3) * q2(2) + q1(4) * q2(1) + q1(1) * q2(4);
    /// s = -q1(2) * q2(2) - q1(3) * q2(3) - q1(4) * q2(4) + q1(1) * q2(1);
    /// q=[s,x,y,z];</remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="q1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] quaternionProduct(int numArgsOut, Object q1)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionProduct", q1);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the quaternionProduct
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// x = q1(2) * q2(1)  + q1(3) * q2(4) - q1(4) * q2(3) + q1(1) * q2(2);
    /// y = -q1(2) * q2(4) + q1(3) * q2(1) + q1(4) * q2(2) + q1(1) * q2(3);
    /// z = q1(2) * q2(3)  - q1(3) * q2(2) + q1(4) * q2(1) + q1(1) * q2(4);
    /// s = -q1(2) * q2(2) - q1(3) * q2(3) - q1(4) * q2(4) + q1(1) * q2(1);
    /// q=[s,x,y,z];</remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="q1">Input argument #1</param>
    /// <param name="q2">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] quaternionProduct(int numArgsOut, Object q1, Object q2)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionProduct", q1, q2);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the quaternionQuTEMSampling
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// s1=s2=s3 =>uniform Sampling
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object quaternionQuTEMSampling()
    {
      return mcr.EvaluateFunction("quaternionQuTEMSampling", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the quaternionQuTEMSampling
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// s1=s2=s3 =>uniform Sampling
    /// </remarks>
    /// <param name="m">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object quaternionQuTEMSampling(Object m)
    {
      return mcr.EvaluateFunction("quaternionQuTEMSampling", m);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the quaternionQuTEMSampling
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// s1=s2=s3 =>uniform Sampling
    /// </remarks>
    /// <param name="m">Input argument #1</param>
    /// <param name="pg">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object quaternionQuTEMSampling(Object m, Object pg)
    {
      return mcr.EvaluateFunction("quaternionQuTEMSampling", m, pg);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the quaternionQuTEMSampling
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// s1=s2=s3 =>uniform Sampling
    /// </remarks>
    /// <param name="m">Input argument #1</param>
    /// <param name="pg">Input argument #2</param>
    /// <param name="samples">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object quaternionQuTEMSampling(Object m, Object pg, Object samples)
    {
      return mcr.EvaluateFunction("quaternionQuTEMSampling", m, pg, samples);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the quaternionQuTEMSampling
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// s1=s2=s3 =>uniform Sampling
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] quaternionQuTEMSampling(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionQuTEMSampling", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the quaternionQuTEMSampling
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// s1=s2=s3 =>uniform Sampling
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="m">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] quaternionQuTEMSampling(int numArgsOut, Object m)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionQuTEMSampling", m);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the quaternionQuTEMSampling
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// s1=s2=s3 =>uniform Sampling
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="m">Input argument #1</param>
    /// <param name="pg">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] quaternionQuTEMSampling(int numArgsOut, Object m, Object pg)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionQuTEMSampling", m, pg);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the quaternionQuTEMSampling
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// s1=s2=s3 =>uniform Sampling
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="m">Input argument #1</param>
    /// <param name="pg">Input argument #2</param>
    /// <param name="samples">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] quaternionQuTEMSampling(int numArgsOut, Object m, Object pg, Object 
                                      samples)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionQuTEMSampling", m, pg, samples);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the quaternionRotation
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Create vector of quaternion point
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object quaternionRotation()
    {
      return mcr.EvaluateFunction("quaternionRotation", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the quaternionRotation
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Create vector of quaternion point
    /// </remarks>
    /// <param name="vector">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object quaternionRotation(Object vector)
    {
      return mcr.EvaluateFunction("quaternionRotation", vector);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the quaternionRotation
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Create vector of quaternion point
    /// </remarks>
    /// <param name="vector">Input argument #1</param>
    /// <param name="quaternion">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object quaternionRotation(Object vector, Object quaternion)
    {
      return mcr.EvaluateFunction("quaternionRotation", vector, quaternion);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the quaternionRotation
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Create vector of quaternion point
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] quaternionRotation(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionRotation", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the quaternionRotation
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Create vector of quaternion point
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="vector">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] quaternionRotation(int numArgsOut, Object vector)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionRotation", vector);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the quaternionRotation
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Create vector of quaternion point
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="vector">Input argument #1</param>
    /// <param name="quaternion">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] quaternionRotation(int numArgsOut, Object vector, Object quaternion)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionRotation", vector, quaternion);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the remostrejar M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// r
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object remostrejar()
    {
      return mcr.EvaluateFunction("remostrejar", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the remostrejar M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// r
    /// </remarks>
    /// <param name="particles">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object remostrejar(Object particles)
    {
      return mcr.EvaluateFunction("remostrejar", particles);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the remostrejar M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// r
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] remostrejar(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "remostrejar", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the remostrejar M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// r
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="particles">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] remostrejar(int numArgsOut, Object particles)
    {
      return mcr.EvaluateFunction(numArgsOut, "remostrejar", particles);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the S_Touch M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos 
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object S_Touch()
    {
      return mcr.EvaluateFunction("S_Touch", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the S_Touch M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos 
    /// </remarks>
    /// <param name="chain">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object S_Touch(Object chain)
    {
      return mcr.EvaluateFunction("S_Touch", chain);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the S_Touch M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos 
    /// </remarks>
    /// <param name="chain">Input argument #1</param>
    /// <param name="S">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object S_Touch(Object chain, Object S)
    {
      return mcr.EvaluateFunction("S_Touch", chain, S);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the S_Touch M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] S_Touch(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "S_Touch", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the S_Touch M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="chain">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] S_Touch(int numArgsOut, Object chain)
    {
      return mcr.EvaluateFunction(numArgsOut, "S_Touch", chain);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the S_Touch M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="chain">Input argument #1</param>
    /// <param name="S">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] S_Touch(int numArgsOut, Object chain, Object S)
    {
      return mcr.EvaluateFunction(numArgsOut, "S_Touch", chain, S);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the setGaussianParameters
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object setGaussianParameters()
    {
      return mcr.EvaluateFunction("setGaussianParameters", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the setGaussianParameters
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="media_gausiana">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object setGaussianParameters(Object media_gausiana)
    {
      return mcr.EvaluateFunction("setGaussianParameters", media_gausiana);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the setGaussianParameters
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="media_gausiana">Input argument #1</param>
    /// <param name="rotar_en_x">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object setGaussianParameters(Object media_gausiana, Object rotar_en_x)
    {
      return mcr.EvaluateFunction("setGaussianParameters", media_gausiana, rotar_en_x);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the setGaussianParameters
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="media_gausiana">Input argument #1</param>
    /// <param name="rotar_en_x">Input argument #2</param>
    /// <param name="rotar_en_y">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object setGaussianParameters(Object media_gausiana, Object rotar_en_x, Object 
                                  rotar_en_y)
    {
      return mcr.EvaluateFunction("setGaussianParameters", media_gausiana, rotar_en_x, rotar_en_y);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the setGaussianParameters
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="media_gausiana">Input argument #1</param>
    /// <param name="rotar_en_x">Input argument #2</param>
    /// <param name="rotar_en_y">Input argument #3</param>
    /// <param name="rotar_en_z">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object setGaussianParameters(Object media_gausiana, Object rotar_en_x, Object 
                                  rotar_en_y, Object rotar_en_z)
    {
      return mcr.EvaluateFunction("setGaussianParameters", media_gausiana, rotar_en_x, rotar_en_y, rotar_en_z);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the setGaussianParameters
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] setGaussianParameters(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "setGaussianParameters", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the setGaussianParameters
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="media_gausiana">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] setGaussianParameters(int numArgsOut, Object media_gausiana)
    {
      return mcr.EvaluateFunction(numArgsOut, "setGaussianParameters", media_gausiana);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the setGaussianParameters
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="media_gausiana">Input argument #1</param>
    /// <param name="rotar_en_x">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] setGaussianParameters(int numArgsOut, Object media_gausiana, Object 
                                    rotar_en_x)
    {
      return mcr.EvaluateFunction(numArgsOut, "setGaussianParameters", media_gausiana, rotar_en_x);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the setGaussianParameters
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="media_gausiana">Input argument #1</param>
    /// <param name="rotar_en_x">Input argument #2</param>
    /// <param name="rotar_en_y">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] setGaussianParameters(int numArgsOut, Object media_gausiana, Object 
                                    rotar_en_x, Object rotar_en_y)
    {
      return mcr.EvaluateFunction(numArgsOut, "setGaussianParameters", media_gausiana, rotar_en_x, rotar_en_y);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the setGaussianParameters
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="media_gausiana">Input argument #1</param>
    /// <param name="rotar_en_x">Input argument #2</param>
    /// <param name="rotar_en_y">Input argument #3</param>
    /// <param name="rotar_en_z">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] setGaussianParameters(int numArgsOut, Object media_gausiana, Object 
                                    rotar_en_x, Object rotar_en_y, Object rotar_en_z)
    {
      return mcr.EvaluateFunction(numArgsOut, "setGaussianParameters", media_gausiana, rotar_en_x, rotar_en_y, rotar_en_z);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the weightFunction
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// euclideanDistance
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object weightFunction()
    {
      return mcr.EvaluateFunction("weightFunction", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the weightFunction
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// euclideanDistance
    /// </remarks>
    /// <param name="chain">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object weightFunction(Object chain)
    {
      return mcr.EvaluateFunction("weightFunction", chain);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the weightFunction
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// euclideanDistance
    /// </remarks>
    /// <param name="chain">Input argument #1</param>
    /// <param name="goal">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object weightFunction(Object chain, Object goal)
    {
      return mcr.EvaluateFunction("weightFunction", chain, goal);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the weightFunction
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// euclideanDistance
    /// </remarks>
    /// <param name="chain">Input argument #1</param>
    /// <param name="goal">Input argument #2</param>
    /// <param name="S">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object weightFunction(Object chain, Object goal, Object S)
    {
      return mcr.EvaluateFunction("weightFunction", chain, goal, S);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the weightFunction M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// euclideanDistance
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] weightFunction(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "weightFunction", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the weightFunction M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// euclideanDistance
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="chain">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] weightFunction(int numArgsOut, Object chain)
    {
      return mcr.EvaluateFunction(numArgsOut, "weightFunction", chain);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the weightFunction M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// euclideanDistance
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="chain">Input argument #1</param>
    /// <param name="goal">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] weightFunction(int numArgsOut, Object chain, Object goal)
    {
      return mcr.EvaluateFunction(numArgsOut, "weightFunction", chain, goal);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the weightFunction M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// euclideanDistance
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="chain">Input argument #1</param>
    /// <param name="goal">Input argument #2</param>
    /// <param name="S">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] weightFunction(int numArgsOut, Object chain, Object goal, Object S)
    {
      return mcr.EvaluateFunction(numArgsOut, "weightFunction", chain, goal, S);
    }


    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
