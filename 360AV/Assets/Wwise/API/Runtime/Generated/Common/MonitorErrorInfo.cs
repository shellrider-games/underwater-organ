#if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class MonitorErrorInfo : global::System.IDisposable {
  private global::System.IntPtr swigCPtr;
  protected bool swigCMemOwn;

  internal MonitorErrorInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  internal static global::System.IntPtr getCPtr(MonitorErrorInfo obj) {
    return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;
  }

  internal virtual void setCPtr(global::System.IntPtr cPtr) {
    Dispose();
    swigCPtr = cPtr;
  }

  ~MonitorErrorInfo() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkSoundEnginePINVOKE.CSharp_delete_MonitorErrorInfo(swigCPtr);
        }
        swigCPtr = global::System.IntPtr.Zero;
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public MonitorErrorInfo(string in_name, string in_message) : this(AkSoundEnginePINVOKE.CSharp_new_MonitorErrorInfo__SWIG_0(in_name, in_message), true) {
  }

  public MonitorErrorInfo(string in_name) : this(AkSoundEnginePINVOKE.CSharp_new_MonitorErrorInfo__SWIG_1(in_name), true) {
  }

  public MonitorErrorInfo() : this(AkSoundEnginePINVOKE.CSharp_new_MonitorErrorInfo__SWIG_2(), true) {
  }

  public string m_name { set { AkSoundEnginePINVOKE.CSharp_MonitorErrorInfo_m_name_set(swigCPtr, value); }  get { return AkSoundEngine.StringFromIntPtrOSString(AkSoundEnginePINVOKE.CSharp_MonitorErrorInfo_m_name_get(swigCPtr)); } 
  }

  public string m_message { set { AkSoundEnginePINVOKE.CSharp_MonitorErrorInfo_m_message_set(swigCPtr, value); }  get { return AkSoundEngine.StringFromIntPtrOSString(AkSoundEnginePINVOKE.CSharp_MonitorErrorInfo_m_message_get(swigCPtr)); } 
  }

}
#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.