using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>

        delegate void D();

        [STAThread]
        static void Main()
        {
            MainEditor me;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            me = new MainEditor();
            Thread t = new Thread(() => Application.Run(me));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            D redraw = () => me.ReDraw();
            D update = () => me.Update();

            Thread.Sleep(3000);
            try
            {
                while (true)
                {
                    //todo: 60frame
                    me.Invoke((Delegate)(redraw));
                    me.Invoke((Delegate)(update));
                    Thread.Sleep(20);
                }
            }
            catch (ObjectDisposedException)
            {
                return;
            }
            catch (InvalidOperationException) {

            }
        }
    }
}
