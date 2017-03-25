/*
* MATLAB Compiler: 4.14 (R2010b)
* Date: Mon Oct 31 18:27:37 2011
* Arguments: "-B" "macro_default" "-W"
* "dotnet:MATLAB_ParticleFilter,MatlabParticleFilter_v2,0.0,private" "-T" "link:lib" "-d"
* "D:\Proyecto de Tesis [ultimo]\Matlab_ParticleFilter\MATLAB_ParticleFilter\src" "-w"
* "enable:specified_file_mismatch" "-w" "enable:repeated_file" "-w"
* "enable:switch_ignored" "-w" "enable:missing_lib_sentinel" "-w" "enable:demo_license"
* "-v" "class{MatlabParticleFilter_v2:D:\Proyecto de Tesis
* [ultimo]\Matlab_ParticleFilter\angulo.m,D:\Proyecto de Tesis
* [ultimo]\Matlab_ParticleFilter\chain2positions.m,D:\Proyecto de Tesis
* [ultimo]\Matlab_ParticleFilter\chainEndEffectorPosition.m,D:\Proyecto de Tesis
* [ultimo]\Matlab_ParticleFilter\chainQuTEMSampling.m,D:\Proyecto de Tesis
* [ultimo]\Matlab_ParticleFilter\createChain.m,D:\Proyecto de Tesis
* [ultimo]\Matlab_ParticleFilter\createParticle.m,D:\Proyecto de Tesis
* [ultimo]\Matlab_ParticleFilter\dentro.m,D:\Proyecto de Tesis
* [ultimo]\Matlab_ParticleFilter\euclidianDistance.m,D:\Proyecto de Tesis
* [ultimo]\Matlab_ParticleFilter\evalua_recta.m,D:\Proyecto de Tesis
* [ultimo]\Matlab_ParticleFilter\mas.m,D:\Proyecto de Tesis
* [ultimo]\Matlab_ParticleFilter\obstaculo_crecido.m,D:\Proyecto de Tesis
* [ultimo]\Matlab_ParticleFilter\PF.m,D:\Proyecto de Tesis
* [ultimo]\Matlab_ParticleFilter\pik.m,D:\Proyecto de Tesis
* [ultimo]\Matlab_ParticleFilter\positions2chain.m,D:\Proyecto de Tesis
* [ultimo]\Matlab_ParticleFilter\PrtFltr_MkwskSum.m,D:\Proyecto de Tesis
* [ultimo]\Matlab_ParticleFilter\quaternion.m,D:\Proyecto de Tesis
* [ultimo]\Matlab_ParticleFilter\quaternionConjugate.m,D:\Proyecto de Tesis
* [ultimo]\Matlab_ParticleFilter\quaternionExponentialMap.m,D:\Proyecto de Tesis
* [ultimo]\Matlab_ParticleFilter\quaternionProduct.m,D:\Proyecto de Tesis
* [ultimo]\Matlab_ParticleFilter\quaternionQuTEMSampling.m,D:\Proyecto de Tesis
* [ultimo]\Matlab_ParticleFilter\quaternionRotation.m,D:\Proyecto de Tesis
* [ultimo]\Matlab_ParticleFilter\remostrejar.m,D:\Proyecto de Tesis
* [ultimo]\Matlab_ParticleFilter\S_Touch.m,D:\Proyecto de Tesis
* [ultimo]\Matlab_ParticleFilter\setGaussianParameters.m,D:\Proyecto de Tesis
* [ultimo]\Matlab_ParticleFilter\weightFunction.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace MATLAB_ParticleFilter
{
  /// <summary>
  /// The MatlabParticleFilter_v2 class provides a CLS compliant, MWArray interface to
  /// the M-functions contained in the files:
  /// <newpara></newpara>
  /// D:\Proyecto de Tesis [ultimo]\Matlab_ParticleFilter\angulo.m
  /// <newpara></newpara>
  /// D:\Proyecto de Tesis [ultimo]\Matlab_ParticleFilter\chain2positions.m
  /// <newpara></newpara>
  /// D:\Proyecto de Tesis [ultimo]\Matlab_ParticleFilter\chainEndEffectorPosition.m
  /// <newpara></newpara>
  /// D:\Proyecto de Tesis [ultimo]\Matlab_ParticleFilter\chainQuTEMSampling.m
  /// <newpara></newpara>
  /// D:\Proyecto de Tesis [ultimo]\Matlab_ParticleFilter\createChain.m
  /// <newpara></newpara>
  /// D:\Proyecto de Tesis [ultimo]\Matlab_ParticleFilter\createParticle.m
  /// <newpara></newpara>
  /// D:\Proyecto de Tesis [ultimo]\Matlab_ParticleFilter\dentro.m
  /// <newpara></newpara>
  /// D:\Proyecto de Tesis [ultimo]\Matlab_ParticleFilter\euclidianDistance.m
  /// <newpara></newpara>
  /// D:\Proyecto de Tesis [ultimo]\Matlab_ParticleFilter\evalua_recta.m
  /// <newpara></newpara>
  /// D:\Proyecto de Tesis [ultimo]\Matlab_ParticleFilter\mas.m
  /// <newpara></newpara>
  /// D:\Proyecto de Tesis [ultimo]\Matlab_ParticleFilter\obstaculo_crecido.m
  /// <newpara></newpara>
  /// D:\Proyecto de Tesis [ultimo]\Matlab_ParticleFilter\PF.m
  /// <newpara></newpara>
  /// D:\Proyecto de Tesis [ultimo]\Matlab_ParticleFilter\pik.m
  /// <newpara></newpara>
  /// D:\Proyecto de Tesis [ultimo]\Matlab_ParticleFilter\positions2chain.m
  /// <newpara></newpara>
  /// D:\Proyecto de Tesis [ultimo]\Matlab_ParticleFilter\PrtFltr_MkwskSum.m
  /// <newpara></newpara>
  /// D:\Proyecto de Tesis [ultimo]\Matlab_ParticleFilter\quaternion.m
  /// <newpara></newpara>
  /// D:\Proyecto de Tesis [ultimo]\Matlab_ParticleFilter\quaternionConjugate.m
  /// <newpara></newpara>
  /// D:\Proyecto de Tesis [ultimo]\Matlab_ParticleFilter\quaternionExponentialMap.m
  /// <newpara></newpara>
  /// D:\Proyecto de Tesis [ultimo]\Matlab_ParticleFilter\quaternionProduct.m
  /// <newpara></newpara>
  /// D:\Proyecto de Tesis [ultimo]\Matlab_ParticleFilter\quaternionQuTEMSampling.m
  /// <newpara></newpara>
  /// D:\Proyecto de Tesis [ultimo]\Matlab_ParticleFilter\quaternionRotation.m
  /// <newpara></newpara>
  /// D:\Proyecto de Tesis [ultimo]\Matlab_ParticleFilter\remostrejar.m
  /// <newpara></newpara>
  /// D:\Proyecto de Tesis [ultimo]\Matlab_ParticleFilter\S_Touch.m
  /// <newpara></newpara>
  /// D:\Proyecto de Tesis [ultimo]\Matlab_ParticleFilter\setGaussianParameters.m
  /// <newpara></newpara>
  /// D:\Proyecto de Tesis [ultimo]\Matlab_ParticleFilter\weightFunction.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class MatlabParticleFilter_v2 : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static MatlabParticleFilter_v2()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = "MATLAB_ParticleFilter.ctf";

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
    /// Constructs a new instance of the MatlabParticleFilter_v2 class.
    /// </summary>
    public MatlabParticleFilter_v2()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~MatlabParticleFilter_v2()
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
    /// Provides a single output, 0-input MWArrayinterface to the angulo M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray angulo()
    {
      return mcr.EvaluateFunction("angulo", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the angulo M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="p1">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray angulo(MWArray p1)
    {
      return mcr.EvaluateFunction("angulo", p1);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the angulo M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="p1">Input argument #1</param>
    /// <param name="p2">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray angulo(MWArray p1, MWArray p2)
    {
      return mcr.EvaluateFunction("angulo", p1, p2);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the angulo M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="p1">Input argument #1</param>
    /// <param name="p2">Input argument #2</param>
    /// <param name="antan">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray angulo(MWArray p1, MWArray p2, MWArray antan)
    {
      return mcr.EvaluateFunction("angulo", p1, p2, antan);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the angulo M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] angulo(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "angulo", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the angulo M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="p1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] angulo(int numArgsOut, MWArray p1)
    {
      return mcr.EvaluateFunction(numArgsOut, "angulo", p1);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the angulo M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="p1">Input argument #1</param>
    /// <param name="p2">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] angulo(int numArgsOut, MWArray p1, MWArray p2)
    {
      return mcr.EvaluateFunction(numArgsOut, "angulo", p1, p2);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the angulo M-function.
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
    public MWArray[] angulo(int numArgsOut, MWArray p1, MWArray p2, MWArray antan)
    {
      return mcr.EvaluateFunction(numArgsOut, "angulo", p1, p2, antan);
    }


    /// <summary>
    /// Provides an interface for the angulo function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void angulo(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("angulo", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the chain2positions
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// TODO: Valid for matrix</remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray chain2positions()
    {
      return mcr.EvaluateFunction("chain2positions", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the chain2positions
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// TODO: Valid for matrix</remarks>
    /// <param name="chain">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray chain2positions(MWArray chain)
    {
      return mcr.EvaluateFunction("chain2positions", chain);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the chain2positions
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// TODO: Valid for matrix</remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] chain2positions(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "chain2positions", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the chain2positions
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// TODO: Valid for matrix</remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="chain">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] chain2positions(int numArgsOut, MWArray chain)
    {
      return mcr.EvaluateFunction(numArgsOut, "chain2positions", chain);
    }


    /// <summary>
    /// Provides an interface for the chain2positions function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// TODO: Valid for matrix</remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void chain2positions(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("chain2positions", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the
    /// chainEndEffectorPosition M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray chainEndEffectorPosition()
    {
      return mcr.EvaluateFunction("chainEndEffectorPosition", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the
    /// chainEndEffectorPosition M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="chain">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray chainEndEffectorPosition(MWArray chain)
    {
      return mcr.EvaluateFunction("chainEndEffectorPosition", chain);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the chainEndEffectorPosition
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] chainEndEffectorPosition(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "chainEndEffectorPosition", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the chainEndEffectorPosition
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="chain">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] chainEndEffectorPosition(int numArgsOut, MWArray chain)
    {
      return mcr.EvaluateFunction(numArgsOut, "chainEndEffectorPosition", chain);
    }


    /// <summary>
    /// Provides an interface for the chainEndEffectorPosition function in which the
    /// input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void chainEndEffectorPosition(int numArgsOut, ref MWArray[] argsOut, MWArray[] 
                               argsIn)
    {
      mcr.EvaluateFunction("chainEndEffectorPosition", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the chainQuTEMSampling
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray chainQuTEMSampling()
    {
      return mcr.EvaluateFunction("chainQuTEMSampling", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the chainQuTEMSampling
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="g">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray chainQuTEMSampling(MWArray g)
    {
      return mcr.EvaluateFunction("chainQuTEMSampling", g);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the chainQuTEMSampling
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="g">Input argument #1</param>
    /// <param name="chain">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray chainQuTEMSampling(MWArray g, MWArray chain)
    {
      return mcr.EvaluateFunction("chainQuTEMSampling", g, chain);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the chainQuTEMSampling
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] chainQuTEMSampling(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "chainQuTEMSampling", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the chainQuTEMSampling
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="g">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] chainQuTEMSampling(int numArgsOut, MWArray g)
    {
      return mcr.EvaluateFunction(numArgsOut, "chainQuTEMSampling", g);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the chainQuTEMSampling
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
    public MWArray[] chainQuTEMSampling(int numArgsOut, MWArray g, MWArray chain)
    {
      return mcr.EvaluateFunction(numArgsOut, "chainQuTEMSampling", g, chain);
    }


    /// <summary>
    /// Provides an interface for the chainQuTEMSampling function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void chainQuTEMSampling(int numArgsOut, ref MWArray[] argsOut, MWArray[] 
                         argsIn)
    {
      mcr.EvaluateFunction("chainQuTEMSampling", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the createChain M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray createChain()
    {
      return mcr.EvaluateFunction("createChain", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the createChain M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="vectores_canonicos">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray createChain(MWArray vectores_canonicos)
    {
      return mcr.EvaluateFunction("createChain", vectores_canonicos);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the createChain M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] createChain(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "createChain", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the createChain M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="vectores_canonicos">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] createChain(int numArgsOut, MWArray vectores_canonicos)
    {
      return mcr.EvaluateFunction(numArgsOut, "createChain", vectores_canonicos);
    }


    /// <summary>
    /// Provides an interface for the createChain function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void createChain(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("createChain", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the createParticle
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray createParticle()
    {
      return mcr.EvaluateFunction("createParticle", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the createParticle
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="chain">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray createParticle(MWArray chain)
    {
      return mcr.EvaluateFunction("createParticle", chain);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the createParticle
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="chain">Input argument #1</param>
    /// <param name="samples">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray createParticle(MWArray chain, MWArray samples)
    {
      return mcr.EvaluateFunction("createParticle", chain, samples);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the createParticle
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="chain">Input argument #1</param>
    /// <param name="samples">Input argument #2</param>
    /// <param name="pg">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray createParticle(MWArray chain, MWArray samples, MWArray pg)
    {
      return mcr.EvaluateFunction("createParticle", chain, samples, pg);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the createParticle
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="chain">Input argument #1</param>
    /// <param name="samples">Input argument #2</param>
    /// <param name="pg">Input argument #3</param>
    /// <param name="equal">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray createParticle(MWArray chain, MWArray samples, MWArray pg, MWArray 
                            equal)
    {
      return mcr.EvaluateFunction("createParticle", chain, samples, pg, equal);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the createParticle M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] createParticle(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "createParticle", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the createParticle M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="chain">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] createParticle(int numArgsOut, MWArray chain)
    {
      return mcr.EvaluateFunction(numArgsOut, "createParticle", chain);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the createParticle M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="chain">Input argument #1</param>
    /// <param name="samples">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] createParticle(int numArgsOut, MWArray chain, MWArray samples)
    {
      return mcr.EvaluateFunction(numArgsOut, "createParticle", chain, samples);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the createParticle M-function.
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
    public MWArray[] createParticle(int numArgsOut, MWArray chain, MWArray samples, 
                              MWArray pg)
    {
      return mcr.EvaluateFunction(numArgsOut, "createParticle", chain, samples, pg);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the createParticle M-function.
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
    public MWArray[] createParticle(int numArgsOut, MWArray chain, MWArray samples, 
                              MWArray pg, MWArray equal)
    {
      return mcr.EvaluateFunction(numArgsOut, "createParticle", chain, samples, pg, equal);
    }


    /// <summary>
    /// Provides an interface for the createParticle function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void createParticle(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("createParticle", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the dentro M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion nos dir'a si un punto est'a dentro de un poligono (convexo)
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray dentro()
    {
      return mcr.EvaluateFunction("dentro", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the dentro M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion nos dir'a si un punto est'a dentro de un poligono (convexo)
    /// </remarks>
    /// <param name="P">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray dentro(MWArray P)
    {
      return mcr.EvaluateFunction("dentro", P);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the dentro M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion nos dir'a si un punto est'a dentro de un poligono (convexo)
    /// </remarks>
    /// <param name="P">Input argument #1</param>
    /// <param name="p">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray dentro(MWArray P, MWArray p)
    {
      return mcr.EvaluateFunction("dentro", P, p);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the dentro M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta funcion nos dir'a si un punto est'a dentro de un poligono (convexo)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] dentro(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "dentro", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the dentro M-function.
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
    public MWArray[] dentro(int numArgsOut, MWArray P)
    {
      return mcr.EvaluateFunction(numArgsOut, "dentro", P);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the dentro M-function.
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
    public MWArray[] dentro(int numArgsOut, MWArray P, MWArray p)
    {
      return mcr.EvaluateFunction(numArgsOut, "dentro", P, p);
    }


    /// <summary>
    /// Provides an interface for the dentro function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Esta funcion nos dir'a si un punto est'a dentro de un poligono (convexo)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void dentro(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("dentro", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the euclidianDistance
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray euclidianDistance()
    {
      return mcr.EvaluateFunction("euclidianDistance", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the euclidianDistance
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="p1">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray euclidianDistance(MWArray p1)
    {
      return mcr.EvaluateFunction("euclidianDistance", p1);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the euclidianDistance
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="p1">Input argument #1</param>
    /// <param name="p2">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray euclidianDistance(MWArray p1, MWArray p2)
    {
      return mcr.EvaluateFunction("euclidianDistance", p1, p2);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the euclidianDistance
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] euclidianDistance(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "euclidianDistance", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the euclidianDistance
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="p1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] euclidianDistance(int numArgsOut, MWArray p1)
    {
      return mcr.EvaluateFunction(numArgsOut, "euclidianDistance", p1);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the euclidianDistance
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
    public MWArray[] euclidianDistance(int numArgsOut, MWArray p1, MWArray p2)
    {
      return mcr.EvaluateFunction(numArgsOut, "euclidianDistance", p1, p2);
    }


    /// <summary>
    /// Provides an interface for the euclidianDistance function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void euclidianDistance(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("euclidianDistance", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the evalua_recta
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Calculo de la ecuación d ela recta
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray evalua_recta()
    {
      return mcr.EvaluateFunction("evalua_recta", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the evalua_recta
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Calculo de la ecuación d ela recta
    /// </remarks>
    /// <param name="r">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray evalua_recta(MWArray r)
    {
      return mcr.EvaluateFunction("evalua_recta", r);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the evalua_recta
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Calculo de la ecuación d ela recta
    /// </remarks>
    /// <param name="r">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray evalua_recta(MWArray r, MWArray x)
    {
      return mcr.EvaluateFunction("evalua_recta", r, x);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the evalua_recta M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Calculo de la ecuación d ela recta
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] evalua_recta(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "evalua_recta", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the evalua_recta M-function.
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
    public MWArray[] evalua_recta(int numArgsOut, MWArray r)
    {
      return mcr.EvaluateFunction(numArgsOut, "evalua_recta", r);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the evalua_recta M-function.
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
    public MWArray[] evalua_recta(int numArgsOut, MWArray r, MWArray x)
    {
      return mcr.EvaluateFunction(numArgsOut, "evalua_recta", r, x);
    }


    /// <summary>
    /// Provides an interface for the evalua_recta function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Calculo de la ecuación d ela recta
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void evalua_recta(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("evalua_recta", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the mas M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Retorna la suma vectorial de dos puntos
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mas()
    {
      return mcr.EvaluateFunction("mas", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the mas M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Retorna la suma vectorial de dos puntos
    /// </remarks>
    /// <param name="p1">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mas(MWArray p1)
    {
      return mcr.EvaluateFunction("mas", p1);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the mas M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Retorna la suma vectorial de dos puntos
    /// </remarks>
    /// <param name="p1">Input argument #1</param>
    /// <param name="p2">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mas(MWArray p1, MWArray p2)
    {
      return mcr.EvaluateFunction("mas", p1, p2);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the mas M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Retorna la suma vectorial de dos puntos
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mas(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "mas", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the mas M-function.
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
    public MWArray[] mas(int numArgsOut, MWArray p1)
    {
      return mcr.EvaluateFunction(numArgsOut, "mas", p1);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the mas M-function.
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
    public MWArray[] mas(int numArgsOut, MWArray p1, MWArray p2)
    {
      return mcr.EvaluateFunction(numArgsOut, "mas", p1, p2);
    }


    /// <summary>
    /// Provides an interface for the mas function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Retorna la suma vectorial de dos puntos
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void mas(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("mas", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the obstaculo_crecido
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta función calcula espacio prohibido de configuraciones de un brazo
    /// mecanico representado por el segmento "a". El resultado es una lista de
    /// puntos que representan el obstáculo crecido: "RmasP"
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray obstaculo_crecido()
    {
      return mcr.EvaluateFunction("obstaculo_crecido", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the obstaculo_crecido
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Esta función calcula espacio prohibido de configuraciones de un brazo
    /// mecanico representado por el segmento "a". El resultado es una lista de
    /// puntos que representan el obstáculo crecido: "RmasP"
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray obstaculo_crecido(MWArray a)
    {
      return mcr.EvaluateFunction("obstaculo_crecido", a);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the obstaculo_crecido
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray obstaculo_crecido(MWArray a, MWArray L_puntos)
    {
      return mcr.EvaluateFunction("obstaculo_crecido", a, L_puntos);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the obstaculo_crecido
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
    public MWArray[] obstaculo_crecido(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "obstaculo_crecido", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the obstaculo_crecido
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
    public MWArray[] obstaculo_crecido(int numArgsOut, MWArray a)
    {
      return mcr.EvaluateFunction(numArgsOut, "obstaculo_crecido", a);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the obstaculo_crecido
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
    public MWArray[] obstaculo_crecido(int numArgsOut, MWArray a, MWArray L_puntos)
    {
      return mcr.EvaluateFunction(numArgsOut, "obstaculo_crecido", a, L_puntos);
    }


    /// <summary>
    /// Provides an interface for the obstaculo_crecido function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Esta función calcula espacio prohibido de configuraciones de un brazo
    /// mecanico representado por el segmento "a". El resultado es una lista de
    /// puntos que representan el obstáculo crecido: "RmasP"
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void obstaculo_crecido(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("obstaculo_crecido", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the PF M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// sampling
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PF()
    {
      return mcr.EvaluateFunction("PF", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the PF M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// sampling
    /// </remarks>
    /// <param name="goal">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PF(MWArray goal)
    {
      return mcr.EvaluateFunction("PF", goal);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the PF M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// sampling
    /// </remarks>
    /// <param name="goal">Input argument #1</param>
    /// <param name="particles">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PF(MWArray goal, MWArray particles)
    {
      return mcr.EvaluateFunction("PF", goal, particles);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the PF M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// sampling
    /// </remarks>
    /// <param name="goal">Input argument #1</param>
    /// <param name="particles">Input argument #2</param>
    /// <param name="S">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PF(MWArray goal, MWArray particles, MWArray S)
    {
      return mcr.EvaluateFunction("PF", goal, particles, S);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the PF M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// sampling
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PF(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "PF", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the PF M-function.
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
    public MWArray[] PF(int numArgsOut, MWArray goal)
    {
      return mcr.EvaluateFunction(numArgsOut, "PF", goal);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the PF M-function.
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
    public MWArray[] PF(int numArgsOut, MWArray goal, MWArray particles)
    {
      return mcr.EvaluateFunction(numArgsOut, "PF", goal, particles);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the PF M-function.
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
    public MWArray[] PF(int numArgsOut, MWArray goal, MWArray particles, MWArray S)
    {
      return mcr.EvaluateFunction(numArgsOut, "PF", goal, particles, S);
    }


    /// <summary>
    /// Provides an interface for the PF function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// sampling
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void PF(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("PF", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the pik M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// chainResult = chain;
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray pik()
    {
      return mcr.EvaluateFunction("pik", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the pik M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// chainResult = chain;
    /// </remarks>
    /// <param name="max_iter">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray pik(MWArray max_iter)
    {
      return mcr.EvaluateFunction("pik", max_iter);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the pik M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// chainResult = chain;
    /// </remarks>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray pik(MWArray max_iter, MWArray epsilon)
    {
      return mcr.EvaluateFunction("pik", max_iter, epsilon);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the pik M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// chainResult = chain;
    /// </remarks>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <param name="chain">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray pik(MWArray max_iter, MWArray epsilon, MWArray chain)
    {
      return mcr.EvaluateFunction("pik", max_iter, epsilon, chain);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the pik M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// chainResult = chain;
    /// </remarks>
    /// <param name="max_iter">Input argument #1</param>
    /// <param name="epsilon">Input argument #2</param>
    /// <param name="chain">Input argument #3</param>
    /// <param name="goal">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray pik(MWArray max_iter, MWArray epsilon, MWArray chain, MWArray goal)
    {
      return mcr.EvaluateFunction("pik", max_iter, epsilon, chain, goal);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the pik M-function.
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray pik(MWArray max_iter, MWArray epsilon, MWArray chain, MWArray goal, 
                 MWArray particles)
    {
      return mcr.EvaluateFunction("pik", max_iter, epsilon, chain, goal, particles);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the pik M-function.
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray pik(MWArray max_iter, MWArray epsilon, MWArray chain, MWArray goal, 
                 MWArray particles, MWArray S)
    {
      return mcr.EvaluateFunction("pik", max_iter, epsilon, chain, goal, particles, S);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the pik M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// chainResult = chain;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] pik(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "pik", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the pik M-function.
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
    public MWArray[] pik(int numArgsOut, MWArray max_iter)
    {
      return mcr.EvaluateFunction(numArgsOut, "pik", max_iter);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the pik M-function.
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
    public MWArray[] pik(int numArgsOut, MWArray max_iter, MWArray epsilon)
    {
      return mcr.EvaluateFunction(numArgsOut, "pik", max_iter, epsilon);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the pik M-function.
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
    public MWArray[] pik(int numArgsOut, MWArray max_iter, MWArray epsilon, MWArray chain)
    {
      return mcr.EvaluateFunction(numArgsOut, "pik", max_iter, epsilon, chain);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the pik M-function.
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
    public MWArray[] pik(int numArgsOut, MWArray max_iter, MWArray epsilon, MWArray 
                   chain, MWArray goal)
    {
      return mcr.EvaluateFunction(numArgsOut, "pik", max_iter, epsilon, chain, goal);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the pik M-function.
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
    public MWArray[] pik(int numArgsOut, MWArray max_iter, MWArray epsilon, MWArray 
                   chain, MWArray goal, MWArray particles)
    {
      return mcr.EvaluateFunction(numArgsOut, "pik", max_iter, epsilon, chain, goal, particles);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the pik M-function.
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
    public MWArray[] pik(int numArgsOut, MWArray max_iter, MWArray epsilon, MWArray 
                   chain, MWArray goal, MWArray particles, MWArray S)
    {
      return mcr.EvaluateFunction(numArgsOut, "pik", max_iter, epsilon, chain, goal, particles, S);
    }


    /// <summary>
    /// Provides an interface for the pik function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// chainResult = chain;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void pik(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("pik", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the positions2chain
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Se asume que la primera posicion es el (0,0)
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray positions2chain()
    {
      return mcr.EvaluateFunction("positions2chain", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the positions2chain
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Se asume que la primera posicion es el (0,0)
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray positions2chain(MWArray x)
    {
      return mcr.EvaluateFunction("positions2chain", x);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the positions2chain
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Se asume que la primera posicion es el (0,0)
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray positions2chain(MWArray x, MWArray y)
    {
      return mcr.EvaluateFunction("positions2chain", x, y);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the positions2chain
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Se asume que la primera posicion es el (0,0)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] positions2chain(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "positions2chain", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the positions2chain
    /// M-function.
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
    public MWArray[] positions2chain(int numArgsOut, MWArray x)
    {
      return mcr.EvaluateFunction(numArgsOut, "positions2chain", x);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the positions2chain
    /// M-function.
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
    public MWArray[] positions2chain(int numArgsOut, MWArray x, MWArray y)
    {
      return mcr.EvaluateFunction(numArgsOut, "positions2chain", x, y);
    }


    /// <summary>
    /// Provides an interface for the positions2chain function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Se asume que la primera posicion es el (0,0)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void positions2chain(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("positions2chain", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the PrtFltr_MkwskSum
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PrtFltr_MkwskSum()
    {
      return mcr.EvaluateFunction("PrtFltr_MkwskSum", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the PrtFltr_MkwskSum
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PrtFltr_MkwskSum(MWArray max_iter)
    {
      return mcr.EvaluateFunction("PrtFltr_MkwskSum", max_iter);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the PrtFltr_MkwskSum
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PrtFltr_MkwskSum(MWArray max_iter, MWArray epsilon)
    {
      return mcr.EvaluateFunction("PrtFltr_MkwskSum", max_iter, epsilon);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the PrtFltr_MkwskSum
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PrtFltr_MkwskSum(MWArray max_iter, MWArray epsilon, MWArray obst_ranks)
    {
      return mcr.EvaluateFunction("PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the PrtFltr_MkwskSum
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PrtFltr_MkwskSum(MWArray max_iter, MWArray epsilon, MWArray 
                              obst_ranks, MWArray x_obst)
    {
      return mcr.EvaluateFunction("PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the PrtFltr_MkwskSum
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PrtFltr_MkwskSum(MWArray max_iter, MWArray epsilon, MWArray 
                              obst_ranks, MWArray x_obst, MWArray y_obst)
    {
      return mcr.EvaluateFunction("PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst, y_obst);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the PrtFltr_MkwskSum
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PrtFltr_MkwskSum(MWArray max_iter, MWArray epsilon, MWArray 
                              obst_ranks, MWArray x_obst, MWArray y_obst, MWArray x_axis)
    {
      return mcr.EvaluateFunction("PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst, y_obst, x_axis);
    }


    /// <summary>
    /// Provides a single output, 7-input MWArrayinterface to the PrtFltr_MkwskSum
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PrtFltr_MkwskSum(MWArray max_iter, MWArray epsilon, MWArray 
                              obst_ranks, MWArray x_obst, MWArray y_obst, MWArray x_axis, 
                              MWArray y_axis)
    {
      return mcr.EvaluateFunction("PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst, y_obst, x_axis, y_axis);
    }


    /// <summary>
    /// Provides a single output, 8-input MWArrayinterface to the PrtFltr_MkwskSum
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PrtFltr_MkwskSum(MWArray max_iter, MWArray epsilon, MWArray 
                              obst_ranks, MWArray x_obst, MWArray y_obst, MWArray x_axis, 
                              MWArray y_axis, MWArray obj)
    {
      return mcr.EvaluateFunction("PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst, y_obst, x_axis, y_axis, obj);
    }


    /// <summary>
    /// Provides a single output, 9-input MWArrayinterface to the PrtFltr_MkwskSum
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PrtFltr_MkwskSum(MWArray max_iter, MWArray epsilon, MWArray 
                              obst_ranks, MWArray x_obst, MWArray y_obst, MWArray x_axis, 
                              MWArray y_axis, MWArray obj, MWArray samples)
    {
      return mcr.EvaluateFunction("PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst, y_obst, x_axis, y_axis, obj, samples);
    }


    /// <summary>
    /// Provides a single output, 10-input MWArrayinterface to the PrtFltr_MkwskSum
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PrtFltr_MkwskSum(MWArray max_iter, MWArray epsilon, MWArray 
                              obst_ranks, MWArray x_obst, MWArray y_obst, MWArray x_axis, 
                              MWArray y_axis, MWArray obj, MWArray samples, MWArray 
                              media_gausiana)
    {
      return mcr.EvaluateFunction("PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst, y_obst, x_axis, y_axis, obj, samples, media_gausiana);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the PrtFltr_MkwskSum
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
    public MWArray[] PrtFltr_MkwskSum(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "PrtFltr_MkwskSum", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the PrtFltr_MkwskSum
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
    public MWArray[] PrtFltr_MkwskSum(int numArgsOut, MWArray max_iter)
    {
      return mcr.EvaluateFunction(numArgsOut, "PrtFltr_MkwskSum", max_iter);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the PrtFltr_MkwskSum
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
    public MWArray[] PrtFltr_MkwskSum(int numArgsOut, MWArray max_iter, MWArray epsilon)
    {
      return mcr.EvaluateFunction(numArgsOut, "PrtFltr_MkwskSum", max_iter, epsilon);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the PrtFltr_MkwskSum
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
    public MWArray[] PrtFltr_MkwskSum(int numArgsOut, MWArray max_iter, MWArray epsilon, 
                                MWArray obst_ranks)
    {
      return mcr.EvaluateFunction(numArgsOut, "PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the PrtFltr_MkwskSum
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
    public MWArray[] PrtFltr_MkwskSum(int numArgsOut, MWArray max_iter, MWArray epsilon, 
                                MWArray obst_ranks, MWArray x_obst)
    {
      return mcr.EvaluateFunction(numArgsOut, "PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the PrtFltr_MkwskSum
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
    public MWArray[] PrtFltr_MkwskSum(int numArgsOut, MWArray max_iter, MWArray epsilon, 
                                MWArray obst_ranks, MWArray x_obst, MWArray y_obst)
    {
      return mcr.EvaluateFunction(numArgsOut, "PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst, y_obst);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the PrtFltr_MkwskSum
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
    public MWArray[] PrtFltr_MkwskSum(int numArgsOut, MWArray max_iter, MWArray epsilon, 
                                MWArray obst_ranks, MWArray x_obst, MWArray y_obst, 
                                MWArray x_axis)
    {
      return mcr.EvaluateFunction(numArgsOut, "PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst, y_obst, x_axis);
    }


    /// <summary>
    /// Provides the standard 7-input MWArray interface to the PrtFltr_MkwskSum
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
    public MWArray[] PrtFltr_MkwskSum(int numArgsOut, MWArray max_iter, MWArray epsilon, 
                                MWArray obst_ranks, MWArray x_obst, MWArray y_obst, 
                                MWArray x_axis, MWArray y_axis)
    {
      return mcr.EvaluateFunction(numArgsOut, "PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst, y_obst, x_axis, y_axis);
    }


    /// <summary>
    /// Provides the standard 8-input MWArray interface to the PrtFltr_MkwskSum
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
    public MWArray[] PrtFltr_MkwskSum(int numArgsOut, MWArray max_iter, MWArray epsilon, 
                                MWArray obst_ranks, MWArray x_obst, MWArray y_obst, 
                                MWArray x_axis, MWArray y_axis, MWArray obj)
    {
      return mcr.EvaluateFunction(numArgsOut, "PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst, y_obst, x_axis, y_axis, obj);
    }


    /// <summary>
    /// Provides the standard 9-input MWArray interface to the PrtFltr_MkwskSum
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
    public MWArray[] PrtFltr_MkwskSum(int numArgsOut, MWArray max_iter, MWArray epsilon, 
                                MWArray obst_ranks, MWArray x_obst, MWArray y_obst, 
                                MWArray x_axis, MWArray y_axis, MWArray obj, MWArray 
                                samples)
    {
      return mcr.EvaluateFunction(numArgsOut, "PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst, y_obst, x_axis, y_axis, obj, samples);
    }


    /// <summary>
    /// Provides the standard 10-input MWArray interface to the PrtFltr_MkwskSum
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
    public MWArray[] PrtFltr_MkwskSum(int numArgsOut, MWArray max_iter, MWArray epsilon, 
                                MWArray obst_ranks, MWArray x_obst, MWArray y_obst, 
                                MWArray x_axis, MWArray y_axis, MWArray obj, MWArray 
                                samples, MWArray media_gausiana)
    {
      return mcr.EvaluateFunction(numArgsOut, "PrtFltr_MkwskSum", max_iter, epsilon, obst_ranks, x_obst, y_obst, x_axis, y_axis, obj, samples, media_gausiana);
    }


    /// <summary>
    /// Provides an interface for the PrtFltr_MkwskSum function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
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
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void PrtFltr_MkwskSum(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("PrtFltr_MkwskSum", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the quaternion M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// TODO: Tal vegada s'hauria de fer un get i set per quaternion. Per ara ho
    /// deixam aixÃ­.
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray quaternion()
    {
      return mcr.EvaluateFunction("quaternion", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the quaternion M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// TODO: Tal vegada s'hauria de fer un get i set per quaternion. Per ara ho
    /// deixam aixÃ­.
    /// </remarks>
    /// <param name="s">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray quaternion(MWArray s)
    {
      return mcr.EvaluateFunction("quaternion", s);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the quaternion M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// TODO: Tal vegada s'hauria de fer un get i set per quaternion. Per ara ho
    /// deixam aixÃ­.
    /// </remarks>
    /// <param name="s">Input argument #1</param>
    /// <param name="p">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray quaternion(MWArray s, MWArray p)
    {
      return mcr.EvaluateFunction("quaternion", s, p);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the quaternion M-function.
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
    public MWArray[] quaternion(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternion", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the quaternion M-function.
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
    public MWArray[] quaternion(int numArgsOut, MWArray s)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternion", s);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the quaternion M-function.
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
    public MWArray[] quaternion(int numArgsOut, MWArray s, MWArray p)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternion", s, p);
    }


    /// <summary>
    /// Provides an interface for the quaternion function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// TODO: Tal vegada s'hauria de fer un get i set per quaternion. Per ara ho
    /// deixam aixÃ­.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void quaternion(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("quaternion", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the quaternionConjugate
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray quaternionConjugate()
    {
      return mcr.EvaluateFunction("quaternionConjugate", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the quaternionConjugate
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="q">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray quaternionConjugate(MWArray q)
    {
      return mcr.EvaluateFunction("quaternionConjugate", q);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the quaternionConjugate
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] quaternionConjugate(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionConjugate", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the quaternionConjugate
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="q">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] quaternionConjugate(int numArgsOut, MWArray q)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionConjugate", q);
    }


    /// <summary>
    /// Provides an interface for the quaternionConjugate function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void quaternionConjugate(int numArgsOut, ref MWArray[] argsOut, MWArray[] 
                          argsIn)
    {
      mcr.EvaluateFunction("quaternionConjugate", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the
    /// quaternionExponentialMap M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray quaternionExponentialMap()
    {
      return mcr.EvaluateFunction("quaternionExponentialMap", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the
    /// quaternionExponentialMap M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="p">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray quaternionExponentialMap(MWArray p)
    {
      return mcr.EvaluateFunction("quaternionExponentialMap", p);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the quaternionExponentialMap
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] quaternionExponentialMap(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionExponentialMap", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the quaternionExponentialMap
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="p">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] quaternionExponentialMap(int numArgsOut, MWArray p)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionExponentialMap", p);
    }


    /// <summary>
    /// Provides an interface for the quaternionExponentialMap function in which the
    /// input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void quaternionExponentialMap(int numArgsOut, ref MWArray[] argsOut, MWArray[] 
                               argsIn)
    {
      mcr.EvaluateFunction("quaternionExponentialMap", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the quaternionProduct
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// x = q1(2) * q2(1)  + q1(3) * q2(4) - q1(4) * q2(3) + q1(1) * q2(2);
    /// y = -q1(2) * q2(4) + q1(3) * q2(1) + q1(4) * q2(2) + q1(1) * q2(3);
    /// z = q1(2) * q2(3)  - q1(3) * q2(2) + q1(4) * q2(1) + q1(1) * q2(4);
    /// s = -q1(2) * q2(2) - q1(3) * q2(3) - q1(4) * q2(4) + q1(1) * q2(1);
    /// q=[s,x,y,z];</remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray quaternionProduct()
    {
      return mcr.EvaluateFunction("quaternionProduct", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the quaternionProduct
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray quaternionProduct(MWArray q1)
    {
      return mcr.EvaluateFunction("quaternionProduct", q1);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the quaternionProduct
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray quaternionProduct(MWArray q1, MWArray q2)
    {
      return mcr.EvaluateFunction("quaternionProduct", q1, q2);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the quaternionProduct
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
    public MWArray[] quaternionProduct(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionProduct", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the quaternionProduct
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
    public MWArray[] quaternionProduct(int numArgsOut, MWArray q1)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionProduct", q1);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the quaternionProduct
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
    public MWArray[] quaternionProduct(int numArgsOut, MWArray q1, MWArray q2)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionProduct", q1, q2);
    }


    /// <summary>
    /// Provides an interface for the quaternionProduct function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// x = q1(2) * q2(1)  + q1(3) * q2(4) - q1(4) * q2(3) + q1(1) * q2(2);
    /// y = -q1(2) * q2(4) + q1(3) * q2(1) + q1(4) * q2(2) + q1(1) * q2(3);
    /// z = q1(2) * q2(3)  - q1(3) * q2(2) + q1(4) * q2(1) + q1(1) * q2(4);
    /// s = -q1(2) * q2(2) - q1(3) * q2(3) - q1(4) * q2(4) + q1(1) * q2(1);
    /// q=[s,x,y,z];</remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void quaternionProduct(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("quaternionProduct", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the quaternionQuTEMSampling
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// s1=s2=s3 =>uniform Sampling
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray quaternionQuTEMSampling()
    {
      return mcr.EvaluateFunction("quaternionQuTEMSampling", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the quaternionQuTEMSampling
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// s1=s2=s3 =>uniform Sampling
    /// </remarks>
    /// <param name="m">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray quaternionQuTEMSampling(MWArray m)
    {
      return mcr.EvaluateFunction("quaternionQuTEMSampling", m);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the quaternionQuTEMSampling
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// s1=s2=s3 =>uniform Sampling
    /// </remarks>
    /// <param name="m">Input argument #1</param>
    /// <param name="pg">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray quaternionQuTEMSampling(MWArray m, MWArray pg)
    {
      return mcr.EvaluateFunction("quaternionQuTEMSampling", m, pg);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the quaternionQuTEMSampling
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// s1=s2=s3 =>uniform Sampling
    /// </remarks>
    /// <param name="m">Input argument #1</param>
    /// <param name="pg">Input argument #2</param>
    /// <param name="samples">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray quaternionQuTEMSampling(MWArray m, MWArray pg, MWArray samples)
    {
      return mcr.EvaluateFunction("quaternionQuTEMSampling", m, pg, samples);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the quaternionQuTEMSampling
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
    public MWArray[] quaternionQuTEMSampling(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionQuTEMSampling", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the quaternionQuTEMSampling
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
    public MWArray[] quaternionQuTEMSampling(int numArgsOut, MWArray m)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionQuTEMSampling", m);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the quaternionQuTEMSampling
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
    public MWArray[] quaternionQuTEMSampling(int numArgsOut, MWArray m, MWArray pg)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionQuTEMSampling", m, pg);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the quaternionQuTEMSampling
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
    public MWArray[] quaternionQuTEMSampling(int numArgsOut, MWArray m, MWArray pg, 
                                       MWArray samples)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionQuTEMSampling", m, pg, samples);
    }


    /// <summary>
    /// Provides an interface for the quaternionQuTEMSampling function in which the input
    /// and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// s1=s2=s3 =>uniform Sampling
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void quaternionQuTEMSampling(int numArgsOut, ref MWArray[] argsOut, MWArray[] 
                              argsIn)
    {
      mcr.EvaluateFunction("quaternionQuTEMSampling", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the quaternionRotation
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Create vector of quaternion point
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray quaternionRotation()
    {
      return mcr.EvaluateFunction("quaternionRotation", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the quaternionRotation
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Create vector of quaternion point
    /// </remarks>
    /// <param name="vector">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray quaternionRotation(MWArray vector)
    {
      return mcr.EvaluateFunction("quaternionRotation", vector);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the quaternionRotation
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Create vector of quaternion point
    /// </remarks>
    /// <param name="vector">Input argument #1</param>
    /// <param name="quaternion">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray quaternionRotation(MWArray vector, MWArray quaternion)
    {
      return mcr.EvaluateFunction("quaternionRotation", vector, quaternion);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the quaternionRotation
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
    public MWArray[] quaternionRotation(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionRotation", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the quaternionRotation
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
    public MWArray[] quaternionRotation(int numArgsOut, MWArray vector)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionRotation", vector);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the quaternionRotation
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
    public MWArray[] quaternionRotation(int numArgsOut, MWArray vector, MWArray 
                                  quaternion)
    {
      return mcr.EvaluateFunction(numArgsOut, "quaternionRotation", vector, quaternion);
    }


    /// <summary>
    /// Provides an interface for the quaternionRotation function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Create vector of quaternion point
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void quaternionRotation(int numArgsOut, ref MWArray[] argsOut, MWArray[] 
                         argsIn)
    {
      mcr.EvaluateFunction("quaternionRotation", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the remostrejar M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// r
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray remostrejar()
    {
      return mcr.EvaluateFunction("remostrejar", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the remostrejar M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// r
    /// </remarks>
    /// <param name="particles">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray remostrejar(MWArray particles)
    {
      return mcr.EvaluateFunction("remostrejar", particles);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the remostrejar M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// r
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] remostrejar(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "remostrejar", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the remostrejar M-function.
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
    public MWArray[] remostrejar(int numArgsOut, MWArray particles)
    {
      return mcr.EvaluateFunction(numArgsOut, "remostrejar", particles);
    }


    /// <summary>
    /// Provides an interface for the remostrejar function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// r
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void remostrejar(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("remostrejar", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the S_Touch M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos 
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray S_Touch()
    {
      return mcr.EvaluateFunction("S_Touch", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the S_Touch M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos 
    /// </remarks>
    /// <param name="chain">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray S_Touch(MWArray chain)
    {
      return mcr.EvaluateFunction("S_Touch", chain);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the S_Touch M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos 
    /// </remarks>
    /// <param name="chain">Input argument #1</param>
    /// <param name="S">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray S_Touch(MWArray chain, MWArray S)
    {
      return mcr.EvaluateFunction("S_Touch", chain, S);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the S_Touch M-function.
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
    public MWArray[] S_Touch(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "S_Touch", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the S_Touch M-function.
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
    public MWArray[] S_Touch(int numArgsOut, MWArray chain)
    {
      return mcr.EvaluateFunction(numArgsOut, "S_Touch", chain);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the S_Touch M-function.
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
    public MWArray[] S_Touch(int numArgsOut, MWArray chain, MWArray S)
    {
      return mcr.EvaluateFunction(numArgsOut, "S_Touch", chain, S);
    }


    /// <summary>
    /// Provides an interface for the S_Touch function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// S: 
    /// S = [O1 O2 ... Ok]
    /// Ok.ptos: lista de puntos 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void S_Touch(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("S_Touch", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the setGaussianParameters
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray setGaussianParameters()
    {
      return mcr.EvaluateFunction("setGaussianParameters", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the setGaussianParameters
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="media_gausiana">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray setGaussianParameters(MWArray media_gausiana)
    {
      return mcr.EvaluateFunction("setGaussianParameters", media_gausiana);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the setGaussianParameters
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="media_gausiana">Input argument #1</param>
    /// <param name="rotar_en_x">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray setGaussianParameters(MWArray media_gausiana, MWArray rotar_en_x)
    {
      return mcr.EvaluateFunction("setGaussianParameters", media_gausiana, rotar_en_x);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the setGaussianParameters
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="media_gausiana">Input argument #1</param>
    /// <param name="rotar_en_x">Input argument #2</param>
    /// <param name="rotar_en_y">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray setGaussianParameters(MWArray media_gausiana, MWArray rotar_en_x, 
                                   MWArray rotar_en_y)
    {
      return mcr.EvaluateFunction("setGaussianParameters", media_gausiana, rotar_en_x, rotar_en_y);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the setGaussianParameters
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="media_gausiana">Input argument #1</param>
    /// <param name="rotar_en_x">Input argument #2</param>
    /// <param name="rotar_en_y">Input argument #3</param>
    /// <param name="rotar_en_z">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray setGaussianParameters(MWArray media_gausiana, MWArray rotar_en_x, 
                                   MWArray rotar_en_y, MWArray rotar_en_z)
    {
      return mcr.EvaluateFunction("setGaussianParameters", media_gausiana, rotar_en_x, rotar_en_y, rotar_en_z);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the setGaussianParameters
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] setGaussianParameters(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "setGaussianParameters", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the setGaussianParameters
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="media_gausiana">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] setGaussianParameters(int numArgsOut, MWArray media_gausiana)
    {
      return mcr.EvaluateFunction(numArgsOut, "setGaussianParameters", media_gausiana);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the setGaussianParameters
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
    public MWArray[] setGaussianParameters(int numArgsOut, MWArray media_gausiana, 
                                     MWArray rotar_en_x)
    {
      return mcr.EvaluateFunction(numArgsOut, "setGaussianParameters", media_gausiana, rotar_en_x);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the setGaussianParameters
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
    public MWArray[] setGaussianParameters(int numArgsOut, MWArray media_gausiana, 
                                     MWArray rotar_en_x, MWArray rotar_en_y)
    {
      return mcr.EvaluateFunction(numArgsOut, "setGaussianParameters", media_gausiana, rotar_en_x, rotar_en_y);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the setGaussianParameters
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
    public MWArray[] setGaussianParameters(int numArgsOut, MWArray media_gausiana, 
                                     MWArray rotar_en_x, MWArray rotar_en_y, MWArray 
                                     rotar_en_z)
    {
      return mcr.EvaluateFunction(numArgsOut, "setGaussianParameters", media_gausiana, rotar_en_x, rotar_en_y, rotar_en_z);
    }


    /// <summary>
    /// Provides an interface for the setGaussianParameters function in which the input
    /// and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void setGaussianParameters(int numArgsOut, ref MWArray[] argsOut, MWArray[] 
                            argsIn)
    {
      mcr.EvaluateFunction("setGaussianParameters", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the weightFunction
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// euclideanDistance
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray weightFunction()
    {
      return mcr.EvaluateFunction("weightFunction", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the weightFunction
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// euclideanDistance
    /// </remarks>
    /// <param name="chain">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray weightFunction(MWArray chain)
    {
      return mcr.EvaluateFunction("weightFunction", chain);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the weightFunction
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// euclideanDistance
    /// </remarks>
    /// <param name="chain">Input argument #1</param>
    /// <param name="goal">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray weightFunction(MWArray chain, MWArray goal)
    {
      return mcr.EvaluateFunction("weightFunction", chain, goal);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the weightFunction
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// euclideanDistance
    /// </remarks>
    /// <param name="chain">Input argument #1</param>
    /// <param name="goal">Input argument #2</param>
    /// <param name="S">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray weightFunction(MWArray chain, MWArray goal, MWArray S)
    {
      return mcr.EvaluateFunction("weightFunction", chain, goal, S);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the weightFunction M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// euclideanDistance
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] weightFunction(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "weightFunction", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the weightFunction M-function.
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
    public MWArray[] weightFunction(int numArgsOut, MWArray chain)
    {
      return mcr.EvaluateFunction(numArgsOut, "weightFunction", chain);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the weightFunction M-function.
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
    public MWArray[] weightFunction(int numArgsOut, MWArray chain, MWArray goal)
    {
      return mcr.EvaluateFunction(numArgsOut, "weightFunction", chain, goal);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the weightFunction M-function.
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
    public MWArray[] weightFunction(int numArgsOut, MWArray chain, MWArray goal, MWArray 
                              S)
    {
      return mcr.EvaluateFunction(numArgsOut, "weightFunction", chain, goal, S);
    }


    /// <summary>
    /// Provides an interface for the weightFunction function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// euclideanDistance
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void weightFunction(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("weightFunction", numArgsOut, ref argsOut, argsIn);
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
