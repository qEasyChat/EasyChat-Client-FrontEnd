//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


class easy_chat_utils_apiPINVOKE {

  protected class SWIGExceptionHelper {

    public delegate void ExceptionDelegate(string message);
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="SWIGRegisterExceptionCallbacks_easy_chat_utils_api")]
    public static extern void SWIGRegisterExceptionCallbacks_easy_chat_utils_api(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_easy_chat_utils_api")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_easy_chat_utils_api(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new global::System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new global::System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new global::System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new global::System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new global::System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new global::System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new global::System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new global::System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new global::System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new global::System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new global::System.SystemException(message, SWIGPendingException.Retrieve()));
    }

    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new global::System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArgumentNullException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentNullException(paramName, message));
    }
    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_easy_chat_utils_api(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_easy_chat_utils_api(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [global::System.ThreadStatic]
    private static global::System.Exception pendingException = null;
    private static int numExceptionsPending = 0;
    private static global::System.Object exceptionsLock = null;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(global::System.Exception e) {
      if (pendingException != null)
        throw new global::System.ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(exceptionsLock) {
        numExceptionsPending++;
      }
    }

    public static global::System.Exception Retrieve() {
      global::System.Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(exceptionsLock) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }

    static SWIGPendingException() {
      exceptionsLock = new global::System.Object();
    }
  }


  protected class SWIGStringHelper {

    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="SWIGRegisterStringCallback_easy_chat_utils_api")]
    public static extern void SWIGRegisterStringCallback_easy_chat_utils_api(SWIGStringDelegate stringDelegate);

    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_easy_chat_utils_api(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static easy_chat_utils_apiPINVOKE() {
  }


  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_BUFFER_SIZE_get")]
  public static extern int BUFFER_SIZE_get();

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_SIZE_BYTES_get")]
  public static extern int SIZE_BYTES_get();

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_new_Client_Down_Exception")]
  public static extern global::System.IntPtr new_Client_Down_Exception();

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_delete_Client_Down_Exception")]
  public static extern void delete_Client_Down_Exception(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_new_Bad_Socket_Exception")]
  public static extern global::System.IntPtr new_Bad_Socket_Exception();

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_delete_Bad_Socket_Exception")]
  public static extern void delete_Bad_Socket_Exception(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_new_Socket_Error_Exception")]
  public static extern global::System.IntPtr new_Socket_Error_Exception();

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_delete_Socket_Error_Exception")]
  public static extern void delete_Socket_Error_Exception(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_new_Connection__SWIG_0")]
  public static extern global::System.IntPtr new_Connection__SWIG_0(int jarg1, string jarg2, string jarg3);

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_new_Connection__SWIG_1")]
  public static extern global::System.IntPtr new_Connection__SWIG_1(int jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_new_Connection__SWIG_2")]
  public static extern global::System.IntPtr new_Connection__SWIG_2(int jarg1);

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_new_Connection__SWIG_3")]
  public static extern global::System.IntPtr new_Connection__SWIG_3();

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_delete_Connection")]
  public static extern void delete_Connection(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_Connection_get_fixed_length_size")]
  public static extern string Connection_get_fixed_length_size(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_Connection_send_message")]
  public static extern void Connection_send_message(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_Connection_recive_message")]
  public static extern string Connection_recive_message(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_Connection_get_socket")]
  public static extern global::System.IntPtr Connection_get_socket(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_Connection_set_socket")]
  public static extern void Connection_set_socket(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_Connection_get_port_number")]
  public static extern int Connection_get_port_number(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_Connection_set_port_number")]
  public static extern void Connection_set_port_number(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_Connection_get_username")]
  public static extern string Connection_get_username(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_Connection_set_username")]
  public static extern void Connection_set_username(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_Connection_get_ip")]
  public static extern string Connection_get_ip(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_Connection_set_ip")]
  public static extern void Connection_set_ip(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_new_Connection_Message_Not_Sent_Exception")]
  public static extern global::System.IntPtr new_Connection_Message_Not_Sent_Exception();

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_delete_Connection_Message_Not_Sent_Exception")]
  public static extern void delete_Connection_Message_Not_Sent_Exception(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_new_Crypto_Manager")]
  public static extern global::System.IntPtr new_Crypto_Manager();

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_Crypto_Manager_get_sha3_512_hash")]
  public static extern string Crypto_Manager_get_sha3_512_hash(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_Crypto_Manager_rsa_decrypt")]
  public static extern string Crypto_Manager_rsa_decrypt(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_Crypto_Manager_rsa_encrypt")]
  public static extern global::System.IntPtr Crypto_Manager_rsa_encrypt(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("easy_chat_utils_api", EntryPoint="CSharp_delete_Crypto_Manager")]
  public static extern void delete_Crypto_Manager(global::System.Runtime.InteropServices.HandleRef jarg1);
}
