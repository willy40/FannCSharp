//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------
/*
 * Title: FANN C# IntAccessor
 */
using FannWrapperFixed;
namespace FANNCSharp
{
    /* Class: IntAccessor
       
       Provides fast access to an array of ints
    */
    public class IntAccessor : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal IntAccessor(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IntAccessor obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~IntAccessor()
        {
            Dispose();
        }
        /* Method: Dispose
        
            Destructs the accessor. Must be called manually.
        */
        public virtual void Dispose()
        {
            lock (this)
            {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        fannfixedPINVOKE.delete_IntAccessor(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }
        /* Method: Get
           Parameters:
                      index - The index of the element to return
   
            Return:
                 An int at index
        */
        public int Get(int index)
        {
            int ret = fannfixedPINVOKE.IntAccessor_Get(swigCPtr, index);
            return ret;
        }

        internal static IntAccessor FromPointer(SWIGTYPE_p_int t)
        {
            global::System.IntPtr cPtr = fannfixedPINVOKE.IntAccessor_FromPointer(SWIGTYPE_p_int.getCPtr(t));
            IntAccessor ret = (cPtr == global::System.IntPtr.Zero) ? null : new IntAccessor(cPtr, false);
            return ret;
        }
    }
}
