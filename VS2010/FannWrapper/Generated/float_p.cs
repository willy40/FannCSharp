//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class float_p : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal float_p(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(float_p obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~float_p() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FannWrapperPINVOKE.delete_float_p(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public float_p() : this(FannWrapperPINVOKE.new_float_p(), true) {
  }

  public void assign(float value) {
    FannWrapperPINVOKE.float_p_assign(swigCPtr, value);
  }

  public float value() {
    float ret = FannWrapperPINVOKE.float_p_value(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_float cast() {
    global::System.IntPtr cPtr = FannWrapperPINVOKE.float_p_cast(swigCPtr);
    SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
    return ret;
  }

  public static float_p frompointer(SWIGTYPE_p_float t) {
    global::System.IntPtr cPtr = FannWrapperPINVOKE.float_p_frompointer(SWIGTYPE_p_float.getCPtr(t));
    float_p ret = (cPtr == global::System.IntPtr.Zero) ? null : new float_p(cPtr, false);
    return ret;
  }

}