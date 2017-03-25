/*
* MATLAB Compiler: 4.14 (R2010b)
* Date: Mon Oct 31 16:38:51 2011
* Arguments: "-B" "macro_default" "-W" "dotnet:Normrand,MATLAB_NormalRandom,0.0,private"
* "-T" "link:lib" "-d" "C:\Users\Alejandro\Desktop\Normrand\Normrand\src" "-w"
* "enable:specified_file_mismatch" "-w" "enable:repeated_file" "-w"
* "enable:switch_ignored" "-w" "enable:missing_lib_sentinel" "-w" "enable:demo_license"
* "-v" "class{MATLAB_NormalRandom:C:\Users\Alejandro\Desktop\Normrand\Normrand.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace Normrand
{
  /// <summary>
  /// The MATLAB_NormalRandom class provides a CLS compliant, MWArray interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// C:\Users\Alejandro\Desktop\Normrand\Normrand.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class MATLAB_NormalRandom : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static MATLAB_NormalRandom()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = "Normrand.ctf";

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
    /// Constructs a new instance of the MATLAB_NormalRandom class.
    /// </summary>
    public MATLAB_NormalRandom()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~MATLAB_NormalRandom()
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
    /// Provides a single output, 0-input MWArrayinterface to the Normrand M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Normrand()
    {
      return mcr.EvaluateFunction("Normrand", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the Normrand M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="mu">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Normrand(MWArray mu)
    {
      return mcr.EvaluateFunction("Normrand", mu);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the Normrand M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="mu">Input argument #1</param>
    /// <param name="sigma">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Normrand(MWArray mu, MWArray sigma)
    {
      return mcr.EvaluateFunction("Normrand", mu, sigma);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the Normrand M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="mu">Input argument #1</param>
    /// <param name="sigma">Input argument #2</param>
    /// <param name="n">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Normrand(MWArray mu, MWArray sigma, MWArray n)
    {
      return mcr.EvaluateFunction("Normrand", mu, sigma, n);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the Normrand M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="mu">Input argument #1</param>
    /// <param name="sigma">Input argument #2</param>
    /// <param name="n">Input argument #3</param>
    /// <param name="m">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Normrand(MWArray mu, MWArray sigma, MWArray n, MWArray m)
    {
      return mcr.EvaluateFunction("Normrand", mu, sigma, n, m);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the Normrand M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Normrand(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "Normrand", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the Normrand M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="mu">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Normrand(int numArgsOut, MWArray mu)
    {
      return mcr.EvaluateFunction(numArgsOut, "Normrand", mu);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the Normrand M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="mu">Input argument #1</param>
    /// <param name="sigma">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Normrand(int numArgsOut, MWArray mu, MWArray sigma)
    {
      return mcr.EvaluateFunction(numArgsOut, "Normrand", mu, sigma);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the Normrand M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="mu">Input argument #1</param>
    /// <param name="sigma">Input argument #2</param>
    /// <param name="n">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Normrand(int numArgsOut, MWArray mu, MWArray sigma, MWArray n)
    {
      return mcr.EvaluateFunction(numArgsOut, "Normrand", mu, sigma, n);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the Normrand M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="mu">Input argument #1</param>
    /// <param name="sigma">Input argument #2</param>
    /// <param name="n">Input argument #3</param>
    /// <param name="m">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Normrand(int numArgsOut, MWArray mu, MWArray sigma, MWArray n, 
                        MWArray m)
    {
      return mcr.EvaluateFunction(numArgsOut, "Normrand", mu, sigma, n, m);
    }


    /// <summary>
    /// Provides an interface for the Normrand function in which the input and output
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
    public void Normrand(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("Normrand", numArgsOut, ref argsOut, argsIn);
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
