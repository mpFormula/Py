using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TestAcro
{

	public class clsWindowMessaging : System.Windows.Forms.NativeWindow, IDisposable
	{
    private bool disposed = false;

    private MainForm MyMainFormLocal;

    public const int WM_COPYDATA = 0x4A;
    public struct COPYDATASTRUCT
    {
      public IntPtr dwData;
      public int cbData;
      [MarshalAs(UnmanagedType.LPStr)]
      public string lpData;
    }

    protected override void WndProc(ref Message m)
		{
        if (m.Msg == WM_COPYDATA)
      {
        COPYDATASTRUCT mystr = new COPYDATASTRUCT();
        Type mytype = mystr.GetType();
        mystr = (COPYDATASTRUCT)m.GetLParam(mytype);
        string MyString = mystr.lpData;
        MyMainFormLocal.UpdateDocument(MyString);
      }
			base.WndProc(ref m);
		}


    public clsWindowMessaging(MainForm MyMainForm, string PDFHELPVIEWER_WINDOWTITLE)
		{
      MyMainFormLocal = MyMainForm;
			CreateParams Params  = new CreateParams();
      Params.Caption = PDFHELPVIEWER_WINDOWTITLE;
			this.CreateHandle(Params);
		}


		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}


		private void Dispose(bool disposing)
		{
      if (!this.disposed)
      {
        if (disposing)
        {
        }
        if (!this.Handle.Equals(IntPtr.Zero))
        {
          this.ReleaseHandle();
        }
      }
      disposed = true;         
		}


		~clsWindowMessaging()
		{
			Dispose(false);
		}
  }  //class clsWindowMessaging


//
//
//  class Program
//  {
//		[STAThread]
//    static void Main(string[] args)
//    {
//      if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();
//      Application.EnableVisualStyles();
//      
//	  	string directory = Application.ExecutablePath;
//		directory = directory + "\\..\\..\\..\\..\\..\\..\\..\\mpFormula40\\";
//		string RootDir = directory;
//      
//      Application.Run(new MainForm(args, RootDir));
//		}
//    [System.Runtime.InteropServices.DllImport("user32.dll")]
//    private static extern bool SetProcessDPIAware();

    
//	}  // class Program

}  // namespace PDFHelpViewer