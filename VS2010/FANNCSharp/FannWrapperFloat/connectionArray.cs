//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

using FannWrapper;
namespace FannWrapperFloat {

public class connectionArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal connectionArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(connectionArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~connectionArray() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fannfloatPINVOKE.delete_connectionArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public connectionArray(int nelements) : this(fannfloatPINVOKE.new_connectionArray(nelements), true) {
  }

  public connection getitem(int index) {
    connection ret = new connection(fannfloatPINVOKE.connectionArray_getitem(swigCPtr, index), true);
    return ret;
  }

  public void setitem(int index, connection value) {
    fannfloatPINVOKE.connectionArray_setitem(swigCPtr, index, connection.getCPtr(value));
    if (fannfloatPINVOKE.SWIGPendingException.Pending) throw fannfloatPINVOKE.SWIGPendingException.Retrieve();
  }

  public connection cast() {
    global::System.IntPtr cPtr = fannfloatPINVOKE.connectionArray_cast(swigCPtr);
    connection ret = (cPtr == global::System.IntPtr.Zero) ? null : new connection(cPtr, false);
    return ret;
  }

  public static connectionArray frompointer(connection t) {
    global::System.IntPtr cPtr = fannfloatPINVOKE.connectionArray_frompointer(connection.getCPtr(t));
    connectionArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new connectionArray(cPtr, false);
    return ret;
  }

}

}
