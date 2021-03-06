//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Crypto_Manager : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Crypto_Manager(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Crypto_Manager obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Crypto_Manager() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          easy_chat_utils_apiPINVOKE.delete_Crypto_Manager(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Crypto_Manager() : this(easy_chat_utils_apiPINVOKE.new_Crypto_Manager(), true) {
  }

  public string get_sha3_512_hash(string message) {
    string ret = easy_chat_utils_apiPINVOKE.Crypto_Manager_get_sha3_512_hash(swigCPtr, message);
    if (easy_chat_utils_apiPINVOKE.SWIGPendingException.Pending) throw easy_chat_utils_apiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string rsa_decrypt(SWIGTYPE_p_std__vectorT_double_t encrypted_message) {
    string ret = easy_chat_utils_apiPINVOKE.Crypto_Manager_rsa_decrypt(swigCPtr, SWIGTYPE_p_std__vectorT_double_t.getCPtr(encrypted_message));
    if (easy_chat_utils_apiPINVOKE.SWIGPendingException.Pending) throw easy_chat_utils_apiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_double_t rsa_encrypt(string message) {
    SWIGTYPE_p_std__vectorT_double_t ret = new SWIGTYPE_p_std__vectorT_double_t(easy_chat_utils_apiPINVOKE.Crypto_Manager_rsa_encrypt(swigCPtr, message), true);
    if (easy_chat_utils_apiPINVOKE.SWIGPendingException.Pending) throw easy_chat_utils_apiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
