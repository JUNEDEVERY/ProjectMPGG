using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proba
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Autorization());
                DebugAndTrace.testing(PosleVHODA.login, PosleRegistracii.Surname, PosleRegistracii.Name1, PosleRegistracii.Patronymic, PosleRegistracii.Login1, BuyTools.buy, Nomenklatura_add.add);
            }
            catch
            {
                MessageBox.Show("В программе возникла ошибка, из-за чего она будет заввершена");
            }
}
        
    }
}
