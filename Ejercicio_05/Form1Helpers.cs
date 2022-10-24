using System.Windows.Forms;

namespace Ejercicio_05
{
    internal static class Form1Helpers
    {

        public static DialogResult Show(
                                        string text,
                                        string caption,
                                        MessageBoxButtons buttons,
                                        MessageBoxIcon icon,
                                        MessageBoxDefaultButton defaultButton
         );
    }
}