/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace ImagePackageGenerator.swig {

unsafe partial class Layer : ReferenceObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal Layer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PSDParserPINVOKE.Layer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Layer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public System.IntPtr GetData() { return PSDParserPINVOKE.Layer_GetData(swigCPtr); }

  public Rect GetRect() {
    Rect ret = new Rect(PSDParserPINVOKE.Layer_GetRect(swigCPtr), true);
    return ret;
  }

  public string GetName() {
    string ret = System.Runtime.InteropServices.Marshal.PtrToStringUni(PSDParserPINVOKE.Layer_GetName(swigCPtr));
    return ret;
  }

  public uint GetSrtideLength() {
    uint ret = PSDParserPINVOKE.Layer_GetSrtideLength(swigCPtr);
    return ret;
  }

}

}